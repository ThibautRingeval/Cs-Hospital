namespace WindowsFormsApp1
{
    partial class Modifier
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
            this.Modifier_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Mail_Tb = new System.Windows.Forms.TextBox();
            this.Num_Tb = new System.Windows.Forms.TextBox();
            this.Surname_btn = new System.Windows.Forms.TextBox();
            this.Name_Tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Modifier_btn
            // 
            this.Modifier_btn.Location = new System.Drawing.Point(250, 254);
            this.Modifier_btn.Name = "Modifier_btn";
            this.Modifier_btn.Size = new System.Drawing.Size(75, 23);
            this.Modifier_btn.TabIndex = 26;
            this.Modifier_btn.Text = "Modifier";
            this.Modifier_btn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(260, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Modifier";
            // 
            // Mail_Tb
            // 
            this.Mail_Tb.Location = new System.Drawing.Point(119, 164);
            this.Mail_Tb.Name = "Mail_Tb";
            this.Mail_Tb.Size = new System.Drawing.Size(151, 20);
            this.Mail_Tb.TabIndex = 22;
            // 
            // Num_Tb
            // 
            this.Num_Tb.Location = new System.Drawing.Point(119, 136);
            this.Num_Tb.Name = "Num_Tb";
            this.Num_Tb.Size = new System.Drawing.Size(151, 20);
            this.Num_Tb.TabIndex = 21;
            // 
            // Surname_btn
            // 
            this.Surname_btn.Location = new System.Drawing.Point(119, 98);
            this.Surname_btn.Name = "Surname_btn";
            this.Surname_btn.Size = new System.Drawing.Size(151, 20);
            this.Surname_btn.TabIndex = 20;
            // 
            // Name_Tb
            // 
            this.Name_Tb.Location = new System.Drawing.Point(119, 71);
            this.Name_Tb.Name = "Name_Tb";
            this.Name_Tb.Size = new System.Drawing.Size(151, 20);
            this.Name_Tb.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(28, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Téléphone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom :";
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 304);
            this.Controls.Add(this.Modifier_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mail_Tb);
            this.Controls.Add(this.Num_Tb);
            this.Controls.Add(this.Surname_btn);
            this.Controls.Add(this.Name_Tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modifier";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Modifier_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Mail_Tb;
        private System.Windows.Forms.TextBox Num_Tb;
        private System.Windows.Forms.TextBox Surname_btn;
        private System.Windows.Forms.TextBox Name_Tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}