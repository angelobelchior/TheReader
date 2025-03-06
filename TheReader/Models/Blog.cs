namespace TheReader.Models;

public partial class Blog : ObservableObject
{
    public Guid Id { get; set; }

    public string Url { get; set; } = string.Empty;
    public string Feed { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;

    [ObservableProperty] private int _count;

    public ObservableCollection<Post> Posts { get; set; } = [];

    public static Blog Create(string url, string feed, string title, string icon, params Post[] posts)
    {
        Blog blog = new()
        {
            Id = Guid.NewGuid(),
            Url = url,
            Feed = feed,
            Title = title,
            Icon = icon,
            Count = posts.Length,
            Posts = new ObservableCollection<Post>(posts)
        };

        foreach (var post in posts)
            post.Blog = blog;

        return blog;
    }
}