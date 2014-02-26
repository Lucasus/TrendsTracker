﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendsTracker.Entities;
using TrendsTracker.Persistence;

namespace TrendsTracker.Reps
{
    public class KeywordRepository
    {
        public void AddKeyword(Keyword keyword)
        {
            using (var context = new PersistenceContext())
            {
                context.Keywords.Add(keyword);
                context.SaveChanges();
            }
        }
    }
}
