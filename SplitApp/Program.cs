using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib01;

namespace SplitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Split split = new Split(); //create an instance of the class Split
            string path = @"C:\Users\Tarek\Documents\Training\Picture Split\19.jpg"; //take the path of the desired image
            split.splitInto(4, 3, path); //split the image 
        }
    }
}
