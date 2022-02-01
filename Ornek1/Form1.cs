using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Array(dizi)
        //Birden fazla, aynı tipteki veriyi bir arada tutmamızı sağlayan nesnelermizdir.
        //Eğer, "Index was outside the bounds of the array", hatası alıyorsanız, bilin ki dizi boyutlarını aşacak şekilde eleman eklemeye çalışıyorsunuz. Hata nerede diye bakmayın, eleman ekleme işlemlerini kontrol edin.
        private void Form1_Load(object sender, EventArgs e)
        {
            //veriTipi[] diziAdi=new veriTipi[elemanSayisi];

            int[] sayisalDizi = new int[3];
            sayisalDizi[0] = 121;
            sayisalDizi[2] = 1;
            sayisalDizi[1] = 12;
            //sayisalDizi[3] = 121; dizimiz 3 elemanlı index numarası en fazla 2 olabilir.


            //veriTipi[] diziAdi=new veriTipi[elemanSayisi](birinciEleman,ikinciEleman,...)

            string[] sehirler = new string[4] { "Ankara", "İstanbul", "Eskişeir", "Kütahya" };



            //veriTipi[] diziAdi=[diziElemanlari]

            char[] karakterler = { 'a', 'b', 'c', 'd','e','f' };

        }
    }
}
