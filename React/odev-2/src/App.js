import { useState } from 'react';
import './App.css';
import AddTodo from './components/AddTodo';
import List from './components/List';

function App() {
  const [todos,setTodos] = useState([
    {id:1, todo:'Learn JavaScript', done:true},
    {id:2, todo:'Learn React', done:false},
    {id:3, todo:'Learn a life!', done:false}
  ]);



  return (
    <div className="App">
      <section className="todoapp">
	      
        <AddTodo todos={todos} setTodos={setTodos} />
	      <List todos={todos} setTodos={setTodos} />
	      
      </section>
    </div>
  );
}

export default App;
