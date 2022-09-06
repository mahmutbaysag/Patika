
//id içerik ve onay
let todos = [];


let listele = () => {
    if(localStorage.getItem("todos")){
        todos = JSON.parse(localStorage.getItem("todos"));
        let list = "";
   
        todos.forEach(x => {
            if(x.status==0){
                list += `<li class="col-md-12 d-flex p-0" onclick="tamamla(${x.id})">
                    <div class="col-1 pt-1 text-hide">
                        <svg width="16px" height="16px" viewBox="0 0 16 16" xmlns="http://www.w3.org/2000/svg" version="1.1" fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="1.5">
                        <polyline points="2.75 8.75,6.25 12.25,13.25 4.75"/>
                        </svg></div>
                    <div class="col-10 py-2" style="left:-50px">${x.task}</div>
                    <div id="removebutton" onclick="kaldir(${x.id})" class="col-1  m-0 text-center p-2" style="height:3rem;"><svg width="32px" height="32px" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg"><defs><style>.cls-1{fill:none;stroke:rgb(0,0,0);stroke-linecap:round;stroke-linejoin:bevel;stroke-width:1.5px;}</style></defs><g id="ic-actions-close-simple"><line class="cls-1" x1="18.36" y1="18.36" x2="5.64" y2="5.64"/><line class="cls-1" x1="18.36" y1="5.64" x2="5.64" y2="18.36"/></g></svg></div>
                </li>`;
            }else{
                list += `<li class="col-md-12 d-flex p-0" id="tamamlanmis" onclick="tamamla(${x.id})">
                    <div class="col-1 pt-1 ">
                        <svg width="16px" height="16px" viewBox="0 0 16 16" xmlns="http://www.w3.org/2000/svg" version="1.1" fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="1.5">
                        <polyline points="2.75 8.75,6.25 12.25,13.25 4.75"/>
                        </svg></div>
                    <div class="col-10 py-2 text-overline" style="left:-50px"><s>${x.task}</s></div>
                    <div id="removebutton" onclick="kaldir(${x.id})" class="col-1  m-0 text-center p-2" style="height:3rem;"><svg width="32px" height="32px" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg"><defs><style>.cls-1{fill:none;stroke:rgb(0,0,0);stroke-linecap:round;stroke-linejoin:bevel;stroke-width:1.5px;}</style></defs><g id="ic-actions-close-simple"><line class="cls-1" x1="18.36" y1="18.36" x2="5.64" y2="5.64"/><line class="cls-1" x1="18.36" y1="5.64" x2="5.64" y2="18.36"/></g></svg></div>
                </li>`;
            }
            
        })
        let elemen = document.getElementById("list");
        elemen.innerHTML = list;
    
    }
}
listele();
let kaydet = () => {
    localStorage.setItem("todos",JSON.stringify(todos));
    console.log((localStorage.getItem("todos")));
    console.log("kaydedildi");
}


let ekle = () => {
    let todo = new String( document.querySelector("#task").value);
    
    if(todo.trim()==""){
        $("#inputbostoast").toast("show");
    }else{
        let id
        if(todos.length>0){
            id = todos[todos.length-1].id + 1;
        }else{
            id=1;
        }
        
        let newtodo = {id:id, task:todo, status:0};
        todos.push({id:id, task:todo, status:0});
        
        $("#taskeklenditoast").toast("show");
        kaydet();
        listele();
    }   
}

let kaldir = (id) => {
    let newTodos = todos.filter(x => x.id != id);
    todos = newTodos;

    $("#kaldirilditoast").toast("show");
    kaydet();
    listele();
}

let tamamla = (id) => {
    let yeni;
    let newTodos = todos.map(x => {
        if(x.id==id){
          yeni = x;
          yeni.status=!yeni.status;
          return yeni;  
        }
        return x;
    })
    todos = newTodos;

    if(yeni.status==1){
        $("#tamamlanditoast").toast("show");
    }else{
        $("#tamamlanmaditoast").toast("show");
    }
    kaydet();
    listele();
}

