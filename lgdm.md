-   [Tema 6](#tema-6)
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
-   [Tema 7](#tema-7)
    -   [HTML5](#html5)
    -   [Etiquetas de sección de pagina (_header_, _nav_, _footer_, _aside_, _section_ y _article_)](#etiquetas-de-sección-de-pagina-header-nav-footer-aside-section-y-article)
    -   [Formularios](#formularios)
        -   [Etiquetado (_label_)](#etiquetado-label)
        -   [Sugerencias (_datalist_)](#sugerencias-datalist)
        -   [Correo electrónico (_type="email"_)](#correo-electrónico-typeemail)
        -   [Atributos varios](#atributos-varios)
    -   [Multimedia](#multimedia)
        -   [Video y audio](#video-y-audio)
    -   [CSS3](#css3)
        -   [Bordes redondeados (_border-radius_)](#bordes-redondeados-border-radius)
        -   [Sombras (_tex-shadow_ y _box-shadow_)](#sombras-tex-shadow-y-box-shadow)
        -   [Fuentes](#fuentes)
        -   [Media queries](#media-queries)

# Tema 6

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

# Tema 7

## HTML5

```html
<!DOCTYPE html>
<html lang="es">
	<head>
		<meta charset="UTF-8" />
		<title>Titulo</title>
		<link rel="stylesheet" href="file.css" />
	</head>
	<body></body>
</html>
```

## Etiquetas de sección de pagina (_header_, _nav_, _footer_, _aside_, _section_ y _article_)

-   **header**: Agrupa los elementos del encabezado de página.
-   **nav**: Especifica la sección donde se sitúan los elementos de un menú de navegación.
-   **footer**: Indica los elementos que forman la sección del pie de página.
-   **aside**: Especifica los elementos anexos al contenido.
-   **section**: Define una parte del contenido de la página que se refiere a un tema concreto.
-   **article**: Especifica un contenido del documento que posee una identidad independiente.

## Formularios

### Etiquetado (_label_)

La etiqueta **label** asocia un texto de titulo a un campo de formulario, util para accesibilidad.

```html
<form name="form1" action="">
	Forma de pago:<br />
	<label for="cash1">Tarjeta de crédito</label>
	<input type="radio" name="cash" id="cash1" /><br />
	<label for="cash2">PayPal</label>
	<input type="radio" name="cash" id="cash2" /><br />
	<label for="cash3">Contra-reembolso</label>
	<input type="radio" name="cash" id="cash3" />
</form>
```

### Sugerencias (_datalist_)

La etiqueta **datalist**, agregada a un campo de texto, crea una lista de sugerencias dadas por la etiqueta _option_.

```html
<input type="text" list="frutas" />
<datalist id="frutas">
	<option value="Naranja"></option>
	<option value="Manzana"></option>
	<option value="Pera"></option>
	<option value="Ciruela"></option>
</datalist>
```

### Correo electrónico (_type="email"_)

La etiqueta `<input type="email">` permite introducir y validar una dirección de correo electrónico directamente en el navegador.

```html
<form id="form1" action="">
	Correo electrónico: <input type="email" name="mail" required />
	<input type="submit" value="Enviar" />
</form>
```

### Atributos varios

-   **min**: Valor mínimo.
-   **max**: Valor máximo.
-   **step**: Incremento del contador.
-   **value**: Valor inicial.
-   **required**: Obligatorio.
-   **placeholder**: Texto de ejemplo.
-   **autofocus**: Foco cuando se cargue la pagina.

## Multimedia

### Video y audio

-   **src**: Ruta del archivo obligatoria.
-   **width**: Determina la anchura del vídeo.
-   **height**: Determina la altura del vídeo.
-   **poster**: Imagen que el navegador usará mientras se está descargando el vídeo o hasta que el usuario inicie su reproducción.
-   **controls**: Muestra las funciones de reproducción del vídeo: inicio de reproducción, pausa,
    avance y volumen.
-   **autoplay**: Especifica la reproducción automática del archivo de vídeo una vez esté
    disponible, tras la carga de la página.
-   **loop**: Especifica la reproducción en bucle del archivo de vídeo.
-   **preload**: Indica al navegador que se debe descargar el archivo de vídeo durante la carga de
    la página, de modo que esté disponible su reproducción de forma inmediata. Puede tomar
    los siguientes valores: **none**, especifica que no existe carga previa; **metadata**, especifica la
    carga previa de los metadatos asociados al archivo; y, **auto**, especifica la carga previa
    automática.

```html
<video controls>
	<source src="./recursos/bunny.ogv" />
	<source src="./recursos/bunny.mp4" />
	<source src="./recursos/bunny.webm" />
	Su navegador no soporta la etiqueta video.
</video>
```

## CSS3

| Pseudoclase     | Descripcion                                                                                                            |
| --------------- | ---------------------------------------------------------------------------------------------------------------------- |
| :empty          | Elementos sin hijos                                                                                                    |
| :nth-of-type(n) | Designa al enésimo elemento de este tipo donde n es un número, o bienlas palabras claves even (pares) y odd (impares). |

| Selector de atributos | Descripcion                                    |
| --------------------- | ---------------------------------------------- |
| [atr]                 | Contiene el atributo _atr_                     |
| [atr="valor"]         | Contiene el atributo atr con el valor indicado |
| [atrˆ="valor"]        | El atributo atr comience con el prefijo        |
| [atr$="valor"]        | El atributo atr termina por el prefijo         |
| [atr*="valor"]        | Contiene una instancia u ocurrencia            |

### Bordes redondeados (_border-radius_)

```css
#img {
	width: 270px;
	height: 180px;
	border-radius: 1em;
	border: 1px solid gray;
	background-image: url(coche.png);
}
.borderedondo {
	border-radius: 7px;
	border: 1px solid blue;
}
```

### Sombras (_tex-shadow_ y _box-shadow_)

```css
.relieve {
	color: white;
	text-shadow: 2px 2px 3px black;
}
```

### Fuentes

```html
<head>
	<title>CSS3 - Tipos de letra personalizados</title>
	<meta charset="utf-8" />
	<link
		rel="stylesheet"
		type="text/css"
		href="https://fonts.googleapis.com/css?family=Tangerine"
	/>
</head>
```

```css
.titulo {
	font-family: "Tangerine", "Agency FB", "Arial Rounded MT", serif;
	font-size: 52px;
	font-weight: bold;
	text-shadow: 4px 4px 4px #aaa;
}
```

### Media queries

```css
/* En pantallas de 992 px de ancho o menos, el color de fondo es azul */
@media only screen and (max-width: 992px) {
	body {
		background-color: blue;
		color: white;
	}
}
/*En pantallas de 600 px de ancho o menos, el color de fondo es azul olive */
@media only screen and (max-width: 600px) {
	body {
		background-color: olive;
		color: white;
	}
}
```
