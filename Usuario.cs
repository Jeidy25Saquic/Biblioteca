using System;

public class Usuario
{
	private string User; 
	private string Nombre;
	private string Contraseña;
    private string Rol;

    public Usuario(string user, string nombre, string contraseña, string rol)
    {
        User = user;
        Nombre = nombre;
        Contraseña = contraseña;
        Rol = rol;
    }

    public  string UsuarioVerificar()
    {
        return User;
    }
    public Usuario()
	{
	}
}
