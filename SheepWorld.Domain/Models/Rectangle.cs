namespace SheepWorld.Domain.Models
{
    public class Rectangle : Shape
    {
      public virtual double Length {get; set;}
      public virtual double Width {get; set;}
      public Rectangle() : base(4) 
      {
      }

      public override double Perimter() 
      {
        return 2 * (Length + Width); 
      }

      public double Area()
      {
        return Length * Width;
      }

      public override double Volume() {
        return Perimter() * 10; 
      }
    }
}