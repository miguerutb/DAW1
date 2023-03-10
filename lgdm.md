# Lenguages de marcas 2

-   [Lenguages de marcas 2](#lenguages-de-marcas-2)
    -   [Posicionamiento (_position_, _float_ y _clear_)](#posicionamiento-position-float-y-clear)
        -   [Posicionamiento estático](#posicionamiento-estático)
        -   [Posicionamiento relativo](#posicionamiento-relativo)
        -   [Posicionamiento absoluto](#posicionamiento-absoluto)
        -   [Posicionamiento fijo](#posicionamiento-fijo)
        -   [Posicionamiento flotante](#posicionamiento-flotante)
    -   [Superposición (_z-index_)](#superposición-z-index)
    -   [Desbordamiento (_overflow_)](#desbordamiento-overflow)
    -   [Recorte (_clip_)](#recorte-clip)
    -   [Visibilidad (_visibility_)](#visibilidad-visibility)
    -   [Visualización (_display_)](#visualización-display)
        -   [Table](#table)

## Posicionamiento (_position_, _float_ y _clear_)

Actualmente desaconsejado. Cinco metodos distintos:

### Posicionamiento estático

Valor **por defecto**. Los elementos aparecen segun el flujo normal.

```css
position: static;
```

### Posicionamiento relativo

Desplaza la caja un cierto valor respecto a su posición normal.

```css
position: relative;
top: 30px;
left: 60px;
```

### Posicionamiento absoluto

La posición viene dada por las coordenadas, por lo que se puede solapar. El resto de elementos se comportan como si no existieran los elementos con posicionamiento absoluto. El elemento padre debe estar posicionado.

```css
position: absolute;
left: 75px;
top: 100px;
```

### Posicionamiento fijo

Como el posicionamiento absoluto pero manteniendo la posicion cuando el usuario desplaza la pagina.

```css
position: fixed;
left: 75px;
top: 100px;
```

### Posicionamiento flotante

Desplaza horizontalmente la caja hacia la izquierda o la derecha. El resto de cajas ocupan el lugar dejado por la caja flotante. No se produce superposicion ni solapamiento.

```css
float: left | right;
```

La propiedad **clear** anula el efecto introducido por la propiedad float:

```css
clear: both;
```

## Superposición (_z-index_)

La propiedad **z-index** determina el elemento que se situa delante; el valor mayor aparecerá por delante de las demás. Sólo funciona con posicionamiento absoluto.

```css
.cajas {
	position: absolute;
}
.caja1 {
	z-index: 1;
}
.caja2 {
	z-index: 2;
}
```

## Desbordamiento (_overflow_)

El **overflow** determina como actua el navegador cuando un elemento es mas grande que su contenedor.

-   **hidden**: oculta el desbordamiento.
-   **scroll**: oculta el desbordamiento y añade barras de scroll.
-   **visible**: muestra el desbordamiento.
-   **auto**: lo gestiona el navegador.

## Recorte (_clip_)

La propiedad **clip** determina la parte visible de un elemento, generalmente una imagen. Se incluye la imagen entera aunque no toda sea visible. Sólo funciona con posicionamiento absoluto.

```css
.recorte {
	position: absolute;
	clip: rect(0px 170px 215px 0px);
}
```

## Visibilidad (_visibility_)

El elemento sigue ocupando espacio pero no se ve.

```css
visibility: hidden;
```

## Visualización (_display_)

-   **block**: El elemento se trata como un bloque y ocupa todo el ancho de linea.
-   **inline**: El elemento solo ocupa el espacio necesario.
-   **inline-block**: se muestra como una línea en el flujo del texto, pero también puede tener un ancho y alto establecidos, y puede tener márgenes y rellenos. Además, varios elementos "inline-block" pueden estar en línea uno al lado del otro.
-   **none**: Oculta el elemento y no ocupa espacio en la página.
-   **flex**
-   **table**

```css
display: blocl | inline | inline-block | none | flex | table;
```

### Table

El elemento table presenta problemas de accesibilidad y suele utilizarse `display: table;`.

-   table: Asigna comportamiento de tabla.
-   table-row: Crea una fila de la tabla como _tr_.
-   table-column: Crea una fila de la tabla como.
-   table-cell: Crea una celda como _td_.
-   table-caption: Leyenda de la tabla.

```css
.tabla {
	display: table;
}
.fila {
	display: table-row;
}
.celda {
	display: table-cell;
}
```
