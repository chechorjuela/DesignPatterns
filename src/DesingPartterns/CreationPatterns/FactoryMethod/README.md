# Factory Method

Permite la creacion de objectos de un subtipo determinado atraves de una clase factory. Esto es epecialmente util cuando no sabemos, en tiempo de diseño, el subtipo dque vamos a utilizar o cuando queremos delegar la logica de la creacion de los objectos a una clase factory. Utilizando este patron podemos crear instancias dinamicamente mediante la configuracion, estableciendo cual sera la implementacion a utilizar en un archivo de texto, XML, properties o mediate cualquier otra estrategia.

### Componentes que conforman el patron:
1. IProdcut:
    * Repressenta de forma abstract el objecto que queremos crear. mediante esta interface define la estructura que tendra el objecto.

2. ConcreteProcucto:
    * Representa de una implementacion concreta de la interface <small>IProduct</small>, la cual es creada atravez del <small>ConcreteFactory</small>.

3. AbstractFactory: (Opcional)
    * Se recomienda la creacion de un <small>AbstractFactory</small> que defina el comportamiento por default de los <small>ConcreteFactory</small>.

4. ConcreteFactory:
    * Representa una fabrica concreta la cual es utilizada para la creacion de los <small>ConcreteProduct</small>, esta clase hereda el comportamiento basico de <small>AbstractFactory</small>

    

El patrón Factory Method se implementa cuando necesitas crear objetos pero no sabes exactamente qué clase concreta necesitas hasta el momento de la creación. Aquí hay algunas situaciones comunes en las que podría ser apropiado utilizar el patrón Factory Method:

1. Cuando la creación de un objeto requiere lógica compleja: Si la creación de un objeto implica la evaluación de ciertas condiciones o la ejecución de lógica compleja, el Factory Method puede encapsular esta lógica en una clase dedicada, permitiendo una mejor organización del código.

2. Cuando quieres desacoplar el código que usa el objeto de su implementación: El Factory Method permite que el código cliente no dependa de las clases concretas, sino que dependa de una interfaz común o una clase base. Esto facilita la sustitución de implementaciones concretas sin cambiar el código cliente.

3. Cuando quieres extender la creación de objetos: El Factory Method facilita la extensión del código para admitir nuevos tipos de objetos. Simplemente tienes que crear una nueva clase de fábrica que implemente la interfaz del Factory Method y proporcione la lógica para crear el nuevo tipo de objeto.

4. Cuando deseas centralizar la lógica de creación: Si tienes múltiples lugares en tu código donde se crea un tipo particular de objeto, puede ser beneficioso centralizar esa lógica de creación en una sola clase o método. El Factory Method proporciona una forma de hacer esto.

En resumen, el patrón Factory Method se utiliza cuando necesitas flexibilidad en la creación de objetos, desacoplamiento entre el código cliente y las implementaciones concretas, extensibilidad y centralización de la lógica de creación.