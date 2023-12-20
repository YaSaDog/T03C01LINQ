namespace T03C01LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic bl = new BusinessLogic();

            var req1 = bl.GetUsersBySurname("Begging");
            foreach (var u in req1)
                Console.WriteLine(u);
            Console.WriteLine();

            var req2 = bl.GetUsersBySurname("NULL");
            foreach (var u in req2)
                Console.WriteLine(u);
            Console.WriteLine();

            Console.WriteLine(bl.GetUserById(1));
            Console.WriteLine();

            var req3 = bl.GetUsersBySubstring("a");
            foreach (var u in req3)
                Console.WriteLine(u);
            Console.WriteLine();

            var req4 = bl.GetUsersBySubstring("Hell yeah");
            foreach (var u in req4)
                Console.WriteLine(u);
            Console.WriteLine();

            var req5 = bl.GetAllUniqueNames();
            foreach (var u in req5)
                Console.WriteLine(u);
            Console.WriteLine();

            var req6 = bl.GetAllAuthors();
            foreach (var u in req6)
                Console.WriteLine(u);
            Console.WriteLine();

            var req7 = bl.GetUsersDictionary();
            foreach (var kvl in req7)
                Console.WriteLine($"{kvl.Key} - {kvl.Value}");
            Console.WriteLine();

            var req8 = bl.GetMaxID();
            Console.WriteLine(req8);
            Console.WriteLine();

            var req9 = bl.GetOrderedUsers();
            foreach (var u in req9)
                Console.WriteLine(u);
            Console.WriteLine();

            var req10 = bl.GetDescendingOrderedUsers();
            foreach (var u in req10)
                Console.WriteLine(u);
            Console.WriteLine();

            var req11 = bl.GetReversedUsers();
            foreach (var u in req11)
                Console.WriteLine(u);
            Console.WriteLine();

            var req12 = bl.GetUsersPage(5, 1);
            foreach (var u in req12)
                Console.WriteLine(u);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
