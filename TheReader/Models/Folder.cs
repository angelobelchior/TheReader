namespace TheReader.Models;

public partial class Folder : ObservableObject
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    [ObservableProperty] private int _count;

    public ObservableCollection<Blog> Blogs { get; set; } = [];

    public static Folder Create(string folderName, params Blog[] blogs)
    {
        var folder = new Folder
        {
            Id = Guid.NewGuid(),
            Name = folderName,
            Count = blogs.Sum(i => i.Count),
            Blogs = new ObservableCollection<Blog>(blogs)
        };

        return folder;
    }
}