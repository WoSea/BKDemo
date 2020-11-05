import React,{useState} from "react";
import "./App.css";
import  Person from './components/Person/Person'; 
import  Example  from './components/Example';

function App() {
  const [showPerson, setShowPerson] = useState(true);
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

  const togglePersons=()=>{
      setShowPerson(!showPerson);
  };

  const deletePerson=(personIndex)=>{
      let newPersons=[...persons];
      newPersons.splice(personIndex,1);
      setPersons(newPersons);
  }
  let personsList =null;
  const styles={
    backgroundColor : 'white',
    font:'inherit',
    border:'1px solid green',
    padding:'8px',
    cursor:'pointer',
    color:'white'
  };

  let classes=[];
if(persons.length<=2 ){ classes.push('red');}
if(persons.length<=1 ){ classes.push('bold');}

  if(showPerson===true){
    personsList=
    <div> 
      {
        persons.map((item,index)=>{
         return ( 
           <Person key={index}
           click={()=>deletePerson(index)}  changed={switchNameHandler}
            name={item.name} age={item.age}></Person>
          );
        })
      } 
    </div>  
  };
  styles.backgroundColor="red";
  return (
      <>
        <div className="App">
            <h1>React application</h1>
            <p className={classes.join(' ')}>This is dynamic class paragraph</p>
            <button style={styles} onClick={() => togglePersons()}>Toggle Persons</button>
                {personsList }
           {/* <Example></Example> */}
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
