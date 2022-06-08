
namespace Aula11CrudClient.Models.Domains
{
    public class Debit
    {
        public Debit(){}

        public Debit(int id, double value, string date, Client client)
        {
            this.Id = id;
            this.Value = value;
            this.Date = date;
            this.Client = client;
        }

        public int Id { get; set; }
        public double Value { get; set; }
        public string Date { get; set; }
        public Client Client{ get; set; }
    }
}