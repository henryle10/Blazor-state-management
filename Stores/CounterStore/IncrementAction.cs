namespace State_Management_with_Flux.Stores.CounterStore
{
    public class IncrementAction : IAction
    {
        public const string INCREMENT = "INCREMENT";

        public string Name => INCREMENT;

        public int Count { get; set; }
    }
}
