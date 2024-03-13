
namespace WindowsFormsFiche2
{
    partial class Fm_principal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rt_texte = new System.Windows.Forms.RichTextBox();
            this.ms_principal = new System.Windows.Forms.MenuStrip();
            this.mi_fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ouvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_enregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.od_ouvrir = new System.Windows.Forms.OpenFileDialog();
            this.od_enregistrer = new System.Windows.Forms.OpenFileDialog();
            this.ms_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_texte
            // 
            this.rt_texte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rt_texte.Location = new System.Drawing.Point(0, 24);
            this.rt_texte.Name = "rt_texte";
            this.rt_texte.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rt_texte.Size = new System.Drawing.Size(800, 426);
            this.rt_texte.TabIndex = 0;
            this.rt_texte.Text = "";
            // 
            // ms_principal
            // 
            this.ms_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_fichier});
            this.ms_principal.Location = new System.Drawing.Point(0, 0);
            this.ms_principal.Name = "ms_principal";
            this.ms_principal.Size = new System.Drawing.Size(800, 24);
            this.ms_principal.TabIndex = 1;
            this.ms_principal.Text = "menuStrip1";
            // 
            // mi_fichier
            // 
            this.mi_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_ouvrir,
            this.mi_enregistrerSous,
            this.quitterToolStripMenuItem,
            this.mi_quitter});
            this.mi_fichier.Name = "mi_fichier";
            this.mi_fichier.Size = new System.Drawing.Size(54, 20);
            this.mi_fichier.Text = "Fichier";
            // 
            // mi_ouvrir
            // 
            this.mi_ouvrir.Name = "mi_ouvrir";
            this.mi_ouvrir.Size = new System.Drawing.Size(180, 22);
            this.mi_ouvrir.Text = "&Ouvrir";
            this.mi_ouvrir.Click += new System.EventHandler(this.mi_ouvrir_Click);
            // 
            // mi_enregistrerSous
            // 
            this.mi_enregistrerSous.Name = "mi_enregistrerSous";
            this.mi_enregistrerSous.Size = new System.Drawing.Size(180, 22);
            this.mi_enregistrerSous.Text = "&En&registrer sous";
            this.mi_enregistrerSous.Click += new System.EventHandler(this.mi_enregistrerSous_Click_1);
            // 
            // mi_quitter
            // 
            this.mi_quitter.Name = "mi_quitter";
            this.mi_quitter.Size = new System.Drawing.Size(180, 22);
            this.mi_quitter.Text = "&Quitter";
            this.mi_quitter.Click += new System.EventHandler(this.mi_quitter_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // od_ouvrir
            // 
            this.od_ouvrir.FileName = "openFileDialog1";
            this.od_ouvrir.FileOk += new System.ComponentModel.CancelEventHandler(this.od_ouvrir_FileOk);
            // 
            // od_enregistrer
            // 
            this.od_enregistrer.FileName = "openFileDialog1";
            this.od_enregistrer.FileOk += new System.ComponentModel.CancelEventHandler(this.od_enregistrer_FileOk);
            // 
            // Fm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rt_texte);
            this.Controls.Add(this.ms_principal);
            this.MainMenuStrip = this.ms_principal;
            this.Name = "Fm_principal";
            this.Text = "Mon petit éditeur";
            this.ms_principal.ResumeLayout(false);
            this.ms_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_texte;
        private System.Windows.Forms.MenuStrip ms_principal;
        private System.Windows.Forms.ToolStripMenuItem mi_fichier;
        private System.Windows.Forms.ToolStripMenuItem mi_ouvrir;
        private System.Windows.Forms.ToolStripMenuItem mi_enregistrerSous;
        private System.Windows.Forms.ToolStripMenuItem mi_quitter;
        private System.Windows.Forms.ToolStripSeparator quitterToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog od_ouvrir;
        private System.Windows.Forms.OpenFileDialog od_enregistrer;
    }
}

