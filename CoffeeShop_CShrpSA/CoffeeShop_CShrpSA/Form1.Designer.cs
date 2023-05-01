
namespace CoffeeShop_CShrpSA
{
    partial class MainWindow
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDBDataSet = new CoffeeShop_CShrpSA.CoffeeShopDBDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPick_managementTab = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBtn_Yearly = new System.Windows.Forms.RadioButton();
            this.rdBtn_Monthly = new System.Windows.Forms.RadioButton();
            this.rdBtn_Daily = new System.Windows.Forms.RadioButton();
            this.btn_b3 = new System.Windows.Forms.Button();
            this.btn_b2 = new System.Windows.Forms.Button();
            this.btn_b1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox_SelectCoffee = new System.Windows.Forms.ComboBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkBox_Cream = new System.Windows.Forms.CheckBox();
            this.chkBox_Sugar = new System.Windows.Forms.CheckBox();
            this.comboBox_SelectQuantity = new System.Windows.Forms.ComboBox();
            this.txt_OrderSummary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdBtn_Large = new System.Windows.Forms.RadioButton();
            this.rdBtn_Medium = new System.Windows.Forms.RadioButton();
            this.rdBtn_Small = new System.Windows.Forms.RadioButton();
            this.salesTableTableAdapter = new CoffeeShop_CShrpSA.CoffeeShopDBDataSetTableAdapters.SalesTableTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.printDataGridView = new System.Drawing.Printing.PrintDocument();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDBDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 651);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DTPick_managementTab);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rdBtn_Yearly);
            this.tabPage1.Controls.Add(this.rdBtn_Monthly);
            this.tabPage1.Controls.Add(this.rdBtn_Daily);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btn_b3);
            this.tabPage1.Controls.Add(this.btn_b2);
            this.tabPage1.Controls.Add(this.btn_b1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MANAGEMENT";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSaleDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(627, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 151);
            this.dataGridView1.TabIndex = 30;
            // 
            // idSaleDataGridViewTextBoxColumn
            // 
            this.idSaleDataGridViewTextBoxColumn.DataPropertyName = "Id_Sale";
            this.idSaleDataGridViewTextBoxColumn.HeaderText = "Id_Sale";
            this.idSaleDataGridViewTextBoxColumn.Name = "idSaleDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // salesTableBindingSource
            // 
            this.salesTableBindingSource.DataMember = "SalesTable";
            this.salesTableBindingSource.DataSource = this.coffeeShopDBDataSet;
            // 
            // coffeeShopDBDataSet
            // 
            this.coffeeShopDBDataSet.DataSetName = "CoffeeShopDBDataSet";
            this.coffeeShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "COFFEE SHOP SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Summary: ";
            // 
            // DTPick_managementTab
            // 
            this.DTPick_managementTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPick_managementTab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPick_managementTab.Location = new System.Drawing.Point(713, 212);
            this.DTPick_managementTab.Name = "DTPick_managementTab";
            this.DTPick_managementTab.Size = new System.Drawing.Size(250, 21);
            this.DTPick_managementTab.TabIndex = 10;
            this.DTPick_managementTab.ValueChanged += new System.EventHandler(this.DTPick_managementTab_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(624, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sale";
            // 
            // rdBtn_Yearly
            // 
            this.rdBtn_Yearly.AutoSize = true;
            this.rdBtn_Yearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Yearly.Location = new System.Drawing.Point(899, 156);
            this.rdBtn_Yearly.Name = "rdBtn_Yearly";
            this.rdBtn_Yearly.Size = new System.Drawing.Size(64, 19);
            this.rdBtn_Yearly.TabIndex = 8;
            this.rdBtn_Yearly.TabStop = true;
            this.rdBtn_Yearly.Text = "Yearly";
            this.rdBtn_Yearly.UseVisualStyleBackColor = true;
            // 
            // rdBtn_Monthly
            // 
            this.rdBtn_Monthly.AutoSize = true;
            this.rdBtn_Monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Monthly.Location = new System.Drawing.Point(800, 156);
            this.rdBtn_Monthly.Name = "rdBtn_Monthly";
            this.rdBtn_Monthly.Size = new System.Drawing.Size(75, 19);
            this.rdBtn_Monthly.TabIndex = 7;
            this.rdBtn_Monthly.TabStop = true;
            this.rdBtn_Monthly.Text = "Monthly";
            this.rdBtn_Monthly.UseVisualStyleBackColor = true;
            // 
            // rdBtn_Daily
            // 
            this.rdBtn_Daily.AutoSize = true;
            this.rdBtn_Daily.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Daily.Location = new System.Drawing.Point(713, 156);
            this.rdBtn_Daily.Name = "rdBtn_Daily";
            this.rdBtn_Daily.Size = new System.Drawing.Size(57, 19);
            this.rdBtn_Daily.TabIndex = 6;
            this.rdBtn_Daily.TabStop = true;
            this.rdBtn_Daily.Text = "Daily";
            this.rdBtn_Daily.UseVisualStyleBackColor = true;
            // 
            // btn_b3
            // 
            this.btn_b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b3.ForeColor = System.Drawing.Color.Red;
            this.btn_b3.Location = new System.Drawing.Point(479, 130);
            this.btn_b3.Name = "btn_b3";
            this.btn_b3.Size = new System.Drawing.Size(53, 20);
            this.btn_b3.TabIndex = 2;
            this.btn_b3.Text = "b3";
            this.btn_b3.UseVisualStyleBackColor = true;
            this.btn_b3.Click += new System.EventHandler(this.btn_b3_Click);
            // 
            // btn_b2
            // 
            this.btn_b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b2.ForeColor = System.Drawing.Color.Red;
            this.btn_b2.Location = new System.Drawing.Point(279, 130);
            this.btn_b2.Name = "btn_b2";
            this.btn_b2.Size = new System.Drawing.Size(53, 20);
            this.btn_b2.TabIndex = 1;
            this.btn_b2.Text = "b2";
            this.btn_b2.UseVisualStyleBackColor = true;
            this.btn_b2.Click += new System.EventHandler(this.btn_b2_Click);
            // 
            // btn_b1
            // 
            this.btn_b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b1.ForeColor = System.Drawing.Color.Red;
            this.btn_b1.Location = new System.Drawing.Point(74, 130);
            this.btn_b1.Name = "btn_b1";
            this.btn_b1.Size = new System.Drawing.Size(53, 20);
            this.btn_b1.TabIndex = 0;
            this.btn_b1.Text = "b1";
            this.btn_b1.UseVisualStyleBackColor = true;
            this.btn_b1.Click += new System.EventHandler(this.btn_b1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.comboBox_SelectCoffee);
            this.tabPage2.Controls.Add(this.btn_Print);
            this.tabPage2.Controls.Add(this.btn_AddOrder);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.chkBox_Cream);
            this.tabPage2.Controls.Add(this.chkBox_Sugar);
            this.tabPage2.Controls.Add(this.comboBox_SelectQuantity);
            this.tabPage2.Controls.Add(this.txt_OrderSummary);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.rdBtn_Large);
            this.tabPage2.Controls.Add(this.rdBtn_Medium);
            this.tabPage2.Controls.Add(this.rdBtn_Small);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1168, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ORDER";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // comboBox_SelectCoffee
            // 
            this.comboBox_SelectCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SelectCoffee.FormattingEnabled = true;
            this.comboBox_SelectCoffee.Items.AddRange(new object[] {
            "Americano",
            "Cappuccino",
            "Espresso",
            "Late",
            "Macchiato"});
            this.comboBox_SelectCoffee.Location = new System.Drawing.Point(170, 153);
            this.comboBox_SelectCoffee.Name = "comboBox_SelectCoffee";
            this.comboBox_SelectCoffee.Size = new System.Drawing.Size(281, 23);
            this.comboBox_SelectCoffee.TabIndex = 27;
            this.comboBox_SelectCoffee.Text = "Select Coffee";
            this.comboBox_SelectCoffee.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectCoffee_SelectedIndexChanged);
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(316, 424);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(135, 27);
            this.btn_Print.TabIndex = 26;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOrder.Location = new System.Drawing.Point(170, 424);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(135, 27);
            this.btn_AddOrder.TabIndex = 25;
            this.btn_AddOrder.Text = "Add To Order";
            this.btn_AddOrder.UseVisualStyleBackColor = true;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Type Of Coffee: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 33);
            this.label6.TabIndex = 23;
            this.label6.Text = "COFFEE SHOP SYSTEM";
            // 
            // chkBox_Cream
            // 
            this.chkBox_Cream.AutoSize = true;
            this.chkBox_Cream.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_Cream.Location = new System.Drawing.Point(655, 205);
            this.chkBox_Cream.Name = "chkBox_Cream";
            this.chkBox_Cream.Size = new System.Drawing.Size(68, 19);
            this.chkBox_Cream.TabIndex = 22;
            this.chkBox_Cream.Text = "Cream";
            this.chkBox_Cream.UseVisualStyleBackColor = true;
            // 
            // chkBox_Sugar
            // 
            this.chkBox_Sugar.AutoSize = true;
            this.chkBox_Sugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_Sugar.Location = new System.Drawing.Point(556, 205);
            this.chkBox_Sugar.Name = "chkBox_Sugar";
            this.chkBox_Sugar.Size = new System.Drawing.Size(64, 19);
            this.chkBox_Sugar.TabIndex = 21;
            this.chkBox_Sugar.Text = "Sugar";
            this.chkBox_Sugar.UseVisualStyleBackColor = true;
            this.chkBox_Sugar.CheckedChanged += new System.EventHandler(this.chkBox_Sugar_CheckedChanged);
            // 
            // comboBox_SelectQuantity
            // 
            this.comboBox_SelectQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SelectQuantity.FormattingEnabled = true;
            this.comboBox_SelectQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_SelectQuantity.Location = new System.Drawing.Point(766, 203);
            this.comboBox_SelectQuantity.Name = "comboBox_SelectQuantity";
            this.comboBox_SelectQuantity.Size = new System.Drawing.Size(125, 23);
            this.comboBox_SelectQuantity.TabIndex = 20;
            this.comboBox_SelectQuantity.Text = "Select Quantity";
            // 
            // txt_OrderSummary
            // 
            this.txt_OrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OrderSummary.Location = new System.Drawing.Point(556, 278);
            this.txt_OrderSummary.Multiline = true;
            this.txt_OrderSummary.Name = "txt_OrderSummary";
            this.txt_OrderSummary.ReadOnly = true;
            this.txt_OrderSummary.Size = new System.Drawing.Size(399, 153);
            this.txt_OrderSummary.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Order Summary: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Size";
            // 
            // rdBtn_Large
            // 
            this.rdBtn_Large.AutoSize = true;
            this.rdBtn_Large.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Large.Location = new System.Drawing.Point(828, 152);
            this.rdBtn_Large.Name = "rdBtn_Large";
            this.rdBtn_Large.Size = new System.Drawing.Size(62, 19);
            this.rdBtn_Large.TabIndex = 15;
            this.rdBtn_Large.Text = "Large";
            this.rdBtn_Large.UseVisualStyleBackColor = true;
            this.rdBtn_Large.CheckedChanged += new System.EventHandler(this.rdBtn_Large_CheckedChanged);
            // 
            // rdBtn_Medium
            // 
            this.rdBtn_Medium.AutoSize = true;
            this.rdBtn_Medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Medium.Location = new System.Drawing.Point(729, 152);
            this.rdBtn_Medium.Name = "rdBtn_Medium";
            this.rdBtn_Medium.Size = new System.Drawing.Size(77, 19);
            this.rdBtn_Medium.TabIndex = 14;
            this.rdBtn_Medium.Text = "Medium";
            this.rdBtn_Medium.UseVisualStyleBackColor = true;
            this.rdBtn_Medium.CheckedChanged += new System.EventHandler(this.rdBtn_Medium_CheckedChanged);
            // 
            // rdBtn_Small
            // 
            this.rdBtn_Small.AutoSize = true;
            this.rdBtn_Small.Checked = true;
            this.rdBtn_Small.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_Small.Location = new System.Drawing.Point(642, 152);
            this.rdBtn_Small.Name = "rdBtn_Small";
            this.rdBtn_Small.Size = new System.Drawing.Size(62, 19);
            this.rdBtn_Small.TabIndex = 13;
            this.rdBtn_Small.TabStop = true;
            this.rdBtn_Small.Text = "Small";
            this.rdBtn_Small.UseVisualStyleBackColor = true;
            this.rdBtn_Small.CheckedChanged += new System.EventHandler(this.rdBtn_Small_CheckedChanged);
            // 
            // salesTableTableAdapter
            // 
            this.salesTableTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CoffeeShop_CShrpSA.Properties.Resources.Viewdata12;
            this.pictureBox3.Location = new System.Drawing.Point(418, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 279);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CoffeeShop_CShrpSA.Properties.Resources.print12;
            this.pictureBox2.Location = new System.Drawing.Point(215, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 279);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeShop_CShrpSA.Properties.Resources.save_to_file_12;
            this.pictureBox1.Location = new System.Drawing.Point(12, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CoffeeShop_CShrpSA.Properties.Resources._48_485680_coffee_logo_logo_elements_logo_objects_coffee_logo;
            this.pictureBox4.Location = new System.Drawing.Point(170, 180);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(280, 227);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // printDataGridView
            // 
            this.printDataGridView.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDataGridView_PrintPage);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 668);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "Coffee Shop App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDBDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_b3;
        private System.Windows.Forms.Button btn_b2;
        private System.Windows.Forms.Button btn_b1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPick_managementTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtn_Yearly;
        private System.Windows.Forms.RadioButton rdBtn_Monthly;
        private System.Windows.Forms.RadioButton rdBtn_Daily;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_SelectQuantity;
        private System.Windows.Forms.TextBox txt_OrderSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdBtn_Large;
        private System.Windows.Forms.RadioButton rdBtn_Medium;
        private System.Windows.Forms.RadioButton rdBtn_Small;
        private System.Windows.Forms.CheckBox chkBox_Cream;
        private System.Windows.Forms.CheckBox chkBox_Sugar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox comboBox_SelectCoffee;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private CoffeeShopDBDataSet coffeeShopDBDataSet;
        private System.Windows.Forms.BindingSource salesTableBindingSource;
        private CoffeeShopDBDataSetTableAdapters.SalesTableTableAdapter salesTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDataGridView;
    }
}

