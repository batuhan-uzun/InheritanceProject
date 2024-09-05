using InheritanceProject;

Teacher teacher = new Teacher()
{
    Name = "Ahmet",
    Surname = "Yılmaz",
    Salary = 30000
};

Student student = new Student()
{
    Name = "Mehmet",
    Surname = "Yıldırım",
    StudentID = 25
};

teacher.printTeacherInfo();
student.printStudentInfo();