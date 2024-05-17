//* Exploración de la conversión y la coerción de tipos de datos en C#

/*


    Existen varias tecnicas para llevar a cabo la conversion de datos
    y escogemos la tecnica correcta en base a la respuesta de dos importantes
    preguntas: 

    - En funcion del valor, ¿es posible que el intento de cambiar el 
    tipo de datos del valor produzca una excepcion en 
    tiempo de ejecución?

    - En funcion del valor, ¿es posible que el intento
    de cambiar de tipo de datos provoque una perdida
    de la información?

    Para realizar la conversión de datos, puede emplear varias técnicas:

        - Usar un método auxiliar en el tipo de datos.
        - Usar un método auxiliar en la variable.
        - Uso de los métodos de la clase Convert

    El termino "conversion de amplificacion" indica que estamos 
    convirtiendo un tipo de datos que contiene menos informacion en 
    otro tipo de datos que puede contener mas informacion, por ejemplo
    un tipo de dato int convertido a decimal, cuando se sabe que
    se realizara una conversion de amplificacion podemos confiar en
    la conversion implícita [ El compilador controla las conversiones implícitas ]. 

    ///* Ejemplo de conversion implicita
    int myInt = 3; 
    Console.WriteLine($"int {myInt}");

    decimal myDecimal = myInt;
    Console.WriteLine($"decimal: {myDecimal}");


    ///? Conversion de restriccion
    el termino "conversion de restriccion" refiere a cuando se intenta
    convertir un tipo de datos que podria contener mas informacion
    en uno que podria contener menos, resultando en perdida de informacion y precision,
    cuando sabemos que vamos a llevar a cabo una conversion de restriccion
    utilizamos la tecnica de "coerción" la cual utiliza una instruccion
    para indicarle al compilador de C# que usted sabe que es posible
    que se pierda precision, pero esta dispuesto a aceptarlo.

    ///? Realizacion de una "coerción"
    para realizar una coerción se usa el operador de coerción "()"
    para encerrar un tipo de datos y se coloca junto a la variable 
    que se quiere convertir (ejemplo: (int)myDecimal). 
    Se realiza una conversión explícita al tipo de
    datos de coerción definido (int).

    ///* Ejemplos de coerción y conversion de restriccion

    decimal myDecimal = 3.14m;
    Console.WriteLine($"decimal: {myDecimal}");

    int myInt = (int)myDecimal;
    Console.WriteLine($"int: {myInt}");


    .- output
    ///decimal: 3.14
    ///int: 3

    decimal myDecimal = 1.23456789m;
    float myFloat = (float)myDecimal;

    Console.WriteLine($"Decimal: {myDecimal}");
    Console.WriteLine($"Float  : {myFloat}");

    .- output
    Decimal: 1.23456789
    Float  : 1.2345679
*/


string value = "3231";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else 
{
    Console.WriteLine($"Unable to report the measurement.");
}

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");