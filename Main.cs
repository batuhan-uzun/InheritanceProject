using InheritanceProject;

Teacher teacher = new Teacher() // Created object from Teacher class
{
    Name = "Ahmet",
    Surname = "Yılmaz",
    Salary = 30000
};

Student student = new Student() // Created object from Student class
{
    Name = "Mehmet",
    Surname = "Yıldırım",
    StudentID = 25
};

teacher.PrintTeacherInfo(); // Teacher information printed
student.PrintStudentInfo(); // Student information printed
