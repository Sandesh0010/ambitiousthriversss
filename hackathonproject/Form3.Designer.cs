namespace hackathonproject
{
    partial class Quizcat
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
            this.generalk = new System.Windows.Forms.Button();
            this.Science = new System.Windows.Forms.Button();
            this.Technology = new System.Windows.Forms.Button();
            this.previous1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generalk
            // 
            this.generalk.Location = new System.Drawing.Point(233, 99);
            this.generalk.Name = "generalk";
            this.generalk.Size = new System.Drawing.Size(311, 93);
            this.generalk.TabIndex = 0;
            this.generalk.Text = "General Knowledge";
            this.generalk.UseVisualStyleBackColor = true;
            this.generalk.Click += new System.EventHandler(this.generalk_Click);
            // 
            // Science
            // 
            this.Science.Location = new System.Drawing.Point(233, 239);
            this.Science.Name = "Science";
            this.Science.Size = new System.Drawing.Size(311, 93);
            this.Science.TabIndex = 1;
            this.Science.Text = "Science";
            this.Science.UseVisualStyleBackColor = true;
            this.Science.Click += new System.EventHandler(this.Science_Click);
            // 
            // Technology
            // 
            this.Technology.Location = new System.Drawing.Point(233, 377);
            this.Technology.Name = "Technology";
            this.Technology.Size = new System.Drawing.Size(311, 93);
            this.Technology.TabIndex = 2;
            this.Technology.Text = "Technology";
            this.Technology.UseVisualStyleBackColor = true;
            // 
            // previous1
            // 
            this.previous1.Location = new System.Drawing.Point(12, 512);
            this.previous1.Name = "previous1";
            this.previous1.Size = new System.Drawing.Size(78, 33);
            this.previous1.TabIndex = 3;
            this.previous1.Text = "Previous";
            this.previous1.UseVisualStyleBackColor = true;
            this.previous1.Click += new System.EventHandler(this.previous1_Click);
            // 
            // Quizcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.previous1);
            this.Controls.Add(this.Technology);
            this.Controls.Add(this.Science);
            this.Controls.Add(this.generalk);
            this.Name = "Quizcat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Categories";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generalk;
        private System.Windows.Forms.Button Science;
        private System.Windows.Forms.Button Technology;
        private System.Windows.Forms.Button previous1;
    }
}