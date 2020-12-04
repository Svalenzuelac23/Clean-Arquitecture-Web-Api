# Clean-Arquitecture-Web-Api
Plantilla de Web API con Clean Arquitecture


![image](https://netsharpdev.com/images/posts/shape.png)


# 01. Domain
Todo lo relacionado a tus modelos de dominio del negocio. Esta capa no debe tener relacion con ninguna otra capa.

# 02. Application (Core)
Aca se centra toda la logica del negocio, todo lo que la app necesita para funcionar, Interfaces, Exceptiones del negocio, modelos de respuesta, logica del negocio (servicios, que para este ejemplo es el patron CQRS)

# 03. Persistencia
Tu logica de base de datos, tu conexion al proveedor de base de datos, y la implementacion de las interfaces de la capa Core.

# 04. Infraestructure
Todo lo que no esta a nuestro control, consumo de apis externas, mapeos, validaciones o uso de paquetes o productos externos.

# 05. Api
Esta es la capa final o capa de presentacion, es la que se expondra al cliente y con el cual tendra una interaccion.


