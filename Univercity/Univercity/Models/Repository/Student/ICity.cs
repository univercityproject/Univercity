using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercity.Models.Repository.Student
{
   public interface ICity
    {

        tbl_show_city FindCity(int id);
        List<tbl_show_city> FinCities(int StateID);

        int InsertCity(tbl_show_city _city);

        int InsertListCities(IEnumerable<tbl_show_city> liCity);

        int UpdateCity(tbl_show_city _city);
        int DeleteCity(tbl_show_city _city);

    }
}
