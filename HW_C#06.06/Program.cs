
namespace HW_C_06._06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задача 1.\n");
            //var numbers = new List<int> { -1,-2,-3,-4,-5,-6};
            var numbers = new List<int> { 1,2,3,-4,5,-6,7,8,9,-10};
            try
            {
                double average = numbers.GetAveragePositiveNumbers();
                Console.WriteLine($"Среднее положительных чисел: {average}");
            }
            catch(NoPositiveNumbersExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Задача 2.\n");
            
            var contactManager = new ContactManager();
            try
            {
                contactManager.AddContact("Иван Иваныч", "89132689797");
                contactManager.AddContact("Сан Саныч", "89138527971");
                contactManager.AddContact("", "89991233669");
            }
            catch(ContactException ex)
            {
                Console.WriteLine(ex.Message);
            }

            var findCont = contactManager.FindContactByName("Иван Иваныч");
            foreach(var contact in findCont)
            {
                Console.WriteLine($"Имя: {contact.Name}\nТелефон: {contact.PhoneNumber}");
            }
            
        }
    }
}
