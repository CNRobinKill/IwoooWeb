using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{ 
    public class CompanyNewsDAL
    {
        //private const string SPAddCompanyNews = "AddCompanyNews";
        //private const string SPGetCompanyNews = "GetCompanyNews";
        //private const string SPGetNewContentByNewTittle = "GetNewContentByNewTittle";
        //private const string SPGetNewContentById = "GetNewContentById";
        //private const string SPGetCompanyNewsIndex = "GetCompanyNewsIndex";
        //private const string SPDelCompanyNewsById = "DelCompanyNewsById";
        //private const string SPUpdCompanyNewsById = "UpdCompanyNewsById";


        public static int AddCompanyNews(string newTittle, string newContent, string newDate)
        {
            string sql = "insert into CompanyNews(newTittle,newContent,newDate) values('" + newTittle + "','" + newContent + "','" + newDate + "')";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static DataSet GetCompanyNews(string index)
        {
            string sql ="";
            if (index != "All")
            {
                sql = "select *  from (select count(a.id) as row,a.id,a.newTittle,a.newDate from CompanyNews a inner join CompanyNews b on a.id >= b.id group by a.id,a.newTittle,a.newDate)n where n.row>9*(" + index + "-1) and n.row<9*" + index + "+1 order by n.id desc";
            }
            else
            {
                sql = "select * from (select count(a.id) as row,a.id,a.newTittle,a.newDate from CompanyNews a inner join CompanyNews b on a.id >= b.id group by a.id,a.newTittle,a.newDate)n order by n.id desc";
            }
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static string GetNewContentByNewTittle(string newTittle)
        {
            string sql = "select newContent from CompanyNews where newTittle='" + newTittle + "'";
            return (string)Common.SqlHelper.ExecuteScalar(sql);
        }

        public static OleDbDataReader GetNewContentById(string id)
        {
            string sql = "select newTittle,newContent from CompanyNews where id=" + id;
            return Common.SqlHelper.ExecuteReader(sql);
        }

        public static int GetCompanyNewsIndex()
        {
            string sql = "select  int(IIF( MAX(rNo) mod 9 = 0,MAX(rNo) /  9 , MAX(rNo) / 9 + 1)) as rIndex from (select a.id, count(*) as rNo from CompanyNews a inner join CompanyNews b on a.id >= b.id group by a.id ) as t";
            return int.Parse(Common.SqlHelper.ExecuteScalar(sql).ToString());
        }

        public static int DelCompanyNewsById(string id)
        {
            string sql = "delete from CompanyNews where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int UpdCompanyNewsById(string id, string newTittle, string newContent)
        {
            string sql = "update CompanyNews set newTittle='"+newTittle+"',newContent='"+newContent+"' where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
