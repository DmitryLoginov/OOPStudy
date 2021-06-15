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
        /// Тип Resistor для objectTypeComboBox.DataSource.
        /// </summary>
        private const string ResistorKey = "Резистор";

        /// <summary>
        /// Тип Capacitor для objectTypeComboBox.DataSource.
        /// </summary>
        private const string CapacitorKey = "Ёмкостный элемент";

        /// <summary>
        /// Тип Inductor для objectTypeComboBox.DataSource.
        /// </summary>
        private const string InductorKey = "Индуктивный элемент";

        /// <summary>
        /// Текст для objectParamLabel при типе Resistor.
        /// </summary>
        private const string ResistorLabel = "Сопротивление, Ом";

        /// <summary>
        /// Текст для objectParamLabel при типе Capacitor.
        /// </summary>
        private const string CapacitorLabel = "Ёмкость, Ф";

        /// <summary>
        /// Текст для objectParamLabel при типе Inductor.
        /// </summary>
        private const string InductorLabel = "Индуктивность, Гн";

        /// <summary>
        /// Событие для передачи объекта PassiveElementBase в MainForm.
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
                ResistorKey, CapacitorKey, InductorKey
            };
            #if !DEBUG
            randomButton.Visible = false;
            #endif
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
                SendElement?.Invoke(this, new PassiveElementEventArgs(_element));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода", 
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
                    objectTypeComboBox.SelectedItem = ResistorKey;
                    objectParamTextBox.Text = resistor.Resistance.ToString();
                    break;
                }
                case Capacitor capacitor:
                {
                    objectTypeComboBox.SelectedItem = CapacitorKey;
                    objectParamTextBox.Text = capacitor.Capacitance.ToString();
                    break;
                }
                case Inductor inductor:
                {
                    objectTypeComboBox.SelectedItem = InductorKey;
                    objectParamTextBox.Text = inductor.Inductance.ToString();
                    break;
                }
                default:
                {
                    throw new Exception("Неверный формат.");
                }
            }
        }

        /// <summary>
        /// Проверяет название элемента в nameTextBox.
        /// </summary>
        private void CheckName()
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                throw new Exception($"Поле \"{nameGroupBox.Text}\" не заполнено.");
            }
            _element.Name = nameTextBox.Text;
        }

        /// <summary>
        /// Проверяет частоту тока в frequencyTextBox.
        /// </summary>
        private void CheckFrequency()
        {
            if (!int.TryParse(frequencyTextBox.Text, out int frequency))
            {
                throw new Exception($"Параметр \"{frequencyLabel.Text}\" должен быть целым числом.");
            }
            _element.Frequency = frequency;
        }

        /// <summary>
        /// Проверяет параметры элемента в objectParamTextBox.
        /// </summary>
        /// <returns></returns>
        private double CheckObjectParam()
        {
            objectParamTextBox.Text.Replace('.', ',');
            if (!double.TryParse(objectParamTextBox.Text, out double param))
            {
                throw new Exception($"Параметр \"{objectParamLabel.Text}\" должен быть числом.");
            }
            return param;
        }

        /// <summary>
        /// Изменяет текст objectParamLabel в зависимости
        /// от значения в objectTypeComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjectTypeComboBoxSelectedValueChanged(object sender, EventArgs e)
        {
            switch (objectTypeComboBox.SelectedItem.ToString())
            {
                case ResistorKey:
                {
                    objectParamLabel.Text = ResistorLabel;
                    _element = new Resistor();
                    break;
                }
                case CapacitorKey:
                {
                    objectParamLabel.Text = CapacitorLabel;
                    _element = new Capacitor();
                    break;
                }
                case InductorKey:
                {
                    objectParamLabel.Text = InductorLabel;
                    _element = new Inductor();
                    break;
                }
                default:
                {
                    throw new Exception("Неверный формат.");
                }
            }
        }
    }
}
