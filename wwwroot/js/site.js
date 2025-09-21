let ContadorIntentos = 0;
let IntentosLetras = [];
let Adivinanza = [];
let Gano = null;
let LetraIngresada = "";

function IniciarJuego(palabra) {
    ContadorIntentos = 0;
    IntentosLetras = [];
    Adivinanza = [];
    Gano = null;
    for (let i = 0; i < palabra.length; i++) {
        Adivinanza.push('-');
    }
    document.getElementById("res").innerText = Adivinanza.join('');
    document.getElementById("contandor").innerText = ContadorIntentos;
    document.getElementById("alert").innerText = "";
    document.getElementById("juego").style.display = "block";
    document.getElementById("palabraElegida").value = "";
}

function AdivinarPalabra(palabra) {
    if (Gano !== null) return;

    LetraIngresada = document.getElementById("palabraElegida").value.trim().toLowerCase();
    document.getElementById("palabraElegida").value = "";

    if (LetraIngresada.length === 0) return;

    if (LetraIngresada.length > 1) {
        ContadorIntentos++;
        if (LetraIngresada === palabra.toLowerCase()) {
            Adivinanza = palabra.split('');
            Gano = true;
            MostrarResultado(palabra, true);
            return;
        } else {
            MostrarResultado(palabra, false);
            return;
        }
    }

    if (LetraIngresada.length === 1) {
        if (IntentosLetras.includes(LetraIngresada)) {
            return;
        }
        IntentosLetras.push(LetraIngresada);
        ContadorIntentos++;

        let acerto = false;
        for (let j = 0; j < palabra.length; j++) {
            if (palabra[j].toLowerCase() === LetraIngresada) {
                Adivinanza[j] = palabra[j]; 
                acerto = true;
            }
        }

        document.getElementById("res").innerText = Adivinanza.join('');
        document.getElementById("contandor").innerText = ContadorIntentos;

        if (Adivinanza.join('').toLowerCase() === palabra.toLowerCase()) {
            Gano = true;
            MostrarResultado(palabra, true);
            return;
        }
    }
}

   function MostrarResultado(palabra, gano) {
        document.getElementById("res").innerText = palabra;
        if (gano) {
            document.getElementById("alert").innerText = "GANASTE AMIGO, BIEN AHI, EN " + ContadorIntentos + " INTENTOS";
            document.getElementById("ganador").style.display = "block"; // Mostrar botón solo si ganó
        } else {
            document.getElementById("alert").innerText = "PERDISTE BURRO EN " + ContadorIntentos + " INTENTOS";
        }
        document.getElementById("juego").style.display = "none";
    }
function SacarIntentos() {
    return ContadorIntentos;
}
function FinJuego() {
    var intentos = SacarIntentos();
    window.location.href = '/Home/FinJuego?intentos=' + intentos;
}