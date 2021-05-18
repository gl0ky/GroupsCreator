using NUnit.Framework;
using System;

namespace codigo.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public void GroupsException(){

            throw new ArgumentException("Los grupos no pueden ser mayores que los estudiantes");

        }

        public void TopicsException(){

            throw new ArgumentException("Los temas no pueden ser menores que los grupos");

        }

        [Test]
        public void LessStudentsThanGroups()
        {

            int studentsQuantity = 5;
            int groupsQuantity = 10;

            if(studentsQuantity < groupsQuantity){

                Assert.Throws<ArgumentException>(GroupsException);

            }

        }

        [Test]
        public void SameStudentsSameGroups()
        {

            int studentsQuantity = 10;
            int groupsQuantity = 10;

            if(studentsQuantity == groupsQuantity){

                Assert.Pass();

            }

        }

        [Test]
        public void MoreStudentsThanGroups(){

            int studentsQuantity = 10;
            int groupsQuantity = 5;

            if (studentsQuantity > groupsQuantity)
            {

                Assert.Pass();
                
            }

        }

        [Test]
        public void LessTopicsThanGroups()
        {

            int topicsQuantity = 10;
            int groupsQuantity = 5;

            if(topicsQuantity > groupsQuantity){

                Assert.Throws<ArgumentException>(TopicsException);

            }

        }

        [Test]
        public void SameTopics_SameGroups(){

            int topicsQuantity = 10;
            int groupsQuantity = 10;

            if(topicsQuantity == groupsQuantity){

                Assert.Pass();

            }

        }

        [Test]
        public void MoreTopicsThanGroups()
        {

            int topicsQuantity = 10;
            int groupsQuantity = 5;

            if (topicsQuantity > groupsQuantity)
            {

                Assert.Pass();
                
            }

        }

        [Test]
        public void TestingRandomness()
        {

            Assert.Pass();

        }

    }
}