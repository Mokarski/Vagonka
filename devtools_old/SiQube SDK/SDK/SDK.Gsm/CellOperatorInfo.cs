namespace SDK.Gsm
{
    public class CellOperatorInfo
    {
        public CellOperatorInfo(string login, string password, string accessPoint, string phone, string balanceUssd)
        {
            Login = login;
            Password = password;
            AccessPoint = accessPoint;
            Phone = phone;
            BalanceUssd = balanceUssd;
        }

        /// <summary>
        /// Login for ppp session
        /// </summary>
        public string Login { private set; get; }

        /// <summary>
        /// Password for ppp session
        /// </summary>
        public string Password { private set; get; }

        /// <summary>
        /// AccessPoint for start GPRS context
        /// </summary>
        public string AccessPoint { private set; get; }

        /// <summary>
        /// Phone number for start GPRS context
        /// </summary>
        public string Phone { private set; get; }

        /// <summary>
        /// USSD Command for request of balance
        /// </summary>
        public string BalanceUssd { private set; get; }
    }
}