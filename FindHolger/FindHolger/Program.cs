Console.WriteLine("Find Holger! ");

List<char> charList = new List<char>
{ 'a' , 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
    'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'æ', 'ø', 'å'};

Random random = new Random();

//Note til Peter: Jeg har holdt mig til row og column = 15, da det gav bedre overblik på skærmen, fordi jeg brugte tabulering.
//Jeg kunne rette koden og bruge whitespaces istedet for tabulering, men jeg følte ikke at det gav mening blot for dette!
int row = 15;
int column = 15;

int randomRow = random.Next(row);
int randomColumn = random.Next(column);

Console.WriteLine(randomRow);
Console.WriteLine(randomColumn);
Console.WriteLine();

Console.Write("#" + "\t");

for (int i = 0; i < column; i++)
{
    Console.Write(i + "\t");
}
Console.WriteLine();

for (int i = 0; i < row; i++)
{
    Console.ResetColor();
    Console.Write(i + "\t");

    for (int j = 0; j < column; j++)
    {
        int randomColor = random.Next(0, 6);

        if (randomColor == 0) { Console.ForegroundColor = ConsoleColor.Blue; }
        else if (randomColor == 1) { Console.ForegroundColor = ConsoleColor.Red; }
        else if (randomColor == 2) { Console.ForegroundColor = ConsoleColor.Green; }
        else if (randomColor == 3) { Console.ForegroundColor = ConsoleColor.Yellow; }
        else if (randomColor == 4) { Console.ForegroundColor = ConsoleColor.Cyan; }
        else if (randomColor == 5) { Console.ForegroundColor = ConsoleColor.White; }

        if (i == randomRow && j == randomColumn)
        {
            Console.Write("@" + "\t");
        }
        else
        {
            bool isUpper = Convert.ToBoolean(random.Next(0, 2));

            if (isUpper == true)
            {
                Console.Write(Char.ToUpper(charList[random.Next(charList.Count)]) + "\t");
            }
            else
            {
                Console.Write(charList[random.Next(charList.Count)] + "\t");
            }
        }
    }
    Console.WriteLine();
}

try
{
    Console.ResetColor();
    Console.WriteLine("Hvor er Holger? (@)");

    Console.WriteLine("Indtast rækkenr: ");
    int rowInput = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Indtast kolonnenr: ");
    int columnInput = Convert.ToInt32(Console.ReadLine());

    if (rowInput == randomRow && columnInput == randomColumn)
    {
        Console.WriteLine("Tillykke! Du fandt Holger :)");
    }
    else
    {
        Console.WriteLine("Desværre, det er forkert. Prøv igen!");
    }
}
catch (Exception)
{
    Console.WriteLine("Input ikke korrekt. Benyt talværdier til række og kolonnenr!");
}