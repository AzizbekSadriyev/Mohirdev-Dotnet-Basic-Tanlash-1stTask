// String ustida amallar

/*
String tipida (string str) qiymat berilgan. Consoleda int tipidagi qiymat kiriting. Agar bu son str ning uzunligidan katta bo’lsa, str ni katta harflarga o’giring, aks holda kichik harflarga o’giring.
Input: x=13, str="teLefOn"
Output: "TELEFON"
*/

namespace Task
{
    public class FirstTask
    {
        public static void Task()
        {
            Console.Write("Enter one natural number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter one string: ");
            string? str = Console.ReadLine();

            if (number > str!.Length)
            {
                str.ToUpper();
            }
            else
            {
                str.ToLower();
            }

            Console.WriteLine(str);
        }
    }
}
