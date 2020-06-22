namespace Aula22Static
{
    //e preciso colocar o static em todos os metodos e atributos
    public static class Conversor
    {
        public static float CotacaoDolar = 5.24f;
        public static float CotacaoEuro = 5.87f;


        public static float ConverterRealparaDolar(float ValorRS ){
            return ValorRS / CotacaoDolar;
        }
        public static float ConverterDolarparaReal(float ValorUS){
            return CotacaoDolar * ValorUS;
        }
        public static float ConverterRealparaEuro(float ValorRS){
            return ValorRS / CotacaoEuro;
        }
        public static float ConverterEuroparaReal(float ValorEUR){
            return CotacaoEuro * ValorEUR;
        }
    //static - modificador de acesso

    }
}