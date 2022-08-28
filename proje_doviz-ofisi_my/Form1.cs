﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace proje_doviz_ofisi_my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblda.Text = dolaralis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblds.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            lblea.Text = euroalis;
            lbles.Text = eurosatis;
        }

        private void btnda_Click(object sender, EventArgs e)
        {
            txtkur.Text = lblda.Text;

        }

        private void btnds_Click(object sender, EventArgs e)
        {
            txtkur.Text = lblds.Text;
        }

        private void btnea_Click(object sender, EventArgs e)
        {
            txtkur.Text = lblea.Text;
        }

        private void btnes_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbles.Text;
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur=Convert.ToDouble(txtkur.Text);
            miktar=Convert.ToDouble(txtmiktar.Text);
            tutar = kur * miktar;
            txttutar.Text = tutar.ToString();

        }

      

        private void btnsatis2_Click(object sender, EventArgs e)
        {
            double kur=Convert.ToDouble(txtkur.Text);
            int miktar = Convert.ToInt32(txtmiktar.Text);
            int tutar = Convert.ToInt32(miktar/kur);
            txttutar.Text=tutar.ToString();
            double kalan;
            kalan = miktar % kur;
            txtkalan.Text=kalan.ToString();

        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
           // txtkur.Text = txtkur.Text.Replace(".", ",");
        }        

    }
}
