using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_StructClass_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ogrenci Ogr = new Ogrenci();
     

      

        private void btnKayit_Click_1(object sender, EventArgs e)
        {

            Ders Drs = new Ders();
            Ogr.Adi = txtAdi.Text.ToUpper();
            Ogr.Soyadi = txtSoyadi.Text.ToUpper();

            Drs.Ders_adi = txtDersAdi.Text.ToUpper();
            Drs.Vize = Convert.ToDecimal(txtVize.Text);
            Drs.Final = Convert.ToDecimal(txtFinal.Text);



            Ogr.DersListesi.Add(Drs);

            lstListe.Items.Add(Drs);
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();

                }

            }
        }

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            lblGoruntule.Text = Ogr.ToString();
            switch (Ogr.Durumu)
            {
                case Durum.Geçti:
                    lblDurum.Text = "Dönemi başarıyla tamamladınız...";
                    lblDurum.ForeColor = Color.Blue;
                    break;
                case Durum.Kaldi:
                    lblDurum.Text = "Seneye bir daha bekleriz...Sınıf tekrarı.";
                    lblDurum.ForeColor = Color.Red;
                    break;
                case Durum.SartliGecti:
                    lblDurum.Text = "Ucuz yırttın...Şartlı geçtiniz.";
                    lblDurum.ForeColor = Color.Orange;
                    break;
                default:
                    lblDurum.Text = "Bu nasıl bir not anlayamadık";
                    break;
            }
        }
    }
}
