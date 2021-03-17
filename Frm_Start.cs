using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;



namespace UNO
{
    //Start Page
    //Keerthi - Code and button design
    //Breannna - UNO title pixel art and helped Katrina 
    //Katrina - UNO cards icon pixel art 
    //Date: 03/06/2019
    public partial class Frm_Start : Form
    {
        public Frm_Start()
        {
            InitializeComponent();
            
        }
        
        private void Btn_play_Click(object sender, EventArgs e)//event when btn_play is clicked
        {
            Frm_Game openForm = new Frm_Game();//frm_game is open form
            openForm.Show();//the open form is shown
            Visible = false;//the previous form is closed
            
            


        }

        private void Frm_Start_Load(object sender, EventArgs e)
        {
            //I think I made this by mistake (-_-;)
        }

        private void Pic_instructions_Click(object sender, EventArgs e)//event when btn_instruction is clicked
        {
            Frm_Instruction openForm = new Frm_Instruction();//frm_instruction is open form
            openForm.Show();//the open form is shown
            Visible = false;//the previous form is closed
        }

        private void Pic_cards_Click(object sender, EventArgs e)
        {
            //I think I made this by mistake (-_-;)
        }
    }
}
