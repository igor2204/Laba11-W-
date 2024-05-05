class Program
{
    // Объявление делегата
    delegate string DayOfWeekDelegate();

    static void Main(string[] args)
    {
        // Массив с названиями дней недели
        string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        // Индекс текущего дня недели (начинается с понедельника)
        int currentDayIndex = 0;

        // Создание экземпляра делегата с помощью лямбда-выражения
        DayOfWeekDelegate getDayOfWeek = () =>
        {
            string day = daysOfWeek[currentDayIndex];
            currentDayIndex = (currentDayIndex + 1) % daysOfWeek.Length; // Переход к следующему дню, циклически
            return day;
        };

        // Вызов делегата несколько раз
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(getDayOfWeek());
        }

        Console.ReadLine();
    }
}
