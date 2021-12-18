namespace TestingLINQ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddDrugDiller = new System.Windows.Forms.Button();
            this.PhoneNumb = new System.Windows.Forms.TextBox();
            this.sales = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.MaskedTextBox();
            this.disc = new System.Windows.Forms.MaskedTextBox();
            this.adress = new System.Windows.Forms.MaskedTextBox();
            this.DataList = new System.Windows.Forms.ListBox();
            this.AddDiller = new System.Windows.Forms.TextBox();
            this.AddData = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.DillerInfo = new System.Windows.Forms.ListBox();
            this.SearchDiller = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.DillersInfoList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DillersInfoList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDrugDiller
            // 
            this.AddDrugDiller.BackColor = System.Drawing.Color.Thistle;
            this.AddDrugDiller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDrugDiller.ForeColor = System.Drawing.Color.Black;
            this.AddDrugDiller.Location = new System.Drawing.Point(25, 12);
            this.AddDrugDiller.Name = "AddDrugDiller";
            this.AddDrugDiller.Size = new System.Drawing.Size(117, 52);
            this.AddDrugDiller.TabIndex = 3;
            this.AddDrugDiller.Text = "Добавить drug-дилера";
            this.AddDrugDiller.UseVisualStyleBackColor = false;
            this.AddDrugDiller.Click += new System.EventHandler(this.AddDrugDiller_Click_1);
            // 
            // PhoneNumb
            // 
            this.PhoneNumb.Location = new System.Drawing.Point(446, 166);
            this.PhoneNumb.Name = "PhoneNumb";
            this.PhoneNumb.Size = new System.Drawing.Size(226, 26);
            this.PhoneNumb.TabIndex = 5;
            this.PhoneNumb.Visible = false;
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.Lavender;
            this.sales.Location = new System.Drawing.Point(446, 305);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(180, 26);
            this.sales.TabIndex = 7;
            // 
            // discount
            // 
            this.discount.BackColor = System.Drawing.Color.Lavender;
            this.discount.Location = new System.Drawing.Point(446, 242);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(198, 26);
            this.discount.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Адрес:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Телефон:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Объем закупок:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Объем продаж:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Льготная скидка:";
            // 
            // phonenum
            // 
            this.phonenum.BackColor = System.Drawing.Color.Lavender;
            this.phonenum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonenum.Location = new System.Drawing.Point(446, 166);
            this.phonenum.Mask = "(999) 000-0000";
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(226, 26);
            this.phonenum.TabIndex = 14;
            // 
            // disc
            // 
            this.disc.BackColor = System.Drawing.Color.Lavender;
            this.disc.BeepOnError = true;
            this.disc.Location = new System.Drawing.Point(446, 376);
            this.disc.Mask = "000.0%";
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(94, 26);
            this.disc.TabIndex = 15;
            this.disc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DiscountVal_MaskInputRejected);
            // 
            // adress
            // 
            this.adress.BackColor = System.Drawing.Color.Lavender;
            this.adress.Location = new System.Drawing.Point(446, 100);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(306, 26);
            this.adress.TabIndex = 16;
            // 
            // DataList
            // 
            this.DataList.BackColor = System.Drawing.Color.Lavender;
            this.DataList.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DataList.FormattingEnabled = true;
            this.DataList.HorizontalScrollbar = true;
            this.DataList.ItemHeight = 20;
            this.DataList.Location = new System.Drawing.Point(25, 94);
            this.DataList.Name = "DataList";
            this.DataList.ScrollAlwaysVisible = true;
            this.DataList.Size = new System.Drawing.Size(400, 304);
            this.DataList.Sorted = true;
            this.DataList.TabIndex = 17;
            // 
            // AddDiller
            // 
            this.AddDiller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AddDiller.BackColor = System.Drawing.Color.Lavender;
            this.AddDiller.Location = new System.Drawing.Point(164, 37);
            this.AddDiller.Name = "AddDiller";
            this.AddDiller.Size = new System.Drawing.Size(293, 26);
            this.AddDiller.TabIndex = 18;
            // 
            // AddData
            // 
            this.AddData.BackColor = System.Drawing.Color.Thistle;
            this.AddData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddData.Location = new System.Drawing.Point(507, 12);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(176, 52);
            this.AddData.TabIndex = 19;
            this.AddData.Text = "Добавить данные drug-дилера";
            this.AddData.UseVisualStyleBackColor = false;
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Thistle;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Location = new System.Drawing.Point(764, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(150, 52);
            this.Search.TabIndex = 20;
            this.Search.Text = "Найти drug-дилера";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click_1);
            // 
            // DillerInfo
            // 
            this.DillerInfo.BackColor = System.Drawing.Color.Lavender;
            this.DillerInfo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DillerInfo.FormattingEnabled = true;
            this.DillerInfo.ItemHeight = 20;
            this.DillerInfo.Location = new System.Drawing.Point(764, 94);
            this.DillerInfo.Name = "DillerInfo";
            this.DillerInfo.Size = new System.Drawing.Size(361, 304);
            this.DillerInfo.TabIndex = 21;
            // 
            // SearchDiller
            // 
            this.SearchDiller.BackColor = System.Drawing.Color.Lavender;
            this.SearchDiller.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SearchDiller.Location = new System.Drawing.Point(941, 38);
            this.SearchDiller.Name = "SearchDiller";
            this.SearchDiller.Size = new System.Drawing.Size(184, 26);
            this.SearchDiller.TabIndex = 22;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Lavender;
            this.clear.Location = new System.Drawing.Point(1166, 94);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(244, 26);
            this.clear.TabIndex = 23;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Thistle;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Location = new System.Drawing.Point(1166, 12);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(183, 54);
            this.Delete.TabIndex = 24;
            this.Delete.Text = "Удалить drug-дилера";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DillersInfoList
            // 
            this.DillersInfoList.AllowUserToOrderColumns = true;
            this.DillersInfoList.BackgroundColor = System.Drawing.Color.Lavender;
            this.DillersInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DillersInfoList.Location = new System.Drawing.Point(29, 416);
            this.DillersInfoList.Name = "DillersInfoList";
            this.DillersInfoList.RowHeadersWidth = 62;
            this.DillersInfoList.RowTemplate.Height = 28;
            this.DillersInfoList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DillersInfoList.Size = new System.Drawing.Size(1373, 269);
            this.DillersInfoList.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1422, 697);
            this.Controls.Add(this.DillersInfoList);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.SearchDiller);
            this.Controls.Add(this.DillerInfo);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.AddData);
            this.Controls.Add(this.AddDiller);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.disc);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.PhoneNumb);
            this.Controls.Add(this.AddDrugDiller);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DillersInfoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddDrugDiller;
        private System.Windows.Forms.TextBox PhoneNumb;
        private System.Windows.Forms.TextBox sales;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox phonenum;
        private System.Windows.Forms.MaskedTextBox disc;
        private System.Windows.Forms.MaskedTextBox adress;
        private System.Windows.Forms.ListBox DataList;
        private System.Windows.Forms.TextBox AddDiller;
        private System.Windows.Forms.Button AddData;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListBox DillerInfo;
        private System.Windows.Forms.TextBox SearchDiller;
        private System.Windows.Forms.TextBox clear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView DillersInfoList;
    }
}

