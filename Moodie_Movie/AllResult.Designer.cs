namespace Moodie_Movie
{
    partial class AllResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllResult));
            this.all_result = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // all_result
            // 
            this.all_result.AutoSize = true;
            this.all_result.Location = new System.Drawing.Point(141, 12);
            this.all_result.Name = "all_result";
            this.all_result.Size = new System.Drawing.Size(513, 4548);
            this.all_result.TabIndex = 4;
            this.all_result.Text = resources.GetString("all_result.Text");
            this.all_result.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.all_result);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 978);
            this.panel1.TabIndex = 5;
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(692, 957);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 6;
            this.close_button.Text = "닫기";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1002);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.panel1);
            this.Name = "AllResult";
            this.Text = "AllResult";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label all_result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close_button;
    }
}