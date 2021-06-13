
namespace View
{
    partial class MainForm
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
            this.dataGridGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridPassiveElements = new System.Windows.Forms.DataGridView();
            this.addObjectButton = new System.Windows.Forms.Button();
            this.deleteObjectButton = new System.Windows.Forms.Button();
            this.findObjectButton = new System.Windows.Forms.Button();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.dataGridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPassiveElements)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGroupBox
            // 
            this.dataGridGroupBox.Controls.Add(this.dataGridPassiveElements);
            this.dataGridGroupBox.Location = new System.Drawing.Point(12, 12);
            this.dataGridGroupBox.Name = "dataGridGroupBox";
            this.dataGridGroupBox.Size = new System.Drawing.Size(411, 177);
            this.dataGridGroupBox.TabIndex = 0;
            this.dataGridGroupBox.TabStop = false;
            this.dataGridGroupBox.Text = "Пассивные элементы электрической цепи";
            // 
            // dataGridPassiveElements
            // 
            this.dataGridPassiveElements.AllowUserToAddRows = false;
            this.dataGridPassiveElements.AllowUserToDeleteRows = false;
            this.dataGridPassiveElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPassiveElements.Location = new System.Drawing.Point(6, 19);
            this.dataGridPassiveElements.Name = "dataGridPassiveElements";
            this.dataGridPassiveElements.ReadOnly = true;
            this.dataGridPassiveElements.RowHeadersVisible = false;
            this.dataGridPassiveElements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPassiveElements.ShowEditingIcon = false;
            this.dataGridPassiveElements.Size = new System.Drawing.Size(399, 152);
            this.dataGridPassiveElements.TabIndex = 0;
            // 
            // addObjectButton
            // 
            this.addObjectButton.Location = new System.Drawing.Point(429, 31);
            this.addObjectButton.Name = "addObjectButton";
            this.addObjectButton.Size = new System.Drawing.Size(121, 23);
            this.addObjectButton.TabIndex = 1;
            this.addObjectButton.Text = "Добавить элемент";
            this.addObjectButton.UseVisualStyleBackColor = true;
            this.addObjectButton.Click += new System.EventHandler(this.AddObjectButtonClick);
            // 
            // deleteObjectButton
            // 
            this.deleteObjectButton.Location = new System.Drawing.Point(429, 60);
            this.deleteObjectButton.Name = "deleteObjectButton";
            this.deleteObjectButton.Size = new System.Drawing.Size(121, 23);
            this.deleteObjectButton.TabIndex = 2;
            this.deleteObjectButton.Text = "Удалить элемент";
            this.deleteObjectButton.UseVisualStyleBackColor = true;
            this.deleteObjectButton.Click += new System.EventHandler(this.DeleteObjectButtonClick);
            // 
            // findObjectButton
            // 
            this.findObjectButton.Location = new System.Drawing.Point(429, 89);
            this.findObjectButton.Name = "findObjectButton";
            this.findObjectButton.Size = new System.Drawing.Size(121, 23);
            this.findObjectButton.TabIndex = 3;
            this.findObjectButton.Text = "Найти элемент";
            this.findObjectButton.UseVisualStyleBackColor = true;
            this.findObjectButton.Click += new System.EventHandler(this.FindObjectButtonClick);
            // 
            // saveDataButton
            // 
            this.saveDataButton.Location = new System.Drawing.Point(429, 118);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(121, 23);
            this.saveDataButton.TabIndex = 4;
            this.saveDataButton.Text = "Сохранить данные";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.SaveDataButtonClick);
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(429, 147);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(121, 23);
            this.loadDataButton.TabIndex = 5;
            this.loadDataButton.Text = "Загрузить данные";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.LoadDataButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 199);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(this.findObjectButton);
            this.Controls.Add(this.deleteObjectButton);
            this.Controls.Add(this.addObjectButton);
            this.Controls.Add(this.dataGridGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Элементы цепи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.dataGridGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPassiveElements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dataGridGroupBox;
        private System.Windows.Forms.DataGridView dataGridPassiveElements;
        private System.Windows.Forms.Button addObjectButton;
        private System.Windows.Forms.Button deleteObjectButton;
        private System.Windows.Forms.Button findObjectButton;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Button loadDataButton;
    }
}

