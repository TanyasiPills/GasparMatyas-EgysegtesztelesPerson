using PeopleProject;

namespace TestPeopleProject
{
    public class Tests
    {
        PersonStatistics statistics;
        

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyPersonList()
        {
            List<Person> list = new List<Person>();
            Assert.DoesNotThrow(() => statistics = new PersonStatistics(list));
        }
        [Test]
        public void NullPersonList()
        {
            List<Person> list = null;
            Assert.Throws<StatisticsConstructorException>(() => statistics = new PersonStatistics(list));
        }
        [Test]
        public void NegativeAvarageScore()
        {
            List<Person> list = new List<Person>();
            list.Add(new Person(1,"feri",12,true,-34));
            list.Add(new Person(2, "pista", 14, true, -2));
            Assert.Throws<NegativeAvarageException>(() => statistics.getAvarageScoreOfStudents(list));
        }
        [Test]
        public void NullPersonVariable()
        {
            Assert.Throws<NullVariableExceptioin>(() => new Person(2, null, 14, true, -2));
        }
        [Test]
        public void FuncrionWithoutPerson()
        {
            List<Person> persons = new List<Person>();
            Assert.Throws<InvalidListException>(() => statistics.getNumbrOfStudent(persons));
        }
        [Test]
        public void ExceedNumber()
        {
            List<Person> ps = new List<Person>();
            ps.Add(new Person(1, "János", 23, true, 78));
            ps.Add(new Person(2, "Ferenc", 20, true, 78));
            Assert.Throws<ExceededNumberException>(() => statistics.getPersonWithHighestScore(ps));
        }
        [Test]
        public void NegativeAgeStudent()
        {
            List<Person> ps = new List<Person>();
            ps.Add(new Person(1, "János", -1, true, 78));
            Assert.Throws<NegativeAgeException>(() => statistics.getOldestStudent(ps));
        }
    }
}