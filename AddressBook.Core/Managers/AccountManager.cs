using AddressBook.Core.Interfaces.Managers;
using AddressBook.Core.Interfaces.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Core.Managers
{
    class AccountManager : IAccountManager
    {
        IAccountQueries _queries;

        public AccountManager(IAccountQueries queries)
        {
            _queries = queries;
        }
    }
}
