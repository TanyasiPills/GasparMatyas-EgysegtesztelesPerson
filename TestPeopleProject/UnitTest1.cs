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
        public void InvalidPersonList()
        {
            List<Person> list = new List<Person>();
            Assert.Throws<InvalidListException>(() => statistics.getPersonWithHighestScore(list));
        }
        /*
        [Test]
        public void EmptyPersonList()
        {
            Assert.Throws<>(() => );
        }
        [Test]
        public void EmptyPersonList()
        {
            Assert.Throws<>(() => );
        }
        [Test]
        public void EmptyPersonList()
        {
            Assert.Throws<>(() => );
        }*/
    }
}