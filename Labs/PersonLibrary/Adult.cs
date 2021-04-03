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

        public override string Info
        {
            get
            {
                string child = Child != null
                    ? $"{Child.FirstName} {Child.LastName}"
                    : "нет детей";
                string job = Job != null
                    ? $"{Job}"
                    : "безработный";
                string partner = Partner != null
                    ? $"{Partner.FirstName} {Partner.LastName}"
                    : "нет";

                return $"{FirstName} {LastName}, пол: {Gender}, возраст: {Age},\n" +
                    $"паспортные данные: {Passport.Series} {Passport.Number}, " +
                    $"супруг(а): {partner},\nдети: {child}, место работы: {job}";
            }
        }

        public Adult(string firstName, string lastName,
            int age, Gender gender, string passSeries, string passNumber) : base(firstName, lastName, age, gender)
        {
            Passport = new Passport(passSeries, passNumber);
        }

        public void GetAJob(string job)
        {
            Job = job;
        }

        // Разобраться с паспортом
        // GetMarried
    }
}
