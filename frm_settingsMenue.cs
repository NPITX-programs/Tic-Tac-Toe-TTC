using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeProject
{
    public partial class frm_settingsMenue : Form
    {
        public frm_settingsMenue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(this);
        }
    }
}
