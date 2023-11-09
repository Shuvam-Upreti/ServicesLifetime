namespace ServicesLifetime.Services
{
    public class ScopedServices : IScoped
    {
        private readonly Guid Id;

        public ScopedServices()
        {
                Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
