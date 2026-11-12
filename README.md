# Kepler-7 – El universo de los patrones

Trabajo Práctico Final de Patrones de Diseño – Universidad Abierta Interamericana (UAI).

Videojuego de escritorio en C# con Windows Forms. La Estación Orbital Kepler-7 está en crisis y el jugador tiene que recorrer sus 7 áreas para recuperar los subsistemas. En cada área se usan uno o más de los 12 patrones de diseño pedidos.

**Integrantes:** Agustina Torres, Ariana Campos, Tomas Garrote, Ivan Paco, Lautaro Martori

## Tecnologías

- C# con Windows Forms sobre .NET Framework 4.8
- SQL Server Express LocalDB (progreso de la partida, logros y registro de accesos denegados)
- Solo bibliotecas incluidas en .NET, sin motores ni paquetes NuGet de terceros

## Cómo ejecutarlo

1. Abrir `Kepler-7/Kepler7.sln` con Visual Studio 2022.
2. Tener instalado SQL Server Express LocalDB (viene con la carga de trabajo "Almacenamiento y procesamiento de datos" de Visual Studio). La base `Kepler7` y sus tablas se crean solas la primera vez que se abre el juego.
3. Establecer `Kepler7.Game` como proyecto de inicio y ejecutar (F5).

## Estructura

```
Kepler-7/
├── Kepler7.sln
├── Kepler7.Core/     Class Library: lógica del juego y los 12 patrones
│   ├── Builder/  Prototype/  Bridge/  Facade/  Flyweight/  Proxy/
│   ├── ChainOfResponsibility/  Command/  Visitor/  State/  TemplateMethod/  Strategy/
│   ├── Juego/        Progreso y guardado de la partida
│   └── Datos/        Script SQL de la base
└── Kepler7.Game/     Windows Forms App: solo interfaz gráfica
Diagramas/            Diagramas de clases de cada patrón
```

## Recorrido y patrones

| Área | Formulario | Patrones |
| --- | --- | --- |
| Control central | FrmControlCentral | Facade |
| Hangar | FrmConstructorNaves | Builder |
| Combate | FrmSimuladorIA | Strategy |
| Laboratorio | FrmLaboratorio | Prototype, Flyweight |
| Comunicaciones | FrmComunicaciones | Bridge, Proxy |
| Personaje | FrmPersonaje | State, Visitor |
| Batalla | FrmBatalla | Command, Template Method, Chain of Responsibility |

- **Creacionales:** Builder, Prototype
- **Estructurales:** Bridge, Facade, Flyweight, Proxy
- **Comportamiento:** Chain of Responsibility, Command, Visitor, State, Template Method, Strategy

## Cómo se juega

- Se empieza con un tutorial y se avanza por las 7 áreas con el botón "Siguiente".
- Cada patrón dominado da 100 XP y un logro; cada 300 XP se sube de nivel.
- **Victoria:** dominar los 12 patrones.
- **Derrota:** perder contra el dron en el simulador o que la Vida de la estación llegue a 0 en la Batalla.
- El progreso se guarda automáticamente en la base de datos.
