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
