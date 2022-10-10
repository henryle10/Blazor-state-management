namespace State_Management_with_Flux.Stores.CounterStore
{
    public class DecrementAction : IAction
    {
        public const string DECREMENT = "DECREMENT";

        public string Name => DECREMENT;
    }
}
