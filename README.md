<h1 align="center">🎮 AdventureRoller — Proyecto Unity 6.2 PGL 3º DAM 🎮</h1> <p align="center"> <img src="https://img.shields.io/badge/Unity-6.2-brightgreen?logo=unity" /> <img src="https://img.shields.io/badge/C%23-Scripting-blue?logo=c-sharp" /> <img src="https://img.shields.io/badge/3D-Game-orange?logo=unity" /> <img src="https://img.shields.io/badge/License-MIT-green" /> </p>
🧩 Descripción del proyecto

AdventureRoller es un juego 3D desarrollado en Unity 6.2 para la asignatura de PGL de 3º DAM.
El jugador controla una bola que debe recoger todos los pickups en cada nivel mientras evita enemigos.
Incluye:

Movimiento físico realista con Rigidbody.

Saltos solo sobre plataformas.

Enemigos que reinician el nivel al tocarlos.

Transición automática Level1 → Level2 → GameEnd.

Pantalla final con opción de reiniciar el juego.

🚀 Tecnologías utilizadas
Tipo	Tecnología
Motor de juego	Unity 6.2
Lenguaje	C#
UI	Canvas + TextMeshPro
Física	Rigidbody, Colliders
Input	Input System Actions
Otros	SceneManager, Coroutines, ScriptableObjects opcional

⚙️ Instalación y ejecución

1️⃣ Clonar el repositorio:

git clone https://github.com/bramirezramirez/AdventureRoller
cd AdventureRoller


2️⃣ Abrir en Unity 6.2:

Abrir Unity Hub → Add Project → seleccionar la carpeta del proyecto.

Abrir Level1.unity para iniciar pruebas o jugar.

3️⃣ Ejecutar el juego:

Pulsar Play en el editor.

Controlar la bola con W/A/S/D o flechas.

Saltar si está sobre el suelo.

Reiniciar el nivel en cualquier momento con R.

Recoger todos los pickups para avanzar de nivel.

🧠 Funcionalidades principales

✅ Movimiento con Rigidbody y física realista.
✅ Saltos condicionados al suelo (isGrounded).
✅ Recoger pickups con contador en pantalla.
✅ Enemigos que reinician el nivel al contacto.
✅ Patrullas de enemigos con EnnemyPatrol.
✅ Transición automática entre niveles y pantalla final.
✅ Pantalla GameEnd con mensaje de victoria y botón Reiniciar juego.
✅ Reinicio manual con tecla R.
✅ Cámara suave y dinámica con CameraController.

🔹 Característica extra de Unity

Se ha añadido rebote de la bola contra las paredes mediante un Physics Material con los siguientes ajustes:

Bounciness: 1 (rebote máximo)

Friction Combine: Minimum

Bounce Combine: Maximum

Dynamic Friction: 0

Static Friction: 0

Esto permite que la bola rebote de forma consistente y rápida al chocar contra cualquier muro, aumentando la jugabilidad y demostrando el uso de Physics Materials de Unity.


🗂️ Estructura del proyecto
AdventureRoller/
├─ Assets/
│  ├─ Scenes/
│  │   ├─ Level1/Level1.unity
│  │   └─ Level2/Level2.unity
│  │   └─ GameEnd/GameEnd.unity
│  ├─ Materials/
│  │   ├─ EnemyMat.mat
│  │   ├─ GroundMat.mat
│  │   ├─ PickupMat.mat
│  │   ├─ SuperEnemyMat.mat
│  │   └─ WallMat.mat
│  ├─ InputSystem/
│  │   └─ InputSystemActions.inputactions
│  └─ Scripts/
│      ├─ CameraController.cs
│      ├─ EndMenu.cs
│      ├─ EnnemyPatrol.cs
│      ├─ GameManager.cs
│      ├─ Pickup.cs
│      └─ PlayerController.cs
└─ ProjectSettings/

🎨 Interfaz de usuario (UI/UX)

Contador de pickups en pantalla con TextMeshPro.

Mensaje de “Nivel completado” al final de cada nivel.

Pantalla final GameEnd con botón Reiniciar juego.

Diseño limpio con colores diferenciados para pickups, enemigos y plataformas.

📝 Notas importantes

⚠️ Cada nivel debe tener todos los pickups correctamente taggeados como "Pickup".
⚠️ Enemigos deben tener tag "Enemy".
⚠️ PlayerController requiere Rigidbody y Collider.
⚠️ Todas las escenas deben estar en Build Profiles en este orden:

Level1 → Level2 → GameEnd


⚠️ Tecla R reinicia el nivel actual.
⚠️ Botón de GameEnd reinicia el juego al primer nivel.

📄 Licencia

MIT License – libre para uso educativo y personal.

🚀 Proyecto realizado por

Bentejui Ramirez Ramirez — 3º CFGS DAM IES El Rincón 💻