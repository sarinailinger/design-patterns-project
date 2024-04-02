using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.States
{
    internal class ReadyToMerge : FileSystemState
    {
        public ReadyToMerge(FileSystem fileSystem) : base(fileSystem)
        {
        }
        public ReadyToMerge(ReadyToMerge readyToMerge):base(readyToMerge)
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
            this.fileSystem.MoMento.Content = this.fileSystem.State;
            this.fileSystem.CareTaker.history.Push(this.fileSystem.MoMento); 
            fileSystem.State = new Merged(fileSystem);
             return (fileSystem.Merge(item));
           
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
