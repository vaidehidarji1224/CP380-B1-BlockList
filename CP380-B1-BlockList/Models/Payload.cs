
namespace CP380_B1_BlockList.Models
{
    public enum TransactionTypes
    {
        BUY, SELL, GRANT
    }

    public class Payload
    {
        public string user
        { get; set; }
        public TransactionTypes transType
        { get; set; }
        public string titem
        { get; set; }
        public int tamount
        { get; set; }

        public Payload(string userName, TransactionTypes transType,  string titem , int tamount)
        {
            this.user = userName;
            this.transType = transType;
            this.titem = titem;
            this.tamount = tamount;
        }
    }
}
