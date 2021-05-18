using NUnit.Framework;
using System;
using System.Collections.Generic;
using codigo.produccion.Interfaces;
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
            string pathTeams = "";
            string pathTopics = "";
            double porcentError = 0.05;
            int executionQuantity = 1000;
            int teamsQuantity = 5;

            bool passTest = true;

            var students = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < executionQuantity; i++)
            {
                var teams = new List<IEquipo>(); // Aqui se van a generar los equipos
                
                // Aqui se van a asignar los temas
                foreach (var team in teams)
                {
                    foreach (var student in team.Estudiantes)
                    {
                        if (students.ContainsKey(student)) {
                            if (students[student].ContainsKey(team.Nombre)) {
                                students[student][team.Nombre] += 1;
                                continue;
                            }
                            students[student].Add(team.Nombre, 1);
                            continue;
                        }
                        students.Add(student, new Dictionary<string, int>());
                        students[student].Add(team.Nombre, 1);
                    }
                }

                foreach (var student in students) 
                {
                    if (!passTest) {
                        break;
                    }

                    foreach (var team in student.Value.Keys)
                    {
                        double frequency = (double)students[student.Key][team] / (double) executionQuantity;
                        double probability = (double) 1 / (double) teamsQuantity;
                        if (frequency < probability - porcentError || frequency > probability + porcentError) {
                            passTest = false;
                            break;
                        }
                    }
                }
            }
            
            Assert.IsTrue(passTest);

        }

    }
}