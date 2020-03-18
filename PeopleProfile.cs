namespace Fake_Dashboard
{
    class PeopleProfile
    {
        string _UPI;
        string _Password;
        string _FirstName;
        string _Surname;
        string _Gender;
        string _DateOfBirth;
        string _Email;
        string _PhoneNum;
        public string UPI { get => _UPI; set => _UPI = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string Surname { get => _Surname; set => _Surname = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public string DateOfBirth { get => _DateOfBirth; set => _DateOfBirth = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string PhoneNum { get => _PhoneNum; set => _PhoneNum = value; }
        public string Password { get => _Password; set => _Password = value; }

        public PeopleProfile(string LoginUpi)
        {
            UPI = LoginUpi;
        }


    }
}
