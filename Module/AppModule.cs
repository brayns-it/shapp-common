namespace Brayns.Common.Module
{
    [Shaper.Classes.AppModule]
    public class AppModule : Shaper.Classes.AppModule
    {
        private Brayns.System.Upgrades upgrades = new();

        public override string Author => "Brayns";
        public override string Name => "Common";
        public override Version Version => new Version("1.0.30901.0");
        public override Guid Id => new Guid("{8102E373-66C3-4C89-9FD3-0B3E63BC2BA2}");

        public override void Install()
        {
        }
    }
}
