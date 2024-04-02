using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Momento
{
    internal class FileSystemCareTaker
    {
        public Stack<FileSystemMoMento> history { get; set; }
        public FileSystemCareTaker()
        {
            history = new Stack<FileSystemMoMento>();
        }
        //public FileSystemCareTaker(FileSystemMoMento fileSystemMoMento)
        //{
        //    this.history = new Stack<FileSystemMoMento>();
        //}
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
            //List<FileSystemMoMento> list = new List<FileSystemMoMento>();
            //Stack<FileSystemMoMento> stack = new Stack<FileSystemMoMento>();
            //while (history.Count != 0)
            //{
            //    var x = history.Pop();
            //    list.Add(x);
            //    stack.Push(x);
            //}
            //while (stack.Count != 0)
            //{
            //    history.Push(stack.Pop());
            //}
            //return list;
            Stack<FileSystemMoMento> stack = new Stack<FileSystemMoMento>();
            Console.WriteLine("The history:");
            while (history.Count != 0)
            {
                var x = history.Pop();
                stack.Push(x);
                Console.WriteLine(x.GetContent());
            }
            while (stack.Count != 0)
            {
                history.Push(stack.Pop());
            }
        }
    }
}
