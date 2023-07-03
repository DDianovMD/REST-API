import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { NavBar } from './Components/NavBar';
import { Home } from './Components/Home.js'
import { Edit } from './Components/Edit';
import {
  BrowserRouter as Router,
  Routes,
  Route,
} from "react-router-dom";

function App() {

  

  return (
    <div className="App">
      <Router>
        <NavBar />
        <Routes>
          <Route exact path='/' element={<Home />}></Route>
          <Route path='/edit' element={<Edit />}></Route>
        </Routes>
      </Router>
    </div>
  );
}

export default App;
