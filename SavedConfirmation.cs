using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{

    public partial class SavedConfirmation
    {
        public string ItemAddedConfirmation { get; set; }

        private DateTime TargetDT;
        private TimeSpan stopWatch = TimeSpan.FromSeconds(3d);

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

        public SavedConfirmation()
        {
            InitializeComponent();
        }

        private void FadeInWindow()
        {
            Opacity = 0d;
            var tmr = new Timer() { Interval = 2 };
            tmr.Start();
            tmr.Tick += () =>
                {
                    Opacity += 0.1d;
                    if (Opacity == 1d)
                        tmr.Stop();
                };
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SavedConfirmation_Load(object sender, EventArgs e)
        {
            tmrClose.Start();
            TargetDT = DateTime.Now.Add(stopWatch);
            FadeInWindow();

            if (ItemAddedConfirmation != default)
            {
                lblConfirmation.Text = ItemAddedConfirmation;
            }
        }

        private void SavedConfirmation_Closing(object sender, CancelEventArgs e)
        {
            // 'e.Cancel = True
            // 'Me.Opacity = 1
            // 'Dim tmr As New Timer With {
            // '    .Interval = 1
            // '}
            // 'tmr.Start()
            // 'AddHandler tmr.Tick, Sub()
            // '                         Me.Opacity -= 0.1
            // '                         If Me.Opacity = 0 Then
            // '                             e.Cancel = False
            // '                             tmr.Stop()
            // '                             Me.Dispose()
            // '                         End If
            // '                     End Sub
        }

        private void tmrClose_Tick(object sender, EventArgs e)
        {
            var ts = TargetDT.Subtract(DateTime.Now);
            if (ts.TotalMilliseconds > 1d)
            {
                lblTime.Text = ts.ToString("ss");
            }
            else
            {
                tmrClose.Stop();
                Close();
            }
        }
    }
}