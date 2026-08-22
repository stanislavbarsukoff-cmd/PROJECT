public static class ArrayExtensions {
    public static bool TryOrGet<T>(this T[] array, int index, out T value) {
        if (index >= 0 && index < array.Length) {
            value = array[index];
            return value is not null;
        }
        value = default;
        return false;
    }
}
