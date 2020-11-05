 //need adding React | ReactDom | Babel
 function Person(props){
     return(
        <div className="person">
            <h1>{props.name}</h1>
            <p>Age: {props.age}</p>
        </div>
     )
 }

var app = (
<div>
    <Person name="Brown" age="35" />
    <Person name="Red" age="45" />
</div>
 )
 ReactDOM.render(app,document.querySelector('#root'));
 