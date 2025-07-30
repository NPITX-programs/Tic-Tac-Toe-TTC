using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ticTacToe;

namespace Tic_Tac_Toe_TTC
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_viewDebug_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms["frm_debugInfo"];
            if (frm == null)
            {
                frm = new frm_debugInfoForm();
                frm.Show();
            }
            else
            {
                frm.BringToFront();
            }
        }
    }
}
