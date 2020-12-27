namespace project_TP2
{
    partial class table
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enrgNote = new System.Windows.Forms.Button();
            this.arrayOfNumber = new System.Windows.Forms.Label();
            this.noteMat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.more = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.less = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ecart = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.moy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enrgNote);
            this.groupBox1.Controls.Add(this.arrayOfNumber);
            this.groupBox1.Controls.Add(this.noteMat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement des notes";
            // 
            // enrgNote
            // 
            this.enrgNote.Enabled = false;
            this.enrgNote.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.enrgNote.Image = global::project_TP2.Properties.Resources.add;
            this.enrgNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enrgNote.Location = new System.Drawing.Point(472, 34);
            this.enrgNote.Name = "enrgNote";
            this.enrgNote.Size = new System.Drawing.Size(178, 53);
            this.enrgNote.TabIndex = 3;
            this.enrgNote.Text = "Enregistrer";
            this.enrgNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enrgNote.UseVisualStyleBackColor = true;
            this.enrgNote.Click += new System.EventHandler(this.enrgNote_Click);
            // 
            // arrayOfNumber
            // 
            this.arrayOfNumber.AutoSize = true;
            this.arrayOfNumber.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.arrayOfNumber.Location = new System.Drawing.Point(6, 126);
            this.arrayOfNumber.Name = "arrayOfNumber";
            this.arrayOfNumber.Size = new System.Drawing.Size(224, 26);
            this.arrayOfNumber.TabIndex = 2;
            this.arrayOfNumber.Text = "Les Notes Sont : ";
            // 
            // noteMat
            // 
            this.noteMat.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.noteMat.Location = new System.Drawing.Point(318, 55);
            this.noteMat.MaxLength = 5;
            this.noteMat.Name = "noteMat";
            this.noteMat.Size = new System.Drawing.Size(100, 32);
            this.noteMat.TabIndex = 1;
            this.noteMat.TextChanged += new System.EventHandler(this.noteMat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez la note d\'éleve N° :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::project_TP2.Properties.Resources.exit;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(553, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Quitter";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::project_TP2.Properties.Resources.back;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(553, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "Retour";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::project_TP2.Properties.Resources.calculator;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(553, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Calculer";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.more);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(325, 189);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(72, 46);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // more
            // 
            this.more.AutoSize = true;
            this.more.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.more.Location = new System.Drawing.Point(7, 17);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(16, 18);
            this.more.TabIndex = 0;
            this.more.Text = "-";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.less);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(307, 137);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(72, 46);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // less
            // 
            this.less.AutoSize = true;
            this.less.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.less.Location = new System.Drawing.Point(7, 17);
            this.less.Name = "less";
            this.less.Size = new System.Drawing.Size(16, 18);
            this.less.TabIndex = 0;
            this.less.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ecart);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(294, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(72, 46);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // ecart
            // 
            this.ecart.AutoSize = true;
            this.ecart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecart.Location = new System.Drawing.Point(6, 17);
            this.ecart.Name = "ecart";
            this.ecart.Size = new System.Drawing.Size(16, 18);
            this.ecart.TabIndex = 0;
            this.ecart.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.moy);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(294, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(72, 46);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // moy
            // 
            this.moy.AutoSize = true;
            this.moy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moy.Location = new System.Drawing.Point(7, 16);
            this.moy.Name = "moy";
            this.moy.Size = new System.Drawing.Size(16, 18);
            this.moy.TabIndex = 0;
            this.moy.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre des notes >=10 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre des notes <10 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "L\'ecart Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Moyenne de la classe : ";
            // 
            // table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "table";
            this.Text = "table";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label arrayOfNumber;
        private System.Windows.Forms.TextBox noteMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label more;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label less;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ecart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label moy;
        private System.Windows.Forms.Button enrgNote;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}