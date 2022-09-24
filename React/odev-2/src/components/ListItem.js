import React, { useEffect, useState } from 'react'


function ListItem({todo,setTodos,todos}) {
    const [data,setData] = useState({id:0,todo:'',done:false});

    useEffect(()=>{
        setData(todo); 
    },[todo])

    const setDone = (x) =>{
        console.log(x)
        setData({...data, done:x})
        
        console.log(data)
    }

    const konsol = () =>{
      setTodos(todos.map(z => z.id===data.id?data:z))
    }

    useEffect(() => {
      konsol()
    }, [data])
    

    

    const destroyTodo = () =>{
        const ntd = todos.filter(t=> t.id!==data.id)
        setTodos(ntd)
    }

  return (
    <li className={data.done?"completed":null}>
		<div className="view">
			<input className="toggle" type="checkbox" checked={data.done} onChange={(e)=>setDone(e.target.checked)} />
			<label>{data.todo}</label>
			<button className="destroy" onClick={()=>destroyTodo()}></button>
		</div>
	</li>
  )
}

export default ListItem