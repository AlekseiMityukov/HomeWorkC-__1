using System.Text.RegularExpressions;

namespace HomeWorkC___1
{

    internal class Users 
    {
        internal string login; 
        internal string Login 
        {
            get { return login; }
            set 
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин слишком короткий");
                }
                else if (value.Length > 12) 
                {
                    Console.WriteLine("Логин слишком длинный");
                }
                else
                {
                    login = value;
                }
            } 
        }

        internal string password;
        internal string Password 
        {
            get { return password; }
            set
            { 
                bool CorrectDigit = value.Any(char.IsDigit);
                bool CorrectLetter = value.Any(char.IsLetter);
                if (CorrectDigit && CorrectLetter)
                {
                    password = value;
                }
                else 
                {
                    Console.WriteLine("В пароле должна быть хотя бы одна цифра, буква");
                }
            } 
        }



        internal string Mail { get; set; }

        internal string NickName { get; set; }

        public Users(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }



    
}
