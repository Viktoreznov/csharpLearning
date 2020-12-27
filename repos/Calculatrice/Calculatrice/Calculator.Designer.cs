namespace Calculatrice
{
    partial class Calculator
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
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mul = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(12, 37);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(85, 45);
            this.n1.TabIndex = 0;
            this.n1.TextChanged += new System.EventHandler(this.n1_TextChanged);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(176, 37);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(90, 45);
            this.n2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number2";
            // 
            // Mul
            // 
            this.Mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mul.Location = new System.Drawing.Point(15, 186);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(82, 43);
            this.Mul.TabIndex = 2;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Div.Location = new System.Drawing.Point(176, 186);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(82, 43);
            this.Div.TabIndex = 2;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(15, 117);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(82, 43);
            this.add.TabIndex = 2;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Sub
            // 
            this.Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub.Location = new System.Drawing.Point(176, 117);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(82, 43);
            this.Sub.TabIndex = 2;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 248);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Sub;
    }
}