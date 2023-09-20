namespace BlazorView.Data
{
    public class SessionManager
    {
        Dictionary<string, int> userSesssion = new();

        public string GenerateSession(int idUser)
        {
            string session = Guid.NewGuid().ToString();
            userSesssion.Add(session, idUser);
            return session;
        }
    }
}
