using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISK = IsKatmanı;
using VAR = Varlıklar;

namespace OBS_1
{
    public partial class Form5 : Form
    {
        public VAR.ogrenci ogrenci;
        public Form5()
        {
            InitializeComponent();
        }
        private void OgrenciDuzenle()
        {
            textBox1.Text = ogrenci.Ogrno.ToString();
            textBox2.Text = ogrenci.Tcno;
            textBox3.Text = ogrenci.OgrAdSoyad;
            textBox4.Text = ogrenci.OgrBolum;
            textBox5.Text = ogrenci.Sinif;
            textBox6.Text = ogrenci.Ceptel;
            textBox7.Text = ogrenci.Mail;
        }
        private bool KullaniciGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Öğrenci numarasını boş geçemezsiniz.");
                textBox1.SelectAll();
                textBox1.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Tc numarası bilgisini boş geçemezsiniz.");
                textBox2.SelectAll();
                textBox2.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("İsim bilgisini boş geçemezsiniz.");
                textBox3.SelectAll();
                textBox3.Focus();
                return false;
            }

            return true;
        }

        VeriErisimKatmanı.ogrenci yeniogrenci = new VeriErisimKatmanı.ogrenci();
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            VAR.ogrenci yogrenci = new Varlıklar.ogrenci(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            yogrenci.Ogrid = yeniogrenci.Guncelle(yogrenci);
            ((Form3)this.Owner).ogrlistele();

            this.Visible = false;
            }
            catch { MessageBox.Show("Hatalı işlem."); }
        }
    }
}
