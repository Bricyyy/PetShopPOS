using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace MilkTeaOrderAndInventorySystem
{

    public partial class InsertPictureSample
    {
        private readonly OpenFileDialog opf = new OpenFileDialog() { Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif" };

        public InsertPictureSample()
        {
            InitializeComponent();
        }

        private void InsertPictureSample_Load(object sender, EventArgs e)
        {
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";
        }

        private void setPicture_MouseEnter(object sender, EventArgs e)
        {
            setPicture.Text = "Set Picture";
        }

        private void setPicture_MouseLeave(object sender, EventArgs e)
        {
            setPicture.Text = "";
        }

        private void setPicture_Click(object sender, EventArgs e)
        {

            if (opf.ShowDialog() == DialogResult.OK)
            {
                var originalImage = Image.FromFile(opf.FileName);
                var croppedImage = new Bitmap(originalImage.Width, originalImage.Height);

                using (var g = Graphics.FromImage(croppedImage))
                {
                    var path = new GraphicsPath();

                    path.AddEllipse(0, 0, croppedImage.Width, croppedImage.Height);

                    var reg = new Region(path);

                    g.Clip = reg;
                    g.DrawImage(originalImage, Point.Empty);
                }

                setPicture.CustomImages.Image = croppedImage;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            var originalImage = Image.FromFile(opf.FileName);

            uint filesize;

            var mstream = new System.IO.MemoryStream();
            originalImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] arrimage = mstream.GetBuffer();
            filesize = (uint)mstream.Length;
            mstream.Close();

            try
            {
                UniversalVariables.sql = "UPDATE userProfile SET userPic = @pic WHERE uEmail = @email";
                {
                    ref var withBlock = ref UniversalVariables.cmd;
                    withBlock.Parameters.Add("@pic", MySqlDbType.Blob).Value = arrimage;
                    withBlock.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text;
                }
                UniversalVariables.connect();
                MessageBox.Show("Image Inserted");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
    }
}