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
        /// <summary>
        /// Наименьший возраст, начиная с которого
        /// персона считается "взрослым".
        /// </summary>
        public const int MinAdultAge = 18;
        
        /// <summary>
        /// Паспорт.
        /// </summary>
        private Passport _passport;

        /// <summary>
        /// Партнер, супруг(а).
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Ребёнок.
        /// </summary>
        private Child _child;

        /// <summary>
        /// Место работы.
        /// </summary>
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
            set
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

        /// <summary>
        /// Информация о персоне.
        /// </summary>
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

        /// <summary>
        /// Конструктор класса Adult.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="passSeries">Серия паспорта.</param>
        /// <param name="passNumber">Номер паспорта.</param>
        public Adult(string firstName, string lastName, int age,
            Gender gender, string passSeries, string passNumber) : base(firstName, lastName, age, gender)
        {
            Passport = new Passport(passSeries, passNumber);
        }

        /// <summary>
        /// Конструктор класса Adult.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="passSeries">Серия паспорта.</param>
        /// <param name="passNumber">Номер паспорта.</param>
        /// <param name="job">Место работы.</param>
        public Adult(string firstName, string lastName, int age,
            Gender gender, string passSeries, string passNumber,
            string job) : base(firstName, lastName, age, gender)
        {
            Passport = new Passport(passSeries, passNumber);
            Job = job;
        }

        /// <summary>
        /// Конструктор класса Adult.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="passport">Паспорт.</param>
        public Adult(string firstName, string lastName, int age,
            Gender gender, Passport passport) : base(firstName, lastName, age, gender)
        {
            Passport = passport;
        }

        /// <summary>
        /// Конструктор класса Adult.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="passport">Паспорт.</param>
        /// <param name="job">Место работы.</param>
        public Adult(string firstName, string lastName, int age,
            Gender gender, Passport passport, string job) : base(firstName, lastName, age, gender)
        {
            Passport = passport;
            Job = job;
        }

        /// <summary>
        /// Проверяет возраст на соответствие требованиям.
        /// </summary>
        /// <param name="age">Строка, соответствующая возрасту.</param>
        /// <exception cref="System.ArgumentException">
        /// Выбрасывается при несоответствии возраста требованиям.
        /// </exception>
        protected override void IsAgeCorrect(int age)
        {
            if ((age >= MaxAge) || (age < MinAdultAge))
            {
                throw new ArgumentException($"Возраст взрослого должен быть " +
                    $"не отрицательным числом, большим {MinAdultAge} меньшим {MaxAge}.");
            }
        }

        /// <summary>
        /// Найти работу.
        /// </summary>
        /// <param name="job">Место работы.</param>
        public void GetAJob(string job)
        {
            Job = job;
        }

        /// <summary>
        /// Связывает узами брака двух персон.
        /// </summary>
        /// <remarks>
        /// Проверка полов не осуществляется.
        /// </remarks>
        /// <param name="firstPartner"></param>
        /// <param name="secondPartner"></param>
        public static void GetMarried(Adult firstPartner, Adult secondPartner)
        {
            firstPartner.Partner = secondPartner;
            secondPartner.Partner = firstPartner;
        }

        //public static Child MakeABaby(Adult firstPartner, Adult secondPartner)
        //{
        //
        //}

        // Разобраться с паспортом
    }
}
