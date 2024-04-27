namespace EjemploInyeccionDependencias;
public class Notificador
{
    private readonly IServicioCorreo servicioCorreo;

    public Notificador(IServicioCorreo servicioCorreo)
    {
        this.servicioCorreo = servicioCorreo;
    }

    public void NotificarCliente(string destinatario, string mensaje)
    {
        servicioCorreo.EnviarCorreo(destinatario, mensaje);
    }
}
