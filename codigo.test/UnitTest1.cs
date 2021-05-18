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

        [Test]
        public void LessStudentsThanGroups()
        {

            int studentsQuantity = 5;
            int groupsQuantity = 10;

            if(studentsQuantity < groupsQuantity){

                Assert.Throws<ArgumentException>(GroupsException);

            }
    }
}