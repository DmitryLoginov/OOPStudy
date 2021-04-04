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
        private Adult _mother;

        private Adult _father;

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

                return $"{FirstName} {LastName}, пол: {Gender}, возраст: {Age},\n" +
                    $"родители: {parents}, учебное заведение: {learningFacility}";
            }
        }

        public Child(string firstName, string lastName,
            int age, Gender gender) : base(firstName, lastName, age, gender)
        {

        }

        public Child(string firstName, string lastName,
            int age, Gender gender, Adult mother, Adult father) : base(firstName, lastName, age, gender)
        {
            Mother = mother;
            Father = father;
        }

        public void GoStudy(string learningFacility)
        {
            LearningFacility = learningFacility;
        }
    }
}
