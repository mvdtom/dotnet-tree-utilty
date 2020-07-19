using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TreeUtility
{
    public struct Node
    {
        public Node(string path)
        {
            Path = path;
            Name = System.IO.Path.GetFileName(path);
        }

        public string Path { get; }
        public string Name { get; }

    }
}
