namespace HRM_API.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? password { get; set; }
        public int isActive { get; set; }
    }
}
