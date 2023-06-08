namespace tareas;

public class tarea {
    private int tareaID;
    private string? descripcion;
    private int duracion;

    public int TareaID { get => tareaID; set => tareaID = value; }

    private string[] descripciones = {"Limpiar el piso", "Lavar los platos", "Cocinar"};

    public tarea(int id, int a, int b){
        tareaID = id;
        descripcion = descripciones[a];
        duracion = b;
    }
    public string? Descripcion { get => descripcion;}
    public int Duracion { get => duracion;}
}

