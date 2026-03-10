namespace Command;

public class RemoteControl
{
    private readonly Stack<ICommand> _history = new();

    public void Press(ICommand command)
    {
        command.Execute();
        _history.Push(command);
    }

    public void PressUndo()
    {
        if (_history.Count > 0)
            _history.Pop().Undo();
        else
            Console.WriteLine("Nothing to undo.");
    }
}