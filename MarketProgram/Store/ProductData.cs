namespace MarketProgram.Store
{
    [System.Serializable]
    public class ProductData
    {
        public string barcodeID;
        public string productName;
        public double price;
        public uint count;

        public ProductData()
        {

        }

        public ProductData(string barcodeID, string productName, double price, uint count)
        {
            this.barcodeID = barcodeID;
            this.productName = productName;
            this.price = price;
            this.count = count;
        }
    }
}