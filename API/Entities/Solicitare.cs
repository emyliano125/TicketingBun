

namespace API.Entities
{
    public class Solicitare
    {
        public int Id { get; set; }
        public string Denumire { get; set; }

        //Serviciu
        public int ServiciuAsignatId { get; set; }
        public Serviciu Serviciu { get; set; }
        
        public bool Valid { get; set; }

    }
}