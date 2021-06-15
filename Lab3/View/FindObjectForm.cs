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
        private readonly BindingList<PassiveElementBase> _data;

        /// <summary>
        /// Конструктор класса FindObjectForm.
        /// </summary>
        public FindObjectForm(BindingList<PassiveElementBase> data)
        {
            InitializeComponent();
            _data = data;
            dataGridSearchResults.DataSource = _data;
            dataGridSearchResults.Columns[0].HeaderText = "Название";
            dataGridSearchResults.Columns[1].HeaderText = "Частота тока";
            dataGridSearchResults.Columns[2].HeaderText = "Комплексное сопротивление";
            dataGridSearchResults.Columns[2].Width = 160;
            nameTextBox.Enabled = false;
            frequencyTextBox.Enabled = false;
            complexPartsGroupBox.Enabled = false;
        }

        /// <summary>
        /// Изменяет значение параметра Enabled для контрола при
        /// изменении свойства Check соответствующего объекта CheckBox.
        /// </summary>
        /// <param name="checkBox">Объект класса CheckBox.</param>
        /// <param name="control">Объект класса Control.</param>
        private void CheckBoxCheckedChangedHandler(CheckBox checkBox, Control control)
        {
            if (checkBox.Checked == true)
            {
                control.Enabled = true;
            }
            else
            {
                control.Enabled = false;
            }
        }

        /// <summary>
        /// Обработчик изменения свойства Check объекта nameCheckBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCheckedChangedHandler(nameCheckBox, nameTextBox);
        }

        /// <summary>
        /// Обработчик изменения свойства Check объекта frequencyCheckBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrequencyCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCheckedChangedHandler(frequencyCheckBox, frequencyTextBox);
        }

        /// <summary>
        /// Обработчик изменения свойства Check объекта impedanceCheckBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImpedanceChechBoxCheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCheckedChangedHandler(impedanceCheckBox, complexPartsGroupBox);
        }

        /// <summary>
        /// Закрывает форму для поиска элементов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Сбрасывает фильтр.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetFilterButtonClick(object sender, EventArgs e)
        {
            nameCheckBox.Checked = false;
            nameTextBox.Text = string.Empty;
            frequencyCheckBox.Checked = false;
            frequencyTextBox.Text = string.Empty;
            impedanceCheckBox.Checked = false;
            realPartTextBox.Text = string.Empty;
            imaginaryPartTextBox.Text = string.Empty;
            for (int i = 0; i < dataGridSearchResults.Rows.Count; i++)
            {
                dataGridSearchResults.Rows[i].Visible = true;
            }
        }

        /// <summary>
        /// Показывает результаты поиска в таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowResultsButtonClick(object sender, EventArgs e)
        {
            if (nameCheckBox.Checked == false && frequencyCheckBox.Checked == false && 
                impedanceCheckBox.Checked == false)
            {
                MessageBox.Show("Фильтр не задан.", "Не найдено ни одного элемента", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridSearchResults.CurrentCell = null;
            for (int i = 0; i < dataGridSearchResults.Rows.Count; i++)
            {
                dataGridSearchResults.Rows[i].Visible = true;
            }

            var filterFuncs = new List<Tuple<CheckBox, Func<int, bool>>>()
            {
                new Tuple<CheckBox, Func<int, bool>>
                (
                    nameCheckBox,
                    (index) =>
                    {
                        return !_data[index].Name.Contains(nameTextBox.Text);
                    }
                ),
                new Tuple<CheckBox, Func<int, bool>>
                (
                    frequencyCheckBox,
                    (index) =>
                    {
                        if (frequencyTextBox.Text == string.Empty)
                        {
                            return false;
                        }
                        return (dataGridSearchResults.Rows[index].Cells[1].Value.ToString() 
                            != frequencyTextBox.Text);
                    }
                ),
                new Tuple<CheckBox, Func<int, bool>>
                (
                    impedanceCheckBox,
                    (index) =>
                    {
                        if (realPartTextBox.Text == string.Empty)
                        {
                            return false;
                        }
                        if (dataGridSearchResults.Rows[index].Cells[2].Value is Complex impedance)
                        {
                            return (impedance.Real.ToString() != realPartTextBox.Text);
                        }
                        return false;
                    }
                ),
                new Tuple<CheckBox, Func<int, bool>>
                (
                    impedanceCheckBox,
                    (index) =>
                    {
                        var tmpValue = dataGridSearchResults.Rows[index].Cells[2].Value;
                        var imaginaryToStringFunc = new Func<Complex, string>(                        
                                tmpImpedance => tmpImpedance.Imaginary.ToString());
                        var tmpTextBox = imaginaryPartTextBox;

                        if (tmpTextBox.Text == string.Empty)
                        {
                            return false;
                        }
                        if (tmpValue is Complex impedance)
                        {
                            return (imaginaryToStringFunc.Invoke(impedance) != tmpTextBox.Text);
                        }
                        return false;
                    }
                )
            };

            for (int i = 0; i < filterFuncs.Count; i++)
            {
                if (filterFuncs[i].Item1.Checked)
                {
                    FilterData(filterFuncs[i].Item2);
                }
            }

            
        }

        /// <summary>
        /// Фильтрует записи в dataGridSearchResults в зависимости
        /// от заданных пользователем условий.
        /// </summary>
        /// <param name="condition">
        /// Делегат Func с одним параметром типа int, возвращающий результат типа bool.
        /// </param>
        private void FilterData(Func<int, bool> condition)
        {
            for (int i = 0; i < dataGridSearchResults.Rows.Count; i++)
            {
                if (condition(i))
                {
                    dataGridSearchResults.Rows[i].Visible = false;
                }
            }
        }
    }
}
