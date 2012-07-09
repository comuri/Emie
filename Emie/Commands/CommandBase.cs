using System;
using System.Collections.Generic;
using System.Text;
using Excel = XlsOp.Excel;
using VB = XlsOp.VBIDE;

namespace Emie.Commands
{
    internal abstract class CommandBase : ICommand
    {
        public CommandBase(ILogger logger)
        {
            this.logger = logger;
        }

        protected void info(string message, params string[] args)
        {
            if (this.logger != null)
                this.logger.info(message, args);
        }

        protected void warn(string message, params string[] args)
        {
            if (this.logger != null)
                this.logger.warn(message, args);
        }

        protected void error(string message, params string[] args)
        {
            if (this.logger != null)
                this.logger.error(message, args);
        }

        public abstract void invoke(Excel.IWorkbook workbook);
        private ILogger logger;
    }
}
