import { AppShell, Burger } from '@mantine/core';
import { useDisclosure } from '@mantine/hooks';
import { Route, Routes } from 'react-router';
import ProviderMenu from './components/provider/Menu.tsx';

const App = () => {
const [opened, { toggle }] = useDisclosure();

  return<AppShell
      header={{ height: 60 }}
      navbar={{
        width: 300,
        breakpoint: 'sm',
        collapsed: { mobile: !opened },
      }}
      padding="md"
    >
      <AppShell.Header>
        <Burger
          opened={opened}
          onClick={toggle}
          hiddenFrom="sm"
          size="sm"
        />
        <div>Logo</div>
      </AppShell.Header>
          <Routes>
              <Route path="/provider/*" element={<ProviderMenu />} />
          </Routes>
    </AppShell>;
}

export default App;