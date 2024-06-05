using System;
Console.Write("Karra jadval boshlanishi: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Karra jadval tugashi: ");
int end = Convert.ToInt32(Console.ReadLine());

        // Ustun kengligini belgilash
        int columnWidth = 15;

        // Har bir ustun uchun natijalarni chiqarish
        for (int j = 1; j <= 10; j++)
        {
            for (int i = start; i <= end; i++)
            {
                // Natijani chiqarish va ustun kengligiga moslash
                string result = $"{i} * {j} = {i * j}";
                Console.Write(result.PadRight(columnWidth));
            }
            Console.WriteLine(); 
        }