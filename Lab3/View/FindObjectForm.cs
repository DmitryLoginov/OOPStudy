using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;

namespace View
{
    /// <summary>
    /// Класс формы для поиска элементов.
    /// </summary>
    public partial class FindObjectForm : Form
    {
        /// <summary>
        /// Список объектов PassiveElementBase.
        /// </summary>
        private BindingList<PassiveElementBase> _data = new BindingList<PassiveElementBase>();

        /// <summary>
        /// Конструктор класса FindObjectForm.
        /// </summary>
        public FindObjectForm(BindingList<PassiveElementBase> data)
        {
            InitializeComponent();
            _data = data;
            dataGridSearchResults.DataSource = _data;
            nameTextBox.Enabled = false;
            frequencyTextBox.Enabled = false;
            complexPartsGroupBox.Enabled = false;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameCheckBoxCheckedChanged(object sender, EventArgs e)
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
        private void FrequencyCheckBoxCheckedChanged(object sender, EventArgs e)
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
        private void ImpedanceChechBoxCheckedChanged(object sender, EventArgs e)
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
        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetFilterButtonClick(object sender, EventArgs e)
        {
            nameCheckBox.Checked = false;
            nameTextBox.Text = "";
            frequencyCheckBox.Checked = false;
            frequencyTextBox.Text = "";
            impedanceCheckBox.Checked = false;
            realPartTextBox.Text = "";
            imaginaryPartTextBox.Text = "";
            for (int i = 0; i < dataGridSearchResults.Rows.Count; i++)
            {
                dataGridSearchResults.Rows[i].Visible = true;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showResultsButton_Click(object sender, EventArgs e)
        {
            if (nameCheckBox.Checked == false && frequencyCheckBox.Checked == false && 
                impedanceCheckBox.Checked == false)
            {
                MessageBox.Show("Фильтр не задан.", "Не найдено ни одного элемента", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //for (int i = 0; i < dataGridSearchResults.Rows.Count; i++)
            //{
            //    dataGridSearchResults.Rows[i].Visible = false;
            //}

            dataGridSearchResults.CurrentCell = null;

            if (nameCheckBox.Checked == true)
            {
                for (int i = 0; i < dataGridSearchResults.Rows.Count; i++)
                {
                    if (!_data[i].Name.Contains(nameTextBox.Text))
                    {
                        dataGridSearchResults.Rows[i].Visible = false;
                    }
                }
            }

            if (frequencyCheckBox.Checked == true)
            {
                for (int i = 0; i < dataGridSearchResults.Rows.Count; i++)
                {
                    if (dataGridSearchResults.Rows[i].Cells[1].Value.ToString() != frequencyTextBox.Text)
                    {
                        dataGridSearchResults.Rows[i].Visible = false;
                    }
                }
            }

            if (impedanceCheckBox.Checked == true)
            {
                if (!String.IsNullOrEmpty(realPartTextBox.Text))
                {
                    for (int i = 0; i < dataGridSearchResults.Rows.Count; i++)
                    {
                        if (dataGridSearchResults.Rows[i].Cells[2].Value is Complex)
                        {
                            Complex impedance = (Complex)dataGridSearchResults.Rows[i].Cells[2].Value;
                            
                            if (impedance.Real.ToString() != realPartTextBox.Text)
                            {
                                dataGridSearchResults.Rows[i].Visible = false;
                            }
                        }
                    }
                }

                if (!String.IsNullOrEmpty(imaginaryPartTextBox.Text))
                {
                    for (int i = 0; i < dataGridSearchResults.Rows.Count; i++)
                    {
                        if (dataGridSearchResults.Rows[i].Cells[2].Value is Complex)
                        {
                            Complex impedance = (Complex)dataGridSearchResults.Rows[i].Cells[2].Value;

                            if (impedance.Imaginary.ToString() != imaginaryPartTextBox.Text)
                            {
                                dataGridSearchResults.Rows[i].Visible = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
