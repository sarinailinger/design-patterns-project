using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.States
{
    internal class Staged : FileSystemState
    {
        public Staged(FileSystem fileSystem) : base(fileSystem)
        {
        }
        public Staged(Staged staged) : base(staged)
        {

        }

        public override string AddFiles()
        {
            throw new NotImplementedException();
        }

        public override string Commit(string strCommit)
        {
            this.fileSystem.MoMento.Content = this.fileSystem.State;
            this.fileSystem.CareTaker.history.Push(this.fileSystem.MoMento);
            this.fileSystem.State = new Committed(fileSystem);
            return (this.fileSystem.Commit(strCommit));


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
