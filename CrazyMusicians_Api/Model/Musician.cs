namespace CrazyMusicians_Api.Models
{
    public class Musician
    {
        public int Id { get; set; }         // Müzisyenin benzersiz kimliği
        public string Name { get; set; }    // Müzisyenin adı
        public string Profession { get; set; } // Mesleği
        public string FunnyFeature { get; set; } // Eğlenceli özelliği

        //Ezberi kuvvetlendirmek için ekliyorum.
    }
}
