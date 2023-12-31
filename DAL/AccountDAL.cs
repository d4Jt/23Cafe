using DAL.UseCase;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class AccountDAL : AccountUseCase
    {
        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { instance = value; }
        }

        private AccountDAL() { }


        /**
        * Hàm mã hóa mật khẩu MD5
        *@param username @userName[User Name]
        *@param passWord @passWord[Pass Word]
        *@return result.Rows.Count
        */
        public bool Login(string userName, string passWord)
        {
            /**
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            */
            //var list = hasData.ToString();
            //list.Reverse();

            try
            {
                string query = "USP_Login @userName , @passWord";

                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord /*list*/});

                return result.Rows.Count > 0;
            } catch (Exception ex)
            {
                return false;
            }
        }

        /**
        * Hàm sửa thông tin tài khoản
        *@param username @userName[User Name]
        *@param displayName @displayName [displayName]
        *@param passWord @passWord[Pass Word]
        *@param newPassword @newPassword  [newPass Word]        
        *@return result
        */
        public bool UpdateAccountPassword(string userName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @password , @newPassword", new object[] { userName, pass, newPass });

            return result > 0;
        }

        public DataTable GetListAccountsTable()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT username, display_name, phone, basic_salary, role FROM dbo.Account");
        }

        public List<Account> GetListAccounts()
        {
            List<Account> list = new List<Account>();

            string query = string.Format("SELECT * from Account");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }

            return list;
        }

        public List<Account> SearchListAccounts(string querySearch)
        {
            try
            {
                List<Account> list = new List<Account>();

                string query = string.Format($"SELECT * from Account WHERE display_name LIKE N'%{querySearch}%' OR phone LIKE N'%{querySearch}%' OR username LIKE N'%{querySearch}%'");
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    Account account = new Account(item);
                    list.Add(account);
                }
                return list;
            } catch (Exception ex)
            {
                return null;
            }
        }

        public Account GetAccountByUserName(string userName)
        {
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery($"Select * from Account where username = '{userName}'");

                foreach (DataRow item in data.Rows)
                {
                    return new Account(item);
                }

                return null;
            } catch (Exception ex)
            {
                return null;
            }
        }
        /**
        * Hàm thêm tài khoản
        *@param UserName @UserName
        *@param displayName @displayName 
        *@param type @type
        *@param password @password        
        *@return result
        */
        public bool InsertAccount(string username, string displayName, string phone, int basic_salary, int role, string password)
        {
            try
            {
                string query = string.Format("INSERT dbo.Account ( username, display_name, role, password, phone, basic_salary ) VALUES  ( N'{0}', N'{1}', {2}, N'{3}', N'{4}', {5})", username, displayName, role, password, phone, basic_salary);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            } catch (Exception ex)
            {
                return false;
            }
        }

        /**
        * Hàm sửa tài khoản
        *@param name @UserName
        *@param displayName @displayName 
        *@param type @type
        *@return result
        */
        public bool UpdateAccount(string username, string displayName, int role, string phone, int basic_salary)
        {
            try
            {
                string query = string.Format("UPDATE Account SET display_name = N'{1}', role = {2}, phone = N'{3}', basic_salary = {4} WHERE username = '{0}'", username, displayName, role, phone, basic_salary);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            } catch (Exception ex)
            {
                return false;
            }
        }

        /**
        * Hàm xóa tài khoản
        *@param name @name
        *@return result
        */
        public bool DeleteAccount(string username)
        {
            try
            {
                string query = string.Format("Delete from Account where username = N'{0}'", username);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            } catch (Exception ex)
            {
                return false;
            }
        }

        /**
        * Hàm reset mật khẩu
        *@param name @name
        *@return result
        */
        public bool ResetPassword(string newPass, string username)
        {
            try
            {
                string query = string.Format("update account set password = N'{0}' where username = N'{1}'", newPass, username);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            } catch (Exception ex)
            {
                return false;
            }
        }
    }
}