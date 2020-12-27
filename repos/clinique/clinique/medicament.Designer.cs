namespace clinique
{
    partial class medicament
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
            this.medic = new System.Windows.Forms.RichTextBox();
            this.add = new System.Windows.Forms.Button();
            this.clos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // medic
            // 
            this.medic.Location = new System.Drawing.Point(13, 13);
            this.medic.Name = "medic";
            this.medic.Size = new System.Drawing.Size(262, 111);
            this.medic.TabIndex = 0;
            this.medic.Text = "";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(13, 139);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clos
            // 
            this.clos.Location = new System.Drawing.Point(200, 139);
            this.clos.Name = "clos";
            this.clos.Size = new System.Drawing.Size(75, 23);
            this.clos.TabIndex = 1;
            this.clos.Text = "Fermer";
            this.clos.UseVisualStyleBackColor = true;
            this.clos.Click += new System.EventHandler(this.clos_Click);
            // 
            // medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(287, 174);
            this.Controls.Add(this.clos);
            this.Controls.Add(this.add);
            this.Controls.Add(this.medic);
            this.Name = "medicament";
            this.Text = "medicament";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox medic;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clos;
    }
}