namespace WebAppContacts.Settings
{
    public class MongoDbSettings
    {
        public string Name { get; init; }
        public string Host { get; init; }
        public int Port { get; init; }
        public string ConnectionString 
        { 
            get 
            {
                return $"mongodb://{Host}:{Port}";
            }
        }
    }
}