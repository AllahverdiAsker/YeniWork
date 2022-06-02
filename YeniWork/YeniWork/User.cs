using System;
using System.Collections.Generic;
using System.Text;

namespace YeniWork
{
    class User
    {
        private string _username;
        private string _password;
        
        
            
            public void SetUsername(string username)

            {

            if(username!=null && username.Length>5 && username.Length<26)
            {
                _username = username;

            }

            }
            public void SetPassword(string password)
            {
            if(password.Length>7 && password.Length < 26)
            {
                for(int i = 0; i < password.Length; i++)
                {
                    
                    if (HasDigit(password)&&HasUpper(password)&& HasLower(password))
                    {

                        _password = password;

                    }
                }
            }            
            }
        public bool HasDigit(string password)
        {
            for(int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]));
                return true;

            }
            return false;
        }
        public bool HasUpper(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i])) ;
                return true;

            }
            return false;
        }
        public bool HasLower(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i])) ;
                return true;

            }
            return false;
        }

        public string GetUserName()
        {
            return _username;
        }


        public string GetPassword()
        {
            return _password;
        }

    }
}
