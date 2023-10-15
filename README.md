# Calculator-App: Binario-Decimal

El primer parcial de **Laboratorio II** parte de del **primer ejercicio integrador**, es una calculadora que realiza operaciones básicas hecha en `C#`.

Permite realizar las operaciones de suma, resta, multiplicación y división y poder expresar el resultado tanto en **decimal** como **binario**.

Ademas de poder acceder al historial de operaciones realizadas y poder limpiarlo.

![Gif mostrando la calculadora](src/vid/Preview-Calculator-App.gif)

## Diagrama de clases 📋

Inicialmente, el proyecto contara con las siguientes clases:

- **Numeracion**
- **Sistema Decimal**
- **Sistema Binario**
- **Calculadora**

Junto a un enumerado **ESistema** que contendra los valores **Binario**, **Decimal** y **Octal** (proximamente) que representaran el sistema de la calculadora.

Ademas, se creara un formulario principal **FrmCalculadora** que contendra los botones y los campos de texto para poder realizar las operaciones.

### Numeracion

Es la clase base de la aplicación y es `abstracta`. Contiene los atributos **valor** y **msgError** ambas de tipo `string` que representaran el valor numerico de la numeracion dependiendo de si esta es valida o no. 

Las clases **Sistema Decimal** y **Sistema Binario** heredan de esta clase. E internamente siempre trabajaremos con tipos numéricos.

![Diagrama de clases](src/img/Diagrama-Numeracion.png)

Tanto **Sistema Decimal** como **Sistema Binario** contienen métodos que les permitira validar el numero de la numeracion.

### Calculadora

Es la clase que contiene los métodos para realizar las operaciones. Contiene los atributos **primerOperando**, **segundoOperando** y **resultado** de tipo `Numeracion`. 

Junto a **operaciones** que es un `List<string>` que contiene el historial de operaciones realizadas, **sistema** de tipo `ESistema` que representa el sistema de la calculadora. 

Adicionalmente esta **nombre** que es un `string` que representa el nombre de la calculadora (o de su dueño).

El metodo `Caclular` recibe como parámetro el operador (por defecto realiza una suma) y mapea el resultado de la operación segun el sistema de la calculadora.

![Diagrama de clases](src/img/Diagrama-Calculadora.png)

### FrmCalculadora

Es el formulario principal de la aplicación. Contiene los botones para realizar la operacion, revisar el historial y de limpieza para este ultimo. 

También contiene dos **TextBox** donde se ingresan los números y el **Label** donde se muestra el resultado.

![Diagrama de clases](src/img/Diagrama-Formulario.png)