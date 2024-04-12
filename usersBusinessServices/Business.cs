using DataUserServer;
using Model_Users_Data;
using System;


namespace usersBusinessServices
{
    public class Business
    {
        public bool Verification(string userID, string pass)
        {
            UserServer dataservice = new UserServer();
            var result = dataservice.GetDummyData(userID, pass);

            if (result.userID && result.pass == pass)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
