﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.States
{
    internal class Staged : FileSystemState
    {
        public Staged(FileSystem fileSystem) : base(fileSystem)
        {
        }

        public override void AddFiles(FileSystem item)
        {
            throw new NotImplementedException();
        }

        public override void Commit(string strCommit)
        {
            throw new NotImplementedException();
        }

        public override void Merge(FileSystem item)
        {
            throw new NotImplementedException();
        }

        public override void RequestAReview(FileSystem item)
        {
            throw new NotImplementedException();
        }

        public override void UndoTheCommit(string strCommit)
        {
            throw new NotImplementedException();
        }
    }
}
