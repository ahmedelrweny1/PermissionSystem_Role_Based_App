using Permission_System.Models;

namespace Permission_System.Data
{
    public class Data
    {
        public List<Manager> Managers = new List<Manager>();
        public List<User> Users = new List<User>();
        public List<Supervisor> Supervisors = new List<Supervisor>();
        public List<Admin> Admins = new List<Admin>();
        public List<Guest> Guests = new List<Guest>();

        public Data()
        {
            AddData();
        }

        void AddData()
        {
            var manager = new Manager("manager", "manager2025");
            manager.UserPermissions = Permissions.All;
            Managers.Add(manager);

            var admin = new Admin("admin", "admin2025");
            admin.UserPermissions = Permissions.Read | Permissions.Insert | Permissions.Update;
            Admins.Add(admin);

            var supervisor = new Supervisor("supervise", "supervise2025");
            supervisor.UserPermissions = Permissions.Read | Permissions.Insert;
            Supervisors.Add(supervisor);

            Managers.AddRange(new List<Manager>
            {
                new Manager() { Name = "Ahmed Hassan", UserName = "ahmed.hassan", Password = "pass123", Age = 35, Address = "Cairo", PhoneNumber = "01234567890", Role = "Manager", UserPermissions = Permissions.All },
                new Manager() { Name = "Fatma Ali", UserName = "fatma.ali", Password = "pass123", Age = 32, Address = "Alexandria", PhoneNumber = "01234567891", Role = "Manager", UserPermissions = Permissions.All },
                new Manager() { Name = "Mohamed Salah", UserName = "mohamed.salah", Password = "pass123", Age = 40, Address = "Giza", PhoneNumber = "01234567892", Role = "Manager", UserPermissions = Permissions.All },
                new Manager() { Name = "Nour Ibrahim", UserName = "nour.ibrahim", Password = "pass123", Age = 28, Address = "Mansoura", PhoneNumber = "01234567893", Role = "Manager", UserPermissions = Permissions.All },
                new Manager() { Name = "Omar Khaled", UserName = "omar.khaled", Password = "pass123", Age = 38, Address = "Aswan", PhoneNumber = "01234567894", Role = "Manager", UserPermissions = Permissions.All }
            });

            Admins.AddRange(new List<Admin>
            {
                new Admin() { Name = "Yasmin Mahmoud", UserName = "yasmin.mahmoud", Password = "admin123", Age = 30, Address = "Cairo", PhoneNumber = "01234567895", Role = "Admin", UserPermissions = Permissions.Read | Permissions.Insert | Permissions.Update },
                new Admin() { Name = "Kareem Adel", UserName = "kareem.adel", Password = "admin123", Age = 29, Address = "Alexandria", PhoneNumber = "01234567896", Role = "Admin", UserPermissions = Permissions.Read | Permissions.Insert | Permissions.Update },
                new Admin() { Name = "Menna Samir", UserName = "menna.samir", Password = "admin123", Age = 27, Address = "Giza", PhoneNumber = "01234567897", Role = "Admin", UserPermissions = Permissions.Read | Permissions.Insert | Permissions.Update },
                new Admin() { Name = "Tamer Farouk", UserName = "tamer.farouk", Password = "admin123", Age = 33, Address = "Luxor", PhoneNumber = "01234567898", Role = "Admin", UserPermissions = Permissions.Read | Permissions.Insert | Permissions.Update },
                new Admin() { Name = "Dina Mostafa", UserName = "dina.mostafa", Password = "admin123", Age = 31, Address = "Sharm El Sheikh", PhoneNumber = "01234567899", Role = "Admin", UserPermissions = Permissions.Read | Permissions.Insert | Permissions.Update }
            });

            Supervisors.AddRange(new List<Supervisor>
            {
                new Supervisor() { Name = "Amr Youssef", UserName = "amr.youssef", Password = "super123", Age = 26, Address = "Cairo", PhoneNumber = "01234567800", Role = "Supervisor", UserPermissions = Permissions.Read | Permissions.Insert },
                new Supervisor() { Name = "Rana Hamed", UserName = "rana.hamed", Password = "super123", Age = 25, Address = "Alexandria", PhoneNumber = "01234567801", Role = "Supervisor", UserPermissions = Permissions.Read | Permissions.Insert },
                new Supervisor() { Name = "Hossam Gamal", UserName = "hossam.gamal", Password = "super123", Age = 28, Address = "Giza", PhoneNumber = "01234567802", Role = "Supervisor", UserPermissions = Permissions.Read | Permissions.Insert },
                new Supervisor() { Name = "Mariam Nasser", UserName = "mariam.nasser", Password = "super123", Age = 24, Address = "Ismailia", PhoneNumber = "01234567803", Role = "Supervisor", UserPermissions = Permissions.Read | Permissions.Insert },
                new Supervisor() { Name = "Youssef Ahmed", UserName = "youssef.ahmed", Password = "super123", Age = 27, Address = "Tanta", PhoneNumber = "01234567804", Role = "Supervisor", UserPermissions = Permissions.Read | Permissions.Insert }
            });

            Users.AddRange(new List<User>
            {
                new User() { Name = "Sara Abdel Rahman", UserName = "sara.abdel", Password = "user123", Age = 23, Address = "Cairo", PhoneNumber = "01234567805", Role = "User", UserPermissions = Permissions.Read },
                new User() { Name = "Mahmoud Fathy", UserName = "mahmoud.fathy", Password = "user123", Age = 22, Address = "Alexandria", PhoneNumber = "01234567806", Role = "User", UserPermissions = Permissions.Read },
                new User() { Name = "Nada Essam", UserName = "nada.essam", Password = "user123", Age = 24, Address = "Giza", PhoneNumber = "01234567807", Role = "User", UserPermissions = Permissions.Read },
                new User() { Name = "Karim Wael", UserName = "karim.wael", Password = "user123", Age = 21, Address = "Hurghada", PhoneNumber = "01234567808", Role = "User", UserPermissions = Permissions.Read },
                new User() { Name = "Layla Sherif", UserName = "layla.sherif", Password = "user123", Age = 25, Address = "Minya", PhoneNumber = "01234567809", Role = "User", UserPermissions = Permissions.Read }
            });

            Guests.AddRange(new List<Guest>
            {
                new Guest() { Name = "Rania Tarek", UserName = "rania.tarek", Password = "guest123", Age = 20, Address = "Cairo", PhoneNumber = "01234567810", Role = "Guest", UserPermissions = Permissions.Read },
                new Guest() { Name = "Eslam Magdy", UserName = "eslam.magdy", Password = "guest123", Age = 19, Address = "Alexandria", PhoneNumber = "01234567811", Role = "Guest", UserPermissions = Permissions.Read },
                new Guest() { Name = "Habiba Osama", UserName = "habiba.osama", Password = "guest123", Age = 21, Address = "Giza", PhoneNumber = "01234567812", Role = "Guest", UserPermissions = Permissions.Read },
                new Guest() { Name = "Ziad Hesham", UserName = "ziad.hesham", Password = "guest123", Age = 18, Address = "Zagazig", PhoneNumber = "01234567813", Role = "Guest", UserPermissions = Permissions.Read },
                new Guest() { Name = "Salma Reda", UserName = "salma.reda", Password = "guest123", Age = 22, Address = "Sohag", PhoneNumber = "01234567814", Role = "Guest", UserPermissions = Permissions.Read }
            });
        }
    }
}