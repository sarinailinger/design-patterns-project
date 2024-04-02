﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class Folder:FileSystem
    {
        public List<FileSystem> item { get; set; }
        public Folder(string Name, float Size) : base(Name, Size)
        {
            item = new List<FileSystem>();
        }
    }
}
