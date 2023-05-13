public class Program {
  // This is an extremely simple program, but one could always make use of
  // a command-line argument parser library such as CommandLineParser, which
  // would produce a more robust entry point as well as human-friendly errors.
  public static void Main(string[] args) {
    if (args.Length != 1) {
      Console.WriteLine("Draws a diamond of letters.\n");
      Console.WriteLine("Usage:");
      Console.WriteLine("  Diamond <midLetter>\n");
      Console.WriteLine("Example:");
      Console.WriteLine("  Diamond C\n");
      Console.WriteLine("Output:\n");
      Console.WriteLine("  A  ");
      Console.WriteLine(" B B ");
      Console.WriteLine("C   C");
      Console.WriteLine(" B B ");
      Console.WriteLine("  A  ");
      return;
    }

    var inputChar = args[0][0];
 
    try {
      var diamond = DiamondMaker.GenerateDiamond(inputChar);
      Console.WriteLine(diamond);
    } catch (ArgumentException e) {
      Console.WriteLine(e.Message);
    }
  }
}