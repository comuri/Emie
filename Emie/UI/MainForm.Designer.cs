namespace Emie.UI
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDoExport = new System.Windows.Forms.Button();
            this.buttonDoImport = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbOverrideExport = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbOverrideImport = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoveAllMacrosBeforeImport = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bRemoveAllMacros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxExcelFilePath = new System.Windows.Forms.TextBox();
            this.buttonBrowseExcelFilePath = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDoExport
            // 
            this.buttonDoExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDoExport.Location = new System.Drawing.Point(458, 63);
            this.buttonDoExport.Name = "buttonDoExport";
            this.buttonDoExport.Size = new System.Drawing.Size(75, 23);
            this.buttonDoExport.TabIndex = 1;
            this.buttonDoExport.Text = "実行";
            this.buttonDoExport.UseVisualStyleBackColor = true;
            this.buttonDoExport.Click += new System.EventHandler(this.buttonDoExport_Click);
            // 
            // buttonDoImport
            // 
            this.buttonDoImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDoImport.Location = new System.Drawing.Point(458, 63);
            this.buttonDoImport.Name = "buttonDoImport";
            this.buttonDoImport.Size = new System.Drawing.Size(75, 23);
            this.buttonDoImport.TabIndex = 2;
            this.buttonDoImport.Text = "実行";
            this.buttonDoImport.UseVisualStyleBackColor = true;
            this.buttonDoImport.Click += new System.EventHandler(this.buttonDoImport_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 120);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbOverrideExport);
            this.tabPage1.Controls.Add(this.buttonDoExport);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 94);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "マクロを抽出する";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbOverrideExport
            // 
            this.cbOverrideExport.AutoSize = true;
            this.cbOverrideExport.Location = new System.Drawing.Point(8, 6);
            this.cbOverrideExport.Name = "cbOverrideExport";
            this.cbOverrideExport.Size = new System.Drawing.Size(190, 16);
            this.cbOverrideExport.TabIndex = 0;
            this.cbOverrideExport.Text = "抽出先に存在していたら上書きする";
            this.cbOverrideExport.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbOverrideImport);
            this.tabPage2.Controls.Add(this.checkBoxRemoveAllMacrosBeforeImport);
            this.tabPage2.Controls.Add(this.buttonDoImport);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 94);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "マクロを取り込む";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbOverrideImport
            // 
            this.cbOverrideImport.AutoSize = true;
            this.cbOverrideImport.Location = new System.Drawing.Point(8, 28);
            this.cbOverrideImport.Name = "cbOverrideImport";
            this.cbOverrideImport.Size = new System.Drawing.Size(174, 16);
            this.cbOverrideImport.TabIndex = 1;
            this.cbOverrideImport.Text = "すでに存在していたら上書きする";
            this.cbOverrideImport.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemoveAllMacrosBeforeImport
            // 
            this.checkBoxRemoveAllMacrosBeforeImport.AutoSize = true;
            this.checkBoxRemoveAllMacrosBeforeImport.Location = new System.Drawing.Point(8, 6);
            this.checkBoxRemoveAllMacrosBeforeImport.Name = "checkBoxRemoveAllMacrosBeforeImport";
            this.checkBoxRemoveAllMacrosBeforeImport.Size = new System.Drawing.Size(196, 16);
            this.checkBoxRemoveAllMacrosBeforeImport.TabIndex = 0;
            this.checkBoxRemoveAllMacrosBeforeImport.Text = "取り込む前に全てのマクロを消去する";
            this.checkBoxRemoveAllMacrosBeforeImport.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bRemoveAllMacros);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(542, 94);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "おまけ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bRemoveAllMacros
            // 
            this.bRemoveAllMacros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRemoveAllMacros.Location = new System.Drawing.Point(375, 63);
            this.bRemoveAllMacros.Name = "bRemoveAllMacros";
            this.bRemoveAllMacros.Size = new System.Drawing.Size(158, 23);
            this.bRemoveAllMacros.TabIndex = 0;
            this.bRemoveAllMacros.Text = "マクロを全て削除する";
            this.bRemoveAllMacros.UseVisualStyleBackColor = true;
            this.bRemoveAllMacros.Click += new System.EventHandler(this.bRemoveAllMacros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxExcelFilePath);
            this.groupBox1.Controls.Add(this.buttonBrowseExcelFilePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "対象 Excel ファイルのパス";
            // 
            // textBoxExcelFilePath
            // 
            this.textBoxExcelFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExcelFilePath.Location = new System.Drawing.Point(6, 18);
            this.textBoxExcelFilePath.Name = "textBoxExcelFilePath";
            this.textBoxExcelFilePath.Size = new System.Drawing.Size(488, 19);
            this.textBoxExcelFilePath.TabIndex = 0;
            // 
            // buttonBrowseExcelFilePath
            // 
            this.buttonBrowseExcelFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseExcelFilePath.Location = new System.Drawing.Point(493, 17);
            this.buttonBrowseExcelFilePath.Name = "buttonBrowseExcelFilePath";
            this.buttonBrowseExcelFilePath.Size = new System.Drawing.Size(23, 21);
            this.buttonBrowseExcelFilePath.TabIndex = 1;
            this.buttonBrowseExcelFilePath.Text = "...";
            this.buttonBrowseExcelFilePath.UseVisualStyleBackColor = true;
            this.buttonBrowseExcelFilePath.Click += new System.EventHandler(this.buttonBrowseExcelFilePath_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 188);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Emie - Excel Macro Impoter Exporter";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDoExport;
        private System.Windows.Forms.Button buttonDoImport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bRemoveAllMacros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxExcelFilePath;
        private System.Windows.Forms.Button buttonBrowseExcelFilePath;
        private System.Windows.Forms.CheckBox cbOverrideExport;
        private System.Windows.Forms.CheckBox cbOverrideImport;
        private System.Windows.Forms.CheckBox checkBoxRemoveAllMacrosBeforeImport;
    }
}