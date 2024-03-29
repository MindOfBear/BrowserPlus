namespace Browser__
{
    partial class Form2
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
            SettingsTitle = new Label();
            downloadToLabel = new Label();
            downloadsPathFolder = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // SettingsTitle
            // 
            SettingsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SettingsTitle.AutoSize = true;
            SettingsTitle.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SettingsTitle.Location = new Point(97, 9);
            SettingsTitle.Name = "SettingsTitle";
            SettingsTitle.RightToLeft = RightToLeft.No;
            SettingsTitle.Size = new Size(97, 30);
            SettingsTitle.TabIndex = 0;
            SettingsTitle.Text = "Settings";
            SettingsTitle.TextAlign = ContentAlignment.TopCenter;
            SettingsTitle.Click += SettingsTitle_Click;
            // 
            // downloadToLabel
            // 
            downloadToLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            downloadToLabel.AutoSize = true;
            downloadToLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            downloadToLabel.Location = new Point(80, 48);
            downloadToLabel.Name = "downloadToLabel";
            downloadToLabel.Size = new Size(124, 16);
            downloadToLabel.TabIndex = 1;
            downloadToLabel.Text = "Download Files To";
            // 
            // downloadsPathFolder
            // 
            downloadsPathFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            downloadsPathFolder.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            downloadsPathFolder.Location = new Point(80, 64);
            downloadsPathFolder.Name = "downloadsPathFolder";
            downloadsPathFolder.Size = new Size(124, 101);
            downloadsPathFolder.TabIndex = 2;
            downloadsPathFolder.Text = "path";
            downloadsPathFolder.TextAlign = ContentAlignment.TopCenter;
            downloadsPathFolder.Click += downloadsPathFolder_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 165);
            label1.Name = "label1";
            label1.Size = new Size(158, 16);
            label1.TabIndex = 4;
            label1.Text = "Delete Browsing History";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackgroundImage = Properties.Resources.trash_can_115312;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(125, 184);
            button1.Name = "button1";
            button1.Size = new Size(31, 32);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(284, 261);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(downloadsPathFolder);
            Controls.Add(downloadToLabel);
            Controls.Add(SettingsTitle);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SettingsTitle;
        private Label downloadToLabel;
        private Label downloadsPathFolder;
        private Button editDownloadPath;
        private Label label1;
        private Button button1;
    }
}