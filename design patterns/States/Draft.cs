using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.States
{
    internal class Draft : FileSystemState
    {
        public Draft(FileSystem fileSystem) : base(fileSystem)
        {
        }
        public Draft(Draft draft):base(draft) { }

        
        public override string AddFiles()
        {
            this.fileSystem.MoMento.Content = this.fileSystem.State;
            this.fileSystem.CareTaker.history.Push(this.fileSystem.MoMento);
            fileSystem.State = new Staged(fileSystem);
            return fileSystem.AddFiles(this.fileSystem);
            
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
