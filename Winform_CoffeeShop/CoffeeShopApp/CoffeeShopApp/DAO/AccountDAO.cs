using System.Data;

namespace CoffeeShopApp.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value;
        }

        private AccountDAO() { }
        public bool VerifyLogin(string userName, string pwd)
        {
            var query = $"USP_Login @userName , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{ userName, pwd });
            return result.Rows.Count > 0;  
        }
    }
}
