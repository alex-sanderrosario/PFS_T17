/* Regras para operadores de comparação
=(é utlizado para atribuição)

== p/ comparação (verificar se é igaual(xor))
ao comparar duas coisas o resultado é booleano portanto true ou false                 
xor
let x = true
let y = false
let resultado = (x==y)
console.log(resultado)
tabela verdade
x = 0 / y = 0 / resultado = 1
x = 0 / y = 1 / resultado = 0
x = 1 / y = 0 / resultado = 0
x = 1 / y = 1 / resultado = 1

=== P/ compraração (verifica se é identico, portanto mesmo tipo de daado e valor)
ex:
x = 20 numero
y = "20" texto

! diferente (not)

< menor
> maior
<= menor igual
>= maior igual
*/
/*operadores de atribuição
= atribuição
+= (x+= y) é a mesma coisa que (x = x + y)
-= (x-= y) é a mesma coisa que (x = x - y)
*= (x*= y) é a mesma coisa que (x = x * y)
/= (x/= y) é a mesma coisa que (x = x / y)
*/

/* Operadores lógicos
&& (e / end)
// (ou / or)
!  (negação / not)

&& 
Tabela verdade
x = 0 / y = 0 / resultado = 0
x = 0 / y = 1 / resultado = 0
x = 1 / y = 0 / resultado = 0
x = 1 / y = 1 / resultado = 1

//
tabela verdade
x = 0 / y = 0 / resultado = 0
x = 0 / y = 1 / resultado = 1
x = 1 / y = 0 / resultado = 1
x = 1 / y = 1 / resultado = 1

==
tabela verdade
x = 0 / y = 0 / resultado = 1
x = 0 / y = 1 / resultado = 0
x = 1 / y = 0 / resultado = 0
x = 1 / y = 1 / resultado = 1

!
tabela verdade
x = 0 / resultado = 1
*/

let x = true
let y = false
let resultado = (x && y)
console.log(resultado)
