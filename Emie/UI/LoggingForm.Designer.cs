namespace Emie.UI
{
    partial class LoggingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggingForm));
            this.ilMessageIcons = new System.Windows.Forms.ImageList(this.components);
            this.lvLoggingMessage = new System.Windows.Forms.ListView();
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ilMessageIcons
            // 
            this.ilMessageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMessageIcons.ImageStream")));
            this.ilMessageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMessageIcons.Images.SetKeyName(0, "Information.png");
            this.ilMessageIcons.Images.SetKeyName(1, "warning.png");
            this.ilMessageIcons.Images.SetKeyName(2, "error.png");
            // 
            // lvLoggingMessage
            // 
            this.lvLoggingMessage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chType,
            this.chTimestamp,
            this.chMessage});
            this.lvLoggingMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLoggingMessage.FullRowSelect = true;
            this.lvLoggingMessage.GridLines = true;
            this.lvLoggingMessage.Location = new System.Drawing.Point(0, 0);
            this.lvLoggingMessage.Name = "lvLoggingMessage";
            this.lvLoggingMessage.Size = new System.Drawing.Size(646, 231);
            this.lvLoggingMessage.SmallImageList = this.ilMessageIcons;
            this.lvLoggingMessage.TabIndex = 0;
            this.lvLoggingMessage.UseCompatibleStateImageBehavior = false;
            this.lvLoggingMessage.View = System.Windows.Forms.View.Details;
            // 
            // chType
            // 
            this.chType.Text = "";
            this.chType.Width = 24;
            // 
            // chTimestamp
            // 
            this.chTimestamp.Text = "時刻";
            this.chTimestamp.Width = 129;
            // 
            // chMessage
            // 
            this.chMessage.Text = "メッセージ";
            this.chMessage.Width = 452;
            // 
            // LoggingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 231);
            this.Controls.Add(this.lvLoggingMessage);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoggingForm";
            this.Text = "実行ログ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilMessageIcons;
        private System.Windows.Forms.ListView lvLoggingMessage;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chTimestamp;
        private System.Windows.Forms.ColumnHeader chMessage;
    }
}