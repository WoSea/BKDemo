import React,{useState} from "react";
import "./App.css";
import  Person from './components/Person';
import  Example  from './components/Example';

function App() {

  const [persons,setPersons] = useState([
    {name:"Red", age:4},
    {name:"Green", age:43},
    {name:"Blue", age:452},

  ]);
  const changeNameHandler = (e)=> {
    setPersons([
      {name:"Brown", age:14},
      {name:"Yellow", age:33},
      {name:"White", age:52},
  
    ]);
  };

  const switchNameHandler =(event)=>{
    setPersons([
      {name:event.target.value, age:14},
      {name:event.target.value,
         age:33},
      {name:event.target.value, age:52},
    ]);
  };
  return (
      <>

        <div className="App">
            <h1>React application</h1>
            <button onClick={(e) => changeNameHandler()}>Change Name</button>
            <Person click={()=>changeNameHandler()}  changed={switchNameHandler}
             name={persons[0].name} age={persons[0].age}></Person>
           
            <Person click={changeNameHandler}   changed={switchNameHandler}
              name={persons[1].name} age={persons[1].age}></Person>

            <Person click={changeNameHandler}  changed={switchNameHandler}
            name={persons[2].name} age={persons[2].age}></Person>
            <Example></Example>
        </div>  
    </>
  );
}
/*function App() {
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
*/
/*class App extends Component {
  render() {
    return (
      // <div className="App">
      //  <h1>This is the first React application</h1>
      //  <p>Description</p>
      // </div>
      //Cant put your UI code outerdiv
      //React.createElement('div',{className:'App'},React.createElement('h1',null,'This is the first React app'))
      <>
        <div className="App">
          <h1> This is the first React application </h1>
        </div> 
        <p> Can put your code here </p> 
      </>
    );
  }
}*/

export default App;
