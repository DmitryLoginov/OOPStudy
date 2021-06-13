
namespace View
{
    partial class FindObjectForm
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
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.frequencyCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.impedanceCheckBox = new System.Windows.Forms.CheckBox();
            this.complexPartsGroupBox = new System.Windows.Forms.GroupBox();
            this.imaginaryPartTextBox = new System.Windows.Forms.TextBox();
            this.realPartTextBox = new System.Windows.Forms.TextBox();
            this.imaginaryPartLabel = new System.Windows.Forms.Label();
            this.realPartLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.searchResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridSearchResults = new System.Windows.Forms.DataGridView();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.resetFilterButton = new System.Windows.Forms.Button();
            this.showResultsButton = new System.Windows.Forms.Button();
            this.complexPartsGroupBox.SuspendLayout();
            this.searchResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchResults)).BeginInit();
            this.filterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(6, 19);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(76, 17);
            this.nameCheckBox.TabIndex = 0;
            this.nameCheckBox.Text = "Название";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            this.nameCheckBox.CheckedChanged += new System.EventHandler(this.NameCheckBoxCheckedChanged);
            // 
            // frequencyCheckBox
            // 
            this.frequencyCheckBox.AutoSize = true;
            this.frequencyCheckBox.Location = new System.Drawing.Point(6, 43);
            this.frequencyCheckBox.Name = "frequencyCheckBox";
            this.frequencyCheckBox.Size = new System.Drawing.Size(68, 17);
            this.frequencyCheckBox.TabIndex = 1;
            this.frequencyCheckBox.Text = "Частота";
            this.frequencyCheckBox.UseVisualStyleBackColor = true;
            this.frequencyCheckBox.CheckedChanged += new System.EventHandler(this.FrequencyCheckBoxCheckedChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(92, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.Location = new System.Drawing.Point(92, 40);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.Size = new System.Drawing.Size(66, 20);
            this.frequencyTextBox.TabIndex = 3;
            // 
            // impedanceCheckBox
            // 
            this.impedanceCheckBox.AutoSize = true;
            this.impedanceCheckBox.Location = new System.Drawing.Point(6, 66);
            this.impedanceCheckBox.Name = "impedanceCheckBox";
            this.impedanceCheckBox.Size = new System.Drawing.Size(78, 17);
            this.impedanceCheckBox.TabIndex = 4;
            this.impedanceCheckBox.Text = "Импеданс";
            this.impedanceCheckBox.UseVisualStyleBackColor = true;
            this.impedanceCheckBox.CheckedChanged += new System.EventHandler(this.ImpedanceChechBoxCheckedChanged);
            // 
            // complexPartsGroupBox
            // 
            this.complexPartsGroupBox.Controls.Add(this.imaginaryPartTextBox);
            this.complexPartsGroupBox.Controls.Add(this.realPartTextBox);
            this.complexPartsGroupBox.Controls.Add(this.imaginaryPartLabel);
            this.complexPartsGroupBox.Controls.Add(this.realPartLabel);
            this.complexPartsGroupBox.Location = new System.Drawing.Point(6, 91);
            this.complexPartsGroupBox.Name = "complexPartsGroupBox";
            this.complexPartsGroupBox.Size = new System.Drawing.Size(211, 72);
            this.complexPartsGroupBox.TabIndex = 5;
            this.complexPartsGroupBox.TabStop = false;
            this.complexPartsGroupBox.Text = "Комплексные составляющие";
            // 
            // imaginaryPartTextBox
            // 
            this.imaginaryPartTextBox.Location = new System.Drawing.Point(104, 45);
            this.imaginaryPartTextBox.Name = "imaginaryPartTextBox";
            this.imaginaryPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.imaginaryPartTextBox.TabIndex = 3;
            // 
            // realPartTextBox
            // 
            this.realPartTextBox.Location = new System.Drawing.Point(104, 19);
            this.realPartTextBox.Name = "realPartTextBox";
            this.realPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.realPartTextBox.TabIndex = 2;
            // 
            // imaginaryPartLabel
            // 
            this.imaginaryPartLabel.AutoSize = true;
            this.imaginaryPartLabel.Location = new System.Drawing.Point(6, 48);
            this.imaginaryPartLabel.Name = "imaginaryPartLabel";
            this.imaginaryPartLabel.Size = new System.Drawing.Size(48, 13);
            this.imaginaryPartLabel.TabIndex = 1;
            this.imaginaryPartLabel.Text = "Мнимая";
            // 
            // realPartLabel
            // 
            this.realPartLabel.AutoSize = true;
            this.realPartLabel.Location = new System.Drawing.Point(6, 22);
            this.realPartLabel.Name = "realPartLabel";
            this.realPartLabel.Size = new System.Drawing.Size(92, 13);
            this.realPartLabel.TabIndex = 0;
            this.realPartLabel.Text = "Действительная";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(557, 187);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Закрыть";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // searchResultsGroupBox
            // 
            this.searchResultsGroupBox.Controls.Add(this.dataGridSearchResults);
            this.searchResultsGroupBox.Location = new System.Drawing.Point(242, 12);
            this.searchResultsGroupBox.Name = "searchResultsGroupBox";
            this.searchResultsGroupBox.Size = new System.Drawing.Size(390, 169);
            this.searchResultsGroupBox.TabIndex = 8;
            this.searchResultsGroupBox.TabStop = false;
            this.searchResultsGroupBox.Text = "Результаты поиска";
            // 
            // dataGridSearchResults
            // 
            this.dataGridSearchResults.AllowUserToAddRows = false;
            this.dataGridSearchResults.AllowUserToDeleteRows = false;
            this.dataGridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchResults.Location = new System.Drawing.Point(7, 20);
            this.dataGridSearchResults.Name = "dataGridSearchResults";
            this.dataGridSearchResults.ReadOnly = true;
            this.dataGridSearchResults.RowHeadersVisible = false;
            this.dataGridSearchResults.Size = new System.Drawing.Size(377, 138);
            this.dataGridSearchResults.TabIndex = 0;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.nameTextBox);
            this.filterGroupBox.Controls.Add(this.nameCheckBox);
            this.filterGroupBox.Controls.Add(this.frequencyCheckBox);
            this.filterGroupBox.Controls.Add(this.complexPartsGroupBox);
            this.filterGroupBox.Controls.Add(this.frequencyTextBox);
            this.filterGroupBox.Controls.Add(this.impedanceCheckBox);
            this.filterGroupBox.Location = new System.Drawing.Point(12, 12);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(224, 169);
            this.filterGroupBox.TabIndex = 9;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фильтр";
            // 
            // resetFilterButton
            // 
            this.resetFilterButton.Location = new System.Drawing.Point(476, 187);
            this.resetFilterButton.Name = "resetFilterButton";
            this.resetFilterButton.Size = new System.Drawing.Size(75, 23);
            this.resetFilterButton.TabIndex = 10;
            this.resetFilterButton.Text = "Сбросить";
            this.resetFilterButton.UseVisualStyleBackColor = true;
            this.resetFilterButton.Click += new System.EventHandler(this.ResetFilterButtonClick);
            // 
            // showResultsButton
            // 
            this.showResultsButton.Location = new System.Drawing.Point(395, 187);
            this.showResultsButton.Name = "showResultsButton";
            this.showResultsButton.Size = new System.Drawing.Size(75, 23);
            this.showResultsButton.TabIndex = 11;
            this.showResultsButton.Text = "Показать";
            this.showResultsButton.UseVisualStyleBackColor = true;
            this.showResultsButton.Click += new System.EventHandler(this.ShowResultsButtonClick);
            // 
            // FindObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 223);
            this.Controls.Add(this.showResultsButton);
            this.Controls.Add(this.resetFilterButton);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.searchResultsGroupBox);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FindObjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск объекта";
            this.complexPartsGroupBox.ResumeLayout(false);
            this.complexPartsGroupBox.PerformLayout();
            this.searchResultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchResults)).EndInit();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.CheckBox frequencyCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.CheckBox impedanceCheckBox;
        private System.Windows.Forms.GroupBox complexPartsGroupBox;
        private System.Windows.Forms.TextBox imaginaryPartTextBox;
        private System.Windows.Forms.TextBox realPartTextBox;
        private System.Windows.Forms.Label imaginaryPartLabel;
        private System.Windows.Forms.Label realPartLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox searchResultsGroupBox;
        private System.Windows.Forms.DataGridView dataGridSearchResults;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Button resetFilterButton;
        private System.Windows.Forms.Button showResultsButton;
    }
}