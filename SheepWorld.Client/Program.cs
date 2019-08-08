using System; //Import
using SheepWorld.Domain;
using SheepWorld.Domain.Models;

namespace SheepWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayWithShape(); //Keep Main this small! 
        }

        private static void PlayWithShape()
        {
          //Shape someShape = new Shape(10);
          Rectangle someRectangle = new Rectangle();
          Square someSquare = new Square();
          //someShape.setEdges(10);
          //Console.WriteLine(someShape.NumberOfEdges);
          System.Console.WriteLine(someRectangle.NumberOfEdges);
          System.Console.WriteLine(someSquare.NumberOfEdges);

        }
    }
}
