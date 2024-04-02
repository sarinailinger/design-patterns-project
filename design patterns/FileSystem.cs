using design_patterns.Momento;
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
        public FileSystemState State { get; set; }
        public Repository Repo { get; set; }
        public FileSystemMoMento MoMento { get; set; }
        public FileSystemCareTaker CareTaker { get; set; }
        public FileSystem(string name, float size, Repository repository)
        {
            Name = name;
            Size = size;
            Repo = repository;
            State = new Draft(this);
            MoMento = new FileSystemMoMento(this.State);
            CareTaker = new FileSystemCareTaker();
        }
        public FileSystem(FileSystem fileSystem)
        {
            this.Name = fileSystem.Name;
            this.Size = fileSystem.Size;
            Repo = fileSystem.Repo;
            this.State = new Draft(fileSystem);
            this.MoMento = new FileSystemMoMento(fileSystem.MoMento);
            this.CareTaker = fileSystem.CareTaker;
        }

        public string Merge(FileSystem other)
        {
            return $"You merged file :{this.Name} with files: {other.Name}";
        }
        public string Commit(string str)
        {
            return $"The file :{this.Name} committed:  {str}";
        }
        public string UndoTheCommit(string strCommit)
        {
            return $"The commit :{strCommit} canceled";
        }
        public string AddFiles(FileSystem item)
        {
            return $"You added the files : {item.Name}";
        }
        public void RequestAReview()
        {
            Repo.NotifyUsers();
        }
        public string Confirmation()
        {
            return $"The test was successful";
        }

    }
}
