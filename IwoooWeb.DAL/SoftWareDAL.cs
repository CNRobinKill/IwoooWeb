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
    public class SoftWareDAL
    {
        //private const string SPGetSoftWareType = "GetSoftWareType";
        //private const string SPGetSoftWare = "GetSoftWare";
        //private const string SPGetSoftWareContentBySoftWareName = "GetSoftWareContentBySoftWareName";
        //private const string SPGetSoftWareIndex = "GetSoftWareIndex";
        //private const string SPAddSoftWare = "AddSoftWare";
        //private const string SPGetSoftWareById = "GetSoftWareById";
        //private const string SPGetAllSoftWare = "GetAllSoftWare";
        //private const string SPUpdSoftWare = "UpdSoftWare";
        //private const string SPDelSoftWareById = "DelSoftWareById";

        public static DataSet GetSoftWareType()
        {
            string sql = "select softWareType from SoftWare group by softWareType order by softWareType";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static DataSet GetSoftWare(string softWareType, string index)
        {
            string sql = "select *  from (select count(a.id) as row,a.softWareName,a.softWarePhoto from SoftWare a inner join SoftWare b on a.id >= b.id where a.softWareType='" + softWareType + "' group by a.softWareName,a.softWarePhoto)n where n.row>9*(" + index + "-1) and n.row<9*" + index + "+1 order by n.softWareName";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static string GetSoftWareContentBySoftWareName(string softWareName)
        {
            string sql = "select softWareContent from SoftWare where softWareName='" + softWareName + "'";
            return (string)Common.SqlHelper.ExecuteScalar(sql);
        }

        public static int GetSoftWareIndex(string softWareType)
        {
            string sql = "select  int(IIF( MAX(rNo) mod 9 = 0,MAX(rNo) / 9 , MAX(rNo) / 9 + 1)) as rIndex from (select a.id, count(*) as rNo from SoftWare a inner join SoftWare b on a.id >= b.id where a.softWareType='" + softWareType + "' group by a.id ) as t";
            return int.Parse(Common.SqlHelper.ExecuteScalar(sql).ToString());
        }

        public static int AddSoftWare(string softWareType, string softWareName, string softWarePhoto, string softWareContent)
        {
            string sql = "insert into SoftWare(softWareType,softWareName,softWarePhoto,softWareContent) values ('" + softWareType + "','" + softWareName + "','" + softWarePhoto + "','" + softWareContent + "')";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static OleDbDataReader GetSoftWareById(string id)
        {
            string sql = "select softWareType,softWareName,softWarePhoto,softWareContent from SoftWare where id=" + id;
            return Common.SqlHelper.ExecuteReader(sql);
        }

        public static DataSet GetAllSoftWare()
        {
            string sql = "select id,softWareType,softWareName,softWarePhoto,softWareContent from SoftWare order by softWareType";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static int UpdSoftWare(string id, string softWareType, string softWareName, string softWareContent)
        {
            string sql = "update SoftWare set softWareType='" + softWareType + "',softWareName='" + softWareName + "',softWareContent='" + softWareContent + "' where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int DelSoftWareById(string id)
        {
            string sql = "delete from SoftWare where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
