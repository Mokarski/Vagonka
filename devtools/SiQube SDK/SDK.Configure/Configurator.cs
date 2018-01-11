using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using SDK.Common;
using SDK.SignalsFactory;
using SDK.SignalsFactory.Interface;


// TODO
/*
  необходимо склеить конфигуратор и фабрику сигналов, чтобы для бродкаста, конфигурации и внешнего меню 
  можно было использовать только один файл базы сигналов
 
  AddConfig(SignalDescription) - это внешние настройки
  AddSignal(SignalDescription)
 
  SignalDescription : Signal (должен быть занаследован)
  RecorType - добавить ushort и discreet (bool c позиционированием) (для работы с modbus сигналами)
  Для сигналов конфигурации надо дать возможность указывать дефоолтное значение (выставлять таким при первом добавлении в базу)
  
 */

namespace SDK.Configure
{
    public class Configurator : SQLiteConnection
    {
        public Configurator()
            : base("./config.sqlite3", true)
        {
            CreateTable<Signal>(CreateFlags.AllImplicit);
            CreateTable<SignalDescription>(CreateFlags.AllImplicit);
        }

        public bool IsEmpty()
        {
            return !Table<Signal>().Any();
        }

        public Signal[] QueryByDepth(byte depth)
        {
            //return (from s in Table<Signal>() where s.Depth == depth select s).ToArray();
            return null;
        }

        public Signal[] QueryById(string id)
        {
            return (from s in Table<Signal>() where s.Id.Contains(id) select s).ToArray();
        }

        public Signal[] QueryByIdAndDepth(string id, byte depth)
        {
            //return (from s in Table<Signal>() where s.Id.Contains(id) && s.Depth == depth select s).ToArray();
            return null;
        }        
    }
}