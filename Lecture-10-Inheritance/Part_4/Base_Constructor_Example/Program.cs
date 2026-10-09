GraphicalDice dice = new GraphicalDice(3, 5);


public class PairOfDie
{
    private int d1;
    private int d2;

    public PairOfDie(int d1value, int d2value)
    {
        d1 = d1value;
        d2 = d2value;

        Console.WriteLine("PairOfDie constructor called");
        Console.WriteLine("d1 = " + d1);
        Console.WriteLine("d2 = " + d2);
    }
}


public class GraphicalDice : PairOfDie
{
    public GraphicalDice(int d1value, int d2value)
        : base(d1value, d2value)
    {
        //Console.WriteLine("GraphicalDice constructor called");
        draw();
    }

    public void draw()
    {
        Console.WriteLine("Drawing the dice...");
    }
}
