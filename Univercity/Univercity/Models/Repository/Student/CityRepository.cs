using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Univercity.Models.Repository.Student
{
    public class CityRepository : ICity
    {
        univercityEntities db = new Models.univercityEntities();

        public int DeleteCity(tbl_show_city _city)
        {
            db.tbl_show_city.Remove(_city);
            return db.SaveChanges();
        }

        public List<tbl_show_city> FinCities(int StateID)
        {
            List<tbl_show_city> city = db.tbl_show_city.Where(c => c.code_state == StateID).ToList();
            return city;
        }

        public tbl_show_city FindCity(int id)
        {
            tbl_show_city city = db.tbl_show_city.Where(c => c.code_city == id).SingleOrDefault();
            return city;
            
        }

        public int InsertCity(tbl_show_city _city)
        {
            db.tbl_show_city.Add(_city);
          return  db.SaveChanges();
        }

        public int InsertListCities(IEnumerable<tbl_show_city> liCity)
        {
            db.tbl_show_city.AddRange(liCity);
            return db.SaveChanges();

        }

        public int UpdateCity(tbl_show_city _city)
        {

            db.Entry(_city).State = System.Data.Entity.EntityState.Modified;
                
             return db.SaveChanges();

        }
    }
}