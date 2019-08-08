namespace SheepWorld.Domain.Models
{
    public class Square : Rectangle 
    {
      private double sideLength;
    

      public override double Length 
      {
        get
        {
          return sideLength;
        }
        set
        {
          Length = Width = value; 
        }
      }

      public 
    }
}