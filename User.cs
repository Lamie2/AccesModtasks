using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModtask
{
    class User
    {
        public User(string username)
        {
            this._userName = username;
        }
        private string _userName;
        private string _password;

        public string UserName
        {

            get
            {
                return this._userName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length>=6 && value.Length<=25)
                {
                    this._userName = value;

                }
            }
        }

        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 8 && value.Length <= 25 && HasDigit("password")==true && HasUpper("password")==true 
                    && HasLower("password")==true)
                {
                    this._password = value;
                }
            }

        }

        public bool HasDigit(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                return true;
                }                            
            }
            return false;
        }


        public bool HasUpper(string str1)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (char.IsUpper(str1[i]))
                {
                    return true;
                }
            }
            return false;
        }


        public bool HasLower(string str2)
        {
            for (int i = 0; i < str2.Length; i++)
            {
                if (char.IsLower(str2[i]))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
