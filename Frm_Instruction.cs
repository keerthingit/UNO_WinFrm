using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNO
{
    public partial class Frm_Instruction : Form
    {
        public Frm_Instruction()
        {
            InitializeComponent();
        }

        private void Pic_back_Click(object sender, EventArgs e)
        {
            Frm_Start openForm = new Frm_Start();//frm_instruction is open form
            openForm.Show();//the open form is shown
            Visible = false;//the previous form is closed
        }
    }
}
