namespace Artworks_ASP.NET
{
    public static class ConnectionManager
    {
        private static string server = "DESKTOP-CBC069A";
        private static string database = "Artworks";
        private static string username = "DESKTOP-CBC069A\\Michael Raw";
        private static string password = "YTanoi99";
        private static string trustedConnection = "yes";
        private static string connectionTimeout = "30";
        private static string connectionString = string.Format("user id={0};password={1};server={2};Trusted_Connection={3};database={4};connection timeout={5};TrustServerCertificate=True",
            Username, Password, Server, TrustedConnection, Database, ConnectionTimeout);

        public static string ConnectionString
        {
            get { return connectionString; }
        }
        public static string Server
        {
            get { return server; }
        }
        public static string Database
        {
            get { return database; }
        }
        public static string Username
        {
            get { return username;}
        }
        public static string TrustedConnection
        {
            get { return trustedConnection; }
        }
        public static string Password
        {
            get { return password; }
        }
        public static string ConnectionTimeout
        {
            get { return connectionTimeout; }
        }
    }
}
