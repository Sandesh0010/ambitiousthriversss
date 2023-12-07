namespace hackathonproject
{
    partial class management1
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
            this.txtcomm = new System.Windows.Forms.MaskedTextBox();
            this.txtmathm = new System.Windows.Forms.MaskedTextBox();
            this.txtfinances = new System.Windows.Forms.TextBox();
            this.txteco = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnqns1next = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcomm
            // 
            this.txtcomm.Location = new System.Drawing.Point(350, 254);
            this.txtcomm.Name = "txtcomm";
            this.txtcomm.Size = new System.Drawing.Size(100, 26);
            this.txtcomm.TabIndex = 17;
            // 
            // txtmathm
            // 
            this.txtmathm.Location = new System.Drawing.Point(350, 331);
            this.txtmathm.Name = "txtmathm";
            this.txtmathm.Size = new System.Drawing.Size(100, 26);
            this.txtmathm.TabIndex = 16;
            // 
            // txtfinances
            // 
            this.txtfinances.Location = new System.Drawing.Point(334, 143);
            this.txtfinances.Name = "txtfinances";
            this.txtfinances.Size = new System.Drawing.Size(100, 26);
            this.txtfinances.TabIndex = 15;
            // 
            // txteco
            // 
            this.txteco.Location = new System.Drawing.Point(350, 185);
            this.txteco.Name = "txteco";
            this.txteco.Size = new System.Drawing.Size(100, 26);
            this.txteco.TabIndex = 14;
            this.txteco.Text = "\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "mathematics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "computer science";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "economics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "finances";
            // 
            // btnqns1next
            // 
            this.btnqns1next.Location = new System.Drawing.Point(626, 384);
            this.btnqns1next.Name = "btnqns1next";
            this.btnqns1next.Size = new System.Drawing.Size(75, 23);
            this.btnqns1next.TabIndex = 18;
            this.btnqns1next.Text = "next";
            this.btnqns1next.UseVisualStyleBackColor = true;
            this.btnqns1next.Click += new System.EventHandler(this.btnqns1next_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(497, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "What were the marks in different subjects of the stream you studied ?";
            // 
            // management1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnqns1next);
            this.Controls.Add(this.txtcomm);
            this.Controls.Add(this.txtmathm);
            this.Controls.Add(this.txtfinances);
            this.Controls.Add(this.txteco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "management1";
            this.Text = "management1";
            this.Load += new System.EventHandler(this.management1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtcomm;
        private System.Windows.Forms.MaskedTextBox txtmathm;
        private System.Windows.Forms.TextBox txtfinances;
        private System.Windows.Forms.MaskedTextBox txteco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnqns1next;
        private System.Windows.Forms.Label label5;
    }
}