let listadepecas = ["filtro de ar","Roda","Peneu"]

listadepecas.push("Disco de freio")
listadepecas.push("Motor")
listadepecas.push("Armotecedor")

//listadepecas[2] = "pastilha" //alterar item da lista pelo indice

if (listadepecas.length <10){
    console.log("É possivel cadastra mais peças!!!")
}
else {
    console.log("Não há mais espaço na caixa")
}

let peso = 150
if(peso < 100){
    console.log("A peça deve pesar no mínimo 100g")
}
else{
    console.log("A peça possui o peso adequado")
}

let nomepeca = "disco de freio"

if (nomepeca.length >3){
    console.log("O nome da peça está adequado para o cadastro")
}
else if(nomepeca.length ==0){
    console.log("O nome da peça não pode ser vazio")
}
else{
    console.log("O nome da peça deve termais de 3 caracteres, digite o nome adequado")
}