namespace _01_Interfaces_Playground
{
    public interface ILebewesen
    {
        // Eigenschaften
        double Groesse { get; set; }

        double Gewicht { get; set; }

        // Methoden
        void Ausscheiden();
    }
}