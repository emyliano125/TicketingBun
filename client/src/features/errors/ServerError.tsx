import { Container, Divider, Paper, Typography } from "@mui/material";
import { useLocation } from "react-router-dom";

export default function ServerError() {
    const { state } = useLocation();
    return (
        <Container component={Paper}>
            {state?.error ? (
                <>
                    <Typography gutterBottom variant="h3" color='error'>
                        {state.error.title}
                    </Typography>
                    <Divider/>
                    <Typography variant="body1">{state.error.detail || 'Eroare de Server'}</Typography>
                </>
            ) : (
                <Typography gutterBottom variant="h5" color='secondary'>
                        Eroare de Server
                    </Typography>
            )}
            <Typography variant='h5' gutterBottom>Eroare de Server</Typography>
        </Container>
    )
}