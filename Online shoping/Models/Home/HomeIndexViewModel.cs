using Online_shoping.DAL;
using Online_shoping.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;

namespace Online_shoping.Models.Home
{
    public class HomeIndexViewModel
    {
        
        public IPagedList<Tbl_Product> ListOfProduct { get; set; }
        public GenericUnitWork _unitOfWork = new GenericUnitWork();
        dbMyshoppingEntities context = new dbMyshoppingEntities();
        public HomeIndexViewModel CreateModel(string search,int? page)
        {
            SqlParameter[] param = new SqlParameter[]
                {new SqlParameter("@search",search??(object)DBNull.Value)
                };
            IPagedList<Tbl_Product> data = context.Database.SqlQuery<Tbl_Product>("GetbySearch @search", param).ToList().ToPagedList(page?? 1,4);
            return new HomeIndexViewModel
            {
                ListOfProduct = data
            };
            
        }

    }
}