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
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numIntV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntP)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vanzari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interval (min)";
            // 
            // numIntV
            // 
            this.numIntV.Location = new System.Drawing.Point(23, 53);
            this.numIntV.Margin = new System.Windows.Forms.Padding(1);
            this.numIntV.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numIntV.Name = "numIntV";
            this.numIntV.Size = new System.Drawing.Size(45, 27);
            this.numIntV.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Link";
            // 
            // txtLinkV
            // 
            this.txtLinkV.Location = new System.Drawing.Point(23, 112);
            this.txtLinkV.Margin = new System.Windows.Forms.Padding(1);
            this.txtLinkV.Name = "txtLinkV";
            this.txtLinkV.Size = new System.Drawing.Size(172, 27);
            this.txtLinkV.TabIndex = 5;
            this.txtLinkV.Validating += new System.ComponentModel.CancelEventHandler(this.txtLinkV_Validating);
            // 
            // brwV
            // 
            this.brwV.Location = new System.Drawing.Point(23, 167);
            this.brwV.Margin = new System.Windows.Forms.Padding(1);
            this.brwV.Name = "brwV";
            this.brwV.Size = new System.Drawing.Size(169, 28);
            this.brwV.TabIndex = 6;
            this.brwV.Text = "Browse Folders";
            this.brwV.UseVisualStyleBackColor = true;
            this.brwV.Click += new System.EventHandler(this.brwV_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Folder";
            // 
            // brwP
            // 
            this.brwP.Location = new System.Drawing.Point(212, 167);
            this.brwP.Margin = new System.Windows.Forms.Padding(1);
            this.brwP.Name = "brwP";
            this.brwP.Size = new System.Drawing.Size(169, 28);
            this.brwP.TabIndex = 12;
            this.brwP.Text = "Browse Folders";
            this.brwP.UseVisualStyleBackColor = true;
            this.brwP.Click += new System.EventHandler(this.brwP_Click);
            // 
            // txtLinkP
            // 
            this.txtLinkP.Location = new System.Drawing.Point(212, 112);
            this.txtLinkP.Margin = new System.Windows.Forms.Padding(1);
            this.txtLinkP.Name = "txtLinkP";
            this.txtLinkP.Size = new System.Drawing.Size(172, 27);
            this.txtLinkP.TabIndex = 11;
            this.txtLinkP.Validating += new System.ComponentModel.CancelEventHandler(this.txtLinkP_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Link";
            // 
            // numIntP
            // 
            this.numIntP.Location = new System.Drawing.Point(212, 53);
            this.numIntP.Margin = new System.Windows.Forms.Padding(1);
            this.numIntP.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numIntP.Name = "numIntP";
            this.numIntP.Size = new System.Drawing.Size(42, 27);
            this.numIntP.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Interval (ore)";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "ConnectorComm";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.syncSalesToolStripMenuItem,
            this.syncProductsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 128);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.configToolStripMenuItem.Text = "&Configurare";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // syncSalesToolStripMenuItem
            // 
            this.syncSalesToolStripMenuItem.Name = "syncSalesToolStripMenuItem";
            this.syncSalesToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.syncSalesToolStripMenuItem.Text = "Sincronizare &vanzari";
            this.syncSalesToolStripMenuItem.Click += new System.EventHandler(this.syncSalesToolStripMenuItem_ClickAsync);
            // 
            // syncProductsToolStripMenuItem
            // 
            this.syncProductsToolStripMenuItem.Name = "syncProductsToolStripMenuItem";
            this.syncProductsToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.syncProductsToolStripMenuItem.Text = "Sincronizare &produse";
            this.syncProductsToolStripMenuItem.Click += new System.EventHandler(this.syncProductsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(104, 231);
            this.btnOk.Margin = new System.Windows.Forms.Padding(1);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 28);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(212, 231);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 28);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(408, 299);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "ConnectorComm";
            ((System.ComponentModel.ISupportInitialize)(this.numIntV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntP)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private ToolStripMenuItem configToolStripMenuItem;
        private ToolStripMenuItem syncSalesToolStripMenuItem;
        private ToolStripMenuItem syncProductsToolStripMenuItem;
        private Button btnOk;
        private Button btnCancel;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ErrorProvider errorProvider1;
    }
}