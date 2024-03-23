using System;

public partial class Coords
{
    private int x;
    private int y;

    /// <summary>
    /// Initializes a new instance of the <see cref="Coords"/> class with the specified coordinates.
    /// </summary>
    /// <param name="x">The x-coordinate.</param>
    /// <param name="y">The y-coordinate.</param>
    public Coords(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    /// <summary>
    /// Prints the coordinates.
    /// </summary>
    public void PrintCoords()
    {
        Console.WriteLine("Coords: {0},{1}", x, y);
    }
}

public partial class Coords
{
    static void Main()
    {
        Coords myCoords = new Coords(10, 15);
        myCoords.PrintCoords();

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
// Output: Coords: 10,15