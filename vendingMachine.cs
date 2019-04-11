using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp42
{
    public partial class vendingMachine : Form
    {
        // initialize variables to call and connect to the form
        private int totalQuantity = 20;
        private double colaCost = 1;
        private double rootBeerCost = 1;
        private double lemonLimeCost = 1;
        private double grapeCost = 1.5;
        private double creamSodaCost = 1.5;
        private General objGeneral;

        public vendingMachine()
        {
            InitializeComponent();
            this.objGeneral = new General();
            this.objGeneral.cola = 20;
            this.objGeneral.rootBeer = 20;
            this.objGeneral.lemonLime = 20;
            this.objGeneral.grape = 20;
            this.objGeneral.creamSoda = 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image.FromFile(System.AppContext.BaseDirectory + @"\Drink Machine\Cola.bmp");
            Image.FromFile(System.AppContext.BaseDirectory + @"\Drink Machine\CreamSoda.bmp");
            Image.FromFile(System.AppContext.BaseDirectory + @"\Drink Machine\GrapeSoda.bmp");
            Image.FromFile(System.AppContext.BaseDirectory + @"\Drink Machine\LemonLime.bmp");
            Image.FromFile(System.AppContext.BaseDirectory + @"\Drink Machine\RootBeer.bmp");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.objGeneral.cola == 0)
            {
                MessageBox.Show("Sorry Sold Out");
                return;
            }
            this.objGeneral.cola = this.objGeneral.cola - 1;
            updateMachine();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.objGeneral.rootBeer == 0)
            {
                MessageBox.Show("Sorry Sold Out");
                return;
            }
            this.objGeneral.rootBeer = this.objGeneral.rootBeer - 1;
            updateMachine();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.objGeneral.lemonlime == 0)
            {
                MessageBox.Show("Sorry Sold Out");
                return;
            }
            this.objGeneral.lemonlime = this.objGeneral.lemonlime - 1;
            updateMachine();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (this.objGeneral.grape == 0)
            {
                MessageBox.Show("Sorry Sold Out");
                return;
            }
            this.objGeneral.grape = this.objGeneral.grape - 1;
            updateMachine();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (this.objGeneral.creamSoda == 0)
            {
                MessageBox.Show("Sorry Sold Out");
                return;
            }
            this.objGeneral.creamSoda = this.objGeneral.creamSoda - 1;
            updateMachine();
        }
        private void updateMachine()
        {
            lblBoxCola.Text = this.objGeneral.Cola.ToString();
            lblBoxrootBeer.Text = this.objGeneral.rootBeer.ToString();
            lblBoxgrape.Text=this.objGeneral.grape.ToString();
            lblBoxlemonLime.Text = this.objGeneral.lemonLime.ToString();
            lblBoxcreamSoda.Text = this.objGeneral.creamSoda.ToString();

            double cola = (totalQuantity - this.objGeneral.Cola) * colaCost;
            double rootBeer = (totalQuantity - this.objGeneral.rootBeer) * rootBeerCost;
            double lemonLime = (totalQuantity - this.objGeneral.lemonLime) * lemonLimeCost;
            double grapeSoda = (totalQuantity - this.objGeneral.grape) * grapeCost;
            double creamSoda  = (totalQuantity - this.objGeneral.creamSoda) *creamSodaCost;

            lblBoxTotal.Text = "$" + Math.Round((cola + rootBeer + lemonLime + grapeSoda + creamSoda), 2).ToString();
        }
        }
}
