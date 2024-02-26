namespace ExemploGetterESetter;
public class Rocket
{
  int _fuel;
  int _maxFuel = 5000;

  public int FuelAsPercentage
  {
    get { return _fuel * 100 / _maxFuel; };
    set {
      if (value > 100 || value < 0)
        throw new ArgumentOutOfRangeException();
      
      _fuel = value * _maxFuel / 100; 
      // (return _fuel / _maxFuel) * 100; // Não funciona
    }
  }
}
