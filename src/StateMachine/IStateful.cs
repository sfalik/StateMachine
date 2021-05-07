namespace StateMachine
{
    public interface IStateful<TState, TEvent>
    {
        public TState[] States { get; }
        public TState State { get; }

        public TEvent[] Events { get; }

        public (bool, TState) IsEventAccepted(TEvent data);

        public TState TriggerEvent(TEvent data);
    }
}
