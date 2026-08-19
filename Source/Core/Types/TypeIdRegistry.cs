public static class TypeIdRegistry<T>
{
    private int _count;
    public int Count = Volatile.Read(_count);
    public static class For<IEntity>
    {
        public int Id { get; } = Interlocked.Increment(_count);
    }
}
