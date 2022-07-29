namespace SharpTrigger
{
    /// <summary>
    /// Base implementation of <see cref="ITrigger"/> with no parameter values. A <see cref="Trigger"/> is created by assigning it an <see cref="Action"/> and can only be fired once unless reloaded through <see cref="Reload"/>. 
    /// </summary>
    public class Trigger : ITrigger
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
        public static implicit operator Action(Trigger t)
        {
            if(t == null)
            {
                throw new ArgumentNullException("Trigger is null");
            }
            return t.trigger;
        }

        public virtual void Fire()
        {
            if (hasFired == false)
            {
                try
                {
                    trigger.Invoke();
                }
                catch (Exception ex)
                {
                    if (HasDelegate == false) throw new InvalidOperationException("Trigger does not have Delegate");
                }
                finally
                {
                    hasFired = true;
                }
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