﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitory
{
     internal class ContactInfoRepository:BaseRepository<ContactInfo>, IContactInfoRepository
    {
        public ContactInfoRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
