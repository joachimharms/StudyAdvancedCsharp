namespace _01_Interfaces_Playground
{
    public interface ISaeugetier : ILebewesen
    {
       // Eigenschaften
        int Alter{ get; set; }

        string Name{ get; set; }
       // Methoden
        void Trinken();

        void Fressen();
    }
}