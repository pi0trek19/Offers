namespace Offers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOffers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.NewOfferbutton = new System.Windows.Forms.Button();

            this.rentCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noMonthsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyMilageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageOffers.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageClients.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();

            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOffers);
            this.tabControl1.Controls.Add(this.tabPageClients);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageOffers
            // 
            this.tabPageOffers.Controls.Add(this.tableLayoutPanel1);
            this.tabPageOffers.Location = new System.Drawing.Point(4, 22);
            this.tabPageOffers.Name = "tabPageOffers";
            this.tabPageOffers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOffers.Size = new System.Drawing.Size(792, 424);
            this.tabPageOffers.TabIndex = 0;
            this.tabPageOffers.Text = "Oferty";
            this.tabPageOffers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.97129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.02871F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentCarDataGridViewTextBoxColumn,
            this.noMonthsDataGridViewTextBoxColumn,
            this.monthlyFeeDataGridViewTextBoxColumn,
            this.startPaymentDataGridViewTextBoxColumn,
            this.endPaymentDataGridViewTextBoxColumn,
            this.monthlyMilageDataGridViewTextBoxColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(780, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.tableLayoutPanel2);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(792, 424);
            this.tabPageClients.TabIndex = 1;
            this.tabPageClients.Text = "Klienci";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.58525F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.41475F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(780, 284);
            this.dataGridView2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.NewOfferbutton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 353);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(499, 62);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // NewOfferbutton
            // 
            this.NewOfferbutton.Location = new System.Drawing.Point(3, 3);
            this.NewOfferbutton.Name = "NewOfferbutton";
            this.NewOfferbutton.Size = new System.Drawing.Size(75, 23);
            this.NewOfferbutton.TabIndex = 0;
            this.NewOfferbutton.Text = "Nowa Oferta";
            this.NewOfferbutton.UseVisualStyleBackColor = true;
            this.NewOfferbutton.Click += new System.EventHandler(this.NewOfferbutton_Click);
            // 
            // offerBindingSource
            // 

            // 
            // rentCarDataGridViewTextBoxColumn
            // 
            this.rentCarDataGridViewTextBoxColumn.DataPropertyName = "RentCar.RegNo";
            this.rentCarDataGridViewTextBoxColumn.HeaderText = "Nr. Rej";
            this.rentCarDataGridViewTextBoxColumn.Name = "rentCarDataGridViewTextBoxColumn";
            this.rentCarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noMonthsDataGridViewTextBoxColumn
            // 
            this.noMonthsDataGridViewTextBoxColumn.DataPropertyName = "NoMonths";
            this.noMonthsDataGridViewTextBoxColumn.HeaderText = "NoMonths";
            this.noMonthsDataGridViewTextBoxColumn.Name = "noMonthsDataGridViewTextBoxColumn";
            this.noMonthsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthlyFeeDataGridViewTextBoxColumn
            // 
            this.monthlyFeeDataGridViewTextBoxColumn.DataPropertyName = "MonthlyFee";
            this.monthlyFeeDataGridViewTextBoxColumn.HeaderText = "MonthlyFee";
            this.monthlyFeeDataGridViewTextBoxColumn.Name = "monthlyFeeDataGridViewTextBoxColumn";
            this.monthlyFeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startPaymentDataGridViewTextBoxColumn
            // 
            this.startPaymentDataGridViewTextBoxColumn.DataPropertyName = "StartPayment";
            this.startPaymentDataGridViewTextBoxColumn.HeaderText = "StartPayment";
            this.startPaymentDataGridViewTextBoxColumn.Name = "startPaymentDataGridViewTextBoxColumn";
            this.startPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endPaymentDataGridViewTextBoxColumn
            // 
            this.endPaymentDataGridViewTextBoxColumn.DataPropertyName = "EndPayment";
            this.endPaymentDataGridViewTextBoxColumn.HeaderText = "EndPayment";
            this.endPaymentDataGridViewTextBoxColumn.Name = "endPaymentDataGridViewTextBoxColumn";
            this.endPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthlyMilageDataGridViewTextBoxColumn
            // 
            this.monthlyMilageDataGridViewTextBoxColumn.DataPropertyName = "MonthlyMilage";
            this.monthlyMilageDataGridViewTextBoxColumn.HeaderText = "MonthlyMilage";
            this.monthlyMilageDataGridViewTextBoxColumn.Name = "monthlyMilageDataGridViewTextBoxColumn";
            this.monthlyMilageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOffers.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageClients.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOffers;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button NewOfferbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noMonthsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyMilageDataGridViewTextBoxColumn;
    }
}

