using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Excel = XlsOp.Excel;
using VB = XlsOp.VBIDE;

namespace Emie.Commands
{
    internal class ImportMacros : CommandBase
    {
        public ImportMacros(ILogger logger, MacroEnv env, bool doOverride)
            : base(logger)
        {
            this.env = env;
            this.doOverride = doOverride;
        }

        public override void invoke(Excel.IWorkbook workbook)
        {
            using (VB.IVBProject vbProject = workbook.VBProject)
            using (VB.IVBComponents vbComponents = vbProject.VBComponents) {
                List<VB.IVBComponent> componentList = new List<VB.IVBComponent>(vbComponents);
                try {
                    foreach (string path in env.GetDocuments()) {
                        string name = Path.GetFileNameWithoutExtension(path);
                        VB.IVBComponent component = FindComponentByNameAndType(componentList, name, VB.ComponentType.Document);
                        if (component != null) {
                            using (VB.ICodeModule vbCodeModule = component.CodeModule) {
                                bool doImport = true;
                                if (vbCodeModule.CountOfLines > 0) {
                                    if (doOverride)
                                        vbCodeModule.DeleteLines(1, vbCodeModule.CountOfLines);
                                    else
                                        doImport = false;
                                }
                                if (doImport) {
                                    info("モジュールをインポートします");
                                    int index = 1;
                                    using (StreamReader reader = new StreamReader(path, Encoding.GetEncoding("shift_jis"))) {
                                        string line = null;
                                        while ((line = reader.ReadLine()) != null) {
                                            component.CodeModule.InsertLines(index++, line);
                                        }
                                    }
                                }
                            }
                        }
                        else {
                            warn("シートがないためスキップします：{0}", name);
                        }
                    }
                    foreach (string path in env.GetModules()) {
                        string name = Path.GetFileNameWithoutExtension(path);
                        VB.IVBComponent component = FindComponentByNameAndType(componentList, name, VB.ComponentType.StdModule);
                        bool doImport = true;
                        if (component != null) {
                            if (doOverride) {
                                vbComponents.Remove(component);
                                componentList.Remove(component);
                            }
                            else
                                doImport = false;
                        }
                        if (doImport) {
                            info("標準モジュールをインポートします：{0}", name);
                            vbComponents.Import(path);
                        }
                    }
                    foreach (string path in env.GetClasses()) {
                        string name = Path.GetFileNameWithoutExtension(path);
                        VB.IVBComponent component = FindComponentByNameAndType(componentList, name, VB.ComponentType.ClassModule);
                        bool doImport = true;
                        if (component != null) {
                            if (doOverride) {
                                vbComponents.Remove(component);
                                componentList.Remove(component);
                            }
                            else
                                doImport = false;
                        }
                        if (doImport) {
                            info("クラスモジュールをインポートします：{0}", name);
                            vbComponents.Import(path);
                        }
                    }
                    foreach (string path in env.GetForms()) {
                        string name = Path.GetFileNameWithoutExtension(path);
                        VB.IVBComponent component = FindComponentByNameAndType(componentList, name, VB.ComponentType.MSForm);
                        bool doImport = true;
                        if (component != null) {
                            if (doOverride) {
                                vbComponents.Remove(component);
                                componentList.Remove(component);
                            }
                            else
                                doImport = false;
                        }
                        if (doImport) {
                            info("ユーザーフォームをインポートします：{0}", name);
                            vbComponents.Import(path);
                        }
                    }
                }
                finally {
                    foreach (VB.IVBComponent vbComponent in componentList) {
                        vbComponent.Dispose();
                    }
                }
            }
        }

        private static VB.IVBComponent FindComponentByNameAndType(IEnumerable<VB.IVBComponent> componentList, string name, VB.ComponentType type)
        {
            VB.IVBComponent foundComponent = null;
            foreach (VB.IVBComponent vbComponent in componentList) {
                if (vbComponent.Name == name && vbComponent.Type == type) {
                    foundComponent = vbComponent;
                }
            }
            return foundComponent;
        }

        private MacroEnv env;
        private bool doOverride;
    }
}
