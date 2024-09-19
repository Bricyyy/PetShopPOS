using System;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class AddressNotice
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

        public AddressNotice()
        {
            InitializeComponent();
        }

        private void AddressNotice_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}