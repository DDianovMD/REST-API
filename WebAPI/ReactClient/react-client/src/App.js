import './App.css';
// import 'bootstrap/dist/css/bootstrap.min.css';
// import { NavBar } from './Components/NavBar';
// import { Home } from './Components/Home.js'
// import { Edit } from './Components/Edit';
// import { Add } from './Components/Add';
// import {
//   BrowserRouter as Router,
//   Routes,
//   Route,
// } from "react-router-dom";

import { PrimeReactProvider } from 'primereact/api';
import { QueryClientProvider, QueryClient } from 'react-query';
import { PrimeReactHomePage } from './Components/PrimeReactHomePage';

const queryClient = new QueryClient();

function App() {
  return (
    <div className="App">
      {/* <Router>
        <NavBar />
        <Routes>
          <Route exact path='/' element={<Home />}></Route>
           <Route path='/edit' element={<Edit />}></Route>
           <Route exact path='/add' element={<Add />}></Route>
        </Routes>
      </Router>  */}
      <QueryClientProvider client={queryClient}>
        <PrimeReactProvider>
          <PrimeReactHomePage></PrimeReactHomePage>
        </PrimeReactProvider>
      </QueryClientProvider>
    </div>
  );
}

export default App;
