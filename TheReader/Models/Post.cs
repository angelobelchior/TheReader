namespace TheReader.Models;

public partial class Post : ObservableObject
{
    public Guid Id { get; set; }

    public string Url { get; set; } = string.Empty;
    public Blog Blog { get; set; } = null!;
    public string Image { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    [ObservableProperty] private bool _isRead;

    public DateTime DateTime { get; set; }

    public static Post Create(
        string url,
        string image,
        string title,
        string description,
        bool isRead,
        DateTime dateTime)
        => new()
        {
            Id = Guid.NewGuid(),
            Url = url,
            Image = image,
            Title = title,
            Description = description,
            IsRead = isRead,
            DateTime = dateTime
        };
}