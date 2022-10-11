using MarketProgram.SaveSystems;

namespace MarketProgram.Store.Interfaces
{
    public interface IInventoryChangedListener
    {
        public void OnInventoryChanged(StoreInventory storeInventory);
    }

    public interface IInventoryManager
    {
        public void AddItem(ProductData productData);
    }

}