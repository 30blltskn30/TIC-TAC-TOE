namespace CS_Tic_Tac_Toe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnExıt = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPlayerO = new System.Windows.Forms.Label();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.PlayerO = new System.Windows.Forms.Label();
            this.PlayerX = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(350, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1441, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(405, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIC TAC TOE GAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(350, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1441, 758);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(853, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(567, 704);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btnExıt);
            this.panel6.Controls.Add(this.btnNewGame);
            this.panel6.Controls.Add(this.btnReset);
            this.panel6.Location = new System.Drawing.Point(20, 358);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(521, 293);
            this.panel6.TabIndex = 3;
            // 
            // btnExıt
            // 
            this.btnExıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExıt.Location = new System.Drawing.Point(262, 157);
            this.btnExıt.Name = "btnExıt";
            this.btnExıt.Size = new System.Drawing.Size(252, 110);
            this.btnExıt.TabIndex = 21;
            this.btnExıt.Text = "Exit";
            this.btnExıt.UseVisualStyleBackColor = true;
            this.btnExıt.Click += new System.EventHandler(this.btnExıt_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewGame.Location = new System.Drawing.Point(3, 26);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(511, 100);
            this.btnNewGame.TabIndex = 22;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseCompatibleTextRendering = true;
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.Location = new System.Drawing.Point(3, 157);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(253, 110);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblPlayerO);
            this.panel5.Controls.Add(this.lblPlayerX);
            this.panel5.Controls.Add(this.PlayerO);
            this.panel5.Controls.Add(this.PlayerX);
            this.panel5.Location = new System.Drawing.Point(20, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(521, 279);
            this.panel5.TabIndex = 2;
            // 
            // lblPlayerO
            // 
            this.lblPlayerO.BackColor = System.Drawing.Color.White;
            this.lblPlayerO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayerO.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPlayerO.Location = new System.Drawing.Point(303, 115);
            this.lblPlayerO.Name = "lblPlayerO";
            this.lblPlayerO.Size = new System.Drawing.Size(141, 69);
            this.lblPlayerO.TabIndex = 4;
            this.lblPlayerO.Text = "0";
            this.lblPlayerO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.BackColor = System.Drawing.Color.White;
            this.lblPlayerX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayerX.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPlayerX.Location = new System.Drawing.Point(303, 32);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(141, 69);
            this.lblPlayerX.TabIndex = 3;
            this.lblPlayerX.Text = "0";
            this.lblPlayerX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerO
            // 
            this.PlayerO.AutoSize = true;
            this.PlayerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlayerO.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PlayerO.Location = new System.Drawing.Point(9, 115);
            this.PlayerO.Name = "PlayerO";
            this.PlayerO.Size = new System.Drawing.Size(288, 69);
            this.PlayerO.TabIndex = 2;
            this.PlayerO.Text = "Player O:";
            // 
            // PlayerX
            // 
            this.PlayerX.AutoSize = true;
            this.PlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlayerX.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PlayerX.Location = new System.Drawing.Point(16, 32);
            this.PlayerX.Name = "PlayerX";
            this.PlayerX.Size = new System.Drawing.Size(281, 69);
            this.PlayerX.TabIndex = 1;
            this.PlayerX.Text = "Player X:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(29, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 704);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(24, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 217);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(494, 466);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(229, 212);
            this.button9.TabIndex = 19;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(494, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(229, 218);
            this.button6.TabIndex = 18;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(494, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 217);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(259, 466);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(229, 212);
            this.button8.TabIndex = 16;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(259, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 218);
            this.button5.TabIndex = 15;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(259, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 217);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(24, 466);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(229, 212);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(24, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 218);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1802, 1007);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExıt;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.Label PlayerO;
        private System.Windows.Forms.Label PlayerX;
        private System.Windows.Forms.Label lblPlayerO;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

