namespace MyWebApi.Models
{
    public class AuthorizationToken
    {
        public string token { get; set; }
        public AuthorizationToken(string token)
        {
            this.token = token;
        }
    
        public bool ValidToken()
        {
            return token == "1234";
        }
    }
}