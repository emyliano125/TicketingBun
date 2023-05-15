import { Accordion, AccordionDetails, AccordionSummary, Box, Card, CardHeader, Grid, Paper, Stack, TextField, Typography, styled } from "@mui/material";
import axios from "axios";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { Ticket } from "../../app/models/ticket";

import moment from "moment";
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import agent from "../../app/api/agent";
import NotFound from "../errors/NotFound";
import LoadingComponent from "../../app/layout/LoadingComponent";


const Item = styled(Paper)(({ theme }) => ({
    backgroundColor: theme.palette.mode === 'dark' ? '#1A2027' : '#fff',
    ...theme.typography.body2,
    padding: theme.spacing(1),
    textAlign: 'center',
    color: theme.palette.text.secondary,
}));


export default function TicketDetails() {
    const { id } = useParams<{ id: string }>();
    const [ticket, setTicket] = useState<Ticket | null>(null);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
    id && agent.Ticket.details(parseInt(id))
            .then(response => setTicket(response))
            .catch(error => console.log(error))
            .finally(() => setLoading(false));
    }, [id])

    if (loading) return <LoadingComponent message="Incarcare ticket..."/>

    if (!ticket) return <NotFound/>

    return (
        
        <Box  sx={{
            p: 3,
            boxShadow:
                '0 0 2px 0 rgba(145, 158, 171, 0.2), 0 12px 24px -4px rgba(145, 158, 171, 0.12)',
            background: "white",
            borderRadius: '16px',
            padding: '2rem',
            position: 'relative',
          

        }}
>
        <Grid>
            <Typography variant="h2">
                Informatii Ticket -  {ticket.id}
            </Typography>
        </Grid>
        <Grid container spacing={2} sx={{mt:5}}>
            <Grid item xs={12} md={12}>
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
                    <Stack spacing={3}>
                        <Stack direction="row" spacing={2}>
                            
                        <TextField
                                disabled={true}
                                variant='outlined'
                                type='string'
                                label='Solicitant'
                                fullWidth
                                value={ticket.idUserExpeditor}
                            />
                            <TextField
                                disabled={true}
                                variant='outlined'
                                type='string'
                                label='Telefon interior'
                                fullWidth
                                value={ticket.tlfnInteriorSolicitant}
                            />
                            
                                <TextField
                                disabled={true}
                                variant='outlined'
                                type='string'
                                label='Telefon mobil'
                                fullWidth
                                value={ticket.tlfMobilSolicitant}
                            />
                        </Stack>
                        <TextField
                            disabled={true}
                            variant='outlined'
                            type='string'
                            label='Unitatea Expeditoare'
                            fullWidth
                            value={ticket.unitate.denumire}
                        />
                        <TextField 
                                disabled={true}
                                variant='outlined'
                                type='string'
                                label='Tipul Solicitarii'
                                fullWidth
                                value={ticket.solicitare.denumire}
                            />


                    </Stack>
                </Box>
            </Grid>
          
           
            <Grid item xs={12} md={8}>
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
                    <Stack spacing={3} sx={{ minHeight: 433 }}>
                        <Stack direction="column" spacing={2}>
                            <Card sx={{ mt: 1, minHeight: 400 }}>
                                <CardHeader

                                    title={
                                        <>
                                            <Typography color="text.main" 
                                                sx={{
                                                    fontFamily: "Computer Modern Sans, sans-serif",
                                                   
                                                    display: "flex",
                                                    justifyContent: 'left',
                                                    mt: 3

                                                }}
                                            >
                                                {"Ticket creat la: " + moment(ticket.dataDeschidereTicket).format('LL')}
                                            </Typography>
                                            <Typography color="text.main" 
                                                sx={{
                                                    fontFamily: "Computer Modern Sans, sans-serif",
                                                  
                                                    display: "flex",
                                                    justifyContent: "right",

                                                }}
                                            >
                                                {ticket.emailSolicitant}
                                            </Typography>

                                        </>
                                    }
                                    subheader={
                                        <Typography color="text.main" 
                                            sx={{
                                                fontFamily: "Computer Modern Sans, sans-serif",
                                                
                                                display: "flex",
                                                justifyContent: "left",

                                            }}
                                        >
                                            {"Numarul ticketului: " + ticket.id}
                                        </Typography>
                                    }
                                />

                                <Box sx={{ p: 3, pb: 1, mt: 3 }} dir="ltr">
                                    <Stack direction="row" spacing={2}>
                                        <Typography variant="body2" color="text.main" fontSize={18}>
                                            {ticket.descriere}
                                        </Typography>
                                    </Stack>
                                </Box>

                            </Card>
                        </Stack>


                    </Stack>
                </Box>
            </Grid>
            <Grid item xs={12} md={4}>
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
                    <Accordion>
                        <AccordionSummary
                            expandIcon={<ExpandMoreIcon />}
                            aria-controls="panel1a-content"
                            id="panel1a-header"
                        >
                            <Typography sx={{ textAlign: "center" }}>Informatii Suplimentare</Typography>
                        </AccordionSummary>
                        <AccordionDetails >
                            <Stack spacing={3}>
                                <Stack direction="column" spacing={2}>
                                    <TextField
                                        disabled={true}
                                        variant='outlined'
                                        type='string'
                                        label='Nume Solicitant'
                                        fullWidth
                                        value={ticket.idUserExpeditor}
                                    />
                                     <TextField
                                        disabled={true}
                                        variant='outlined'
                                        type='string'
                                        label='Prenume Solicitant'
                                        fullWidth
                                        value={ticket.idUserExpeditor}
                                    />
                                     <TextField
                                        disabled={true}
                                        variant='outlined'
                                        type='string'
                                        label='Status'
                                        fullWidth
                                        value={ticket.status.denumire}
                                    />
                                     <TextField
                                        disabled={true}
                                        variant='outlined'
                                        type='string'
                                        label='Lucrator Asignat'
                                        fullWidth
                                        value={ticket.idLucratorAsignat}
                                    />
                                    <TextField
                                        disabled={true}
                                        variant='outlined'
                                        type='string'
                                        label='Serviciu Asignat'
                                        fullWidth
                                        value={ticket.serviciu.prescurtare}
                                    />
                                </Stack>
                            </Stack>
                        </AccordionDetails>
                    </Accordion>

                </Box>
            </Grid>


        </Grid>
        </Box>

    )
}