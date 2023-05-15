namespace API.Entities
{
    public class Ticket
    {
        public int Id { get; set; }


        //Solicitare
        public int SolicitareId { get; set; }
        public Solicitare Solicitare { get; set; }


        //Unitate expeditoare
        public int UnitateId { get; set; }
        public Unitate Unitate { get; set; }


        //Status
        public int StatusId { get; set; }
        public Status Status { get; set; }


        //Serviciu Asignat
        public int ServiciuId { get; set; }
        public Serviciu Serviciu { get; set; }



        public int idUserExpeditor { get; set; }

        public string emailSolicitant { get; set; }

        public string tlfnInteriorSolicitant { get; set; }

        public string tlfMobilSolicitant { get; set; }

        public DateTime dataDeschidereTicket { get; set; } = DateTime.Now;
        public string Descriere { get; set; }

        public int idLucratorAsignat { get; set; }
        public bool Valid { get; set; }
    }
}