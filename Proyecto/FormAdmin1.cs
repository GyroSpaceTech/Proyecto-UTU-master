using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormAdmin1 : Form
    {
        public FormAdmin1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdmin2 fa2 = new FormAdmin2();
            fa2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdmin3 fa3 = new FormAdmin3();
            fa3.Show();
        }
    }
}
