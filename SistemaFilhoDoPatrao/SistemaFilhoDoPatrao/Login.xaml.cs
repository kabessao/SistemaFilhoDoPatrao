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

        List<Usuario> Usuarios = Usuario.GerarUsuarios();
        public Login()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            txtNome.Completed += (s, e) => txtSenha.Focus();
            txtSenha.Completed += Logar;
        }

        private void Logar(object sender, EventArgs e)
        {
            if (Usuarios.Any(x => x.Nome.Equals(txtNome.Text) && x.Senha.Equals(txtSenha.Text)))
                DisplayAlert("", "Logado com sucesso!", "Ok");
            else
                DisplayAlert("Erro", "Usuario ou senha incoretos!", "Ok");
        }
    }
}
