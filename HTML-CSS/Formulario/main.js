document.getElementById('formulario').addEventListener("submit",function(event){

    event.preventDefault();

    
    document.getElementById('tabela-dados').classList.remove('d-none');
    
    console.log('Submetido');
    
    })
    
    
    
    document.getElementById('firtname').addEventListener('focusout', gerarLogin)
    
    document.getElementById('lastname').addEventListener('focusout', gerarLogin)

    document.getElementById('email').addEventListener('focusout', gerarLogin)

    document.getElementById('firtname').addEventListener('focusoutee', valida)
    document.getElementById('lastname').addEventListener('focusoutee', valida)
    document.getElementById('email').addEventListener('focusoutee', valida)
    document.getElementById('login').addEventListener('focusoutee', valida)
    document.getElementById('GitHub').addEventListener('focusoutee', valida)
    document.getElementById('number').addEventListener('focusoutee', valida)
    document.getElementById('CEP').addEventListener('focusoutee', valida)
    document.getElementById('address').addEventListener('focusoutee', valida)
    document.getElementById('n-casa').addEventListener('focusoutee', valida)
    document.getElementById('complement').addEventListener('focusoutee', valida)
    document.getElementById('district').addEventListener('focusoutee', valida)
    document.getElementById('City').addEventListener('focusoutee', valida)
    document.getElementById('password').addEventListener('focusoutee', valida)
    document.getElementById('Confirpassword').addEventListener('focusoutee', valida)
    document.getElementById('state').addEventListener('focusoutee', valida)
  

    
    
    
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
    
    function valida(){
        if (document.getElementById('firtname').value==''){
          alert('Preencha os campos') ;
          document.getElementById('firtname').focus()
          return false;
         }
        
         if (document.getElementById('lastname').value==''){
            alert('Preencha os campos') ;
            document.getElementById('lastname').focus()
            return false;
           }
           
           if (document.getElementById('email').value==''){
            alert('Preencha os campos') ;
            document.getElementById('email').focus()
            return false;
           }
           
           if (document.getElementById('login').value==''){
            alert('Preencha os campos') ;
            document.getElementById('login').focus()
            return false;
           }
           
           if (document.getElementById('GitHub').value==''){
            alert('Preencha os campos') ;
            document.getElementById('GitHub').focus()
            return false;
           }
          
           if (document.getElementById('number').value==''){
            alert('Preencha os campos') ;
            document.getElementById('number').focus()
            return false;
           }
          
           if (document.getElementById('CEP').value==''){
            alert('Preencha os campos') ;
            document.getElementById('CEP').focus()
            return false;
           }
           
           if (document.getElementById('address').value==''){
            alert('Preencha os campos') ;
            document.getElementById('address').focus()
            return false;
           }
          
           if (document.getElementById('n-casa').value==''){
            alert('Preencha os campos') ;
            document.getElementById('n-casa').focus()
            return false;
           }
           
           if (document.getElementById('complement').value==''){
            alert('Preencha os campos') ;
            document.getElementById('complement').focus()
            return false;
           }

           if (document.getElementById('district').value==''){
            alert('Preencha os campos') ;
            document.getElementById('district').focus()
            return false;
           }

           if (document.getElementById('City').value==''){
            alert('Preencha os campos') ;
            document.getElementById('City').focus()
            return false;
           }

           if (document.getElementById('password').value==''){
            alert('Preencha os campos') ;
            document.getElementById('password').focus()
            return false;
           }

           if (document.getElementById('Confirpassword').value==''){
            alert('Preencha os campos') ;
            document.getElementById('Confirpassword').focus()
            return false;
           }

           if (document.getElementById('state').value==''){
            alert('Preencha os campos') ;
            document.getElementById('state').focus()
            return false;
           }

           return true;
     }

    