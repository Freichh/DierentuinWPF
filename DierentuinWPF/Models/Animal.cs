namespace DierentuinWPF.Models
{
    class Animal
    {

        public string Name { get; set; }
        public int Energy { get; set; } = 100;

        public Animal()
        {

        }

        public void Eat()
        {
            this.Energy += 25;
        }
    }


}
