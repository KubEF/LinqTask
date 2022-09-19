using System;
namespace LinqTask {

   class program
    {
        static private void Test(string result, string testingMethod)
        {
            Console.WriteLine($"Прверка коррекности работы метода {testingMethod}: \n ожидается вывод: {result}");
        }
        static void Main(string[] args)
        {
            BusinessLogic businessLogic = new BusinessLogic();

            Test("'Katya, Masha'", "GetUsersBySurname");
            businessLogic.GetUsersBySurname("Celovalnikova").ForEach(a => Console.WriteLine( a.Name));


            Test("'Efim'", "GetUserByID");
            Console.WriteLine(businessLogic.GetUserByID(0).Name);


            Test("'Misha, Lia'", "GetUsersBySubstring");
            businessLogic.GetUsersBySubstring("ol").ForEach(a => Console.WriteLine(a.Name));

            Test("'Efim, Liza, Misha, Lia, Azat, Katya, Masha'", "GetAllUniqueNames");
            businessLogic.GetAllUniqueNames().ForEach(a => Console.WriteLine(a));


            Test("'Efim, Misha, Azat, Masha'", "GetAllAuthors");
            businessLogic.GetAllAuthors().ForEach(a => Console.WriteLine(a.Name));


            Test("'Efim, Liza, Misha, Lia, Azat, Katya, Masha, Masha'", "GetUsersDictionary");
            businessLogic.GetUsersDictionary().Values.ToList().ForEach(a => Console.WriteLine(a.Name));


            Test("'7'", "GetMaxID");
            Console.WriteLine(businessLogic.GetMaxID());


            Test("'Efim, Liza, Misha, Lia, Masha, Katya, Masha, Azat'", "GetOrderedUsers");
            businessLogic.GetOrderedUsers().ForEach(a => Console.WriteLine(a.Name));


            Test("'Azat, Masha, Katya, Masha, Lia, Misha, Liza, Efim'", "GetDescendingOrderedUsers");
            businessLogic.GetDescendingOrderedUsers().ForEach(a => Console.WriteLine(a.Name));


            Test("'Masha, Masha, Katya, Azat, Lia, Misha, Liza, Efim'", "GetReversedUsers");
            businessLogic.GetReversedUsers().ForEach(a => Console.WriteLine(a.Name));


            Test("'Efim, Liza'", "GetUsersPage");
            businessLogic.GetUsersPage(2, 1).ForEach(a => Console.WriteLine(a));
        }
    }
}