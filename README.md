# 💼 Portafolio Web

Landing page de portafolio personal construida con **ASP.NET Core MVC** y **Razor**. Sirve para presentar perfil, habilidades, proyectos y un formulario de contacto. El código está pensado para que puedas **clonarlo, ejecutarlo en local y personalizarlo** (contenido, estilos y datos de proyectos).

---

## 📖 Descripción

La aplicación ofrece:

- **Inicio** con presentación, habilidades y un extracto de proyectos.
- **Listado de proyectos** con datos provenientes de un repositorio en memoria (`RepositorioProyectos`).
- **Contacto** con envío por correo (SMTP, orientado a Gmail) y página de agradecimiento.

Arquitectura clásica **MVC**: controladores, vistas Razor, modelos y servicios inyectados por DI.

---

## 🛠️ Tecnologías

| Área | Tecnología |
|------|------------|
| Runtime / framework | [.NET](https://dotnet.microsoft.com/) 10 (`net10.0`) |
| Web | ASP.NET Core MVC, Razor Views |
| Frontend | [Bootstrap](https://getbootstrap.com/), [jQuery](https://jquery.com/), validación unobtrusive |
| Correo | `System.Net.Mail` (SMTP) |
| Configuración local | [User Secrets](https://learn.microsoft.com/aspnet/core/security/app-secrets) (recomendado para credenciales) |

---

## 📁 Estructura del proyecto

```
PortafolioWeb/
├── PortafolioWeb.slnx          # Solución
├── Portafolio/
│   ├── Controllers/            # HomeController (rutas MVC)
│   ├── Models/                 # ViewModels y entidades (Persona, Proyecto, etc.)
│   ├── Servicios/              # RepositorioProyectos, ServicioEmailGmail
│   ├── Views/                  # Vistas Razor y layout compartido
│   ├── wwwroot/                # CSS, JS, librerías estáticas (Bootstrap, jQuery)
│   ├── Program.cs              # Pipeline y registro de servicios
│   ├── appsettings.json
│   └── Properties/launchSettings.json
├── LICENSE
└── README.md
```

---

## 🚀 Uso en local

### Requisitos

- [SDK de .NET 10](https://dotnet.microsoft.com/download) o superior compatible con el proyecto.

### Pasos

1. Clona el repositorio (ver sección [Git](#-clonar-el-repositorio)).
2. Abre una terminal en la carpeta raíz del repo (`PortafolioWeb`).
3. Restaura y ejecuta:

```bash
dotnet restore
dotnet run --project Portafolio/Portafolio.csproj
```

4. Abre el navegador en la URL que indique la consola. Por defecto suele ser:

   - **HTTPS:** `https://localhost:7150`
   - **HTTP:** `http://localhost:5269`

*(Los puertos están definidos en `Portafolio/Properties/launchSettings.json`.)*

### Formulario de contacto (opcional)

El envío de correo lee la sección `CONFIGURACIONES_EMAIL` (email, contraseña de aplicación, host y puerto SMTP). **No subas secretos al repositorio.** En desarrollo, configura [User Secrets](https://learn.microsoft.com/aspnet/core/security/app-secrets) en el proyecto web, por ejemplo:

```bash
cd Portafolio
dotnet user-secrets set "CONFIGURACIONES_EMAIL:EMAIL" "tu-correo@gmail.com"
dotnet user-secrets set "CONFIGURACIONES_EMAIL:PASSWORD" "tu-contraseña-de-aplicacion"
dotnet user-secrets set "CONFIGURACIONES_EMAIL:HOST" "smtp.gmail.com"
dotnet user-secrets set "CONFIGURACIONES_EMAIL:PUERTO" "587"
```

---

## 📥 Clonar el repositorio

Sustituye la URL por la de tu fork o el remoto real.

```bash
# HTTPS
git clone https://github.com/TU_USUARIO/PortafolioWeb.git

# SSH
git clone git@github.com:TU_USUARIO/PortafolioWeb.git
```

Entra en la carpeta del proyecto:

```bash
cd PortafolioWeb
```

---

## 👁️ Vista previa

Al ejecutar la app verás una **landing** con secciones de presentación, habilidades y proyectos, navegación a **Proyectos** y **Contacto**, y estilos definidos en `wwwroot/css/`.

> **Sugerencia:** Puedes añadir una captura de pantalla en el repo (por ejemplo `docs/preview.png`) y enlazarla aquí con `![Vista previa](docs/preview.png)` para enriquecer esta sección.

---

## 👤 Autor

**Juan Felipe España Arias**

---

## 📄 Licencia

Este proyecto está bajo la **Licencia MIT**. Consulta el archivo [LICENSE](LICENSE) para el texto completo.

Copyright © 2026 Juan Felipe España Arias.
