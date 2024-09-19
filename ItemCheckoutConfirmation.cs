using System;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class ItemCheckoutConfirmation
    {

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

        public ItemCheckoutConfirmation()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}