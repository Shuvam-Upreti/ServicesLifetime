namespace ServicesLifetime.Services
{
    public class TransientServices:ITransient
    {
        private readonly Guid Id;

        public TransientServices()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
