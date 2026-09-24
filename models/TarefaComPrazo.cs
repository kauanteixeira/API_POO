public class TarefaComPrazo : Tarefa
{
    DateTime? Time;
    DateTime Conclusion = DateTime.Now;
    bool CompletedWithDelay;
    public override void Complete()
    {
        
    }
}