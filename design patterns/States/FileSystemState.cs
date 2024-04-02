using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.States
{
    internal abstract class FileSystemState
    {

        protected FileSystem fileSystem;
        public FileSystemState(FileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }
        public abstract void Commit(string strCommit);
        public abstract void Merge(FileSystem item);
        public abstract void UndoTheCommit(string strCommit);
        public abstract void RequestAReview(FileSystem item);
        public abstract void AddFiles(FileSystem item);
    }
}
