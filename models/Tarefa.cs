public abstract class Tarefa
{
    private int Id;
    private string Title;
    protected bool Completed;

    public abstract void Complete();
}