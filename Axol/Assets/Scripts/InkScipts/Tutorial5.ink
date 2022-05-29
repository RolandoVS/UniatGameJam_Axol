EXTERNAL Name(charName)
EXTERNAL Img(nameImg)
EXTERNAL ImgR(nameImgR)
VAR Culpa = 0

 {Img("Alicia")}
 {ImgR("Jose")}
 {Name("Alicia")}
Estando cerca de José podía sentir una vibra de tranquilidad y todo lo que hacía con él era más tranquilo y ameno.. siempre se preocupaba por mi y aunque no me lo decía siempre, podía ver en su cara cuando una decisión mía no le agradaba tanto. Era fácil leer sus expresiones porque es como un libro abierto. Cuando salíamos para pasar el rato, podíamos estar horas sin hablar, solo disfrutando de la compañía del otro y viendo la naturaleza que nos rodeaba.
 {ImgR("")}
pero ya es tarde y nadie vino… creí que yo era especial para ellos, creí que después de todos estos años harían un espacio para mí, es triste saber que no les importo a mis amigos.
 {Name("???")}
grrrr
 {Name("Alicia")}
¿quién eres tú?
 {Name("???")}
grrr...
Soy...
 {ImgR("Tridimin")}
 {Name("Tridimin")}
Tridimin…
 {Name("Alicia")}
¿qué quieres?
 {Name("Tridimin")}
me entere...
que es tu cumpleaños…. 
y vengo a concederte un deseo...
 {Name("Alicia")}
un deseo?
 {Name("Tridimin")}
 si un deseo de cumpleaños
  {Name("Alicia")}
¿por qué?
  {Name("Tridimin")}
me entere que estás sola y que tus amigos te abandonaron…. 
   {Name("Alicia")}
 ellos no me abandonaron.
   {Name("Tridimin")}
enserio? acaso Ana no se quedó sola por que tu empezaste a hablarle?
* si, creo que el hablarle hizo que más gente la rechazara.
 {Name("Alicia")}
 ~Culpa= Culpa + 1
 ->P2
* no, ella ya vivía sola desde antes que le hablara, por eso me acerqué.
 {Name("Alicia")}
->P2

===P2===
   {Name("Tridimin")}
y luis? acaso no le quitaste tiempo preciado de su vida para estar contigo?
* si, creo que él pudo llegar mucho más lejos si ese tiempo lo hubiera invertido en sus actividades.
 {Name("Alicia")}
 ~Culpa= Culpa + 1
 ->P3
* no, yo no le pedí que lo hiciera, él me ofreció su tiempo y eso me hizo muy feliz.
 {Name("Alicia")}
 ->P3
 
 ===P3===
    {Name("Tridimin")}
 y que me dices de estefania? acaso no tuvo que ser más condescendiente contigo mientras estaban en la escuela, eso pudo costarle su puesto de presidenta estudiantil...
 * si, creo que no se la puse fácil y muchas veces me aproveche de su estatus para salirme con la mía.
  {Name("Alicia")}
 ~Culpa= Culpa + 1
 ->P4
* no, ella siempre quiso ayudarme a ser una mejor versión de mi, era estricta conmigo pero eso me alegraba porque sabía que se preocupaba por mi.
 {Name("Alicia")}
->P4

===P4===
    {Name("Tridimin")}
por último el pobre José, crees que todo su tiempo que pasó contigo lo hizo sin esperar obtener nada a cambio?...
* si, creo que el tiempo que me dedicó solo era porque buscaba algo más de mi, nunca fue mi amigo.
 {Name("Alicia")}
 ~Culpa= Culpa + 1
->EvalOpc
* no, él es un amigo de verdad me entiende, se toma el tiempo de escucharme, él no haría algo así.
 {Name("Alicia")}
->EvalOpc

===EvalOpc===
{
-Culpa >= 2:
->MuertePreguntas
- else:
->SigMundo
}

===MuertePreguntas==
    {Name("Tridimin")}
lo ves no mereces su compañía… no mereces a nadie
    {Name("")}
    {Img("")}
Tridimin produce un grito horrendo 
GAME OVER
->END

===SigMundo===
 {Name("Alicia")}
Mientes… tu no sabes nada de ellos, ni de mi, ellos siempre me acompañan y me apoyan
 {Name("Tridimin")}
ah sí? pues yo no los veo por aquí…. dime ¿qué es lo que más deseas?
 {Name("Alicia")}
Solo quiero que mis amigos se queden conmigo
->END