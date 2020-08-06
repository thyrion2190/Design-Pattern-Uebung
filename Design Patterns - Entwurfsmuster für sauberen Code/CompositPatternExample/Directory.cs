using System;
using System.Collections.Generic;
using System.Text;

namespace CompositPatternExample
{
    public class Directory : FileSystemComponent
    {
        private List<FileSystemComponent> includedFiles = new List<FileSystemComponent>();

        public Directory(string name)
        {
            this.Name = name;
        }

        public void Add(FileSystemComponent component)
        {
            includedFiles.Add(component);
        }

        public void Remove(FileSystemComponent component)
        {
            includedFiles.Remove(component);
        }

        public FileSystemComponent GetFileSystemComponent(int index)
        {
            return includedFiles[index];
        }

        public override void Print(string spacing)
        {
            Console.WriteLine(spacing + "Directoryname: " + Name);
            foreach (FileSystemComponent component in includedFiles)
            {
                component.Print(spacing + "     ");
            }
        }
    }
}
