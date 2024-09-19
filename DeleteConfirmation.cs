using System;
using System.Data;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class DeleteConfirmation
    {
        public string passAddress { get; set; }
        public string passConfirmation { get; set; }

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

        public DeleteConfirmation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void DeleteConfirmation_Load(object sender, EventArgs e)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            if (passConfirmation != default)
            {
                lblConfirmation.Text = passConfirmation;
            }
            else
            {
                var obj = new Homepage();
                obj.Hide();
            }
        }
    }
}