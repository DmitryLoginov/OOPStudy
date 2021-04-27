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
    public class Adult : PersonBase
    {
        /// <summary>
        /// Наименьший возраст, начиная с которого
        /// персона считается "взрослым".
        /// </summary>
        public const int MinAdultAge = 18;
        
        /// <summary>
        /// Паспортные данные.
        /// </summary>
        public PassportTemplate Passport { get; set; }

        /// <summary>
        /// Семейное положение.
        /// </summary>
        public bool IsMarried
        {
            get
            {
                return (Partner != null);
            }
        }

        /// <summary>
        /// Супруг(а).
        /// </summary>
        public Adult Partner { get; set; }

        /// <summary>
        /// Ребёнок.
        /// </summary>
        public Child Child { get; set; }

        /// <summary>
        /// Место работы.
        /// </summary>
        public string Job { get; set; }

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

                return base.Info +
                    $"\n\tпаспортные данные: {Passport.Series} {Passport.Number}\n" +
                    $"\tсупруг(а): {partner}\n" +
                    $"\tдети: {child}\n" +
                    $"\tместо работы: {job}";
            }
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
            Gender gender, PassportTemplate passport) : base(firstName, lastName, age, gender)
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
            Gender gender, PassportTemplate passport, string job) : base(firstName, lastName, age, gender)
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
            if ((age > MaxAge) || (age < MinAdultAge))
            {
                throw new ArgumentException($"Возраст взрослого должен быть " +
                    $"положительным числом, большим {MinAdultAge} меньшим {MaxAge}.");
            }
        }

        /// <summary>
        /// Найти работу.
        /// </summary>
        /// <param name="job">Место работы.</param>
        /// <returns>Информационное сообщение.</returns>
        public string FindAJob(string job)
        {
            Job = job;

            return $"Теперь {FirstName} {LastName} работает в {job}";
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
    }
}
