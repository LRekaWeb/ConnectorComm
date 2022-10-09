using System.Security.Policy;

namespace ConnectorComm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = Icon;
            loadSettings();
        }

        // Save settings entered in the form fields.
        private void btnOk_Click(object sender, EventArgs e)
        {
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
            ShowDialog();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void syncSalesToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            string newPkuld = Properties.Settings.Default.vFolder + @"/pkuld.0001";
            using FileStream fs = File.Create(newPkuld);
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
        }

        private void txtLinkV_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateTextLink((TextBox)sender);
        }

        private void txtLinkP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateTextLink((TextBox)sender);
        }

        private void validateTextLink(TextBox txtLink)
        {
            //e.Cancel = true;
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

        private bool isPkapCorrect()
        {
            string content = File.ReadAllText(Properties.Settings.Default.vFolder + @"/pkap.0001");
            return content != "03" && content != String.Empty;
        }
    }
}