namespace ecoc_bookstore
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_openXML = new System.Windows.Forms.Button();
            this.button_saveXML = new System.Windows.Forms.Button();
            this.button_reportHTML = new System.Windows.Forms.Button();
            this.button_deleteEntry = new System.Windows.Forms.Button();
            this.button_addEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.Category,
            this.Price,
            this.Year});
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 459);
            this.dataGridView1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.HeaderText = "Книга";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Width = 125;
            // 
            // button_openXML
            // 
            this.button_openXML.Location = new System.Drawing.Point(12, 13);
            this.button_openXML.Name = "button_openXML";
            this.button_openXML.Size = new System.Drawing.Size(138, 42);
            this.button_openXML.TabIndex = 1;
            this.button_openXML.Text = "Открыть XML";
            this.button_openXML.UseVisualStyleBackColor = true;
            this.button_openXML.Click += new System.EventHandler(this.button_openXML_Click);
            // 
            // button_saveXML
            // 
            this.button_saveXML.Location = new System.Drawing.Point(176, 13);
            this.button_saveXML.Name = "button_saveXML";
            this.button_saveXML.Size = new System.Drawing.Size(157, 42);
            this.button_saveXML.TabIndex = 2;
            this.button_saveXML.Text = "Сохранить XML";
            this.button_saveXML.UseVisualStyleBackColor = true;
            this.button_saveXML.Click += new System.EventHandler(this.button_saveXML_Click);
            // 
            // button_reportHTML
            // 
            this.button_reportHTML.Location = new System.Drawing.Point(947, 13);
            this.button_reportHTML.Name = "button_reportHTML";
            this.button_reportHTML.Size = new System.Drawing.Size(133, 42);
            this.button_reportHTML.TabIndex = 3;
            this.button_reportHTML.Text = "Отчет в HTML";
            this.button_reportHTML.UseVisualStyleBackColor = true;
            this.button_reportHTML.Click += new System.EventHandler(this.button_reportHTML_Click);
            // 
            // button_deleteEntry
            // 
            this.button_deleteEntry.Location = new System.Drawing.Point(3, 536);
            this.button_deleteEntry.Name = "button_deleteEntry";
            this.button_deleteEntry.Size = new System.Drawing.Size(201, 37);
            this.button_deleteEntry.TabIndex = 4;
            this.button_deleteEntry.Text = "Удалить запись";
            this.button_deleteEntry.UseVisualStyleBackColor = true;
            this.button_deleteEntry.Click += new System.EventHandler(this.button_deleteEntry_Click);
            // 
            // button_addEntry
            // 
            this.button_addEntry.Location = new System.Drawing.Point(228, 536);
            this.button_addEntry.Name = "button_addEntry";
            this.button_addEntry.Size = new System.Drawing.Size(176, 37);
            this.button_addEntry.TabIndex = 5;
            this.button_addEntry.Text = "Добавить запись";
            this.button_addEntry.UseVisualStyleBackColor = true;
            this.button_addEntry.Click += new System.EventHandler(this.button_addEntry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1144, 607);
            this.Controls.Add(this.button_addEntry);
            this.Controls.Add(this.button_deleteEntry);
            this.Controls.Add(this.button_reportHTML);
            this.Controls.Add(this.button_saveXML);
            this.Controls.Add(this.button_openXML);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Bookstore";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_openXML;
        private System.Windows.Forms.Button button_saveXML;
        private System.Windows.Forms.Button button_reportHTML;
        private System.Windows.Forms.Button button_deleteEntry;
        private System.Windows.Forms.Button button_addEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
    }
}

