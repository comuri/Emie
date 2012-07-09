using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Emie.UI
{
    internal partial class LoggingForm : Form, ILogger
    {
        public LoggingForm()
        {
            InitializeComponent();
        }

        void ILogger.info(string message, params string[] args)
        {
            log(LoggingType.INFO, message, args);
        }

        void ILogger.warn(string message, params string[] args)
        {
            log(LoggingType.WARN, message, args);
        }

        void ILogger.error(string message, params string[] args)
        {
            log(LoggingType.ERROR, message, args);
        }

        private void log(LoggingType type, string message, params string[] args)
        {
            int imageIndex = 0;
            switch (type) {
                case LoggingType.INFO:
                    imageIndex = 0;
                    break;
                case LoggingType.WARN:
                    imageIndex = 1;
                    break;
                case LoggingType.ERROR:
                    imageIndex = 2;
                    break;
            }

            lvLoggingMessage.Items.Add(new ListViewItem(new string[] {
                "", 
                DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                string.Format(message, args)
            }, imageIndex));
            lvLoggingMessage.Invalidate();
        }
    }
}
