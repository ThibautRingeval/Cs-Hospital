namespace WindowsFormsApp1
{
    partial class Vaccin
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
            this.ListboxVaccins = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListboxVaccins
            // 
            this.ListboxVaccins.FormattingEnabled = true;
            this.ListboxVaccins.Location = new System.Drawing.Point(87, 39);
            this.ListboxVaccins.Name = "ListboxVaccins";
            this.ListboxVaccins.Size = new System.Drawing.Size(348, 316);
            this.ListboxVaccins.TabIndex = 0;
            this.ListboxVaccins.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Vaccin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListboxVaccins);
            this.Name = "Vaccin";
            this.Text = "Vaccin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListboxVaccins;
    }
}