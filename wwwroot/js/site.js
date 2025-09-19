let ContadorIntentos = 0;
let IntentosLetras = [];
let Adivinanza;
let Gano = null;
function AdivinarPalabra(palabra){
    let LetraIngresada = getElementById("palabraElegida").value;
    for (let X = 0; X < LetraIngresada.length; X++)
    {
        Adivinanza[X] = '-';
    }
    if (LetraIngresada.length === 1)
    {
        ContadorIntentos = ContadorIntentos + 1;
        if (!IntentosLetras.includes(LetraIngresada))
        {
            IntentosLetras.push(LetraIngresada);
            for (let i = 0; i < IntentosLetras.count; i++)
            {
                for (let j = 0; j < Adivinanza.length; j++)
                {
                    if (IntentosLetras[i] == PalabraElegida[j])
                    {
                        Adivinanza[j] = IntentosLetras[i];
                        if(Adivinanza = palabra){
                            ComprarPalabra(palabra);
                        }
                    }
                }
            }
        }
        document.getElementById("res") = Adivinanza;
        document.getElementById("contandor") = ContadorIntentos;

    }
    else
    {
        ComprarPalabra(palabra);
    }
    }

    function ComprarPalabra(palabra)
    {
         if (palabra == LetraIngresada)
         {
            document.getElementById("res") = palabra;
            document.getElementById("alert") = "GANASTE AMIGO, BIEN AHI, EN " + ContadorIntentos + " INTENTOS" ;
            document.getElementById("juego").style.display ="none";
         } 
         else 
         {
            document.getElementById("res") = palabra;
            document.getElementById("alert") = "PERDISTE BURRO EN " + ContadorIntentos + " INTENTOS";
            document.getElementById("juego").style.display ="none";

         }
    }
