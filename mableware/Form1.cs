using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mableware
{
    public partial class Form1 : Form
    {
        #region dlls
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration
        #endregion

        public Form1()
        {
            InitializeComponent();
        }


        bool isShifting = false;
        private void LeftClicker_Tick(object sender, EventArgs e)
        {
            LeftClicker.Interval = 1000 / randomisedCPS;

            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (cbToggle.Checked && !isShifting)
                    {
                        if (MouseButtons == MouseButtons.Left)
                        {
                            SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                            Task.Delay(20).Wait();
                            SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                        }
                    }
                }

                if (cbShiftD.Checked)
                {
                    if (GetAsyncKeyState(Keys.LShiftKey) < 0)
                    {
                        isShifting = true;
                    }
                    else
                    {
                        isShifting = false;
                    }
                }
            }

        }


        int randomisedCPS = 10;
        private void Random_Tick(object sender, EventArgs e)
        {
            randomisedCPS = new Random().Next(sldCPS.Value - 3, sldCPS.Value + 3);
        }

        private void btBind_KeyUp(object sender, KeyEventArgs e)
        {
            if (btBind.Text == "...")
            {
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    btBind.Text = "none";
                }
                else
                {
                    btBind.Text = e.KeyCode.ToString();
                }
            }
        }

        private void btBind_Click(object sender, EventArgs e)
        {
            btBind.Text = "...";
        }
        private void sldCPS_Scroll(object sender, ScrollEventArgs e)
        {
            lbCPS.Text = "CPS: " + (sldCPS.Value.ToString());
        }

        public static KeysConverter Key = new KeysConverter();
        private void Bind_Tick(object sender, EventArgs e)
        {
            if (btBind.Text != "none")
            {
                if (btBind.Text != "...")
                {
                    Keys key = (Keys)Key.ConvertFromString(btBind.Text);

                    if (GetAsyncKeyState(key) < 0)
                    {
                        cbToggle.Checked = !cbToggle.Checked;
                    }
                }
            }
        }

        private void lbCPS_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            string message = "mableware v0.2 - made by Kyxles#0001";
            string title = "Clicker Information";
            MessageBox.Show(message, title);
        }
    }
}
