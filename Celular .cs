namespace CelularPOO
{
    public class celular
    {
        public string cor;
        public string modelo;
        public int tamanho;
        public bool ligado;
        public string Ligar(){
            if(ligado){
                return "Celular ligado.";
            }
            else{
                return "-----------------";
            }
                      
        }  
        public string FazerLigacao(){
            if(!ligado){
                return "Não é possivel ligar com o celular desligado, ligue ele primeiro.";
            }
            else{
                return "Ligando para seu contato";
            }
        }
        public string EnviarMensagem(){
            if(ligado){
            return "Mensagem enviada";
            }
            else{
                return "Não é possivel enviar mensagem com o celular desligado, ligue ele primeiro.";
            }
        }
        public string Desligar(){
            if(ligado)
            {
                return "Desligando Celular";
            }
            else{
                return "Não é possivel completar essa ação celular ja esta desligado.";
            }
        }    
    }
}