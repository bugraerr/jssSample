using RepoSample.UI.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepoSample.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in new Repo<Shipper>().ListAll())
            {
               listBox1.Items.Add(item);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repo<Shipper> shipperRepo = new Repo<Shipper>();
            int satirsayisi = shipperRepo.Insert(new Shipper()
            {
                CompanyName = textBox1.Text,
                Phone = textBox2.Text,
                AktifMi=true
            });
            if (satirsayisi>0)
            {
                MessageBox.Show("Kargo Girildi");

            }
            else
            {
                MessageBox.Show("hata var");
            }
        }
    }
}
