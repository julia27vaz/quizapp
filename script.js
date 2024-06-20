let tema = "claro"

const botaoTema = document.querySelector(".tema button")
botaoTema.addEventListener("click", trocarTema);

const body = document.querySelector("body")

function trocarTema (){
    if(localStorage.getItem("tema")){
        tema = localStorage.getItem("tema")
    }

    if(tema == "claro"){
        body.classList.add("dark")
        localStorage.setItem("tema", "dark")
    } else {
        body.classList.remove("dark")
        localStorage.setItem("tema", "claro")
    }
}

function verificarTema(){
    if(localStorage.getItem("tema")){
        tema = localStorage.getItem("tema")
    }

    if(tema === "dark"){
        body.classList.add("dark") 
    }
}

verificarTema()