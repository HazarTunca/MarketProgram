using MarketProgram;
using MarketProgram.SaveSystems;
using System.Collections.Generic;

namespace MarketProgram.Store
{
    public class StoreInventory : ISaveable
    {
        Dictionary<uint, ProductData> productDatas = new Dictionary<uint, ProductData>();

        public void AddProduct(ProductData productData)
        {
            productDatas.Add(productData.barcodeID, productData);
        }

        public void AddProduct(uint barcodeID, string productName, double price)
        {
            productDatas.Add(barcodeID,
                new ProductData
                {
                    barcodeID = barcodeID,
                    productName = productName,
                    price = price,
                    count = 0
                });
        }

        public void AddProduct(uint barcodeID, string productName, double price, uint count)
        {
            productDatas.Add(barcodeID,
                new ProductData
                {
                    barcodeID = barcodeID,
                    productName = productName,
                    price = price,
                    count = count,
                });
        }

        public object GetSaveData()
        {
            return productDatas;
        }

        public void Load(object loadedData)
        {
            productDatas = (Dictionary<uint, ProductData>)loadedData;
        }
    }
}
