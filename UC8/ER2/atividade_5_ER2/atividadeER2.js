//atividade card 9 - atividade 5 - encontro remoto 2

let numeroDeAluno = 10;
for (let contador = 0; contador <= numeroDeAluno; contador ++) {
   

    if (contador == 0) {
        
        console.log(`${contador} - Zero`) //interpelação
        //console.log(contador + " - Zero") //concatenação
    }
    else if((contador % 2) == 0){
        console.log(`${contador} - Par`)
    }
    else console.log(`${contador} - Impar`)



}
