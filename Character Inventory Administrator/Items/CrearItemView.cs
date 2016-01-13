using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Character_Inventory_Administrator.Items
{
    public partial class CrearItemView : Form
    {
        List<ItemModel> _listaItems = new List<ItemModel>(); 

        public CrearItemView()
        {
            InitializeComponent();
        }

        private void CrearItemView_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarImagenItem_Click(object sender, EventArgs e)
        {
            openFileDialogImagenItem.Title = "Por favor seleccione una imagen para el item";
            openFileDialogImagenItem.InitialDirectory = "c:";
            openFileDialogImagenItem.ShowDialog();
            pictureBoxImagenItem.ImageLocation = openFileDialogImagenItem.FileName;
            pictureBoxImagenItem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagenItem.Visible = true;
        }

        private void btnCrearItem_Click(object sender, EventArgs e)
        {

        }

        private void selectorTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            String caseSwitch = selectorTamaño.SelectedItem.ToString();
            switch (caseSwitch) 
            {                    

                case "Enorme":
                    pictureBoxImagenItem.Size = new Size(250, 100);
                    break;
                case "Grande":
                    pictureBoxImagenItem.Size = new Size(90, 130);
                    break;
                case "Mediano":
                    pictureBoxImagenItem.Size = new Size(146, 72);
                    break;
                case "Pequeño":
                    pictureBoxImagenItem.Size = new Size(60, 120);
                    break;
                case "Diminuto":
                    pictureBoxImagenItem.Size = new Size(72, 72);
                    break;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }



    }
}
