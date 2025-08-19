namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");

        public MainPage()
        {
            InitializeComponent();
        }
       
        private void Edit_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Edit_Completed(object sender, EventArgs e)
        {

        }

        private void SalvarBtn_Clicked(object sender, EventArgs e)
        {
            string conteudo = Edit.Text;
            File.WriteAllText(caminho, conteudo);
        }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}
