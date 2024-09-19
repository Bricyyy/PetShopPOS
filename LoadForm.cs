using System;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressbar.Width += 5;

            if (progressbar.Width >= 315)
            {
                Timer1.Stop();
                var obj1 = new Login();
                var obj2 = new Homepage();
                if (My.MySettingsProperty.Settings.userRememberMe == true)
                {
                    obj2.Show();
                }
                else
                {
                    obj1.Show();
                }
                Hide();
            }
        }
    }
}