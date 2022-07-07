
    
    
    //faz a requisição da URL que recebe as informações via Json e vai jogar cara informção dentro do seu respequitivo campo 
    // da pagina de cadastro
    function buscarCep(){
        //para pegar a irnformação do CEP digitado dentro do campo de preechimento
        let cep = document.getElementById('CEP').value;
        //condição para executar somente se o usuario tiver saido
        if(cep!==""){
            let url="https://brasilapi.com.br/api/cep/v1/"+cep;
           
            let req = new XMLHttpRequest();//objeto do JavaScript
               //aviso que a chamada é via Método GET que vai consumir a variavem url
                req.open("GET",url);
                //req.send- consome a requisição
                req.send();
                //agora o tratamento da resposta da requisição
                req.onload=function(){
                    //criado para saber se teve sucesso na requisição
                    if(req.status===200){
                        let endereco =JSON.parse(req.response);
                        document.getElementById("address").value= endereco.street;
                        document.getElementById("district").value= endereco.neighborhood;
                        document.getElementById("City").value= endereco.city;
                        document.getElementById("state").value= endereco.state;
                       


                    }
                    else if(req.status===404){
                        alert("CEP inválido");
                    }
                    else {
                        alert("Erro ao fazer a requisição");
                
                    }
                }
        }

    
     //criando o evento que preenche o campo ao sair do campo preenchido.
         window.onload=function(){
             let txtCep= document.getElementById("CEP");
             txtCep.addEventListener("blur",buscarCep);
         }
        
        }
   
        
        
       

  
