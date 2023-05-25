namespace ciagLiczbKonsola
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Podaj ciąg liczb do opisania (liczby oddziel przecinkami): ");
            string tabCandidate = $"{Console.ReadLine()},";
            int[] tabA = new int[tabCandidate.Length * 2];
            for (int i = 0; i < tabA.Length; i++)
            {
                tabA[i] = 0;
            }
            int x = 0;
            string temp = "";
            for (int i = 0; i < tabCandidate.Length; i++)
            {
                if (tabCandidate[i] != ',')
                {
                    temp += tabCandidate[i];
                }
                else
                {
                    tabA[x] = int.Parse(temp);
                    x++;
                    temp = "";
                }
            }
            int[] tabB = new int[tabA.Length];
            for (int i = 0; i < tabB.Length; i++)
            {
                tabB[i] = 0;
            }
            int count = 0;
            int num = 0;
            int z = 0;
            for (int i = 0; i < tabA.Length; i++)
            {
                if (num != tabA[i])
                {
                    if (num != 0)
                    {
                        tabB[z] = count;
                        z++;
                        tabB[z] = num;
                        z++;
                    }
                    num = tabA[i];
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            string result = "Ciąg przed opisaniem: ";
            for (int i = 0; i < tabA.Length; i++)
            {
                if (tabA[i] != 0)
                {
                    result += $"{tabA[i]}";
                }
            }
            result += ". Ciąg po opisaniu: ";
            for (int i = 0; i < tabB.Length; i++)
            {
                if (tabB[i] != 0)
                {
                    result += $"{tabB[i]}";
                }
            }
            int actualLength = 0;
            for (int i = 0; i < tabB.Length; i++)
            {
                if (tabB[i] != 0)
                {
                    actualLength++;
                }
            }
            result += $". Długość opisu ciągu A: {actualLength}";
            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}