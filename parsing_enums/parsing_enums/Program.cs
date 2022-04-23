namespace parsing_enums
{
    class program
    {
        public enum DaysOfTheWeek
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
         
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Type in the day of the week!");
                var day = Console.ReadLine();
                DaysOfTheWeek daysOfTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);
                Console.WriteLine("Yes it's " + daysOfTheWeek);
            }
            catch (Exception)
            {
                Console.WriteLine("That's not a day of the week!");
            }
        }
    }
}