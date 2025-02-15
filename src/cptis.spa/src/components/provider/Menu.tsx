import { Link, Route, Routes } from 'react-router';
import { AppShell } from '@mantine/core';
import Edit from './Edit.tsx';
import Create from './Create.tsx';

const Menu = () => {
    return <>
        <AppShell.Navbar p='md'>
            <Link to='/provider'>
                Search
            </Link>
        </AppShell.Navbar>
        <AppShell.Main>
            <Routes>
                <Route path='/:id' element={<Edit/>}/>
                <Route path='/create' element={<Create/>}/>
            </Routes>
        </AppShell.Main>
    </>;
}

export default Menu;