# registro-estudiantes

Este desarrollo fue creado en el backend con C# .NET Framework con EntityFramework y EF First Code, y en las vista Angula 8 consumiendo el web api.

## Instalacion

Para poder correr la vista en Angular es necesarion instalar la paqueteria de node con

```bash
npm i
```

## Uso
Para el uso de este servicio es necesario correr el programa en Visual Studio y ejecutarlo ya que a traves de este se consulta la base de datos y se envian los datos hacia la vista.
Encuanto a la vista es necesario ejecutar el servidor de Angular con 

```bash
ng serve
```

## Usuarios
Los usuario autorizados para poder ver el listado de los registros son:
```json
administrativos = [
    {
      email:'admin@uam.com',
      password: '1234'
    },
    {
      email:'jhon@uam.com',
      password: '1234'
    }
  ]
```
y se encuentran en la siguiente ruta:
```bash
./src/app/components/lista-estudiantes/lista-estudiantes.component.ts
``` 
como un array de objetos

## License
[MIT](https://choosealicense.com/licenses/mit/)