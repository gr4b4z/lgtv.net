using Windows.Storage;

namespace LgTv
{
    public class ClientKeyStore
    {
        private string ip;
        public ClientKeyStore(string ip)
        {
            this.ip = ip;
        }
        public string GetClientKey()
        {
            return (string)ApplicationData.Current.LocalSettings.Values[ip + "ClientKey"];
        }
        public void SaveClientKey(string key)
        {
            ApplicationData.Current.LocalSettings.Values[ip + "ClientKey"] = key;
        }
    }
}
