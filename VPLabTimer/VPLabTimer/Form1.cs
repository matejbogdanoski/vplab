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
    public partial class Form1 : Form
    {
        private static readonly int TIME = 60;
        private int timeElapsed;
        private int rezultat;
        private List<Igrach> igrachi;

        public Form1()
        {
            InitializeComponent();
            newGame();
            igrachi = new List<Igrach>();
          
        }

        public int newEquation()
        {
            Equation e = new Equation();
            txtOp1.Text = e.Operand1.ToString();
            txtOp2.Text = e.Operand2.ToString();
            txtZnak.Text = e.Znak.ToString();
            return e.Rezultat;
        }

        public void newGame()
        {
            rezultat = newEquation();
            txtIgrac.Text = "";
            timeElapsed = 0;
            lblPoeni.Text = "0";
            timer1.Start();
            pbPoeni.Value = 0;
            pbVreme.Value = TIME;
        }

        public void endGame()
        {
           
            Igrach igrach = new Igrach(txtIgrac.Text,Convert.ToInt32(lblPoeni.Text));
            igrachi.Add(igrach);
            DialogResult result = MessageBox.Show("Играта е завршена! \n" + igrach.ToString());

        }

        private void updateTime()
        {
            int left = TIME - timeElapsed;
            int min = left / 60;
            int sec = left % 60;
            lblVreme.Text = String.Format("{0:00}:{1:00}", min, sec);

        }

        private void btnIskluci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void btnPogodi_Click(object sender, EventArgs e)
        {
            if (txtGuess.Text == "") return;
            if(Convert.ToInt32(txtGuess.Text) == rezultat)
            {
                int poeni = Convert.ToInt32(lblPoeni.Text) + 1;
                if (poeni % 10 == 0) timeElapsed -= 10;
                lblPoeni.Text = Convert.ToString(poeni);
                pbPoeni.Value++;
            }
            rezultat = newEquation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            pbVreme.Value = TIME - timeElapsed;
            updateTime();
            if (timeElapsed == TIME)
            {
                timer1.Stop();
                endGame();
            }
            
        
            
        }

        private void btnNajdobriIgraci_Click(object sender, EventArgs e)
        {
            igrachi = igrachi.OrderByDescending(x => x.Poeni).ToList();
            Igrachi form = new Igrachi(igrachi);
            form.ShowDialog();
        }
    }
}
