import { Notifications } from "@mui/icons-material";
import { AppBar, Badge, Box, Card, IconButton, List, ListItem, Toolbar, Typography } from "@mui/material";
import { Link, NavLink } from "react-router-dom";

const midLinks = [
    { title: 'Solicitari AD', path: '/solicitariAD' },
    { title: 'Tickete', path: '/vizualizareTicketePrimite' },
    { title: 'Ticketele Mele', path: '/ticketeleMele' },
    { title: 'Administrare', path: '/administrare' },
    { title: 'Pagina Erori', path: '/errors' },

]

const rightLinks = [
    { title: 'login', path: '/login' },
    { title: 'register', path: '/register' },

]


const navStyles = {
    color: 'inherit',
    typography: 'h6',
    mr: 8,
    whiteSpace: 'nowrap',
    '&:hover': {
        color: 'grey.500'
    },
    '&.active': {
        color: 'text.secondary'
    }
}

export default function Header() {
    return (


        <AppBar position='static' sx={{ mb: 4 }}>
            <Toolbar sx={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>

                <Box display='flex' alignItems='center'>

                    <Typography variant='h6' component={NavLink}
                        to='/'
                        sx={navStyles}>
                        {/* <img style={{ maxWidth: "3%", }}
                            src={require('./logo.png')}
                            alt="Logo" /> */}

                        IGPR-DCTI
                    </Typography>

                </Box>
                <Box >
                    <List sx={{ display: 'flex', justifyContent: 'space-around' }}>
                        {midLinks.map(({ title, path }) => (
                            <ListItem
                                component={NavLink}
                                to={path}
                                key={path}
                                sx={navStyles}
                            >
                                {title.toUpperCase()}
                            </ListItem>
                        ))}
                    </List>
                </Box>

                <Box display='flex' alignItems='center'>

                    <List sx={{ display: 'flex' }}>
                        <IconButton size='large' edge='start' color='inherit' sx={{ mr: 2 }}>
                            <Badge badgeContent='4' color='secondary'>
                                <Notifications />
                            </Badge>

                        </IconButton>
                    </List>
                </Box>


                <Box >
                    <List sx={{ display: 'flex', justifyContent: 'space-around' }}>
                        {rightLinks.map(({ title, path }) => (
                            <ListItem
                                component={NavLink}
                                to={path}
                                key={path} 
                                sx={navStyles}
                            >
                                {title.toUpperCase()}
                            </ListItem>
                        ))}
                    </List>
                </Box>

            </Toolbar>
        </AppBar>



    )
}