namespace Permission_System.Models
{
    public class Admin : User
    {
        public DateTime HireDate { get; set; }
        public int YearsOfExp { get; set; }
        public Admin()
        {
        }
        public Admin(string username, string password)
        {
            UserName = username;
            Password = password;
            Role = "Admin";
        }
    }
}