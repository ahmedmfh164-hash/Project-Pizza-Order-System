using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
           UpdatePricePieceOfPizza();
            TotalPriceValue();
        }

        void UpdateSize()
        {

            if (rbSmall.Checked)
            {
                labSizeValue.Text="Small";
                return;
            }
            if (rbMedium.Checked)
            {
                labSizeValue.Text="Medium";
                return;
            }
            if (rbLarge.Checked)
            {
                labSizeValue.Text="Large";
                return;
            }

        }

        void UpdateToppings()
        {

            string sToppings = "";

            if (ckExtraCheese.Checked)
            {
                sToppings="Extra Cheese";
            }
            if (ckMushrooms.Checked)
            {
                sToppings+=", Mushrooms";
            }
            if (ckTomatoes.Checked)
            {
                sToppings+=", Tomatoes";
            }
            if (ckOnion.Checked)
            {
                sToppings+=", Onion";
            }
            if (ckOlives.Checked)
            {
                sToppings+=", Olives";
            }
            if (ckGreenPeppers.Checked)
            {
                sToppings+=", Green Peppers";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings=sToppings.Substring(1, sToppings.Length-1).Trim();
            }

            if (sToppings=="")
                sToppings="No Toppings";

            labToppingsValue.Text=sToppings;

        }

        void UpdateCrust()
        {

            if (rbThin.Checked)
            {
                labCrustValue.Text="Thin";
                return;
            }
            else
            {
                labCrustValue.Text="Thick";
                return;
            }

        } 

        void UpdateWhereToEat()
        {

            if (rbEatIn.Checked)
            {
                labWhereToEatValue.Text="Eat In";
                return;
            }
            else
            {
                labWhereToEatValue.Text="Take Out";
                return;
            }

        }


        float GetSelectedSizePrice()
        {

            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
            else
                return Convert.ToSingle(rbLarge.Tag);


        }

        float CalculatePriceToppings()
        {
            float ToppingsTotalPrice = 0;

            if (ckExtraCheese.Checked)
            {
                ToppingsTotalPrice+=Convert.ToSingle(ckExtraCheese.Tag);

            }
            if (ckMushrooms.Checked)
            {
                ToppingsTotalPrice+=Convert.ToSingle(ckMushrooms.Tag);

            }
            if (ckTomatoes.Checked)
            {
                ToppingsTotalPrice+=Convert.ToSingle(ckTomatoes.Tag);
            }
            if (ckOnion.Checked)
            {
                ToppingsTotalPrice+=Convert.ToSingle(ckOnion.Tag);
            }
            if (ckOlives.Checked)
            {
                ToppingsTotalPrice+=Convert.ToSingle(ckOlives.Tag);
            }
            if (ckGreenPeppers.Checked)
            {
                ToppingsTotalPrice+=Convert.ToSingle(ckGreenPeppers.Tag);
            }

            return ToppingsTotalPrice;
        }

        float GetSelectedCrustPrice()
        { 
            if (rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);
            else
                return Convert.ToSingle(rbThick.Tag);

        }

        float CalculatePricePieceOfPizza()
        {
            return GetSelectedSizePrice()+CalculatePriceToppings()+GetSelectedCrustPrice();
        }

        void UpdatePricePieceOfPizza()
        {

            lblPriceOfPieceValue.Text="$"+(CalculatePricePieceOfPizza()).ToString();

        }

        private void rbSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void ckToppings_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();

        }

        private void rbCrustType_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void rbWhereToEat_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereToEat.Enabled = false;
                numericUpDown1 .Enabled = false;
                btnOrderPizza.Enabled = false;
            }
            else
                MessageBox.Show("Order Placed Non-Successfully", "Not Success"
, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            rbSmall.Checked=true;

            gbToppings.Enabled=true;
            ckExtraCheese.Checked=false;
            ckMushrooms.Checked=false;
            ckGreenPeppers.Checked=false;
            ckOlives.Checked=false;
            ckOnion.Checked=false;
            ckTomatoes.Checked=false;

            gbCrustType.Enabled=true;
            rbThin.Checked=true;

            gbWhereToEat.Enabled=true;
            rbEatIn.Checked=true;

            numericUpDown1.Enabled=true;

            numericUpDown1.Value = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text="Pizza Order";
            this.BackColor=Color.Gray;

            gbOrderSummary.BackColor=Color.Transparent;
            rbThin.Checked=true;
            rbSmall.Checked=true;
            rbEatIn.Checked=true;

            UpdateOrderSummary();

            labSize.ForeColor=Color.Red;
            labToppings.ForeColor=Color.Red;
            labCrustType.ForeColor=Color.Red;
            labWhereToEat.ForeColor=Color.Red;
            labTotalPrice.ForeColor=Color.Red;
            lblNumberOfPizza.ForeColor=Color.Red;
            lblPriceOfPiece.ForeColor=Color.Red;
            gbOrderSummary.ForeColor=Color.Blue;

            btnOrderPizza.BackColor=Color.DarkGray;
            btnResetForm.BackColor=Color.DarkGray;

            label2.Text="Number Of Pizza : ";
            label2.ForeColor=Color.Blue;

            numericUpDown1.ForeColor=Color.Red;
            numericUpDown1.BackColor=Color.DarkGray;

        }

        void TotalPriceValue()
        {

           lblTotalPriceValue.Text="$"+(CalculatePricePieceOfPizza()*((float)numericUpDown1.Value)).ToString();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            lblNumberOfPizzaValue.Text=numericUpDown1.Value.ToString();
           
            TotalPriceValue();
        }

     
    }
}
