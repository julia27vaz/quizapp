*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: "Rubik", sans-serif;
}

:root{
    --bg-color: #f4f6fa;
    --primary-text-color: #313e51;
    --secondery-text-color: #626c7f;
    --purple: #a729f5;
    --bg-button: #fff;
    --white: #fff;
    --green: #26d782;
    --red: #ee5454;
    --shadow: 0px 16px 40px 0px rgba(143, 168, 193, 0.14);
    --bg-html: #fff1e9;
    --bg-css: #e0fdef;
    --bg-js: #ebf0ff;
    --bg-acessibilidade: #f6e7ff;
    --bg-mobile: url(../../assets/images/pattern-background-mobile-light.svg);
    --bg-desktop: url(../../assets/images/pattern-background-desktop-light.svg);
}

body.dark{
    --bg-color: #313e51;
    --bg-mobile: url(../../assets/images/pattern-background-mobile-dark.svg);
    --bg-desktop: url(../../assets/images/pattern-background-desktop-dark.svg);
    --primary-text-color: #fff;
    --secondery-text-color: #abc1e1;
    --bg-button: #3b4d66;
    --shadow: 0px 16px 40px 0px rgba(49, 62, 81, 0.14);
}

body{
    height: 100svh;
    background: var(--bg-mobile) var(--bg-color);
    background-repeat: no-repeat;
    background-size: cover;
}


header{
    display: flex;
    justify-content: space-between;
    padding: 16px 24px;
}

.assunto{
    display: flex;
    align-items: center;
    gap: 16px;
}

.assuntoIcone{
    background: var(--bg-acessibilidade);
    padding: 5px;
    width: 40px;
    height: 40px;
    border-radius: 5px;
}

.assuntoIcone img{
    width: 100%;
}

.assunto h1{
    font-size: 18px;
    font-weight: 500;
    color: var(--primary-text-color);
}

.tema{
    padding: 8px 0px;
    display: flex;
    align-items: center;
    gap: 8px;
}

.tema img{
    width: 16px;
}

.tema button{
    height: 20px;
    width: 32px;
    background: var(--purple);
    border: 0;
    border-radius: 999px;
    padding: 4px;
}

.tema button div{
    background: var(--white);
    height: 12px;
    width: 12px;
    border-radius: 999px;
}


main{
    padding: 16px 24px;
}

.pergunta{
    margin-bottom: 40px;
}

.pergunta p{
    font-style: italic;
    font-size: 14px;
    color: var(--secondery-text-color);
    margin-bottom: 12px;
}

.pergunta h2{
    font-size: 20px;
    font-weight: 500;
    color: var(--primary-text-color);
    line-height: 24px;
    margin-bottom: 24px;
}

.barraProgresso{
    background: var(--bg-button);
    height: 16px;
    padding: 4px;
    border-radius: 999px;
}

.barraProgresso div{
    height: 100%;
    width: 60%;
    background: var(--purple);
    border-radius: 999px;
}

.alternativas form{
    display: flex;
    flex-direction: column;
    gap: 12px;
    margin-bottom: 12px;
}

.alternativas label{
    display: block;
    background: var(--bg-button);
    padding: 12px;
    font-size: 18px;
    font-weight: 500;
    border-radius: 12px;
    box-shadow: var(--shadow);
    color: var(--primary-text-color);
}

.alternativas label:has(input:checked){
  outline: 3px solid var(--purple);

    & span{
        background: var(--purple);
        color: var(--white);
    }
}

.alternativas input{
    display: none;
}

.alternativas div{
    display: flex;
    align-items: center;
    gap: 16px;
}

.alternativas div span{
    display: block;
    width: 40px;
    height: 40px;
    background: var(--bg-color);
    border-radius: 5px;
    color: var(--secondery-text-color);

    display: flex;
    flex-shrink: 0;
    align-items: center;
    justify-content: center;
}

.alternativas button{
    padding: 16px;
    border-radius: 12px;
    border: none;
    background: var(--purple);
    color: var(--white);
    width: 100%;
    font-size: 18px;
    font-weight: 500;
}

@media(min-width: 1100px){
   
    .tema{
        gap: 16px;
    }

    .tema img{
        width: 24px;
    }

    .tema button{
        width: 48px;
        height: 28px;
    }

    .tema button div{
        width: 20px;
        height: 20px;
    }
}