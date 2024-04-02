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
        public FileSystemState(FileSystemState fileSystemState)
        {
            this.fileSystem = new FileSystem(fileSystemState.fileSystem);
        }
        public abstract string Commit(string strCommit);
        public abstract string Merge(FileSystem item);
        public abstract string UndoTheCommit(string strCommit);
        public abstract void RequestAReview();
        public abstract string AddFiles();
        public abstract string Confirmation();
    }
}
