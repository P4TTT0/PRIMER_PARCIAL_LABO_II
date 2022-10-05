# PRIMER_PARCIAL_LABO_II
Primer parcial de Laboratorio II de Perez Cardenal Patricio

# [CRUCITY] 
## []-| SOBRE MI.
Mi nombre es Perez Cardenal Patricio, tengo 18 años y me encuentro finalizando este actual proyecto. El hecho de programar me entusiasma mucho y es por eso que me he enfocado con mi mayor esfuerzo en el desarollo de este trabajo, el cual sinceramente fue un desafio debido a mi poco tiempo y a la complejidad del mismo. Se perfectamente que hay un sin fin de cosas que mejorar pero di todo de mi para equilibrar produccion, tiempo y funcionalidad.

## []-| RESUMEN.
- [LOGIN] La aplicacion comienza con una ventana de LOG-IN que permite al vendedor ingresar su usuario y contraseña para entrar con su respectivo perfil.
- [MENU PRINCIPAL] Una vez adentro de la aplicacion nos encontraremos con el menu de inicio donde podremos ver nuestro usuario, la fecha actual y nuestra foto de perfil. En un costado tambien podremos visualizar las diferentes opciones:
    - **VIAJES:** Aqui podremos observar todos los cruceros con su informacion basica, si poseen un viaje asignado, ver sus viajes asignados y crear viajes colocando destino y fecha.
    - **VENDER:** Aqui podremos observar los viajes disponibles para vender pasajes. En el lateral izquierdo tenemos un listado de filtros para una busqueda mas rapida y/o detallada. Podemos decidir si queremos vender un pasaje de tipo PREMIUM o uno TURISTA, en ambos deberemos colocar toda la informacion del pasajero para poder asignarlo a un viaje.
    - **INFO:** Aqui se desplegara una lista de todos los viajes, los mismos podran ser seleccionados para desplegar otra lista sus pasajeros asignados. En la parte inferior derecha tendremos un boton que nos permitira visualizar la informacion a detalle del pasajero que seleccionemos.
    - **STATS:** Por ultimo, en esta opcion veremos estadisticas historicas, un grafico porcentual de ganancias, las ganacias totales dependiendo de tipo de destino y dos botones que nos llevan a dos diferentes listados historicos.
## []- DIAGRAMA DE CLASES.
![DIAGRAMA DE CLASES](https://user-images.githubusercontent.com/98591487/193988381-e9b53b9b-5e50-48c0-9a5e-712c42fb3d72.png)
## []- JUSTIFICACION TECNICA.
- Tema 01
Englobando todos los conceptos, el lenguaje c# fue quien me permitio dar todas las instrucciones a la mencionada aplicacion, realizando todo el apartado logico del programa.
- Tema 02
Realice una clase estatica con su respectivos metodos esaticos para poseer una base de datos en la cual ubicar todos los hardcodeos literales. La misma dispone de diferentes listas y metodos que facilitaron el manejo de cualquier informacion.
- Tema 03
La programacion orientada a objetos fue la principal ayuda a la hora de elaborar entidades con sus respectivos atributos y comportamientos, abstrayendo los detalles mas importantes y enfocandome en lo necesario. De hecho, me hizo pensar de forma literal a la hora de crear, por ejemplo, la clase persona para heredarla en pasajero.
- Tema 04
Las sobrecargas tambien fueron de gran ayuda para la construccion de entidades, de herencias, de comparaciones si pensamos en los operadores y de comportamientos si pensamos en los metodos. Lo utilice en diversas ocaciones mayormente para la comparacion indirecta de atributos sobre distntas entidades.
- Tema 05
La implementacion de una interfaz grafica me permitio crear una aplicacion mas intuitiva y con ayudas visuales dirigas al usuario que permiten un manejo mas fluido del programa. Utilice una variedad de elementos provinientes de Windows Forms para poder dar accesibilidad y funcionalidad a diferentes apartados.
- Tema 06
Como mencione anteriormente, utilice una "base de datos" con diferentes colecciones para administrar datos de manera organizada. Para ser mas especificos, todas fueron colecciones genericas para proporcionar operaciones eficientes y seguras a la hora de acceder a los elementos.
- Tema 07
El encapsulamiento se mantuvo presente durante todo el desarrollo logico a la hora de: nivelar los modificadores de acceso de las diferentes entidades, atributos y comportamientos, crear propiedades para no sobreexponer atributos y enumerados para facilitar el manejo de constantes.
- Tema 08
La utilizacion de herencia como un respectivo molde me sirvio para la creacion de entidades que compartian caracteristicas, como "Leaderboard". Tambien he utilizado en la interfaz grafica ya que me permitio mantener un diseño con comportamientos iguales o similares.
- Tema 09
Utilice polimorfismo en la anterior mencionada entidad "Persona" para sobreescribir el metodo mostrar.
