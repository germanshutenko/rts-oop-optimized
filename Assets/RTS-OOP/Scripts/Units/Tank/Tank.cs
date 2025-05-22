namespace RtsOop
{
    public class Tank : BaseUnit
    {
        private void Awake()
        {
            var monoProvider = CompositionRoot.GetMonoProvider();

            UnitBehaviour = new TankBehaviour(this, monoProvider);
        }
    }
}