using System;
using System.Collections.Generic;
using System.Text;

namespace Emie
{
    internal class MacroEnv
    {
        public MacroEnv(string path)
        {
            this.path = path;
        }

        public string Path { get { return this.path; } }

        public string MakeDocumentPath(string name)
        {
            return MakePath(name, ".txt");
        }

        public string MakeModulePath(string name)
        {
            return MakePath(name, ".bas");
        }

        public string MakeClassPath(string name)
        {
            return MakePath(name, ".cls");
        }

        public string MakeFormPath(string name)
        {
            return MakePath(name, ".frm");
        }

        private string MakePath(string name, string ext)
        {
            return System.IO.Path.Combine(this.Path, name + ext);
        }

        public string[] GetDocuments()
        {
            return GetFiles("*.txt");
        }

        public string[] GetModules()
        {
            return GetFiles("*.bas");
        }

        public string[] GetClasses()
        {
            return GetFiles("*.cls");
        }

        public string[] GetForms()
        {
            return GetFiles("*.frm");
        }

        private string[] GetFiles(string pattern)
        {
            return System.IO.Directory.GetFiles(this.Path, pattern);
        }

        private string path;
    }
}
