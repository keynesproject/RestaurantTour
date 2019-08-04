using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using RestaurantTour.Model.Extension;

namespace RestaurantTour.Model.DataAccessObject
{
    internal class DaoSQL
    {
        #region Singleton物件宣告，Thread safe，並在使用時才會建立實體

        private static readonly DaoSQL m_instance = new DaoSQL();

        internal static DaoSQL Instance { get { return m_instance; } }
                
        private DaoSQL()
        {
        }

        #endregion Singleton物件宣告

        /// <summary>
        /// 資料庫讀取物件
        /// </summary>
        private DaoDbCommon m_SQL = null;

        /// <summary>
        /// 連接使用的資料庫
        /// </summary>
        internal DaoErrMsg OpenDatabase()
        {
            DaoErrMsg Msg = new DaoErrMsg();
            try
            {
                Msg = ConnectSQLite();
                if (Msg.isError == true )
                {
                    throw new NotImplementedException(string.Format("Connect SQL Server database error. Message:{0}", Msg.ErrorMsg));                    
                }
            }
            catch (Exception ex)
            {
                Msg.isError = true;
                Msg.ErrorMsg = string.Format("Connect SQL Server database throw exception. Message:{0}", ex.Message);
                return Msg;
            }

            return Msg;
        }

        /// <summary>
        /// 關閉資料庫連接
        /// </summary>
        internal void CloseDatabase()
        {
            if (m_SQL == null)
                return;

            m_SQL.Close();

            m_SQL = null;
        }

        private DaoDbCommon CreateDbCom(string DbPath)
        {
            string DbPW = "BIS";
            string strConnection = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}; User ID=Admin;Jet OLEDB:Database Password={1};",
                                                 DbPath, DbPW);

