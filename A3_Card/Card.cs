using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_Card
{
    public partial class Card : UserControl
    {
        public event EventHandler SelectCard;

        public string Name { get { return lblName.Text; } set { lblName.Text = value; } }
        public string Age { get { return lblAge.Text; } set { lblAge.Text = value; } }
        public string Album { get { return lblAlbum.Text; } set { lblAlbum.Text = value; } }
        public string GroupName { get { return lblGroupName.Text; } set { lblGroupName.Text = value; } }

        public string bgColor { set { this.BackColor = ColorTranslator.FromHtml(value);lblGroupName.ForeColor= ColorTranslator.FromHtml(value); } }
       

        public string Img { set { pictureBox1.ImageLocation = value; } }
        public Card()
        {
            InitializeComponent();
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            //pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/superstar-smtown/images/4/4a/Karina_%28DCT%29.png/revision/latest?cb=20220105093630";

        }

   
      
    }
}
