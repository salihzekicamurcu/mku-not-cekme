using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotCekme
{
    public partial class Form1 : Form
    {
        public double vize;
        public double AA;
        public double BA;
        public double BB;
        public double CB;
        public double CC;
        public double DC;
        public double DD;
        public double FD;
        public double FF;


        public double AAicin;
        public double BAicin;
        public double BBicin;
        public double CBicin;
        public double CCicin;
        public double DCicin;
        public double DDicin;
        public double FDicin;
        public double FFicin;


        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDersAd.Text = "Ders";
            HarfVarsayilan();


        }

        private void buttonDersEkle_Click(object sender, EventArgs e)
        {

            hesapla();
            
        }
        private void hesapla()
        {
            if (textBoxDersAd.Text != "" && textBoxVize.Text != "")
            {
                string dersadi = textBoxDersAd.Text;
                try
                {
                    vize = Convert.ToDouble(textBoxVize.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    
                }

                // AA icin


                AAicin = (AA - vize * 0.4) / 0.6;
                BAicin = (BA - vize * 0.4) / 0.6;
                BBicin = (BB - vize * 0.4) / 0.6;
                CBicin = (CB - vize * 0.4) / 0.6;
                CCicin = (CC - vize * 0.4) / 0.6;
                DCicin = (DC - vize * 0.4) / 0.6;
                DDicin = (DD - vize * 0.4) / 0.6;
                FDicin = (FD - vize * 0.4) / 0.6;
                FFicin = (FF - vize * 0.4) / 0.6;
                if (AAicin > 100 || AAicin < 0)
                {
                    AAicin = -1;
                }
                if (BAicin > 100 || BAicin < 0)
                {
                    BAicin = -1;
                }
                if (BBicin > 100 || BBicin < 0)
                {
                    BBicin = -1;
                }
                if (CBicin > 100 || CBicin < 0)
                {
                    CBicin = -1;
                }
                if (CCicin > 100 || CCicin < 0)
                {
                    CCicin = -1;
                }
                if (DCicin > 100 || DCicin < 0)
                {
                    DCicin = -1;
                }
                if (DDicin > 100 || DDicin < 0)
                {
                    DDicin = -1;
                }
                if (FDicin > 100 || FDicin < 0)
                {
                    FDicin = -1;
                }
                if (FFicin > 100 || FFicin < 0)
                {
                    FFicin = -1;
                }

                textBoxGerekenAA.Text = AAicin.ToString();
                textBoxGerekenBA.Text = BAicin.ToString();
                textBoxGerekenBB.Text = BBicin.ToString();
                textBoxGerekenCB.Text = CBicin.ToString();
                textBoxGerekenCC.Text = CCicin.ToString();
                textBoxGerekenDC.Text = DCicin.ToString();
                textBoxGerekenDD.Text = DDicin.ToString();
                textBoxGerekenFD.Text = FDicin.ToString();
                textBoxGerekenFF.Text = FFicin.ToString();

            }
        }
        private void HarfVarsayilan()
        {
         textBoxAA.Text = "90";
         textBoxBA.Text = "80";
         textBoxBB.Text = "70";
         textBoxCB.Text = "65";
         textBoxCC.Text = "60";
         textBoxDC.Text = "55";
         textBoxDD.Text = "50";
         textBoxFD.Text = "40";
         textBoxFF.Text = "39";
         
       
         AA=Convert.ToDouble(textBoxAA.Text);
         BA=Convert.ToDouble(textBoxBA.Text);
         BB=Convert.ToDouble(textBoxBB.Text);
         CB=Convert.ToDouble(textBoxCB.Text);
         CC=Convert.ToDouble(textBoxCC.Text);
         DC=Convert.ToDouble(textBoxDC.Text);
         DD=Convert.ToDouble(textBoxDD.Text);
         FD=Convert.ToDouble(textBoxFD.Text);
         FF=Convert.ToDouble(textBoxFF.Text);
         labelHata.Text = "Harfler Varsayilan ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                HarfVarsayilan();
                hesapla();
                labelHata.Text = "Harfler Varsayilan ";
            }
            else
            {

               
            }
        }
        private void HarfDegistir()
        {
            try
            {
                AA = Convert.ToDouble(textBoxAA.Text);
                BA = Convert.ToDouble(textBoxBA.Text);
                BB = Convert.ToDouble(textBoxBB.Text);
                CB = Convert.ToDouble(textBoxCB.Text);
                CC = Convert.ToDouble(textBoxCC.Text);
                DC = Convert.ToDouble(textBoxDC.Text);
                DD = Convert.ToDouble(textBoxDD.Text);
                FD = Convert.ToDouble(textBoxFD.Text);
                FF = Convert.ToDouble(textBoxFF.Text);
                labelHata.Text = "Harfler Degistirildi";
                hesapla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void buttonHarfDegistir_Click(object sender, EventArgs e)
        {
            HarfDegistir();
          
           }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDersAd_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDersAd.Text != "")
            {
                labelDersAd.Text = textBoxDersAd.Text;
                textBoxDersAdGNO.Text = textBoxDersAd.Text;
               // textBoxKredi.Focus();
            }
        }

        private void textBoxVize_TextChanged(object sender, EventArgs e)
        {

            double sonuc;
            bool isDouble = Double.TryParse(textBoxVize.Text, out sonuc);
            if (isDouble)
            {
                vize = sonuc;
                // double here
                HarfDegistir();
                hesapla();
                labelHata.Text = "";
                textBoxVizeGNO.Text = textBoxVize.Text;
             //   textBoxHarfGNO.Focus();
            }
            else
            {
                labelHata.Text = "Vize Notunu Sayısal Bir Değer Gir ";
            }
            if (textBoxVize.Text == "")
            {
                labelHata.Text += "\n Ders Adi Bos";
            }
        
            
            
        }

        private void textBoxAA_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVize.Text != ""&&textBoxAA.Text!="")
            {
                HarfDegistir();
                hesapla();
            }

        }

        private void textBoxBA_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVize.Text != "" && textBoxBA.Text != "")
            {
                HarfDegistir();
                hesapla();
            }

        }

        private void textBoxBB_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVize.Text != "" && textBoxBB.Text != "")
            {
                HarfDegistir();
                hesapla();
            }
        }

        private void textBoxCB_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVize.Text != "" && textBoxCB.Text != "")
            {
                HarfDegistir();
                hesapla();
            }
        }

        private void textBoxCC_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVize.Text != "" && textBoxCC.Text != "")
            {
                HarfDegistir();
                hesapla();
            }
        }

        private void textBoxDC_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVize.Text != "" && textBoxDC.Text != "")
            {
                HarfDegistir();
                hesapla();
            }
        }

        private void textBoxDD_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVize.Text != "" && textBoxDD.Text != "")
            {
                HarfDegistir();
                hesapla();
            }
        }

        private void textBoxFD_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVize.Text != "" && textBoxFD.Text != "")
            {
                HarfDegistir();
                hesapla();
            }
        }

        private void textBoxFF_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVize.Text != "" && textBoxFF.Text != "")
            {
                HarfDegistir();
                hesapla();
            }
        }

        private void groupBoxDers_Enter(object sender, EventArgs e)
        {

        }

        Form1 nesne;
        private void buttonYenile_Click(object sender, EventArgs e)
        {
           
            nesne = new Form1();
            nesne.Show();
            this.Hide();
           
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HarfBul()
        
        {

            TextBox HarfTextBox = textBoxHarfGNO;
            TextBox KatsayiTextBox = textBoxDersKatsayiGNO;
            if (HarfTextBox.TextLength > 0)
            {
                if (HarfTextBox.Text == "AA" || HarfTextBox.Text == "aa")
                {
                    HarfTextBox.Text = "AA";
                    KatsayiTextBox.Text = "4,0";
                }
                else if (HarfTextBox.Text == "BA" || HarfTextBox.Text == "ba")
                {
                    HarfTextBox.Text = "BA";
                    KatsayiTextBox.Text = "3,50";

                }
                else if (HarfTextBox.Text == "BB" || HarfTextBox.Text == "bb")
                {
                    HarfTextBox.Text = "BB";
                    KatsayiTextBox.Text = "3,0";
                }
                else if (HarfTextBox.Text == "CB" || HarfTextBox.Text == "cb")
                {
                    HarfTextBox.Text = "CB";
                    KatsayiTextBox.Text = "2,50";
                }
                else if (HarfTextBox.Text == "CC" || HarfTextBox.Text == "cc")
                {
                    HarfTextBox.Text = "CC";
                    KatsayiTextBox.Text = "2,25";
                }
                else if (HarfTextBox.Text == "DC" || HarfTextBox.Text == "dc")
                {
                    HarfTextBox.Text = "DC";
                    KatsayiTextBox.Text = "1,75";
                }
                else if (HarfTextBox.Text == "DD" || HarfTextBox.Text == "dd")
                {
                    HarfTextBox.Text = "DD";
                    KatsayiTextBox.Text = "1,25";
                }
                else if (HarfTextBox.Text == "FD" || HarfTextBox.Text == "fd")
                {
                    HarfTextBox.Text = "FD";
                    KatsayiTextBox.Text = "0,75";
                }
                else if (HarfTextBox.Text == "FF" || HarfTextBox.Text == "ff")
                {
                    HarfTextBox.Text = "FF";
                    KatsayiTextBox.Text = "0.0";
                }
               textBoxHarfGNO= HarfTextBox  ;
               textBoxDersKatsayiGNO= KatsayiTextBox  ;
            }

        }
        private void buttonDersEkleGNO_Click(object sender, EventArgs e)
        {
            if (textBoxDersAdGNO.Text != "" &&textBoxKrediGNO.Text!=""&& textBoxDersKatsayiGNO.Text !=  "" && textBoxHarfGNO.Text != "")
            {
                HarfBul();
                listBoxDersAd.Items.Add(textBoxDersAdGNO.Text);
                listBoxDersKredi.Items.Add(textBoxKrediGNO.Text);
                listBoxDersHarf.Items.Add(textBoxHarfGNO.Text);
                listBoxKatsayi.Items.Add(textBoxDersKatsayiGNO.Text);
                textBoxDersAdGNO.Text = textBoxDersKatsayiGNO.Text = textBoxFinalGNO.Text = textBoxVizeGNO.Text = textBoxHarfGNO.Text = textBoxKrediGNO.Text = "";
                GnoHesapla();
                textBoxDersAd.Focus();
            }
            else
            {
                textBoxKrediGNO.Focus();
            }
            
            
        }
        public float kreditoplam, puan, GNO;
        private void GnoHesapla()
        {
            kreditoplam = 0;
            puan = 0;
            GNO = 0;
            int kayitsayisi = Convert.ToInt32(listBoxDersAd.Items.Count);
            if (kayitsayisi > 0)
            {
                for (int i = 0; i < kayitsayisi; i++)
                {
                    kreditoplam += Convert.ToSingle(listBoxDersKredi.Items[i]);
                    puan += (Convert.ToSingle(listBoxDersKredi.Items[i]) * Convert.ToSingle(listBoxKatsayi.Items[i]));

                }
                GNO = (float)(puan / kreditoplam);
                GenelNotOrtalamasi.Text = GNO.ToString();
            }
            else
            {
                textBoxDersAd.Focus();
            }
              

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxDersAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDersAd.SelectedIndex >= 0)
            {
                int secilen = Convert.ToInt32(listBoxDersAd.SelectedIndex);

                listBoxDersHarf.SetSelected(secilen,true);
                listBoxDersKredi.SetSelected(secilen,true);
                listBoxKatsayi.SetSelected(secilen, true);

            
                }
        }

        private void groupBoxGNO_Enter(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

        }

        private void buttonGNOHesapla_Click(object sender, EventArgs e)
        {
            GnoHesapla();
        }

        private void textBoxHarfGNO_TextChanged(object sender, EventArgs e)
        {
            HarfBul();
        }

        private void textBoxKredi_TextChanged(object sender, EventArgs e)
        {
            double sonuc;
            bool isDouble = Double.TryParse(textBoxKredi.Text, out sonuc);
            if (isDouble)
            {
                if (textBoxKredi.Text != "")
                {
                    textBoxKrediGNO.Text = textBoxKredi.Text;
                  //  textBoxVize.Focus();
                }
            }
            else
            {
                textBoxKredi.Focus();
            }
            
        }

        private void textBoxHarfGNO_TextChanged_1(object sender, EventArgs e)
        {
            HarfBul();
        //    buttonDersEkleGNO.Focus();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            textBoxHarfGNO.Text = label15.Text;
            textBoxFinalGNO.Text = AAicin.ToString();
        }

        private void label16_Click(object sender, EventArgs e)
        {

            textBoxHarfGNO.Text = label16.Text;
            textBoxFinalGNO.Text = BAicin.ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {

            textBoxHarfGNO.Text = label17.Text;
            textBoxFinalGNO.Text = BBicin.ToString(); 
        }

        private void label18_Click(object sender, EventArgs e)
        {

            textBoxHarfGNO.Text = label18.Text;
            textBoxFinalGNO.Text = CBicin.ToString(); 
        }

        private void label19_Click(object sender, EventArgs e)
        {

            textBoxHarfGNO.Text = label19.Text;
            textBoxFinalGNO.Text = CCicin.ToString();
        }

        private void label20_Click(object sender, EventArgs e)
        {

            textBoxHarfGNO.Text = label20.Text;
            textBoxFinalGNO.Text = DCicin.ToString();
        }

        private void label21_Click(object sender, EventArgs e)
        {

            textBoxHarfGNO.Text = label21.Text;
            textBoxFinalGNO.Text = DDicin.ToString();  
        }

        private void label22_Click(object sender, EventArgs e)
        {

            textBoxHarfGNO.Text = label22.Text;
            textBoxFinalGNO.Text = FDicin.ToString();    
    }

        private void label23_Click(object sender, EventArgs e)
        {

            textBoxHarfGNO.Text = label23.Text;
            textBoxFinalGNO.Text = FFicin.ToString();
        }

        private void buttonDersCikarGNO_Click(object sender, EventArgs e)
        {
             int sil = listBoxDersAd.SelectedIndex;

                if (sil > -1)
                {
                    listBoxDersKredi.SetSelected(sil, true);
                    string silinecek = "Silinen Ders Adi:" + listBoxDersAd.Items[sil].ToString() + "  Kredisi:" + listBoxDersKredi.Items[sil];

                    listBoxDersAd.Items.RemoveAt(sil);
                    listBoxDersKredi.Items.RemoveAt(sil);
                    listBoxKatsayi.Items.RemoveAt(sil);
                    listBoxDersHarf.Items.RemoveAt(sil);

                    MessageBox.Show(silinecek.ToString(), "Bilgi",MessageBoxButtons.OK);
                    GnoHesapla();
                     }
                else
                {
                    MessageBox.Show("Sanırım Gereksiz Bir Tuşa Bastın");
                }
            }
         
















        }


    }

