
namespace Permission_System
{
    [Flags]
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Insert = 2,
        Update = 4,
        Delete = 8,
        All = Read | Insert | Update | Delete
    }
}
