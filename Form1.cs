using System;
using System.Diagnostics;
using System.Net;
using System.Security.Policy;
using System.Text;
using Timer = System.Windows.Forms.Timer;

namespace ConnectorComm
{
    public partial class Form1 : Form
    {

        private int vCount = 1;

        private int pCount = 1;

        private HttpClient httpClient = new HttpClient();

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

        private void txtLink_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
            if (!this.Visible)
            { 
                ShowDialog(); 
            }
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadSettings();
            if (!this.Visible)
            { 
                ShowDialog(); 
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void syncSalesToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            if (checkSalesConfig())
            {
                vCount++;
                syncSales();
                vCount--;
            }
        }

        private void syncProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkProductsConfig())
            {
                pCount++;
                syncProducts();
                vCount--;
            }
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

        private bool checkSalesConfig()
        {
            return  Properties.Settings.Default.vLink != String.Empty && Properties.Settings.Default.vFolder != String.Empty;
        }

        private bool checkProductsConfig()
        {
            return Properties.Settings.Default.pLink != String.Empty && Properties.Settings.Default.pFolder != String.Empty;
        }

        private void initTimers()
        {
            // Sales-sync requires a web server URL.
            timerV.Stop();
            if (Properties.Settings.Default.vIntervalMin > 0 && checkSalesConfig())
            {
                //timerV.Interval = Properties.Settings.Default.vIntervalMin * 60 * 1000;
                timerV.Interval = 1000;
                timerV.Start();
            }
            // Product-sync requires a web server URL.
            timerP.Stop();
            if (Properties.Settings.Default.pIntervalHour > 0 && checkProductsConfig())
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

        private async void syncSales()
        {
            // Look for pkuld.0001 and pkap.0001 files (file extension is a counter with leading zeros).
            string pathRequest = Properties.Settings.Default.vFolder + @"/pkuld." + vCount.ToString("D4");
            string pathResponse = Properties.Settings.Default.vFolder + @"/pkap." + vCount.ToString("D4");
            bool existsPkuld = File.Exists(pathRequest);
            bool existsPkap = File.Exists(pathResponse);
            /*foreach (string file in Directory.EnumerateFiles(Properties.Settings.Default.vFolder, "*.0001"))
            {
            }*/
            if (!existsPkuld && !existsPkap)
            {
                using (StreamWriter sw = new StreamWriter(pathRequest, true, Encoding.Default))
                {
                    sw.Write("2032-00");
                }
                // Start a new timer to watch for a response from Connector.
                Timer timer = new Timer();
                timer.Tick += new EventHandler(async (sender, e) =>
                {
                    if (File.Exists(pathResponse))
                    {
                        // Response found, stop the timer.
                        ((Timer)sender).Stop();
                        bool canDeleteResponseFile = false;
                        // Read response file contents.
                        string content = File.ReadAllText(pathResponse);
                        if (content != "03" && content != String.Empty)
                        {
                            // Response content is correct and can be sent to server.
                            // Send response to web server.
                            try
                            {
                                var httpContent = new StringContent(content, Encoding.UTF8, "application/text");
                                var httpResponse = await httpClient.PostAsync(Properties.Settings.Default.vLink, httpContent);
                                /*HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Properties.Settings.Default.vLink);
                                request.Method = "POST";
                                request.ContentType = "application/text";
                                byte[] byteArray = Encoding.UTF8.GetBytes(content);
                                request.ContentLength = byteArray.Length;
                                // Get the request stream.
                                var dataStream = request.GetRequestStream();
                                // Write the data to the request stream.
                                dataStream.Write(byteArray, 0, byteArray.Length);
                                // Close the Stream object.
                                dataStream.Close();*/
                                canDeleteResponseFile = true;
                            }
                            catch (Exception ex) 
                            {
                                notify("Server error: " + ex.Message, EventLogEntryType.Error);
                            }
                        }
                        else
                        {
                            // Response content is NOT correct and can NOT be sent to server.
                            notify("Connector response error. " + pathResponse);
                            // @todo Copy erroneous pkap int oa separate file for debugging?
                        }

                        // Delete response file.
                        if (canDeleteResponseFile)
                        {
                            File.Delete(pathResponse);
                        }
                    }
                });
                timer.Interval = 500;
                timer.Start();
            }
            else if (!existsPkuld && existsPkap)
            {
                // Edge-case. Kuldes szervernek, Letrohoz uj pkuld

            }
            else if (existsPkuld && existsPkap)
            {
                // Kuldes szervernek, pkuld torol, Letrohoz uj pkuld

            }
            else if (existsPkuld && !existsPkap)
            {
                // Varunk “vegtelenig”
            }
        }

        private void syncProducts()
        {
            // @todo
            // Get contents from web server.
            string contents = "";
            using (WebClient wc = new WebClient())
            {
                //wc.Headers.Add(HttpRequestHeader.Accept, "application/json");
                try
                {
                    contents = wc.DownloadString(Properties.Settings.Default.pLink);
                    //response.statusCode = (int)HttpStatusCode.OK;
                }
                catch (WebException ex)
                {
                    notify(ex.Message, EventLogEntryType.Error);
                    return;
                }
            }
        }
        
        private void notify(string message, EventLogEntryType type = EventLogEntryType.Information)
        {
            try
            {
                //if (!EventLog.SourceExists("ConnectComm"))
                //{
                //    EventLog.CreateEventSource("ConnectComm", "Application");
                //}
                //EventLog.WriteEntry("ConnectComm", message, type);
            }
            catch (System.Security.SecurityException ex)
            {
                notifyIcon1.ShowBalloonTip(500, "ConnectComm", "Failed to write log entry. " + ex.Message, ToolTipIcon.Error);
            }
            // Cast from EventLogEntryType to ToolTipIcon.
            ToolTipIcon icon = (ToolTipIcon)((int)type);
            notifyIcon1.ShowBalloonTip(500, "ConnectComm", message, ToolTipIcon.Info);
        }

    }
}