using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class BusinessLogic
    {
        private List<User> users = new List<User>(); 
        private List<Record> records = new List<Record>(); 
        public BusinessLogic()
        {
            // наполнение обеих коллекций тестовыми данными 
            users.Add(new User(0, "Efim", "Kubishkin"));
            users.Add(new User(1, "Liza", "Borodina"));
            users.Add(new User(2, "Misha", "Kolesnikov"));
            users.Add(new User(3, "Lia", "Soloveva"));
            users.Add(new User(7, "Azat", "Gabdrahmanov"));
            users.Add(new User(5, "Katya", "Celovalnikova"));
            users.Add(new User(6, "Masha", "Celovalnikova"));
            users.Add(new User(4, "Masha", "Nikonova"));

            // Свернуть в LINQ запрос
            //foreach (var user in users)
            //{
            //    if (user.ID % 2 == 0)
            //    {
            //        records.Add(new Record(user, $"Отзыв номер {user.ID / 2 + 1}"));
            //    }
            //}

            records.AddRange(
                from user in users
                where user.ID % 2 == 0
                select new Record(user, $"Отзыв номер {user.ID / 2 + 1}"
                ));
        }
        public List<User> GetUsersBySurname(String surname)
        {
            var RightUsers = (from us in users
                              where us.Surname == surname
                              select us).ToList();
            return RightUsers;
        }
        public User GetUserByID(int id)
        {

            var RightUser = (from us in users
                              where us.ID == id
                              select us).Single();
            return RightUser;

        }
        public List<User> GetUsersBySubstring(String substring)
        {

            var RightUsers = (from us in users
                             where us.Name.Contains(substring) || us.Surname.Contains(substring)
                             select us).ToList();
            return RightUsers;
        }
        public List<String> GetAllUniqueNames()
        {

            var RightUsers = (from us in users
                              select us.Name).Distinct().ToList();
            return RightUsers;

        }
        public List<User> GetAllAuthors()
        {

            var Authors = (from re in records
                           select re.Author).ToList();
            return Authors;

        }
        public Dictionary<int, User> GetUsersDictionary()
        {

            var UserDict = users.ToDictionary(x => x.ID, x => x);
            return UserDict;

        }
        public int GetMaxID()
        {

            var MaxID = users.Max(x => x.ID);
            return MaxID;

        }
        public List<User> GetOrderedUsers()
        {

            var OrderedUsers = users.OrderBy(x => x.ID).ToList();
            return OrderedUsers;

        }
        public List<User> GetDescendingOrderedUsers()
        {


            var OrderedUsers = users.OrderByDescending(x => x.ID).ToList();
            return OrderedUsers;
        }
        public List<User> GetReversedUsers()
        {
            var n = new List<User>(users);
            n.Reverse();
            return n;
        }
        public List<User> GetUsersPage(int pageSize, int pageIndex)
        {

            var a = users.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return a;

        }
    }
}
