using design_patterns.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class FileSystem
    {
        public string Name { get; set; }
        public float Size { get; set; }
        public FileSystemState State
        {
            private get;
            set;
        }
        public FileSystem(string name, float size)
        {
            Name = name;
            Size = size;
            State = new Draft(this);
        }
        public FileSystem(string name)
        {
            Name = name;
            State = new Draft(this);
        }
        public FileSystem()
        {
            State = new Draft(this);
        }
        public string Merge(FileSystem other)
        {
            return $"You merged file {this.Name} with branch {other.Name}";
        }
        public string Commit(FileSystem item)
        {
            return $"The file {item.Name} committed";
        }
        public string UndoTheCommit(string strCommit)
        {
            return $"The commit {strCommit} canceled";
        }
        public string AddFiles(FileSystem item)
        {
            return $"You added the files {item.Name}";
        }
        public void RequestAReview(FileSystem item)
        {

        }

    }
}
