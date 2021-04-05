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
        private Adult _mother;

        /// <summary>
        /// Отец.
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Учебное заведение.
        /// </summary>
        private string _learningFacility;

        /// <summary>
        /// Мать.
        /// </summary>
        public Adult Mother
        {
            get
            {
                return _mother;
            }
            set
            {
                _mother = value;
            }
        }

        /// <summary>
        /// Отец.
        /// </summary>
        public Adult Father
        {
            get
            {
                return _father;
            }
            set
            {
                _father = value;
            }
        }

        /// <summary>
        /// Учебное заведение.
        /// </summary>
        public string LearningFacility
        {
            get
            {
                return _learningFacility;
            }
            private set
            {
                _learningFacility = value;
            }
        }

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
                    parents = "сирота";
                }
                else if ((Mother == null) && (Father != null))
                {
                    parents = $"отец: {Father.FirstName} {Father.LastName}";
                }
                else if ((Mother != null) && (Father == null))
                {
                    parents = $"мать: {Mother.FirstName} {Mother.LastName}";
                }
                else
                {
                    parents = $"отец: {Father.FirstName} {Father.LastName}, " +
                        $"мать: {Mother.FirstName} {Mother.LastName}";
                }

                string learningFacility = LearningFacility != null
                    ? $"{LearningFacility}"
                    : "нет";

                return $"{FirstName} {LastName}\n" +
                    $"\tпол: {Gender}\n" +
                    $"\tвозраст: {Age}\n" +
                    $"\tродители: {parents}\n" +
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
        public Child(string firstName, string lastName, int age,
            Gender gender) : base(firstName, lastName, age, gender)
        {

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
        public Child(string firstName, string lastName, int age,
            Gender gender, Adult mother, Adult father) : base(firstName, lastName, age, gender)
        {
            Mother = mother;
            Father = father;
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

            return $"Учебное заведение, которое посещает {FirstName} {LastName} - {learningFacility}";
        }
    }
}
