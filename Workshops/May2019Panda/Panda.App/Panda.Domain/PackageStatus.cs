namespace Panda.Domain
{
    using System;

    public class PackageStatus
    {
        public PackageStatus()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string Name { get; set; }
    }
}