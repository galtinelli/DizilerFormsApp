using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] arabalar = { "Mercedes", "Volvo", "Fiat", "Audi", "Honda", "Hyundai", "Toyota", "Tesla", "BMW", "Kia" };
        private void btnSonEleman_Click(object sender, EventArgs e)
        {
            //Dizinin eleman sayısını bilmiyoruz fakat bu butona tıklandığında dizinin son elemanını MessageBox ile gösterimi sağlanacak

            MessageBox.Show("Dizinin son elemanı: " + arabalar[arabalar.Length - 1]);
        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0, arabalar.Length - 1);
            MessageBox.Show("Dizinin rastgele elemanı: " + arabalar[sayi]);


        }

        int[] sayilar = { 10, 20, 30, 40, 50, 60 };
        int index = 0;
        int havuz = 0;
        private void btnListele_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < arabalar.Length; i++)
            //{
            //lbxElemanlar.Items.Add(i+". eleman: "+arabalar[i]);
            if (index < sayilar.Length)
            {
                lbxElemanlar.Items.Add(sayilar[index]);
                havuz += sayilar[index];
                this.Text = "Toplam: " + havuz;
                index++;


                }
            else
            {
                MessageBox.Show("Dizinin son elemanına gelindi!");
            }

            //}

        }

    }
}
