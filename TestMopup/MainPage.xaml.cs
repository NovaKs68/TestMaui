namespace TestMopup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOpenModalClicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PushModalAsync(new SamplePage());
        }

        private void OnOpenPageClicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PushAsync(new SamplePage());
        }
    }

}
