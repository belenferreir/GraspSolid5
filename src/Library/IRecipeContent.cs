public interface IRecipeContent
{
    string GetTextToPrint();
}

//Esta interfaz cumple con el principio SOLID ya que promueve la dependencia de abstracciones
//las clases de alto y bajo nivel ahora dependen de esta interfaz y no de Recipe
//con esto logramos que si se modifica Recipe no se vean afectas otras clases.