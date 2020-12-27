namespace Liste_des_Prog_Lang
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
            this.ls1 = new System.Windows.Forms.ListBox();
            this.ls2 = new System.Windows.Forms.ListBox();
            this.lr = new System.Windows.Forms.Button();
            this.rl = new System.Windows.Forms.Button();
            this.lra = new System.Windows.Forms.Button();
            this.rla = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ls1
            // 
            this.ls1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ls1.FormattingEnabled = true;
            this.ls1.ItemHeight = 29;
            this.ls1.Location = new System.Drawing.Point(12, 12);
            this.ls1.Name = "ls1";
            this.ls1.Size = new System.Drawing.Size(254, 410);
            this.ls1.TabIndex = 0;
            // 
            // ls2
            // 
            this.ls2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ls2.FormattingEnabled = true;
            this.ls2.ItemHeight = 29;
            this.ls2.Location = new System.Drawing.Point(474, 12);
            this.ls2.Name = "ls2";
            this.ls2.Size = new System.Drawing.Size(254, 410);
            this.ls2.TabIndex = 0;
            // 
            // lr
            // 
            this.lr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr.Location = new System.Drawing.Point(272, 43);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(82, 52);
            this.lr.TabIndex = 1;
            this.lr.Text = "<";
            this.lr.UseVisualStyleBackColor = true;
            this.lr.Click += new System.EventHandler(this.lr_Click);
            // 
            // rl
            // 
            this.rl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rl.Location = new System.Drawing.Point(386, 43);
            this.rl.Name = "rl";
            this.rl.Size = new System.Drawing.Size(82, 52);
            this.rl.TabIndex = 1;
            this.rl.Text = ">";
            this.rl.UseVisualStyleBackColor = true;
            this.rl.Click += new System.EventHandler(this.rl_Click);
            // 
            // lra
            // 
            this.lra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lra.Location = new System.Drawing.Point(272, 139);
            this.lra.Name = "lra";
            this.lra.Size = new System.Drawing.Size(82, 52);
            this.lra.TabIndex = 1;
            this.lra.Text = "<<";
            this.lra.UseVisualStyleBackColor = true;
            this.lra.Click += new System.EventHandler(this.lra_Click);
            // 
            // rla
            // 
            this.rla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rla.Location = new System.Drawing.Point(386, 139);
            this.rla.Name = "rla";
            this.rla.Size = new System.Drawing.Size(82, 52);
            this.rla.TabIndex = 1;
            this.rla.Text = ">>";
            this.rla.UseVisualStyleBackColor = true;
            this.rla.Click += new System.EventHandler(this.rla_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(272, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 52);
            this.button5.TabIndex = 1;
            this.button5.Text = "Up";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(272, 362);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 52);
            this.button6.TabIndex = 1;
            this.button6.Text = "down";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.rla);
            this.Controls.Add(this.rl);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lra);
            this.Controls.Add(this.lr);
            this.Controls.Add(this.ls2);
            this.Controls.Add(this.ls1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ls1;
        private System.Windows.Forms.ListBox ls2;
        private System.Windows.Forms.Button lr;
        private System.Windows.Forms.Button rl;
        private System.Windows.Forms.Button lra;
        private System.Windows.Forms.Button rla;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

