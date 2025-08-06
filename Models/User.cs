namespace Permission_System.Models
{
    public class User 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Permissions UserPermissions = Permissions.None;
        public static User GetUser(string name, string pass)
        {
            Data.Data data = new Data.Data();

            if (name == "manager" && pass == "manager2025")
            {
                foreach (var manager in data.Managers)
                {
                    if (manager.UserName == name && manager.Password == pass)
                        return manager;
                }
            }
            else if (name == "admin" && pass == "admin2025")
            {
                foreach (var admin in data.Admins)
                {
                    if (admin.UserName == name && admin.Password == pass)
                        return admin;
                }
            }
            else if (name == "supervise" && pass == "supervise2025")
            {
                foreach (var supervisor in data.Supervisors)
                {
                    if (supervisor.UserName == name && supervisor.Password == pass)
                        return supervisor;
                }
            }

            Guest guest = new Guest();
            guest.UserName = name;
            guest.Role = "Guest";
            guest.UserPermissions = Permissions.Read;
            return guest;
        }
    }
}