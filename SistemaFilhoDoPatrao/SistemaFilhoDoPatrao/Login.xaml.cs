using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SistemaFilhoDoPatrao
{
    public partial class Login : ContentPage
    {


        internal static Usuario UsuarioLogado { get; private set; }

        private List<Usuario> Usuarios = Usuario.GerarUsuarios();

        

        public Login()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            if (String.IsNullOrWhiteSpace(txtNome.Text))
                txtNome.Focus();

            txtNome.Completed += (s, e) => txtSenha.Focus();
            txtSenha.Completed += Logar;
        }

        private void Logar(object sender, EventArgs e)
        {
            if (Usuarios.Any(x => x.Nome.Equals(txtNome.Text) && x.Senha.Equals(txtSenha.Text)))
                Confirmar();
            else
                DisplayAlert("Erro", "Usuario ou senha incoretos!", "Ok");
        }

        private async void Confirmar()
        {
            await DisplayAlert("Sucesso", "Logado com sucesso!", "Ok");
            UsuarioLogado = Usuarios.Where(x => x.Nome.Equals(txtNome.Text) && x.Senha.Equals(txtSenha.Text)).First();
            App.Current.MainPage = new NavigationPage(new Menu());
        }
    }
}
