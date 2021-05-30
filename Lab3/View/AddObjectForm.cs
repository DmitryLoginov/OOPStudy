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
        private const string _resistor = "Резистор";

        private const string _capacitor = "Ёмкостный элемент";

        private const string _inductor = "Индуктивный элемент";

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<PassiveElementEventArgs> SendElement;

        /// <summary>
        /// Внутренний объект типа PassiveElementBase.
        /// </summary>
        private PassiveElementBase _element;
        
        /// <summary>
        /// Конструктор класса AddObjectForm
        /// </summary>
        public AddObjectForm()
        {
            InitializeComponent();
            objectTypeComboBox.DataSource = new List<string>()
            {
                _resistor, _capacitor, _inductor
            };
            #if !DEBUG
            randomButton.Visible = false;
            #endif
        }

        /// <summary>
        /// Изменяет текст objectParamLabel, а также доступность
        /// objectParamTextBox и frequencyTextBox в зависимости
        /// от значения в objectTypeComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjectTypeComboBoxSelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (objectTypeComboBox.SelectedItem.ToString())
            {
                case _resistor:
                {
                    objectParamLabel.Text = "Сопротивление";
                    _element = new Resistor();
                    break;
                }
                case _capacitor:
                {
                    objectParamLabel.Text = "Ёмкость";
                    _element = new Capacitor();
                    break;
                }
                case _inductor:
                {
                    objectParamLabel.Text = "Индуктивность";
                    _element = new Inductor();
                    break;
                }
                default:
                {
                    throw new Exception("Неверный формат.");
                }
            }
            objectParamTextBox.Enabled = true;
            frequencyTextBox.Enabled = true;
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки ОК.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButtonClick(object sender, EventArgs e)
        {
            try
            {
                CheckName();
                switch (_element)
                {
                    case Resistor resistor:
                    {
                        resistor.Resistance = CheckObjectParam();
                        break;
                    }
                    case Capacitor capacitor:
                    {
                        capacitor.Capacitance = CheckObjectParam();
                        break;
                    }
                    case Inductor inductor:
                    {
                        inductor.Inductance = CheckObjectParam();
                        break;
                    }
                }
                CheckFrequency();
                SendElement(this, new PassiveElementEventArgs(_element));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Закрывает форму добавления элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void СancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Заполняет поля случайными правильными данными для объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomButtonClick(object sender, EventArgs e)
        {
            PassiveElementBase randomElement = RandomPassiveElement.GetRandomElement();
            nameTextBox.Text = randomElement.Name;
            frequencyTextBox.Text = randomElement.Frequency.ToString();
            switch (randomElement)
            {
                case Resistor resistor:
                {
                    objectTypeComboBox.SelectedItem = _resistor;
                    _element = new Resistor();
                    objectParamLabel.Text = "Сопротивление";
                    objectParamTextBox.Text = resistor.Resistance.ToString();
                    break;
                }
                case Capacitor capacitor:
                {
                    objectTypeComboBox.SelectedItem = _capacitor;
                    _element = new Capacitor();
                    objectParamLabel.Text = "Ёмкость";
                    objectParamTextBox.Text = capacitor.Capacitance.ToString();
                    break;
                }
                case Inductor inductor:
                {
                    objectTypeComboBox.SelectedItem = _inductor;
                    _element = new Inductor();
                    objectParamLabel.Text = "Индуктивность";
                    objectParamTextBox.Text = inductor.Inductance.ToString();
                    break;
                }
                default:
                {
                    throw new Exception("Ошибка");
                }
            }
            objectParamTextBox.Enabled = true;
            frequencyTextBox.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckName()
        {
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                throw new Exception("Поле \"Название элемента\" не заполнено.");
            }
            _element.Name = nameTextBox.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckFrequency()
        {
            if (!Int32.TryParse(frequencyTextBox.Text, out int frequency))
            {
                throw new Exception("Параметр \"Частота\" должен быть числом.");
            }
            _element.Frequency = frequency;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private double CheckObjectParam()
        {
            objectParamTextBox.Text.Replace('.', ',');
            if (!Double.TryParse(objectParamTextBox.Text, out double param))
            {
                throw new Exception($"Параметр \"{objectParamLabel.Text}\" должен быть числом.");
            }

            return param;
        }
    }
}
