// Dando erro no console, mas o foco aqui é a sintaxe do try/catch/finally
namespace Program {
  public class Program {
    public bool VerifyProductValidity(int productId)
    {
      Database db = new Database();

      try {
        db.Open();
        var product = db.GetProduct(productId);

        if (product == null){
          throw new NullReferenceException("Produto não encontrado.");
        }

        return product.IsValid;
      } catch (NullReferenceException ex) {
        Console.WriteLine(ex.Message);
        throw;
      } finally {
        db.Close();
      }
    }
  }
}
