using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection.Controller
{
    public class AccountController
    {
        private readonly IAcoountService _service;

        public AccountController()
        {
            _service = new AccountService();
        }
        public void Register()
        {
            Console.WriteLine("Add your username");
            string username = Console.ReadLine();

            Console.WriteLine("Add your username");
            string email = Console.ReadLine();

            Console.WriteLine("Add your username");
            string password = Console.ReadLine();


            var result = _service.Register(username, email, password);

            Console.WriteLine(result);
        }

    }
}
