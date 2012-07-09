using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Excel = XlsOp.Excel;
using VB = XlsOp.VBIDE;

namespace Emie.Commands
{
    internal class ExportMacros : CommandBase
    {
        public ExportMacros(ILogger logger, MacroEnv env, bool doOverride)
            : base(logger)
        {
            this.env = env;
            this.doOverride = doOverride;
        }

        public override void invoke(Excel.IWorkbook workbook)
        {
            using (VB.IVBProject vbProject = workbook.VBProject)
            using (VB.IVBComponents vbComponents = vbProject.VBComponents) {
                foreach (VB.IVBComponent vbComponent in vbComponents) {
                    using (vbComponent) {
                        string codepath = null;
                        switch (vbComponent.Type) {
                            case VB.ComponentType.Document:
                                info("埋め込みコードをエクスポートします: {0}", vbComponent.Name);
                                codepath = env.MakeDocumentPath(vbComponent.Name);
                                break;
                            case VB.ComponentType.StdModule:
                                info("標準モジュールをエクスポートします: {0}", vbComponent.Name);
                                codepath = env.MakeModulePath(vbComponent.Name);
                                break;
                            case VB.ComponentType.ClassModule:
                                info("クラスモジュールをエクスポートします: {0}", vbComponent.Name);
                                codepath = env.MakeClassPath(vbComponent.Name);
                                break;
                            case VB.ComponentType.MSForm:
                                info("ユーザーフォームをエクスポートします: {0}", vbComponent.Name);
                                codepath = env.MakeFormPath(vbComponent.Name);
                                break;
                        }

                        bool doExport = false;
                        if (File.Exists(codepath)) {
                            if (doOverride) {
                                try {
                                    warn("  すでにファイルが存在するため削除します");
                                    File.Delete(codepath);
                                    doExport = true;
                                }
                                catch (IOException e) {
                                    error(e.Message);
                                }
                            }
                            else
                                warn("  すでにファイルが存在するため無視します");
                        }
                        else
                            doExport = true;

                        if (doExport) {
                            switch (vbComponent.Type) {
                                case VB.ComponentType.Document:
                                    using (VB.ICodeModule codeModule = vbComponent.CodeModule) {
                                        if (codeModule.CountOfLines > 0) {
                                            using (StreamWriter writer = new StreamWriter(codepath, false, Encoding.GetEncoding("shift_jis"))) {
                                                for (int i = 1, n = codeModule.CountOfLines; i <= n; i++)
                                                    writer.WriteLine(codeModule.Lines[i, 1]);
                                            }
                                            info("  エクスポートしました: {0}", codepath);
                                        }
                                        else
                                            info("  空のため無視されました");
                                    }
                                    break;
                                case VB.ComponentType.StdModule:
                                    vbComponent.Export(codepath);
                                    info("  エクスポートしました: {0}", codepath);
                                    break;
                                case VB.ComponentType.ClassModule:
                                    vbComponent.Export(codepath);
                                    info("  エクスポートしました: {0}", codepath);
                                    break;
                                case VB.ComponentType.MSForm:
                                    vbComponent.Export(codepath);
                                    info("  エクスポートしました: {0}", codepath);
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private MacroEnv env;
        private bool doOverride;
    }
}
