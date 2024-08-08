using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StrugglersShop
{
    internal class UserDB
    {
        private static User ApprovedUser = new User();

        private static List<User> userList = new List<User>();

        public UserDB() 
        { 
            LoadTextFile();
            if (userList.Count == 0)
            {
                User u = new User();
                u.Name = "Jack";
                u.Password = "12345";
                userList.Add(u);
            }
        }
        private void LoadTextFile()
        {
            try
            {
                string contents = File.ReadAllText(@"C:\Users\lab_services_student\source\repos\StrugglersShop\StrugglersShop\login.txt");
                MessageBox.Show(contents);
                Console.WriteLine(contents);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                MessageBox.Show(ex.ToString()); 
            }
        }
        private void UpdateTextFile()
        {

        }

        public void AddUser(User user)
        {
            userList.Add(user);
        }
        public override string ToString()
        {
            string strOutput = "";
            foreach (var item in userList)
            {
                strOutput += "Name : " + item.Name + ", Password: " + item.Password;
            }
            return strOutput;
        }

        public bool CheckUser(User user)
        {
            bool Valid = false;
            foreach (var item in userList)
            {
                if (item.Name == user.Name)
                {

                    if (item.Name.Equals(user.Password))
                    {
                        Valid = true;
                        ApprovedUser = item;
                        break;


                    }

                }
            }
            return Valid;
        }
        public bool CheckIfExists(string user)
        {
            bool bFound = false;
            foreach (var item in userList)
            {
                if(item.Equals(user))
                {
                    bFound = true;
                    break;
                }
            }
            return bFound;
        }

        internal string CurrentUser()
        {
            return ApprovedUser.Name;
        }
    }
}

