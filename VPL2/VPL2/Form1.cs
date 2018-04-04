using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPL2
{
    public partial class Form1 : Form
    {

        public void calculateTotal()
        {
            int total = 0;
            int kusur = 0;
            if (rbMala.Checked && txtMala.Text != "") total += Convert.ToInt32(txtMala.Text);
            if(rbSredna.Checked && txtSredna.Text != "") total+= Convert.ToInt32(txtSredna.Text);
            if (rbGolema.Checked && txtGolema.Text!="") total += Convert.ToInt32(txtGolema.Text);
            if (cbFeferonki.Checked && txtFeferonki.Text != "") total += Convert.ToInt32(txtFeferonki.Text);
            if (cbKecap.Checked && txtKecap.Text != "") total += Convert.ToInt32(txtKecap.Text);
            if (cbSirenje.Checked && txtSirenje.Text != "") total += Convert.ToInt32(txtSirenje.Text);
            if (txtColaKol.Text != "" && txtColaCena.Text != "")
            {
                total += (Convert.ToInt32(txtColaKol.Text) * Convert.ToInt32(txtColaCena.Text));
                txtColaTotal.Text = (Convert.ToInt32(txtColaKol.Text) * Convert.ToInt32(txtColaCena.Text)) + "";
            }
            if (txtSokCena.Text != "" && txtSokKol.Text != "")
            {
                total += (Convert.ToInt32(txtSokCena.Text) * Convert.ToInt32(txtSokKol.Text));
                txtSokTotal.Text = (Convert.ToInt32(txtSokCena.Text) * Convert.ToInt32(txtSokKol.Text)) + "";
            }
            if (txtPivoCena.Text != "" && txtPivoKol.Text != "")
            {
                total += (Convert.ToInt32(txtPivoCena.Text) * Convert.ToInt32(txtPivoKol.Text));
                txtPivoTotal.Text = (Convert.ToInt32(txtPivoCena.Text) * Convert.ToInt32(txtPivoKol.Text)) + "";
            }
          

            if (lstDesert.SelectedIndex == 0)
            {
                txtCenaDesert.Text = "80";
                total += 80;
            }
            if (lstDesert.SelectedIndex == 1)
            {
                txtCenaDesert.Text = "120";
                total += 120;
            }
            if (lstDesert.SelectedIndex == 2)
            {
                txtCenaDesert.Text = "160";
                total += 160;
            }
            if (txtNaplateno.Text != "")
            {
                kusur = Convert.ToInt32(txtNaplateno.Text) - total;
                if (kusur < 0) kusur = 0;
                txtKusur.Text = kusur.ToString();
            }
            else
            {
                txtKusur.Text = "0";

            }
            txtTotal.Text = total + "";
        }

        public Form1()
        {
            InitializeComponent();
            txtMala.Text = "200";
            txtSredna.Text = "300";
            txtGolema.Text = "500";
            txtFeferonki.Text = "40";
            txtSirenje.Text = "30";
            txtKecap.Text = "20";
            txtColaKol.Text = "0";
            txtColaCena.Text = "60";
            txtSokCena.Text = "70";
            txtSokKol.Text = "0";
            txtPivoCena.Text = "80";
            txtPivoKol.Text = "0";
            txtNaplateno.Text = "0";
            txtKusur.Text = "0";
         
        }

        private void rbMala_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbFeferonki_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbSirenje_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbKecap_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtMala_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtSredna_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtGolema_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtFeferonki_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtSirenje_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtKecap_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtColaKol_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtColaCena_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtSokKol_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtSokCena_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtPivoKol_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtPivoCena_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtCenaDesert_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtNaplateno_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни дека сакате да ја откажете нарачката?", "Откажување",
            MessageBoxButtons.YesNo, // vid na dijalogot 
            MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNaracaj_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (rbMala.Checked) sb.Append("Мала ");
            if (rbSredna.Checked) sb.Append("Средна ");
            if (rbGolema.Checked) sb.Append("Голема ");
            sb.Append("пица\n");
            if (cbFeferonki.Checked || cbKecap.Checked || cbSirenje.Checked) sb.Append("Додатоци: \n");
            if (cbFeferonki.Checked) sb.Append("феферонки \n");
            if (cbSirenje.Checked) sb.Append("екстра сирење \n");
            if (cbKecap.Checked) sb.Append("кечап \n");
            if(!txtColaKol.Text.Equals("0") || !txtSokKol.Text.Equals("0") || !txtPivoKol.Text.Equals("0"))
                sb.Append("Пијалок: \n");
            if (!txtColaKol.Text.Equals("0"))
                sb.Append("кока кола\n");
            if (!txtSokKol.Text.Equals("0"))
                sb.Append("сок\n");
            if (!txtPivoKol.Text.Equals("0"))
                sb.Append("пиво\n");
            if (lstDesert.SelectedIndex > -1)
            {
                sb.Append("Десерт: \n");
                sb.Append(lstDesert.SelectedItem);
            }

            MessageBox.Show(sb.ToString());



        }

        private void lstDesert_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtKusur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
