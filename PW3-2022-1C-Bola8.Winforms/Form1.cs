using PW3_2022_1C_Bola8.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW3_2022_1C_Bola8.Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPreg_Click(object sender, EventArgs e)
        {
            lblRta.Text = $"{Bola8.Pregunta()}";
        }
    }
}
