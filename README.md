# carce-api-cqrs
Prueba tecnica de Desarrollador .NET para Tekton
## Patrones de diseño usados 
1. CQRS (Command Query Responsability Segregation)
2. DDD (Domain Driven Design) orientado a microservicios
3. TDD (Test Driven Design)
4. IoC (Inversion of Control)

## Consideraciones

1. El proyecto esta desarrollado en VS2022 
2. El metodo de persistencia usado es una clase hardcodeada que emula un contexto de Productos
3. La pagina principal del proyecto es "https://localhost:7024/swagger/index.html"
4. La API donde se obtiene los descuentos es "https://659f9a795023b02bfe89fa19.mockapi.io/api/v1/discounts"
5. Para levantar la API setear  CARCE.API como proyecto de inicio y lanzar
