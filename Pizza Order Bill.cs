using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace My_Pizza_Project
{
    public partial class PizzaOrderBill : Form
    {
        private PizzaOrder _mainForm;

        public PizzaOrderBill(string size, string crust, string toppings, string place, string count, string price, PizzaOrder mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            lblSize.Text = size;
            lblCrust.Text = crust;
            lblToppings.Text = toppings;
            lblPlace.Text = place;
            lblCount.Text = count;
            string sPrice = price.Replace("$", "");

            float TotalAmount = Convert.ToSingle(sPrice) * Convert.ToInt32(count);
            lblPrice.Text = "$" + Convert.ToString(TotalAmount);
            DateTime dt = DateTime.Now;
            lblDate.Text = dt.ToString();

        }

        void ReSetForm()
        {

            _mainForm.gbCrustType.Enabled = true;
            _mainForm.gbTopping.Enabled = true;
            _mainForm.gbWhereToEat.Enabled = true;
            _mainForm.pgSize.Enabled = true;

            _mainForm.txtCount.Enabled = true;
            // _mainForm.lblCount.Enabled = true;
            _mainForm.btnOrderPizza.Enabled = true;

            _mainForm.rbSmall.Checked = true;
            _mainForm.rbThinCrust.Checked = true;
            _mainForm.rbEat_In.Checked = true;
            _mainForm.txtCount.Text = string.Empty;
            _mainForm.chkExraCheese.Checked = false;
            _mainForm.chkMushrooms.Checked = false;
            _mainForm.chkTomato.Checked = false;
            _mainForm.chkOnion.Checked = false;
            _mainForm.chkOlives.Checked = false;
            _mainForm.chkGreenPaper.Checked = false;

        }
       
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
        Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            e.Graphics.DrawImage(bmp, 0, 0);
            
        
    }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ReSetForm();
            this.Close();
        }
    }
}