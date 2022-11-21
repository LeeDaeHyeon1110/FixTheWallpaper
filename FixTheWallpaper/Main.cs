using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Drawing;

namespace FixTheWallpaper {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void getDefaultWallpaperBtn_Click(object sender, EventArgs e) {
            string defaultPath = @"C:\Windows\Web\Wallpaper\Windows\img0.jpg";
            if (File.Exists(defaultPath)) {
                wallpaperBox.ImageLocation = defaultPath;
            } else {
                MessageBox.Show("기본 바탕화면을 찾는데에 실패 하였습니다..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getDefaultLockScreenBtn_Click(object sender, EventArgs e) {
            string defaultPath = @"C:\Windows\Web\Screen\img100.jpg";
            if (File.Exists(defaultPath)) {
                lockScreenBox.ImageLocation = defaultPath;
            } else {
                MessageBox.Show("기본 잠금화면을 찾는데에 실패 하였습니다", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetStatus() {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\PersonalizationCSP", true);
            if (key != null) {
                string wallpaperPath = key.GetValue(@"DesktopImagePath").ToString();
                if (wallpaperPath != null) {
                    wallpaperBox.ImageLocation = wallpaperPath;
                }

                string lockScreenPath = key.GetValue(@"LockScreenImagePath").ToString();
                if (lockScreenPath != null) {
                    lockScreenBox.ImageLocation = lockScreenPath;
                }
                
                statusLbl.Text = "활성화";
                statusLbl.ForeColor = Color.Green;
            } else {
                statusLbl.Text = "비활성화";
                statusLbl.ForeColor = Color.Red;
            }
        }

        private void fixBtn_Click(object sender, EventArgs e) {
            RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\PersonalizationCSP", true);
            key.SetValue(@"LockScreenImagePath", lockScreenBox.ImageLocation);
            key.SetValue(@"LockScreenImageUrl", lockScreenBox.ImageLocation);
            key.SetValue(@"LockScreenImageStatus", 1, RegistryValueKind.DWord);

            key.SetValue(@"DesktopImagePath", wallpaperBox.ImageLocation);
            key.SetValue(@"DesktopImageUrl", wallpaperBox.ImageLocation);
            key.SetValue(@"DesktopImageStatus", 1, RegistryValueKind.DWord);
            key.Close();

            GetStatus();
        }

        private void unFixBtn_Click(object sender, EventArgs e) {

        }

        private void Main_Load(object sender, EventArgs e) {
            GetStatus();
        }
    }
}
