namespace TheReader;

public class Grouping<TKey, TItem>(TKey key, IEnumerable<TItem> items)
    : ObservableCollection<TItem>(items)
{
    public TKey Key { get; private set; } = key;
}