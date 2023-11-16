namespace samochody
{
    public class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public bool czyPowypadkowy { get; set; }

        public void Informacje()
        {
            Console.WriteLine($"Samochód: {Marka} {Model}, Rocznik: {Rocznik}");
            if (czyPowypadkowy) { Console.WriteLine("Uwaga! Samochoód powypadkowy");  }
        }
        public void Zatrab()
        {
            Console.WriteLine("Beep! Beep!");
        }
    }
}
