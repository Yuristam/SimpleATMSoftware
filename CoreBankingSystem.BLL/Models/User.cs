namespace CoreBankingSystem.BLL.Models
{
    public class User
    {
        public User(int id, string fullName, string login, string password, string confirmPassword)
        {
            Id = id;
            FullName = fullName;
            Login = login;
            Password = password;
            ConfirmPassword = confirmPassword;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
