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
        public List<Branch> BranchesList { get; set; }

        public Branch(Branches branches)
        {
            this.BranchesType = branches;
            FileSystem = new List<FileSystem>();
            BranchesList = new List<Branch>();
        }
        public Branch(Branch branch)
        {
            this.BranchesType = branch.BranchesType;
            FileSystem = new List<FileSystem>();
            BranchesList = new List<Branch>();
            foreach (FileSystem fs in branch.FileSystem)
            {
                this.FileSystem.Add(fs);
            }
        }

        public void CreateBranch()
        {
            this.BranchesList.Add(new Branch(this));
        }

        public void DeleteBranch(Branch branch)
        {
            this.BranchesList.Remove(branch);
        }

    }
}
