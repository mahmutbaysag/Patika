import { useState,useEffect } from 'react';
import Form from './components/Form'
import List from './components/List'

function App() {
  const [contacts,setContacts] = useState([
    {name:'Mahmut', phone:'1234567890'},
    {name:'Ali', phone:'5469785421'},
    {name:'Ayşe', phone:'1555567890'},
    {name:'Veli', phone:'7469827890'},
    {name:'Selin', phone:'5679852431'}
  ]);

  useEffect(()=>{
    console.log(contacts)
  })

  return (
    <div className="App col-sm-6 p-3 offset-md-5 mt-4">
      <h3>Contacts List App</h3>
      <List contacts={contacts}  />
      <hr className='col-md-6' />
      <Form setContacts={setContacts} contacts={contacts} />
    </div>
  );
}

export default App;
