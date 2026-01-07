namespace Teste4_Alura.PetShop;

internal class Dono
{

    public Dono(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; set; }
    public List<Pet> Pets = new List<Pet>();

    public void AdotarPet(Pet pet)
    {
        Pets.Add(pet);
        pet.DonoPet = this;
    }

    public void TodosPets()
    {
        foreach (Pet pet in Pets)
        {
            Console.WriteLine(pet.Nome);
        }
    }
}
