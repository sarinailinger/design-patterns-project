using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class FileSystemMoMento
    {
        private FileSystem Content { get; set; }
        public FileSystemMoMento(FileSystem content)
        {
            this.Content = content;
        }
        public FileSystem GetContent()
        {
            return this.Content;
        }

    }
}
