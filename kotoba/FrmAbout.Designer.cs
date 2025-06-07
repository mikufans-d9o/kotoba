namespace kotoba
{
    partial class FrmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            PbLogo = new PictureBox();
            LblAppName = new Label();
            LblIntro = new Label();
            LlWebsite = new LinkLabel();
            BtnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            SuspendLayout();
            // 
            // PbLogo
            // 
            PbLogo.Image = (Image)resources.GetObject("PbLogo.Image");
            PbLogo.Location = new Point(98, 31);
            PbLogo.Name = "PbLogo";
            PbLogo.Size = new Size(50, 50);
            PbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PbLogo.TabIndex = 0;
            PbLogo.TabStop = false;
            // 
            // LblAppName
            // 
            LblAppName.AutoSize = true;
            LblAppName.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            LblAppName.Location = new Point(154, 38);
            LblAppName.Name = "LblAppName";
            LblAppName.Size = new Size(117, 37);
            LblAppName.TabIndex = 1;
            LblAppName.Text = "kotoba";
            // 
            // LblIntro
            // 
            LblIntro.AutoSize = true;
            LblIntro.Location = new Point(28, 124);
            LblIntro.Name = "LblIntro";
            LblIntro.Size = new Size(324, 160);
            LblIntro.TabIndex = 2;
            LblIntro.Text = "一个简洁实用的 Windows 窗体应用，用于通过\r\n导入词库进行词语默写练习，适合日语、英语等\r\n语言学习者使用。\r\n\r\n版本 : 1.0\r\n\r\n\r\nmikufans";
            // 
            // LlWebsite
            // 
            LlWebsite.AutoSize = true;
            LlWebsite.Location = new Point(28, 284);
            LlWebsite.Name = "LlWebsite";
            LlWebsite.Size = new Size(58, 20);
            LlWebsite.TabIndex = 3;
            LlWebsite.TabStop = true;
            LlWebsite.Text = "Github";
            LlWebsite.LinkClicked += linkLabel1_LinkClicked;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(231, 375);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(94, 29);
            BtnOK.TabIndex = 4;
            BtnOK.Text = "确定";
            BtnOK.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnOK;
            ClientSize = new Size(382, 453);
            Controls.Add(BtnOK);
            Controls.Add(LlWebsite);
            Controls.Add(LblIntro);
            Controls.Add(LblAppName);
            Controls.Add(PbLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            ShowIcon = false;
            Text = "关于";
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbLogo;
        private Label LblAppName;
        private Label LblIntro;
        private LinkLabel LlWebsite;
        private Button BtnOK;
    }
}