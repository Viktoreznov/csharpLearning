namespace billetTrain
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
            this.label1 = new System.Windows.Forms.Label();
            this.prixBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prixTtc = new System.Windows.Forms.TextBox();
            this.tva = new System.Windows.Forms.TextBox();
            this.prixHt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.reduceBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prix";
            // 
            // prixBase
            // 
            this.prixBase.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixBase.Location = new System.Drawing.Point(135, 37);
            this.prixBase.Name = "prixBase";
            this.prixBase.Size = new System.Drawing.Size(153, 33);
            this.prixBase.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type B.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reduction";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prixTtc);
            this.groupBox1.Controls.Add(this.tva);
            this.groupBox1.Controls.Add(this.prixHt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(28, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 205);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // prixTtc
            // 
            this.prixTtc.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.prixTtc.Location = new System.Drawing.Point(136, 151);
            this.prixTtc.Name = "prixTtc";
            this.prixTtc.Size = new System.Drawing.Size(145, 32);
            this.prixTtc.TabIndex = 1;
            // 
            // tva
            // 
            this.tva.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.tva.Location = new System.Drawing.Point(136, 91);
            this.tva.Name = "tva";
            this.tva.Size = new System.Drawing.Size(145, 32);
            this.tva.TabIndex = 1;
            // 
            // prixHt
            // 
            this.prixHt.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.prixHt.Location = new System.Drawing.Point(136, 29);
            this.prixHt.Name = "prixHt";
            this.prixHt.Size = new System.Drawing.Size(145, 32);
            this.prixHt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Prix TTC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "TVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prix HT.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(135, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Calculer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // classBox
            // 
            this.classBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classBox.FormattingEnabled = true;
            this.classBox.Location = new System.Drawing.Point(135, 102);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(227, 33);
            this.classBox.TabIndex = 9;
            // 
            // reduceBox
            // 
            this.reduceBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Pas de réduction",
            "Carte Jeune",
            "Carte Adult",
            "Carte Famille"});
            this.reduceBox.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.reduceBox.FormattingEnabled = true;
            this.reduceBox.Location = new System.Drawing.Point(156, 154);
            this.reduceBox.Name = "reduceBox";
            this.reduceBox.Size = new System.Drawing.Size(220, 31);
            this.reduceBox.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(249, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Réinitialiser";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 510);
            this.Controls.Add(this.reduceBox);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prixBase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prixBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox prixTtc;
        private System.Windows.Forms.TextBox tva;
        private System.Windows.Forms.TextBox prixHt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.ComboBox reduceBox;
        private System.Windows.Forms.Button button3;
    }
}

