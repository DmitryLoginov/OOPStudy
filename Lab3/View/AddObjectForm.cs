using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;

namespace View
{
    /// <summary>
    /// Класс формы добавления элемента.
    /// </summary>
    public partial class AddObjectForm : Form
    {

        /// <summary>
        /// Объект типа PassiveElementBase.
        /// </summary>
        private PassiveElementBase _element;
        
        /// <summary>
        /// Конструктор класса AddObjectForm
        /// </summary>
        public AddObjectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Изменяет текст objectParamLabel, а также доступность
        /// objectParamTextBox и frequencyTextBox в зависимости
        /// от значения в objectTypeComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void objectTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (objectTypeComboBox.SelectedItem.ToString())
            {
                case "Резистор":
                {
                    objectParamLabel.Text = "Сопротивление:";
                    _element = new Resistor();
                    break;
                }
                case "Ёмкостный элемент":
                {
                    objectParamLabel.Text = "Ёмкость:";
                    _element = new Capacitor();
                    break;
                }
                case "Индуктивный элемент":
                {
                    objectParamLabel.Text = "Индуктивность:";
                    _element = new Inductor();
                    break;
                }
            }
            objectParamTextBox.Enabled = true;
            frequencyTextBox.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Закрывает форму добавления элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        /// <summary>
        /// Проверяет название элемента.
        /// </summary>
        private void ValidateName()
        {
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                throw new Exception("Название элемента не должно быть пустым.");
            }
        }
    }
}
