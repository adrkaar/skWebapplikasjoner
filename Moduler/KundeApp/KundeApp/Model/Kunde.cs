namespace KundeApp.Model
{
    public class Kunde
    {   
        //Definerer ID i databasen
        //ID blir autoimcriment i databasen
        public int id { get; set; }
        public string navn { get; set; }
        public string adresse { get; set; }

    }
}
