namespace GradeBook
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Role { get; set; } = "Student";   // "Student" or "Instructor"
    }
    public class Grade
    {
        public int Id { get; set; }
        public string StudentUsername { get; set; } = "";
        public string Subject { get; set; } = "";
        public int Score { get; set; }
    }
}