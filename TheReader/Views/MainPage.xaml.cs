namespace TheReader.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel mainViewModel)
    {
        InitializeComponent();

        BindingContext = mainViewModel;
    }

    private void SelectableItemsView_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (foldersCollectionView.SelectedItem is not Blog blog) return;
        postsCollectionView.ItemsSource = blog.Posts;
    }

    private void PostsCollectionView_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if(postsCollectionView.SelectedItem is not Post post) return;
        
        webView.Source = new Uri(post.Url);
        webView.IsVisible = true;
    }
}