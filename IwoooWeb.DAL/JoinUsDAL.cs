using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{
    public class JoinUsDAL
    {

        //private const string SPAddJoinUs = "AddJoinUs";
        //private const string SPGetJoinUs = "GetJoinUs";
        //private const string SPGetPositionContentByPosition = "GetPositionContentByPosition";
        //private const string SPUpdJoinUsById = "UpdJoinUsById";
        //private const string SPDelJoinUsById = "DelJoinUsById";



        public static int AddJoinUs(string position, string positionContent)
        {
            if (GetPosition(position) == 0)
            {
                string sql = "insert into JoinUs([position],positionContent) values('" + position + "','" + positionContent + "')";
                return Common.SqlHelper.ExecuteNonQuery(sql);
            }
            else
            {
                return 0;
            }
        }

        public static DataSet GetJoinUs()
        {
            string sql = "select id,[position] from JoinUs order by [position]";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static string GetPositionContentByPosition(string position)
        {
            string sql = "select positionContent from JoinUs where [position]='" + position + "'";
            return (string)Common.SqlHelper.ExecuteScalar(sql);
        }

        public static int UpdJoinUsById(string id, string position, string positionContent)
        {
            string sql = "update JoinUs set [position]='" + position + "',positionContent='" + positionContent + "' where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int DelJoinUsById(string id)
        {
            string sql = "delete from JoinUs where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int GetPosition(string position)
        {
            string sql = "select count([position]) from JoinUs where [position]='" + position + "'";
            return int.Parse(Common.SqlHelper.ExecuteScalar(sql).ToString());
        }
    }
}
