using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Lib01
{
    public class Split
    {

        //-------------------------------------------------------------
        //The method will split the image into parts
        //Precondition: takes the number of rows and columns that the image will be split into, and the path of the desired image to be split
        //Postcondition: generates the split images and saves them in a destinated folder
        //-------------------------------------------------------------
        public void splitInto(int rows, int columns, string path)
        {
            #region declaration of variables
            var imgarray = new Image[rows, columns]; //Create a double array of type Image
            var img = Image.FromFile(path); //Get image path and store it in variable img
            int height = img.Height; //Get image height
            int width = img.Width;//Get image width
            int one_img_h = height / rows; //Get the height of a split image by dividing the original image height with the number of rows to be split
            int one_img_w = width / columns;////Get the width of a split image by dividing the original image width with the number of columns to be split
            #endregion 

            #region splitting the image
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    
                    imgarray[i, j] = new Bitmap(one_img_w, one_img_h);//generating new bitmap in every element in the array.
                    var graphics = Graphics.FromImage(imgarray[i, j]);
                    graphics.DrawImage(img, new Rectangle(0, 0, one_img_w, one_img_h), new Rectangle(j * one_img_w, i * one_img_h, one_img_w, one_img_h), GraphicsUnit.Pixel);//Generating Splitted Pieces of Image
                    graphics.Dispose();
                }
            }
            #endregion 

            #region saving the image splits in a destination folder
            var destinationFolderName = @"C:\Users\Tarek\Documents\Training\Picture Split\Image's splits";//Define the destination path for saving the splitted images

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    imgarray[i, j].Save(@"" + destinationFolderName + "/" + i + "_" + j + ".jpg");//Save every element of the image array in the destination folder
                }
            }
            #endregion
        }
    }
}




