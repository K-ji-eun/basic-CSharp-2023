namespace wf03_property
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gbxmain = new System.Windows.Forms.GroupBox();
            this.RdoIndent = new System.Windows.Forms.RadioButton();
            this.RdoNomal = new System.Windows.Forms.RadioButton();
            this.NudFontSize = new System.Windows.Forms.NumericUpDown();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.ChkItalic = new System.Windows.Forms.CheckBox();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.CboFontFamily = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PgbDummy = new System.Windows.Forms.ProgressBar();
            this.TrbDummy = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnMsgBox = new System.Windows.Forms.Button();
            this.BtnModaless = new System.Windows.Forms.Button();
            this.BtnModal = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAddChild = new System.Windows.Forms.Button();
            this.BtnAddRoot = new System.Windows.Forms.Button();
            this.LsvDummy = new System.Windows.Forms.ListView();
            this.TrvDummy = new System.Windows.Forms.TreeView();
            this.PcbDummy = new System.Windows.Forms.PictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbxmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFontSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbDummy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDummy)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxmain
            // 
            this.gbxmain.Controls.Add(this.RdoIndent);
            this.gbxmain.Controls.Add(this.RdoNomal);
            this.gbxmain.Controls.Add(this.NudFontSize);
            this.gbxmain.Controls.Add(this.TxtResult);
            this.gbxmain.Controls.Add(this.ChkItalic);
            this.gbxmain.Controls.Add(this.ChkBold);
            this.gbxmain.Controls.Add(this.CboFontFamily);
            this.gbxmain.Controls.Add(this.label2);
            this.gbxmain.Controls.Add(this.label1);
            this.gbxmain.Location = new System.Drawing.Point(12, 12);
            this.gbxmain.Name = "gbxmain";
            this.gbxmain.Size = new System.Drawing.Size(395, 174);
            this.gbxmain.TabIndex = 0;
            this.gbxmain.TabStop = false;
            this.gbxmain.Text = "컨트롤 학습";
            // 
            // RdoIndent
            // 
            this.RdoIndent.AutoSize = true;
            this.RdoIndent.Location = new System.Drawing.Point(316, 51);
            this.RdoIndent.Name = "RdoIndent";
            this.RdoIndent.Size = new System.Drawing.Size(71, 16);
            this.RdoIndent.TabIndex = 16;
            this.RdoIndent.Text = "들여쓰기";
            this.RdoIndent.UseVisualStyleBackColor = true;
            this.RdoIndent.CheckedChanged += new System.EventHandler(this.RdoIndent_CheckedChanged);
            // 
            // RdoNomal
            // 
            this.RdoNomal.AutoSize = true;
            this.RdoNomal.Checked = true;
            this.RdoNomal.Location = new System.Drawing.Point(242, 51);
            this.RdoNomal.Name = "RdoNomal";
            this.RdoNomal.Size = new System.Drawing.Size(47, 16);
            this.RdoNomal.TabIndex = 15;
            this.RdoNomal.TabStop = true;
            this.RdoNomal.Text = "일반";
            this.RdoNomal.UseVisualStyleBackColor = true;
            this.RdoNomal.CheckedChanged += new System.EventHandler(this.RdoNomal_CheckedChanged);
            // 
            // NudFontSize
            // 
            this.NudFontSize.Location = new System.Drawing.Point(97, 48);
            this.NudFontSize.Name = "NudFontSize";
            this.NudFontSize.Size = new System.Drawing.Size(121, 21);
            this.NudFontSize.TabIndex = 4;
            this.NudFontSize.ValueChanged += new System.EventHandler(this.fontsize_ValueChanged);
            // 
            // TxtResult
            // 
            this.TxtResult.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtResult.Location = new System.Drawing.Point(29, 75);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(337, 93);
            this.TxtResult.TabIndex = 5;
            // 
            // ChkItalic
            // 
            this.ChkItalic.AutoSize = true;
            this.ChkItalic.Location = new System.Drawing.Point(316, 24);
            this.ChkItalic.Name = "ChkItalic";
            this.ChkItalic.Size = new System.Drawing.Size(60, 16);
            this.ChkItalic.TabIndex = 3;
            this.ChkItalic.Text = "이탤릭";
            this.ChkItalic.UseVisualStyleBackColor = true;
            this.ChkItalic.CheckedChanged += new System.EventHandler(this.italic_CheckedChanged);
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Checked = true;
            this.ChkBold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBold.Location = new System.Drawing.Point(242, 25);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(48, 16);
            this.ChkBold.TabIndex = 2;
            this.ChkBold.Text = "볼드";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.bold_CheckedChanged);
            // 
            // CboFontFamily
            // 
            this.CboFontFamily.FormattingEnabled = true;
            this.CboFontFamily.Location = new System.Drawing.Point(97, 22);
            this.CboFontFamily.Name = "CboFontFamily";
            this.CboFontFamily.Size = new System.Drawing.Size(121, 20);
            this.CboFontFamily.TabIndex = 1;
            this.CboFontFamily.SelectedIndexChanged += new System.EventHandler(this.fontname_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "글자크기";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "글자체";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PgbDummy);
            this.groupBox1.Controls.Add(this.TrbDummy);
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "트랙바 및 진행바";
            // 
            // PgbDummy
            // 
            this.PgbDummy.Location = new System.Drawing.Point(6, 71);
            this.PgbDummy.Maximum = 20;
            this.PgbDummy.Name = "PgbDummy";
            this.PgbDummy.Size = new System.Drawing.Size(383, 23);
            this.PgbDummy.TabIndex = 7;
            // 
            // TrbDummy
            // 
            this.TrbDummy.Location = new System.Drawing.Point(6, 20);
            this.TrbDummy.Maximum = 20;
            this.TrbDummy.Name = "TrbDummy";
            this.TrbDummy.Size = new System.Drawing.Size(383, 45);
            this.TrbDummy.TabIndex = 6;
            this.TrbDummy.Scroll += new System.EventHandler(this.TrbDummy_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnMsgBox);
            this.groupBox2.Controls.Add(this.BtnModaless);
            this.groupBox2.Controls.Add(this.BtnModal);
            this.groupBox2.Location = new System.Drawing.Point(12, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "모달/리스/메세지창";
            // 
            // BtnMsgBox
            // 
            this.BtnMsgBox.Location = new System.Drawing.Point(203, 21);
            this.BtnMsgBox.Name = "BtnMsgBox";
            this.BtnMsgBox.Size = new System.Drawing.Size(186, 35);
            this.BtnMsgBox.TabIndex = 10;
            this.BtnMsgBox.Text = "MessageBox";
            this.BtnMsgBox.UseVisualStyleBackColor = true;
            this.BtnMsgBox.Click += new System.EventHandler(this.BtnMsgBox_Click);
            // 
            // BtnModaless
            // 
            this.BtnModaless.Location = new System.Drawing.Point(97, 21);
            this.BtnModaless.Name = "BtnModaless";
            this.BtnModaless.Size = new System.Drawing.Size(84, 35);
            this.BtnModaless.TabIndex = 9;
            this.BtnModaless.Text = "Modaless";
            this.BtnModaless.UseVisualStyleBackColor = true;
            this.BtnModaless.Click += new System.EventHandler(this.BtnModaless_Click);
            // 
            // BtnModal
            // 
            this.BtnModal.Location = new System.Drawing.Point(7, 21);
            this.BtnModal.Name = "BtnModal";
            this.BtnModal.Size = new System.Drawing.Size(84, 35);
            this.BtnModal.TabIndex = 8;
            this.BtnModal.Text = "Modal";
            this.BtnModal.UseVisualStyleBackColor = true;
            this.BtnModal.Click += new System.EventHandler(this.BtnModal_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAddChild);
            this.groupBox3.Controls.Add(this.BtnAddRoot);
            this.groupBox3.Controls.Add(this.LsvDummy);
            this.groupBox3.Controls.Add(this.TrvDummy);
            this.groupBox3.Location = new System.Drawing.Point(413, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 204);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "트리뷰/리스트뷰";
            // 
            // BtnAddChild
            // 
            this.BtnAddChild.Location = new System.Drawing.Point(110, 174);
            this.BtnAddChild.Name = "BtnAddChild";
            this.BtnAddChild.Size = new System.Drawing.Size(75, 23);
            this.BtnAddChild.TabIndex = 14;
            this.BtnAddChild.Text = "자식 추가";
            this.BtnAddChild.UseVisualStyleBackColor = true;
            this.BtnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            // 
            // BtnAddRoot
            // 
            this.BtnAddRoot.Location = new System.Drawing.Point(29, 174);
            this.BtnAddRoot.Name = "BtnAddRoot";
            this.BtnAddRoot.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRoot.TabIndex = 13;
            this.BtnAddRoot.Text = "루트 추가";
            this.BtnAddRoot.UseVisualStyleBackColor = true;
            this.BtnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);
            // 
            // LsvDummy
            // 
            this.LsvDummy.HideSelection = false;
            this.LsvDummy.Location = new System.Drawing.Point(202, 21);
            this.LsvDummy.Name = "LsvDummy";
            this.LsvDummy.Size = new System.Drawing.Size(186, 147);
            this.LsvDummy.TabIndex = 12;
            this.LsvDummy.UseCompatibleStateImageBehavior = false;
            // 
            // TrvDummy
            // 
            this.TrvDummy.Location = new System.Drawing.Point(7, 21);
            this.TrvDummy.Name = "TrvDummy";
            this.TrvDummy.Size = new System.Drawing.Size(189, 147);
            this.TrvDummy.TabIndex = 11;
            // 
            // PcbDummy
            // 
            this.PcbDummy.Location = new System.Drawing.Point(6, 16);
            this.PcbDummy.Name = "PcbDummy";
            this.PcbDummy.Size = new System.Drawing.Size(251, 175);
            this.PcbDummy.TabIndex = 4;
            this.PcbDummy.TabStop = false;
            this.PcbDummy.Click += new System.EventHandler(this.PcbDummy_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(270, 16);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 5;
            this.BtnLoad.Text = "로드";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PcbDummy);
            this.groupBox4.Controls.Add(this.BtnLoad);
            this.groupBox4.Location = new System.Drawing.Point(420, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 191);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "픽처박스";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 484);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxmain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "속성확인";
            this.Load += new System.EventHandler(this.Form_Load);
            this.gbxmain.ResumeLayout(false);
            this.gbxmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFontSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbDummy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbDummy)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxmain;
        private System.Windows.Forms.CheckBox ChkItalic;
        private System.Windows.Forms.CheckBox ChkBold;
        private System.Windows.Forms.ComboBox CboFontFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.NumericUpDown NudFontSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar PgbDummy;
        private System.Windows.Forms.TrackBar TrbDummy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnMsgBox;
        private System.Windows.Forms.Button BtnModaless;
        private System.Windows.Forms.Button BtnModal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView LsvDummy;
        private System.Windows.Forms.TreeView TrvDummy;
        private System.Windows.Forms.Button BtnAddChild;
        private System.Windows.Forms.Button BtnAddRoot;
        private System.Windows.Forms.RadioButton RdoIndent;
        private System.Windows.Forms.RadioButton RdoNomal;
        private System.Windows.Forms.PictureBox PcbDummy;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

