public class Program {
  public static void Main() {
    int whileNumber = 0;

    Console.WriteLine("Laço while até 3:");
    while (whileNumber < 3) {
      Console.WriteLine(whileNumber);
      whileNumber++;
    }
    
    Console.WriteLine("Laço do/while até 0 usando a mesma variável do while:");
    do {
      Console.WriteLine(whileNumber);
      whileNumber--;
    } while (whileNumber > 0);

  }
}
