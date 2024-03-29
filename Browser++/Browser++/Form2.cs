using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser__
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MinimumSize = new Size(300, 300);
            this.MaximumSize = new Size(300, 300);


            // buttons

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Text = "";

            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

            downloadsPathFolder.Text = downloadsPath;

        }

        private void SettingsTitle_Click(object sender, EventArgs e)
        {

        }

        private void downloadsPathFolder_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<(string, DateTime)> browsingHistory = GlobalData.BrowsingHistory;
            browsingHistory.Clear();
        }
    }
}
