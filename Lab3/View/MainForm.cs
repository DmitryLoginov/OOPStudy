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

        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            AddObjectForm addObjectForm = new AddObjectForm();
            addObjectForm.Show();
        }
    }
}
