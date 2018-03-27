# plataformero-uc

## Resumen del juego

Este plataformero cuenta la historia de un **novato perdido y atrasado** para su primera prueba. Deberá atravesar el Campus San Joaquín para llega su sala a tiempo, evitando enemigos como ayudantes (*goombas*) y profesores (*koopa*) malvados mientras recoge monedas por el campus. Puede encontrar varios power-ups, como pizza (*champiñon normal*), café (*1UP*) o apuntes perfectos del ramo (*starman*). 

En término de mecánicas, el objetivo incial es crear un clon de [Super Mario Bros. (NES)](https://www.youtube.com/watch?v=PsC0zIhWNww), pero si nos va bien podemos agregarle más mecánicas y objetos y niveles.

## Tareas para la semana

### Arte

#### Concepto del personaje principal - @Valhalla
Sería ideal si uno pudiera elegir entre jugar como novato o novata, así que la idea sería crear un diseño para ambos. Se puede repartir esta tarea entre **dos personas entonces,** uno el novato y otro la novata.

#### Conceptos de los enemigos  - @Cappu (profesores) y 
Concept art para los ayudantes malvados y los profesores malvados. Como son dos diseños, pueden ser **dos personas** en esta tarea.

### Diseño

#### Diseño del primer nivel - @matthers3
Hay que diseñar un nivel que enseñe lo básico al jugador, pero **sin tutorial!** [El mismo SMB hace esto.](https://www.youtube.com/watch?v=zRGRJRUWafY) Hay que tratar de introducir todos los elementos del juego

### Programación

#### Movimiento del personaje - @tatanpoker09
El personaje debe poder moverse izquierda y derecha, saltar y caer. [Este tutorial de Unity](https://unity3d.com/learn/tutorials/topics/2d-game-creation/creating-basic-platformer-game) puede ser buena referencia

#### Programación de los enemigos - @rexer
Hay que programar el comportamiento de los dos enemigos:
* Ayudantes malvados: Son como goombas, avanzan en un dirección y cambian cuando chocan con una pared. Si llegan a un precipicio, se tiran nomas. Se matan saltando encima de ellos.
* Profesores malvados: Como los ayudantes pero un poco más pillos, son como los Koopa que cambian de dirección cuando llegan a un precipicio. Se matan de la misma manera.

#### Creación inicial de scenes - @FarDust
El primer scene del proyecto es un *splash screen* con fondo blanco y el [logo de GameDev UC.](https://static.wixstatic.com/media/a818e3_46256d10ccb44a1ca70e1daef0aa39b5~mv2.png/v1/crop/x_84,y_0,w_832,h_1059/fill/w_384,h_466,al_c,usm_0.66_1.00_0.01/a818e3_46256d10ccb44a1ca70e1daef0aa39b5~mv2.png) Este deberá:
* Hacer fade-in gradual del logo (~1 seg)
* Quedarse un rato opaco (~2 seg)
* Hacer fade-out gradual del logo (~1 seg)
En todo momento, el logo debe ser **clickeable** y que lleve al [sitio web](https://www.gamedevcomuc.com) de GameDev UC. Una vez terminado el fade-out, deberá ir **automáticamente** al *ménu*.


En el *menú* habrá dos botones:
* Un botón "Empezar juego", que te lleve al *cutscene inicial.*
* Un botón "Créditos", que abra una caja de texto con los créditos. Deberá tener un "X" algo similar para poder cerrarlos.


En el *cutscene inicial*, no habrá nada ahora! Así que te llevará automaticamente al *primer nivel.*

En el *primer nivel*, tampoco hay cosas que poner, así que quedará como un scene vacio por ahora.

### Audio

#### Crear un loop para el gameplay principal
Estoy abierto a sugerencias para el estilo de música!
