using System;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class OrderConfirmation
    {

        public string ordernumber { get; set; }

        private const int CS_DROPSHADOW = 131072;

        protected override CreateParams CreateParams
        {

            get
            {
                var cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_DROPSHADOW;
                return cp;
            }

        }

        public OrderConfirmation()
        {
            InitializeComponent();
        }

        private void OrderConfirmation_Load(object sender, EventArgs e)
        {
            lblOrderNum.Text = "Order number: #" + ordernumber;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}