public class Todo{
    public int Id{get;set;}
    public string? Task{get;set;}
    public bool Completed{get;set;}

    public Todo(int id, string tache, bool completed){
        Id=id;
        Task=tache;
        Completed=completed;
    }
}