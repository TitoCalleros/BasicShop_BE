# API de Productos

API REST para gestionar productos (CRUD, filtrado y paginación).  
**Base de datos compatible:** **SQL Server 2014** (compatibility level 120).

---

## Tabla de contenidos
- [Requisitos](#requisitos)
- [Compatibilidad con SQL Server 2014](#compatibilidad-con-sql-server-2014)
- [Instalación](#instalación)
- [Migraciones](#migraciones)

---

## Requisitos
- **.NET SDK** 8/9 (según `TargetFramework` del proyecto).
- **SQL Server 2014** o superior.
- (Opcional) **FluentMigrator** o **EF Core Tools** si ejecutas migraciones desde CLI.
- (Opcional) Docker para contenedores de API/BD.
- Crear la base de datos BasicShop en el servidor de SQL Server

---

## Compatibilidad con SQL Server 2014
- Nivel de compatibilidad recomendado: **120**.
- ✅ Paginación con `OFFSET … FETCH`: **disponible** desde SQL 2012 → compatible.
- ❌ Funciones JSON nativas (`JSON_VALUE`, etc.): **no disponibles** (aparecen en SQL 2016).
- Evita T-SQL o tipos introducidos en versiones posteriores si no existen en 2014.

---

## Instalación
Clona el repositorio y restaura dependencias:

```bash
git clone <url-del-repo>
cd <carpeta-del-repo>
dotnet restore
```

---

## Migraciones
Este proyecto incluye la ejecución de 2 migraciones para crear la tabla Products y llenarla con 50 registros.
