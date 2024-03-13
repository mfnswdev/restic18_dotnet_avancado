class EXE1
{
    static void Main(string[] args)
    {
        Lampada lamp1= new Lampada(true);
        lamp1.imprimir();
        lamp1.desligar();
        lamp1.ligar();
    }

    public class Lampada{
        public Lampada(bool ligada){
            this.ligada = ligada;
        }
        private bool ligada;

        public void ligar(){
            ligada = true;
            this.imprimir();
        }

        public void desligar(){
            ligada = false;
            this.imprimir();
        }

        public void imprimir(){
            if(ligada)
                console.log("Lampada Ligada");
            else
                console.log("Lampada Desligada");
        }
    }
}