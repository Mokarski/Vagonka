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
  ���������� ������� ������������ � ������� ��������, ����� ��� ���������, ������������ � �������� ���� 
  ����� ���� ������������ ������ ���� ���� ���� ��������
 
  AddConfig(SignalDescription) - ��� ������� ���������
  AddSignal(SignalDescription)
 
  SignalDescription : Signal (������ ���� ������������)
  RecorType - �������� ushort � discreet (bool c �����������������) (��� ������ � modbus ���������)
  ��� �������� ������������ ���� ���� ����������� ��������� ���������� �������� (���������� ����� ��� ������ ���������� � ����)
  
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