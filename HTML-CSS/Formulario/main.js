document.getElementById('formulario').addEventListener('submit',function(event){

    event.preventDefault();

    
    document.getElementById('tbpessoas').classList.remove('d-none');
    
    console.log('Submetido');
    cadPessoa()
    })


    document.getElementById('firtname').addEventListener('focusout', gerarLogin)
    
    document.getElementById('lastname').addEventListener('focusout', gerarLogin)
    


   
   
function cadPessoa(){
    
   
    var tb= document.getElementById("tbpessoas")
    var qtdlinhas= tb.rows.length;
    var linha=tb.insertRow(qtdlinhas);
    var cellCodigo= linha.insertCell(0);
    var cellNome = linha.insertCell(1);
    var cellSobrenome= linha.insertCell(2);
    var cellEmail= linha.insertCell(3);
    var cellLogin= linha.insertCell(4);
    var cellGitHub= linha.insertCell(5);
    var cellNumber= linha.insertCell(6);
    var cellCep= linha.insertCell(7);
    var cellAddress= linha.insertCell(8);
    var cellNcasa= linha.insertCell(9);
    var cellComplement= linha.insertCell(10);
    var cellDistrict= linha.insertCell(11);
    var cellCity= linha.insertCell(12);
    var cellState= linha.insertCell(13);
    var cellPassword= linha.insertCell(14);


    
        cellCodigo.innerHTML=qtdlinhas
         cellNome.innerHTML=document.getElementById('firtname').value;
         cellSobrenome.innerHTML=document.getElementById('lastname').value;
         cellEmail.innerHTML=document.getElementById('email').value;
         cellLogin.innerHTML=document.getElementById('login').value;
         cellGitHub.innerHTML=document.getElementById('GitHub').value;
         cellNumber.innerHTML=document.getElementById('number').value;
         cellCep.innerHTML=document.getElementById('cep').value;
         cellAddress.innerHTML=document.getElementById('address').value;
         cellNcasa.innerHTML=document.getElementById('ncasa').value;
         cellComplement.innerHTML=document.getElementById('complement').value;
         cellDistrict.innerHTML=document.getElementById('district').value;
         cellCity.innerHTML=document.getElementById('City').value;
         cellState.innerHTML=document.getElementById('state').value;
         cellPassword.innerHTML=document.getElementById('password').value;

}


    
    function gerarLogin(){
    
        const nome = document.getElementById('firtname').value;
    
        const sobrenome = document.getElementById('lastname').value;
       
       

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
          
           if (document.getElementById('cep').value==''){
            alert('Preencha os campos') ;
            document.getElementById('cep').focus()
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

           document.getElementById('termos').checked = false;
           x = document.getElementsByName('informacao');
           x[0].checked = true;
       
                  
    
           return true;


           
     }

    