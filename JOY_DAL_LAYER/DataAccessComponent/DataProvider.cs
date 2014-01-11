#region [Namespaces]
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.OracleClient;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
#endregion

namespace JOY_DAL_LAYER.DataAccessComponent
{
    public class DataProvider : IDisposable
    {
        #region [Constructor]

        public DataProvider()
        {

        }

        public DataProvider(string ConnectString, DBType Database)
        {
            this.ConnectionString = ConnectString;
            this.DatabaseType = Database;
        }

        #endregion

        #region [Database Enumerator]
       public  enum DBType
        {
            OLEDB,
            SQLSERVER,
            ORACLE,
            MYSQL
        };
        #endregion

        #region [Common Variables]
        private DBType _DatabaseType = DBType.SQLSERVER;
        private string _ConnectionString = "";
        IDbCommand command = null;
        IDbConnection connection = null;
        DataSet dataset = null;
        IDataAdapter adapter = null;
        IDataParameter parameter = null;
        IDbTransaction transaction = null;
        int res = 0;
        #endregion

        public DBType DatabaseType
        {
            get
            {
                return this._DatabaseType;
            }
            set
            {
                this._DatabaseType = value;
            }
        }

        public String ConnectionString
        {
            get
            {
                return this._ConnectionString;
            }
            set
            {
                this._ConnectionString = value;
            }
        }

