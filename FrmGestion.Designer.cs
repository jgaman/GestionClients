namespace GestionClients
{
    partial class FrmGestion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvNorthwind = new System.Windows.Forms.DataGridView();
            this.supprimerClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNorthwind)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauClientToolStripMenuItem,
            this.supprimerClientToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // nouveauClientToolStripMenuItem
            // 
            this.nouveauClientToolStripMenuItem.Name = "nouveauClientToolStripMenuItem";
            this.nouveauClientToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.nouveauClientToolStripMenuItem.Text = "Nouveau Client";
            this.nouveauClientToolStripMenuItem.Click += new System.EventHandler(this.nouveauClientToolStripMenuItem_Click);
            // 
            // dgvNorthwind
            // 
            this.dgvNorthwind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNorthwind.Location = new System.Drawing.Point(12, 42);
            this.dgvNorthwind.Name = "dgvNorthwind";
            this.dgvNorthwind.Size = new System.Drawing.Size(790, 411);
            this.dgvNorthwind.TabIndex = 1;
            // 
            // supprimerClientToolStripMenuItem
            // 
            this.supprimerClientToolStripMenuItem.Name = "supprimerClientToolStripMenuItem";
            this.supprimerClientToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.supprimerClientToolStripMenuItem.Text = "Supprimer Client";
            this.supprimerClientToolStripMenuItem.Click += new System.EventHandler(this.supprimerClientToolStripMenuItem_Click);
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 474);
            this.Controls.Add(this.dgvNorthwind);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGestion";
            this.Text = "clients";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNorthwind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauClientToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvNorthwind;
        private System.Windows.Forms.ToolStripMenuItem supprimerClientToolStripMenuItem;
    }
}

