namespace Service.Repositories
{
    public interface IUpdatesRepository
    {
        void UpdateTimeTable(Model.Controller controller);
        string GetRelativeTimeTableFileName(long imei);
    }
}