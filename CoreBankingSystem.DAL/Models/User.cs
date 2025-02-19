namespace CoreBankingSystem.DAL.Models
{
    public class User
    {
        public User(int id, string firstName, string lastName, string login, string password, string confirmPassword)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Login = login;
            Password = password;
            ConfirmPassword = confirmPassword;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get => $"{FirstName} {LastName}"; }
        public string ShortName { get => $"{FirstName} {LastName.Substring(0, 1)}."; }
        
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
