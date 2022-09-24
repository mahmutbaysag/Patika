import React, {useState, useEffect} from 'react'

const initialFormValues = {name:'', phone:''};

function Form({setContacts,contacts}) {
  const [form,setForm] = useState(initialFormValues);

  const onChangeInput = (e) =>{
    setForm({...form, [e.target.name]:e.target.value})
  }

  const onSubmit = (e) =>{
    e.preventDefault();
    if (form.name ==="" || form.phone === "") return false;

    setContacts([...contacts,form])
  }

  useEffect(()=>{
    setForm(initialFormValues);
  },[contacts])

  return (
    <div className='col-md-6'>
      <form className='form' onSubmit={onSubmit}>
        <input className='form-control mb-2' pattern='[a-zA-Z\s]{0,24}' value={form.name} onChange={onChangeInput} name="name" placeholder='Name' />
        <input className='form-control mb-2' pattern='[0-9]{10}' value={form.phone} onChange={onChangeInput} name='phone' placeholder='Phone' />
        <button className='btn btn-primary float-end ' type='submit'> Ekle </button>
      </form>
    </div>
  )
}

export default Form