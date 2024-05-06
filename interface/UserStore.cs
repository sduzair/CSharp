namespace csharpinterface
{
    internal class UserStore : IUserStore
    {
        public bool AutoSaveChanges { get; set; } = true;
    }
}
