using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03C01LINQ
{
    public class BusinessLogic
    {
        private List<User> users = new List<User>();
        private List<Record> records = new List<Record>();

        public BusinessLogic()
        {
            users.Add(new User(0, "Al", "Bal"));
            users.Add(new User(1, "Twen", "Folaks"));
            users.Add(new User(2, "Frodo", "Begging"));
            users.Add(new User(3, "Frodo", "Begging"));
            users.Add(new User(4, "Frodo", "Begging"));
            users.Add(new User(5, "Frodo", "Begging"));
            users.Add(new User(6, "Frodo", "Begging"));
            users.Add(new User(7, "Frodo", "Begging"));
            users.Add(new User(8, "Frodo", "Begging"));
            users.Add(new User(9, "Frodo", "Begging"));
            users.Add(new User(10, "Frodo", "Begging"));

            records.Add(new Record(users[0], "First message"));
            records.Add(new Record(users[1], "2nd message"));
            records.Add(new Record(users[1], "Third message"));
        }

        public List<User> GetUsersBySurname(string surname)
        {
            var subset = from u in users
                         where u.Surname == surname
                         select u;

            return subset.ToList();
        }

        public User GetUserById(int id)
        {
            try
            {
                var subset = (from u in users where u.ID == id select u).Single();
                return subset;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new User(-1, "null", "null");
            }
        }

        public List<User> GetUsersBySubstring(string substring)
        {
            var subset =
                from u in users
                where u.Name.Contains(substring) 
                    || u.Surname.Contains(substring)
                select u;

            return subset.ToList();
        }

        public List<string> GetAllUniqueNames()
        {
            var subset = (from u in users select u.Name).Distinct();

            return subset.ToList();
        }

        public List<User> GetAllAuthors()
        {
            var subset = (from r in records select r.Author).Distinct();

            return subset.ToList();
        }

        public Dictionary<int, User> GetUsersDictionary()
        {
            try
            {
                Dictionary<int, User> pairs = users.ToDictionary(u => u.ID);

                return pairs;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Dictionary<int, User>();
            }
        }

        public int GetMaxID()
        {
            int maxID = (from u in users select u.ID).Max();

            return maxID;
        }

        public List<User> GetOrderedUsers()
        {
            var subset = from u in users
                         orderby u.ID
                         select u;

            return subset.ToList();
        }

        public List<User> GetDescendingOrderedUsers()
        {
            var subset = from u in users
                         orderby u.ID descending
                         select u;

            return subset.ToList();
        }

        public List<User> GetReversedUsers()
        {
            var subset = from u in users
                         orderby u.ID
                         select u;

            List<User> result = subset.ToList();
            result.Reverse();

            return result;
        }

        public List<User> GetUsersPage(int pageSize, int pageIndex)
        {
            var subset = (from u in users select u)
                .Skip(pageSize * pageIndex)
                .Take(pageSize);

            return subset.ToList();
        }
    }
}
