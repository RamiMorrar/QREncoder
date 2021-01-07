using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QREncoderAndDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true }) // Makes QR Code
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessagingToolkit.QRCode.Codec.QRCodeEncoder Encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                    Encoder.QRCodeScale = 10; // Creates image
                    Bitmap bmp = Encoder.Encode((EncodeText.Text)); // Creates new QR Bitmap
                    Picturebox.Image = bmp;
                    bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false}) // Lets user open QR Code
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Picturebox.Image = Image.FromFile(ofd.FileName);
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                    DecodeText.Text = decoder.Decode(new QRCodeBitmapImage(Picturebox.Image as Bitmap));
                }
            }
        }
    }
}
