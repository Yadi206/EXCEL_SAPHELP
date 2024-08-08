using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using EXCEL_SAPHELP.Com;


public class Hook
{
    #region 定义变量
    //定义鼠标钩子处理函数
    private Win32API.HookProc MouseHookProcedure = null;
    //定义键盘钩子处理函数
    private Win32API.HookProc KeyboardProcDelegate = null;

    //定义键盘钩子句柄
    private IntPtr khook;
    //定义鼠标钩子句柄
    private IntPtr hHook = IntPtr.Zero;

    //定义鼠标事件
    public event MouseEventHandler OnMouseActivity;
    #endregion

    /// <summary>
    /// 安装钩子
    /// </summary>
    public void InstallHook(HookHelper.HookType hookType)
    {
        if (hookType == HookHelper.HookType.KeyOperation)
        {
            if (khook == IntPtr.Zero)//键盘钩子
            {
                uint id = Win32API.GetCurrentThreadId();
                this.KeyboardProcDelegate = new Win32API.HookProc(this.KeyboardProc);
                khook = Win32API.SetWindowsHookEx((int)HookHelper.WH_Codes.WH_KEYBOARD_LL, this.KeyboardProcDelegate, IntPtr.Zero, id);
            }
        }
        else
        {
            if (hHook == IntPtr.Zero)//鼠标钩子
            {
                uint id = Win32API.GetCurrentThreadId();
                this.MouseHookProcedure = new Win32API.HookProc(this.MouseHookProc);
                //这里挂节钩子
                hHook = Win32API.SetWindowsHookEx((int)HookHelper.WH_Codes.WH_MOUSE_LL, MouseHookProcedure, IntPtr.Zero, id);
            }
        }
    }

    /// <summary>
    /// 卸载鼠标钩子
    /// </summary>
    public void UnInstallHook(HookHelper.HookType hookType)
    {
        bool isSuccess = false;
        if (hookType == HookHelper.HookType.KeyOperation)//键盘钩子
        {
            if (khook != IntPtr.Zero)
            {
                isSuccess = Win32API.UnhookWindowsHookEx(khook);
                this.khook = IntPtr.Zero;
            }
        }
        else
        {
            if (this.hHook != IntPtr.Zero)//鼠标钩子
            {
                isSuccess = Win32API.UnhookWindowsHookEx(hHook);
                this.hHook = IntPtr.Zero;
            }
        }
        if (isSuccess)
        {
            MessageBox.Show("卸载成功！");
        }
        else
        {
            MessageBox.Show("卸载失败！");
        }
    }

    /// <summary>
    /// 鼠标钩子处理函数
    /// </summary>
    /// <param name="nCode"></param>
    /// <param name="wParam"></param>
    /// <param name="lParam"></param>
    /// <returns></returns>
    private int MouseHookProc(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode < (int)HookHelper.WH_Codes.HC_ACTION)
        {
            return Win32API.CallNextHookEx(hHook, nCode, wParam, lParam);
        }

        if (OnMouseActivity != null)
        {
            //Marshall the data from callback.
            HookHelper.MouseHookStruct mouseHookStruct = (HookHelper.MouseHookStruct)Marshal.PtrToStructure(lParam, typeof(HookHelper.MouseHookStruct));
            MouseButtons button = MouseButtons.None;
            short mouseDelta = 0;
            switch ((int)wParam)
            {
                case (int)HookHelper.WM_MOUSE.WM_LBUTTONDOWN:
                    //case WM_LBUTTONUP: 
                    //case WM_LBUTTONDBLCLK:
                    button = MouseButtons.Left;
                    break;
                case (int)HookHelper.WM_MOUSE.WM_RBUTTONDOWN:
                    //case WM_RBUTTONUP: 
                    //case WM_RBUTTONDBLCLK: 
                    button = MouseButtons.Right;
                    break;
                case (int)HookHelper.WM_MOUSE.WM_MOUSEWHEEL:
                    //button = MouseButtons.Middle;//滚动轮
                    //(value >> 16) & 0xffff; retrieves the high-order word from the given 32-bit value
                    mouseDelta = (short)((mouseHookStruct.MouseData >> 16) & 0xffff);
                    break;
            }

            int clickCount = 0;//点击数
            if (button != MouseButtons.None)
            {
                if ((int)wParam == (int)HookHelper.WM_MOUSE.WM_LBUTTONDBLCLK || (int)wParam == (int)HookHelper.WM_MOUSE.WM_RBUTTONDBLCLK)
                {
                    clickCount = 2;//双击
                }
                else
                {
                    clickCount = 1;//单击
                }
            }

            //鼠标事件传递数据
            MouseEventArgs e = new MouseEventArgs(button, clickCount, mouseHookStruct.Point.X, mouseHookStruct.Point.Y, mouseDelta);

            //重写事件
            OnMouseActivity(this, e);
        }

        return Win32API.CallNextHookEx(hHook, nCode, wParam, lParam);
    }

    /// <summary>
    /// 键盘钩子处理函数
    /// </summary>
    /// <param name="code"></param>
    /// <param name="wParam"></param>
    /// <param name="lParam"></param>
    /// <returns></returns>
    private int KeyboardProc(int nCode, IntPtr wParam, IntPtr lParam)
    {
        try
        {
            if (nCode < (int)HookHelper.WH_Codes.HC_ACTION)
            {
                return Win32API.CallNextHookEx((IntPtr)khook, nCode, wParam, lParam);
            }

            HookHelper.KeyboardHookStruct keyHookStruct = (HookHelper.KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(HookHelper.KeyboardHookStruct));

            #region
            //if ((int)wParam == (int)Keys.C && ((int)lParam & (int)Keys.ControlKey) != 0 ||//Ctrl+C
            //    (int)wParam == (int)Keys.X && ((int)lParam & (int)Keys.ControlKey) != 0)//Ctrl+V
            //{
            //    MessageBox.Show("C||V");
            //}

            //if (lParam.ToInt32() > 0)//捕获键盘按下
            //{
            //    Keys keys = (Keys)wParam;
            //    MessageBox.Show("键盘按下");
            //}
            //if (lParam.ToInt32() < 0)//捕获键盘抬起
            //{
            //    MessageBox.Show("键盘抬起");
            //}
            /**************** 
             //全局键盘钩子判断是否按下键 
             wParam = = 0x100 // 键盘按下 
             wParam = = 0x101 // 键盘抬起 
            ****************/
            //return 0;//如果返回1,则结束消息,消息截止,不再传递。如果返回0或调用CallNextHookEx函数,消息出这个钩子继续往下传递。
            #endregion

        }
        catch
        {

        }

        return Win32API.CallNextHookEx(khook, nCode, wParam, lParam);
    }
}