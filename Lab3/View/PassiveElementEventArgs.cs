using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace View
{
    /// <summary>
    /// Класс для передачи данных события нажатия на кнопку "ОК" в AddObjectForm.
    /// </summary>
    public class PassiveElementEventArgs : EventArgs
    {
        /// <summary>
        /// Передаваемый объект типа PassiveElementBase.
        /// </summary>
        private PassiveElementBase _addedElement;

        /// <summary>
        /// Передаваемый объект типа PassiveElementBase.
        /// </summary>
        public PassiveElementBase AddedElement
        {
            get
            {
                return _addedElement;
            }
            private set
            {
                _addedElement = value;
            }
        }

        /// <summary>
        /// Конструктор класса PassiveElementEventArgs.
        /// </summary>
        /// <param name="addedElement">Передаваемый объект.</param>
        public PassiveElementEventArgs(PassiveElementBase addedElement)
        {
            AddedElement = addedElement;
        }
    }
}
