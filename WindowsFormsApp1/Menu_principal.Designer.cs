namespace WindowsFormsApp1
{
    partial class Menu_principal
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
            this.Ajouter_btn = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.ListboxEmployers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Vaccin_btn = new System.Windows.Forms.Button();
            this.Vaccin_btn.Name = "totaux";
            this.SuspendLayout();
            // 
            // Ajouter_btn
            // 
            this.Ajouter_btn.Location = new System.Drawing.Point(557, 26);
            this.Ajouter_btn.Name = "Ajouter_btn";
            this.Ajouter_btn.Size = new System.Drawing.Size(199, 43);
            this.Ajouter_btn.TabIndex = 1;
            this.Ajouter_btn.Text = "Ajouter";
            this.Ajouter_btn.UseVisualStyleBackColor = true;
            this.Ajouter_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(557, 75);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(199, 43);
            this.Supprimer.TabIndex = 2;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(557, 124);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(199, 43);
            this.Modifier.TabIndex = 3;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListboxEmployers
            // 
            this.ListboxEmployers.FormattingEnabled = true;
            this.ListboxEmployers.Location = new System.Drawing.Point(41, 75);
            this.ListboxEmployers.Name = "ListboxEmployers";
            this.ListboxEmployers.Size = new System.Drawing.Size(487, 342);
            this.ListboxEmployers.TabIndex = 5;
            this.ListboxEmployers.SelectedIndexChanged += new System.EventHandler(this.ListboxEmployers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(196, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Liste des employés";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Affichage des lits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "Quantité injecté par jour";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Vaccin_btn
            // 
            this.Vaccin_btn.Location = new System.Drawing.Point(557, 290);
            this.Vaccin_btn.Name = "Vaccin_btn";
            this.Vaccin_btn.Size = new System.Drawing.Size(199, 42);
            this.Vaccin_btn.TabIndex = 12;
            this.Vaccin_btn.Text = "Vaccins";
            this.Vaccin_btn.UseVisualStyleBackColor = true;
            this.Vaccin_btn.Visible = false;
            this.Vaccin_btn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.Vaccin_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListboxEmployers);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter_btn);
            this.Name = "Menu_principal";
            this.Text = "Gerer";
            this.Load += new System.EventHandler(this.Menu_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ajouter_btn;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.ListBox ListboxEmployers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Vaccin_btn;
    }
}