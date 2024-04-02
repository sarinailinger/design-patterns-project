using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class Repository
    {
          
        public List<User> Users { get; set; }
        public Branch MainBranch { get; set; }
        public string NameReposetory { get; set; }
        public Repository( string NameReposetory)
        {
            Users = new List<User>();
            this.MainBranch = new Branch(Branches.main);
            this.NameReposetory= NameReposetory;
        }
        public void AddUser(User user)
        {
            Users.Add(user);
        }
        public void RemoveUser(User user)
        {
            Users.Remove(user);
        }
        public void NotifyUsers()
        {
            foreach (User user in Users)
            {
                user.Update();
            }
        }
    }
}
