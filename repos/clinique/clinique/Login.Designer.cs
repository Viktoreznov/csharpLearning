namespace clinique
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Password = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quitter = new System.Windows.Forms.Button();
            this.valider = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(30, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrez vos cordonnées";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(152, 90);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(142, 21);
            this.Password.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mot de passe :";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(152, 40);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(142, 21);
            this.username.TabIndex = 2;
            this.username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom d\'utilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Image = global::clinique.Properties.Resources.Close_2_icon;
            this.pictureBox2.Location = new System.Drawing.Point(244, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::clinique.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.pictureBox1.Location = new System.Drawing.Point(91, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // quitter
            // 
            this.quitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quitter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter.Location = new System.Drawing.Point(235, 282);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(120, 49);
            this.quitter.TabIndex = 1;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = false;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // valider
            // 
            this.valider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valider.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Location = new System.Drawing.Point(82, 282);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(114, 49);
            this.valider.TabIndex = 0;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(36, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bienvenue sur clinicoffice";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::clinique.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(446, 362);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "clinicoffice";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox Password;
        private System.Windows.Forms.Label label4;
    }
}

