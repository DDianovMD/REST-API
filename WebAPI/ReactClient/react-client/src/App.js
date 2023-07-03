import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Home } from './Components/Home.js'
import {
  BrowserRouter as Router,
  Routes,
  Route,
} from "react-router-dom";
import { NavBar } from './Components/NavBar';

function App() {

  

  return (
    <div className="App">
      <Router>
        <NavBar />
        <Routes>
          <Route exact path='/' element={<Home />}></Route>
        </Routes>
      </Router>
    </div>
  );
}

export default App;
