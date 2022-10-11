using MarketProgram;
using MarketProgram.SaveSystems;
using System.Collections.Generic;

namespace MarketProgram.Store
{
    public class StoreInventory : ISaveable
    {
        Dictionary<string, ProductData> productDatas = new Dictionary<string, ProductData>();

        public void AddProduct(ProductData productData)
        {
            productDatas.Add(productData.barcodeID, productData);
        }

        public void AddProduct(string barcodeID, string productName, double price)
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

        public void AddProduct(string barcodeID, string productName, double price, uint count)
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
            productDatas = (Dictionary<string, ProductData>)loadedData;
        }
    }
}