        public int ExecuteNonQuery(string CmdText)
        {
            try
            {
                connection = this.GetConnection();
                command = this.GetCommand(CmdText, connection);
                connection.Open();
                res = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                res = 0;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
            return res;

        }

        public int ExecuteNonQuerySP(string procedureName, Dictionary<string, object> parameters)
        {
            try
            {
                connection = this.GetConnection();
                transaction = connection.BeginTransaction();
                command = this.GetCommand(procedureName, parameters);
                connection.Open();
                res = command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                res = 0;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
            return res;
        }

        public int ExecuteNonQuery(string CmdText, ref IDbTransaction transaction)
        {
            try
            {
                transaction = connection.BeginTransaction();
                connection = this.GetConnection();
                command = this.GetCommand(CmdText, connection);
                command.Transaction = transaction;
                connection.Open();
                res = command.ExecuteNonQuery();
                res = 1;
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                res = 0;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
            return res;
        }

        public int ExecuteNonQuery(string commandText, Dictionary<string, object> parameters)
        {
            try
            {
                connection = this.GetConnection();
                command = this.GetCommand(commandText, parameters);
                command.Connection = connection;
                command.Transaction = transaction;
                connection.Open();
                transaction = connection.BeginTransaction();
                res = command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                res = 0;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
            return res;
        }

        public IDataReader ExecuteReader(string CmdText)
        {
            try
            {
                connection = this.GetConnection();
                command = this.GetCommand(CmdText, connection);
                connection.Open();
                return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
                if (connection != null)
                {
                    connection.Dispose();
                }
            }

        }

        public object ExecuteScalar(string CmdText)
        {
            try
            {
                connection = this.GetConnection();
                command = this.GetCommand(CmdText, connection);
                connection.Open();
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
        }

        public DataSet FillDataSet(string CmdText)
        {
            try
            {
                connection = this.GetConnection();
                command = this.GetCommand(CmdText, connection);
                adapter = this.GetDataAdapter(command);

                dataset = new DataSet();
                adapter.Fill(dataset);
                return dataset;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
                if (connection != null)
                {
                    connection.Dispose();
                }
            }

        }

        public IDbConnection GetConnection()
        {
            switch (this.DatabaseType)
            {
                case DBType.OLEDB:
                    connection = new OleDbConnection(this.ConnectionString);
                    break;
                case DBType.SQLSERVER:
                    connection = new SqlConnection(this.ConnectionString);
                    break;
                case DBType.ORACLE:
                    connection = new OracleConnection(this.ConnectionString);
                    break;
                case DBType.MYSQL:
                    connection = new MySqlConnection(this.ConnectionString);
                    break;
                default:
                    connection = null;
                    break;
            }
            return connection;
        }

        public IDbCommand GetCommand(string CmdText, IDbConnection Connection)
        {
            switch (this.DatabaseType)
            {
                case DBType.OLEDB:
                    command = new OleDbCommand(CmdText, connection as OleDbConnection);
                    break;
                case DBType.SQLSERVER:
                    command = new SqlCommand(CmdText, connection as SqlConnection);
                    break;
                case DBType.ORACLE:
                    command = new OracleCommand(CmdText, connection as OracleConnection);
                    break;
                case DBType.MYSQL:
                    command = new MySqlCommand(CmdText, connection as MySqlConnection);
                    break;
                default:
                    command = null;
                    break;
            }
            return command;
        }

        public IDbCommand GetCommand(string CmdText)
        {
            switch (this.DatabaseType)
            {
                case DBType.OLEDB:
                    command = new OleDbCommand(CmdText);
                    break;
                case DBType.SQLSERVER:
                    command = new SqlCommand(CmdText);
                    break;
                case DBType.ORACLE:
                    command = new OracleCommand(CmdText);
                    break;
                case DBType.MYSQL:
                    command = new MySqlCommand(CmdText);
                    break;
                default:
                    command = null;
                    break;
            }
            return command;
        }

        public IDbCommand GetCommand(string CmdText, Dictionary<string, object> parameters)
        {
            IDbCommand command = this.GetCommand(CmdText);
            command.CommandType = CommandType.StoredProcedure;
            foreach (string parametername in parameters.Keys)
            {
                string[] param = new string[2];
                param = parametername.Split('|');
                command.Parameters.Add(this.GetParameter(param[0], param[1], parameters[parametername]));
            }
            return command;
        }

        public DataTable GetDataTable(string procedureName, Dictionary<string, object> parameters)
        {
            IDbCommand command = this.GetCommand(procedureName, parameters);
            connection = this.GetConnection();
            connection.Open();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;

            IDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable table = new DataTable();

            table.Load(reader);
            reader.Close();

            return table;
        }

        public IDataAdapter GetDataAdapter(IDbCommand command)
        {
            switch (this.DatabaseType)
            {
                case DBType.OLEDB:
                    adapter = new OleDbDataAdapter(command as OleDbCommand);
                    break;
                case DBType.SQLSERVER:
                    adapter = new SqlDataAdapter(command as SqlCommand);
                    break;
                case DBType.ORACLE:
                    adapter = new OracleDataAdapter(command as OracleCommand);
                    break;
                case DBType.MYSQL:
                    adapter = new MySqlDataAdapter(command as MySqlCommand);
                    break;
                default:
                    adapter = null;
                    break;
            }
            return adapter;
        }

        public DataSet FillDataset(IDbConnection connection, string StoredProc, CommandType CmdType, Dictionary<string, object> parameters)
        {
            command = this.GetCommand(StoredProc, parameters);
            command.CommandType = CmdType;
            command.Connection = connection;
            adapter = this.GetDataAdapter(command);

            dataset = new DataSet();
            adapter.Fill(dataset);
            return dataset;

        }

        public IDataParameter GetParameter()
        {
            switch (this.DatabaseType)
            {
                case DBType.OLEDB:
                    parameter = new OleDbParameter();
                    break;
                case DBType.SQLSERVER:
                    parameter = new SqlParameter();
                    break;
                case DBType.ORACLE:
                    parameter = new OracleParameter();
                    break;
                case DBType.MYSQL:
                    parameter = new MySqlParameter();
                    break;
                default:
                    parameter = null;
                    break;
            }
            return parameter;
        }

        public IDataParameter GetParameter(string parameterName, string Direct, Object value)
        {
            IDataParameter parameter = this.GetParameter();
            parameter.ParameterName = parameterName;
            switch (Direct)
            {
                case "IN":
                    parameter.Direction = ParameterDirection.Input;
                    break;
                case "OUT":
                    parameter.Direction = ParameterDirection.Output;
                    break;
                default:
                    parameter.Direction = ParameterDirection.Input;
                    break;
            }
            parameter.Value = value;
            return parameter;
        }

        #region [IDisposable Support]
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
