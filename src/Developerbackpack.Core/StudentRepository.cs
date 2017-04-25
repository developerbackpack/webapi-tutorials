using System.Collections.Generic;

namespace Developerbackpack.Core
{
    public static class StudentRepository
    {
        public static IEnumerable<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Matthew Collins",
                    Major = "Chemistry"
                },
                new Student
                {
                    Id = 2,
                    Name = "Julie Adams",
                    Major = "Physics"
                },
                new Student
                {
                    Id = 3,
                    Name = "Jane Donovan",
                    Major = "Biology"
                },
                new Student
                {
                    Id = 4,
                    Name = "Judith Aventor",
                    Major = "Mathematics"
                },
                new Student
                {
                    Id = 5,
                    Name = "Edgar Poe",
                    Major = "Philosophy"
                },
                new Student
                {
                    Id = 6,
                    Name = "Nancy Drew",
                    Major = "Sociology"
                },
                new Student
                {
                    Id = 7,
                    Name = "Dwayne Wade",
                    Major = "Sports Science"
                }

            };
        }
    }
}
