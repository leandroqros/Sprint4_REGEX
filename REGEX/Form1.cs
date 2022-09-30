using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace REGEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_movil_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(txt_movil_y.Text);
            bool match = rgx.IsMatch(txt_movil.Text);
            if (match)
            {
                pnl_movil.BackColor = Color.Green;
                txt_movil_y.Text = "Correcto!";
            } else
            {
                pnl_movil.BackColor = Color.Red;
                txt_movil_y.Text = "Incorrecto...";
            }
        }
    }
}
