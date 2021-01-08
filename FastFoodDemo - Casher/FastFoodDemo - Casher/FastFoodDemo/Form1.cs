using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustmControl1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            thirdUserControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            fourthUserControl1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            fifthUserControl1.BringToFront();
        }
    }

    class Menu
    {

        //Default Constructor
        public Menu()
        {
            newApachegolden = 0.0;
            newCrackchicken = 0.0;
            newBigzinger = 0.0;
            newCharbroiledBBQ = 0.0;
            newCrispyStyle = 0.0;
            newCheesyMushroom = 0.0;

            newDonate = 0.0;
            newCheeseCake = 0.0;
            newMacaron = 0.0;
            newCupCakes = 0.0;
            newPannaCotta = 0.0;
            newBaklava = 0.0;
        }

        //Set Method od Meals & Desserts
        public Menu(double Apachegolden, double Crackchicken, double Bigzinger, double CharbroiledBBQ, double CrispyStyle, double CheesyMushroom,
object miTea1, object miTea, double Donate, double CheeseCake, double Macaron, double CupCakes, double PannaCotta, double Baklava)
        {
            newApachegolden = Apachegolden;
            newCrackchicken = Crackchicken;
            newBigzinger = Bigzinger;
            newCharbroiledBBQ = CharbroiledBBQ;
            newCrispyStyle = CrispyStyle;
            newCheesyMushroom = CheesyMushroom;

            newDonate = Donate;
            newCheeseCake = CheeseCake;
            newMacaron = Macaron;
            newCupCakes = CupCakes;
            newPannaCotta = PannaCotta;
            newBaklava = Baklava;
        }

        public Menu(double apatchegolden, double crackchicken, double bigzinger, double charbroiledBBQ, double crispyStyle, double cheesyMushroom, double donate, double cheeseCake, double macaron, double cupCakes, double pannaCotta, double baklava)
        {
            this.apatchegolden = apatchegolden;
            this.crackchicken = crackchicken;
            this.bigzinger = bigzinger;
            this.charbroiledBBQ = charbroiledBBQ;
            this.crispyStyle = crispyStyle;
            this.cheesyMushroom = cheesyMushroom;
            this.donate = donate;
            this.cheeseCake = cheeseCake;
            this.macaron = macaron;
            this.cupCakes = cupCakes;
            this.pannaCotta = pannaCotta;
            this.baklava = baklava;
        }

        //get Method of Meals
        public double getApachegolden() { return newApachegolden; }
        public double getCrackchicken() { return newCrackchicken; }
        public double getBigzinger() { return newBigzinger; }
        public double getCharbroiledBBQ() { return newCharbroiledBBQ; }
        public double getCrispyStyle() { return newCrispyStyle; }
        public double getCheesyMushroom() { return newCheesyMushroom; }

        //get Method of Desserts

        public double getDonate() { return newDonate; }
        public double getCheeseCake() { return newCheeseCake; }
        public double getMacaron() { return newMacaron; }
        public double getCupCakes() { return newCupCakes; }
        public double getPannaCotta() { return newPannaCotta; }
        public double getBaklava() { return newBaklava; }

        //Meals
        private double newApachegolden;
        private double newCrackchicken;
        private double newBigzinger;
        private double newCharbroiledBBQ;
        private double newCrispyStyle;
        private double newCheesyMushroom;

        //Desserts
        private double newDonate;
        private double newCheeseCake;
        private double newMacaron;
        private double newCupCakes;
        private double newPannaCotta;
        private double newBaklava;
        private double apatchegolden;
        private double crackchicken;
        private double bigzinger;
        private double charbroiledBBQ;
        private double crispyStyle;
        private double cheesyMushroom;
        private double donate;
        private double cheeseCake;
        private double macaron;
        private double cupCakes;
        private double pannaCotta;
        private double baklava;
    }
}
