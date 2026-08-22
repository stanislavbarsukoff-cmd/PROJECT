public static class ArrayExtensions {
    public static bool TryGetValue<T>(this T[] array, int index, out T value) {
        if (index >= 0 && index < array.Length) {
            value = array[index];
            return value is not null;
        }
        value = default;
        return false;
    }

    public static bool Try<T>(this T[] array, int index)
        => index >= 0 && index < array.Length && array[index] is not null;
}
