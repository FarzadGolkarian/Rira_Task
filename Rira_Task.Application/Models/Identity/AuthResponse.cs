namespace TDS_Food.Application.Models.Identity
{
    public class AuthResponse
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int PersonnelID { get; set; }
        public string Token { get; set; }
        public string companyName { get; set; }
        public string unit { get; set; }
        public int Duration { get; set; }
        public bool IsAdmin { get; set; }
    }
}
