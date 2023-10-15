namespace PBKK_7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       
        void OnSayHelloClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            if (!string.IsNullOrWhiteSpace(name))
            {
                NamaMuncul.Text = $"Hello!,Anda {name}";
            }
        }
    }
}