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
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowStream = new System.Windows.Forms.Button();
            this.ChannelName = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ConnectedStream = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.leftbutton = new System.Windows.Forms.Button();
            this.rightbutton = new System.Windows.Forms.Button();
            this.stats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedStream)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(558, 12);
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
            this.label1.Location = new System.Drawing.Point(385, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(426, 17);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "label2";
            // 
            // StreamList
            // 
            this.StreamList.CheckBoxes = true;
            this.StreamList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.GameColumn,
            this.ViewerColumn});
            this.StreamList.FullRowSelect = true;
            this.StreamList.Location = new System.Drawing.Point(79, 77);
            this.StreamList.Name = "StreamList";
            this.StreamList.Size = new System.Drawing.Size(264, 325);
            this.StreamList.TabIndex = 3;
            this.StreamList.UseCompatibleStateImageBehavior = false;
            this.StreamList.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 100;
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
            // ChannelName
            // 
            this.ChannelName.Location = new System.Drawing.Point(79, 417);
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.Size = new System.Drawing.Size(172, 20);
            this.ChannelName.TabIndex = 5;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(268, 415);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectedStream
            // 
            this.ConnectedStream.AllowUserToAddRows = false;
            this.ConnectedStream.AllowUserToDeleteRows = false;
            this.ConnectedStream.AllowUserToResizeColumns = false;
            this.ConnectedStream.AllowUserToResizeRows = false;
            this.ConnectedStream.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ConnectedStream.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectedStream.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2});
            this.ConnectedStream.Location = new System.Drawing.Point(389, 77);
            this.ConnectedStream.Name = "ConnectedStream";
            this.ConnectedStream.ReadOnly = true;
            this.ConnectedStream.Size = new System.Drawing.Size(284, 325);
            this.ConnectedStream.TabIndex = 8;
            this.ConnectedStream.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConnectedStream_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Chat";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Remove";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // leftbutton
            // 
            this.leftbutton.Location = new System.Drawing.Point(207, 48);
            this.leftbutton.Name = "leftbutton";
            this.leftbutton.Size = new System.Drawing.Size(44, 23);
            this.leftbutton.TabIndex = 9;
            this.leftbutton.Text = "<<";
            this.leftbutton.UseVisualStyleBackColor = true;
            this.leftbutton.Click += new System.EventHandler(this.leftbutton_Click);
            // 
            // rightbutton
            // 
            this.rightbutton.Location = new System.Drawing.Point(257, 48);
            this.rightbutton.Name = "rightbutton";
            this.rightbutton.Size = new System.Drawing.Size(44, 23);
            this.rightbutton.TabIndex = 10;
            this.rightbutton.Text = ">>";
            this.rightbutton.UseVisualStyleBackColor = true;
            this.rightbutton.Click += new System.EventHandler(this.rightbutton_Click);
            // 
            // stats
            // 
            this.stats.Location = new System.Drawing.Point(558, 48);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(75, 23);
            this.stats.TabIndex = 11;
            this.stats.Text = "Stats";
            this.stats.UseVisualStyleBackColor = true;
            this.stats.Click += new System.EventHandler(this.stats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 504);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.rightbutton);
            this.Controls.Add(this.leftbutton);
            this.Controls.Add(this.ConnectedStream);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ChannelName);
            this.Controls.Add(this.ShowStream);
            this.Controls.Add(this.StreamList);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedStream)).EndInit();
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
        private System.Windows.Forms.TextBox ChannelName;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.DataGridView ConnectedStream;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Button leftbutton;
        private System.Windows.Forms.Button rightbutton;
        private System.Windows.Forms.Button stats;
    }
}

