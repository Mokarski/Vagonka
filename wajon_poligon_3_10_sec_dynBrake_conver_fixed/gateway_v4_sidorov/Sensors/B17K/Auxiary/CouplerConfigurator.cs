using System.Collections.Generic;
using SDK.SignalsFactory.Equipment.Wago;
using SDK.SignalsFactory.Interface;

namespace Sensors.B17K
{
    static public class CouplerConfigurator
    {
        public static bool W750493_flag = true;
        public static bool Test_W750493() //проверка серии модуля детекции напряжения 493 или 494 модель
        {
            return true;
        }
        public static void Init(Coupler wago, ISignalsFactory signals)
        {
            if (W750493_flag == true)
            {

                {
                    W750493.Add(wago, 0, new List<ISignal>
                                              {
                                                 signals.GetSignal(SensorName.Phase(1, SignalName.Voltage))
                                              });

                    W750514.Add(wago, 518, new List<ISignal>
                                            {                                                     
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv4)),             // sound alarm                                                 
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv11)),            // pump on              
                                  
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv10)),            // conv speed 1                                              
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv9)),             // conv speed 2                                                

                                                signals.GetSignal(SensorName.Relay(RelayName.RectifierReset)),  // rectifier reset//null,//new Signal(SensorName.Relay(RelayName.Kv10)),//mode mix,                                                                                           
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv1)),             // rectifier active mode
                                            });


                    W7501405.Add(wago, 6, new List<ISignal>
                                      {                                                                                                       
                                          signals.GetSignal(SensorName.Drive(SignalName.Forward)),// SignalType.Ushort),                                          
                                          signals.GetSignal(SensorName.Drive(SignalName.Reverse)),// SignalType.Ushort),                                          
                                          signals.GetSignal(SensorName.Cord(1)), //SignalType.Ushort), // F1                                          
                                          signals.GetSignal(SensorName.Cord(2)), //SignalType.Ushort), // F2                                          
                                          signals.GetSignal(SensorName.Cord(3)), //SignalType.Ushort), // F3                                          
                                          signals.GetSignal(SensorName.Cord(4)), //SignalType.Ushort), // F4                                          
                                          signals.GetSignal(SensorName.Cord(5)), //SignalType.Ushort), // F5                                          
                                          signals.GetSignal(SensorName.Cord(6)), //SignalType.Ushort), // F6                                          
                                          null,//new Signal(SensorName.Empty()),                                          
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv11, SignalName.Feedback)), //SignalType.Ushort),// K1     2008                                      
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv2, SignalName.Feedback)), //SignalType.Ushort),// K2                                           
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv1, SignalName.Feedback)), //SignalType.Ushort),// K3 -    2009                                       
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv9, SignalName.Feedback)), //SignalType.Ushort),//  K4  
                                          //signals.GetSignal(SensorName.Relay(RelayName.Kv8, SignalName.Feedback)), //SignalType.Ushort),// K4 -                                           
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv10, SignalName.Feedback)), //SignalType.Ushort),// K5 -                                           
                                          //null,//signals.GetSignal(SensorName.Relay(RelayName.Kv10, SignalName.Feedback)), //SignalType.Ushort),// K6, now K4                                        
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv8, SignalName.Feedback)),
                                          null//new Signal(SensorName.Empty()) 
                                      });
                }

   
            }
            
            if (W750493_flag == false) // etc 750494 module installed
            {
                {
                    
                    W750493.Add(wago, 4, new List<ISignal>
                                              {
                                                 signals.GetSignal(SensorName.Phase(1, SignalName.Voltage))
                                              });

                    W750514.Add(wago, 518, new List<ISignal>
                                            {                                                     
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv4)),             // sound alarm                                                 
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv11)),            // pump on              
                                  
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv10)),            //                                               
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv9)),             //                                                 

                                                signals.GetSignal(SensorName.Relay(RelayName.RectifierReset)),  // rectifier reset//null,//new Signal(SensorName.Relay(RelayName.Kv10)),//mode mix,                                                                                           
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv1)),             // rectifier active mode
                                            });


                    W7501405.Add(wago, 6, new List<ISignal>
                                      {                                                                                                       
                                          signals.GetSignal(SensorName.Drive(SignalName.Forward)),// SignalType.Ushort),                                          
                                          signals.GetSignal(SensorName.Drive(SignalName.Reverse)),// SignalType.Ushort),                                          
                                          signals.GetSignal(SensorName.Cord(1)), //SignalType.Ushort), // F1                                          
                                          signals.GetSignal(SensorName.Cord(2)), //SignalType.Ushort), // F2                                          
                                          signals.GetSignal(SensorName.Cord(3)), //SignalType.Ushort), // F3                                          
                                          signals.GetSignal(SensorName.Cord(4)), //SignalType.Ushort), // F4                                          
                                          signals.GetSignal(SensorName.Cord(5)), //SignalType.Ushort), // F5                                          
                                          signals.GetSignal(SensorName.Cord(6)), //SignalType.Ushort), // F6                                          
                                          null,//new Signal(SensorName.Empty()),                                          
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv11, SignalName.Feedback)), //SignalType.Ushort),// K1                                          
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv2, SignalName.Feedback)), //SignalType.Ushort),// K2                                           
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv1, SignalName.Feedback)), //SignalType.Ushort),// K3 -                                           
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv9, SignalName.Feedback)), //SignalType.Ushort),//  K4  
                                          //signals.GetSignal(SensorName.Relay(RelayName.Kv8, SignalName.Feedback)), //SignalType.Ushort),// K4 -                                           
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv10, SignalName.Feedback)), //SignalType.Ushort),// K5 -                                           
                                          null,//signals.GetSignal(SensorName.Relay(RelayName.Kv10, SignalName.Feedback)), //SignalType.Ushort),// K6, now K4                                        
                                          null//new Signal(SensorName.Empty()) 
                                      });
                }
            }
        }
        public static void Initwago750493(Coupler wago, ISignalsFactory signals)
        {
            {
                W750493.Add(wago, 0, new List<ISignal>
                                              {
                                                 signals.GetSignal(SensorName.Phase(1, SignalName.Voltage))
                                              });

                W750514.Add(wago, 518, new List<ISignal>
                                            {                                                     
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv4)),             // sound alarm                                                 
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv11)),            // pump on              
                                  
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv10)),            //                                               
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv9)),             //                                                 

                                                signals.GetSignal(SensorName.Relay(RelayName.RectifierReset)),  // rectifier reset//null,//new Signal(SensorName.Relay(RelayName.Kv10)),//mode mix,                                                                                           
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv1)),             // rectifier active mode
                                            });


                W7501405.Add(wago, 6, new List<ISignal>
                                      {                                                                                                       
                                          signals.GetSignal(SensorName.Drive(SignalName.Forward)),// SignalType.Ushort),                                          
                                          signals.GetSignal(SensorName.Drive(SignalName.Reverse)),// SignalType.Ushort),                                          
                                          signals.GetSignal(SensorName.Cord(1)), //SignalType.Ushort), // F1                                          
                                          signals.GetSignal(SensorName.Cord(2)), //SignalType.Ushort), // F2                                          
                                          signals.GetSignal(SensorName.Cord(3)), //SignalType.Ushort), // F3                                          
                                          signals.GetSignal(SensorName.Cord(4)), //SignalType.Ushort), // F4                                          
                                          signals.GetSignal(SensorName.Cord(5)), //SignalType.Ushort), // F5                                          
                                          signals.GetSignal(SensorName.Cord(6)), //SignalType.Ushort), // F6                                          
                                          null,//new Signal(SensorName.Empty()),                                          
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv11, SignalName.Feedback)), //SignalType.Ushort),// K1                                          
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv2, SignalName.Feedback)), //SignalType.Ushort),// K2                                           
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv1, SignalName.Feedback)), //SignalType.Ushort),// K3 -                                           
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv9, SignalName.Feedback)), //SignalType.Ushort),//  K4  
                                          //signals.GetSignal(SensorName.Relay(RelayName.Kv8, SignalName.Feedback)), //SignalType.Ushort),// K4 -                                           
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv10, SignalName.Feedback)), //SignalType.Ushort),// K5 -                                           
                                          null,//signals.GetSignal(SensorName.Relay(RelayName.Kv10, SignalName.Feedback)), //SignalType.Ushort),// K6, now K4                                        
                                          null//new Signal(SensorName.Empty()) 
                                      });
            }

        }


        public static void Initwago750494(Coupler wago, ISignalsFactory signals)
        {
            {
                W750493.Add(wago, 0, new List<ISignal>
                                              {
                                                 signals.GetSignal(SensorName.Phase(1, SignalName.Voltage))
                                              });

                W750514.Add(wago, 518, new List<ISignal>
                                            {                                                     
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv4)),             // sound alarm                                                 
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv11)),            // pump on              
                                  
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv10)),            //                                               
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv9)),             //                                                 

                                                signals.GetSignal(SensorName.Relay(RelayName.RectifierReset)),  // rectifier reset//null,//new Signal(SensorName.Relay(RelayName.Kv10)),//mode mix,                                                                                           
                                                signals.GetSignal(SensorName.Relay(RelayName.Kv1)),             // rectifier active mode
                                            });


                W7501405.Add(wago, 6, new List<ISignal>
                                      {                                                                                                       
                                          signals.GetSignal(SensorName.Drive(SignalName.Forward)),// SignalType.Ushort),                                          
                                          signals.GetSignal(SensorName.Drive(SignalName.Reverse)),// SignalType.Ushort),                                          
                                          signals.GetSignal(SensorName.Cord(1)), //SignalType.Ushort), // F1                                          
                                          signals.GetSignal(SensorName.Cord(2)), //SignalType.Ushort), // F2                                          
                                          signals.GetSignal(SensorName.Cord(3)), //SignalType.Ushort), // F3                                          
                                          signals.GetSignal(SensorName.Cord(4)), //SignalType.Ushort), // F4                                          
                                          signals.GetSignal(SensorName.Cord(5)), //SignalType.Ushort), // F5                                          
                                          signals.GetSignal(SensorName.Cord(6)), //SignalType.Ushort), // F6                                          
                                          null,//new Signal(SensorName.Empty()),                                          
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv11, SignalName.Feedback)), //SignalType.Ushort),// K1                                          
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv2, SignalName.Feedback)), //SignalType.Ushort),// K2                                           
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv1, SignalName.Feedback)), //SignalType.Ushort),// K3 -                                           
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv9, SignalName.Feedback)), //SignalType.Ushort),//  K4  
                                          //signals.GetSignal(SensorName.Relay(RelayName.Kv8, SignalName.Feedback)), //SignalType.Ushort),// K4 -                                           
                                          signals.GetSignal(SensorName.Relay(RelayName.Kv10, SignalName.Feedback)), //SignalType.Ushort),// K5 -                                           
                                          null,//signals.GetSignal(SensorName.Relay(RelayName.Kv10, SignalName.Feedback)), //SignalType.Ushort),// K6, now K4                                        
                                          null//new Signal(SensorName.Empty()) 
                                      });
            }

        }

    }
}