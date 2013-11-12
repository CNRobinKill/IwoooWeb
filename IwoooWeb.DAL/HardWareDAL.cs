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
    public class HardWareDAL
    {
        //private const string SPGetHardWareType = "GetHardWareType";
        //private const string SPGetHardWare = "GetHardWare";
        //private const string SPGetHardWareContentByHardWareName = "GetHardWareContentByHardWareName";
        //private const string SPGetHardWareIndex = "GetHardWareIndex";
        //private const string SPAddHardWare = "AddHardWare";
        //private const string SPGetHardWareById = "GetHardWareById";
        //private const string SPGetAllHardWare = "GetAllHardWare";
        //private const string SPUpdHardWare = "UpdHardWare";
        //private const string SPDelHardWareById = "DelHardWareById";

        public static DataSet GetHardWareType()
        {
            string sql = "select hardWareType from HardWare group by hardWareType order by hardWareType";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static DataSet GetHardWare(string hardWareType, string index)
        {
            string sql = "select *  from (select count(a.id) as row,a.hardWareName,a.hardWarePhoto from HardWare a inner join HardWare b on a.id >= b.id where a.hardWareType='" + hardWareType + "' group by a.hardWareName,a.hardWarePhoto)n where n.row>9*(" + index + "-1) and n.row<9*" + index + "+1 order by n.hardWareName";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static string GetHardWareContentByHardWareName(string hardWareName)
        {
            string sql = "select hardWareContent from HardWare where hardWareName='" + hardWareName + "'";
            return (string)Common.SqlHelper.ExecuteScalar(sql);
        }

        public static int GetHardWareIndex(string hardWareType)
        {
            string sql = "select  int(IIF( MAX(rNo) mod 9 = 0,MAX(rNo) / 9 , MAX(rNo) / 9 + 1)) as rIndex from (select a.id, count(*) as rNo from HardWare a inner join HardWare b on a.id >= b.id where a.hardWareType='" + hardWareType + "' group by a.id ) as t";
            return int.Parse(Common.SqlHelper.ExecuteScalar(sql).ToString());
        }

        public static int AddHardWare(string hardWareType, string hardWareName, string hardWarePhoto, string hardWareContent)
        {
            string sql = "insert into HardWare(hardWareType,hardWareName,hardWarePhoto,hardWareContent) values ('" + hardWareType + "','" + hardWareName + "','" + hardWarePhoto + "','" + hardWareContent + "')";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static OleDbDataReader GetHardWareById(string id)
        {
            string sql = "select hardWareType,hardWareName,hardWarePhoto,hardWareContent from HardWare where id=" + id;
            return Common.SqlHelper.ExecuteReader(sql);
        }

        public static DataSet GetAllHardWare()
        {
            string sql = "select id,hardWareType,hardWareName,hardWarePhoto,hardWareContent from HardWare order by hardWareType";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static int UpdHardWare(string id, string hardWareType, string hardWareName, string hardWareContent)
        {
            string sql = "update HardWare set hardWareType='" + hardWareType + "',hardWareName='" + hardWareName + "',hardWareContent='" + hardWareContent + "' where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int DelHardWareById(string id)
        {
            string sql = "delete from HardWare where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
