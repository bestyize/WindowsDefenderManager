using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace WindowsDefenderManager
{
    public partial class WD : Form
    {
        public WD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHealthOpen_Click(object sender, EventArgs e)
        {
            //开启安全健康服务
            RegistryKey key1 = Registry.LocalMachine;
            RegistryKey software1 = key1.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SecurityHealthService", true);
            software1.SetValue("Start", 2);
            string GetValue1 = software1.GetValue("Start").ToString();
            if (GetValue1 == "2"){
                MessageBox.Show("开启安全健康服务成功，重启后生效");
               
            }
            else
            {
                MessageBox.Show("失败，请以管理员权限运行");
            }
        }

        private void btnHealthClose_Click(object sender, EventArgs e)
        {
            //关闭安全健康服务
            RegistryKey key1 = Registry.LocalMachine;
            RegistryKey software1 = key1.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SecurityHealthService", true);
            software1.SetValue("Start", 4);
            string GetValue1 = software1.GetValue("Start").ToString();
            if (GetValue1 == "4"){
                MessageBox.Show("关闭安全健康服务成功！重启生效");
            }
            else { 
                MessageBox.Show("失败，请以管理员权限运行"); 
            }
        }

        private void btnServiceOpen_Click(object sender, EventArgs e)
        {
            //开启window Defender安全中心服务
            RegistryKey key2 = Registry.LocalMachine;
            RegistryKey software2 = key2.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wscsvc", true);
            software2.SetValue("Start", 2);
            string GetValue2 = software2.GetValue("Start").ToString();
            if (GetValue2 == "2")
            {
                MessageBox.Show("开启成功！重启生效");
            }
            else
            {
                MessageBox.Show("失败，请以管理员权限运行");
            }
        }

        private void btnServiceClose_Click(object sender, EventArgs e)
        {
            //关闭window Defender安全中心服务
            RegistryKey key2 = Registry.LocalMachine;
            RegistryKey software2 = key2.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wscsvc", true);
            software2.SetValue("Start", 4);
            string GetValue2 = software2.GetValue("Start").ToString();
            if (GetValue2 == "4")
            {
                MessageBox.Show("关闭成功！重启生效");
            }
            else
            {
                MessageBox.Show("失败，请以管理员权限运行");
            }
        }

        private void openSourceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bestyize/WindowsDefenderManager");
        }
    }
}
