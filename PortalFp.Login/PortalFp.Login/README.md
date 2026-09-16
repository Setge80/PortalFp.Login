# PortalFp - Login

Pequeña aplicación de escritorio desarrollada en WPF con .NET 10 para el módulo de Desarrollo de Interfaces (2º DAM). Implementa una pantalla de autenticación accesible, estructurada mediante contenedores `Grid` y con validación de credenciales.

## Características Técnicas
- **Maquetación:** Se utilizo `Grid` sin posicionamiento absoluto y con alturas automáticas adaptativas (`Auto`).
- **Accesibilidad:** Mnemónicos asociados mediante `Label.Target` (Alt+U y Alt+C), navegación con `TabIndex` y descripciones con `AutomationProperties`.
- **Seguridad:** Uso de `PasswordBox` para ocultación de credenciales.
- **Validación:** Comprobación de campos vacíos y feedback visual (`Brushes.Red` / `Brushes.Green`) segun los distintos escenarios.

## Uso Asistido de IA.

Para la fase de estilizado visual en XAML se utilizó **GitHub Copilot** integrado en **Visual Studio**, concretamente se utilizo el modelo **GPT-5 mini**.

### Registro del Prompt
> *"Necesito estilizar este formulario de Login (MainWindow.xaml) respetando la estructura ya existente (Grid y sin posicionamiento absoluto). En primer lugar quiero que definas una paleta de colores sobria con feedback visual claro, en segundo lugar quiero que envuelvas los campos y el boton en contenedores border para redondear las esquinas y por ultimo aplica espacios regulares estandar (margin y padding) en los elementos del formulario con tal de mejorar la legibilidad."*

### Valor Aportado por la IA
- **Solución para WPF:** Envolvió los controles `TextBox`, `PasswordBox` y `Button` en contenedores `Border` con `CornerRadius`, solucionando la ausencia de bordes redondeados en estos controles.
- **Homogeneidad visual:** Generó un espaciado homogéneo, una paleta de colores adecuada y recursos con `Window.Resources` como los `triggers` (hover, pressed, disabled).