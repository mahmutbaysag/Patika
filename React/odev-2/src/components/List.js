import React, { useEffect, useState } from 'react'
import ListItem from './ListItem'
import Toolbar from './Toolbar'

function List({todos,setTodos}) {
    const [filtered,setFiltered] = useState([]);

    useEffect(()=>{
      setFiltered(todos);console.log(todos)
    },[todos])

    const doneAll =(e)=>{
      const {checked} = e;
      setTodos(todos.map(x=>{
        x.done=checked
        return x;
      }))
    }

  return (
    <>
      <section className="main">
	    	<input className="toggle-all" onClick={(e)=>doneAll(e.target)} type="checkbox"  property="toggleAll" id="toggle-all"
				 />
	    	<label htmlFor="toggle-all">
	    		Mark all as complete
	    	</label>
	    	<ul className="todo-list">
	    		{
            filtered.map((todo)=>
              <ListItem key={todo.id} todo={todo} setTodos={setTodos} todos={todos} />
            )
          }
	    	</ul>
	    </section>

      <Toolbar todos={todos} setFiltered={setFiltered} setTodos={setTodos} />
    </>
  )
}

export default List