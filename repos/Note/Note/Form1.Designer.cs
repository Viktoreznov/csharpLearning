namespace Note
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
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.tp = new System.Windows.Forms.TextBox();
            this.ds = new System.Windows.Forms.TextBox();
            this.ex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(130, 78);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 0;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(351, 78);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 20);
            this.prenom.TabIndex = 1;
            // 
            // tp
            // 
            this.tp.Location = new System.Drawing.Point(130, 210);
            this.tp.Name = "tp";
            this.tp.Size = new System.Drawing.Size(142, 20);
            this.tp.TabIndex = 2;
            // 
            // ds
            // 
            this.ds.Location = new System.Drawing.Point(130, 141);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(142, 20);
            this.ds.TabIndex = 3;
            // 
            // ex
            // 
            this.ex.Location = new System.Drawing.Point(130, 272);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(142, 20);
            this.ex.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(288, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pernom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Examen";
            // 
            // lb
            // 
            this.lb.ColumnWidth = 2;
            this.lb.FormattingEnabled = true;
            this.lb.Items.AddRange(new object[] {
            "Ahlem 15.41"});
            this.lb.Location = new System.Drawing.Point(492, 30);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(260, 368);
            this.lb.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "vider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 422);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.ds);
            this.Controls.Add(this.tp);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Name = "Form1";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox tp;
        private System.Windows.Forms.TextBox ds;
        private System.Windows.Forms.TextBox ex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

