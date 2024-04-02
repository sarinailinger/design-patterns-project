using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class User
    {
        public string UserName { get; set; }
        public int Password { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public User(string UserName, int Password, int Id, string Email)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Id = Id;
            this.Email = Email;
        }
        public void Update()
        {

        }
    }
}
