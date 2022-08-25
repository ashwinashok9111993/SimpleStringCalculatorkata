namespace SimpleStringCalculator;
public class StringCalculator
{
    public static int add_from_string(string input)
    {
        var ListFromString = input.Split(',');
        var integerListfromString = ListFromString.Select(int.Parse);
        return integerListfromString.AsQueryable().Sum(); 
    }
}
