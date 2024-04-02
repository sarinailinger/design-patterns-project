using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.States
{
    internal class Merged : FileSystemState
    {
        public Merged(FileSystem fileSystem) : base(fileSystem)
        {
        }
        public Merged(Merged merged):base(merged) 
        {
            
        }

        public override string AddFiles()
        {
            throw new NotImplementedException();
        }

        public override string Commit(string strCommit)
        {
            throw new NotImplementedException();
        }

        public override string Confirmation()
        {
            throw new NotImplementedException();
        }

        public override string Merge(FileSystem item)
        {
            throw new NotImplementedException();
        }

        public override void RequestAReview()
        {
            throw new NotImplementedException();
        }

        public override string UndoTheCommit(string strCommit)
        {
            throw new NotImplementedException();
        }
    }
}
