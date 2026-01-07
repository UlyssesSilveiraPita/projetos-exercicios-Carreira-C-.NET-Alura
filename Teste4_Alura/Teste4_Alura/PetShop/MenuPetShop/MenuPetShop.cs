using menuPetShop = Teste4_Alura.PetShop.MenuPetShop;
using pets = Teste4_Alura.PetShop;

namespace Teste4_Alura.PetShop.MenuPetShop;


internal class MenuPetShop
{


    public void ExibirMenu(string titulo)
    {
        int _quantidadeLetras = titulo.Length;
        string asteristico = string.Empty.PadLeft(_quantidadeLetras, '*');
        Console.WriteLine(asteristico);
        Console.WriteLine(titulo);
        Console.WriteLine(asteristico + "\n");


    }

}
