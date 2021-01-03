using RacoonLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacoonLogin.Model
{
    public class Controling
    {
        public bool verified { get; set; }
        public string message = "";

        public bool Access(string login, string password)
        {
            var loginCommand = new LoginComand();
            verified = loginCommand.VerifyLogin(login, password);
            if(!loginCommand.message.Equals(""))
            {
                this.message = loginCommand.message;
            }
            return verified;
        }

        public string Register(string login, string password, string passwordConfirmation)
        {
            var loginCommand = new LoginComand();
            message = loginCommand.RegisterLogin(login, password, passwordConfirmation);
            if (loginCommand.verified) verified = true;
            return message;
        }

    }
}
