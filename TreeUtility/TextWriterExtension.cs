using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TreeUtility
{
    public static class TextWriterExtension
    {
        public static void WriteLine(this TextWriter output, TreeNode<Node> currentNode, Stack<string> tabScheme, bool last)
        {
            foreach (var tab in tabScheme.Reverse())
            {
                output.Write(tab);
            }

            output.Write(last ? "└───" : "├───");
            output.Write(currentNode.Data.Name);
            output.Write("\r\n");
        }
    }
}
