namespace SayiSistemleriGUI
{
    partial class AnaSayfa
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.metroTile1.Location = new System.Drawing.Point(15, 101);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(117, 134);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Sayı Sistemleri";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.Location = new System.Drawing.Point(251, 101);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(121, 134);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Dogruluk Tablosu";
            this.metroTile2.Click += new System.EventHandler(this.MetroTile2_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 342);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AnaSayfa";
            this.Padding = new System.Windows.Forms.Padding(13, 39, 13, 13);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Ana Sayfa";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}