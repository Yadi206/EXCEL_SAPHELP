
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
    class KeyboardHook
    {
        #region (invokestuff)
        [DllImport("kernel32.dll")]
        static extern uint GetCurrentThreadId();
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern IntPtr SetWindowsHookEx(int code, HookProcKeyboard func, IntPtr hInstance, uint threadID);
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern bool UnhookWindowsHookEx(IntPtr hhk);
        /// <summary>
        /// 传递钩子
        /// </summary>
        /// <param name="hhk">是您自己的钩子函数的句柄。用该句柄可以遍历钩子链</param>
        /// <param name="nCode">把传入的参数简单传给CallNextHookEx即可</param>
        /// <param name="wParam">把传入的参数简单传给CallNextHookEx即可</param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string name);
        #endregion

        #region constans
        private const int WH_KEYBOARD = 2;
        private const int HC_ACTION = 0;
        public const int idHook = 13;/// 底层的钩子变量
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


        delegate int HookProcKeyboard(int code, IntPtr wParam, IntPtr lParam);
        private HookProcKeyboard KeyboardProcDelegate = null;
        private IntPtr khook;
        bool doing = false;

        /// <summary>
        /// 返回数据委托
        /// </summary>
        /// <param name="Key"></param>
        public delegate void _RetKey(string Key);
        /// <summary>
        /// 返回按下的键盘数据
        /// </summary>
        public _RetKey RteKey;

        public void InitHook()
        {
            uint id = GetCurrentThreadId();
            //init the keyboard hook with the thread id of the Visual Studio IDE   
            this.KeyboardProcDelegate = new HookProcKeyboard(this.KeyboardProc);//声明一个托管钩子
            khook = SetWindowsHookEx(WH_KEYBOARD, this.KeyboardProcDelegate, IntPtr.Zero, id);
        }

        public void UnHook()
        {
            if (khook != IntPtr.Zero)
            {
                UnhookWindowsHookEx(khook);
            }
        }

        private int KeyboardProc(int code, IntPtr wParam, IntPtr lParam)
        {
            try
            {
                if (code != HC_ACTION)
                {
                    return CallNextHookEx(khook, code, wParam, lParam);
                }

                //if (code > -1)
                //{
                //    KeyMSG keyboardHookStruct = new KeyMSG(); 
                //    switch ((int)wParam)
                //    {
                //        case WM_KEYDOWN://键盘按下操作
                //        case WM_SYSKEYDOWN: 
                //            keyValuePairs.Add(e.KeyData.ToString(), e.KeyValue);
                //            Shun_KeyDown(e);//调用该事件
                //            break;
                //        case WM_KEYUP://键盘松开操作
                //        case WM_SYSKEYUP:
                //            Shun_KeyUp(e);//调用该事件
                //            break;
                //    }
                //}

                if ((int)wParam == (int)Keys.Q && ((int)lParam == 1048577))
                {
                    if (!doing)
                    {
                        doing = true;
                        #region alt + 5
                        try
                        {
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        #endregion
                        doing = false;
                        return 1;
                    }
                }
            }
            catch
            {
            }
            return CallNextHookEx(khook, code, wParam, lParam);
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
    }
}
