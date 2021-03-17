namespace UNO
{
    partial class Frm_Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Start));
            this.pic_title = new System.Windows.Forms.PictureBox();
            this.pic_instructions = new System.Windows.Forms.PictureBox();
            this.pic_play = new System.Windows.Forms.PictureBox();
            this.pic_cards = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_instructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cards)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_title
            // 
            this.pic_title.Image = ((System.Drawing.Image)(resources.GetObject("pic_title.Image")));
            this.pic_title.Location = new System.Drawing.Point(139, 75);
            this.pic_title.Name = "pic_title";
            this.pic_title.Size = new System.Drawing.Size(378, 144);
            this.pic_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_title.TabIndex = 0;
            this.pic_title.TabStop = false;
            // 
            // pic_instructions
            // 
            this.pic_instructions.Image = ((System.Drawing.Image)(resources.GetObject("pic_instructions.Image")));
            this.pic_instructions.Location = new System.Drawing.Point(228, 543);
            this.pic_instructions.Name = "pic_instructions";
            this.pic_instructions.Size = new System.Drawing.Size(236, 23);
            this.pic_instructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_instructions.TabIndex = 2;
            this.pic_instructions.TabStop = false;
            this.pic_instructions.Click += new System.EventHandler(this.Pic_instructions_Click);
            // 
            // pic_play
            // 
            this.pic_play.Image = ((System.Drawing.Image)(resources.GetObject("pic_play.Image")));
            this.pic_play.Location = new System.Drawing.Point(321, 469);
            this.pic_play.Name = "pic_play";
            this.pic_play.Size = new System.Drawing.Size(90, 33);
            this.pic_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_play.TabIndex = 1;
            this.pic_play.TabStop = false;
            this.pic_play.Click += new System.EventHandler(this.Btn_play_Click);
            // 
            // pic_cards
            // 
            this.pic_cards.Image = ((System.Drawing.Image)(resources.GetObject("pic_cards.Image")));
            this.pic_cards.Location = new System.Drawing.Point(206, 273);
            this.pic_cards.Name = "pic_cards";
            this.pic_cards.Size = new System.Drawing.Size(270, 120);
            this.pic_cards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_cards.TabIndex = 3;
            this.pic_cards.TabStop = false;
            this.pic_cards.Click += new System.EventHandler(this.Pic_cards_Click);
            // 
            // Frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(792, 666);
            this.Controls.Add(this.pic_cards);
            this.Controls.Add(this.pic_instructions);
            this.Controls.Add(this.pic_play);
            this.Controls.Add(this.pic_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Start";
            this.Text = "UNO Cards Game";
            this.Load += new System.EventHandler(this.Frm_Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_instructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_title;
        private System.Windows.Forms.PictureBox pic_instructions;
        private System.Windows.Forms.PictureBox pic_play;
        private System.Windows.Forms.PictureBox pic_cards;
    }
}

