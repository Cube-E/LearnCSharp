using System;

namespace UserControl
{
    class UserAccountControl
    {
        class Customer
        {
            public void Login()
            {
                //login approval
                    //check username
                    //check password
                    //check ip



            }
            public void Edit_PersonalInformation()
            {
                //edit personal information
                // photo
                // name last first middle
                // birthday
                // gender / title

            }
            public void Set_PersonalInformation()
            {
                //
                // photo
                // name last first middle
                // birthday
                // gender / title
            }
        }

        class Employee : Customer
        {
            //view CustomerData


            
        }

        class Manager : Employee
        {
            public void View_CustomerStatistics() { }
            public void View_EmployeeStatistics() { }


        }

        class Admin : Manager
        {   

            public void Create_User() { }
            public void Delete_User() { }
            public void View_ManagerStatistics() { }
            /// TODO
            /// Edit UserPrivileges
            /// Enable/Disable Software Module
            /// ENA/DIS SYSTEM ALERTS
            /// RESET USER PASSWORDS
            /// LOCK/UNLOCK USERACCOUNTS


        }
        class System
        {
            public void Log_Information() { }
            public void Create_User() { }
            /// get/set/view user statistics
            /// display closing warning for application
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
    }