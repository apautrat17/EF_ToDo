

void Ajouter(string task, bool complete){
    using (var context = new TodoContext()){
            var todo1 = new Todo{
            Task = task,
            Completed = complete
            };
            context.Todo.Add(todo1);
            context.SaveChanges();
        }
}

// Ajouter("Passer la tondeuse (encore)", false);


void Supprimer(int id){
    using (var context = new TodoContext()){
            var tododel = context.Todo.Find(id);
        if (tododel != null){
            context.Todo.Remove(tododel); 
            context.SaveChanges();
        }
    }
}

// Supprimer(3);


void LireTodos(){
    using (var context = new TodoContext()){
        var todos = context.Todo.ToList();  // Récupérer tous les éléments
        foreach (Todo todo in todos){
            Console.WriteLine($"Id = {todo.Id}, Task = {todo.Task},  State = {todo.Completed}");
        }
    }
}

LireTodos();

    


    




