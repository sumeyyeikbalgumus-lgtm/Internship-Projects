using System;
using System.Windows.Forms;

namespace StajProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Form üzerindeki TextBox'lardan verileri alıyoruz
            string adSoyad = txtAdSoyad.Text;
            double saatUcreti = Convert.ToDouble(txtSaatUcreti.Text);
            double mesaiSaati = Convert.ToDouble(txtMesaiSaati.Text);

            double toplamKazanc = 0;

            // 40 saat üzeri mesai kontrolü (%50 zamlı hesaplama)
            if (mesaiSaati > 40)
            {
                double normalUcret = 40 * saatUcreti;
                double fazlaSaat = mesaiSaati - 40;
                double zamliUcret = saatUcreti * 1.5;
                double fazlaMesaiUcreti = fazlaSaat * zamliUcret;

                toplamKazanc = normalUcret + fazlaMesaiUcreti;
            }
            else
            {
                toplamKazanc = mesaiSaati * saatUcreti;
            }

            // Sonucu hem form üzerindeki Label'a yazdırıyoruz hem de şık bir bilgilendirme penceresi açıyoruz
            lblSonuc.Text = "Personel: " + adSoyad + "\nHesaplanan Toplam Ücret: " + toplamKazanc.ToString("N2") + " TL";

            // Kullanıcıya görsel yönlendirme ve bilgi bildirim kutusu
            MessageBox.Show(
                "Personel " + adSoyad + " için mesai ve maaş hesaplaması başarıyla tamamlandı.\n\nHesaplanan Tutar: " + toplamKazanc.ToString("N2") + " TL", 
                "Hesaplama Bilgisi", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }
    }
}