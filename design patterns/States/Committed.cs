using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.States
{
    internal class Committed : FileSystemState
    {
        public Committed(FileSystem fileSystem) : base(fileSystem)
        {
        }
        public Committed(Committed committed):base(committed) { }

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
            Committed state = new Committed(this); 
            this.fileSystem.MoMento.Content = state;
            this.fileSystem.CareTaker.history.Push(this.fileSystem.MoMento);
            fileSystem.RequestAReview();
            fileSystem.State = new UnderReview(fileSystem);
        }

        public override string UndoTheCommit(string strCommit)
        {
            Committed state = new Committed(this);
            this.fileSystem.MoMento.Content = state;
            this.fileSystem.CareTaker.history.Push(this.fileSystem.MoMento);
            fileSystem.State = new Staged(fileSystem);
             return (fileSystem.UndoTheCommit(strCommit));
           
        }
    }
}
