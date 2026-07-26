namespace StudentDepartmentAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; } // Foreign key to Department
        public Department Department { get; set; }   // Navigation property
    }

}

