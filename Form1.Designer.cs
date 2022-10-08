namespace ConnectorComm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numIntV = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLinkV = new System.Windows.Forms.TextBox();
            this.brwV = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.brwP = new System.Windows.Forms.Button();
            this.txtLinkP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numIntP = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sincronizarevanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sincronizareproduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.autoTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numIntV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntP)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vanzari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interval (min)";
            // 
            // numIntV
            // 
            this.numIntV.Location = new System.Drawing.Point(48, 109);
            this.numIntV.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numIntV.Name = "numIntV";
            this.numIntV.Size = new System.Drawing.Size(96, 47);
            this.numIntV.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Link";
            // 
            // txtLinkV
            // 
            this.txtLinkV.Location = new System.Drawing.Point(48, 230);
            this.txtLinkV.Name = "txtLinkV";
            this.txtLinkV.Size = new System.Drawing.Size(360, 47);
            this.txtLinkV.TabIndex = 5;
            // 
            // brwV
            // 
            this.brwV.Location = new System.Drawing.Point(48, 343);
            this.brwV.Name = "brwV";
            this.brwV.Size = new System.Drawing.Size(360, 58);
            this.brwV.TabIndex = 6;
            this.brwV.Text = "Browse Folders";
            this.brwV.UseVisualStyleBackColor = true;
            this.brwV.Click += new System.EventHandler(this.brwV_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "Folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 41);
            this.label6.TabIndex = 13;
            this.label6.Text = "Folder";
            // 
            // brwP
            // 
            this.brwP.Location = new System.Drawing.Point(451, 343);
            this.brwP.Name = "brwP";
            this.brwP.Size = new System.Drawing.Size(360, 58);
            this.brwP.TabIndex = 12;
            this.brwP.Text = "Browse Folders";
            this.brwP.UseVisualStyleBackColor = true;
            this.brwP.Click += new System.EventHandler(this.brwP_Click);
            // 
            // txtLinkP
            // 
            this.txtLinkP.Location = new System.Drawing.Point(451, 230);
            this.txtLinkP.Name = "txtLinkP";
            this.txtLinkP.Size = new System.Drawing.Size(360, 47);
            this.txtLinkP.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 41);
            this.label7.TabIndex = 10;
            this.label7.Text = "Link";
            // 
            // numIntP
            // 
            this.numIntP.Location = new System.Drawing.Point(451, 109);
            this.numIntP.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numIntP.Name = "numIntP";
            this.numIntP.Size = new System.Drawing.Size(89, 47);
            this.numIntP.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 41);
            this.label8.TabIndex = 8;
            this.label8.Text = "Interval (ore)";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "ConnectorComm";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vanzariToolStripMenuItem,
            this.sincronizarevanzariToolStripMenuItem,
            this.sincronizareproduseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(376, 196);
            // 
            // vanzariToolStripMenuItem
            // 
            this.vanzariToolStripMenuItem.Name = "vanzariToolStripMenuItem";
            this.vanzariToolStripMenuItem.Size = new System.Drawing.Size(375, 48);
            this.vanzariToolStripMenuItem.Text = "&Configurare";
            // 
            // sincronizarevanzariToolStripMenuItem
            // 
            this.sincronizarevanzariToolStripMenuItem.Name = "sincronizarevanzariToolStripMenuItem";
            this.sincronizarevanzariToolStripMenuItem.Size = new System.Drawing.Size(375, 48);
            this.sincronizarevanzariToolStripMenuItem.Text = "Sincronizare &vanzari";
            this.sincronizarevanzariToolStripMenuItem.Click += new System.EventHandler(this.sincronizarevanzariToolStripMenuItem_Click);
            // 
            // sincronizareproduseToolStripMenuItem
            // 
            this.sincronizareproduseToolStripMenuItem.Name = "sincronizareproduseToolStripMenuItem";
            this.sincronizareproduseToolStripMenuItem.Size = new System.Drawing.Size(375, 48);
            this.sincronizareproduseToolStripMenuItem.Text = "Sincronizare &produse";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(375, 48);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(220, 474);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(188, 58);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(451, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(188, 58);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // autoTimer
            // 
            this.autoTimer.Interval = 15000;
            this.autoTimer.Tick += new System.EventHandler(this.sincronizarevanzariToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(868, 612);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brwP);
            this.Controls.Add(this.txtLinkP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numIntP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brwV);
            this.Controls.Add(this.txtLinkV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numIntV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ConnectorComm";
            ((System.ComponentModel.ISupportInitialize)(this.numIntV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntP)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numIntV;
        private Label label4;
        private TextBox txtLinkV;
        private Button brwV;
        private Label label5;
        private Label label6;
        private Button brwP;
        private TextBox txtLinkP;
        private Label label7;
        private NumericUpDown numIntP;
        private Label label8;
        private FolderBrowserDialog folderBrowserDialog1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem vanzariToolStripMenuItem;
        private ToolStripMenuItem sincronizarevanzariToolStripMenuItem;
        private ToolStripMenuItem sincronizareproduseToolStripMenuItem;
        private Button btnOk;
        private Button btnCancel;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer autoTimer;
    }
}