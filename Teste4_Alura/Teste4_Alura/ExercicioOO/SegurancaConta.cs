namespace Teste4_Alura.ExercicioOO;

internal class SegurancaConta
{

    public bool ValidarSaque(double valor)
    {

        if (valor > 1000)
        {
            return false;

        }
        else 
        {
            return true;
        }
        
        
    }
}
