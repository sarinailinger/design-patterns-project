using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class Folder : FileSystem
    {
        public List<FileSystem> item { get; set; }
        public Folder(string name, float size, Repository repository) : base(name, size, repository)
        {
            item = new List<FileSystem>();
        }
        public void Add(FileSystem fileSystem)
        {
            item.Add(fileSystem);
        }
    }
}
