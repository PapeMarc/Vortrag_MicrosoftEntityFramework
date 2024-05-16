namespace MicrosoftEntityFramework.Model
{
    public static class Config
    {
        public static loadedConfig Load()
        {
            StreamReader sr = new StreamReader("config.txt");
            String pw = sr.ReadToEnd();
            return new() { password = pw };
        }
    }

    public struct loadedConfig
    {
        public string password;
    }
}
