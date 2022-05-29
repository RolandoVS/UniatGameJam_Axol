EXTERNAL Name(charName)
EXTERNAL Img(nameImg)
EXTERNAL ImgR(nameImgR)

//Img Names:  Alicia, Ana, Luis, Estefania, Jose y Tridimin
{Name("?")}
{Img ("0")}
Esta es una linea de dialogo, que podra contener poco mas de 444 caracteres
{Name("Dios")}
{Img("")}
{ImgR("")}
Las lineas verdes son las funciones especiales, para cambiar el nombre se le cambia entre las comillas a el deseado
Para cambiar la imagen hay que tenerla en Resources>Characters y poner el nombre de la imagen(sin extencion) entre las comillas despues de Img, si se deja "" se esconde el panel de imagen, ImgR es la imagen a la derecha
A continuacion se muestran 2 elecciones, al tener el formato de la primera se mostrara el texto despues del asterisco en el boton y en la caja de dialogo, posteriormente se mostrara el dialogo de Elegiste la opcion 1. Al tener el formato de la segunda, solo se mostrara el texto entre las llaves en el boton y en la caja de dialogo solo se mostrara Elegiste opcion 2
* This is a choice that can only be chosen once
Elegiste opcion 1
* [A choice where the content isn't printed after choosing]
Elegiste opcion 2
Se pueden crear diferentes cadenas, de manera que segun la eleccion que tome a lo largo del juego los dialogos sean totalmente diferentes