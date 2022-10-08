using System.Runtime.CompilerServices;

namespace ConnectorComm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = Icon;
            // Read settings.
            numIntV.Value = Properties.Settings.Default.vIntervalMin;
            numIntP.Value = Properties.Settings.Default.pIntervalHour;
            txtLinkV.Text = Properties.Settings.Default.vLink;
            txtLinkP.Text = Properties.Settings.Default.pLink;
            if (Properties.Settings.Default.vFolder != String.Empty)
            {
                brwV.Text = Properties.Settings.Default.vFolder;
            }
            if (Properties.Settings.Default.pFolder != String.Empty)
            {
                brwP.Text = Properties.Settings.Default.pFolder;
            }
        }

        /**
         * Save settings.
         */
        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.vIntervalMin = (int) numIntV.Value;
            Properties.Settings.Default.pIntervalHour = (int) numIntP.Value;
            if (this.isValidUrl(txtLinkV.Text) || txtLinkV.Text == String.Empty)
            {
                Properties.Settings.Default.vLink = txtLinkV.Text;
            }
            else
            {
                MessageBox.Show("Adresa URL invalida: " + txtLinkV.Text);
            }
            if (this.isValidUrl(txtLinkP.Text) || txtLinkP.Text == String.Empty)
            {
                Properties.Settings.Default.vLink = txtLinkP.Text;
            }
            else
            {
                MessageBox.Show("Adresa URL invalida: " + txtLinkP.Text);
            }

            Properties.Settings.Default.pLink = txtLinkP.Text;
            Properties.Settings.Default.vFolder = brwV.Text;
            Properties.Settings.Default.pFolder = brwP.Text;
            Properties.Settings.Default.Save();
        }

        private bool isValidUrl(string url)
        {
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        private void brwV_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                brwV.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void brwP_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                brwP.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void sincronizarevanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newPkuld = Properties.Settings.Default.vFolder + @"/pkuld.0001";
            using (FileStream fs = File.Create(newPkuld));
            using StreamWriter filePkuld = new(newPkuld, append: true);
            await filePkuld.WriteLineAsync("2032-00");
            /*autoTimer.Enabled = true;
            if (autoTimer.Tick)
            {
                if (!isPkapCorrect())
                {
                    File.Delete(Properties.Settings.Default.vFolder + @"/pkap.0001");
                }
            }*/   

        }

        private bool isPkapCorrect()
        {
            string content = File.ReadAllText(Properties.Settings.Default.vFolder + @"/pkap.0001");
            return content != "03" && content != String.Empty; 
        }
    }
}