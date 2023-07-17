using RepoCalisma2.Repos;
using RepoSample.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepoCalisma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShipperYukle();
        }

        private void ShipperYukle()
        {
            listBox1.Items.Clear();
            foreach (Shipper x in new Repo2<Shipper>().listall())
            {
                
                listBox1.Items.Add(x);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int satirsayisi = new Repo2<Shipper>().Insert(new Shipper
            {
                CompanyName = textBox1.Text,
                Phone = textBox2.Text,
                AktifMi = true,
            });
            if (satirsayisi > 0)
            {
                MessageBox.Show("Kayıt girildi");
                ShipperYukle();
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
             

            int satirsayisi = new Repo2<Shipper>().Delete(new Shipper
            {
                ShipperID = contextMenuStrip1.Tag  new  Shipper().ShipperID ,
            });
        }
    }
}
