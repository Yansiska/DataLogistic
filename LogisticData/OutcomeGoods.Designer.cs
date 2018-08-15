namespace LogisticData
{
    partial class OutcomeGoods
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
            this.btnSaveOut = new System.Windows.Forms.Button();
            this.dgLogistic = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lboutcoming = new System.Windows.Forms.Label();
            this.lbSisa = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.txtSisa = new System.Windows.Forms.TextBox();
            this.dateTimeOut = new System.Windows.Forms.DateTimePicker();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUnit = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.dateEntry = new System.Windows.Forms.DateTimePicker();
            this.txtOutcome = new System.Windows.Forms.TextBox();
            this.dgOutCome = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOucome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExitOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutCome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveOut
            // 
            this.btnSaveOut.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOut.Location = new System.Drawing.Point(149, 370);
            this.btnSaveOut.Name = "btnSaveOut";
            this.btnSaveOut.Size = new System.Drawing.Size(75, 36);
            this.btnSaveOut.TabIndex = 13;
            this.btnSaveOut.Text = "Save";
            this.btnSaveOut.UseVisualStyleBackColor = true;
            this.btnSaveOut.Click += new System.EventHandler(this.btnSaveOut_Click);
            // 
            // dgLogistic
            // 
            this.dgLogistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colName,
            this.colUnit,
            this.colDateEntry});
            this.dgLogistic.Location = new System.Drawing.Point(404, 12);
            this.dgLogistic.Name = "dgLogistic";
            this.dgLogistic.Size = new System.Drawing.Size(443, 196);
            this.dgLogistic.TabIndex = 15;
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
            // lboutcoming
            // 
            this.lboutcoming.AutoSize = true;
            this.lboutcoming.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboutcoming.Location = new System.Drawing.Point(44, 219);
            this.lboutcoming.Name = "lboutcoming";
            this.lboutcoming.Size = new System.Drawing.Size(86, 20);
            this.lboutcoming.TabIndex = 1;
            this.lboutcoming.Text = "Outcome Goods";
            // 
            // lbSisa
            // 
            this.lbSisa.AutoSize = true;
            this.lbSisa.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSisa.Location = new System.Drawing.Point(44, 311);
            this.lbSisa.Name = "lbSisa";
            this.lbSisa.Size = new System.Drawing.Size(92, 20);
            this.lbSisa.TabIndex = 2;
            this.lbSisa.Text = "Remaining Stock";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(44, 269);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(50, 20);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Date Out";
            // 
            // txtSisa
            // 
            this.txtSisa.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSisa.Location = new System.Drawing.Point(149, 308);
            this.txtSisa.Name = "txtSisa";
            this.txtSisa.Size = new System.Drawing.Size(163, 27);
            this.txtSisa.TabIndex = 10;
            this.txtSisa.TextChanged += new System.EventHandler(this.txtSisa_TextChanged);
            // 
            // dateTimeOut
            // 
            this.dateTimeOut.Location = new System.Drawing.Point(149, 268);
            this.dateTimeOut.Name = "dateTimeOut";
            this.dateTimeOut.Size = new System.Drawing.Size(163, 20);
            this.dateTimeOut.TabIndex = 12;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(43, 74);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 20);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Date Entry";
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit.Location = new System.Drawing.Point(43, 128);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(28, 20);
            this.lbUnit.TabIndex = 20;
            this.lbUnit.Text = "Unit";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(149, 21);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(163, 20);
            this.txtCode.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(149, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 22;
            // 
            // txtUnit
            // 
            this.txtUnit.Enabled = false;
            this.txtUnit.Location = new System.Drawing.Point(149, 128);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(163, 20);
            this.txtUnit.TabIndex = 23;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(43, 21);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(34, 20);
            this.lbCode.TabIndex = 19;
            this.lbCode.Text = "Code";
            // 
            // dateEntry
            // 
            this.dateEntry.Enabled = false;
            this.dateEntry.Location = new System.Drawing.Point(149, 175);
            this.dateEntry.Name = "dateEntry";
            this.dateEntry.Size = new System.Drawing.Size(163, 20);
            this.dateEntry.TabIndex = 26;
            // 
            // txtOutcome
            // 
            this.txtOutcome.Location = new System.Drawing.Point(149, 221);
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.Size = new System.Drawing.Size(163, 20);
            this.txtOutcome.TabIndex = 28;
            this.txtOutcome.TextChanged += new System.EventHandler(this.txtOutcome_TextChanged);
            // 
            // dgOutCome
            // 
            this.dgOutCome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOutCome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colOucome,
            this.colDateOut,
            this.colSisa});
            this.dgOutCome.Location = new System.Drawing.Point(404, 233);
            this.dgOutCome.Name = "dgOutCome";
            this.dgOutCome.Size = new System.Drawing.Size(443, 181);
            this.dgOutCome.TabIndex = 29;
            this.dgOutCome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOutCome_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "Code";
            this.colID.Name = "colID";
            // 
            // colOucome
            // 
            this.colOucome.HeaderText = "Outcome Goods";
            this.colOucome.Name = "colOucome";
            // 
            // colDateOut
            // 
            this.colDateOut.HeaderText = "Date Out";
            this.colDateOut.Name = "colDateOut";
            // 
            // colSisa
            // 
            this.colSisa.HeaderText = "Remaining Stock";
            this.colSisa.Name = "colSisa";
            // 
            // btnExitOut
            // 
            this.btnExitOut.BackgroundImage = global::LogisticData.Properties.Resources.backbuttoncircle_795591;
            this.btnExitOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitOut.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitOut.Location = new System.Drawing.Point(2, 370);
            this.btnExitOut.Name = "btnExitOut";
            this.btnExitOut.Size = new System.Drawing.Size(78, 53);
            this.btnExitOut.TabIndex = 14;
            this.btnExitOut.UseVisualStyleBackColor = true;
            this.btnExitOut.Click += new System.EventHandler(this.btnExitOut_Click);
            // 
            // OutcomeGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 426);
            this.Controls.Add(this.dgOutCome);
            this.Controls.Add(this.txtOutcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEntry);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.dgLogistic);
            this.Controls.Add(this.btnExitOut);
            this.Controls.Add(this.btnSaveOut);
            this.Controls.Add(this.dateTimeOut);
            this.Controls.Add(this.txtSisa);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbSisa);
            this.Controls.Add(this.lboutcoming);
            this.Name = "OutcomeGoods";
            this.Text = "OutcomeGoods";
            this.Load += new System.EventHandler(this.OutcomeGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLogistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutCome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveOut;
        private System.Windows.Forms.Button btnExitOut;
        private System.Windows.Forms.DataGridView dgLogistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateEntry;
        private System.Windows.Forms.Label lboutcoming;
        private System.Windows.Forms.Label lbSisa;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox txtSisa;
        private System.Windows.Forms.DateTimePicker dateTimeOut;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.DateTimePicker dateEntry;
        private System.Windows.Forms.TextBox txtOutcome;
        private System.Windows.Forms.DataGridView dgOutCome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOucome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSisa;
    }
}