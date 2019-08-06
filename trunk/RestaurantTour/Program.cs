using RestaurantTour.Model.DataAccessObject;
using RestaurantTour.View;
using RestaurantTour.View.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RestaurantTour
{
    static class Program
    {
        //用於防止程式多開;//
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private const int WS_SHOWNORMAL = 1;

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Get the running instance.   
            Process instance = RunningInstance();

            if (instance == null)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.DoEvents();

                //開啟資料庫;//
                DaoSQL.Instance.OpenDatabase();

                while (true)
                {
                    DialogResult Ret = DialogResult.Cancel;

                    //Login畫面;//
                    //Ret = ShowLoginForm();
                    //if (Ret != DialogResult.OK)
                    //{
                    //    break;
                    //}

                    //登入成功，顯示主畫面;//
                    FormMain fMain = new FormMain();
                    fMain.BringToFront();
                    Ret = fMain.ShowDialog();

                    //釋放主畫面資源;//
                    fMain.Close();
                    fMain.Dispose();

                    //判斷是否為關閉視窗//
                    if (Ret != DialogResult.Retry)
                        break;
                }

            }
            else
            {
                //There is another instance of this process.
                HandleRunningInstance(instance);
            }

            //強制關閉，避免因thread或是timer尚在啟動，造成程式無法關閉;//
            Environment.Exit(Environment.ExitCode);
        }

        /// <summary>
        /// 顯示Login畫面
        /// </summary>
        /// <returns></returns>
        private static DialogResult ShowLoginForm()
        {
            FormLogin LpsLogin = new FormLogin();
            LpsLogin.BringToFront();

            DialogResult Ret = LpsLogin.ShowDialog();
            LpsLogin.Close();
            LpsLogin.Dispose();

            return Ret;
        }

        public static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            //Loop through the running processes in with the same name
            foreach (Process process in processes)
            {
                //Ignore the current process   
                if (process.Id != current.Id)
                {
                    //Make sure that the process is running from the exe file.
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                    {
                        //Return the other process instance.   
                        return process;
                    }
                }
            }

            //No other instance was found, return null. 
            return null;
        }

        public static void HandleRunningInstance(Process instance)
        {
            //Make sure the window is not minimized or maximized   
            ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL);

            //Set the real intance to foreground window
            SetForegroundWindow(instance.MainWindowHandle);
        }
    }
}
