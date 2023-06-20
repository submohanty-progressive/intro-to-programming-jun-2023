
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)  
    {
        if (numbers.Equals(""))
        {
            return 0;
        }
        int numCommas = 0;
        foreach (char comma in numbers)
        {
            if (comma == ',')
            {
                numCommas += 1;
            }
        }

        int[] splitArray = new int[numCommas + 1];
        string[] splitnumbers = numbers.Split(',');
        for (int i = 0; i < splitnumbers.Length; i++)
        {
            splitArray[i] = int.Parse(splitnumbers[i]);
        }
        int totalSum = 0;
        for (int i = 0; i < splitArray.Length; i++)
        {
            totalSum += splitArray[i];
        }
        return totalSum;
    }
}
    