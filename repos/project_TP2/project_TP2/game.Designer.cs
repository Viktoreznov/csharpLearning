namespace project_TP2
{
    partial class game
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberOfTry = new System.Windows.Forms.Label();
            this.hideResult = new System.Windows.Forms.Button();
            this.showResult = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.val4Box = new System.Windows.Forms.GroupBox();
            this.val4 = new System.Windows.Forms.Label();
            this.val3Box = new System.Windows.Forms.GroupBox();
            this.val3 = new System.Windows.Forms.Label();
            this.val2Box = new System.Windows.Forms.GroupBox();
            this.val2 = new System.Windows.Forms.Label();
            this.val1Box = new System.Windows.Forms.GroupBox();
            this.val1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Verify = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.v4 = new System.Windows.Forms.TextBox();
            this.v3 = new System.Windows.Forms.TextBox();
            this.v2 = new System.Windows.Forms.TextBox();
            this.v1 = new System.Windows.Forms.TextBox();
            this.tryAgain = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.back = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.val4Box.SuspendLayout();
            this.val3Box.SuspendLayout();
            this.val2Box.SuspendLayout();
            this.val1Box.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Caché";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numberOfTry);
            this.groupBox1.Controls.Add(this.hideResult);
            this.groupBox1.Controls.Add(this.showResult);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.newGame);
            this.groupBox1.Location = new System.Drawing.Point(32, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // numberOfTry
            // 
            this.numberOfTry.AutoSize = true;
            this.numberOfTry.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTry.Location = new System.Drawing.Point(281, 103);
            this.numberOfTry.Name = "numberOfTry";
            this.numberOfTry.Size = new System.Drawing.Size(27, 25);
            this.numberOfTry.TabIndex = 3;
            this.numberOfTry.Text = "0";
            // 
            // hideResult
            // 
            this.hideResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideResult.Image = global::project_TP2.Properties.Resources.hide;
            this.hideResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hideResult.Location = new System.Drawing.Point(564, 71);
            this.hideResult.Name = "hideResult";
            this.hideResult.Size = new System.Drawing.Size(98, 46);
            this.hideResult.TabIndex = 2;
            this.hideResult.Text = "cacher";
            this.hideResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hideResult.UseVisualStyleBackColor = true;
            this.hideResult.Click += new System.EventHandler(this.hideResult_Click);
            // 
            // showResult
            // 
            this.showResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showResult.Image = global::project_TP2.Properties.Resources.eye;
            this.showResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showResult.Location = new System.Drawing.Point(564, 19);
            this.showResult.Name = "showResult";
            this.showResult.Size = new System.Drawing.Size(98, 46);
            this.showResult.TabIndex = 2;
            this.showResult.Text = "Afficher";
            this.showResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showResult.UseVisualStyleBackColor = true;
            this.showResult.Click += new System.EventHandler(this.showResult_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.val4Box);
            this.groupBox2.Controls.Add(this.val3Box);
            this.groupBox2.Controls.Add(this.val2Box);
            this.groupBox2.Controls.Add(this.val1Box);
            this.groupBox2.Location = new System.Drawing.Point(162, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "numero a devinir";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // val4Box
            // 
            this.val4Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.val4Box.Controls.Add(this.val4);
            this.val4Box.Location = new System.Drawing.Point(281, 17);
            this.val4Box.Name = "val4Box";
            this.val4Box.Size = new System.Drawing.Size(69, 50);
            this.val4Box.TabIndex = 0;
            this.val4Box.TabStop = false;
            // 
            // val4
            // 
            this.val4.AutoSize = true;
            this.val4.Font = new System.Drawing.Font("Verdana", 19F, System.Drawing.FontStyle.Bold);
            this.val4.Location = new System.Drawing.Point(17, 11);
            this.val4.Name = "val4";
            this.val4.Size = new System.Drawing.Size(33, 32);
            this.val4.TabIndex = 0;
            this.val4.Text = "8";
            // 
            // val3Box
            // 
            this.val3Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.val3Box.Controls.Add(this.val3);
            this.val3Box.Location = new System.Drawing.Point(189, 17);
            this.val3Box.Name = "val3Box";
            this.val3Box.Size = new System.Drawing.Size(69, 50);
            this.val3Box.TabIndex = 0;
            this.val3Box.TabStop = false;
            // 
            // val3
            // 
            this.val3.AutoSize = true;
            this.val3.Font = new System.Drawing.Font("Verdana", 19F, System.Drawing.FontStyle.Bold);
            this.val3.Location = new System.Drawing.Point(17, 11);
            this.val3.Name = "val3";
            this.val3.Size = new System.Drawing.Size(33, 32);
            this.val3.TabIndex = 0;
            this.val3.Text = "8";
            // 
            // val2Box
            // 
            this.val2Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.val2Box.Controls.Add(this.val2);
            this.val2Box.Location = new System.Drawing.Point(96, 17);
            this.val2Box.Name = "val2Box";
            this.val2Box.Size = new System.Drawing.Size(69, 50);
            this.val2Box.TabIndex = 0;
            this.val2Box.TabStop = false;
            // 
            // val2
            // 
            this.val2.AutoSize = true;
            this.val2.Font = new System.Drawing.Font("Verdana", 19F, System.Drawing.FontStyle.Bold);
            this.val2.Location = new System.Drawing.Point(17, 11);
            this.val2.Name = "val2";
            this.val2.Size = new System.Drawing.Size(33, 32);
            this.val2.TabIndex = 0;
            this.val2.Text = "8";
            // 
            // val1Box
            // 
            this.val1Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.val1Box.Controls.Add(this.val1);
            this.val1Box.Location = new System.Drawing.Point(12, 17);
            this.val1Box.Name = "val1Box";
            this.val1Box.Size = new System.Drawing.Size(69, 50);
            this.val1Box.TabIndex = 0;
            this.val1Box.TabStop = false;
            // 
            // val1
            // 
            this.val1.AutoSize = true;
            this.val1.Font = new System.Drawing.Font("Verdana", 19F, System.Drawing.FontStyle.Bold);
            this.val1.Location = new System.Drawing.Point(17, 11);
            this.val1.Name = "val1";
            this.val1.Size = new System.Drawing.Size(33, 32);
            this.val1.TabIndex = 0;
            this.val1.Text = "8";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Verify);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.tryAgain);
            this.groupBox7.Location = new System.Drawing.Point(38, 276);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(731, 118);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            // 
            // Verify
            // 
            this.Verify.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verify.Image = global::project_TP2.Properties.Resources.list;
            this.Verify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Verify.Location = new System.Drawing.Point(590, 30);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(123, 56);
            this.Verify.TabIndex = 2;
            this.Verify.Text = "Valider";
            this.Verify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Verify.UseVisualStyleBackColor = true;
            this.Verify.Click += new System.EventHandler(this.Verify_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.v4);
            this.groupBox8.Controls.Add(this.v3);
            this.groupBox8.Controls.Add(this.v2);
            this.groupBox8.Controls.Add(this.v1);
            this.groupBox8.Location = new System.Drawing.Point(171, 18);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(402, 72);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Your try";
            // 
            // v4
            // 
            this.v4.Font = new System.Drawing.Font("Verdana", 19F, System.Drawing.FontStyle.Bold);
            this.v4.Location = new System.Drawing.Point(289, 26);
            this.v4.MaxLength = 1;
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(61, 38);
            this.v4.TabIndex = 0;
            // 
            // v3
            // 
            this.v3.Font = new System.Drawing.Font("Verdana", 19F, System.Drawing.FontStyle.Bold);
            this.v3.Location = new System.Drawing.Point(200, 26);
            this.v3.MaxLength = 1;
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(61, 38);
            this.v3.TabIndex = 0;
            // 
            // v2
            // 
            this.v2.Font = new System.Drawing.Font("Verdana", 19F, System.Drawing.FontStyle.Bold);
            this.v2.Location = new System.Drawing.Point(109, 26);
            this.v2.MaxLength = 1;
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(61, 38);
            this.v2.TabIndex = 0;
            // 
            // v1
            // 
            this.v1.Font = new System.Drawing.Font("Verdana", 19F, System.Drawing.FontStyle.Bold);
            this.v1.Location = new System.Drawing.Point(20, 26);
            this.v1.MaxLength = 1;
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(61, 38);
            this.v1.TabIndex = 0;
            // 
            // tryAgain
            // 
            this.tryAgain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgain.Image = global::project_TP2.Properties.Resources.clear;
            this.tryAgain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tryAgain.Location = new System.Drawing.Point(24, 30);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(126, 56);
            this.tryAgain.TabIndex = 0;
            this.tryAgain.Text = "Rejouer";
            this.tryAgain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tryAgain.UseVisualStyleBackColor = true;
            this.tryAgain.Click += new System.EventHandler(this.tryAgain_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Verdana", 16F);
            this.exit.Image = global::project_TP2.Properties.Resources.exit;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(453, 400);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(241, 48);
            this.exit.TabIndex = 3;
            this.exit.Text = "Quitter";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Verdana", 16F);
            this.back.Image = global::project_TP2.Properties.Resources.back;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(118, 400);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(241, 48);
            this.back.TabIndex = 4;
            this.back.Text = "Retour";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // newGame
            // 
            this.newGame.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.newGame.Image = global::project_TP2.Properties.Resources.replay;
            this.newGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newGame.Location = new System.Drawing.Point(6, 19);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(150, 65);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "New Game";
            this.newGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "game";
            this.Load += new System.EventHandler(this.game_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.val4Box.ResumeLayout(false);
            this.val4Box.PerformLayout();
            this.val3Box.ResumeLayout(false);
            this.val3Box.PerformLayout();
            this.val2Box.ResumeLayout(false);
            this.val2Box.PerformLayout();
            this.val1Box.ResumeLayout(false);
            this.val1Box.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox val1Box;
        private System.Windows.Forms.Label numberOfTry;
        private System.Windows.Forms.Button hideResult;
        private System.Windows.Forms.Button showResult;
        private System.Windows.Forms.GroupBox val4Box;
        private System.Windows.Forms.Label val4;
        private System.Windows.Forms.GroupBox val3Box;
        private System.Windows.Forms.Label val3;
        private System.Windows.Forms.GroupBox val2Box;
        private System.Windows.Forms.Label val2;
        private System.Windows.Forms.Label val1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button tryAgain;
        private System.Windows.Forms.Button Verify;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox v4;
        private System.Windows.Forms.TextBox v3;
        private System.Windows.Forms.TextBox v2;
        private System.Windows.Forms.TextBox v1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button back;
    }
}