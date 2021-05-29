
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
            this.realPartLabel = new System.Windows.Forms.Label();
            this.imaginaryPartLabel = new System.Windows.Forms.Label();
            this.realPartTextBox = new System.Windows.Forms.TextBox();
            this.imaginaryPartTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.complexPartsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(13, 13);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(76, 17);
            this.nameCheckBox.TabIndex = 0;
            this.nameCheckBox.Text = "Название";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            this.nameCheckBox.CheckedChanged += new System.EventHandler(this.nameCheckBox_CheckedChanged);
            // 
            // frequencyCheckBox
            // 
            this.frequencyCheckBox.AutoSize = true;
            this.frequencyCheckBox.Location = new System.Drawing.Point(13, 37);
            this.frequencyCheckBox.Name = "frequencyCheckBox";
            this.frequencyCheckBox.Size = new System.Drawing.Size(68, 17);
            this.frequencyCheckBox.TabIndex = 1;
            this.frequencyCheckBox.Text = "Частота";
            this.frequencyCheckBox.UseVisualStyleBackColor = true;
            this.frequencyCheckBox.CheckedChanged += new System.EventHandler(this.frequencyCheckBox_CheckedChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(99, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(135, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.Location = new System.Drawing.Point(99, 34);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.Size = new System.Drawing.Size(66, 20);
            this.frequencyTextBox.TabIndex = 3;
            // 
            // impedanceCheckBox
            // 
            this.impedanceCheckBox.AutoSize = true;
            this.impedanceCheckBox.Location = new System.Drawing.Point(13, 60);
            this.impedanceCheckBox.Name = "impedanceCheckBox";
            this.impedanceCheckBox.Size = new System.Drawing.Size(78, 17);
            this.impedanceCheckBox.TabIndex = 4;
            this.impedanceCheckBox.Text = "Импеданс";
            this.impedanceCheckBox.UseVisualStyleBackColor = true;
            this.impedanceCheckBox.CheckedChanged += new System.EventHandler(this.impedanceChechBox_CheckedChanged);
            // 
            // complexPartsGroupBox
            // 
            this.complexPartsGroupBox.Controls.Add(this.imaginaryPartTextBox);
            this.complexPartsGroupBox.Controls.Add(this.realPartTextBox);
            this.complexPartsGroupBox.Controls.Add(this.imaginaryPartLabel);
            this.complexPartsGroupBox.Controls.Add(this.realPartLabel);
            this.complexPartsGroupBox.Location = new System.Drawing.Point(13, 85);
            this.complexPartsGroupBox.Name = "complexPartsGroupBox";
            this.complexPartsGroupBox.Size = new System.Drawing.Size(221, 72);
            this.complexPartsGroupBox.TabIndex = 5;
            this.complexPartsGroupBox.TabStop = false;
            this.complexPartsGroupBox.Text = "Комплексные составляющие";
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
            // imaginaryPartLabel
            // 
            this.imaginaryPartLabel.AutoSize = true;
            this.imaginaryPartLabel.Location = new System.Drawing.Point(6, 48);
            this.imaginaryPartLabel.Name = "imaginaryPartLabel";
            this.imaginaryPartLabel.Size = new System.Drawing.Size(48, 13);
            this.imaginaryPartLabel.TabIndex = 1;
            this.imaginaryPartLabel.Text = "Мнимая";
            // 
            // realPartTextBox
            // 
            this.realPartTextBox.Location = new System.Drawing.Point(115, 19);
            this.realPartTextBox.Name = "realPartTextBox";
            this.realPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.realPartTextBox.TabIndex = 2;
            // 
            // imaginaryPartTextBox
            // 
            this.imaginaryPartTextBox.Location = new System.Drawing.Point(115, 45);
            this.imaginaryPartTextBox.Name = "imaginaryPartTextBox";
            this.imaginaryPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.imaginaryPartTextBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(159, 163);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Закрыть";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(78, 163);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // FindObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 194);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.complexPartsGroupBox);
            this.Controls.Add(this.impedanceCheckBox);
            this.Controls.Add(this.frequencyTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.frequencyCheckBox);
            this.Controls.Add(this.nameCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FindObjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск объекта";
            this.complexPartsGroupBox.ResumeLayout(false);
            this.complexPartsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button OKButton;
    }
}