import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import Home from './Components/Home';
import {BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
import NavMenu from './Components/NavMenu';
import ProjectDetails from './Components/ProjectDetails';


ReactDOM.render(
  <React.StrictMode>
      <Router>
        <div  style={{marginLeft:"12px"}}>
         
          <p>Home page</p>
          
          {/* <Link to="project/5">Product</Link> */}
          <Switch>
              <Route exact path="/" component={Home} />
              
              <Route  path="/project/:id">
                  <ProjectDetails />
              </Route>
          </Switch>
        </div>
      </Router>
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
