# FinmorySolution
# 🧱 Arquitectura del Proyecto: Finmory.API (.NET 8 Web API)

Esta es la estructura base de carpetas para el backend del sistema de finanzas personales **Finmory**. Está organizada siguiendo principios de **Clean Architecture** y buenas prácticas de desarrollo moderno.

/Finmory.API
│
├── Controllers/ # Puntos de entrada HTTP (REST endpoints)
│
├── Models/ # Entidades del dominio (representan las tablas de la BD)
│
├── DTOs/ # Data Transfer Objects: para requests y responses limpios
│
├── Services/ # Lógica de negocio (interfaz y lógica concreta de cada módulo)
│
├── Repositories/ # Acceso a datos: interfaces y clases que interactúan con la BD
│
├── Data/ # DbContext, migraciones y configuración de EF Core
│
├── Auth/ # Lógica relacionada a autenticación y generación de tokens JWT
│
├── Helpers/ # Clases utilitarias, mapeos, constantes, etc.
│
├── Middleware/ # Middleware personalizados para manejo de errores, logs, etc.
│
├── appsettings.json # Configuraciones del entorno (conexión a BD, claves, etc.)
│
└── Program.cs / Startup.cs
