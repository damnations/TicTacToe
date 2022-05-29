namespace TicTacToe
{
    partial class GameBoard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.newGameButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.button33, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button32, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button31, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button23, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button22, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button21, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button13, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button12, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button11, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 354);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button33
            // 
            this.button33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button33.Location = new System.Drawing.Point(531, 239);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(260, 112);
            this.button33.TabIndex = 8;
            this.button33.Text = "button9";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttons_KeyPress);
            this.button33.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.button33.MouseHover += new System.EventHandler(this.buttons_MouseHover);
            // 
            // button32
            // 
            this.button32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button32.Location = new System.Drawing.Point(267, 239);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(258, 112);
            this.button32.TabIndex = 7;
            this.button32.Text = "button8";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttons_KeyPress);
            this.button32.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.button32.MouseHover += new System.EventHandler(this.buttons_MouseHover);
            // 
            // button31
            // 
            this.button31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button31.Location = new System.Drawing.Point(3, 239);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(258, 112);
            this.button31.TabIndex = 6;
            this.button31.Text = "button7";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttons_KeyPress);
            this.button31.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.button31.MouseHover += new System.EventHandler(this.buttons_MouseHover);
            // 
            // button23
            // 
            this.button23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button23.Location = new System.Drawing.Point(531, 121);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(260, 112);
            this.button23.TabIndex = 5;
            this.button23.Text = "button6";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttons_KeyPress);
            this.button23.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.button23.MouseHover += new System.EventHandler(this.buttons_MouseHover);
            // 
            // button22
            // 
            this.button22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button22.Location = new System.Drawing.Point(267, 121);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(258, 112);
            this.button22.TabIndex = 4;
            this.button22.Text = "button5";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttons_KeyPress);
            this.button22.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.button22.MouseHover += new System.EventHandler(this.buttons_MouseHover);
            // 
            // button21
            // 
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.Location = new System.Drawing.Point(3, 121);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(258, 112);
            this.button21.TabIndex = 3;
            this.button21.Text = "button4";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttons_KeyPress);
            this.button21.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.button21.MouseHover += new System.EventHandler(this.buttons_MouseHover);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Location = new System.Drawing.Point(531, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(260, 112);
            this.button13.TabIndex = 2;
            this.button13.Text = "button3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttons_KeyPress);
            this.button13.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.button13.MouseHover += new System.EventHandler(this.buttons_MouseHover);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(267, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(258, 112);
            this.button12.TabIndex = 1;
            this.button12.Text = "button2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttons_KeyPress);
            this.button12.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.button12.MouseHover += new System.EventHandler(this.buttons_MouseHover);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(3, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(258, 112);
            this.button11.TabIndex = 0;
            this.button11.Text = "button1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttons_KeyPress);
            this.button11.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.button11.MouseHover += new System.EventHandler(this.buttons_MouseHover);
            // 
            // newGameButton
            // 
            this.newGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGameButton.Location = new System.Drawing.Point(3, 363);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(794, 84);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameBoard";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button newGameButton;
    }
}

