import { Alert, AlertTitle, Button, ButtonGroup, Container, List, ListItem, ListItemText, Typography } from "@mui/material";
import agent from "../../app/api/agent";
import { useState } from "react";

export default function ErrorsPage() {
    const [validationErrors, setVAlidationErrors] = useState<string[]>([]);

    function getValidationError() {
        agent.TestErrors.getValidationError()
            .then(() => console.log('nu trebue sa vezi asta'))
            .catch(error => setVAlidationErrors(error));
    }

    return (
        <Container>
            <Typography gutterBottom variant='h2'>
                Erori pentru testare
            </Typography>
            <ButtonGroup fullWidth>
                <Button variant='contained'
                    onClick={() => agent.TestErrors.get400Error().catch(error => console.log(error))}>
                    Test Eroare 400</Button>
                <Button variant='contained'
                    onClick={() => agent.TestErrors.get401Error().catch(error => console.log(error))}>
                    Test Eroare 401</Button>
                <Button variant='contained'
                    onClick={() => agent.TestErrors.get404Error().catch(error => console.log(error))}>
                    Test Eroare 404</Button>
                <Button variant='contained'
                    onClick={() => agent.TestErrors.get500Error().catch(error => console.log(error))}>
                    Test Eroare 500</Button>
                <Button variant='contained'
                    onClick={getValidationError}>
                    Test Eroare de Validare</Button>
            </ButtonGroup>
            {validationErrors.length > 0 &&
                <Alert severity='error'>
                    <AlertTitle>Eroare de Validare</AlertTitle>
                    <List>
                        {validationErrors.map(error => (
                            <ListItem key={error}>
                                <ListItemText>{error}</ListItemText>
                            </ListItem>
                        ))}
                    </List>
                </Alert>

            }
        </Container>
    )
}