namespace ChatSaver
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            this.SettingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StreamList = new System.Windows.Forms.ListView();
            this.ShowStream = new System.Windows.Forms.Button();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(634, 17);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(115, 23);
            this.SettingButton.TabIndex = 0;
            this.SettingButton.Text = "User Settings";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(502, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "label2";
            // 
            // StreamList
            // 
            this.StreamList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.GameColumn,
            this.ViewerColumn});
            this.StreamList.Location = new System.Drawing.Point(79, 77);
            this.StreamList.Name = "StreamList";
            this.StreamList.Size = new System.Drawing.Size(338, 325);
            this.StreamList.TabIndex = 3;
            this.StreamList.UseCompatibleStateImageBehavior = false;
            this.StreamList.View = System.Windows.Forms.View.Details;
            // 
            // ShowStream
            // 
            this.ShowStream.Location = new System.Drawing.Point(79, 48);
            this.ShowStream.Name = "ShowStream";
            this.ShowStream.Size = new System.Drawing.Size(122, 23);
            this.ShowStream.TabIndex = 4;
            this.ShowStream.Text = "Show Streams";
            this.ShowStream.UseVisualStyleBackColor = true;
            this.ShowStream.Click += new System.EventHandler(this.ShowStream_Click);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 80;
            // 
            // GameColumn
            // 
            this.GameColumn.Text = "Game";
            this.GameColumn.Width = 100;
            // 
            // ViewerColumn
            // 
            this.ViewerColumn.Text = "Viewers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowStream);
            this.Controls.Add(this.StreamList);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListView StreamList;
        private System.Windows.Forms.Button ShowStream;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader GameColumn;
        private System.Windows.Forms.ColumnHeader ViewerColumn;
    }
}

