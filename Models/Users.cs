namespace FixedAsset.Models
{
    public class Users
    {
        public int Id { get; set; }
        public required string Username { get; set; } // Ensures this must be set during object initialization
        public required string Password { get; set; } // Ensures this must be set during object initialization
    }
}
