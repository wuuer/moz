namespace Moz.Bus.Dtos.Auth
{
    public class MemberLoginApo
    {
        public string AccessToken { get; set; }
        
        public string RefreshToken { get; set; }
        
        public long ExpireDateTime { get; set; }
    }
}