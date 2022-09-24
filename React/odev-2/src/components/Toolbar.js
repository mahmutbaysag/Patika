import React, {   useState } from 'react'

function Toolbar({todos,setFiltered,setTodos}) {
	const [activeFilter,setActiveFilter] = useState(1)

const filtre = (t) => {
	if(t===2){
		//active
		setActiveFilter(2)
		setFiltered(todos.filter(x=> x.done===false))
	}else if(t===3){
		//completed
		setFiltered(todos.filter(x=> x.done===true))
		setActiveFilter(3)
	}else{
		//all
		setFiltered(todos)
		setActiveFilter(1)
	}
}




const clearComplated = () => {
	setTodos(todos.filter(x => x.done===false))

}

  return (
    <footer className="footer">
	      	<span className="todo-count">
	      		<strong>{todos.filter(x=> x.done===false).length}</strong>
	      		items left
	      	</span>

	      	<ul className="filters">
	      		<li>
	      			<a href="#/" onClick={(e)=>filtre(1)} className={activeFilter===1?"selected":null}>All</a>
	      		</li>
	      		<li>
	      			<a href="#/" onClick={(e)=>filtre(2)} className={activeFilter===2?"selected":null}>Active</a>
	      		</li>
	      		<li>
	      			<a href="#/" onClick={(e)=>filtre(3)} className={activeFilter===3?"selected":null}>Completed</a>
	      		</li>
	      	</ul>

	      	<button className="clear-completed" onClick={()=> clearComplated()}>
	      		Clear completed
	      	</button>
	      </footer>
  )
}

export default Toolbar