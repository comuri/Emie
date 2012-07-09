using System;
using Excel = XlsOp.Excel;
using VB = XlsOp.VBIDE;

namespace Emie.Commands
{
    internal class RemoveMacros : CommandBase
    {
        public RemoveMacros(ILogger logger)
            : base(logger)
        {
        }

        public override void invoke(Excel.IWorkbook workbook)
        {
            using (VB.IVBProject vbProject = workbook.VBProject)
            using (VB.IVBComponents vbComponents = vbProject.VBComponents) {
                foreach (VB.IVBComponent vbComponent in vbComponents) {
                    info("マクロを削除します: {0}", vbComponent.Name);
                    using (vbComponent) {
                        if (vbComponent.Type == VB.ComponentType.Document) {
                            using (VB.ICodeModule vbCodeModule = vbComponent.CodeModule) {
                                vbCodeModule.DeleteLines(1, vbCodeModule.CountOfLines);
                            }
                        }
                        else
                            vbComponents.Remove(vbComponent);
                    }
                }
            }
        }
    }
}
