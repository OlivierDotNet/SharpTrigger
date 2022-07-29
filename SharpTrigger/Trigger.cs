namespace SharpTrigger
{
    public class Trigger
    {
        Action? trigger;
        protected bool hasFired;

        public virtual bool HasDelegate { get { return trigger != null && trigger.Method != null; } }
        public bool HasFired { get { return hasFired; } }


        protected static Trigger Init(Action method)
        {
            return new Trigger() { trigger = method, hasFired = false };
        }

        public static implicit operator Trigger(Action a) => Init(a);
        public static implicit operator Action(Trigger t) => t.trigger;


        public virtual void Fire()
        {
            if (hasFired == false)
            {
                trigger.Invoke();
                hasFired = true;
            }
        }

        public void Reload()
        {
            if ((hasFired == false && HasDelegate == false) || HasDelegate == false)
            {
                throw new InvalidOperationException("Trigger must have Delegate before reload!");
            }
            hasFired = false;
        }
    }
}