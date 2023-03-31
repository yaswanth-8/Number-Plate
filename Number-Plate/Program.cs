using System.Text;

class Program
{
    static string TransformPlate(string givenString, int number)
    {
        string finalString = "";

        givenString = givenString.ToUpper();
        foreach (char i in givenString)
        {
            if (i=='-')
            {
                continue;
            }
            else
            {
                finalString += i;
            }
        }
        int position = finalString.Length % number;
        while(position < finalString.Length)
        {
            if(position ==0) {
                position += number;
                continue; 
            }
            finalString = finalString.Insert(position, "-");
            position += (number+1);
        }
        
        return finalString.ToString();
    }

    static void Main(string[] args)
    {
        Console.WriteLine(TransformPlate("5F3Z-2e-9-w", 4));
        Console.WriteLine(TransformPlate("nlj-206-fv", 3));
    }
}