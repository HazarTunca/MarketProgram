namespace MarketProgram
{
    public interface ISaveable
    {
        object GetSaveData();
        void Load(object loadedData);
    }
}