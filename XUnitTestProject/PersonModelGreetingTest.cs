using System;
using Xunit;
using ModelsClassLibrary;

namespace XUnitTestProject
{
    public class PersonModelGreetingTest
    {
        //Arrange, Asses, Assert
        [Fact]
        public void GoodMorningTest() //Should print good morning "lastName";
        {
            PersonModel person = new PersonModel();

            string expected = "Good morning Maxian";

            string actual = person.Greet("Maxian", 11);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GoodEveningTest() //Should print good evening "lastName";
        {
            PersonModel person = new PersonModel();

            string expected = "Good evening Maxian";

            string actual = person.Greet("Maxian", 17);
        }

        [Fact]
        public void GoodNightTest() //Should print good night "lastName";
        {
            PersonModel person = new PersonModel();

            string expected = "Good night Maxian";
            
            string actual = person.Greet("Maxian", 20); 
        }

        //[Theory]
        //InlineDataAttribute();
    }
}
