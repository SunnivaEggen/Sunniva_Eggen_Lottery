namespace Sunniva_Eggen_Appolonia
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNumberOfTickets = new System.Windows.Forms.Label();
            this.txtStatistics = new System.Windows.Forms.TextBox();
            this.txtDraw = new System.Windows.Forms.TextBox();
            this.txtPrices = new System.Windows.Forms.TextBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(74, 39);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(112, 34);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(74, 404);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(184, 34);
            this.btnPrice.TabIndex = 1;
            this.btnPrice.Text = "Check Prices";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(74, 159);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(180, 34);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "Create Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(865, 98);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(148, 34);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Show Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(265, 209);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 31);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(265, 248);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 31);
            this.txtLastName.TabIndex = 5;
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Location = new System.Drawing.Point(265, 285);
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(150, 31);
            this.txtNumberOfTickets.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(74, 212);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 25);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(74, 254);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 25);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblNumberOfTickets
            // 
            this.lblNumberOfTickets.AutoSize = true;
            this.lblNumberOfTickets.Location = new System.Drawing.Point(74, 291);
            this.lblNumberOfTickets.Name = "lblNumberOfTickets";
            this.lblNumberOfTickets.Size = new System.Drawing.Size(161, 25);
            this.lblNumberOfTickets.TabIndex = 9;
            this.lblNumberOfTickets.Text = "Number of Tickets:";
            // 
            // txtStatistics
            // 
            this.txtStatistics.Location = new System.Drawing.Point(1045, 161);
            this.txtStatistics.Multiline = true;
            this.txtStatistics.Name = "txtStatistics";
            this.txtStatistics.Size = new System.Drawing.Size(254, 554);
            this.txtStatistics.TabIndex = 10;
            this.txtStatistics.TextChanged += new System.EventHandler(this.txtStatistics_TextChanged);
            // 
            // txtDraw
            // 
            this.txtDraw.Location = new System.Drawing.Point(208, 39);
            this.txtDraw.Name = "txtDraw";
            this.txtDraw.Size = new System.Drawing.Size(716, 31);
            this.txtDraw.TabIndex = 11;
            // 
            // txtPrices
            // 
            this.txtPrices.Location = new System.Drawing.Point(74, 455);
            this.txtPrices.Multiline = true;
            this.txtPrices.Name = "txtPrices";
            this.txtPrices.Size = new System.Drawing.Size(341, 260);
            this.txtPrices.TabIndex = 12;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(496, 140);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(540, 582);
            this.formsPlot1.TabIndex = 13;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(265, 322);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(150, 31);
            this.txtInvoiceNumber.TabIndex = 7;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(74, 328);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(101, 25);
            this.lblInvoiceNumber.TabIndex = 15;
            this.lblInvoiceNumber.Text = "Invoice No:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(1045, 133);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(36, 25);
            this.lblNumber.TabIndex = 16;
            this.lblNumber.Text = "No";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(1100, 133);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(75, 25);
            this.lblCount.TabIndex = 17;
            this.lblCount.Text = "Counter";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(1196, 133);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(86, 25);
            this.lblPercentage.TabIndex = 18;
            this.lblPercentage.Text = "Share (%)";
            // 
            // cboPeriod
            // 
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Items.AddRange(new object[] {
            "All Periods",
            "Last Month",
            "Last Week",
            "Last Day"});
            this.cboPeriod.Location = new System.Drawing.Point(677, 98);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(182, 33);
            this.cboPeriod.TabIndex = 19;
            this.cboPeriod.Text = "All Periods";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(543, 104);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(131, 25);
            this.lblPeriod.TabIndex = 20;
            this.lblPeriod.Text = "Choose Period:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 727);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.cboPeriod);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblInvoiceNumber);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.txtPrices);
            this.Controls.Add(this.txtDraw);
            this.Controls.Add(this.txtStatistics);
            this.Controls.Add(this.lblNumberOfTickets);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtNumberOfTickets);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDraw;
        private Button btnPrice;
        private Button btnInvoice;
        private Button btnStatistics;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtNumberOfTickets;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblNumberOfTickets;
        private TextBox txtStatistics;
        private TextBox txtDraw;
        private TextBox txtPrices;
        private ScottPlot.FormsPlot formsPlot1;
        private TextBox txtInvoiceNumber;
        private Label lblInvoiceNumber;
        private Label lblNumber;
        private Label lblCount;
        private Label lblPercentage;
        private ComboBox cboPeriod;
        private Label lblPeriod;
    }
}