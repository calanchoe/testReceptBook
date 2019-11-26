using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptBook
{
    public static class DBConnect
    {
        private static FbConnection conn;

        private static string errOpenConnection = "Помилка! Не вдалося підключитися до БД!";

        //private static Dictionary<string, string> Session { get; }
        static DBConnect()
        {
            Session = new Dictionary<string, string>();
            conn = new FbConnection(ConfigurationManager.AppSettings["connectionStr"]);
        }
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //public static FbConnection GetConnection()
        //{

        //        //conn = new FbConnection(sb.ToString());
        //        try
        //        {
        //            conn.Open();
        //            if (conn.State == ConnectionState.Open)
        //            {
        //                return conn;
        //            }
        //            else
        //            {
        //                throw new Exception("Не удалось подключиться к БД!");
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show("Произошла ошибка:\n" + e.ToString(),
        //                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            Application.Exit();
        //            return null;
        //        }

        //}

        private static bool TryOpenConnection()
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Помилка!");
                }
            }
            catch (Exception e)
            {
                ShowError("Помилка роботи з БД:\n" + e.ToString());
                return false;
            }
        }

        private static void CloseConnect()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                ShowError("Помилка роботи з БД:\n" + e.ToString());
            }
        }

        //-------------session--------------------------------------
        private static Dictionary<string, string> Session { get; }
        public static void AddSessionVar(string key, string value)
        {
            try
            {
                Session.Add(key, value);
            }
            catch (Exception e)
            {
                ShowError(e.ToString());
            }
        }
        public static string GetSessionVar(string key)
        {
            try
            {
                string toReturn;
                if (Session.TryGetValue(key, out toReturn))
                {
                    return toReturn;
                }
                else
                    throw new Exception("Не знайдено дані за ключем '" + key + "'!");
            }
            catch (Exception e)
            {
                ShowError(e.ToString());
                return null;
            }
        }
        public static void RemoveSessionVar(string key)
        {
            try
            {
                Session.Remove(key);
            }
            catch (Exception e)
            {
                ShowError(e.ToString());
            }
        }
        public static void RemoveSessionAll()
        {
            Session.Clear();
        }
        //----------для передачи данных с формы авторизации в бд для проверки совпадения-------
        public static bool SignIn(string login, string password)
        {
            try
            {
                bool successFlag = false;
                if (TryOpenConnection())
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        cmd.Connection = conn;
                        string execSignIn = "execute procedure SING_IN('" + login + "', '" + password + "')";
                        cmd.CommandText = execSignIn;
                        int approved = Convert.ToInt32(cmd.ExecuteScalar());
                        if (approved == 1)
                        {
                            AddSessionVar("UserLogin", login);
                            string getRole = "select name_role from roles where id " +
                                "= (select id_role from users where email = '" + login + "')";
                            cmd.CommandText = getRole;
                            AddSessionVar("UserRole", Convert.ToString(cmd.ExecuteScalar()));
                            string getName = "select name_user from users where email = '" + login + "'";
                            cmd.CommandText = getName;
                            AddSessionVar("UserName", Convert.ToString(cmd.ExecuteScalar()));
                            string getSurname = "select surname from users where email = '" + login + "'";
                            cmd.CommandText = getSurname;
                            AddSessionVar("UserSurname", Convert.ToString(cmd.ExecuteScalar()));
                            successFlag = true;
                        }
                    }
                }
                else
                    throw new Exception(errOpenConnection);
                CloseConnect();
                return successFlag;
            }
            catch (Exception e)
            {
                ShowError("Помилка роботи з БД:\n" + e.ToString());
                return false;
            }

        }

        public static bool CheckIn(string surname, string name, string email, string password)
        {
            try
            {
                bool successFlag = false;
                if (TryOpenConnection())
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        cmd.Connection = conn;
                        string execCheckIn = "execute procedure CHECK_IN('" + surname + "', '" + name + 
                                                                "', '" + email + "', '" + password + "')";
                        cmd.CommandText = execCheckIn;
                        int approved = Convert.ToInt32(cmd.ExecuteScalar());
                        if (approved == 1)
                        {
                            successFlag = true;
                        }
                    }
                }
                else
                    throw new Exception(errOpenConnection);
                CloseConnect();
                return successFlag;
            }
            catch (Exception e)
            {
                ShowError("Помилка роботи з БД:\n" + e.ToString());
                return false;
            }

        }
        public static bool FillBindingList(ref BindingList<string> list, string table, string field)
        {
            try
            {
                if (TryOpenConnection())
                {
                    list = new BindingList<string>();
                    string getCategoriesNames = "select " + field.ToUpper() +
                        " from " + table.ToUpper();
                    using (FbCommand cmd = new FbCommand(getCategoriesNames, conn))
                    {
                        FbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (reader.Read())
                        {
                            list.Add(reader[0].ToString());
                        }
                        CloseConnect();
                        return true;
                    }
                }
                else throw new Exception("Не вдалося отримати дані з БД!");
            }
            catch (Exception e)
            {
                ShowError(e.ToString());
                list = null;
                return false;
            }
        }

        public static bool FillIngrOfCategoryBindingList(ref BindingList<string> list, string categoryName)
        {
            try
            {
                if (TryOpenConnection())
                {
                    list = new BindingList<string>();
                    string getCategoriesNames = "select NAME_INGREDIENT from INGREDIENT " +
                        "where ID_KATEG_INGR = (select ID from KATEGORIA_INGREDIENT " +
                        "where NAME_KATEG_INGR = '" + categoryName + "')";
                    using (FbCommand cmd = new FbCommand(getCategoriesNames, conn))
                    {
                        FbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            list.Add(reader[0].ToString());
                        }
                        CloseConnect();
                        return true;
                    }
                }
                else throw new Exception("Не вдалося отримати дані з БД!");
            }
            catch (Exception e)
            {
                ShowError(e.ToString());
                list = null;
                return false;
            }
        }

        public static bool FillDataGridViewWithReceipts(ref DataGridView table, List<string> ingrs)
        {
            try
            {
                if (TryOpenConnection())
                {
                    table.Rows.Clear();
                    table.Columns.Clear();
                    string listIngr = "";
                    foreach (string elem in ingrs)
                        listIngr += "'" + elem + "', ";
                    listIngr += "*";
                    listIngr = listIngr.Replace(", *", "");
                    string getData = "select NAME_RECEPT, DISCRIPTION_RECEPT from RECEPT where id IN (select ID_RECEPT from RECEPT_INGREDIENT where ID_INGREDIENT IN (select id from INGREDIENT where NAME_INGREDIENT IN (" + listIngr + ")))";
                    table.Columns.Add("col1", "Назва рецепту");
                    table.Columns.Add("col2", "Опис рецепту");
                    using (FbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = getData;
                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                table.Rows.Add(reader[0].ToString(), reader[1].ToString());
                            }
                        }
                    }
                    CloseConnect();
                    return true;
                }
                else
                    throw new Exception(errOpenConnection);
            }
            catch (Exception e)
            {
                ShowError(e.ToString());
                CloseConnect();
                return false;
            }
        }
    }
}
