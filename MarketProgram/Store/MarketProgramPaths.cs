using MarketProgram.Store.Interfaces;

namespace MarketProgram.Store
{
    public static class MarketProgramPaths
    {
        public static string BaseFolderPath = Path.Combine(Application.UserAppDataPath, "MarketProgram");
        public static string ProductSavePath = Path.Combine(BaseFolderPath, "ProductSave");
    }
}
