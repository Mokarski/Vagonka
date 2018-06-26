using System.IO;
using Nini.Config;
using log4net;

namespace SDK.Common
{
    public class IniConfiguration
    {
        private readonly ILog mLog;
        private readonly IConfigSource mSource;

        public IniConfiguration(ILog log, string iniUrl)
        {
            mLog = log;

            if (File.Exists(iniUrl))
                mSource = new IniConfigSource(iniUrl);
            else
            {
                if(mLog != null)
                    mLog.Error(string.Format("Файл настроек {0} не найден", iniUrl));

                mSource = new IniConfigSource();
            }
        }

        private IConfig IniConfig(string section)
        {
            var rv =  mSource.Configs[section];
            return rv;
        }

        public string GetString(string section, string key)
        {
            if (IniConfig(section) != null)
                return IniConfig(section).GetString(key);
                
            return null;
        }

        public int? GetInt(string section, string key)
        {
            return IniConfig(section) != null ? IniConfig(section).GetInt(key) : (int?) null;
        }

        public bool GetBool(string section, string key)
        {
            return IniConfig(section) != null && IniConfig(section).GetBoolean(key);
        }
    }
}