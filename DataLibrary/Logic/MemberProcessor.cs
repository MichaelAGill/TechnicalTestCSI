using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class MemberProcessor
    {
        public static int CreateEmployee(string memberID, string firstName, string lastName, string emailAddress)
        {
            MemberModel data = new MemberModel
            {
                MemberID = memberID,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress
            };

            string sql = @"insert into dbo.Member (MemberID, FirstName, LastName, EmailAddress)
                           values (@MemberID, @FirstName, @LastName, @EmailAddress);";

            return SQLDataAccess.SaveData(sql, data);
        }

        public static List<MemberModel> LoadMembers()
        {
            string sql = @"select MemberID, FirstName, LastName, EmailAddress
                           from dbo.Members;";

            // Pass in the MemberModel with the SQL statement
            return SQLDataAccess.LoadData<MemberModel>(sql);
        }
    }
}
