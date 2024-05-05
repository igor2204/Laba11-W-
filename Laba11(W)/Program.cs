class Program
{
    delegate string DayOfWeekDelegate();

    static void Main(string[] args)
    {
        string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        int currentDayIndex = 0;

        DayOfWeekDelegate getDayOfWeek = () =>
        {
            string day = daysOfWeek[currentDayIndex];
            currentDayIndex = (currentDayIndex + 1) % daysOfWeek.Length; 
            return day;
        };

        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(getDayOfWeek());
        }

        Console.ReadLine();
    }
}
