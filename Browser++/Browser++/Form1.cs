using System.Diagnostics;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Browser__
{
    public partial class Form1 : Form
    {
        WebBrowser BrowserPlus = new WebBrowser();

        public Form1()
        {
            InitializeComponent();
            BrowserPlus.ScriptErrorsSuppressed = true;
            BrowserPlus.Navigate("www.google.com");

            BrowserPlus.Dock = DockStyle.Fill;
            panel2.Controls.Add(BrowserPlus);

            BrowserPlus.Navigated += BrowserPlus_Navigated;
            searchBar.KeyDown += searchBar_KeyDown;





            // forward and back buttons downloads and histtory

            backButton.FlatStyle = FlatStyle.Flat;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Text = "";

            forwardButton.FlatStyle = FlatStyle.Flat;
            forwardButton.FlatAppearance.BorderSize = 0;
            forwardButton.Text = "";

            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.Text = "";

            downloadsButton.FlatStyle = FlatStyle.Flat;
            downloadsButton.FlatAppearance.BorderSize = 0;
            downloadsButton.Text = "";

            historyButton.FlatStyle = FlatStyle.Flat;
            historyButton.FlatAppearance.BorderSize = 0;
            historyButton.Text = "";

            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.Text = "";

            // label for current page



        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {


        }

        private void BrowserPlus_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            currentPageLabel.Text = BrowserPlus.Url?.ToString() ?? "No page loaded";
            string currentPageName = currentPageLabel.Text;
            GlobalData.BrowsingHistory.Add((currentPageName, currentTime));

        }

        private void searchBar_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BrowserPlus.Navigate(searchBar.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(800, 500);
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BrowserPlus.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            BrowserPlus.GoForward();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            BrowserPlus.Refresh();
        }

        private void currentPageLabel_Click(object sender, EventArgs e)
        {

        }

        private void downloadsButton_Click(object sender, EventArgs e)
        {
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

           
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = downloadsPath,
                FileName = "explorer.exe"
            };
            Process.Start(startInfo);
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            Form3 form3= new Form3();
            form3.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void Form3_NavigateRequested(object sender, string url)
        {
            BrowserPlus.Navigate(url);
        }
    }
    public static class GlobalData
    {
        public static List<(string, DateTime)> BrowsingHistory { get; set; } = new List<(string, DateTime)>();
    }
}