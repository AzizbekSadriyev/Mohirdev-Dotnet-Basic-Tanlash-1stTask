// Switch expression

/*
Consoleda o'zbek tilida kiritilgan hafta kunini ingliz tiliga o'girib, natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!
*/

namespace Task
{
    public class ThirdTask
    {
        public static void Task()
        {
            Console.Write("Hafta kunini kiriting: ");
            string? dayOfWeek = Console.ReadLine();
            dayOfWeek = dayOfWeek!.ToLower();

            string text = dayOfWeek switch
            {
                "dushanba" => "Dushanba ingliz tilida \"Monday\" deyiladi",
                "seshanba" => "Seshanba ingliz tilida \"Tuesday\" deyiladi",
                "chorshanba" => "Chorshanba ingliz tilida \"Wednesday\" deyiladi",
                "payshanba" => "Payshanba ingliz tilida \"Thursday\" deyiladi",
                "juma" => "Juma ingliz tilida \"Friday\" deyiladi",
                "shanba" => "Shanba ingliz tilida \"Saturday\" deyiladi",
                "yakshanba" => "Yakshanba ingliz tilida \"Sunday\" deyiladi",
                _ => "Hafta kuni aniqlanmadi!"
            };

            Console.WriteLine(text);
        }
    }
}
