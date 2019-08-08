namespace SheepWorld.Domain
{
    public abstract class Shape
    {
        //Fields
        //private int numberOfEdges;

        //Properties
        public int NumberOfEdges{get; private set;}

        //Methods
        /*
        public int getEdges() {
          return numberOfEdges;
        }

        public void setEdges(int edges) {
          if (numberOfEdges == 0) 
          {
            numberOfEdges = edges;
          }
        }
        */
        public Shape(int edges)
        {
            NumberOfEdges = edges;
        }

        public virtual double Perimter() { 
          return 0; 
        }

        public virtual double Volume() {
          return 0; 
        }
    }
}