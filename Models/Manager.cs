namespace Permission_System.Models
{
    public class Manager : User
    {
        public DateTime HireDate { get; set; }
        public string DepartmentName { get; set; }
        public int YearsOfExp { get; set; }
        public Manager(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
            this.Role = "Manager";
        }
        public Manager()
        {
        }
    }
}