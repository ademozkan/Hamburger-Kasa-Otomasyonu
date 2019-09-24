using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPHamburgerciOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Hamburger> menuler = new List<Hamburger>()
        {
            new Hamburger(){ Adi="Çocuk Menüsü", Fiyati=10.5m},
             new Hamburger(){ Adi="Kasap Köfte", Fiyati=21.5m},
              new Hamburger(){ Adi="Dominos", Fiyati=12m},
               new Hamburger(){ Adi="Texas", Fiyati=15m},
                new Hamburger(){ Adi="Wooper", Fiyati=16.5m}
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            cbMenuler.Items.AddRange(menuler.ToArray());
            cbMenuler.SelectedIndex = 0;
        }
        Siparis siparis = new Siparis();
        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            
            siparis.SeciliHamburger = (Hamburger)cbMenuler.SelectedItem;

            if (rbBuyuk.Checked)
                siparis.Boyut = Boyut.Buyuk;
            else if (rbOrta.Checked)
                siparis.Boyut = Boyut.Orta;
            else
                siparis.Boyut = Boyut.Kucuk;

            foreach (CheckBox item in gbEkstralar.Controls)
            {
                if (item.Checked)
                {
                    EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
                    ekstraMalzeme.Adi = item.Text;
                    ekstraMalzeme.Fiyati =Convert.ToDecimal(item.Tag);

                    siparis.Ekstralar.Add(ekstraMalzeme);
                }
            }

            siparis.Adet = Convert.ToInt32(nmrAdet.Value);
            lstSiparisler.Items.Add(siparis);
            siparis.TutarHesapla();

            lblToplamTutar.Text = ToplamTutarHesapla().ToString("c2");
        }

        decimal ToplamTutarHesapla()
        {
            decimal toplam = 0;
            foreach (Siparis item in lstSiparisler.Items)
            {
                toplam += item.ToplamTutar;
            }
            return toplam;
        }

        private void SiparisSil_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.SelectedItem==null)
            {
                MessageBox.Show("Lütfen Kaldırılacak Siparişi Secin!!");
            }
            else
            {
                lstSiparisler.Items.Remove(lstSiparisler.SelectedItem);
                siparis.TutarHesapla();
                lblToplamTutar.Text = ToplamTutarHesapla().ToString("c2");
            }
            
        }
    }
}
