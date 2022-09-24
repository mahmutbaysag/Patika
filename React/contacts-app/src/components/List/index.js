import React, { useState } from "react";

function List({ contacts }) {
  const [filterText, setFilterText] = useState("");

  const filtered = contacts.filter(item=>{
   return Object.keys(item).some(key=>
    item[key]
    .toString()
    .toLowerCase()
    .includes(filterText.toLocaleLowerCase())
   )
  })

  return (
    <div className="p-0 m-0">
      <input className="form-control" placeholder="Filter Contact" value={filterText}
      onChange={(e)=>setFilterText(e.target.value)} />
      <hr className="col-md-6" />
      <ul className="list-group col-md-6">
        {filtered.map((contact, index) => (
          <li key={index} className="list-group-item">
            {contact.name} : {contact.phone}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default List;
