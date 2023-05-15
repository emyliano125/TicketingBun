import { useEffect, useState } from "react";
import { Ticket } from "../../app/models/ticket"
import TicketList from "./TicketList";
import agent from "../../app/api/agent";
import LoadingComponent from "../../app/layout/LoadingComponent";
import { Box, Typography } from "@mui/material";


export default function VizualizareTicketePrimite() {

    const [tickets, setTickets] = useState<Ticket[]>([]);
    const [loading,setLoading] = useState(true);


    useEffect(() => {
      agent.Ticket.list()
        .then(tickets=>setTickets(tickets))
        .catch(error => console.log(error))
        .finally(() => setLoading(false))
    }, [])

    if(loading) return <LoadingComponent message="Incarcare tickete..."/>
  
    // function addTicket() {
    //   setTickets(prevState => [...prevState,
    //   {
    //     id: prevState.length + 1,
    //     idTipSolicitare: prevState.length + 1,
    //     idUnitateExpeditoare: prevState.length + 1,
    //     idUserExpeditor: prevState.length + 1,
    //     emailSolicitant: 'Finalizat',
    //     tlfnInteriorSolicitant: '123455123',
    //     tlfMobilSolicitant: '1231231231231',
    //     dataDeschidereTicket: '02/03/2023',
    //     descriere: 'Tipsolicitare' + (prevState.length + 1),
    //     idStatus: 2,
    //     idLucratorAsignat: 0,
    //     idServiciuAsignat: 0,
    //     valid: true,
    //   }])
    // }
  

    return (
        <>
         <Box
                    sx={{
                        p: 3,
                        boxShadow:
                            '0 0 2px 0 rgba(145, 158, 171, 0.2), 0 12px 24px -4px rgba(145, 158, 171, 0.12)',
                        background: "white",
                        borderRadius: '16px',
                        padding: '2rem',
                        position: 'relative',
                        

                    }}

                >
            <Typography variant="h4" sx={{mt:6,mb:5}}>Vizualizare tickete</Typography>
           <TicketList tickets = {tickets} />
           </Box>
        </>





    )
}