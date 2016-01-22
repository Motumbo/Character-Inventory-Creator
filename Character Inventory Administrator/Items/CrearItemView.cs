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
        private String imageSourceItem = "";

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
            imageSourceItem = pictureBoxImagenItem.ImageLocation = openFileDialogImagenItem.FileName;
            pictureBoxImagenItem.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxImagenItem.Visible = true;
        }



        private void selectorTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            String caseSwitch = selectorTamaño.SelectedItem.ToString();
            switch (caseSwitch) 
            {                    

                case "Enorme":
                    selectAlturaImagen.Maximum = 160;
                    selectAlturaImagen.Value = 160;
                    
                    selectAnchoImagen.Maximum = 350;
                    selectAnchoImagen.Value = 350;
                    

                    lblAlturaImagen.Text = "Altura (Max: 160px)";
                    lblAnchoImagen.Text = "Ancho (Max: 350px)";

                    pictureBoxImagenItem.Size = new Size(350, 160);
                    break;
                case "Grande":

                    selectAlturaImagen.Maximum = 160;
                    selectAlturaImagen.Value = 160;
                    
                    selectAnchoImagen.Maximum = 160;
                    selectAnchoImagen.Value = 160;
                    

                    lblAlturaImagen.Text = "Altura (Max: 160px)";
                    lblAnchoImagen.Text = "Ancho (Max: 160px)";

                    pictureBoxImagenItem.Size = new Size(160, 160);
                    break;
                case "Mediano":

                    selectAlturaImagen.Maximum = 80;
                    selectAlturaImagen.Value = 80;

                    selectAnchoImagen.Maximum = 160;
                    selectAnchoImagen.Value = 160;
                    

                    lblAlturaImagen.Text = "Altura (Max: 160px)";
                    lblAnchoImagen.Text = "Ancho (Max: 80px)";

                    pictureBoxImagenItem.Size = new Size(160, 80);
                    break;
                case "Pequeño":

                    selectAlturaImagen.Maximum = 80;    
                    selectAlturaImagen.Value = 80;

                    selectAnchoImagen.Maximum = 80;
                    selectAnchoImagen.Value = 80;

                    lblAlturaImagen.Text = "Altura (Max: 80px)";
                    lblAnchoImagen.Text = "Ancho (Max: 80px)";

                    pictureBoxImagenItem.Size = new Size(80, 80);
                    break;
                case "Diminuto":

                    selectAlturaImagen.Maximum = 72;
                    selectAlturaImagen.Value = 72;
                    
                    selectAnchoImagen.Maximum = 72;
                    selectAnchoImagen.Value = 72;

                    lblAlturaImagen.Text = "Altura (Max: 72px)";
                    lblAnchoImagen.Text = "Ancho (Max: 72px)";

                    pictureBoxImagenItem.Size = new Size(72, 72);
                    break;
            }
        }

        private void selectAlturaImagen_ValueChanged(object sender, EventArgs e)
        {
            //pictureBoxImagenItem.Height = (int)selectAlturaImagen.Value;
            if (imageSourceItem != "")
                pictureBoxImagenItem.Image = ResizeImage(pictureBoxImagenItem.Image, (int)selectAnchoImagen.Value, (int)selectAlturaImagen.Value);
        }

        private void selectAnchoImagen_ValueChanged(object sender, EventArgs e)
        {
            //pictureBoxImagenItem.Width = (int)selectAnchoImagen.Value;
            if (imageSourceItem != "")
                pictureBoxImagenItem.Image = ResizeImage(pictureBoxImagenItem.Image, (int)selectAnchoImagen.Value, (int)selectAlturaImagen.Value);
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

        private void btnCrearItem_Click(object sender, EventArgs e)
        {
            //ItemModel _nuevoItem = new ItemModel(txtNombreItem.Text, selectorCategoria.SelectedText, selectorTamaño.Text);
        }




    }
}
