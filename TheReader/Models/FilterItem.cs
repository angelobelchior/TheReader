namespace TheReader.Models;

public partial class FilterItem : ObservableObject
{
    public string Title { get; set; } = string.Empty;
    
    public ObservableCollection<Post> Posts { get; set; } = [];
    
    [ObservableProperty] private int _count;

    public FilterItem()
    {
    }

    public FilterItem(string title, params IEnumerable<Post> posts)
    {
        Title = title;
        Posts = new ObservableCollection<Post>(posts);
        Count = Posts.Count;
    }
}