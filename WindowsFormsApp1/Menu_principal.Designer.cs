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
            this.ListboxEmployers.Location = new System.Drawing.Point(44, 26);
            this.ListboxEmployers.Name = "ListboxEmployers";
            this.ListboxEmployers.Size = new System.Drawing.Size(507, 394);
            this.ListboxEmployers.TabIndex = 5;
            this.ListboxEmployers.SelectedIndexChanged += new System.EventHandler(this.ListboxEmployers_SelectedIndexChanged);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListboxEmployers);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter_btn);
            this.Name = "Menu_principal";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Menu_principal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Ajouter_btn;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.ListBox ListboxEmployers;
    }
}