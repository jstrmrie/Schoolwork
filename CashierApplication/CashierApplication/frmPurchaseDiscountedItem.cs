using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem discountedItem;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string name = txtItem.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);

            discountedItem = new DiscountedItem(name, price, quantity, discount);

            double total = discountedItem.getTotalPrice();
            lblTotalAmount.Text = total.ToString("F2");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double payment = Convert.ToDouble(txtPayment.Text);
            discountedItem.setPayment(payment);

            double change = discountedItem.getChange();
            lblChange.Text = change.ToString("F2");
        }
    }
}
