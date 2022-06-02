namespace WindowsFormsApp1
{
    partial class Ajouter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_Tb = new System.Windows.Forms.TextBox();
            this.Surname_Tb = new System.Windows.Forms.TextBox();
            this.Num_Tb = new System.Windows.Forms.TextBox();
            this.Mail_Tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ajout_btn = new System.Windows.Forms.Button();
            this.Num_Securite_Sociale = new System.Windows.Forms.Label();
            this.Numsec_tb = new System.Windows.Forms.TextBox();
            this.Service_Cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Role_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Function_tb = new System.Windows.Forms.TextBox();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(71, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(67, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(67, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Téléphone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(67, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email :";
            // 
            // Name_Tb
            // 
            this.Name_Tb.Location = new System.Drawing.Point(201, 65);
            this.Name_Tb.Name = "Name_Tb";
            this.Name_Tb.Size = new System.Drawing.Size(151, 20);
            this.Name_Tb.TabIndex = 5;
            this.Name_Tb.TextChanged += new System.EventHandler(this.Name_Tb_TextChanged);
            // 
            // Surname_Tb
            // 
            this.Surname_Tb.Location = new System.Drawing.Point(201, 91);
            this.Surname_Tb.Name = "Surname_Tb";
            this.Surname_Tb.Size = new System.Drawing.Size(151, 20);
            this.Surname_Tb.TabIndex = 6;
            // 
            // Num_Tb
            // 
            this.Num_Tb.Location = new System.Drawing.Point(201, 114);
            this.Num_Tb.Name = "Num_Tb";
            this.Num_Tb.Size = new System.Drawing.Size(151, 20);
            this.Num_Tb.TabIndex = 7;
            // 
            // Mail_Tb
            // 
            this.Mail_Tb.Location = new System.Drawing.Point(201, 140);
            this.Mail_Tb.Name = "Mail_Tb";
            this.Mail_Tb.Size = new System.Drawing.Size(151, 20);
            this.Mail_Tb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(159, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ajout";
            // 
            // Ajout_btn
            // 
            this.Ajout_btn.Location = new System.Drawing.Point(137, 317);
            this.Ajout_btn.Name = "Ajout_btn";
            this.Ajout_btn.Size = new System.Drawing.Size(75, 23);
            this.Ajout_btn.TabIndex = 13;
            this.Ajout_btn.Text = "Ajouter";
            this.Ajout_btn.UseVisualStyleBackColor = true;
            this.Ajout_btn.Click += new System.EventHandler(this.Ajout_btn_Click);
            // 
            // Num_Securite_Sociale
            // 
            this.Num_Securite_Sociale.AutoSize = true;
            this.Num_Securite_Sociale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Num_Securite_Sociale.Location = new System.Drawing.Point(12, 192);
            this.Num_Securite_Sociale.Name = "Num_Securite_Sociale";
            this.Num_Securite_Sociale.Size = new System.Drawing.Size(188, 17);
            this.Num_Securite_Sociale.TabIndex = 14;
            this.Num_Securite_Sociale.Text = "Numéro de sécurité sociale :";
            // 
            // Numsec_tb
            // 
            this.Numsec_tb.Location = new System.Drawing.Point(201, 192);
            this.Numsec_tb.Name = "Numsec_tb";
            this.Numsec_tb.Size = new System.Drawing.Size(151, 20);
            this.Numsec_tb.TabIndex = 15;
            // 
            // Service_Cb
            // 
            this.Service_Cb.FormattingEnabled = true;
            this.Service_Cb.Location = new System.Drawing.Point(201, 244);
            this.Service_Cb.Name = "Service_Cb";
            this.Service_Cb.Size = new System.Drawing.Size(151, 21);
            this.Service_Cb.TabIndex = 16;
            this.Service_Cb.SelectedIndexChanged += new System.EventHandler(this.Service_Cb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(55, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Service :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(55, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Rôle :";
            // 
            // Role_cb
            // 
            this.Role_cb.FormattingEnabled = true;
            this.Role_cb.Items.AddRange(new object[] {
            "Utilisateur",
            "Administrateur"});
            this.Role_cb.Location = new System.Drawing.Point(201, 271);
            this.Role_cb.Name = "Role_cb";
            this.Role_cb.Size = new System.Drawing.Size(151, 21);
            this.Role_cb.TabIndex = 20;
            this.Role_cb.SelectedIndexChanged += new System.EventHandler(this.Role_cb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(55, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fonction :";
            // 
            // Function_tb
            // 
            this.Function_tb.Location = new System.Drawing.Point(201, 218);
            this.Function_tb.Name = "Function_tb";
            this.Function_tb.Size = new System.Drawing.Size(151, 20);
            this.Function_tb.TabIndex = 24;
            // 
            // Password_tb
            // 
            this.Password_tb.Location = new System.Drawing.Point(201, 166);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Size = new System.Drawing.Size(151, 20);
            this.Password_tb.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(67, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mot de passe :";
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 358);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Function_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Role_cb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Service_Cb);
            this.Controls.Add(this.Numsec_tb);
            this.Controls.Add(this.Num_Securite_Sociale);
            this.Controls.Add(this.Ajout_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mail_Tb);
            this.Controls.Add(this.Num_Tb);
            this.Controls.Add(this.Surname_Tb);
            this.Controls.Add(this.Name_Tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ajouter";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_Tb;
        private System.Windows.Forms.TextBox Surname_Tb;
        private System.Windows.Forms.TextBox Num_Tb;
        private System.Windows.Forms.TextBox Mail_Tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Ajout_btn;
        private System.Windows.Forms.Label Num_Securite_Sociale;
        private System.Windows.Forms.TextBox Numsec_tb;
        private System.Windows.Forms.ComboBox Service_Cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Role_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Function_tb;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.Label label8;
    }
}