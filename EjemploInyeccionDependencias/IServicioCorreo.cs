namespace EjemploInyeccionDependencias
{
    public interface IServicioCorreo
    {
        void EnviarCorreo(string destinatario, string mensaje);
    }
}