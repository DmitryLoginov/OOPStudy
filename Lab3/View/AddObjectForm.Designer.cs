
namespace View
{
    partial class AddObjectForm
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
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.objectTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.objectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.paramsGroupBox = new System.Windows.Forms.GroupBox();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.objectParamLabel = new System.Windows.Forms.Label();
            this.objectParamTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.nameGroupBox.SuspendLayout();
            this.objectTypeGroupBox.SuspendLayout();
            this.paramsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.nameTextBox);
            this.nameGroupBox.Location = new System.Drawing.Point(12, 12);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(203, 47);
            this.nameGroupBox.TabIndex = 0;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Название элемента";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(7, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(190, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // objectTypeGroupBox
            // 
            this.objectTypeGroupBox.Controls.Add(this.objectTypeComboBox);
            this.objectTypeGroupBox.Location = new System.Drawing.Point(12, 65);
            this.objectTypeGroupBox.Name = "objectTypeGroupBox";
            this.objectTypeGroupBox.Size = new System.Drawing.Size(203, 47);
            this.objectTypeGroupBox.TabIndex = 2;
            this.objectTypeGroupBox.TabStop = false;
            this.objectTypeGroupBox.Text = "Тип элемента";
            // 
            // objectTypeComboBox
            // 
            this.objectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objectTypeComboBox.FormattingEnabled = true;
            this.objectTypeComboBox.Location = new System.Drawing.Point(6, 19);
            this.objectTypeComboBox.Name = "objectTypeComboBox";
            this.objectTypeComboBox.Size = new System.Drawing.Size(191, 21);
            this.objectTypeComboBox.TabIndex = 0;
            this.objectTypeComboBox.SelectedValueChanged += new System.EventHandler(this.ObjectTypeComboBoxSelectedValueChanged);
            // 
            // paramsGroupBox
            // 
            this.paramsGroupBox.Controls.Add(this.frequencyTextBox);
            this.paramsGroupBox.Controls.Add(this.frequencyLabel);
            this.paramsGroupBox.Controls.Add(this.objectParamLabel);
            this.paramsGroupBox.Controls.Add(this.objectParamTextBox);
            this.paramsGroupBox.Location = new System.Drawing.Point(12, 118);
            this.paramsGroupBox.Name = "paramsGroupBox";
            this.paramsGroupBox.Size = new System.Drawing.Size(203, 74);
            this.paramsGroupBox.TabIndex = 3;
            this.paramsGroupBox.TabStop = false;
            this.paramsGroupBox.Text = "Параметры";
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.Location = new System.Drawing.Point(122, 47);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.Size = new System.Drawing.Size(75, 20);
            this.frequencyTextBox.TabIndex = 3;
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(6, 50);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(93, 13);
            this.frequencyLabel.TabIndex = 2;
            this.frequencyLabel.Text = "Частота тока, Гц";
            // 
            // objectParamLabel
            // 
            this.objectParamLabel.AutoSize = true;
            this.objectParamLabel.Location = new System.Drawing.Point(6, 24);
            this.objectParamLabel.Name = "objectParamLabel";
            this.objectParamLabel.Size = new System.Drawing.Size(107, 13);
            this.objectParamLabel.TabIndex = 1;
            this.objectParamLabel.Text = "Сопротивление, Ом";
            // 
            // objectParamTextBox
            // 
            this.objectParamTextBox.Location = new System.Drawing.Point(122, 21);
            this.objectParamTextBox.Name = "objectParamTextBox";
            this.objectParamTextBox.Size = new System.Drawing.Size(75, 20);
            this.objectParamTextBox.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(59, 198);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(140, 198);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Закрыть";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.СancelButtonClick);
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(12, 198);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(41, 23);
            this.randomButton.TabIndex = 6;
            this.randomButton.Text = "R";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.RandomButtonClick);
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 232);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.paramsGroupBox);
            this.Controls.Add(this.objectTypeGroupBox);
            this.Controls.Add(this.nameGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddObjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление элемента";
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.objectTypeGroupBox.ResumeLayout(false);
            this.paramsGroupBox.ResumeLayout(false);
            this.paramsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox objectTypeGroupBox;
        private System.Windows.Forms.GroupBox paramsGroupBox;
        private System.Windows.Forms.TextBox objectParamTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox objectTypeComboBox;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.Label objectParamLabel;
        private System.Windows.Forms.Button randomButton;
    }
}