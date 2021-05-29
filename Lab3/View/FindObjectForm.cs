using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс формы для поиска элементов.
    /// </summary>
    public partial class FindObjectForm : Form
    {
        /// <summary>
        /// Конструктор класса FindObjectForm.
        /// </summary>
        public FindObjectForm()
        {
            InitializeComponent();
            nameTextBox.Enabled = false;
            frequencyTextBox.Enabled = false;
            complexPartsGroupBox.Enabled = false;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (nameCheckBox.Checked == true)
            {
                nameTextBox.Enabled = true;
            }
            else
            {
                nameTextBox.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frequencyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (frequencyCheckBox.Checked == true)
            {
                frequencyTextBox.Enabled = true;
            }
            else
            {
                frequencyTextBox.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void impedanceChechBox_CheckedChanged(object sender, EventArgs e)
        {
            if (impedanceCheckBox.Checked == true)
            {
                complexPartsGroupBox.Enabled = true;
            }
            else
            {
                complexPartsGroupBox.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
