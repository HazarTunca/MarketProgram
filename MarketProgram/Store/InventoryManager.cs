using MarketProgram.Store.Interfaces;

namespace MarketProgram.Store
{
    public static class InventoryManager
    {
        public static string productSavePath = Path.Combine(Application.UserAppDataPath, "MarketProgram/ProductSave");
    }
}
