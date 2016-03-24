using MusicShop.Entities;
using System.Security.Cryptography;
using System.Text;

namespace MusicShop.DesktopUI.Code
{
    public static class CurrentUser
    {
        private static User currentUser;

        public static void Initialize(User user)
        {
            currentUser = user;
        }

        public static int Id
        {
            get
            {
                return currentUser.Id;
            }
        }

        public static string Name
        {
            get
            {
                return currentUser.Name;
            }
        }

        public static string Surname
        {
            get
            {
                return currentUser.Surname;
            }
        }
         // This might be in separate file or class
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
