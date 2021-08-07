using MyContacts.Domain.Entities;
using MyContacts.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Repository.Repositories
{
    public class NaturalPersonRepository : BaseRepository<NaturalPerson>
    {
        public NaturalPersonRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
