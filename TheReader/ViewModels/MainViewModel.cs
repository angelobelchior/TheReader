namespace TheReader.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    
    
    public ObservableCollection<Grouping<Folder, Blog>> GroupedFolders { get; set; }

    public MainViewModel()
    {
        var folders = new List<Folder>();
        folders.Add(Folder.Create("Tech",
            Blog.Create(
                "https://dev.to/angelobelchior",
                "Angelo Belchior",
                "https://media2.dev.to/dynamic/image/width=90,height=90,fit=cover,gravity=auto,format=auto/https:%2F%2Fdev-to-uploads.s3.amazonaws.com%2Fuploads%2Fuser%2Fprofile_image%2F47320%2F55835eda-0aa6-48d3-878c-8e3b4fe77a7c.png",
                    Post.Create(
                        url: "https://dev.to/angelobelchior/reinventando-a-roda-criando-uma-rede-neural-com-csharp-3mg3",
                        image: "https://media2.dev.to/dynamic/image/width=1000,height=420,fit=cover,gravity=auto,format=auto/https%3A%2F%2Fdev-to-uploads.s3.amazonaws.com%2Fuploads%2Farticles%2Fripykrcya2s7zsx1da39.png",
                        title: "Reinventando a Roda: Criando uma Rede Neural com csharp", 
                        description: "Por que causa, motivo, razão ou circunstância um ser humano em sã consciência escreveria uma Rede Neural do Zero, sem o uso de bibliotecas de terceiros e usando csharp?\n\nEu gostaria de dar a você meu caro leitor, minha cara leitora, uma resposta mais embasada ou até mesmo poética. Mas o fato é que eu queria apenas me desafiar a construir algo que não faz parte do meu dia a dia e que me fizesse pensar, estudar. Redes Neurais, IA, Machine Learning, Deep Learning, etc... todas essas palavrinhas sempre me soaram como Mágica e hoje eu descobri que tudo isso não passa de Regex e um monte de ifs aninhados...", 
                        isRead: false, 
                        dateTime: DateTime.Now),
                
                    Post.Create(
                        url: "https://dev.to/angelobelchior/dica-rapida-rodando-o-deepseek-ou-qualquer-modelo-localmente-11ki",
                        image: "https://media2.dev.to/dynamic/image/width=800%2Cheight=%2Cfit=scale-down%2Cgravity=auto%2Cformat=auto/https%3A%2F%2Fdev-to-uploads.s3.amazonaws.com%2Fuploads%2Farticles%2Fv6syd6jqw6k4u4qbym9a.png",
                        title: "Dica rápida: Rodando o DeepSeek (ou qualquer modelo) localmente", 
                        description: "Hype é Hype.\n\nIsso é fato.\n\nMas confesso que fazia tempo que algo não me deixava tão empolgado quanto o Memphis Depay no Corinthians DeepSeek.", 
                        isRead: false, 
                        dateTime: DateTime.Now),
                
                    Post.Create(
                        url: "https://dev.to/angelobelchior/foreach-linkedisney-clovis-de-barros-filho-e-codigo-que-nao-funciona-433m",
                        image:"https://media2.dev.to/dynamic/image/width=800%2Cheight=%2Cfit=scale-down%2Cgravity=auto%2Cformat=auto/https%3A%2F%2Fdev-to-uploads.s3.amazonaws.com%2Fuploads%2Farticles%2Fkl1y6l06i7e2ef56fvmc.jpeg",
                        title: "Foreach, Linkedisney, Clóvis de Barros Filho e código que não funciona...", 
                        description: "Eu tenho sérias críticas em relação ao Linkedisney - nome carinhoso dado ao Linkedin. É uma rede social contaminada por coaches e gurus, onde todas as empresas são ótimas, todas as startups vão se tornar unicórnios e todos os códigos postados funcionam. É o mundo da fantasia pseudo-corporativo-quântica!", 
                        isRead: false, 
                        dateTime: DateTime.Now)
                ),
            Blog.Create(
                "https://elisaterumi.substack.com/",
                "Explorando a Inteligência Artificial",
                "https://substackcdn.com/image/fetch/w_256,c_limit,f_auto,q_auto:good,fl_progressive:steep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2F49760492-629c-471b-b040-aef757924103_500x500.png",
                Post.Create(
                    url: "https://elisaterumi.substack.com/p/redes-neurais-a-ia-inspirada-no-cerebro",
                    image: "https://substackcdn.com/image/fetch/f_auto,q_auto:good,fl_progressive:steep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2Fc033a3ce-b327-4784-a606-1cdf2e4f142a_1280x854.png",
                    title: "Redes Neurais: A IA Inspirada no Cérebro Humano", 
                    description: "Dando continuidade à nossa série sobre os Top 8 Algoritmos de Machine Learning, hoje vamos explorar o fascinante mundo das redes neurais!\n\nAs redes neurais artificiais são um dos pilares da inteligência artificial moderna. Inspiradas no funcionamento do cérebro humano, essas redes revolucionaram a maneira como os computadores aprendem e tomam decisões.", 
                    isRead: false, 
                    dateTime: DateTime.Now),
                
                Post.Create(
                    url: "https://elisaterumi.substack.com/p/deep-learning-entendendo-as-redes",
                    image: "https://substackcdn.com/image/fetch/f_auto,q_auto:good,fl_progressive:steep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2F1a01b2f2-e4b4-414f-9f44-7d540335358d_598x566.png",
                    title: "Deep Learning: Entendendo as Redes Neurais Profundas", 
                    description: "Semana passada, vimos como as redes neurais artificiais funcionam e como elas são inspiradas no funcionamento do cérebro humano.\n\nExploramos a estrutura básica de um neurônio artificial, discutimos os principais tipos de camadas e entendemos como ocorre o aprendizado por meio do ajuste dos pesos.", 
                    isRead: false, 
                    dateTime: DateTime.Now),
                
                Post.Create(
                    url: "https://elisaterumi.substack.com/p/k-nearest-neighbors-knn-simples-eficiente",
                    image: "https://substackcdn.com/image/fetch/f_auto,q_auto:good,fl_progressive:steep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2F784e7d0b-8c88-477e-878a-6f91071e5b8e_332x295.png", 
                    title: "K-Nearest Neighbors (KNN): Simples, Eficiente e Versátil", 
                    description: "Continunado nossa série Top 8 Algoritmos de Machine Learning, hoje chegou a vez de vermos o algoritmo KNN !\n\nK-Nearest Neighbors (KNN), ou K-vizinhos mais próximos, é um dos métodos de machine learning mais simples e intuitivos, amplamente utilizado para classificação e regressão.", 
                    isRead: false, 
                    dateTime: DateTime.Now)
            )
        ));

        GroupedFolders = new ObservableCollection<Grouping<Folder, Blog>>(
            folders.Select(f => new Grouping<Folder, Blog>(f, f.Items))
        );
    }
}