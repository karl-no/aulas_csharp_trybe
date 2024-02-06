public class Program {
  public static void Main() {
    for (int forNumber = 0; forNumber < 3; forNumber++) {
      Console.WriteLine("Número " + forNumber);
    }

    string[] foreachNomes = new string[] {"João", "Maria", "José", "Madalena"};
    foreach (var nome in foreachNomes) {
      Console.WriteLine(nome);
    }
  }
}