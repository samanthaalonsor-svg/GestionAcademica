# API REST de notificaciones por correo (Resend)

Se agregó una pestaña **Notificaciones por correo** al formulario de Servicios web. Desde ella se puede enviar un mensaje académico a una dirección ingresada por el operador usando `POST https://api.resend.com/emails`.

## Configuración requerida

1. Crear una cuenta en https://resend.com/ y generar una API key de envío.
2. Configurar una variable de entorno de Windows llamada `RESEND_API_KEY` con la clave. No pegar la clave en el código ni subirla a GitHub.
3. Opcionalmente configurar `RESEND_FROM_EMAIL` con una dirección remitente válida de un dominio verificado en Resend.
4. Cerrar y volver a abrir Visual Studio después de configurar las variables de entorno, para que la aplicación las reciba.
5. Ejecutar el sistema, abrir **Servicios web > Notificaciones por correo**, completar destinatario, estudiante, asunto y mensaje, y pulsar **Enviar notificación**.

Para una prueba inicial, Resend permite usar `onboarding@resend.dev` como remitente en su modo de prueba, sujeto a las restricciones vigentes de la cuenta. Para enviar a otros destinatarios en producción normalmente se debe verificar un dominio y configurar `RESEND_FROM_EMAIL` con una dirección de ese dominio. Consultar la documentación oficial: https://resend.com/docs/send-with-dotnet y https://resend.com/docs/api-reference/emails/send-email.

## Seguridad y alcance

- La clave API se lee desde variables de entorno; no se incluye en el repositorio.
- Se valida la dirección de correo y se limita la longitud de los campos.
- El texto se codifica para HTML antes de incorporarse al cuerpo del mensaje.
- El formulario envía notificaciones manuales. No se envían automáticamente al guardar una evaluación porque el esquema actual de estudiantes no contiene una dirección de correo asociada a cada estudiante. Para automatizarlo, primero habría que añadir el correo al modelo/formulario de estudiantes y a la base de datos, y luego invocar el servicio después de guardar la evaluación.
- Un `200` de la API significa que el proveedor aceptó la solicitud; no garantiza entrega en bandeja de entrada.
