namespace Permission_System.Models
{
    public class Supervisor : User
    {
        public string SectionName { get; set; }
        public Supervisor()
        {
        }
        public Supervisor(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
            this.Role = "Supervisor";
        }
    }
}