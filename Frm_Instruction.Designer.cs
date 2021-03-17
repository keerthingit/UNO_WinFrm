namespace UNO
{
    partial class Frm_Instruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Instruction));
            this.pic_title_ins = new System.Windows.Forms.PictureBox();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.pic_ins = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title_ins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ins)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_title_ins
            // 
            this.pic_title_ins.Image = ((System.Drawing.Image)(resources.GetObject("pic_title_ins.Image")));
            this.pic_title_ins.Location = new System.Drawing.Point(121, 60);
            this.pic_title_ins.Name = "pic_title_ins";
            this.pic_title_ins.Size = new System.Drawing.Size(394, 38);
            this.pic_title_ins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_title_ins.TabIndex = 0;
            this.pic_title_ins.TabStop = false;
            // 
            // pic_back
            // 
            this.pic_back.Image = ((System.Drawing.Image)(resources.GetObject("pic_back.Image")));
            this.pic_back.Location = new System.Drawing.Point(55, 547);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(79, 20);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_back.TabIndex = 2;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.Pic_back_Click);
            // 
            // pic_ins
            // 
            this.pic_ins.Image = ((System.Drawing.Image)(resources.GetObject("pic_ins.Image")));
            this.pic_ins.Location = new System.Drawing.Point(37, 158);
            this.pic_ins.Name = "pic_ins";
            this.pic_ins.Size = new System.Drawing.Size(544, 294);
            this.pic_ins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_ins.TabIndex = 3;
            this.pic_ins.TabStop = false;
            // 
            // Frm_Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(796, 670);
            this.Controls.Add(this.pic_ins);
            this.Controls.Add(this.pic_back);
            this.Controls.Add(this.pic_title_ins);
            this.Name = "Frm_Instruction";
            this.Text = "UNO Cards Game";
            ((System.ComponentModel.ISupportInitialize)(this.pic_title_ins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_title_ins;
        private System.Windows.Forms.PictureBox pic_back;
        private System.Windows.Forms.PictureBox pic_ins;
    }
}