using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ho.Models
{
    public class AccountModel
    {
        private List<Account> List = new List<Account>();

        public AccountModel()
        {
            List.Add(new Account { Username = "acc1", Password = "123", Roles = "1"});
            List.Add(new Account { Username = "acc2", Password = "123", Roles = "1"});
            List.Add(new Account { Username = "acc3", Password = "123", Roles = "1" });
        }

    }
}