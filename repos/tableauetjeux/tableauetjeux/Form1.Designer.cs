namespace tableauetjeux
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.tab = new System.Windows.Forms.Label();
            this.lbmoy = new System.Windows.Forms.Label();
            this.infdix = new System.Windows.Forms.Label();
            this.supdix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "entre le note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "moyenn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "moyen <10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "moyen>10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "enre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "caluler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 7;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(342, 45);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 9;
            // 
            // tab
            // 
            this.tab.AutoSize = true;
            this.tab.Location = new System.Drawing.Point(342, 112);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(0, 13);
            this.tab.TabIndex = 10;
            // 
            // lbmoy
            // 
            this.lbmoy.AutoSize = true;
            this.lbmoy.Location = new System.Drawing.Point(296, 235);
            this.lbmoy.Name = "lbmoy";
            this.lbmoy.Size = new System.Drawing.Size(35, 13);
            this.lbmoy.TabIndex = 11;
            this.lbmoy.Text = "label8";
            // 
            // infdix
            // 
            this.infdix.AutoSize = true;
            this.infdix.Location = new System.Drawing.Point(296, 270);
            this.infdix.Name = "infdix";
            this.infdix.Size = new System.Drawing.Size(35, 13);
            this.infdix.TabIndex = 12;
            this.infdix.Text = "label9";
            // 
            // supdix
            // 
            this.supdix.AutoSize = true;
            this.supdix.Location = new System.Drawing.Point(296, 303);
            this.supdix.Name = "supdix";
            this.supdix.Size = new System.Drawing.Size(41, 13);
            this.supdix.TabIndex = 13;
            this.supdix.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.supdix);
            this.Controls.Add(this.infdix);
            this.Controls.Add(this.lbmoy);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "755";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label tab;
        private System.Windows.Forms.Label lbmoy;
        private System.Windows.Forms.Label infdix;
        private System.Windows.Forms.Label supdix;
    }
}

