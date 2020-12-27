namespace project_TP2
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
            this.btnFact = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnTab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFact
            // 
            this.btnFact.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnFact.Image = global::project_TP2.Properties.Resources.exclamation;
            this.btnFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFact.Location = new System.Drawing.Point(59, 25);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(132, 68);
            this.btnFact.TabIndex = 0;
            this.btnFact.Text = "Factoriel";
            this.btnFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFact.UseVisualStyleBackColor = true;
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.btnExit.Image = global::project_TP2.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(59, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 68);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Quitter";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGames
            // 
            this.btnGames.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGames.Image = global::project_TP2.Properties.Resources.game_controller;
            this.btnGames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGames.Location = new System.Drawing.Point(59, 205);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(132, 68);
            this.btnGames.TabIndex = 0;
            this.btnGames.Text = "Jouer";
            this.btnGames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnTab
            // 
            this.btnTab.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.btnTab.Image = global::project_TP2.Properties.Resources.array;
            this.btnTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTab.Location = new System.Drawing.Point(59, 116);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(132, 68);
            this.btnTab.TabIndex = 0;
            this.btnTab.Text = "Les Tableaux";
            this.btnTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTab.UseVisualStyleBackColor = true;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 381);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGames);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.btnFact);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnExit;
    }
}

