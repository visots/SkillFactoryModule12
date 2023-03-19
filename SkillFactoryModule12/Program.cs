namespace SkillFactoryModule12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BuildArray();
            CheckAge();

        }

        static void BuildArray()
        {
            Console.WriteLine("Сколько элементов будет в массиве?");

            int count = Int32.Parse(Console.ReadLine());
            int [] array = new int[count];

            for (int i = 0; i < count; i++)
                array[i] = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Все элементы записаны");
        }

        static void CheckAge()
        {
            Console.WriteLine("Введите свой возраст");

            int age = Int32.Parse(Console.ReadLine());

            if (age > 13)
                Console.WriteLine("Вы успешно зарегистрированы");
            else
                Console.WriteLine("Пользователи младше 14 лет не могут быть зарегистрированы");
        }
    }
}