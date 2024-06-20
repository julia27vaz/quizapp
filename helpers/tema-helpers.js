let tema = "claro"

export function trocarTema (body, botaoTema){
    if(localStorage.getItem("tema")){
        tema = localStorage.getItem("tema")
    }

    if(tema == "claro"){
        body.classList.add("dark")
        localStorage.setItem("tema", "dark")
        botaoTema.style.justifyContent = "flex-end"
    } else {
        body.classList.remove("dark")
        localStorage.setItem("tema", "claro")
        botaoTema.style.justifyContent = "flex-start"
    }
}

export function verificarTema(body, botaoTema){
    if(localStorage.getItem("tema")){
        tema = localStorage.getItem("tema")
    }

    if(tema === "dark"){
        body.classList.add("dark")
        botaoTema.style.justifyContent = "flex-end"
    }
}