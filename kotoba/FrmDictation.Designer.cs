namespace kotoba
{
    partial class FrmDictation
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
            LblMeans = new Label();
            TxtWords = new TextBox();
            BtnCheck = new Button();
            LblResult = new Label();
            SuspendLayout();
            // 
            // LblMeans
            // 
            LblMeans.AutoSize = true;
            LblMeans.Location = new Point(27, 16);
            LblMeans.Name = "LblMeans";
            LblMeans.Size = new Size(79, 20);
            LblMeans.TabIndex = 0;
            LblMeans.Text = "LblMeans";
            // 
            // TxtWords
            // 
            TxtWords.Location = new Point(27, 39);
            TxtWords.Name = "TxtWords";
            TxtWords.Size = new Size(166, 27);
            TxtWords.TabIndex = 1;
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(27, 72);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(94, 29);
            BtnCheck.TabIndex = 2;
            BtnCheck.Text = "核对";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += btnCheck_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(27, 104);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(76, 20);
            LblResult.TabIndex = 3;
            LblResult.Text = "LblResult";
            // 
            // DictationForm
            // 
            AcceptButton = BtnCheck;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 143);
            Controls.Add(LblResult);
            Controls.Add(BtnCheck);
            Controls.Add(TxtWords);
            Controls.Add(LblMeans);
            MaximizeBox = false;
            MaximumSize = new Size(1024, 190);
            MinimizeBox = false;
            MinimumSize = new Size(240, 190);
            Name = "DictationForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "默写";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblMeans;
        private TextBox TxtWords;
        private Button BtnCheck;
        private Label LblResult;
    }
}