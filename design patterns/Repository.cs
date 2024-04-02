using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class Repository
    {
          
        public List<User> users { get; set; }
        public Branch MainBranch { get; set; }
        public string NameReposetory { get; set; }
        public Repository( string NameReposetory)
        {
            users = new List<User>();
            this.MainBranch = new Branch(Branches.main);
            this.NameReposetory= NameReposetory;
        }



    }
}
