import React from 'react';
import './App.css';

function App() {
  return (
    // <div className="App">
    //  <h1>This is the first React application</h1>
    //  <p>Description</p>
    // </div>
     //Cant put your UI code outerdiv 
     //React.createElement('div',{className:'App'},React.createElement('h1',null,'This is the first React app'))
    <>

        <div className="App">
            <h1>This is the first React application</h1>
           
        </div> 
            <p>Can put your code here</p>
    </>
  );
}

export default App;
