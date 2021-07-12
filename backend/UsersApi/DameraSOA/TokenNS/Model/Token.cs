using System;

namespace UsersApi.DameraSOA.TokenNS.Model
{
    public class Token
    {
        public int TokenID { get; set; }
        public int UserID { get; set; }
        public string UserToken { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}