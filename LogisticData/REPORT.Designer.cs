namespace LogisticData
{
    partial class REPORT
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
            this.dgLogistic = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutcome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateout1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOucome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgOutCome = new System.Windows.Forms.DataGridView();
            this.btnDisplayIncome = new System.Windows.Forms.Button();
            this.btnDisplayOutcome = new System.Windows.Forms.Button();
            this.dgWarehouse = new System.Windows.Forms.DataGridView();
            this.collcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDisplayWarehouse = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutCome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLogistic
            // 
            this.dgLogistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colName,
            this.colUnit,
            this.colDateEntry,
            this.colOutcome,
            this.colDateout1,
            this.colRemains});
            this.dgLogistic.Location = new System.Drawing.Point(12, 12);
            this.dgLogistic.Name = "dgLogistic";
            this.dgLogistic.Size = new System.Drawing.Size(437, 278);
            this.dgLogistic.TabIndex = 13;
            this.dgLogistic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLogistic_CellContentClick);
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            // 
            // colDateEntry
            // 
            this.colDateEntry.HeaderText = "Date Entry";
            this.colDateEntry.Name = "colDateEntry";
            // 
            // colOutcome
            // 
            this.colOutcome.HeaderText = "Outcome Goods";
            this.colOutcome.Name = "colOutcome";
            // 
            // colDateout1
            // 
            this.colDateout1.HeaderText = "Date Out";
            this.colDateout1.Name = "colDateout1";
            // 
            // colRemains
            // 
            this.colRemains.HeaderText = "Remaining Stock";
            this.colRemains.Name = "colRemains";
            // 
            // colSisa
            // 
            this.colSisa.HeaderText = "Remaining Stock";
            this.colSisa.Name = "colSisa";
            // 
            // colDateOut
            // 
            this.colDateOut.HeaderText = "Date Out";
            this.colDateOut.Name = "colDateOut";
            // 
            // colOucome
            // 
            this.colOucome.HeaderText = "Outcome Goods";
            this.colOucome.Name = "colOucome";
            // 
            // colID
            // 
            this.colID.HeaderText = "Code";
            this.colID.Name = "colID";
            // 
            // dgOutCome
            // 
            this.dgOutCome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOutCome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colOucome,
            this.colDateOut,
            this.colSisa});
            this.dgOutCome.Location = new System.Drawing.Point(455, 12);
            this.dgOutCome.Name = "dgOutCome";
            this.dgOutCome.Size = new System.Drawing.Size(435, 278);
            this.dgOutCome.TabIndex = 30;
            // 
            // btnDisplayIncome
            // 
            this.btnDisplayIncome.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayIncome.Location = new System.Drawing.Point(118, 307);
            this.btnDisplayIncome.Name = "btnDisplayIncome";
            this.btnDisplayIncome.Size = new System.Drawing.Size(162, 32);
            this.btnDisplayIncome.TabIndex = 31;
            this.btnDisplayIncome.Text = "Display Incoming_Goods";
            this.btnDisplayIncome.UseVisualStyleBackColor = true;
            this.btnDisplayIncome.Click += new System.EventHandler(this.btnDisplayIncome_Click);
            // 
            // btnDisplayOutcome
            // 
            this.btnDisplayOutcome.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayOutcome.Location = new System.Drawing.Point(586, 307);
            this.btnDisplayOutcome.Name = "btnDisplayOutcome";
            this.btnDisplayOutcome.Size = new System.Drawing.Size(172, 32);
            this.btnDisplayOutcome.TabIndex = 32;
            this.btnDisplayOutcome.Text = "Display Outcoming_Goods";
            this.btnDisplayOutcome.UseVisualStyleBackColor = true;
            this.btnDisplayOutcome.Click += new System.EventHandler(this.btnDisplayOutcome_Click);
            // 
            // dgWarehouse
            // 
            this.dgWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collcode,
            this.collName,
            this.collUnit});
            this.dgWarehouse.Location = new System.Drawing.Point(12, 373);
            this.dgWarehouse.Name = "dgWarehouse";
            this.dgWarehouse.Size = new System.Drawing.Size(344, 150);
            this.dgWarehouse.TabIndex = 33;
            // 
            // collcode
            // 
            this.collcode.HeaderText = "Code";
            this.collcode.Name = "collcode";
            // 
            // collName
            // 
            this.collName.HeaderText = "Name";
            this.collName.Name = "collName";
            // 
            // collUnit
            // 
            this.collUnit.HeaderText = "Unit";
            this.collUnit.Name = "collUnit";
            // 
            // btnDisplayWarehouse
            // 
            this.btnDisplayWarehouse.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayWarehouse.Location = new System.Drawing.Point(374, 466);
            this.btnDisplayWarehouse.Name = "btnDisplayWarehouse";
            this.btnDisplayWarehouse.Size = new System.Drawing.Size(178, 32);
            this.btnDisplayWarehouse.TabIndex = 34;
            this.btnDisplayWarehouse.Text = "Display Goods_Warehouse";
            this.btnDisplayWarehouse.UseVisualStyleBackColor = true;
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackgroundImage = global::LogisticData.Properties.Resources.backbuttoncircle_79559;
            this.Exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exitbtn.Location = new System.Drawing.Point(824, 454);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 63);
            this.Exitbtn.TabIndex = 35;
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // REPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 520);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.btnDisplayWarehouse);
            this.Controls.Add(this.dgWarehouse);
            this.Controls.Add(this.btnDisplayOutcome);
            this.Controls.Add(this.btnDisplayIncome);
            this.Controls.Add(this.dgOutCome);
            this.Controls.Add(this.dgLogistic);
            this.Name = "REPORT";
            this.Text = "REPORT";
            this.Load += new System.EventHandler(this.REPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLogistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutCome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWarehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLogistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateout1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemains;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOucome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridView dgOutCome;
        private System.Windows.Forms.Button btnDisplayIncome;
        private System.Windows.Forms.Button btnDisplayOutcome;
        private System.Windows.Forms.DataGridView dgWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn collcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn collName;
        private System.Windows.Forms.DataGridViewTextBoxColumn collUnit;
        private System.Windows.Forms.Button btnDisplayWarehouse;
        private System.Windows.Forms.Button Exitbtn;
    }
}