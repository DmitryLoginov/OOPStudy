using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    /// <summary>
    /// Ребёнок.
    /// </summary>
    public class Child : Person
    {
        /// <summary>
        /// Наибольший возраст ребёнка.
        /// </summary>
        public const int MaxChildAge = 18;

        /// <summary>
        /// Мать.
        /// </summary>
        public Adult Mother { get; set; }

        /// <summary>
        /// Отец.
        /// </summary>
        public Adult Father { get; set; }

        /// <summary>
        /// Учебное заведение.
        /// </summary>
        public string LearningFacility { get; set; }

        /// <summary>
        /// Информация о персоне.
        /// </summary>
        public override string Info
        {
            get
            {
                string parents;
                if ((Mother == null) && (Father == null))
                {
                    parents = "отсутствуют";
                }
                else if ((Mother == null) && (Father != null))
                {
                    parents = $"отец-одиночка - {Father.FirstName} {Father.LastName}";
                }
                else if ((Mother != null) && (Father == null))
                {
                    parents = $"мать-одиночка - {Mother.FirstName} {Mother.LastName}";
                }
                else
                {
                    parents = $"отец - {Father.FirstName} {Father.LastName}, " +
                        $"мать - {Mother.FirstName} {Mother.LastName}";
                }

                string learningFacility = LearningFacility != null
                    ? $"{LearningFacility}"
                    : "нет";

                return base.Info +
                    $"\n\tродители: {parents}\n" +
                    $"\tучебное заведение: {learningFacility}";
            }
        }

        /// <summary>
        /// Конструктор класса Child.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="learningFacility">Учебное заведение.</param>
        public Child(string firstName, string lastName, int age,
            Gender gender, string learningFacility) : base(firstName, lastName, age, gender)
        {
            LearningFacility = learningFacility;
        }

        /// <summary>
        /// Конструктор класса Child.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="mother">Мать.</param>
        /// <param name="father">Отец.</param>
        /// <param name="learningFacility">Учебное заведение.</param>
        public Child(string firstName, string lastName, int age,
            Gender gender, Adult mother, Adult father,
            string learningFacility) : base(firstName, lastName, age, gender)
        {
            Mother = mother;
            Father = father;
            LearningFacility = learningFacility;
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
            if ((age >= MaxChildAge) || (age < MinAge))
            {
                throw new ArgumentException($"Возраст ребёнка должен " +
                    $"быть не отрицательным числом, меньшим {MaxChildAge}.");
            }
        }

        /// <summary>
        /// Пойти/поступить в учебное заведение.
        /// </summary>
        /// <param name="learningFacility">Учебное заведение.</param>
        /// <returns>Информационное сообщение.</returns>
        public string GoStudy(string learningFacility)
        {
            LearningFacility = learningFacility;

            return $"Теперь {FirstName} {LastName} посещает {learningFacility}";
        }
    }
}
