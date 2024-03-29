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
    public partial class Form3 : Form
    {
        public event EventHandler<string> NavigateRequested;
        public Form3()
        {
            InitializeComponent();
            this.MinimumSize = new Size(900, 600);
            this.MaximumSize = new Size(900, 600);

            List<(string, DateTime)> browsingHistory = GlobalData.BrowsingHistory;


            foreach ((string url, DateTime timeStamp) in browsingHistory)
            {
                string formattedDateTime = timeStamp.ToString("yyyy-MM-dd HH:mm:ss");

                Label urlLabel = new Label();
                urlLabel.Text = url;
                urlLabel.Font = new Font("Arial", 10, FontStyle.Bold);
                urlLabel.ForeColor = Color.Blue;
                urlLabel.AutoSize = true;
                urlLabel.Enabled = true;
                urlLabel.Click += UrlLabel_Click;

                Label timeLabel = new Label();
                timeLabel.Text = formattedDateTime;
                timeLabel.Font = new Font("Arial", 10, FontStyle.Italic);
                timeLabel.ForeColor = Color.AliceBlue;
                timeLabel.AutoSize = true;

                int rowIndex = tableLayoutPanel1.RowCount++; 
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                
                tableLayoutPanel1.Controls.Add(urlLabel, 0, rowIndex);
                tableLayoutPanel1.Controls.Add(timeLabel, 1, rowIndex);
            }
            

        }

        private void UrlLabel_Click(object? sender, EventArgs e)
        {
            NavigateRequested?.Invoke(this, this.Text);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
