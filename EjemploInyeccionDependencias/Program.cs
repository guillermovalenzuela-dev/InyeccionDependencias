
using EjemploInyeccionDependencias;
using Microsoft.Extensions.DependencyInjection;

// Creamos una instancia del notificador
IServicioCorreo servicioCorreo = new ServicioCorreo();

Notificador notificador = new Notificador(servicioCorreo);

// Usamos el notificador para enviar un correo
notificador.NotificarCliente("ejemplo@correo.com", "¡Hola! Este es un mensaje de prueba.");

