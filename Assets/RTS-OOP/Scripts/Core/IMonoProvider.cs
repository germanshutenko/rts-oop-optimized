namespace RtsOop
{
    public interface IMonoProvider
    {
        void Add(IUpdatable updatable);
        void Remove(IUpdatable updatable);
    }
}