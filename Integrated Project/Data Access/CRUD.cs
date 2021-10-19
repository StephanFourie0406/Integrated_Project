using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Integrated_Project.Data_Access;
using Integrated_Project.Models;

namespace Integrated_Project.Data_Access
{
    public static class CRUD
    {
        public static class User
        {
            public static bool Status(string Email)
            {
                String QueryString = $"EXEC LoginCheck @Email = '{Email}';";
                var output = Input_and_Output.Output(QueryString);

                IDictionary<string, object> valuePairs = output[0];
              //  bool x = (bool)valuePairs.FirstOrDefault();

                if (true)
                {
                    return true;
                }else
                {
                    return false;
                }  
            }

            public static Models.User Get(string Email)
            {
                String QueryString = $"EXEC GetUserByEmail @Email = '{Email}';";
                var output = Input_and_Output.Output(QueryString);

                Models.User user = new Models.User();

                
                return user;
            }

        }

    }
}