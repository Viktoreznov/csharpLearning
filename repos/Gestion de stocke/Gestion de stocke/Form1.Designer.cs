namespace Gestion_de_stocke
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDesClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDesFournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDesProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerUnFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherFacruesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listDesFacuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.facturesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnClientToolStripMenuItem,
            this.listDesClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // ajouterUnClientToolStripMenuItem
            // 
            this.ajouterUnClientToolStripMenuItem.Name = "ajouterUnClientToolStripMenuItem";
            this.ajouterUnClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterUnClientToolStripMenuItem.Text = "Ajouter un client";
            this.ajouterUnClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnClientToolStripMenuItem_Click);
            // 
            // listDesClientToolStripMenuItem
            // 
            this.listDesClientToolStripMenuItem.Name = "listDesClientToolStripMenuItem";
            this.listDesClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listDesClientToolStripMenuItem.Text = "List des Client";
            this.listDesClientToolStripMenuItem.Click += new System.EventHandler(this.listDesClientToolStripMenuItem_Click);
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnFournisseurToolStripMenuItem,
            this.listDesFournisseursToolStripMenuItem});
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fournisseurToolStripMenuItem.Text = "Fournisseur";
            // 
            // ajouterUnFournisseurToolStripMenuItem
            // 
            this.ajouterUnFournisseurToolStripMenuItem.Name = "ajouterUnFournisseurToolStripMenuItem";
            this.ajouterUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ajouterUnFournisseurToolStripMenuItem.Text = "Ajouter un Fournisseur";
            // 
            // listDesFournisseursToolStripMenuItem
            // 
            this.listDesFournisseursToolStripMenuItem.Name = "listDesFournisseursToolStripMenuItem";
            this.listDesFournisseursToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.listDesFournisseursToolStripMenuItem.Text = "List des Fournisseurs";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnProduitToolStripMenuItem,
            this.listDesProduitToolStripMenuItem,
            this.rechercheProduitToolStripMenuItem});
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.produitToolStripMenuItem.Text = "Produits";
            // 
            // ajouterUnProduitToolStripMenuItem
            // 
            this.ajouterUnProduitToolStripMenuItem.Name = "ajouterUnProduitToolStripMenuItem";
            this.ajouterUnProduitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ajouterUnProduitToolStripMenuItem.Text = "Ajouter un produit";
            // 
            // listDesProduitToolStripMenuItem
            // 
            this.listDesProduitToolStripMenuItem.Name = "listDesProduitToolStripMenuItem";
            this.listDesProduitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listDesProduitToolStripMenuItem.Text = "List des Produit";
            // 
            // rechercheProduitToolStripMenuItem
            // 
            this.rechercheProduitToolStripMenuItem.Name = "rechercheProduitToolStripMenuItem";
            this.rechercheProduitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.rechercheProduitToolStripMenuItem.Text = "Recherche Produit";
            // 
            // facturesToolStripMenuItem
            // 
            this.facturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerUnFacturesToolStripMenuItem,
            this.factureToolStripMenuItem});
            this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
            this.facturesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturesToolStripMenuItem.Text = "Factures";
            // 
            // creerUnFacturesToolStripMenuItem
            // 
            this.creerUnFacturesToolStripMenuItem.Name = "creerUnFacturesToolStripMenuItem";
            this.creerUnFacturesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creerUnFacturesToolStripMenuItem.Text = "Creer un Factures";
            // 
            // factureToolStripMenuItem
            // 
            this.factureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherFacruesToolStripMenuItem,
            this.listDesFacuresToolStripMenuItem});
            this.factureToolStripMenuItem.Name = "factureToolStripMenuItem";
            this.factureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.factureToolStripMenuItem.Text = "Facture";
            // 
            // afficherFacruesToolStripMenuItem
            // 
            this.afficherFacruesToolStripMenuItem.Name = "afficherFacruesToolStripMenuItem";
            this.afficherFacruesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afficherFacruesToolStripMenuItem.Text = "Afficher Factues";
            this.afficherFacruesToolStripMenuItem.Click += new System.EventHandler(this.afficherFacruesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // listDesFacuresToolStripMenuItem
            // 
            this.listDesFacuresToolStripMenuItem.Name = "listDesFacuresToolStripMenuItem";
            this.listDesFacuresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listDesFacuresToolStripMenuItem.Text = "List des Facures";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 355);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDesClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDesFournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDesProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerUnFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherFacruesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listDesFacuresToolStripMenuItem;
    }
}

