# 🧱 Arquitectura del Proyecto: Finmory.API (.NET 8 Web API)

## 🛠️ Tecnologías
- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- JWT Authentication
- AutoMapper, FluentValidation
- Docker-ready

> Esta estructura permite separar claramente responsabilidades, hacer el código más mantenible, escalable y fácil de testear.

Esta es la estructura base de carpetas para el backend del sistema de finanzas personales **Finmory**. Está organizada siguiendo principios de **Clean Architecture** y buenas prácticas de desarrollo moderno.

 `/Finmory.API
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
└── Program.cs / Startup.cs`

##Clases
## 🧱 Resumen Funcional de los Modelos Principales

Este proyecto contiene 8 modelos de entidad principales diseñados para soportar un sistema completo de gestión financiera personal. Cada uno tiene una responsabilidad bien definida:

| Clase              | Responsabilidad                                                                 |
|--------------------|----------------------------------------------------------------------------------|
| `User`             | Representa la identidad del usuario, información personal y relaciones con otras entidades. |
| `FinancialAccount` | Administra los saldos por tipo de cuenta (por ejemplo: Banco, Efectivo, Billetera). |
| `Category`         | Clasifica las transacciones como `Ingreso` o `Gasto`.                            |
| `Subcategory`      | Añade más detalle a las categorías (ejemplo: Comida → Rápida, Hogar → Renta).    |
| `Transaction`      | Registra cada movimiento financiero (ingresos, egresos, compras, etc.).          |
| `Budget`           | Define límites de gasto por categoría, por mes y año.                            |
| `FinancialGoal`    | Define metas de ahorro con monto objetivo y fecha estimada de cumplimiento.      |
| `GoalContribution` | Lleva el historial de aportes realizados hacia una meta financiera.              |

## 🧱 Ciclo de desarrollo (resumen)
1. Modelo ➤ 2. DTO ➤ 3. Repository ➤ 4. Service ➤ 5. Controller ➤ 6. JWT & Seguridad
