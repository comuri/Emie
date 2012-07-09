using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Emie.Commands;

namespace Emie.UI
{
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonBrowseExcelFilePath_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel ワークシート (*.xls)|*.xls";
            dialog.FileName = textBoxExcelFilePath.Text;

            if (dialog.ShowDialog(this) == DialogResult.OK) {
                textBoxExcelFilePath.Text = dialog.FileName;
            }
        }

        private void buttonDoExport_Click(object sender, EventArgs e)
        {
            LoggingForm logger = new LoggingForm();
            logger.Show(this);

            string excelFilePath = textBoxExcelFilePath.Text;
            string codeFolderPath = GetMacroFolderPath(true);

            MacroEnv env = new MacroEnv(codeFolderPath);

            ExcelOperator access = new ExcelOperator();
            access.AddCommand(new ExportMacros(logger, env, cbOverrideExport.Checked));
            //access.AddCommand(new RemoveMacros(null));
            access.invoke(excelFilePath, false);
        }

        private void buttonDoImport_Click(object sender, EventArgs e)
        {
            LoggingForm logger = new LoggingForm();
            logger.Show(this);

            string excelFilePath = textBoxExcelFilePath.Text;
            string codeFolderPath = GetMacroFolderPath(false);

            MacroEnv env = new MacroEnv(codeFolderPath);

            ExcelOperator access = new ExcelOperator();
            if (checkBoxRemoveAllMacrosBeforeImport.Checked)
                access.AddCommand(new RemoveMacros(logger));
            access.AddCommand(new ImportMacros(logger, env, cbOverrideImport.Checked));
            access.invoke(excelFilePath, true);
        }

        private void bRemoveAllMacros_Click(object sender, EventArgs e)
        {
            LoggingForm logger = new LoggingForm();
            logger.Show(this);

            string excelFilePath = textBoxExcelFilePath.Text;

            ExcelOperator access = new ExcelOperator();
            access.AddCommand(new RemoveMacros(logger));
            access.invoke(excelFilePath, true);
        }

        private string GetMacroFolderPath(bool isExport)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = isExport;
            dialog.SelectedPath = Path.GetDirectoryName(textBoxExcelFilePath.Text);

            if (dialog.ShowDialog(this) == DialogResult.OK)
                return dialog.SelectedPath;
            else
                return null;
        }
    }
}
