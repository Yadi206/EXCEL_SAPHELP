 
using EXCEL_SAPHELP.WinForm;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCEL_SAPHELP.Com
{
    class KeyboardHook2
    {
        #region 私有变量
        private IntPtr m_pKeyboardHook = IntPtr.Zero;/// 键盘钩子句柄
        private delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);/// 钩子委托声明
        private HookProc m_KeyboardHookProcedure;/// 键盘钩子委托实例
        public const int idHook = 13;/// 底层的钩子变量
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr pInstance, int threadId);/// 安装钩子
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]/// 卸载钩子
        private static extern bool UnhookWindowsHookEx(IntPtr pHookHandle);
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string name);
        /// 传递钩子
        /// <param name="pHookHandle">是您自己的钩子函数的句柄。用该句柄可以遍历钩子链</param>
        /// <param name="nCode">把传入的参数简单传给CallNextHookEx即可</param>
        /// <param name="wParam">把传入的参数简单传给CallNextHookEx即可</param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int CallNextHookEx(IntPtr pHookHandle, int nCode, Int32 wParam, IntPtr lParam);
        [StructLayout(LayoutKind.Sequential)]
        private struct KeyMSG
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }
        protected const int WM_QUERYENDSESSION = 0x0011;
        protected const int WM_KEYDOWN = 0x100;
        protected const int WM_KEYUP = 0x101;
        protected const int WM_SYSKEYDOWN = 0x104;
        protected const int WM_SYSKEYUP = 0x105;
        protected const byte VK_SHIFT = 0x10;
        protected const byte VK_CAPITAL = 0x14;
        protected const byte VK_NUMLOCK = 0x90;
        protected const byte VK_LSHIFT = 0xA0;
        protected const byte VK_RSHIFT = 0xA1;
        protected const int VK_LWIN = 91;
        protected const int VK_RWIN = 92;
        protected const byte VK_LCONTROL = 0xA2;
        protected const byte VK_RCONTROL = 0x3;
        protected const byte VK_LALT = 0xA4;
        protected const byte VK_RALT = 0xA5;
        protected const byte LLKHF_ALTDOWN = 0x20;
        private static int pp = 0;//热键的返回值
        private static bool isInstall = false;//是否安装钩子，true为安装
        #endregion

        #region 事件的声明
        /// <summary>
        /// 返回数据委托
        /// </summary>
        /// <param name="Key"></param>
        public delegate void _RetKey(string Key);
        /// <summary>
        /// 返回按下的键盘数据
        /// </summary>
        public _RetKey RteKey;
        #endregion

        #region 方法
        /// <summary>
        /// 钩子捕获消息后，对消息进行处理
        /// </summary>
        /// <param nCode="int">标识，键盘是否操作</param> 
        /// <param wParam="int">键盘的操作值</param>
        /// <param lParam="IntPtr">指针</param>
        private int KeyboardHookProc(int nCode, int wParam, IntPtr lParam)
        {
            if (nCode > -1)
            {
                KeyMSG keyboardHookStruct = (KeyMSG)Marshal.PtrToStructure(lParam, typeof(KeyMSG));//获取钩子的相关信息
                KeyEventArgs e = new KeyEventArgs((Keys)(keyboardHookStruct.vkCode));//获取KeyEventArgs事件的相磁信息
                switch (wParam)
                {
                    case WM_KEYDOWN://键盘按下操作
                    case WM_SYSKEYDOWN:
                        Shun_KeyDown(e);//调用该事件
                        break;
                    case WM_KEYUP://键盘松开操作
                    case WM_SYSKEYUP:
                        Shun_KeyUp(e);//调用该事件
                        break;
                }
            }
            return pp;//是否屏蔽当前热键，1为屏蔽，2为执行
        }
        /// <summary>
        /// 按下的键码集合
        /// </summary>
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        /// <summary>
        /// 按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Shun_KeyDown(KeyEventArgs e)
        {
            if (!keyValuePairs.ContainsKey(e.KeyData.ToString()))
            {
                if (e.KeyData == Keys.LShiftKey || e.KeyData == Keys.RShiftKey)
                {
                    if (!keyValuePairs.ContainsKey(Keys.Shift.ToString()))
                    {
                        keyValuePairs.Add(Keys.Shift.ToString(), (int)Keys.Shift);
                    }
                }
                else if (e.KeyData == Keys.LControlKey || e.KeyData == Keys.RControlKey)
                {
                    if (!keyValuePairs.ContainsKey(Keys.Control.ToString()))
                    {
                        keyValuePairs.Add(Keys.Control.ToString(), (int)Keys.Control);
                    }
                }
                else if (e.KeyData == Keys.LMenu || e.KeyData == Keys.RMenu)
                {
                    if (!keyValuePairs.ContainsKey(Keys.Alt.ToString()))
                    {
                        keyValuePairs.Add(Keys.Alt.ToString(), (int)Keys.Alt);
                    }
                }
                else
                {
                    keyValuePairs.Add(e.KeyData.ToString(), e.KeyValue);
                }
            }
        }
        /// <summary>
        /// 松开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Shun_KeyUp(KeyEventArgs e)
        {
            List<string> ListData = new List<string>();
            string RetKeyCode = string.Empty;
            var DicSort = from objDic in keyValuePairs orderby objDic.Value descending select objDic;  //倒叙
            //var DicSort = from objDic in keyValuePairs orderby objDic.Value select objDic;  //升序
            foreach (KeyValuePair<string, int> Data in DicSort)
            {
                RetKeyCode += Data.Key + " + ";
                ListData.Add(Data.Key);
            }
            for (int i = 0; i < ListData.Count; i++)
            {
                keyValuePairs.Remove(ListData[i]);
            }
            if (!RetKeyCode.Equals(""))
            {
                RteKey(RetKeyCode.Substring(0, RetKeyCode.Length - 3));
            }
        }
        #endregion

        #region 安装、卸载钩子
        /// <summary>
        /// 安装钩子
        /// </summary>
        /// <returns>是否安装成功</returns>
        public bool Start()
        {

            if (this.m_pKeyboardHook == IntPtr.Zero)//如果键盘的句柄为空
            {
                this.m_KeyboardHookProcedure = new HookProc(KeyboardHookProc);//声明一个托管钩子
                this.m_pKeyboardHook = SetWindowsHookEx(idHook, m_KeyboardHookProcedure, GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);//安装钩子
                if (this.m_pKeyboardHook == IntPtr.Zero)//如果安装失败
                {
                    this.Stop();//卸载钩子
                    return false;
                }
            }
            isInstall = true;//安装了钩子
            return true;
        }
        /// <summary>
        /// 卸载钩子
        /// </summary>
        /// <returns>是否卸载成功</returns>
        public bool Stop()
        {
            if (isInstall == false)//如果没有安装钩子
            {
                return true;
            }
            bool result = true;
            if (this.m_pKeyboardHook != IntPtr.Zero)//如果安装了钩子
            {
                result = (UnhookWindowsHookEx(this.m_pKeyboardHook) && result);//卸载钩子
                this.m_pKeyboardHook = IntPtr.Zero;//清空键盘的钩子句柄
            }
            return result;
        }
        #endregion 公共方法
    } 
}
