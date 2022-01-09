using InterfacesShapes.Models;
using InterfacesShapes.Models.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesShapes
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void rbDaire_CheckedChanged(object sender, EventArgs e)
        {
            pDiger.Visible = false;
            pDaire.Visible = true;

        }

        private void rbDortgen_CheckedChanged(object sender, EventArgs e)
        {
            pDiger.Visible = true;
            pDaire.Visible = false;
        }

        private void rbDikUcgen_CheckedChanged(object sender, EventArgs e)
        {
            pDiger.Visible = true;
            pDaire.Visible = false;
        }

        private void form1_Load(object sender, EventArgs e)
        {
            pDiger.Location = new Point(37, 66);
            pHesap.Location = new Point(37, 147);
            this.Size = new Size(530, 377);
            ddlIslem.Items.Add("Alan"); //index:0
            ddlIslem.Items.Add("Çevre"); //index:1
            ddlIslem.SelectedIndex = 0;


        }

        private void bHesapla_Click(object sender, EventArgs e)
        {
            lSonuc.Text = "Sonuç: ";
            double sonuc = 0;
            IRoundedShape roundedShape;
            IShapesWithAngels shapesWithAngels;

            if (rbDaire.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbYaricap.Text))
                {
                    MessageBox.Show("Yarıçap boş girilemez.");
                    return;
                }
                if (!GirisKontrolEt2(tbYaricap.Text))
                {
                    MessageBox.Show("Yarıçap sayısal olmalıdır!");
                    return;
                }



                roundedShape = new Circle()
                {
                    radius = Convert.ToDouble(tbYaricap.Text, new CultureInfo("tr")),
                    IsPiThree = cbPi.Checked
                };
                sonuc = ddlIslem.SelectedIndex == 0 ? roundedShape.CalculateArea() : roundedShape.CalculateCircumference();
            }
            else if (rbDortgen.Checked)
            {
                if(string.IsNullOrWhiteSpace(tbGenislik.Text) || string.IsNullOrWhiteSpace(tbYukseklik.Text))
                {
                    MessageBox.Show("Genişlik ve yükseklik boş girilemez.");
                    return;
                }
                if (!GirisKontrolEt2(tbGenislik.Text) || !GirisKontrolEt2(tbYukseklik.Text))
                {
                    MessageBox.Show("Genişlik ve yükseklik sayısal olmalıdır!");
                    return;
                }
                shapesWithAngels = new InterfacesShapes.Models.Rectangle()
                {
                    Height = Convert.ToDouble(tbYukseklik.Text, new CultureInfo("tr")),
                    Width = Convert.ToDouble(tbGenislik.Text, new CultureInfo("tr"))
                };
                sonuc = ddlIslem.SelectedIndex == 0 ? shapesWithAngels.CalculateArea() : shapesWithAngels.CalculateCircumference();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbGenislik.Text))
                {
                    MessageBox.Show("Genişlik boş girilemez!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbYukseklik.Text))
                {
                    MessageBox.Show("Yükseklik boş girilemez!");
                    return;
                }
                if (!GirisKontrolEt2(tbGenislik.Text) || !GirisKontrolEt2(tbYukseklik.Text))
                {
                    MessageBox.Show("Genişlik ve yükseklik sayısal olmalıdır!");
                    return;
                }
                shapesWithAngels = new RightTriangle()
                {
                    Height = Convert.ToDouble(tbYukseklik.Text, new CultureInfo("tr")),
                    Width = Convert.ToDouble(tbGenislik.Text, new CultureInfo("tr"))
                };
                sonuc = ddlIslem.SelectedIndex == 0 ? shapesWithAngels.CalculateArea() : shapesWithAngels.CalculateCircumference();
            }
            lSonuc.Text += sonuc.ToString(new CultureInfo("tr"));
        }

        //bool GirisKontrolEt1(string giris) //1. Yöntem
        //{
        //    string[] izinVerilenler = new string[]
        //    {
        //        "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ","
        //    };
        //    bool bulundu = true; //flag
        //    foreach (var karakter in giris) //1a
        //    {
        //        bulundu = false;
        //        foreach(var izinVerilen in izinVerilenler)
        //        {
        //            if (karakter.ToString() == izinVerilen)
        //            {
        //                bulundu = true;
        //                break;
        //            }
        //        }
        //    }
        //    return bulundu;
        //}

        bool GirisKontrolEt2(string giris)
        {
            double sayi;
            //sayi = Convert.ToDouble(giris);
            bool sonuc = double.TryParse(giris, NumberStyles.Any, new CultureInfo("tr"), out sayi); //boolean dönüyor (true veya false) hem dönüştürdüğün sayıya ulaşıyorsun
            return sonuc;                                                                           //hem de işlemin başarılı olup olamadığına ulaşıyorsun

        }
    }
}

