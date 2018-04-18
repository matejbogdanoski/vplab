using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPLabTimer
{
    public partial class Igrachi : Form
    {
        public Igrachi(List<Igrach> igrachi)
        {
            InitializeComponent();
            foreach(Igrach i in igrachi)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
