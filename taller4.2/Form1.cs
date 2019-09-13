using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = 0;          
            int limite = 19;
            for (int i = 0; i <= limite; i++)
            {

                numero = numero - 2;
                listBox1.Items.Add(numero.ToString());

            }
        }
    }
}
