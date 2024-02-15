  public class DataUtil
  {
      public static void Main()
      {
          DateTime date1 = new DateTime(2010, 9, 1, 5, 0, 0);
          DateTime date2 = new DateTime(2022, 8, 10, 12, 0, 0);

          int result = DateTime.Compare(date1, date2);
          string relationship;

          if (result < 0) relationship = "é anterior à";
          else if (result == 0) relationship = "è o mesmo que";
          else relationship = "è posterior à";

          Console.WriteLine("{0} {1} {2}", date1, relationship, date2);
      }
  }
