# GRP1_AMARON

Miembros del grupo:
- Paula Guadalajara Saiz
- Samuel Arevalo Cañestro
- Ricardo González Torres
- Adrían García Olaya
- Tamara Elizabeth Salcedo Peinado
- Javier de Mena Asenjo

Descripción:
Se trata de una página web dirigida a la venta de bebidas alcholicas.

Documento Base de Datos:
- GRP5_GRP1_AMARON/GRP5_GRP1_AMARON/Esquema_BD_AMARON.jpg

Documento Presentacion:
- GRP5_GRP1_AMARON/Presentacion_AMARON_v2.pptx


## Primera Propuesta:

Parte pública:
Desde la parte pública (sin necesidad de iniciar sesión), el usuario podrá ver el listado de productos a la venta y las características de dichos productos, podrá acceder a la página de registro, a la página de inicio de sesión, podrá buscar por distintos filtros los productos, podrá acceder a la página de soporte.

Listado EN Pública:
- Producto
- Guest
- Búsqueda
- Soporte
- Registro
- Login

Parte privada:
Desde la parte privada, los usuarios registrados podrán realizar pedidos, escribir comentarios y opiniones, mirar su carrito de la compra, modificar sus datos personales y mirar los pedidos que ha realizado antes. Además, el usuario registrado podrá recibir emails de la página y enviar sugerencias.

Listado EN Privada:
- Lista de pedidos
- Carrito
- Usuario
- eMails
- Sugerencias

Posibles mejoras:
- Añadir publicidad
- Links de redes sociales
- Añadir una lista de deseos
- Internacionalización de la pagina
- Suscripción premium
- Packs de productos


## Entrega Final AMARON

### Propuesta inicial del proyecto:

- Para usuarios: Ver su perfil, ver pedidos hechos, cifrar sus contraseñas, añadir productos a su carrito, controlar su fecha de nacimiento, editar/borrar su perfil y que puedan añadir valoraciones a los productos.

- Para proveedores: Ver su perfil, editarlo/borrarlo, que tengan la opción para indicar su empresa y que puedan añadir productos.

- Para productos: Tener varios tipos de productos: misceláneos, botellas, pack. Mostrar comentarios de los usuarios. Guardar las valoraciones de los usuarios en la base de datos.

- Página de contacto: Que cualquier persona que acceda a la página pueda tener acceso al formulario de contacto.

- Página Default: Que al acceder a la página lo primero que vea un usuario sea un slider con una muestra de los productos y las lootcrates. Y que pueda acceder al catálogo, esté o no registrado, que ir a la página de iniciar sesión y a la de registro. También que pueda acceder a las página de “Contáctanos”, y rellenar un formulario de contacto, y la página “Acerca de nosotros” que muestra información acerca de la página.

- Página del Catálogo: Accesible estando registrado o no, filtro en función del tipo de producto: Pack, Miscelánea, Botellas y Lootcrate. Que muestre los productos almacenados en la base de datos de forma dinámica.

- Lootcrate: Tipo de producto que consiste en una selección de productos que se envía a los usuarios que se suscriban a algún plan (basic, normal, premium).
 
- Página del carrito: Se mostrarán los productos que el usuario tiene pensados comprar y se podrá acceder a la página de pago para proceder con su compra.

- Página de pago: Se comprobarán ciertos datos del usuario como su tarjeta y si todo es correcto podrá comprar el producto. Al finalizar un pago, el pedido se almacena en el historial de pedidos del usuario (Página de pedido).

- Página de pedido: Visualización de todos los pedidos que ha realizado el usuario, apareciendo el número, estado, coste y fecha del pedido en una tabla.

### Propuesta final del proyecto:

Hemos conseguido todo lo mencionado en la propuesta inicial excepto:

- Mostrar las valoraciones de los usuarios en la página del producto.

- Tipos de suscripción en LootCrate (Basic, Normal, Premium), en lugar de eso, los usuarios que se suscriban al plan de lootcrates recibirán una selección de productos en función del tipo de alcohol (ron, ginebra, vodka, whisky).


Añadidos que no fueron contemplados en la propuesta inicial:

- Ver distintos atributos del productos en función de su tipo.

- Que los proveedores no tengan carrito y que al iniciar sesión como proveedor no tengan la opción.

- Las lootcrates no se podrán comprar, por lo tanto no tendrán la opción de añadir al carrito.

- Pagina de Informacion sobre la empresa: Donde cualquier visitante puede ver donde se encuentra situada la empresa.

- Pagina de contacto con las diferentes redes socliales de la empresa.

- Utilización de mandar emails autogenerados, para recuperar la contraseña.

- Uso de ajax y bootstrap para la implementación y diseño de la Aplicación Web.


#### Cambios en las EN:

##### EN Publicas:

- Productos
- Lootcrates
- Support (Soporte)
- Suggerst (Sugeencias)
- Bottellas
- Packs

##### EN Privadas:

- User (Usuario)
- Provider (Proveedor)
- Cart (Carrito)
- Order (Pedidos Realizados)
- Rating (Comentarios y Valoración)

### Dificultades Encontradas:

- Visual Studio a veces comete fallos: A veces no muestra la base de datos, te pone errores en lineas donde no existen errores, etc.

- En una de las páginas no funcionaba el paso de las palabras a utf-8: Arreglado en web.config añadiendo lineas para obligar el funcionamiento.

- Los validadores de asp generaban un fallo de ejecución de ScripMapping por culpa del jquery que se usa en bootstrap: Arreglado en el web.config añadiendo codigo para que desaparezca el fallo.

### Dificultades con Personas:

- Ninguna, todos han cumplido tanto con los plazos de entrega, como con los objetivos que se les daba, ademas informaban e algunas dificultades que podian tener con el codigo para que ayudaran los demas y avisban con antelación por si habia algun problema al quedar el grupo entero.

### Problemas de Planificación:

- Tener la semana santa en mitad del proyecto fue un problema (por suerte menor), ya que es tiempo de descanso y algunas personas pasan unas vacaciones con familia fuera de Alicante.

- En la última entrega se dispone de poco tiempo para implementar la parte final de un proyecto de esta envergadura (poco mas de 20 días).


### Tabla de actividad:
- GRP5_GRP1_AMARON/Tabla_Actividades_Amaron.docx







