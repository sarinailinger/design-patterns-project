using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class Branch
    {
        public Branches BranchesType { get; set; }
        public List<FileSystem> FileSystem { get; set; }

        public Branch(Branches branches) 
        { 
            this.BranchesType = branches;
            FileSystem = new List<FileSystem>();

        }

        public void CreatBranch()
        {

        }

        public void DeleteBranch()
        {

        }


    }
}
