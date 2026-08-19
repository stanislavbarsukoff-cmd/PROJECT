public static class TypeIdRegistry<TTag>
{
    private static int _count;
    public static int Count = Volatile.Read(_count);
    public static class For<TEntity>
    {
        public static int Id { get; } = Interlocked.Increment(_count);
    }
}
