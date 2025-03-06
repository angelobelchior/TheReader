using CommunityToolkit.Maui.Views;

namespace TheReader.Views;

public partial class MainPage
{
    public MainPage(MainViewModel mainViewModel)
    {
        InitializeComponent();

        BindingContext = mainViewModel;
    }

    private void FiltersCollectionView_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (filtersCollectionView.SelectedItem is not FilterItem filterItem) return;
        
        foldersCollectionView.SelectedItem = null;
        postsCollectionView.SelectedItem = null;

        SetPosts(filterItem.Posts);
    }

    private void FoldersCollectionView_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (foldersCollectionView.SelectedItem is not Blog blog) return;

        filtersCollectionView.SelectedItem = null;
        postsCollectionView.SelectedItem = null;

        SetPosts(blog.Posts);
    }

    private void PostsCollectionView_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (postsCollectionView.SelectedItem is not Post post) return;

        webView.Source = new UrlWebViewSource
        {
            Url = post.Url
        };
        webView.IsVisible = true;
    }

    private void SetPosts(ObservableCollection<Post> posts)
    {
        postsCollectionView.ItemsSource = posts;
        postsCollectionView.SelectedItem = posts.FirstOrDefault();
    }

    protected override void OnAppearing()
    {
        var filters = (BindingContext as MainViewModel)?.Filters;
        filtersCollectionView.SelectedItem = filters?.FirstOrDefault();
        
        base.OnAppearing();
    }

    // private async void Button_OnClicked(object? sender, EventArgs e)
    // {
    //     var foldersControl = new Controls.FoldersControl();
    //     var result = await this.ShowPopupAsync(foldersControl, CancellationToken.None);
    //
    //     if (result is bool boolResult)
    //     {
    //         if (boolResult)
    //         {
    //             // Yes was tapped
    //         }
    //         else
    //         {
    //             // No was tapped
    //         }
    //     }
    // }
}