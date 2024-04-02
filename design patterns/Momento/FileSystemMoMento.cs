using design_patterns.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Momento
{
    internal class FileSystemMoMento
    {
        public FileSystemState Content { get; set; }
        public FileSystemMoMento(FileSystemState content)
        {
            Content = content;
        }
        public FileSystemMoMento(FileSystemMoMento fileSystemMoMento)
        {
            Content = fileSystemMoMento.Content;
        }
        public FileSystemState GetContent()
        {
            return Content;
        }

    }
}
