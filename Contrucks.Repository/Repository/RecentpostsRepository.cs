﻿using Contrucks.model;
using Contrucks.model.ViewModels;
using Contrucks.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Repository
{
  
        public class RecentpostsRepository : RepositoryBase<RecentpostViewmodel>, IRecentpostsRepository
        {
            public RecentpostsRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
            {
            }

        public void Add(NewJobPosts usertables)
        {
            throw new NotImplementedException();
        }
    }
        public interface IRecentpostsRepository : IRepositoryBase<RecentpostViewmodel>
        {
            IEnumerable<RecentpostViewmodel> GetAll();
            void Add(NewJobPosts usertables);
        }

    }

