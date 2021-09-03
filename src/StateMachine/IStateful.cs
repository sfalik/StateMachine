namespace StateMachine
{
    public interface IStateful<TState, TEvent>
    {
        public TState[] States { get; }
        public TState State { get; }

        public TEvent[] Events { get; }

        public bool IsEventAccepted(TEvent data, out TState newState);

        public TState TriggerEvent(TEvent data);
    }
}
