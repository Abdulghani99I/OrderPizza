using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        void ResetForm()
        {
            //reset Groups
            gboSize.Enabled = true;
            gboToppings.Enabled = true;
            gboCrustType.Enabled = true;
            gboWhereToEat.Enabled = true;

            //reset Size
            radMeduim.Checked = true;

            //reset Toppings.
            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset CrustType
            radThikCrust.Checked = true;

            //reset Where to Eat
            radEatIn.Checked = true;

            //Reset Order Button
            butOrderPizza.Enabled = true;

            UpdateToppings();
            UpdateCalculatePrice();
        }

        void UpdateToppings()
        {
            string Toppings = "";

            if (chkExtraChees.Checked)
            {
                Toppings = "Extra Chees";
            }

            if (chkOnion.Checked)
            {
                Toppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                Toppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                Toppings += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                Toppings += ", Tomatoes";
            }

            if (chkGreenPeppers.Checked)
            {
                Toppings += ", Green Peppers";
            }

            if (Toppings == "")
            {
                Toppings = "No Toppings.";
            }

            if (Toppings.StartsWith(","))
            {
                Toppings = Toppings.Substring(1, Toppings.Length - 1);
            }
            
            if (Toppings.EndsWith(","))
            {
                Toppings = Toppings.Substring(0, Toppings.Length - 2);
            }

            labToppings.Text = Toppings;
            
        }

        float GetPriceSize()
        {
            float PriceSize = 0;
            
            if (radSmall.Checked)
            {
                PriceSize = Convert.ToSingle(radSmall.Tag);
            }
            else if (radMeduim.Checked)
            {
                PriceSize = Convert.ToSingle(radMeduim.Tag);
            }
            else
            {
                PriceSize = Convert.ToSingle(radLarg.Tag);
            }

            return PriceSize;
            
        }

        float GetPriceToppings()
        {
            float PriceToppings = 0;

            if (chkExtraChees.Checked)
            {
                PriceToppings += 5;
            }
            if (chkOnion.Checked)
            {
                PriceToppings += 5;
            }
            if (chkMushrooms.Checked)
            {
                PriceToppings += 5;
            }
            if (chkOlives.Checked)
            {
                PriceToppings += 5;
            }
            
            if (chkTomatoes.Checked)
            {
                PriceToppings += 5;
            }
            
            if (chkGreenPeppers.Checked)
            {
                PriceToppings += 5;
            }

            return PriceToppings;

        }

        float GetPriceCrustType()
        {
            float PriceCrustType = 0;

            if(radThinCrust.Checked)
            {
                PriceCrustType = 10;
            }

            if(radThikCrust.Checked)
            {
                PriceCrustType = 20;
            }

            return PriceCrustType;
        }

        void UpdateCalculatePrice()
        {
            float TotalPrice = GetPriceSize() + GetPriceToppings() + GetPriceCrustType();

            labTotalPrice.Text = TotalPrice.ToString();
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatePrice();

            labSize.Text = "Small";
        }

        private void radMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatePrice();
            labSize.Text = "Meduim";
        }

        private void radLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatePrice();
            labSize.Text = "Larg";
        }

        private void radThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatePrice();
            labCrustType.Text = "Thin Crust";
        }

        private void radThikCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatePrice();
            labCrustType.Text = "Thick Crust";
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatePrice();
            
            UpdateToppings(); 

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatePrice();
            UpdateToppings(); 
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatePrice();
            UpdateToppings(); 
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatePrice();
            UpdateToppings(); 
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatePrice();
            UpdateToppings(); 
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatePrice();
            UpdateToppings(); 
        }

        private void radEatIn_CheckedChanged(object sender, EventArgs e)
        {
            labWhereToEat.Text = "Eat In";
        }

        private void radTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            labWhereToEat.Text = "Eat Out";

        }

        private void butReset_Click(object sender, EventArgs e)
        { 
            ResetForm(); 
        }

        private void butOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "certain", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gboSize.Enabled = gboCrustType.Enabled = gboToppings.Enabled 
                    = gboWhereToEat.Enabled = butOrderPizza.Enabled = false;

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
