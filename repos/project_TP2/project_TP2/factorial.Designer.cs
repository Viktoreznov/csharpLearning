namespace project_TP2
{
    partial class factorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.res = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(200, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factoriel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.res);
            this.groupBox2.Controls.Add(this.btnCalc);
            this.groupBox2.Controls.Add(this.value);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(27, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(41, 99);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(101, 23);
            this.res.TabIndex = 3;
            this.res.Text = "Resultat";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalc.Image = global::project_TP2.Properties.Resources.calculator;
            this.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalc.Location = new System.Drawing.Point(271, 26);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(127, 50);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculer";
            this.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // value
            // 
            this.value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.Location = new System.Drawing.Point(9, 46);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(177, 30);
            this.value.TabIndex = 1;
            this.value.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "donner un entier positif :";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::project_TP2.Properties.Resources.back;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(72, 227);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 47);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Retour";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Image = global::project_TP2.Properties.Resources.exit;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(312, 227);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(132, 47);
            this.exit.TabIndex = 4;
            this.exit.Text = "Quitter";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 286);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "factorial";
            this.Text = "factorial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button exit;
    }
}