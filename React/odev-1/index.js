import axios from "axios"

const getUser = async (userid) =>{
    const userData = await axios.get('https://jsonplaceholder.typicode.com/users/'+userid).then(u => u.data);
    const postData = await axios.get('https://jsonplaceholder.typicode.com/posts?userId='+userid).then(p => p.data);

    return {...userData, posts:postData};
}

console.log(await getUser(1));