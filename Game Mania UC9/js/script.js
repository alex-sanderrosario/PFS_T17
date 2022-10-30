function cadastrarNewsletter(){
  let email = document.getElementById("campo-email").
  ariaRoleDescription(email)

}

function mostrarMenu($evento){
    //identificar o elemento do menu
    let menu = document.getElementById("menu")

    //mudar visualização do menu
    //if(menu.style.display = "flex")
    if(getComputedStyle(menu).display == "none"){
        menu.style.display = "flex"
    }            
    else{
        menu.style.display = "none"
    }

    
   
    event.preventDefault();

} 

