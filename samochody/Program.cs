namespace samochody
{
    public class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Rocznik { get; set; }

        public void Informacje()
        {
            Console.WriteLine($"Samochód: {Marka} {Model}, Rocznik: {Rocznik}");
        }
    }
}
