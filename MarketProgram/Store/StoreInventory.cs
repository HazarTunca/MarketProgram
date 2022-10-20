using MarketProgram;
using System.Collections.Generic;
using XIV.SaveSystems;

namespace MarketProgram.Store
{
    public class StoreInventory : ISaveable
    {
        Dictionary<string, ProductData> productDatas = new Dictionary<string, ProductData>();

        static StoreInventory instance;
        public static StoreInventory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = SaveSystem.Load<StoreInventory>(MarketProgramPaths.ProductSavePath);
                }
                return instance;
            }
        }

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

        public bool UpdateProduct(string barcodeID, ProductData newProductData)
        {
            if (productDatas.ContainsKey(barcodeID) == false)
            {
                return false;
            }
            if(newProductData.barcodeID != barcodeID)
            {
                productDatas.Remove(barcodeID);
                AddProduct(newProductData);
            }
            else
            {
                productDatas[barcodeID].productName = newProductData.productName;
                productDatas[barcodeID].price = newProductData.price;
                productDatas[barcodeID].count = newProductData.count;
            }
            return true;
        }

        public bool Contains(string barcodeID)
        {
            return productDatas.ContainsKey(barcodeID);
        }

        public IEnumerable<ProductData> Products()
        {
            foreach (ProductData productData in productDatas.Values)
            {
                yield return productData;
            }
        }

        object ISaveable.GetSaveData()
        {
            return productDatas;
        }

        void ISaveable.Load(object loadedData)
        {
            productDatas = (Dictionary<string, ProductData>)loadedData;
        }
    }
}
