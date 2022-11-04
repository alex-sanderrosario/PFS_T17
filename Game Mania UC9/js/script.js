$(document).ready(function(){
    let slideAtual = 1
    let listaSlides = ["banner-f1", "banner-cs", "banner-lol", "banner-gamemania"]

    setInterval(mudarslide, 2000);

    function mudarslide(){
        //remover o slider anterior
        if (slideAtual > 0){
            $("#carrossel").removeClass(listaSlides[slideAtual -1])

        }
        else {
            $("#carrossel").removeClass(listaSlides[listaSlides.length -1])
        }
       

        //exibir o slider atual
        $("#carrossel").addClass(listaSlides[slideAtual])

        //indicar qual o slider atual
        console.log("slide atual é: ",slideAtual)
       
        slideAtual ++

        if (slideAtual > listaSlides. length -1){
            slideAtual = 0
        }

    }
}) 

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

