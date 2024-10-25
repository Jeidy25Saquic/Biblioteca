using System;
using System.Reflection.Metadata.Ecma335;

public class Administracion
{
	LinkedList<Usuario> usuarios=new LinkedList<Usuario>();

    public bool Login(string username, string password)
    {  bool existe=false;
        foreach (Usuario usario in usuarios)
        {
			if(usario.Login(username, password))
			{
			 existe=true;
				break;
			}
        }

		return existe;
    }
  




    public bool VerificarUsuarios( string user)
	{
		bool existe=false;
		 foreach( var usuario in usuarios ) {

            if (usuario.UsuarioVerificar() == user)
			{
				existe = true;
				break;
			}


        }
		if (usuarios == null)
		{
            existe = false;
        }
		 return existe;
		

	}

	public void AgregarUsuario(Usuario usuario)
	{
		usuarios.AddLast(usuario);
	}
}
