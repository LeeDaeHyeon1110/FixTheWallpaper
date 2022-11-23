namespace FixTheWallpaper {
    partial class Main {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.wallpaperBox = new System.Windows.Forms.PictureBox();
            this.wallpaperGroup = new System.Windows.Forms.GroupBox();
            this.getDefaultWallpaperBtn = new System.Windows.Forms.Button();
            this.lockScreenGroup = new System.Windows.Forms.GroupBox();
            this.getDefaultLockScreenBtn = new System.Windows.Forms.Button();
            this.lockScreenBox = new System.Windows.Forms.PictureBox();
            this.fixBtn = new System.Windows.Forms.Button();
            this.unFixBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wallpaperBox)).BeginInit();
            this.wallpaperGroup.SuspendLayout();
            this.lockScreenGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockScreenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "\'조직에서 관리됨\'라는 기능을 이용하여 바탕화면을 고정시킵니다";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "바탕화면 바꾸지마!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "현재 상태 :";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.statusLbl.ForeColor = System.Drawing.Color.Red;
            this.statusLbl.Location = new System.Drawing.Point(96, 54);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(65, 19);
            this.statusLbl.TabIndex = 3;
            this.statusLbl.Text = "비활성화";
            // 
            // wallpaperBox
            // 
            this.wallpaperBox.Location = new System.Drawing.Point(9, 22);
            this.wallpaperBox.Name = "wallpaperBox";
            this.wallpaperBox.Size = new System.Drawing.Size(320, 180);
            this.wallpaperBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wallpaperBox.TabIndex = 4;
            this.wallpaperBox.TabStop = false;
            // 
            // wallpaperGroup
            // 
            this.wallpaperGroup.Controls.Add(this.getDefaultWallpaperBtn);
            this.wallpaperGroup.Controls.Add(this.wallpaperBox);
            this.wallpaperGroup.Location = new System.Drawing.Point(12, 83);
            this.wallpaperGroup.Name = "wallpaperGroup";
            this.wallpaperGroup.Size = new System.Drawing.Size(335, 237);
            this.wallpaperGroup.TabIndex = 10;
            this.wallpaperGroup.TabStop = false;
            this.wallpaperGroup.Text = "바탕화면";
            // 
            // getDefaultWallpaperBtn
            // 
            this.getDefaultWallpaperBtn.Location = new System.Drawing.Point(6, 208);
            this.getDefaultWallpaperBtn.Name = "getDefaultWallpaperBtn";
            this.getDefaultWallpaperBtn.Size = new System.Drawing.Size(323, 23);
            this.getDefaultWallpaperBtn.TabIndex = 10;
            this.getDefaultWallpaperBtn.Text = "기본 바탕화면";
            this.getDefaultWallpaperBtn.UseVisualStyleBackColor = true;
            this.getDefaultWallpaperBtn.Click += new System.EventHandler(this.getDefaultWallpaperBtn_Click);
            // 
            // lockScreenGroup
            // 
            this.lockScreenGroup.Controls.Add(this.getDefaultLockScreenBtn);
            this.lockScreenGroup.Controls.Add(this.lockScreenBox);
            this.lockScreenGroup.Location = new System.Drawing.Point(361, 83);
            this.lockScreenGroup.Name = "lockScreenGroup";
            this.lockScreenGroup.Size = new System.Drawing.Size(335, 237);
            this.lockScreenGroup.TabIndex = 11;
            this.lockScreenGroup.TabStop = false;
            this.lockScreenGroup.Text = "잠금화면";
            // 
            // getDefaultLockScreenBtn
            // 
            this.getDefaultLockScreenBtn.Location = new System.Drawing.Point(6, 208);
            this.getDefaultLockScreenBtn.Name = "getDefaultLockScreenBtn";
            this.getDefaultLockScreenBtn.Size = new System.Drawing.Size(323, 23);
            this.getDefaultLockScreenBtn.TabIndex = 11;
            this.getDefaultLockScreenBtn.Text = "기본 잠금화면";
            this.getDefaultLockScreenBtn.UseVisualStyleBackColor = true;
            this.getDefaultLockScreenBtn.Click += new System.EventHandler(this.getDefaultLockScreenBtn_Click);
            // 
            // lockScreenBox
            // 
            this.lockScreenBox.Location = new System.Drawing.Point(9, 22);
            this.lockScreenBox.Name = "lockScreenBox";
            this.lockScreenBox.Size = new System.Drawing.Size(320, 180);
            this.lockScreenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockScreenBox.TabIndex = 4;
            this.lockScreenBox.TabStop = false;
            // 
            // fixBtn
            // 
            this.fixBtn.Location = new System.Drawing.Point(12, 325);
            this.fixBtn.Name = "fixBtn";
            this.fixBtn.Size = new System.Drawing.Size(684, 23);
            this.fixBtn.TabIndex = 12;
            this.fixBtn.Text = "고정 시키기";
            this.fixBtn.UseVisualStyleBackColor = true;
            this.fixBtn.Click += new System.EventHandler(this.fixBtn_Click);
            // 
            // unFixBtn
            // 
            this.unFixBtn.Location = new System.Drawing.Point(12, 354);
            this.unFixBtn.Name = "unFixBtn";
            this.unFixBtn.Size = new System.Drawing.Size(684, 23);
            this.unFixBtn.TabIndex = 13;
            this.unFixBtn.Text = "고정해제";
            this.unFixBtn.UseVisualStyleBackColor = true;
            this.unFixBtn.Click += new System.EventHandler(this.unFixBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(708, 389);
            this.Controls.Add(this.unFixBtn);
            this.Controls.Add(this.fixBtn);
            this.Controls.Add(this.lockScreenGroup);
            this.Controls.Add(this.wallpaperGroup);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "바탕화면 고정기";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wallpaperBox)).EndInit();
            this.wallpaperGroup.ResumeLayout(false);
            this.lockScreenGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lockScreenBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.PictureBox wallpaperBox;
        private System.Windows.Forms.GroupBox wallpaperGroup;
        private System.Windows.Forms.GroupBox lockScreenGroup;
        private System.Windows.Forms.PictureBox lockScreenBox;
        private System.Windows.Forms.Button fixBtn;
        private System.Windows.Forms.Button unFixBtn;
        private System.Windows.Forms.Button getDefaultWallpaperBtn;
        private System.Windows.Forms.Button getDefaultLockScreenBtn;
    }
}

