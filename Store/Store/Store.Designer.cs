namespace StoreOfGoods
{
    partial class Store
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PlaceTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.PriceTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.NumbTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.IDTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SumStore = new System.Windows.Forms.Button();
            this.SoldGoods = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.SearchInfo = new System.Windows.Forms.Button();
            this.DeleteInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox2 = new System.Windows.Forms.TextBox();
            this.AddInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.IdTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.SumSoldGoods = new System.Windows.Forms.Button();
            this.SumButton1 = new System.Windows.Forms.Button();
            this.SearchSoldGoods = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.IdTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.SumButton2 = new System.Windows.Forms.Button();
            this.SumDelGoods = new System.Windows.Forms.Button();
            this.SearchDelInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afqkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAllGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseStore = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(35, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 474);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.PlaceTextBox5);
            this.tabPage1.Controls.Add(this.PriceTextBox4);
            this.tabPage1.Controls.Add(this.NumbTextBox3);
            this.tabPage1.Controls.Add(this.IDTextBox1);
            this.tabPage1.Controls.Add(this.SumStore);
            this.tabPage1.Controls.Add(this.SoldGoods);
            this.tabPage1.Controls.Add(this.SumButton);
            this.tabPage1.Controls.Add(this.SearchInfo);
            this.tabPage1.Controls.Add(this.DeleteInfo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.NameTextBox2);
            this.tabPage1.Controls.Add(this.AddInfo);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товар на складе";
            // 
            // PlaceTextBox5
            // 
            this.PlaceTextBox5.Location = new System.Drawing.Point(452, 310);
            this.PlaceTextBox5.Mask = "L00";
            this.PlaceTextBox5.Name = "PlaceTextBox5";
            this.PlaceTextBox5.Size = new System.Drawing.Size(100, 20);
            this.PlaceTextBox5.TabIndex = 35;
            // 
            // PriceTextBox4
            // 
            this.PriceTextBox4.Location = new System.Drawing.Point(346, 310);
            this.PriceTextBox4.Mask = "00000000";
            this.PriceTextBox4.Name = "PriceTextBox4";
            this.PriceTextBox4.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox4.TabIndex = 34;
            // 
            // NumbTextBox3
            // 
            this.NumbTextBox3.Location = new System.Drawing.Point(240, 310);
            this.NumbTextBox3.Mask = "00000000000000";
            this.NumbTextBox3.Name = "NumbTextBox3";
            this.NumbTextBox3.Size = new System.Drawing.Size(100, 20);
            this.NumbTextBox3.TabIndex = 33;
            // 
            // IDTextBox1
            // 
            this.IDTextBox1.Location = new System.Drawing.Point(28, 310);
            this.IDTextBox1.Mask = "0000";
            this.IDTextBox1.Name = "IDTextBox1";
            this.IDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox1.TabIndex = 32;
            // 
            // SumStore
            // 
            this.SumStore.Location = new System.Drawing.Point(27, 400);
            this.SumStore.Name = "SumStore";
            this.SumStore.Size = new System.Drawing.Size(100, 32);
            this.SumStore.TabIndex = 31;
            this.SumStore.Text = "Сумма склада";
            this.SumStore.UseVisualStyleBackColor = true;
            this.SumStore.Click += new System.EventHandler(this.SumStore_Click);
            // 
            // SoldGoods
            // 
            this.SoldGoods.Location = new System.Drawing.Point(452, 349);
            this.SoldGoods.Name = "SoldGoods";
            this.SoldGoods.Size = new System.Drawing.Size(100, 32);
            this.SoldGoods.TabIndex = 30;
            this.SoldGoods.Text = "Списать";
            this.SoldGoods.UseVisualStyleBackColor = true;
            this.SoldGoods.Click += new System.EventHandler(this.SoldGoods_Click);
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(346, 349);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(100, 32);
            this.SumButton.TabIndex = 29;
            this.SumButton.Text = "Сумма";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // SearchInfo
            // 
            this.SearchInfo.Location = new System.Drawing.Point(240, 349);
            this.SearchInfo.Name = "SearchInfo";
            this.SearchInfo.Size = new System.Drawing.Size(100, 32);
            this.SearchInfo.TabIndex = 28;
            this.SearchInfo.Text = "Поиск";
            this.SearchInfo.UseVisualStyleBackColor = true;
            this.SearchInfo.Click += new System.EventHandler(this.SearchInfo_Click);
            // 
            // DeleteInfo
            // 
            this.DeleteInfo.Location = new System.Drawing.Point(133, 349);
            this.DeleteInfo.Name = "DeleteInfo";
            this.DeleteInfo.Size = new System.Drawing.Size(100, 32);
            this.DeleteInfo.TabIndex = 27;
            this.DeleteInfo.Text = "Удалить";
            this.DeleteInfo.UseVisualStyleBackColor = true;
            this.DeleteInfo.Click += new System.EventHandler(this.DeleteInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Место";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Артикул";
            // 
            // NameTextBox2
            // 
            this.NameTextBox2.Location = new System.Drawing.Point(134, 310);
            this.NameTextBox2.Name = "NameTextBox2";
            this.NameTextBox2.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox2.TabIndex = 18;
            // 
            // AddInfo
            // 
            this.AddInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddInfo.Location = new System.Drawing.Point(27, 349);
            this.AddInfo.Name = "AddInfo";
            this.AddInfo.Size = new System.Drawing.Size(100, 32);
            this.AddInfo.TabIndex = 16;
            this.AddInfo.Text = "Добавить";
            this.AddInfo.UseVisualStyleBackColor = true;
            this.AddInfo.Click += new System.EventHandler(this.AddInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 244);
            this.dataGridView1.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage2.Controls.Add(this.IdTextBox6);
            this.tabPage2.Controls.Add(this.SumSoldGoods);
            this.tabPage2.Controls.Add(this.SumButton1);
            this.tabPage2.Controls.Add(this.SearchSoldGoods);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Списанный товар";
            // 
            // IdTextBox6
            // 
            this.IdTextBox6.Location = new System.Drawing.Point(29, 331);
            this.IdTextBox6.Mask = "0000";
            this.IdTextBox6.Name = "IdTextBox6";
            this.IdTextBox6.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox6.TabIndex = 6;
            // 
            // SumSoldGoods
            // 
            this.SumSoldGoods.Location = new System.Drawing.Point(263, 375);
            this.SumSoldGoods.Name = "SumSoldGoods";
            this.SumSoldGoods.Size = new System.Drawing.Size(214, 23);
            this.SumSoldGoods.TabIndex = 5;
            this.SumSoldGoods.Text = "Сумма списанных товаров";
            this.SumSoldGoods.UseVisualStyleBackColor = true;
            this.SumSoldGoods.Click += new System.EventHandler(this.SumSoldGoods_Click);
            // 
            // SumButton1
            // 
            this.SumButton1.Location = new System.Drawing.Point(153, 375);
            this.SumButton1.Name = "SumButton1";
            this.SumButton1.Size = new System.Drawing.Size(90, 23);
            this.SumButton1.TabIndex = 4;
            this.SumButton1.Text = "Сумма";
            this.SumButton1.UseVisualStyleBackColor = true;
            this.SumButton1.Click += new System.EventHandler(this.SumButton1_Click);
            // 
            // SearchSoldGoods
            // 
            this.SearchSoldGoods.Location = new System.Drawing.Point(29, 375);
            this.SearchSoldGoods.Name = "SearchSoldGoods";
            this.SearchSoldGoods.Size = new System.Drawing.Size(98, 23);
            this.SearchSoldGoods.TabIndex = 3;
            this.SearchSoldGoods.Text = "Поиск";
            this.SearchSoldGoods.UseVisualStyleBackColor = true;
            this.SearchSoldGoods.Click += new System.EventHandler(this.SearchSoldGoods_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Артикул";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(538, 246);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage3.Controls.Add(this.IdTextBox7);
            this.tabPage3.Controls.Add(this.SumButton2);
            this.tabPage3.Controls.Add(this.SumDelGoods);
            this.tabPage3.Controls.Add(this.SearchDelInfo);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(600, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Бракованный товар";
            // 
            // IdTextBox7
            // 
            this.IdTextBox7.Location = new System.Drawing.Point(34, 339);
            this.IdTextBox7.Mask = "0000";
            this.IdTextBox7.Name = "IdTextBox7";
            this.IdTextBox7.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox7.TabIndex = 8;
            // 
            // SumButton2
            // 
            this.SumButton2.Location = new System.Drawing.Point(158, 382);
            this.SumButton2.Name = "SumButton2";
            this.SumButton2.Size = new System.Drawing.Size(90, 23);
            this.SumButton2.TabIndex = 7;
            this.SumButton2.Text = "Сумма";
            this.SumButton2.UseVisualStyleBackColor = true;
            this.SumButton2.Click += new System.EventHandler(this.SumButton2_Click);
            // 
            // SumDelGoods
            // 
            this.SumDelGoods.Location = new System.Drawing.Point(284, 382);
            this.SumDelGoods.Name = "SumDelGoods";
            this.SumDelGoods.Size = new System.Drawing.Size(235, 23);
            this.SumDelGoods.TabIndex = 6;
            this.SumDelGoods.Text = "Сумма бракованных товаров";
            this.SumDelGoods.UseVisualStyleBackColor = true;
            this.SumDelGoods.Click += new System.EventHandler(this.SumDelGoods_Click);
            // 
            // SearchDelInfo
            // 
            this.SearchDelInfo.Location = new System.Drawing.Point(34, 382);
            this.SearchDelInfo.Name = "SearchDelInfo";
            this.SearchDelInfo.Size = new System.Drawing.Size(98, 23);
            this.SearchDelInfo.TabIndex = 5;
            this.SearchDelInfo.Text = "Поиск";
            this.SearchDelInfo.UseVisualStyleBackColor = true;
            this.SearchDelInfo.Click += new System.EventHandler(this.SearchDelInfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Артикул";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(34, 22);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(531, 260);
            this.dataGridView3.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afqkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afqkToolStripMenuItem
            // 
            this.afqkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAllGoods,
            this.CloseStore});
            this.afqkToolStripMenuItem.Name = "afqkToolStripMenuItem";
            this.afqkToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.afqkToolStripMenuItem.Text = "Файл";
            // 
            // ShowAllGoods
            // 
            this.ShowAllGoods.Name = "ShowAllGoods";
            this.ShowAllGoods.Size = new System.Drawing.Size(235, 22);
            this.ShowAllGoods.Text = "Показать все объекты склада";
            this.ShowAllGoods.Click += new System.EventHandler(this.ShowAllGoods_Click);
            // 
            // CloseStore
            // 
            this.CloseStore.Name = "CloseStore";
            this.CloseStore.Size = new System.Drawing.Size(235, 22);
            this.CloseStore.Text = "Выход";
            this.CloseStore.Click += new System.EventHandler(this.CloseStore_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.фон_морская_волна;
            this.ClientSize = new System.Drawing.Size(678, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Store";
            this.Text = "Склад";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Store_FormClosing);
            this.Load += new System.EventHandler(this.Store_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button SearchInfo;
        private System.Windows.Forms.Button DeleteInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox2;
        private System.Windows.Forms.Button AddInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button SoldGoods;
        private System.Windows.Forms.Button SumStore;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SumSoldGoods;
        private System.Windows.Forms.Button SumButton1;
        private System.Windows.Forms.Button SearchSoldGoods;
        private System.Windows.Forms.Button SumButton2;
        private System.Windows.Forms.Button SumDelGoods;
        private System.Windows.Forms.Button SearchDelInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.MaskedTextBox IDTextBox1;
        private System.Windows.Forms.MaskedTextBox NumbTextBox3;
        private System.Windows.Forms.MaskedTextBox PriceTextBox4;
        private System.Windows.Forms.MaskedTextBox PlaceTextBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afqkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowAllGoods;
        private System.Windows.Forms.ToolStripMenuItem CloseStore;
        private System.Windows.Forms.MaskedTextBox IdTextBox6;
        private System.Windows.Forms.MaskedTextBox IdTextBox7;

    }
}

