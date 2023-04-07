namespace wf04_filecopy
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BtnFindSource = new Button();
            label1 = new Label();
            TxtSource = new TextBox();
            BtnFindTarget = new Button();
            label2 = new Label();
            TxtTarget = new TextBox();
            BtnAsyncCopy = new Button();
            BtnSyncCopy = new Button();
            PgbCopy = new ProgressBar();
            SuspendLayout();
            // 
            // BtnFindSource
            // 
            BtnFindSource.Location = new Point(321, 14);
            BtnFindSource.Name = "BtnFindSource";
            BtnFindSource.Size = new Size(30, 24);
            BtnFindSource.TabIndex = 3;
            BtnFindSource.Text = "...";
            BtnFindSource.UseVisualStyleBackColor = true;
            BtnFindSource.Click += BtnFindSource_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Source :";
            // 
            // TxtSource
            // 
            TxtSource.BackColor = SystemColors.ControlLight;
            TxtSource.Location = new Point(66, 16);
            TxtSource.Name = "TxtSource";
            TxtSource.Size = new Size(249, 23);
            TxtSource.TabIndex = 1;
            TxtSource.TabStop = false;
            TxtSource.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnFindTarget
            // 
            BtnFindTarget.Location = new Point(321, 44);
            BtnFindTarget.Name = "BtnFindTarget";
            BtnFindTarget.Size = new Size(30, 24);
            BtnFindTarget.TabIndex = 4;
            BtnFindTarget.Text = "...";
            BtnFindTarget.UseVisualStyleBackColor = true;
            BtnFindTarget.Click += BtnFindTarget_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 49);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Target :";
            // 
            // TxtTarget
            // 
            TxtTarget.BackColor = SystemColors.ControlLight;
            TxtTarget.Location = new Point(66, 46);
            TxtTarget.Name = "TxtTarget";
            TxtTarget.Size = new Size(249, 23);
            TxtTarget.TabIndex = 2;
            TxtTarget.TabStop = false;
            // 
            // BtnAsyncCopy
            // 
            BtnAsyncCopy.Location = new Point(66, 102);
            BtnAsyncCopy.Name = "BtnAsyncCopy";
            BtnAsyncCopy.RightToLeft = RightToLeft.Yes;
            BtnAsyncCopy.Size = new Size(110, 23);
            BtnAsyncCopy.TabIndex = 5;
            BtnAsyncCopy.Text = "Async Copy";
            BtnAsyncCopy.UseVisualStyleBackColor = true;
            BtnAsyncCopy.Click += BtnAsyncCopy_Click;
            // 
            // BtnSyncCopy
            // 
            BtnSyncCopy.Location = new Point(212, 102);
            BtnSyncCopy.Name = "BtnSyncCopy";
            BtnSyncCopy.Size = new Size(103, 23);
            BtnSyncCopy.TabIndex = 6;
            BtnSyncCopy.Text = "Sync Copy";
            BtnSyncCopy.UseVisualStyleBackColor = true;
            // 
            // PgbCopy
            // 
            PgbCopy.Location = new Point(16, 131);
            PgbCopy.Name = "PgbCopy";
            PgbCopy.Size = new Size(335, 23);
            PgbCopy.TabIndex = 4;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 177);
            Controls.Add(PgbCopy);
            Controls.Add(BtnSyncCopy);
            Controls.Add(BtnAsyncCopy);
            Controls.Add(TxtTarget);
            Controls.Add(TxtSource);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnFindTarget);
            Controls.Add(BtnFindSource);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Async File Copy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnFindSource;
        private Label label1;
        private TextBox TxtSource;
        private Button BtnFindTarget;
        private Label label2;
        private TextBox TxtTarget;
        private Button BtnAsyncCopy;
        private Button BtnSyncCopy;
        private ProgressBar PgbCopy;
    }
}