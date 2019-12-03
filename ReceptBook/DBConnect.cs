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
                            string getUserId = "select ID from users where email = '" + login + "'";
                            cmd.CommandText = getUserId;
                            AddSessionVar("UserId", Convert.ToString(cmd.ExecuteScalar()));
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
                CloseConnect();
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
                CloseConnect();
                return false;

            }

        }

        public static bool AddUser(string surname, string name, int roleid, string email, string password)
        {
            try
            {
                bool successFlag = false;
                if (TryOpenConnection())
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        cmd.Connection = conn;
                        string execAddUser = "execute procedure ADD_USER('" + surname + "', '" + name +
                                                                "', '" + roleid +
                                                                "', '" + email + "', '" + password + "')";
                        cmd.CommandText = execAddUser;
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
                CloseConnect();
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
                //CloseConnect();
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
                    string getData = "select ID, NAME_RECEPT, DISCRIPTION_RECEPT from RECEPT where id IN (select ID_RECEPT from RECEPT_INGREDIENT where ID_INGREDIENT IN (select id from INGREDIENT where NAME_INGREDIENT IN (" + listIngr + ")))";
                    table.Columns.Add("col1", "ID");
                    table.Columns.Add("col2", "Назва рецепту");
                    table.Columns.Add("col3", "Опис рецепту");
                    using (FbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = getData;
                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
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

        public static Recept GetRecept(int ReceptId)
        {
            try
            {
                Recept dataRecept = new Recept();

                if (TryOpenConnection())
                {
                    string getDataReceptSteps = "select NUM_STEP, DESCRIPTION_STEP from STEP where ID_RECEPT = " + ReceptId;
                    string getDataReceptIngrs = "select RECEPT_INGREDIENT.ING_COUNT AS ING_COUNT, " +
                        "RECEPT_INGREDIENT.MEASURE AS MEASURE, INGREDIENT.NAME_INGREDIENT AS NAME " +
                        "from RECEPT_INGREDIENT INNER JOIN INGREDIENT ON " +
                        "RECEPT_INGREDIENT.ID_INGREDIENT = INGREDIENT.ID where ID_RECEPT = " + ReceptId;
                        
                    string getDataReceptName = "select NAME_RECEPT from RECEPT where ID = " + ReceptId;
                    string getDataReceptDiscription = "select DISCRIPTION_RECEPT from RECEPT where ID = " + ReceptId;
                    string getDataReceptLevel = "select LEVEL_RECEPT from RECEPT where ID = " + ReceptId;
                    string getDataReceptTime = "select TIME_RECEPT from RECEPT where ID = " + ReceptId;

                    string getDataReceptCateg = "select NAME_KATEG_REC from KATEGORIA_RECEPT where ID = " + 
                        "(select KAT_RECEPT from RECEPT where ID = "+ ReceptId + ")";
                    string getDataReceptDateCreate = "select CREATION_DATA_RECEPT from RECEPT where ID = " + ReceptId;
                    string getDataReceptPhoto = "select PHOTO from RECEPT where ID = " + ReceptId;

                    dataRecept.StepsCols.Add("col1", "Крок");
                    dataRecept.StepsCols.Add("col2", "Опис кроку");

                    dataRecept.IngrsCols.Add("col1", "Кількість");
                    dataRecept.IngrsCols.Add("col2", "Вимір");
                    dataRecept.IngrsCols.Add("col3", "Назва");

                    using (FbCommand cmd = conn.CreateCommand())
                    {  
                        cmd.CommandText = getDataReceptSteps;
                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                dataRecept.StepsData.Add(new string[2]);
                                for (var i = 0; i < 2; i++)
                                    dataRecept.StepsData[dataRecept.StepsData.Count - 1][i] = reader[i].ToString();
                            }
                        }
                        cmd.CommandText = getDataReceptIngrs;
                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                dataRecept.IngrsData.Add(new string[3]);
                                for (var i = 0; i < 3; i++)
                                    dataRecept.IngrsData[dataRecept.IngrsData.Count - 1][i] = reader[i].ToString();
                            }
                        }
                        cmd.CommandText = getDataReceptName;
                        dataRecept.NameText = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = getDataReceptDiscription;
                        dataRecept.DescriptionText = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = getDataReceptLevel;
                        dataRecept.LevelText = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = getDataReceptTime;
                        dataRecept.TimeText = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = getDataReceptCateg;
                        dataRecept.CategText = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = getDataReceptDateCreate;
                        dataRecept.CreateDateText = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = getDataReceptDateCreate;
                        dataRecept.CreateDateText = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = getDataReceptPhoto;
                        dataRecept.PicturePath = Convert.ToString(cmd.ExecuteScalar());
                    }
                }
                CloseConnect();
                return dataRecept;
            }
            catch(Exception e)
            {
                ShowError(e.ToString());
                CloseConnect();
                return null;
            }
        }



        public static bool addReceptToFavorites(int ReceptId)
        {
            try
            {
                bool successFlag = false;
                if (TryOpenConnection())
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        cmd.Connection = conn;
                        
                        string execAddFavRecept = "execute procedure ADD_FAVORITE_RECEPT('" + ReceptId + "', '" + 
                            GetSessionVar("UserId") + "')";
                        cmd.CommandText = execAddFavRecept;
                        int approved = Convert.ToInt32(cmd.ExecuteScalar());
                        if (approved == 1)
                        {
                            successFlag = true;
                        }
                    }
                    CloseConnect();
                }
                else
                    throw new Exception(errOpenConnection);
                
                return successFlag;
            }
            catch (Exception e)
            {
                ShowError("Помилка роботи з БД:\n" + e.ToString());
                CloseConnect();
                return false;
            }
        }
        public static int GetLikes(int ReceptId)
        {
                try
                {
                    int countLikes = 0;
                    //bool successFlag = false;
                    if (TryOpenConnection())
                    {
                        using (FbCommand cmd = new FbCommand())
                        {
                            cmd.Connection = conn;

                            string execCountLikes = "execute procedure COUNT_FAVORITES('" + ReceptId + "')";
                            cmd.CommandText = execCountLikes;
                            countLikes = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                    else
                        throw new Exception(errOpenConnection);
                    CloseConnect();
                    return countLikes;
                }
                catch (Exception e)
                {
                    ShowError("Помилка роботи з БД:\n" + e.ToString());
                    CloseConnect();
                    return 0;
                }
        }

        public static bool getAllRecepts(ref DataGridView table)
        {
            try
            {
                if (TryOpenConnection())
                {
                    table.Rows.Clear();
                    table.Columns.Clear();
                    
                    string getDataAllRecepts = "select ID, NAME_RECEPT, DISCRIPTION_RECEPT from RECEPT ";
                    table.Columns.Add("col1", "ID");
                    table.Columns.Add("col2", "Назва рецепту");
                    table.Columns.Add("col3", "Опис рецепту");
                    using (FbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = getDataAllRecepts;
                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
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

        public static bool getAllFavRecepts(ref DataGridView table)
        {
            try
            {
                if (TryOpenConnection())
                {
                    table.Rows.Clear();
                    table.Columns.Clear();

                    string getDataAllRecepts = "select ID, NAME_RECEPT, DISCRIPTION_RECEPT from RECEPT where ID =" +
                        "(select ID_RECEPT from FAVORITES where ID_USER =" + GetSessionVar("UserId") + ")";
                    table.Columns.Add("col1", "ID");
                    table.Columns.Add("col2", "Назва рецепту");
                    table.Columns.Add("col3", "Опис рецепту");
                    using (FbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = getDataAllRecepts;
                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
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

        public static bool FillDataGridViewWithReceiptsByCateg(ref DataGridView table, string nameCategory)
        {
            try
            {
                if (TryOpenConnection())
                {
                    table.Rows.Clear();
                    table.Columns.Clear();
                    string getData = "select ID, NAME_RECEPT, DISCRIPTION_RECEPT from RECEPT where KAT_RECEPT = " +
                        " (select ID from KATEGORIA_RECEPT where NAME_KATEG_REC = '" + nameCategory + "')";
                    table.Columns.Add("col1", "ID");
                    table.Columns.Add("col2", "Назва рецепту");
                    table.Columns.Add("col3", "Опис рецепту");
                    using (FbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = getData;
                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
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

        public static bool getAllUsers(ref DataGridView table)
        {
            try
            {
                if (TryOpenConnection())
                {
                    table.Rows.Clear();
                    table.Columns.Clear();
                    //string getDataReceptIngrs = "select RECEPT_INGREDIENT.ING_COUNT AS ING_COUNT, " +
                    //    "RECEPT_INGREDIENT.MEASURE AS MEASURE, INGREDIENT.NAME_INGREDIENT AS NAME " +
                    //    "from RECEPT_INGREDIENT INNER JOIN INGREDIENT ON " +
                    //    "RECEPT_INGREDIENT.ID_INGREDIENT = INGREDIENT.ID where ID_RECEPT = " + ReceptId;
                    string getDataAllUsers = "select USERS.ID as U_ID,  USERS.SURNAME as SURNAME, USERS.NAME_USER as NAME_USER, " +
                        "USERS.EMAIL as EMAIL, USERS.PASSWRD as PASSWRD, ROLES.NAME_ROLE as NAME_ROLE " +
                        "from USERS INNER JOIN ROLES ON USERS.ID_ROLE = ROLES.ID";
                    table.Columns.Add("col1", "ID");
                    table.Columns.Add("col2", "Призвище");
                    table.Columns.Add("col3", "Ім'я");
                    table.Columns.Add("col4", "Email");
                    table.Columns.Add("col5", "Пароль");
                    table.Columns.Add("col6", "Роль");
                    using (FbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = getDataAllUsers;
                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
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

        public static bool deleteUser(int userId)
        {
            try
            {
                bool successFlag = false;
                if (TryOpenConnection())
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        cmd.Connection = conn;
                        string execUserDel = "execute procedure DEL_USER('" + userId + "')";
                        cmd.CommandText = execUserDel;
                        int approved = Convert.ToInt32(cmd.ExecuteScalar());
                        if (approved == 1)
                        {
                            successFlag = true;
                        }
                    }
                    //CloseConnect();
                    return successFlag;
                }
                else
                {
                    throw new Exception(errOpenConnection);
                }
            }
            catch (Exception e)
            {
                ShowError(e.ToString());
                CloseConnect();
                return false;
            }
        }

        public static bool getAllRoles(ref DataGridView table)
        {
            try
            {
                if (TryOpenConnection())
                {
                    table.Rows.Clear();
                    table.Columns.Clear();
                    string getDataAllRoles = "select ID, NAME_ROLE from ROLES";
                    table.Columns.Add("col1", "ID");
                    table.Columns.Add("col2", "Назва ролі");

                    using (FbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = getDataAllRoles;
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
        public static bool getAllIngr(ref DataGridView table)
        {
            try
            {
                if (TryOpenConnection())
                {
                    table.Rows.Clear();
                    table.Columns.Clear();
                    string getDataAllIngr = "select INGREDIENT.NAME_INGREDIENT as NAME_INGR, "
                        + "KATEGORIA_INGREDIENT.NAME_KATEG_INGR as NAME_CATEG from INGREDIENT INNER JOIN KATEGORIA_INGREDIENT ON "
                        + "INGREDIENT.ID_KATEG_INGR = KATEGORIA_INGREDIENT.ID";
                    table.Columns.Add("col1", "Інгредієнт");
                    table.Columns.Add("col2", "Категорія");

                    using (FbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = getDataAllIngr;
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

        public static bool addIngrToListIngrs(string nameIngr, string nameCategory)
        {
            try
            {
                bool successFlag = false;
                if (TryOpenConnection())
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        cmd.Connection = conn;
                        
                        string idCategory = "select ID from KATEGORIA_INGREDIENT where NAME_KATEG_INGR = '" + nameCategory + "'";
                        
                        cmd.CommandText = idCategory;
                        int catId = Convert.ToInt32(cmd.ExecuteScalar());                        
                        string execAddNewIngr = "execute procedure ADD_INGR('" + nameIngr + "', '" +
                            catId + "')";
                        cmd.CommandText = execAddNewIngr;
                        int approved = Convert.ToInt32(cmd.ExecuteScalar());
                        if (approved == 1)
                        {
                            successFlag = true;
                        }
                    }
                    CloseConnect();
                }
                else
                    throw new Exception(errOpenConnection);

                return successFlag;
            }
            catch (Exception e)
            {
                ShowError("Помилка роботи з БД:\n" + e.ToString());
                CloseConnect();
                return false;
            }
        }


        public static bool addNewRecToListRecepts(string nameRecept, string discription, string time, string level, string datecreat, string category, string photo, string cuisine)
        {
            try
            {
                bool successFlag = false;
                if (TryOpenConnection())
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        cmd.Connection = conn;

                        string idCategory = "select ID from KATEGORIA_RECEPT where NAME_KATEG_REC = '" + category + "'";
                        cmd.CommandText = idCategory;
                        int catId = Convert.ToInt32(cmd.ExecuteScalar());

                        string idCuis = "select ID from CUISINE where NAME_CUISINE = '" + cuisine + "'";
                        cmd.CommandText = idCuis;
                        int cuisId = Convert.ToInt32(cmd.ExecuteScalar());

                        string execAddNewRecept = "execute procedure ADD_RECEPT('" + nameRecept + "', '" +
                            discription + "', '" + time + "', '" + level + "', '" + datecreat + "', '" 
                            + catId + "', '" + photo + "', '" + cuisId + "')";
                        cmd.CommandText = execAddNewRecept;
                        int approved = Convert.ToInt32(cmd.ExecuteScalar());
                        if (approved == 1)
                        {
                            successFlag = true;
                        }
                    }
                    CloseConnect();
                }
                else
                    throw new Exception(errOpenConnection);

                return successFlag;
            }
            catch (Exception e)
            {
                ShowError("Помилка роботи з БД:\n" + e.ToString());
                CloseConnect();
                return false;
            }
        }
    }
}
