namespace RtsOop
{
    public class TankBehaviour : IUnitBehaviour, IUpdatable
    {
        private enum EStates
        {
            Idle,
            Moving,
        }

        private EStates CurrentState;
        private IUnitComponents Components;

        public TankBehaviour(IUnitComponents components, IMonoProvider monoProvider)
        {
            Components = components;

            monoProvider.Add(this);

            CurrentState = EStates.Idle;
        }

        public void Update(float deltaTime)
        {
            switch (CurrentState)
            {
                case EStates.Idle:

                    break;

                case EStates.Moving:
                    Components.Mover.Move(deltaTime);
                    break;
            }
        }

        public void Run()
        {
            CurrentState = EStates.Moving;
        }

        public void Stop()
        {
            CurrentState = EStates.Idle;
        }
    }
}