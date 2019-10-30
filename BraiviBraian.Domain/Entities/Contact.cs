namespace BraviBraian.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int IdContactType { get; set; }

        public ContactType ContactType { get; set; }

        public int IdPerson { get; set; }

        public virtual Person Person { get; set; }
    }
}