using MpvNet.Windows.WinForms.Models;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpvNet.Windows.Helper
{ 
    public class DbHelper
    {
        static readonly string dbname = "mmm.db";
        static SqlSugarClient Db;
        static DbHelper()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = $"datasource={dbname}",
                DbType = DbType.Sqlite,
                IsAutoCloseConnection = true
            },
            db =>
            {

                db.Aop.OnLogExecuting = (sql, pars) =>
                {

                    //获取原生SQL推荐 5.1.4.63  性能OK
                    Console.WriteLine(UtilMethods.GetNativeSql(sql, pars));

                    //获取无参数化SQL 对性能有影响，特别大的SQL参数多的，调试使用
                    //Console.WriteLine(UtilMethods.GetSqlString(DbType.SqlServer,sql,pars))


                };

                //注意多租户 有几个设置几个
                //db.GetConnection(i).Aop

            });
        }
        public static SqlSugarClient getIns()
        {
            return Db;
        }
        static public void init()
        {
            string dbFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbname);
            if (File.Exists(dbFile))
            {
                return;
            }
            ////建库
            DbHelper.getIns().DbMaintenance.CreateDatabase();//达梦和Oracle不支持建库 
            ////建表（看文档迁移）
            DbHelper.getIns().CodeFirst.InitTables<ResourceDetail>();
        }
    }
}
