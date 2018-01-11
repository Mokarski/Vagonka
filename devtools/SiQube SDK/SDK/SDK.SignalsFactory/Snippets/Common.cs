namespace SDK.SignalsFactory
{
    /*
        private void Processing()
        {
            mJournal.Info("Wago coupler started");
            try
            {
                while (true)
                {
                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        mJournal.Fatal(ex);
                    }
                }
            }
            catch (ThreadAbortException)
            {
                mConnection.Close();
                mJournal.Info("Wago coupler stopped");
            }
        }

        public void Start()
        {
            if (mThread.IsAlive)
                return;

            mThread.Start();
        }

        public void Stop()
        {
            mThread.Abort();
        }
*/
    
    
    public class Common
    {
        /*
public void AddFloat(ISignal signal, ushort address, bool isReadOnly = true)
{
    if (signal == null)
        throw new ArgumentNullException("signal");

    if (!IsValidAddress(SignalType.Float, address, byte.MaxValue))
        throw new ArgumentException();

    var rv = new SignalDescription(signal, SignalType.Float, address, byte.MaxValue, isReadOnly);
    //mSignals.Add(string.Format("{0}.{1}", rv.Signal.Id, mSignals.Count), rv); // TODO: for debug only
    mSignals.Add(rv.Signal.Id, rv);
}

public void AddUint(ISignal signal, ushort address, bool isReadOnly = true)
{
    if (signal == null)
        throw new ArgumentNullException("signal");

    if (!IsValidAddress(SignalType.Uint, address, byte.MaxValue))
        throw new ArgumentException();

    var rv = new SignalDescription(signal, SignalType.Uint, address, byte.MaxValue, isReadOnly);
    mSignals.Add(rv.Signal.Id, rv);
}

public void AddUshort(ISignal signal, ushort address, bool isReadOnly = true)
{
    if (signal == null)
        throw new ArgumentNullException("signal");

    if (!IsValidAddress(SignalType.Ushort, address, byte.MaxValue))
        throw new ArgumentException();

    var rv = new SignalDescription(signal, SignalType.Ushort, address, byte.MaxValue, isReadOnly);
    mSignals.Add(rv.Signal.Id, rv);
}

public void AddDiscreet(ISignal signal, ushort address, byte bit, bool isReadOnly = true)
{
    if (signal == null)
        throw new ArgumentNullException("signal");

    if (!IsValidAddress(SignalType.Discreet, address, bit))
        throw new ArgumentException();

    var rv = new SignalDescription(signal, SignalType.Discreet, address, bit, isReadOnly);
    mSignals.Add(rv.Signal.Id, rv);
}
*/
    }
}