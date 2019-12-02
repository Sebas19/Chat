# Chat

## Estructura y Funcionamiento
La estructura del la aplicacion es la siguiente:

- Form1 Form principal donde se ingresa el Nick que usara el Usuario en la Aplicacion y se tiene boton para ingresar a la Parte de Admistracion que se solicito

  - Funcionamiento: Se tienen dos opciones ingresar un nick en el textbox que se tiene el form e ingresar al lobby o dar al boton de Adminitracion que te llevara al form de Administracion. Como se solicito si se ingresa un Nick ya existente y este marca un error de que usario invalido y se tendra que seleccionar un nuevo nick para ingresar. Una vez que se ingresa un Nick valido se vera un listview con todas las salas que existen actualmente y se dara la opcion al usuario de seleccionar una sala de la lista e ingresar con el boton de Login in Room , Crear una nueva sala usando el Textbox que aparece y crear una nueva sala con ese nombre dando click en el boton de Create Room o ir a la adminitracion. Si crea una nueva sala o ingresa a una existente se abrira el Form ChatRoom en caso de selecionar Administracion se abrira el form de Administracion.

- ChatRoom Form para sala de chat donde ya prodra mandar mensaje, se compone de un panel en el que se puso un RichtBox para escribir los mensajes que los usuarios mandan , una listview donde se ven los usuarios conectados en dicha sala , un botton  de send para mandar un mensaje, un boton para salir de la sala y un texbox donde se escribira el mensaje que se desea mandar.

- Adminitracion Form de Adminitracion en el que aparece un boton que te abrira un form donde se listaran todos los usuario que se an registrado en la aplicacion.

- DetailsForm Form donde se veran todos los usuario registrados en la aplicacion.
  - Funcionamiento: Se seleccionara un usario de lista que se muestra y dar click en el boton de Details para que este abra el form de listar todas las salas en la que el usuario a entrado.

- ListUsers Form donde se veran todas las salas en el que un usario a ingresado.
  - Funcionamiento: Se seleccionara una sala de chat de lista que se muestra y dar click en el boton de Details para que este abra el form de listar todos los mensajes que el usuario a mandado.

- Para la base de datos se adjunto scrip para creacion , en este caso se hizo una base de datos basica que consta de 3 tablas.
  - Users:
    - id int (auto incremental)
    - nick varchar (Nick del usuario que ingreso )
    - connec bit (se usa para verificar si el usuario esta conectado , true para conectado y false para desconectado)
  - Room:
    - id  int (auto incremental)
    - name varchar (Nombre de la sala de chat)
    - users int (Users sirve para llevar un conteo de cuanto usuarios estan conectados en esa sala en caso de se llegar a 0 ya no se tomara en cuanta en la aplicacion)
  - Message (Esta tabla se creo para poder almacenar todos los mensaje que son enviados en la aplicacion):
    - id int (auto incremental)
    - idUser int (llave foranea para identificar que usuario mando el mensaje)
    - idRoom int (llave foranea para indentificar en que sala de chat se envio)
    - text varchar (el mensaje que se envio en el chat )