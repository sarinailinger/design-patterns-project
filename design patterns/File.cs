﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class File : FileSystem
    {

        public File(string name, float size, Repository repository) : base(name, size, repository)
        {

        }

    }
}
