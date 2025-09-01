namespace Moodie_Movie
{
    partial class Form1
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
            this.resultButton = new System.Windows.Forms.Button();
            this.check_happe = new System.Windows.Forms.CheckBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check_sad = new System.Windows.Forms.CheckBox();
            this.check_anger = new System.Windows.Forms.CheckBox();
            this.check_excitement = new System.Windows.Forms.CheckBox();
            this.check_tranquility = new System.Windows.Forms.CheckBox();
            this.check_melancholy = new System.Windows.Forms.CheckBox();
            this.check_excited = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.result_list = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.표츈텔러정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(101, 331);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(161, 28);
            this.resultButton.TabIndex = 1;
            this.resultButton.Text = "결과 보기";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // check_happe
            // 
            this.check_happe.AutoSize = true;
            this.check_happe.Location = new System.Drawing.Point(16, 170);
            this.check_happe.Name = "check_happe";
            this.check_happe.Size = new System.Drawing.Size(48, 16);
            this.check_happe.TabIndex = 2;
            this.check_happe.Text = "기쁨";
            this.check_happe.UseVisualStyleBackColor = true;
            this.check_happe.CheckedChanged += new System.EventHandler(this.check_happe_CheckedChanged);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(136, 77);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 21);
            this.tbname.TabIndex = 4;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "이름 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "감정을 선택하세요(최대 3개) : ";
            // 
            // check_sad
            // 
            this.check_sad.AutoSize = true;
            this.check_sad.Location = new System.Drawing.Point(136, 170);
            this.check_sad.Name = "check_sad";
            this.check_sad.Size = new System.Drawing.Size(48, 16);
            this.check_sad.TabIndex = 7;
            this.check_sad.Text = "슬픔";
            this.check_sad.UseVisualStyleBackColor = true;
            this.check_sad.CheckedChanged += new System.EventHandler(this.check_sad_CheckedChanged);
            // 
            // check_anger
            // 
            this.check_anger.AutoSize = true;
            this.check_anger.Location = new System.Drawing.Point(262, 170);
            this.check_anger.Name = "check_anger";
            this.check_anger.Size = new System.Drawing.Size(48, 16);
            this.check_anger.TabIndex = 8;
            this.check_anger.Text = "분노";
            this.check_anger.UseVisualStyleBackColor = true;
            this.check_anger.CheckedChanged += new System.EventHandler(this.check_anger_CheckedChanged);
            // 
            // check_excitement
            // 
            this.check_excitement.AutoSize = true;
            this.check_excitement.Location = new System.Drawing.Point(16, 204);
            this.check_excitement.Name = "check_excitement";
            this.check_excitement.Size = new System.Drawing.Size(52, 16);
            this.check_excitement.TabIndex = 9;
            this.check_excitement.Text = " 설렘";
            this.check_excitement.UseVisualStyleBackColor = true;
            this.check_excitement.CheckedChanged += new System.EventHandler(this.check_excitement_CheckedChanged);
            // 
            // check_tranquility
            // 
            this.check_tranquility.AutoSize = true;
            this.check_tranquility.Location = new System.Drawing.Point(136, 204);
            this.check_tranquility.Name = "check_tranquility";
            this.check_tranquility.Size = new System.Drawing.Size(48, 16);
            this.check_tranquility.TabIndex = 10;
            this.check_tranquility.Text = "평온";
            this.check_tranquility.UseVisualStyleBackColor = true;
            this.check_tranquility.CheckedChanged += new System.EventHandler(this.check_tranquility_CheckedChanged);
            // 
            // check_melancholy
            // 
            this.check_melancholy.AutoSize = true;
            this.check_melancholy.Location = new System.Drawing.Point(262, 204);
            this.check_melancholy.Name = "check_melancholy";
            this.check_melancholy.Size = new System.Drawing.Size(48, 16);
            this.check_melancholy.TabIndex = 11;
            this.check_melancholy.Text = "우울";
            this.check_melancholy.UseVisualStyleBackColor = true;
            this.check_melancholy.CheckedChanged += new System.EventHandler(this.check_melancholy_CheckedChanged);
            // 
            // check_excited
            // 
            this.check_excited.AutoSize = true;
            this.check_excited.Location = new System.Drawing.Point(16, 238);
            this.check_excited.Name = "check_excited";
            this.check_excited.Size = new System.Drawing.Size(48, 16);
            this.check_excited.TabIndex = 12;
            this.check_excited.Text = "신남";
            this.check_excited.UseVisualStyleBackColor = true;
            this.check_excited.CheckedChanged += new System.EventHandler(this.check_excited_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.result_list,
            this.toolStripSeparator1,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // result_list
            // 
            this.result_list.Name = "result_list";
            this.result_list.Size = new System.Drawing.Size(166, 22);
            this.result_list.Text = "모든 선택지 결과";
            this.result_list.Click += new System.EventHandler(this.result_list_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 도움ToolStripMenuItem
            // 
            this.도움ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.표츈텔러정보ToolStripMenuItem});
            this.도움ToolStripMenuItem.Name = "도움ToolStripMenuItem";
            this.도움ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움ToolStripMenuItem.Text = "도움말";
            // 
            // 표츈텔러정보ToolStripMenuItem
            // 
            this.표츈텔러정보ToolStripMenuItem.Name = "표츈텔러정보ToolStripMenuItem";
            this.표츈텔러정보ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.표츈텔러정보ToolStripMenuItem.Text = "표츈텔러 정보";
            this.표츈텔러정보ToolStripMenuItem.Click += new System.EventHandler(this.표츈텔러정보ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbname);
            this.groupBox1.Controls.Add(this.check_excited);
            this.groupBox1.Controls.Add(this.resultButton);
            this.groupBox1.Controls.Add(this.check_melancholy);
            this.groupBox1.Controls.Add(this.check_happe);
            this.groupBox1.Controls.Add(this.check_tranquility);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.check_excitement);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.check_anger);
            this.groupBox1.Controls.Add(this.check_sad);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 401);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 정보 입력";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbResult);
            this.groupBox2.Location = new System.Drawing.Point(385, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 401);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과 보기";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(6, 20);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(391, 366);
            this.tbResult.TabIndex = 1;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Moodie_Movie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.CheckBox check_happe;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_sad;
        private System.Windows.Forms.CheckBox check_anger;
        private System.Windows.Forms.CheckBox check_excitement;
        private System.Windows.Forms.CheckBox check_tranquility;
        private System.Windows.Forms.CheckBox check_melancholy;
        private System.Windows.Forms.CheckBox check_excited;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 표츈텔러정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem result_list;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbResult;
    }
}

