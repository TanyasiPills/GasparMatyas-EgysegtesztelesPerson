using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject
{
    public class PersonStatistics
    {
        private List<Person> persons;

        public List<Person> Persons { private get => persons; set => persons = value; }

        public PersonStatistics(List<Person> persons)
        {
            if(persons != null) this.Persons = persons;
            else throw new StatisticsConstructorException();
        }

        public double getAvarageAge(List<Person> persons)
        {
            double avg = persons.Average(e => (double)e.Age);
            if (avg > 0) return avg;
            else throw new InvalidPersonDataException();
        }
        public int getNumbrOfStudent(List<Person> persons)
        {
            if (persons.Count == 0) throw new InvalidListException();
            else return persons.Where(e => e.IsStudent == true).Count();
        }
        public Person getPersonWithHighestScore(List<Person> persons)
        {
            if (persons == null) throw new ArgumentNullException("szup");
            if (persons.Count == 0) throw new InvalidListException();
            else
            {
                int maxScore = persons.Max(p => p.Score);
                List<Person> max = persons.Where(e => e.Score == maxScore).ToList();
                if (max.Count > 1) throw new ExceededNumberException();
                else return max.First();
            }
        }
        public double getAvarageScoreOfStudents(List<Person> persons)
        {
            double avg = persons.Average(e => (double)e.Score);
            if (avg > 0) return avg;
            else throw new NegativeAvarageException();
        }
        public Person getOldestStudent(List<Person> persons)
        {
            if (persons.Count == 0) throw new InvalidListException();
            else return persons.Where(e => e.Age == persons.Max(w => w.Age)).First();
        }
        public bool isAnyoneFailing(List<Person> persons)
        {
            if (persons.Count == 0) throw new InvalidListException();
            else return persons.Any(e => e.Score < 40);
        }
    }
    public class StatisticsConstructorException : Exception 
    {
        public StatisticsConstructorException()
        : base("Nem megfelelő a lista tartalmi") { }
    }
    public class InvalidPersonDataException : Exception
    {
        public InvalidPersonDataException()
        : base("Helytelen személy adat a műveletben") { }
    }
    public class NegativeAvarageException : Exception
    {
        public NegativeAvarageException()
        : base("Nem lehet a pontszámok átlaga negatív") { }
    }
    public class NullVariableExceptioin : Exception
    {
        public NullVariableExceptioin()
        : base("Nem lehet a class változója null") { }
    }
    public class InvalidListException : Exception
    {
        public InvalidListException()
        : base("A list nem tartalmaz elemeket") { }
    }
    public class ExceededNumberException : Exception
    {
        public ExceededNumberException()
        : base("Több adat megfelel a lekért értéknek") { }
    }
}

