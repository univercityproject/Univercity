using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using BL;


public class RepostitoryTest<TNameTbl> where TNameTbl:class,IUser
    {

    DbContext db;
    DbSet<TNameTbl> _dbset;
        public RepostitoryTest(DbContext _context)
    {
        db = _context;
        _dbset = db.Set<TNameTbl>();
    }

    TNameTbl FindUer(int id)
    {
        return _dbset.Where(c => c.ID == id).SingleOrDefault();
    }


    }
