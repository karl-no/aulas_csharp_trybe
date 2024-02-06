public class Program {
  public static void Main() {

    Console.WriteLine("Informe um número inteiro");
    string? response = Console.ReadLine();
    int number = 0;
    var canConvert = Int32.TryParse(response, out number);

    switch (number) {
      case > 0:
          Console.WriteLine("maior que 0");
          break;
      case 0:
          Console.WriteLine("igual a zero");
          break;
      default:
          Console.WriteLine("menor que zero");
          break;
    }

    Console.WriteLine(IdentifyPolygon(Convert.ToInt32(response)));
    // Console.WriteLine(IdentifyPolygon(canConvert));
  }

  public static string IdentifyPolygon(int sideCount) {

    var name = string.Empty;
    
    switch (sideCount) {
      case < 3:
        name = "Não é um polígono";
        break;
      case 3:
        name = "Triângulo";
        break;
      case 4:
        name = "Quadrado";
        break;
      case 5:
        name = "Pentágono";
        break;
      default:
        name = "Polígono não identificado";
        break;
    }
    return name;
  }

}
