using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.States
{
    internal class UnderReview : FileSystemState
    {
        public UnderReview(FileSystem fileSystem) : base(fileSystem)
        {
        }
        public UnderReview(UnderReview underReview):base(underReview)
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
            this.fileSystem.MoMento.Content = this.fileSystem.State;
            this.fileSystem.CareTaker.history.Push(this.fileSystem.MoMento);
            fileSystem.State = new ReadyToMerge(fileSystem);
             return (fileSystem.Confirmation());
            

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
            this.fileSystem.MoMento.Content = this.fileSystem.State;
            this.fileSystem.CareTaker.history.Push(this.fileSystem.MoMento); 
            fileSystem.State = new Staged(fileSystem);
            return ( fileSystem.UndoTheCommit(strCommit));
           
        }
    }
}
