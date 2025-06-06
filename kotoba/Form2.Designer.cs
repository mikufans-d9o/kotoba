namespace kotoba
{
    partial class Form2
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
            lblMeans = new Label();
            txtWords = new TextBox();
            btnCheck = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblMeans
            // 
            lblMeans.AutoSize = true;
            lblMeans.Location = new Point(27, 16);
            lblMeans.Name = "lblMeans";
            lblMeans.Size = new Size(75, 20);
            lblMeans.TabIndex = 0;
            lblMeans.Text = "lblMeans";
            // 
            // txtWords
            // 
            txtWords.Location = new Point(27, 39);
            txtWords.Name = "txtWords";
            txtWords.Size = new Size(166, 27);
            txtWords.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(27, 72);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 29);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "核对";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(27, 104);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(53, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "label1";
            // 
            // Form2
            // 
            AcceptButton = btnCheck;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 143);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(txtWords);
            Controls.Add(lblMeans);
            MaximizeBox = false;
            MaximumSize = new Size(240, 190);
            MinimizeBox = false;
            MinimumSize = new Size(240, 190);
            Name = "Form2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "默写";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMeans;
        private TextBox txtWords;
        private Button btnCheck;
        private Label lblResult;
    }
}