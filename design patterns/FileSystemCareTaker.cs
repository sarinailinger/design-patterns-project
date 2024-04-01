using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class FileSystemCareTaker
    {
        private Stack<FileSystemMoMento> history;
        public FileSystemCareTaker()
        {
            history= new Stack<FileSystemMoMento>();
        }
        public FileSystemMoMento Pop()
        {
            return history.Pop();
        }
        public void Push(FileSystemMoMento moMento)
        {
            history.Push(moMento);
        }
        public void GetHistory()
        {

        }

    }
}
