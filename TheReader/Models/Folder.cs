namespace TheReader.Models;

public partial class Folder : ObservableObject
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    [ObservableProperty] private int _count;

    public ObservableCollection<Blog> Items { get; set; } = [];

    public static Folder Create(string folderName, params Blog[] items)
    {
        var folder = new Folder
        {
            Id = Guid.NewGuid(),
            Name = folderName,
            Count = items.Sum(i => i.Count),
            Items = new ObservableCollection<Blog>(items)
        };

        return folder;
    }
}