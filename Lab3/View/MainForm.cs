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
    /// Класс MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список объектов PassiveElementBase.
        /// </summary>
        private BindingList<PassiveElementBase> _data = new BindingList<PassiveElementBase>();
        
        /// <summary>
        /// Конструктор класса MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            dataGridPassiveElements.DataSource = _data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addObjectButton_Click(object sender, EventArgs e)
        {
            AddObjectForm addObjectForm = new AddObjectForm();
            addObjectForm.Show();
            addObjectForm.SendElement += AddElementEvent;
        }

        /// <summary>
        /// Обработчик события ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddElementEvent(object sender, PassiveElementEventArgs e)
        {
            _data.Add(e.AddedElement);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteObjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dataGridPassiveElements.CurrentCell == null)
                {
                    throw new Exception("Не выбрано ни одной записи.");
                }
                _data.RemoveAt(dataGridPassiveElements.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findObjectButton_Click(object sender, EventArgs e)
        {
            FindObjectForm findObjectForm = new FindObjectForm();
            findObjectForm.Show();
        }
    }
}
