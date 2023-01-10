using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Exceptions;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    internal class AccountService : IAcoountService
    {
        public string Register(string username, string email, string password)
        {
            try
            {
                var result = GetAllEmails();

                if (result.Contains(email))
                {
                    throw new RegisterExceptions(ResponseMessages.InvalidRegisterMessage);
                }

                return "succes";


            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        private List<string> GetAllEmails()
        {
            return new List<string>() { "pervin12@gmail.com", "ali@code.az", "agshin@gmail.com" };
        }
    }
}
