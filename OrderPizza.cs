using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pizza_Project
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
        }


        float GetSelectedSizePrice()
        {
            if (rbLarge.Checked)
                return Convert.ToSingle(rbLarge.Tag);
            else if (rbMeduim.Checked)
                return Convert.ToSingle(rbMeduim.Tag);
            else
                  return Convert.ToSingle(rbSmall.Tag);
            
        }

        float GetSelectedCrustPrice()
        {
            if (rbThickCrust.Checked)
                return Convert.ToSingle(rbThickCrust.Tag);
            else
                return Convert.ToSingle(rbThinCrust.Tag);
        }

        float GetSelectedToppingsPrice()
        {
            float price = 0;

            if (chkExraCheese.Checked)
                price += Convert.ToSingle(chkExraCheese.Tag);

            if (chkMushrooms.Checked)
                price += Convert.ToSingle(chkMushrooms.Tag);

            if (chkTomato.Checked)
                price += Convert.ToSingle(chkTomato.Tag);

            if (chkOnion.Checked)
                price += Convert.ToSingle(chkOnion.Tag);

            if (chkOlives.Checked)
                price += Convert.ToSingle(chkOlives.Tag);

            if (chkGreenPaper.Checked)
                price += Convert.ToSingle(chkGreenPaper.Tag);

            return price;

        }

        
        float UpdateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedCrustPrice() + GetSelectedToppingsPrice();
        }
            
        void CalculateTotalPrice()
        {
            lblPrice.Text="$"+UpdateTotalPrice().ToString(); 
        }
        
        void UpdateSize()
        { 
            CalculateTotalPrice();
            if (rbLarge.Checked)
                lblSet_Size.Text = " Large ";
            else if (rbMeduim.Checked)
                lblSet_Size.Text = " Meduim ";

            else
            {
                lblSet_Size.Text = rbSmall.Text;
                rbSmall.Checked = true;
            }


            }

        void UpdateCrustType()
        {
            CalculateTotalPrice();

            if (rbThickCrust.Checked)
                lblSet_CrustType.Text = rbThickCrust.Text;
            else
            {
                lblSet_CrustType.Text = rbThinCrust.Text;
                rbThinCrust.Checked = true;
            }

        }

        void UpdateWhereToEat()
        {
            if (rbTake_out.Checked)
                lblSet_Place.Text = rbTake_out.Text;
            else
            {
                lblSet_Place.Text = rbEat_In.Text;
                rbEat_In.Checked = true;
            }
        }

        void UpdateTopping()
        {
            CalculateTotalPrice();

            lblSet_Toppings.Text = string.Empty;
            List<string> ToppingList = new List<string>();

            if (chkExraCheese.Checked)
                ToppingList.Add(chkExraCheese.Text);

            if (chkMushrooms.Checked)
                ToppingList.Add(chkMushrooms.Text);
            if (chkTomato.Checked)
                ToppingList.Add(chkTomato.Text);
            if (chkOnion.Checked)
                ToppingList.Add(chkOnion.Text);
            if (chkOlives.Checked)
                ToppingList.Add(chkOlives.Text);
            if (chkGreenPaper.Checked)
                ToppingList.Add(chkGreenPaper.Text);


            if (ToppingList.Count > 0)
                lblSet_Toppings.Text = string.Join(",", ToppingList);
            else
                lblSet_Toppings.Text = "No Toppings";

        }

        void UpdateSummaryOrder()
        {
            UpdateSize();
            UpdateTopping();
            UpdateWhereToEat();
            UpdateCrustType();
           txtCount.Text = string.Empty;
        }

        private void btnLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void btnSmall_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void btnMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {

            UpdateCrustType();

        }


        private void rbEat_In_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTake_out_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }




        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCount.Text))
            {
                MessageBox.Show("Sorry, please enter order count? ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCount.Focus();
                return;
            }

            if (MessageBox.Show("Are sure you want to Order this Pizza ?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gbCrustType.Enabled = false;
                gbTopping.Enabled = false;
                gbWhereToEat.Enabled = false;
                pgSize.Enabled = false;
                txtCount.Enabled = false;
                btnOrderPizza.Enabled = false;
                

                // تمرير النصوص الجاهزة مباشرة من الـ Controls إلى الفورم الثاني داخل الأقواس
                PizzaOrderBill frmBill = new PizzaOrderBill(
                    lblSet_Size.Text,
                    lblSet_CrustType.Text,
                    lblSet_Toppings.Text,
                    lblSet_Place.Text,
                    txtCount.Text,
                    lblPrice.Text,
                    this);


                frmBill.ShowDialog();
            }
        }
        

        

        private void gbTopping_CheckedChange(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void btnClosePizzaOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PizzaOrder_Load(object sender, EventArgs e)
        {
            UpdateSummaryOrder();
        }
    }
}
