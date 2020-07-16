﻿using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;

namespace TreeUtility
{
    public class TreeBuilder
    {
        private readonly TextWriter _output;

        public TreeBuilder(TextWriter output)
        {
            _output = output;
        }

        public void Build(string path, bool printFiles)
        {
            //put your solution here
            //_output.Write(...);
            TreeNode<String> root = new TreeNode<String>(path);
            DirSearch(path, root, printFiles);
            FormattedOutput(_output, root);
        }

        void DirSearch(string directory, TreeNode<string> node, bool includeFiles)
        {
            try
            {
                if (includeFiles)
                {
                    foreach (string filePath in Directory.GetFiles(directory))
                    {
                        node.AddChild(Path.GetFileName(filePath));
                    }
                }
                foreach (string dirPath in Directory.GetDirectories(directory))
                {
                    var childNode = node.AddChild(Path.GetFileName(dirPath));
                    DirSearch(dirPath, childNode, includeFiles);
                }
            }
            catch (System.Exception ex)
            {
                _output.WriteLine(ex.Message);
            }
        }

        void FormattedOutput(TextWriter output, TreeNode<String> node, int tabLevel = 0)
        {
            
            var sortedChildren = node.Children.OrderBy(child => child.Data).ToArray();
            
            for ( int i = 0; i < sortedChildren.Length; ++i)
            {
                if (i == sortedChildren.Length - 1)
                {
                    output.Write(Tabs(tabLevel, true));
                }
                else
                {
                    output.Write(Tabs(tabLevel, false));
                }
                
                output.Write(sortedChildren[i].Data);
                output.Write("\r\n");
                ++tabLevel;
                FormattedOutput(output, sortedChildren[i], tabLevel);
                --tabLevel;
            }
        }

        string Tabs(int n, bool last)
        {
            String level;

            if (last)
                level = String.Concat(Enumerable.Repeat("\t", n)) + "└───";
            else
                level = String.Concat(Enumerable.Repeat("│\t", n)) + "├───";

            return level;
        }

    }
}