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
        /// 
        /// </summary>
        public event EventHandler<PassiveElementEventArgs> SendElement;

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
            try
            {
                _element.Name = nameTextBox.Text;
                _element.Frequency = Convert.ToInt32(frequencyTextBox.Text);
                switch (_element)
                {
                    case Resistor resistor:
                    {
                        resistor.Resistance = Convert.ToDouble(objectParamTextBox.Text);
                        break;
                    }
                    case Capacitor capacitor:
                    {
                        capacitor.Capacitance = Convert.ToDouble(objectParamTextBox.Text);
                        break;
                    }
                    case Inductor inductor:
                    {
                        inductor.Inductance = Convert.ToDouble(objectParamTextBox.Text);
                        break;
                    }
                }
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
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void randomButton_Click(object sender, EventArgs e)
        {
            PassiveElementBase element = RandomPassiveElement.GetRandomElement();
            nameTextBox.Text = element.Name;
            frequencyTextBox.Text = element.Frequency.ToString();
            switch (element)
            {
                case Resistor resistor:
                {
                    objectTypeComboBox.SelectedItem = "Резистор";
                    _element = new Resistor();
                    objectParamLabel.Text = "Сопротивление:";
                    objectParamTextBox.Text = resistor.Resistance.ToString();
                    break;
                }
                case Capacitor capacitor:
                {
                    objectTypeComboBox.SelectedItem = "Ёмкостный элемент";
                    _element = new Capacitor();
                    objectParamLabel.Text = "Ёмкость:";
                    objectParamTextBox.Text = capacitor.Capacitance.ToString();
                    break;
                }
                case Inductor inductor:
                {
                    objectTypeComboBox.SelectedItem = "Индуктивный элемент";
                    _element = new Inductor();
                    objectParamLabel.Text = "Индуктивность:";
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
    }
}