            return new DaoDbCommon(strConnection, new OleDbConnection());
        }

        private DaoErrMsg ConnectSQLite()
        {
            DaoErrMsg Err = new DaoErrMsg();

            if (m_SQL != null)
            {
                //表示已開啟過;//
                return Err;
            }

            //連接Sqlite;//
            string SQLiteConn = @"Data source = ./MYP.db; Password = Myp53750804; DateTimeKind = Utc";
            m_SQL = new DaoDbCommon(SQLiteConn, new SQLiteConnection());
            Err = m_SQL.Connect();
            if (Err.isError)
            {
                System.Diagnostics.Debug.WriteLine(Err.ErrorMsg);
                m_SQL = null;
                return Err;
            }

            return Err;
        }

        /// <summary>
        /// 照SQL語法取得Table資料
        /// </summary>
        /// <param name="Schema"></param>
        /// <returns></returns>
        private DataTable GetDataTable(string Schema, params object[] Values)
        {
            DataTable Dt;
            DaoErrMsg Err = m_SQL.GetDataTable(Schema, out Dt, Values);

            if (Err.isError)
                return null;

            return Dt;
        }

        /// <summary>
        /// 照SQL語法取得Table資料
        /// </summary>
        /// <param name="Schema"></param>
        /// <returns></returns>
        private DataTable GetDataTable(DaoDbCommon DbCom, string Schema, params object[] Values)
        {
            DataTable Dt;
            DaoErrMsg Err = DbCom.GetDataTable(Schema, out Dt, Values);

            if (Err.isError)
                return null;

            return Dt;
        }

        internal DaoErrMsg UpdatePersonnel(List<PersonnelContent> Personnel)
        {
            DaoErrMsg err = new DaoErrMsg();

            if (Personnel.Count <= 0)
                return err;            

            //先清除人員資資料;//
            string strSchema = string.Format("DELETE FROM tbPersonnel;");
            m_SQL.ExecuteNonQuery(strSchema);

            //更新資料;//
            int Count = 0;
            StringBuilder sbSchema = new StringBuilder();
            sbSchema.Append(@"insert into tbPersonnel( [Key], [JobNumber], [ChineseName], [EnglishName], [CardNumber], [Alias], [Voice], [TEL], [Phone]) values ");
            for (int i = 0; i < Personnel.Count; i++)
            {
                sbSchema.AppendFormat(@"('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'), "
                                      , Personnel[i].Key
                                      , Personnel[i].JobNumber
                                      , Personnel[i].ChineseName
                                      , Personnel[i].EnglicshName
                                      , Personnel[i].CardNumber
                                      , Personnel[i].Alias
                                      , Personnel[i].Voice
                                      , Personnel[i].TEL
                                      , Personnel[i].Phone);
                Count++;

                if (Count >= 50)
                {
                    sbSchema.RemoveLast(",");
                    err = m_SQL.ExecuteNonQuery(sbSchema.ToString());
                    if (err.isError == true)
                        return err;

                    sbSchema.Length = 0;
                    sbSchema.Capacity = 0;
                    Count = 0;
                    sbSchema.Append(@"insert into tbPersonnel( [Key], [JobNumber], [ChineseName], [EnglishName], [CardNumber], [Alias], [Voice], [TEL], [Phone]) values ");
                }
            }

            if (Count != 0)
            {
                sbSchema.RemoveLast(",");
                err = m_SQL.ExecuteNonQuery(sbSchema.ToString());
            }

            return err;
        }

        internal DaoErrMsg UpdateAttendance(List<Attendance> attendance)
        {
            DaoErrMsg err = new DaoErrMsg();
            
            if (attendance.Count <= 0)
                return err;

            //先清除人員資資料;//
            string strSchema = string.Format("DELETE FROM tbAttendance;");
            m_SQL.ExecuteNonQuery(strSchema);

            //更新資料;//
            int Count = 0;
            StringBuilder sbSchema = new StringBuilder();
            sbSchema.Append(@"insert into tbAttendance( [CardNum], [Date], [Time]) values ");
            for (int i = 0; i < attendance.Count; i++)
            {
                sbSchema.AppendFormat(@"('{0}','{1}','{2}'), "
                                      , attendance[i].CardNo
                                      , attendance[i].Time.ToString("yyyyMMdd")
                                      , attendance[i].Time.ToString("HHmm"));
                Count++;

                if (Count >= 50)
                {
                    sbSchema.RemoveLast(",");
                    err = m_SQL.ExecuteNonQuery(sbSchema.ToString());
                    if (err.isError == true)
                        return err;

                    sbSchema.Length = 0;
                    sbSchema.Capacity = 0;
                    Count = 0;
                    sbSchema.Append(@"insert into tbAttendance( [CardNum], [Date], [Time]) values ");
                }
            }

            if (Count != 0)
            {
                sbSchema.RemoveLast(",");
                err = m_SQL.ExecuteNonQuery(sbSchema.ToString());
            }

            return err;
        }

        internal DateTime GetOldestDate()
        {
            string strSchema = "SELECT * FROM tbAttendance ORDER BY Date LIMIT 1;";

            DataTable dt = GetDataTable(strSchema);

            if (dt.Rows.Count <= 0)
                return DateTime.Today;

            return DateTime.ParseExact(dt.Rows[0]["Date"].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
        }

        internal DataTable GetAll(DateTime Start, DateTime End, string Name, string Phone, string CatrdNum)
        {
            StringBuilder sbSchema = new StringBuilder();
            sbSchema.AppendFormat(@"select A.Key, A.ChineseName, A.Phone, A.CardNumber, C.Date || '-' || C.Time as 'Date' FROM tbPersonnel A 
                                      left join ( select * FROM tbAttendance B where B.Date>={0} and B.Date<={1} ) C on A.CardNumber = C.CardNum "
                                    , Start.ToString("yyyyMMdd")
                                    , End.ToString("yyyyMMdd"));

            if (Name.Length > 0 || Phone.Length > 0 || CatrdNum.Length > 0)
                sbSchema.Append(" WHERE ");

            if (Name.Length > 0)
                sbSchema.AppendFormat("A.ChineseName='{0}' ",Name);

            if(Phone.Length > 0)
            {
                sbSchema.AppendFormat("{0} A.Phone='{1}' ",
                                       Name.Length > 0 ? "and" : "",
                                       Phone);
            }

            if (CatrdNum.Length > 0)
            {
                sbSchema.AppendFormat("{0} A.CardNumber='{1}' ",
                                       Name.Length > 0 || Phone.Length > 0 ? "and" : "",
                                       CatrdNum);
            }

            DataTable dt = GetDataTable(sbSchema.ToString());

            dt.Columns.Add("Count", typeof(string));
            
            for(int i=0; i< dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Date"].ToString().Length <= 0)
                {
                    dt.Rows[i]["Count"] = 0;
                }
                else
                {
                    dt.Rows[i]["Count"] = 1;
                }
            }

            return dt;
        }

        internal DataTable GetCount(DateTime Start, DateTime End, string Name, string Phone, string CatrdNum)
        {
            StringBuilder sbSchema = new StringBuilder();
            sbSchema.AppendFormat(@"select A.Key, A.ChineseName, A.Phone, A.CardNumber, B.Date || '-' || B.Time as 'Date', B.Count FROM tbPersonnel A 
                                    left join (select *, count(C.CardNum) as 'Count' from ( select * from tbAttendance D group by D.CardNum, D.Date order by D.Date ) C where C.Date >= {0} and C.Date <= {1} group by C.CardNum ) B on A.CardNumber = B.CardNum "
                                    , Start.ToString("yyyyMMdd")
                                    , End.ToString("yyyyMMdd"));

            if (Name.Length > 0 || Phone.Length > 0 || CatrdNum.Length > 0)
                sbSchema.Append(" WHERE ");

            if (Name.Length > 0)
                sbSchema.AppendFormat("A.ChineseName='{0}' ", Name);

            if (Phone.Length > 0)
            {
                sbSchema.AppendFormat("{0} A.Phone='{1}' ",
                                       Name.Length > 0 ? "and" : "",
                                       Phone);
            }

            if (CatrdNum.Length > 0)
            {
                sbSchema.AppendFormat("{0} A.CardNumber='{1}' ",
                                       Name.Length > 0 || Phone.Length > 0 ? "and" : "",
                                       CatrdNum);
            }

            DataTable dt = GetDataTable(sbSchema.ToString());

            return dt;
        }

        internal void DeleteData()
        {
            string strSchema = "DELETE FROM tbAttendance; DELETE FROM tbPersonnel;";
            m_SQL.ExecuteNonQuery(strSchema);
        }
    }
}