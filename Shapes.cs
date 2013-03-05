
  public abstract class Shapess
    {
       protected int Width { get; set; }
       protected int Height { get; set; }
       public Shapess(int width)
       {
           this.Width = width;
       }
       public Shapess(int widht, int height)
       {
           this.Width = widht;
           this.Height = height;
       }
       public abstract double CalculateSurface();
       
    }

