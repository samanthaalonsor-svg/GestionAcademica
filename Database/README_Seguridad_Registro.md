# Registro de usuarios y seguridad

## Qué se agregó
- Botón **Crear cuenta nueva** en el inicio de sesión.
- Formulario para nombre completo, usuario, contraseña y confirmación.
- Validación de nombre de usuario (4–50 caracteres: letras, números, punto, guion y guion bajo).
- Contraseña mínima de 10 caracteres con letras y números.
- Los usuarios duplicados se rechazan también mediante la restricción `UNIQUE` de SQL Server.
- Las consultas usan parámetros SQL; los datos escritos se tratan como valores, no como instrucciones.
- Las contraseñas de las cuentas nuevas se guardan con PBKDF2, sal aleatoria e iteraciones, no en texto plano. Se conserva compatibilidad con el usuario inicial antiguo `UNI` mientras siga usando SHA-256.

## Antes de ejecutar la versión modificada
1. Abrir SQL Server Management Studio y conectarse a la instancia configurada en `DataAccess/Conexion.cs`.
2. Seleccionar/ejecutar `Database/Actualizar_Seguridad_Usuarios.sql` una vez. Este script amplía `ContrasenaHash` a `NVARCHAR(256)` sin borrar los usuarios existentes.
3. Ejecutar la aplicación desde Visual Studio.
4. En la pantalla de inicio de sesión, pulsar **Crear cuenta nueva**.

Si se instala la base desde cero, se puede usar `Database/Script_Instalacion_Completo.sql`, que ya incluye la columna ampliada y la migración compatible.

## Nota sobre SQL injection
La parametrización evita que el texto de un campo se interprete como SQL. No se debe confiar solo en bloquear palabras como `SELECT`, `DROP` o comillas. Las operaciones CRUD existentes usan procedimientos almacenados con parámetros; las eliminaciones adicionales en `EstudiantesDAO` usan consultas fijas y parámetros. No se puede garantizar que un sistema sea absolutamente invulnerable, por lo que también se recomienda que la cuenta SQL de la aplicación tenga únicamente los permisos necesarios y no permisos de administrador.
