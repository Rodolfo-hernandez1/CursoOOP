# Pasos para instalar el ambiente de desarrollo

## 1) Instalación de dotnet core 2.2.

.NET Core es una versión multi-plataforma y de código libre de .NET. Se incluyen bibliotecas para programar sitios web, servicios web y aplicaciones de consola. El lenguaje de programación nativo es C#.

Como primer paso vamos a instalar el SDK de .NET Core versión 2.2, el cual puedes bajar directamente de 
(https://www.dotnet.microsoft.com) 


![](https://i.ibb.co/CzvCmqP/imaganes.png)

Elige la instalación para tu sistema operativo y arquitectura (64 o 32 bits).

El framework, incluye un programa de línea de comandos (en inglés CLI) llamado dotnet con el cual vamos a administrar nuestro código y los ejecutables de .NET.

Vamos a revisar que esté instalado, para esto abre una terminal. 

En windows se tienen cmd.exe y Power Shell, en macOS y Linux tenemos la Terminal.
![](https://i.ibb.co/DzQVhzL/70450377-381802915821950-6392093852613738496-n-1.png)
Al ejecutar el comando debemos ver un listado de los que tenemos instalado localmente.


## 2) Instalación y configuración de Visual Studio Code para C#.

Aunque vamos a utilizar el comando dotnet para la gestión de nuestros proyectos necesitamos un editor de texto para la edición de nuestro código. 

Un buena opción el editor Visual Studio Code el cual es un editor desarrollado por Microsoft con extensiones para programar en C# y muchos otros lenguajes. Lo bajamos de https://code.visualstudio.com

![](https://i.ibb.co/R6TnsT9/71482348-2397360733835594-2914116992300482560-n.png)

Una vez descargado lo configuramos para el lenguaje de programacion C# y es dodne realizaremose la escritura de nuestro codigos.

![](https://i.ibb.co/DpzTVj0/70883477-706122739854394-7935259702097608704-n.png)


## 2) Instalación de git. conectado a tu cuenta de GitHub y VSC.


Para poder utilizar GitHub de manera remota debemos instalar GIT para eso ingresamos a https://git-scm.com/downloads y lo instalamos para nuestro sistema operativo.

![](https://i.ibb.co/NTM0Z4n/70193355-2415646155221317-8711569234053824512-n.png)


Una vez descargado e instalado debemos configurarlo para poder trabajar directamente desde Visual Studio Code para eso debemos clonar nuestro Repositorio ya creado despues abrir una paleta de comando ingresar el codigo git clone e instertar el URL de nuestro repositorio despues nos pedira que eligamos la ubicacion de los archivos que se crearan. Listo podremos realizar cambios de manera remota.


![](https://i.ibb.co/gwZMXHb/70683250-497110434400659-433213611477827584-n.png)