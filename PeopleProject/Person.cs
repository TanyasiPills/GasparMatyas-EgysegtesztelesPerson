using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject
{
    public class Person
    {
        private int id;
        private string name;
        private int age;
        private bool isStudent;
        private int score;

        public Person(int id, string name, int age, bool isStudent, int score)
        {
            if (id == null || name == null || age == null || isStudent == null || score == null) throw new NullVariableExceptioin();
            else
            {
                this.Id = id;
                this.Name = name;
                this.Age = age;
                this.IsStudent = isStudent;
                this.Score = score;
            }
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool IsStudent { get => isStudent; set => isStudent = value; }
        public int Score { get => score; set => score = value; }
    }
}
