using System;

public class Administracion
{
	LinkedList<Usuario> usuarios=new LinkedList<Usuario>();


    public bool Login(string username, string password)
    {
        
        return username == "admin" && password == "password"; 
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
		usuarios.AddFirst(usuario);
	}
}
