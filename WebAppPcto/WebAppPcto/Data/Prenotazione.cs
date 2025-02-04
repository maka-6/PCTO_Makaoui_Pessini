namespace WebAppPcto.Data
{
    public class Prenotazione
    {
        public required int Id { get; set; }
        public required string NameUser {get;set;}
        public required int IndViaggio {get;set;}
        public required string Email {get;set;}
        public required decimal Price {get;set;}
    }
}
