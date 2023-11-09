namespace ServicesLifetime.Services
{
    public class SingletonServices:ISingleton
    {
        private readonly Guid Id;

        public SingletonServices()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
