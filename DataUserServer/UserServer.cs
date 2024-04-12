using Model_Users_Data;
using System.Linq.Expressions;

namespace DataUserServer
{
    public class UserServer
    {
        List<Users> dummyUsers = new List<Users>();

        public UserServer()
        {
            CreateDummyData();
        }

        private void CreateDummyData()
        {

            Users users1 = new Users { userID = "BTS-1992-04-12", pass = "Jin" };
            Users users2 = new Users { userID = "BTS-1993-09-03", pass = "Suga" };
            Users users3 = new Users { userID = "BTS-1994-18-02", pass = "Jhope" };
            Users users4 = new Users { userID = "BTS-1994-12-09", pass = "RM" };
            Users users5 = new Users { userID = "BTS-1995-13-10", pass = "Jimin" };
            Users users6 = new Users { userID = "BTS-1995-30-12", pass = "V" };
            Users users7 = new Users { userID = "BTS-1997-01-09", pass = "Jungkook" };

            dummyUsers.Add(users1);
            dummyUsers.Add(users2);
            dummyUsers.Add(users3);
            dummyUsers.Add(users4);
            dummyUsers.Add(users5);
            dummyUsers.Add(users6);
            dummyUsers.Add(users7);

        }

        public Users GetDummyData(string userID, string passs)
        {
            Users foundUser = new Users();

            foreach(var dummy in dummyUsers )
            {
                if(userID ==dummy.userID && passs == dummy.pass)

                {
                    foundUser = dummy;
                }     
            }
            return foundUser;
        }
    }

    }

 