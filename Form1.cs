using Timer = System.Windows.Forms.Timer;

namespace ConnectorComm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = Icon;
            loadSettings();
            initTimers();
        }

        // Save settings entered in the form fields.
        private void btnOk_Click(object sender, EventArgs e)
        {
            validateForm();
            if (errorProvider1.GetError(txtLinkV) != String.Empty || errorProvider1.GetError(txtLinkP) != String.Empty)
            {
                // Do not close the dialog on error.
                DialogResult = DialogResult.None;
            }
            else
            {
                saveSettings();
            }
        }

        private void txtLinkV_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateTextLink((TextBox)sender);
        }

        private void txtLinkP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateTextLink((TextBox)sender);
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

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            loadSettings();
            ShowDialog();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadSettings();
            ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void syncSalesToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            syncSales();
        }

        private void syncProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syncProducts();
        }

        private void validateForm()
        {
            validateTextLink(txtLinkV);
            validateTextLink(txtLinkP);
        }

        private void loadSettings()
        {
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
            // Validate after reload.
            validateForm();
        }

        private void saveSettings()
        {
            Properties.Settings.Default.vIntervalMin = (int)numIntV.Value;
            Properties.Settings.Default.pIntervalHour = (int)numIntP.Value;
            Properties.Settings.Default.vLink = txtLinkV.Text;
            Properties.Settings.Default.vLink = txtLinkP.Text;
            Properties.Settings.Default.pLink = txtLinkP.Text;
            Properties.Settings.Default.vFolder = brwV.Text;
            Properties.Settings.Default.pFolder = brwP.Text;
            Properties.Settings.Default.Save();
            initTimers();
        }

        private void validateTextLink(TextBox txtLink)
        {
            bool isValidUrl = Uri.TryCreate(txtLink.Text, UriKind.Absolute, out Uri? uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (isValidUrl || txtLink.Text == String.Empty)
            {
                // Clear the error.
                errorProvider1.SetError(txtLink, String.Empty);
            }
            else
            {
                errorProvider1.SetError(txtLink, "Adresa URL invalida.");
            }
        }

        private void initTimers()
        {
            // Sales-sync requires a web server URL.
            timerV.Stop();
            if (Properties.Settings.Default.vLink != String.Empty && Properties.Settings.Default.vFolder != String.Empty)
            {
                timerV.Interval = Properties.Settings.Default.vIntervalMin * 60 * 1000;
                timerV.Start();
            }
            // Product-sync requires a web server URL.
            timerP.Stop();
            if (Properties.Settings.Default.pLink != String.Empty && Properties.Settings.Default.pFolder != String.Empty)
            {
                timerP.Interval = Properties.Settings.Default.pIntervalHour * 3600 * 1000;
                timerP.Start();
            }
        }

        private void timerV_Tick(object sender, EventArgs e)
        {
            syncSales();
        }

        private void timerP_Tick(object sender, EventArgs e)
        {
            syncProducts();
        }

        private bool isPkapCorrect()
        {
            string content = File.ReadAllText(Properties.Settings.Default.vFolder + @"/pkap.0001");
            return content != "03" && content != String.Empty;
        }

        private async void syncSales()
        {
            // @todo Incremental file extensions.
            /*string newPkuld = Properties.Settings.Default.vFolder + @"/pkuld.0001";
            using FileStream fs = File.Create(newPkuld);
            using StreamWriter filePkuld = new(newPkuld, append: true);
            await filePkuld.WriteLineAsync("2032-00");*/
            // Wait for a response file.
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) => {
                notifyIcon1.ShowBalloonTip(500, "ConnectorComm", "Timer test", ToolTipIcon.None);
                ((Timer)sender).Stop();
                //timer.Stop();
                //timer.Dispose();
                //if (!isPkapCorrect())
                //{
                //    File.Delete(Properties.Settings.Default.vFolder + @"/pkap.0001");
                //}
            });
            timer.Interval = 1000;
            timer.Start();
        }

        private void syncProducts()
        {
            // @todo
        }
    }
}