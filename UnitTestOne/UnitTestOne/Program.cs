using System.Data;

namespace UnitTestOne
{
    public static class TestWorkFromDB
    {
        public static string AddEntrySQLRequest(string table, string id, string name, string work)
        {
            if (table == null || id == null || name == null || work == null) 
            {
                Console.WriteLine("Error: an empty element!");
                return null;
            }
            else
            {
                string SqlRequest = $"INSERT INTO {table}(ID, Name, Work) VALUES ({id}, {name}, {work})";
                return SqlRequest;
            }
        }
        public static bool LogInToTheSystem(string login, string password)
        {
            if (Char.IsDigit(login[0]) || login.StartsWith(" ") || login.Contains("_"))
            {
                return false;
            }
            if (password.Contains(" "))
            {
                return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {

        }
    }
    
}

