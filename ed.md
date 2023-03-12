-   [Tema 4 - Pruebas](#tema-4---pruebas)
    -   [Tipos de pruebas](#tipos-de-pruebas)
        -   [A. Conocimiento del código](#a-conocimiento-del-código)
        -   [B. Automatización](#b-automatización)
        -   [C. Fase del ciclo](#c-fase-del-ciclo)
    -   [Casos de prueba, valores límite y clases de equivalencia](#casos-de-prueba-valores-límite-y-clases-de-equivalencia)
        -   [Caso de prueba](#caso-de-prueba)
        -   [Caja blanca](#caja-blanca)
            -   [Caso de prueba](#caso-de-prueba-1)
        -   [Caja negra](#caja-negra)
            -   [Clases de equivalencia](#clases-de-equivalencia)
            -   [Valores límite](#valores-límite)
            -   [Ejercicio](#ejercicio)
-   [Tema 5 - Documentación](#tema-5---documentación)
    -   [Normas de estilo](#normas-de-estilo)
        -   [Indentación](#indentación)
        -   [Espacios en blanco](#espacios-en-blanco)
        -   [Lineas en blanco](#lineas-en-blanco)
        -   [Comentarios](#comentarios)
        -   [Llaves](#llaves)
        -   [Declaraciones](#declaraciones)
        -   [Convenios de nombres](#convenios-de-nombres)
    -   [Documentación](#documentación)
    -   [IMPORTANTE PARA LA PRÁCTICA](#importante-para-la-práctica)
-   [Tema 6 - Refactorización](#tema-6---refactorización)
    -   [Visual Studio](#visual-studio)

# Tema 4 - Pruebas

## Tipos de pruebas

### A. Conocimiento del código

-   **Caja negra**: no se conoce el código
-   **Caja blanca**: se conoce el código

### B. Automatización

-   **Manuales**: se hacen al programar o las ejecutan personas
-   **Automáticas**: usando software para sistematizar las pruebas

### C. Fase del ciclo

-   **Unitarias**: se aplican a un sólo componente (función, clase, librería...)
-   **Integración**: probar el sistema con todos sus componentes
-   **Funcionales**: comprueba si se cumple con la especificación
-   **Rendimiento**: comprobar el volumen de carga
-   **Aceptación**: realizada por los usarios
    -   _Alfa_: en presencia de desarrolladores
    -   _Beta_: versión casi definitiva

## Casos de prueba, valores límite y clases de equivalencia

### Caso de prueba

Conjunto formado por entradas, condiciones de ejecución y resultados. Un buen caso de prueba es muy probable de descubrir un error y no es redundante.

### Caja blanca

```csharp
static void Main(string[] args)
{
    int j = 2, s = 0, n;
    if (textBox1.Text == "")
        textBox2.Text = "Introduce un número";
    else {
        try
        {
            n = int.Parse(textBox1.Text);
            while (j < n)
            {
                if (n % j == 0)
                s = s + 1;
                j = j + 1;
            }
            if (s == 0)
                textBox2.Text = n + " Es un número primo";
            else
                textBox2.Text = n + " No es un número primo";
        }
        catch
        {
            MessageBox.Show("Has introducido un carácter");
        }
    }
}
```

#### Caso de prueba

| entrada | salida                | comentario           |
| ------- | --------------------- | -------------------- |
| ""      | "Introduce un numero" | primer if            |
| a b     | Mensaje Box           | excepcion; catch     |
| 1       | primo                 | bucle 0 veces, 2º if |
| 3       | primo                 | bucle 1 vez, 3er if  |
| 4       | no primo              | bucle 2 veces, else  |
| 23      | primo                 | bucle n veces, 2º if |

De esta forma se comprueban todas las coberturas de bucles y de condicion y todos los caminos.

### Caja negra

#### Clases de equivalencia

-   Rangos
    -   x < rango
    -   x $\in$ rango
    -   x > rango
-   Valor concreto
    -   x < valor
    -   x == valor
    -   x > valor
-   Conjunto
    -   x $\notin$ conjunto
    -   x $\in$ conjunto
-   Booleanos
    -   _true_
    -   _false_

#### Valores límite

Puntos de cambio de clases de equivalencia. 2 valores frontera; uno justo **abajo** y otro justo **encima**.

`a - 1 | a | a + 1`

#### Ejercicio

[Implementación pruebas unitarias C#](ed.ejercicios/pruebas/PruebasGestion/UnitTest1.cs)

[Programa a probar](ed.ejercicios/pruebas/WindowsFormsApp1/Form1.cs)

-   _realizarReintegro_(cantidad: double)
    -   cantidad > 0 y saldo >= ingreso (es el único caso válido)
    -   cantidad < 0 (no valido, error cantidad)
    -   saldo < cantidad (no válido, saldo insuficiente)
-   _realizarIngreso_(cantidad: double)
    -   cantidad <= 0 (no válido, error cantidad)
    -   cantidad > 0 (caso válido)

| Nombre de la prueba  | Saldo Inicial | Cantidad | Salida esperada        |
| -------------------- | ------------- | -------- | ---------------------- |
| validarIngresoArray1 | 1000          | -100     | ERR_CANTIDAD_NO_VALIDA |
| validarIngresoArray1 | 1000          | -1       | ERR_CANTIDAD_NO_VALIDA |
| validarIngresoArray1 | 1000          | 0        | ERR_CANTIDAD_NO_VALIDA |
| validarIngreso2      | 1000          | 1        | 1001                   |
| validarIngreso3      | 1000          | 100      | 1100                   |

| Nombre de la prueba    | Saldo Inicial | Cantidad           | Salida esperada        |
| ---------------------- | ------------- | ------------------ | ---------------------- |
| validarReintegroArray1 | 1000          | -100               | ERR_CANTIDAD_NO_VALIDA |
| validarReintegroArray1 | 1000          | -1                 | ERR_CANTIDAD_NO_VALIDA |
| validarReintegroArray1 | 1000          | 0                  | ERR_CANTIDAD_NO_VALIDA |
| validarReintegro2      | 1000          | saldo - 1 = 999    | 1                      |
| validarReintegro3      | 1000          | saldo = 1000       | 0                      |
| validarReintegroArray4 | 1000          | saldo + 1 = 1001   | ERR_SALDO_INSUFICIENTE |
| validarReintegroArray4 | 1000          | saldo + 100 = 1100 | ERR_SALDO_INSUFICIENTE |

# Tema 5 - Documentación

## Normas de estilo

### Indentación

-   Nueva linea despues de coma
-   Nueva linea despues de operador
-   Evitar dividir parentesis

### Espacios en blanco

-   Despues de coma o punto y coma
-   Alrededor de operadores excepto unarios

### Lineas en blanco

-   Separar declaraciones de variables
-   Separar metodos de propiedades
-   Separar secciones lógicas dentro de un metodo

### Comentarios

-   Comentarios de documentacion > comentarios de bloque
-   Comentarios de una linea
    -   &check; declaracion de variables y final de una estructura

### Llaves

-   Linea independiente excepto `else` y `while`
-   Evitar omitir llaves

### Declaraciones

-   Una declaración por linea
-   Nombres autoexplicativos

### Convenios de nombres

-   PasCal -> clases, excepciones, interfaces, métodos, propiedades, enumeraciones, estáticos, readonly y constantes
-   caMel -> campos y variables
-   MAYÚSCULAS -> abreviaturas de uno o dos caracteres
-   Notación húngara -> prefijos que indican el tipo
-   Evitar snake_case

```csharp
public interface IMotorizado
{
    void Arrancar();
    void Parar();
}

public class Coche : IMotorizado
{
    // Miembro privado
    private int velocidadActual;

    // Constructor
    public Coche()
    {
        velocidadActual = 0;
    }

    // Propiedad pública
    public int VelocidadActual
    {
        get { return velocidadActual; }
        set { velocidadActual = value; }
    }

    // Método público
    public void Acelerar(int cantidad)
    {
        velocidadActual += cantidad;
        Console.WriteLine($"El coche aceleró {cantidad} km/h y ahora va a {velocidadActual} km/h.");
    }

    // Implementación de la interfaz IMotorizado
    public void Arrancar()
    {
        Console.WriteLine("El coche ha arrancado.");
    }

    public void Parar()
    {
        Console.WriteLine("El coche se ha detenido.");
    }
}
```

## Documentación

-   Summary
-   Remarks: en conjunto con summary
-   Param: atributo name
-   Returns
-   Value: descripcion del valor que recupera una **propiedad**
-   Paramref: referencia a los parámetros que recibe una funcion. Atributo name
-   See: referencia que enlaza usando el atributo cref
-   SeeAlso
-   Exception: atributo cref
-   Para: párrafo
-   List: type = bullet | numeric | table
    -   Item
        -   Description
-   Example
    -   Code

## IMPORTANTE PARA LA PRÁCTICA

-   Tras añadir los comentarios de documentación
    -   Proyecto > Propiedades > Compilación > Salida > Archivo de documentación XML
-   Solucion > Agregar > Nuevo proyecto > Sandcastle Help File Builder Project
-   ProyectoDocumentacion > Documentation Source > ProyectoClases.csproj
-   Project Properties >
    -   Build > Presentation style 2013 > chm
    -   Help File > Spanish > Footer nombre
    -   Visibility > Private fields

# Tema 6 - Refactorización

## Visual Studio

-   Tabulación
-   Renombrar
-   Encapsular: convertir campo público en propiedad
-   Extraer método: crear nuevo método a partir de un fragmento de código existente
-   Quitar parámetros: cuando ya no necesitamos datos de entrada en un método
-   Reordenar parámetros
-   Extraer interfaz
-   Números mágicos
