namespace State_Management_with_Flux.Stores
{
    public interface IActionDispatcher
    {
        void Dispatch(IAction action);

        void Subscript(Action<IAction> actionHandler);

        void Unsubscript(Action<IAction> actionHandler);
    }
}
