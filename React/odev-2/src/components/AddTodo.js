import React, { useEffect, useState } from 'react'

const initialState = {id:0, todo:'', done:false}

function AddTodo({todos,setTodos}) {
    const [newtodo,setNewTodo] = useState(initialState);

    const onSubmit = (e) => {
        e.preventDefault();
        if(newtodo.todo.trim()==="") return false;

        setTodos([...todos,newtodo])
    }

    useEffect(()=>{
        setNewTodo({...initialState, id:todos.length>0?todos[todos.length-1].id+1:1})
    },[todos])

  return (
    <header className="header">
		<h1>todos</h1>
		<form onSubmit={onSubmit}>
			<input className="new-todo" value={newtodo.todo} onChange={(e)=>setNewTodo({...newtodo, todo:e.target.value})} placeholder="What needs to be done?" autoFocus />
		</form>
	</header>
  )
}

export default AddTodo