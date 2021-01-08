using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class FifthUserControl : UserControl
    {
        public double CheesyMushroomf { get; private set; }
        public double Pancakes { get; private set; }
        public double Eclair { get; private set; }

        public FifthUserControl()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //btnReset of Meals
            txtApatchegolden.Text = "0";
            txtCrackchicken.Text = "0";
            txtBigzinger.Text = "0";
            txtCharbroiledBBQ.Text = "0";
            txtCrispyStyle.Text = "0";
            txtCheesyMushroom.Text = "0";

            //btnReset of Desserts
            txtDonate.Text = "0";
            txtCheeseCake.Text = "0";
            txtMacaron.Text = "0";
            txtCupCakes.Text = "0";
            txtPancakes.Text = "0";
            txtEclair.Text = "0";

            //btnReset of Cost & Service & Tax
            lblMealsCost.Text = "0";
            lblDessertsCost.Text = "0";
            lblServiceCharge.Text = "1.75";
            lblTax.Text = "0";
            lblSubTotal.Text = "0";
            lblTotal.Text = "0";

            //chkReset of Meals
            chkApatchegolden.Checked = false;
            chkCrackchicken.Checked = false;
            chkBigzinger.Checked = false;
            chkCharbroiledBBQ.Checked = false;
            chkCrispyStyle.Checked = false;
            chkCheesyMushroom.Checked = false;

            //chkReset of Desserts
            chkDonate.Checked = false;
            chkCheeseCake.Checked = false;
            chkMacaron.Checked = false;
            chkCupCakes.Checked = false;
            chkPancakes.Checked = false;
            chkEclair.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btnReceipt
            rtfReceipt.Clear();

            // rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("\t\t" + "Apache" + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Apatche golden \t\t\t\t" + txtApatchegolden.Text + Environment.NewLine);
            rtfReceipt.AppendText("Crack chicken \t\t\t" + txtCrackchicken.Text + Environment.NewLine);
            rtfReceipt.AppendText("Big zinger \t\t\t\t" + txtBigzinger.Text + Environment.NewLine);
            rtfReceipt.AppendText("harbroiled BBQ \t\t\t" + txtCharbroiledBBQ.Text + Environment.NewLine);
            rtfReceipt.AppendText("Crispy Style \t\t\t" + txtCrispyStyle.Text + Environment.NewLine);
            rtfReceipt.AppendText("Cheesy Mushroom Coffee \t\t\t" + txtCheesyMushroom.Text + Environment.NewLine);
            rtfReceipt.AppendText("Donate \t\t\t" + txtDonate.Text + Environment.NewLine);
            rtfReceipt.AppendText("Cheese Cake \t\t" + txtCheeseCake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Macaron \t\t" + txtMacaron.Text + Environment.NewLine);
            rtfReceipt.AppendText("CupCakes \t\t" + txtCupCakes.Text + Environment.NewLine);
            rtfReceipt.AppendText("Panna Cotta \t\t" + txtPancakes.Text + Environment.NewLine);
            rtfReceipt.AppendText("Baklava \t\t" + txtEclair.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Service Charge \t\t" + lblServiceCharge.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Tax \t\t\t\t" + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total \t\t\t" + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total Cost \t\t\t" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTimer.Text + "\t" + lblDate.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnTotal
            double apatchegolden, crackchicken, bigzinger, charbroiledBBQ, crispyStyle, cheesyMushroom;
            double donate, cheeseCake, macaron, cupCakes, pancakes, eclair;
            double tax, ServiceCharge;
            tax = 0.45;
            ServiceCharge = 1.75;

            apatchegolden = 60.0; crackchicken = 55.0; bigzinger = 65.0; charbroiledBBQ = 67.0; crispyStyle = 77.0; cheesyMushroom = 70.0; //Meals pries
            donate = 17.0; cheeseCake = 23.0; macaron = 8.0; cupCakes = 9.0; pancakes = 25.0; eclair = 15.0; //Desserts prices

            //Meals
            double Apatchegolden = Convert.ToDouble(txtApatchegolden.Text);
            double Crackchicken = Convert.ToDouble(txtCrackchicken.Text);
            double Bigzinger = Convert.ToDouble(txtBigzinger.Text);
            double CharbroiledBBQ = Convert.ToDouble(txtCharbroiledBBQ.Text);
            double CrispyStyle = Convert.ToDouble(txtCrispyStyle.Text);
            double CheesyMushroom = Convert.ToDouble(txtCheesyMushroom.Text);

            //Desserts
            double Donate = Convert.ToDouble(txtDonate.Text);
            double CheeseCake = Convert.ToDouble(txtCheeseCake.Text);
            double Macaron = Convert.ToDouble(txtMacaron.Text);
            double CupCakes = Convert.ToDouble(txtCupCakes.Text);
            double PannaCotta = Convert.ToDouble(txtPancakes.Text);
            double Baklava = Convert.ToDouble(txtEclair.Text);

            Menu eat_in_Resturant = new Menu(Apatchegolden, Crackchicken, Bigzinger, CharbroiledBBQ, CrispyStyle, CheesyMushroom,
               Donate, CheeseCake, Macaron, CupCakes, Pancakes, Eclair);

            double MealsCosts = (Apatchegolden * apatchegolden) + (Crackchicken * crackchicken) + (Bigzinger * bigzinger) + (CharbroiledBBQ * charbroiledBBQ) + (CrispyStyle * crispyStyle) + (CheesyMushroom * cheesyMushroom) ;
            lblMealsCost.Text = Convert.ToString(MealsCosts);
            double DessertsCosts = (Donate * donate) + (CheeseCake * cheeseCake) + (Macaron * macaron) + (CupCakes * cupCakes) + (Pancakes * pancakes) + (Eclair * eclair) ;
            lblDessertsCost.Text = Convert.ToString(DessertsCosts);


            lblServiceCharge.Text = Convert.ToString(ServiceCharge);

            //double ServiceCharge = Convert.ToDouble(lblServiceCharge.Text);

            lblSubTotal.Text = Convert.ToString(DessertsCosts + MealsCosts + ServiceCharge);
            lblTax.Text = Convert.ToString(((DessertsCosts + MealsCosts + ServiceCharge) * tax) / 100);
            double totalAftTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(DessertsCosts + MealsCosts + ServiceCharge + totalAftTax);

            lblMealsCost.Text = String.Format("{0:C}", MealsCosts);
            lblDessertsCost.Text = String.Format("{0:C}", DessertsCosts);
            lblServiceCharge.Text = String.Format("{0:C}", ServiceCharge);
            lblSubTotal.Text = String.Format("{0:C}", (DessertsCosts + MealsCosts + ServiceCharge));
            lblTax.Text = String.Format("{0:C}", totalAftTax);
            lblTotal.Text = String.Format("{0:C}", (DessertsCosts + MealsCosts + ServiceCharge + totalAftTax));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //double Apatchegolden = Convert.ToDouble(txtApatchegolden.Text);
        }

        private void FifthUserControl_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();

            //txtApatchegolden.Text = "0";
            //txtCrackchicken.Text = "0";
            //txtBigzinger.Text = "0";
            //txtCharbroiledBBQ.Text = "0";
            //txtCrispyStyle.Text = "0";
            //txtCheesyMushroom.Text = "0";

            //txtDonate.Text = "0";
            //txtCheeseCake.Text = "0";
            //txtMacaron.Text = "0";
            //txtCupCakes.Text = "0";
            //txtPannaCotta.Text = "0";
            //txtBaklava.Text = "0";

            //lblMealsCost.Text = "0";
            //lblDessertsCost.Text = "0";
            //lblServiceCharge.Text = "1.75";

            //lblSubTotal.Text = "0";
            //lblTax.Text = "0";
            //lblTotal.Text = "0";

            txtApatchegolden.Enabled = false;
            txtCrackchicken.Enabled = false; ;
            txtBigzinger.Enabled = false;
            txtCharbroiledBBQ.Enabled = false;
            txtCrispyStyle.Enabled = false;
            txtCheesyMushroom.Enabled = false;

            txtDonate.Enabled = false;
            txtCheeseCake.Enabled = false;
            txtMacaron.Enabled = false;
            txtCupCakes.Enabled = false;
            txtPancakes.Enabled = false;
            txtEclair.Enabled = false;

            chkApatchegolden.Checked = false;
            chkCrackchicken.Checked = false;
            chkBigzinger.Checked = false;
            chkCharbroiledBBQ.Checked = false;
            chkCrispyStyle.Checked = false;
            chkCheesyMushroom.Checked = false;

            chkDonate.Checked = false;
            chkDonate.Checked = false;
            chkMacaron.Checked = false;
            chkCupCakes.Checked = false;
            chkPancakes.Checked = false;
            chkEclair.Checked = false;

            rtfReceipt.Clear();
        }

        private void chkApatchegolden_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApatchegolden.Checked == true)
            {
                txtApatchegolden.Enabled = true;
            }
            else
            {
                txtApatchegolden.Enabled = false;
                txtApatchegolden.Text = "";
            }
        }

        private void txtApatchegolden_TextChanged(object sender, EventArgs e)
        {
            //txtApatchegolden.Text = "";
            txtApatchegolden.Focus();
        }

        private void chkCrackchicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCrackchicken.Checked == true)
            {
                txtCrackchicken.Enabled = true;
            }
            else
            {
                txtCrackchicken.Enabled = false;
                txtCrackchicken.Text = "";
            }
        }

        private void txtCrackchicken_TextChanged(object sender, EventArgs e)
        {
            //txtCrackchicken.Text = "";
            txtCrackchicken.Focus();
        }

        private void chkBigzinger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBigzinger.Checked == true)
            {
                txtBigzinger.Enabled = true;
            }
            else
            {
                txtBigzinger.Enabled = false;
                txtBigzinger.Text = "";
            }
        }

        private void txtBigzinger_TextChanged(object sender, EventArgs e)
        {
            //txtBigzinger.Text = "";
            txtBigzinger.Focus();
        }

        private void chkCharbroiledBBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCharbroiledBBQ.Checked == true)
            {
                txtCharbroiledBBQ.Enabled = true;
            }
            else
            {
                txtCharbroiledBBQ.Enabled = false;
                txtCharbroiledBBQ.Text = "";
            }
        }

        private void txtCharbroiledBBQ_TextChanged(object sender, EventArgs e)
        {
            //txtCharbroiledBBQ.Text = "";
            txtCharbroiledBBQ.Focus();
        }

        private void chkCrispyStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCrispyStyle.Checked == true)
            {
                txtCrispyStyle.Enabled = true;
            }
            else
            {
                txtCrispyStyle.Enabled = false;
                txtCrispyStyle.Text = "";
            }
        }

        private void txtCrispyStyle_TextChanged(object sender, EventArgs e)
        {
            //txtCrispyStyle.Text = "";
            txtCrispyStyle.Focus();
        }

        private void chkCheesyMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheesyMushroom.Checked == true)
            {
                txtCheesyMushroom.Enabled = true;
            }
            else
            {
                txtCheesyMushroom.Enabled = false;
                txtCheesyMushroom.Text = "";
            }
        }

        private void txtCheesyMushroom_TextChanged(object sender, EventArgs e)
        {
            //txtCheesyMushroom.Text = "";
            txtCheesyMushroom.Focus();
        }

        private void chkDonate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDonate.Checked == true)
            {
                txtDonate.Enabled = true;
            }
            else
            {
                txtDonate.Enabled = false;
                txtDonate.Text = "";
            }
        }

        private void txtDonate_TextChanged(object sender, EventArgs e)
        {
            //txtDonate.Text = "";
            txtDonate.Focus();
        }

        private void chkCheeseCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheeseCake.Checked == true)
            {
                txtCheeseCake.Enabled = true;
            }
            else
            {
                txtCheeseCake.Enabled = false;
                txtCheeseCake.Text = "";
            }
        }

        private void txtCheeseCake_TextChanged(object sender, EventArgs e)
        {
            //txtCheeseCake.Text = "";
            txtCheeseCake.Focus();
        }

        private void chkMacaron_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMacaron.Checked == true)
            {
                txtMacaron.Enabled = true;
            }
            else
            {
                txtMacaron.Enabled = false;
                txtMacaron.Text = "";
            }
        }

        private void txtMacaron_TextChanged(object sender, EventArgs e)
        {
            //txtMacaron.Text = "";
            txtMacaron.Focus();
        }

        private void chkCupCakes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCupCakes.Checked == true)
            {
                txtCupCakes.Enabled = true;
            }
            else
            {
                txtCupCakes.Enabled = false;
                txtCupCakes.Text = "";
            }
        }

        private void txtCupCakes_TextChanged(object sender, EventArgs e)
        {
            //txtCupCakes.Text = "";
            txtCupCakes.Focus();
        }

        private void chkPannaCotta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPancakes.Checked == true)
            {
                txtPancakes.Enabled = true;
            }
            else
            {
                txtPancakes.Enabled = false;
                txtPancakes.Text = "";
            }
        }

        private void txtPannaCotta_TextChanged(object sender, EventArgs e)
        {
            //txtPannaCotta.Text = "";
            txtPancakes.Focus();
        }

        private void chkBaklava_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEclair.Checked == true)
            {
                txtEclair.Enabled = true;
            }
            else
            {
                txtEclair.Enabled = false;
                txtEclair.Text = "";
            }
        }

        private void txtBaklava_TextChanged(object sender, EventArgs e)
        {
            //txtBaklava.Text = "";
            txtEclair.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblMealsCost_Click(object sender, EventArgs e)
        {

        }
    }
}
