using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuickIp
{
    public class QuickIpApplicationContext : ApplicationContext
    {
        private NotifyIcon notifyIcon;

        private Timer trayTimer;

        public delegate void MouseInDelegate(object sender, MouseEventArgs e);

        public delegate void MouseOutDelegate();

        public MouseInDelegate mouseInDelegate;
        public MouseOutDelegate mouseOutDelegate;
        public bool BalloonShown;

        public QuickIpApplicationContext()
        {
            MenuItem configMenuItem = new MenuItem("Configuration", new EventHandler(OpenConfig));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = QuickIp.Properties.Resources.ipIcon;
            notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { configMenuItem, exitMenuItem });
            notifyIcon.Visible = true;
            notifyIcon.Click += NotifyIcon_Click;
            notifyIcon.MouseMove += new MouseEventHandler(icon_MouseMove);
            BuildBaloonText();
        }

        private void BuildBaloonText()
        {
            trayTimer = new Timer();
            trayTimer.Interval = 2000;
            trayTimer.Enabled = false;
            trayTimer.Tick += new EventHandler(trayTimer_Tick);
            BalloonShown = false;

            var nicList = NetworkManagement.getNetworkcardDescriptionAndMacAddresses();

            StringBuilder nicInfo = new StringBuilder();
            foreach (var nic in nicList.Keys.ToList())
            {
                nicInfo.AppendLine(nicList[nic]);
                var nicConfig = NetworkManagement.getNetworkInfoBasedOnNIC(nic);
                foreach (var ip in nicConfig["IPAddress"].ToString().Split(','))
                {
                    nicInfo.AppendLine("IP     " + Regex.Replace(ip, @"\s+", ""));
                }
                nicInfo.AppendLine("Subnet " + nicConfig["IPSubnet"].ToString());
                nicInfo.AppendLine("DFGate " + nicConfig["DefaultIPGateway"].ToString());
            }
            notifyIcon.BalloonTipText = nicInfo.ToString();
            notifyIcon.Text = "Network Info";
        }

        private void icon_MouseMove(object sender, MouseEventArgs e)
        {
            trayTimer.Start();
        }

        private void trayTimer_Tick(object sender, EventArgs e)
        {
            if (!WinAPI.GetTrayRectangle().Contains(Cursor.Position))
            {
                trayTimer.Stop();
                BalloonShown = false;
            }
            else
            {
                if (!BalloonShown)
                {
                    notifyIcon.ShowBalloonTip(1000);
                    BalloonShown = true;
                }
            }
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            MenuItem configMenuItem = new MenuItem("Configuration", new EventHandler(OpenConfig));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            var m = new ContextMenu(new MenuItem[] { configMenuItem, exitMenuItem });

            // m.Show(notifyIcon.Container, new System.Drawing.Point(0,0));
            // m.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void Exit(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;  // Hide tray icon, otherwise it will remain shown until user mouses over it
            Application.Exit();
        }

        private void OpenConfig(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
        }
    }
}