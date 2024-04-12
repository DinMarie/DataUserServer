using DataUserServer;
using Model_Users_Data;
using System;


namespace BusinessServiceUser
{
    public class Business
    {
        public bool Verification(string userID, string pass)
        {
            UserServer dataservice = new UserServer();
            var result = dataservice.GetDummyData(userID, pass);

            if (result.userID == userID && result.pass == pass)
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
