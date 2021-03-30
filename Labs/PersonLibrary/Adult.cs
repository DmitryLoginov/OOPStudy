using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    /// <summary>
    /// Взрослый.
    /// </summary>
    public class Adult : Person
    {
        private Passport _passport;

        private Adult _partner;

        private Child _child;

        private string _job;
        
        /// <summary>
        /// Паспортные данные.
        /// </summary>
        public Passport Passport
        {
            get
            {
                return _passport;
            }
            private set
            {
                _passport = value;
            }
        }

        /// <summary>
        /// Семейное положение.
        /// </summary>
        public bool IsMarried
        {
            get
            {
                return (_partner != null);
            }
        }

        /// <summary>
        /// Супруг(а).
        /// </summary>
        public Adult Partner
        {
            get
            {
                return _partner;
            }
            private set
            {
                _partner = value;
            }
        }

        /// <summary>
        /// Ребёнок.
        /// </summary>
        public Child Child
        {
            get
            {
                return _child;
            }
            private set
            {
                _child = value;
            }
        }

        /// <summary>
        /// Место работы.
        /// </summary>
        public string Job
        {
            get
            {
                return _job;
            }
            private set
            {
                _job = value;
            }
        }
    }
}
