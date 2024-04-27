namespace EjemploInyeccionDependencias;
public class ServicioCorreo : IServicioCorreo
{
    public void EnviarCorreo(string destinatario, string mensaje)
    {
        Console.WriteLine($"Enviando correo a {destinatario}: {mensaje}");
    }
}
