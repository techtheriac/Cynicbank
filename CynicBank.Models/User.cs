namespace Models
{
    public class User
    {
        /// <summary>
        /// Models Customer details
        /// </summary>
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
