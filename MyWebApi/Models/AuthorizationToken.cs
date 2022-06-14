namespace MyWebApi.Models
{
    public class AuthorizationToken
    {
        public string token { get; set; }
        public bool ValidToken()
        {
            return token == "1234";
        }
    }
}