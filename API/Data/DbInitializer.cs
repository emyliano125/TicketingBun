using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if(!userManager.Users.Any())
            {
                var admin = new User{
                    UserName = "emilian.dumitru",
                    Email = "dumitru_emilian@politia.local"
                };
                await userManager.CreateAsync(admin,"Shippuuden2");
                await userManager.AddToRolesAsync(admin, new[] {"Member","Admin"});
          
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user,"Pa$$w0rd");
                await userManager.AddToRoleAsync(user,"Member");

            }


            // if (context.Servicii.Any()) return;
            // var serivcii = new List<Serviciu>
            // {
            //     new Serviciu
            //     {
            //         Denumire="Serviciul pentru Managementul Integrat al Bazelor de Date",
            //         Prescurtare="SMIBD",
            //         Valid = true,

            //     },
            //    new Serviciu
            //     {
            //         Denumire="Serviciul pentru Administrare Sistemelor Informatice",
            //         Prescurtare="SASI",
            //         Valid = true,

            //     },
            //      new Serviciu
            //     {
            //         Denumire="Serviciul Comunicatii Telefonice si Radio",
            //         Prescurtare="SCTR",
            //         Valid = true,

            //     },
            //     new Serviciu
            //     {
            //         Denumire="Serviciul pentru Managementul Dezvoltarii Aplicatiilor Informatice",
            //         Prescurtare="SMDAI",
            //         Valid = true,

            //     },
            //     new Serviciu
            //     {
            //         Denumire="Serviciul pentru Administrarea Retelelor de Comunicatii si Internetului",
            //         Prescurtare="SARCI",
            //         Valid = true,

            //     },
            //      new Serviciu
            //     {
            //         Denumire="Serviciul Suport pentru Comunicatii si Tehnologia Informatiei",
            //         Prescurtare="SSCTI",
            //         Valid = true,

            //     },
            //     new Serviciu
            //     {
            //         Denumire="Compartimentul Management Solutii Informatice",
            //         Prescurtare="MSI",
            //         Valid = true,

            //     },

            // };

            // if (context.Statusuri.Any()) return;
            // var statusuri = new List<Status>
            // {
            //     new Status
            //     {
            //         Denumire="Deschis",


            //     },
            //     new Status
            //     {
            //         Denumire="Rezolvare",


            //     },
            //     new Status
            //     {
            //         Denumire="Rezolvat",


            //     },
            //     new Status
            //     {
            //         Denumire="Inchis",


            //     },

            // };

            // if (context.Unitati.Any()) return;
            // var unitati = new List<Unitate>
            // {
            //     new Unitate
            //     {
            //         Denumire="Inspectoratul General al Politiei Romane - DCTI",
            //         Valid=true,


            //     },
            //     new Unitate
            //     {
            //         Denumire="Inspectoratul General al Politiei Romane - DOS",
            //         Valid=true,


            //     },

            //     new Unitate
            //     {
            //         Denumire="Inspectoratul General al Politiei Romane - DCCO",
            //         Valid=true,


            //     },
            //      new Unitate
            //     {
            //         Denumire="Inspectoratul General al Politiei Romane - INC",
            //         Valid=true,


            //     },

            // };

            // if (context.Solicitari.Any()) return;
            // var solicitari = new List<Solicitare>
            // {
            //     new Solicitare
            //     {
            //         Denumire="Creare cont aplicatii",
            //         ServiciuAsignatId = 1,
            //         Valid = true,

            //     },
            //       new Solicitare
            //     {
            //         Denumire="Schimbare parola cont local",
            //         ServiciuAsignatId = 2,
            //         Valid = true,

            //     },
            //      new Solicitare
            //     {
            //         Denumire="Spatiu insuficient pe server",
            //         ServiciuAsignatId = 2,
            //         Valid = true,

            //     },
            //      new Solicitare
            //     {
            //          Denumire="Mutare cont",
            //          ServiciuAsignatId = 2,
            //         Valid = true,

            //     },
            //      new Solicitare
            //     {
            //          Denumire="Probleme statie tetra",
            //          ServiciuAsignatId = 3,
            //         Valid = true,

            //     },
            //      new Solicitare
            //     {
            //          Denumire="Probleme aplicatie",
            //          ServiciuAsignatId = 4,
            //         Valid = true,

            //     },
            //      new Solicitare
            //     {
            //          Denumire="Probleme retea",
            //          ServiciuAsignatId = 5,
            //         Valid = true,

            //     },
            //      new Solicitare
            //     {
            //          Denumire="Schimbare imprimanta",
            //          ServiciuAsignatId = 6,
            //         Valid = true,

            //     },
            //      new Solicitare
            //     {
            //          Denumire="Proiect",
            //          ServiciuAsignatId = 7,
            //         Valid = true,

            //     },


            // };

            if (context.Tickets.Any()) return;
            var tickets = new List<Ticket>
            {

            new Ticket
                {
                    SolicitareId = 1,
                    UnitateId = 2,
                    idUserExpeditor = 1,
                    emailSolicitant = "nume_prenume@politia.local",
                    tlfnInteriorSolicitant = "010101",
                    tlfMobilSolicitant = "1111111111",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Notă: Funcția TEXT va face conversia numerelor la text, fapt care poate îngreuna referirea la ele în calcule ulterioare. Se recomandă să păstrați valoarea inițială într-o singură celulă, apoi să utilizați funcția TEXT în altă celulă. Apoi, dacă trebuie să construiți alte formule, faceți întotdeauna referire la valoarea inițială și nu la rezultatul funcției TEXT.",
                    StatusId = 1,
                    idLucratorAsignat = 1,
                    ServiciuId = 1,
                    Valid = true,

                },
                 new Ticket
                {
                    SolicitareId = 2,
                    UnitateId = 3,
                    idUserExpeditor = 2,
                    emailSolicitant = "nume_prenume@politia.local",
                    tlfnInteriorSolicitant = "010101",
                    tlfMobilSolicitant = "1111111111",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Notă: Funcția TEXT va face conversia numerelor la text, fapt care poate îngreuna referirea la ele în calcule ulterioare. Se recomandă să păstrați valoarea inițială într-o singură celulă, apoi să utilizați funcția TEXT în altă celulă. Apoi, dacă trebuie să construiți alte formule, faceți întotdeauna referire la valoarea inițială și nu la rezultatul funcției TEXT.",
                    StatusId = 2,
                    idLucratorAsignat = 2,
                    ServiciuId = 2,
                    Valid = true,

                },
                 new Ticket
                {
                    SolicitareId = 3,
                    UnitateId = 4,
                    idUserExpeditor = 3,
                    emailSolicitant = "nume_prenume@politia.local",
                    tlfnInteriorSolicitant = "010101",
                    tlfMobilSolicitant = "1111111111",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Notă: Funcția TEXT va face conversia numerelor la text, fapt care poate îngreuna referirea la ele în calcule ulterioare. Se recomandă să păstrați valoarea inițială într-o singură celulă, apoi să utilizați funcția TEXT în altă celulă. Apoi, dacă trebuie să construiți alte formule, faceți întotdeauna referire la valoarea inițială și nu la rezultatul funcției TEXT.",
                    StatusId = 3,
                    idLucratorAsignat = 1,
                    ServiciuId = 2,
                    Valid = true,

                },
                 new Ticket
                {
                    SolicitareId = 4,
                    UnitateId = 2,
                    idUserExpeditor = 4,
                    emailSolicitant = "nume_prenume@politia.local",
                    tlfnInteriorSolicitant = "010101",
                    tlfMobilSolicitant = "1111111111",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Notă: Funcția TEXT va face conversia numerelor la text, fapt care poate îngreuna referirea la ele în calcule ulterioare. Se recomandă să păstrați valoarea inițială într-o singură celulă, apoi să utilizați funcția TEXT în altă celulă. Apoi, dacă trebuie să construiți alte formule, faceți întotdeauna referire la valoarea inițială și nu la rezultatul funcției TEXT.",
                    StatusId = 4,
                    idLucratorAsignat = 4,
                    ServiciuId = 2,
                    Valid = true,

                },
                new Ticket
                {
                    SolicitareId = 5,
                    UnitateId = 3,
                    idUserExpeditor = 5,
                    emailSolicitant = "nume_prenume@politia.local",
                    tlfnInteriorSolicitant = "010101",
                    tlfMobilSolicitant = "1111111111",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Notă: Funcția TEXT va face conversia numerelor la text, fapt care poate îngreuna referirea la ele în calcule ulterioare. Se recomandă să păstrați valoarea inițială într-o singură celulă, apoi să utilizați funcția TEXT în altă celulă. Apoi, dacă trebuie să construiți alte formule, faceți întotdeauna referire la valoarea inițială și nu la rezultatul funcției TEXT.",
                    StatusId = 1,
                    idLucratorAsignat = 5,
                    ServiciuId = 3,
                    Valid = true,

                },
                 new Ticket
                {
                    SolicitareId = 6,
                    UnitateId = 4,
                    idUserExpeditor = 6,
                    emailSolicitant = "nume_prenume@politia.local",
                    tlfnInteriorSolicitant = "010101",
                    tlfMobilSolicitant = "1111111111",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Notă: Funcția TEXT va face conversia numerelor la text, fapt care poate îngreuna referirea la ele în calcule ulterioare. Se recomandă să păstrați valoarea inițială într-o singură celulă, apoi să utilizați funcția TEXT în altă celulă. Apoi, dacă trebuie să construiți alte formule, faceți întotdeauna referire la valoarea inițială și nu la rezultatul funcției TEXT.",
                    StatusId = 2,
                    idLucratorAsignat = 6,
                    ServiciuId = 4,
                    Valid = true,

                },
                 new Ticket
                {
                    SolicitareId = 7,
                    UnitateId = 2,
                    idUserExpeditor = 7,
                    emailSolicitant = "nume_prenume@politia.local",
                    tlfnInteriorSolicitant = "010101",
                    tlfMobilSolicitant = "1111111111",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Notă: Funcția TEXT va face conversia numerelor la text, fapt care poate îngreuna referirea la ele în calcule ulterioare. Se recomandă să păstrați valoarea inițială într-o singură celulă, apoi să utilizați funcția TEXT în altă celulă. Apoi, dacă trebuie să construiți alte formule, faceți întotdeauna referire la valoarea inițială și nu la rezultatul funcției TEXT.",
                    StatusId = 3,
                    idLucratorAsignat = 7,
                    ServiciuId = 5,
                    Valid = true,

                },
                new Ticket
                {
                    SolicitareId = 8,
                    UnitateId = 3,
                    idUserExpeditor = 8,
                    emailSolicitant = "nume_prenume@politia.local",
                    tlfnInteriorSolicitant = "010101",
                    tlfMobilSolicitant = "1111111111",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Notă: Funcția TEXT va face conversia numerelor la text, fapt care poate îngreuna referirea la ele în calcule ulterioare. Se recomandă să păstrați valoarea inițială într-o singură celulă, apoi să utilizați funcția TEXT în altă celulă. Apoi, dacă trebuie să construiți alte formule, faceți întotdeauna referire la valoarea inițială și nu la rezultatul funcției TEXT.",
                    StatusId = 4,
                    idLucratorAsignat = 8,
                    ServiciuId = 6,
                    Valid = true,

                },
                 new Ticket
                {               
                    SolicitareId = 9,
                    UnitateId = 2,
                    idUserExpeditor = 9,
                    emailSolicitant = "nume_prenume@politia.local",
                    tlfnInteriorSolicitant = "010101",
                    tlfMobilSolicitant = "1111111111",
                    dataDeschidereTicket = DateTime.Now,
                    Descriere = "Notă: Funcția TEXT va face conversia numerelor la text, fapt care poate îngreuna referirea la ele în calcule ulterioare. Se recomandă să păstrați valoarea inițială într-o singură celulă, apoi să utilizați funcția TEXT în altă celulă. Apoi, dacă trebuie să construiți alte formule, faceți întotdeauna referire la valoarea inițială și nu la rezultatul funcției TEXT.",
                    StatusId = 2,
                    idLucratorAsignat = 9,
                    ServiciuId = 7,
                    Valid = true,

                },
            };

            // foreach (var item in serivcii)
            // {
            //     context.Servicii.Add(item);
            // }
            // foreach (var item in statusuri)
            // {
            //     context.Statusuri.Add(item);
            // }
            // foreach (var item in unitati)
            // {
            //     context.Unitati.Add(item);
            // }
            // foreach (var item in solicitari)
            // {
            //     context.Solicitari.Add(item);
            // }

             foreach (var item in tickets)
             {
                 context.Tickets.Add(item);
             }

            context.SaveChanges();
        }
    }
}