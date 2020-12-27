namespace connexion_a_la_base_de_donne
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
            this.tryConn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tryConn
            // 
            this.tryConn.Location = new System.Drawing.Point(83, 51);
            this.tryConn.Name = "tryConn";
            this.tryConn.Size = new System.Drawing.Size(120, 70);
            this.tryConn.TabIndex = 0;
            this.tryConn.Text = "Connecté ?";
            this.tryConn.UseVisualStyleBackColor = true;
            this.tryConn.Click += new System.EventHandler(this.tryConn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 160);
            this.Controls.Add(this.tryConn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tryConn;
    }
}

