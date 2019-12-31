using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Tetris.GameView.Blocks
{
    public class ImageBlock : Block
    {
        private Image image; //là 1 cái class của package System.Windows.Controls giúp
        //transter những hình ảnh có định dạng bmp, gif, .ico, jpg,png,wdp, tiff

        //Constructor
        public ImageBlock(int width, int height, int top, int left, string imageName)
            :base (top, left, width, height)
        {
            image = new Image(); 
            InitImage(imageName);
        }

        private void InitImage(string imageName)
        {
            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/"+imageName+".png")); // this will drag an image from the source given          
            image.Width = width; // set the width of the image, the resolution of the block
            image.Height = height; // set the height of the image, the height of the block
            image.SetValue(Canvas.LeftProperty, left);// this helps throw the image into the canvas, which helps the block to have the image infront off it
            image.SetValue(Canvas.TopProperty, top);
        }

        public override void MoveLeft()
        {
            base.MoveLeft();
            image.SetValue(Canvas.LeftProperty, left);
        }

        public override void MoveRight()
        {
            base.MoveRight();
            image.SetValue(Canvas.LeftProperty, left);
        }

        public override void MoveUp()
        {
            base.MoveUp();
            image.SetValue(Canvas.TopProperty, top);
        }

        public override void MoveDown()
        {
            base.MoveDown();
            image.SetValue(Canvas.TopProperty, top);
        }

        public override void DrawBlock(Canvas canvas)
        {
            canvas.Children.Add(image);
        }

        public override void DeleteBlock(Canvas canvas)
        {
            canvas.Children.Remove(image);
        }
    }
}
