using classes;
namespace Delegates{
    class Delegados {
        delegate void Calculo(int v1, int v2);
        static void Main(string[] args)
        {
            Math m = new Math();
            
            Calculo conta = null;
            conta += m.Soma();
        }
    }
}