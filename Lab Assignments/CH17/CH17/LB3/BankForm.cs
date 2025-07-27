using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class BankForm
    {
        List<Account> bankAccounts = new List<Account>
        {
            new Account("John Doe", "5231", "John", false),
            new Account ("Jane Doe", "9012", "Jane", false),
            new Account ("David Doe", "1245", "David", true),
            new Account ("Grandpa Doe", "5678", "Grandpa", true),
            new Account ("Grandma Doe", "8141", "Grandma", false)
        };
       
        public Account Login(string username,string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new NoUsernamePasswordException("You must enter a username and password.");
            }
            Account found = null;
            foreach (Account acc in bankAccounts)
            {
                if (acc.Username == username && acc.Password == password) 
                {
                    found = acc;
                    break;
                }
            }
            if (found == null)
            {
                throw new IncorrectPasswordException("Password is incorrect, try again.");
            }
            if (found.Disabled)
            {
                throw new AccountDisabledException("This account is disabled.");
            }
            return found;
        }
    }
}
