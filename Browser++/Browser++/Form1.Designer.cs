namespace Browser__
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            settingsButton = new Button();
            downloadsButton = new Button();
            backButton = new Button();
            historyButton = new Button();
            searchBar = new TextBox();
            refreshButton = new Button();
            forwardButton = new Button();
            panel2 = new Panel();
            currentPageLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(settingsButton);
            panel1.Controls.Add(downloadsButton);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(historyButton);
            panel1.Controls.Add(searchBar);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(forwardButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 39);
            panel1.TabIndex = 0;
            // 
            // settingsButton
            // 
            settingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            settingsButton.BackgroundImage = Properties.Resources.settingsbutton_99706;
            settingsButton.BackgroundImageLayout = ImageLayout.Stretch;
            settingsButton.Location = new Point(762, 3);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(35, 32);
            settingsButton.TabIndex = 6;
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // downloadsButton
            // 
            downloadsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            downloadsButton.BackgroundImage = Properties.Resources.arrow_down_download_downloading_file_save_icon_123800;
            downloadsButton.BackgroundImageLayout = ImageLayout.Stretch;
            downloadsButton.Location = new Point(729, 7);
            downloadsButton.Name = "downloadsButton";
            downloadsButton.Size = new Size(27, 24);
            downloadsButton.TabIndex = 4;
            downloadsButton.UseVisualStyleBackColor = true;
            downloadsButton.Click += downloadsButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.BackgroundImage = Properties.Resources.arrow_back_circle_icon_235227;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.Location = new Point(13, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(31, 31);
            backButton.TabIndex = 0;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // historyButton
            // 
            historyButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            historyButton.BackgroundImage = Properties.Resources.user_interface_web_ui_history_icon_221222;
            historyButton.BackgroundImageLayout = ImageLayout.Stretch;
            historyButton.Location = new Point(660, 8);
            historyButton.Name = "historyButton";
            historyButton.Size = new Size(23, 23);
            historyButton.TabIndex = 5;
            historyButton.UseVisualStyleBackColor = true;
            historyButton.Click += historyButton_Click;
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBar.ImeMode = ImeMode.NoControl;
            searchBar.Location = new Point(133, 8);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(521, 23);
            searchBar.TabIndex = 3;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // refreshButton
            // 
            refreshButton.BackgroundImage = Properties.Resources.refreshpagebutton_99726;
            refreshButton.BackgroundImageLayout = ImageLayout.Stretch;
            refreshButton.Location = new Point(99, 6);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(28, 28);
            refreshButton.TabIndex = 2;
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // forwardButton
            // 
            forwardButton.BackgroundImage = Properties.Resources.arrow_forward_circle_icon_235223__1_;
            forwardButton.BackgroundImageLayout = ImageLayout.Stretch;
            forwardButton.Location = new Point(50, 5);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(31, 31);
            forwardButton.TabIndex = 1;
            forwardButton.UseVisualStyleBackColor = true;
            forwardButton.Click += forwardButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.ForeColor = Color.FromArgb(44, 44, 44);
            panel2.Location = new Point(-1, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 393);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // currentPageLabel
            // 
            currentPageLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            currentPageLabel.AutoSize = true;
            currentPageLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            currentPageLabel.Location = new Point(-1, 437);
            currentPageLabel.Name = "currentPageLabel";
            currentPageLabel.Size = new Size(38, 13);
            currentPageLabel.TabIndex = 2;
            currentPageLabel.Text = "label1";
            currentPageLabel.Click += currentPageLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(currentPageLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Broswer </>";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button backButton;
        private Panel panel2;
        private Button historyButton;
        private Button downloadsButton;
        private TextBox searchBar;
        private Button refreshButton;
        private Button forwardButton;
        private Label currentPageLabel;
        private Button settingsButton;
    }
}