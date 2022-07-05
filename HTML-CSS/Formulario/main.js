document.getElementById('formulario').addEventListener('submit',function(event){

    event.preventDefault();
    
    document.getElementById('tabela-dados').classList.remove('d-none');
    
    console.log('Submetido');
    
    })
    
    
    
    document.getElementById('firtname').addEventListener('focusout', gerarLogin)
    
    document.getElementById('lastname').addEventListener('focusout', gerarLogin)

    document.getElementById('email').addEventListener('focusout', gerarLogin)

    
    
    
    function gerarLogin(){
    
        const nome = document.getElementById('firtname').value;
    
        const sobrenome = document.getElementById('lastname').value;

        const email = document.getElementById('email').value;

        let dominio= "@atos.com.br"

        const login = nome + '.' + sobrenome+ '' +dominio;
    
        document.getElementById('login').value = login.toLowerCase();
    
    
    
    }
    function acao(){
        let modal=document.querySelector('.modal')
        modal.style.display= 'block';
    }
    function fechar(){
        let modal=document.querySelector('.modal')
        modal.style.display= 'none';

    }