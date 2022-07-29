namespace SharpTrigger
{
    /// <summary>
    /// Base implementation of <see cref="ITrigger"/> with no parameter values (for parameter values, use <see cref="Trigger{T1, T2, T3, T4}"/>). A <see cref="Trigger"/> is created by assigning it an <see cref="Action"/> and can only be fired once unless reloaded through <see cref="Reload"/>. 
    /// </summary>
    public class Trigger : ITrigger
    {
        Action? trigger;
        protected bool hasFired;
        protected bool hasDelegate;

        public virtual bool HasDelegate { get { return hasDelegate = trigger != null && trigger.Method != null; } }
        public bool HasFired { get { return hasFired; } }

        protected static Trigger Init(Action method)
        {
            return new Trigger() { trigger = method, hasFired = false };
        }

        /// <summary>
        /// Returns a new <see cref="Trigger"/> from <paramref name="a"/>
        /// </summary>
        /// <param name="a">Method</param>
        public static implicit operator Trigger(Action a) => Init(a);

        /// <summary>
        /// Returns the stored <see cref="Action"/> of <see cref="Trigger"/>
        /// </summary>
        /// <param name="t">Trigger to return</param>
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
            if(GetType().IsSubclassOf(typeof(Trigger)))
            {
                throw new InvalidOperationException("This Trigger requires explicit parameters");
            }

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

    public class Trigger<T1> : Trigger
    {
        Action<T1> trigger;
        public override bool HasDelegate { get { return hasDelegate = trigger != null && trigger.Method != null; } }


        protected static Trigger<T1> Init(Action<T1> method)
        {
            return new Trigger<T1>() { trigger = method, hasFired = false };
        }

        public static implicit operator Trigger<T1>(Action<T1> a) => Init(a);
        public static implicit operator Action<T1>(Trigger<T1> t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("Trigger is null");
            }
            return t.trigger;
        }


        public void Fire(T1 obj)
        {
            if (hasFired == false)
            {
                try
                {
                    trigger.Invoke(obj);
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
    }

    public class Trigger<T1, T2> : Trigger
    {
        Action<T1, T2> trigger;

        public override bool HasDelegate { get { return hasDelegate = trigger != null && trigger.Method != null; } }

        protected static Trigger<T1, T2> Init(Action<T1, T2> method)
        {
            return new Trigger<T1, T2>() { trigger = method, hasFired = false };
        }

        public static implicit operator Trigger<T1, T2>(Action<T1, T2> a) => Init(a);
        public static implicit operator Action<T1, T2>(Trigger<T1, T2> t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("Trigger is null");
            }
            return t.trigger;
        }

        public void Fire(T1 obj, T2 obj2)
        {
            if (hasFired == false)
            {
                try
                {
                    trigger.Invoke(obj, obj2);
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
    }

    public class Trigger<T1, T2, T3> : Trigger
    {
        Action<T1, T2, T3> trigger;

        public override bool HasDelegate { get { return hasDelegate = trigger != null && trigger.Method != null; } }

        protected static Trigger<T1, T2, T3> Init(Action<T1, T2, T3> method)
        {
            return new Trigger<T1, T2, T3>() { trigger = method, hasFired = false };
        }

        public static implicit operator Trigger<T1, T2, T3>(Action<T1, T2, T3> a) => Init(a);
        public static implicit operator Action<T1, T2, T3>(Trigger<T1, T2, T3> t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("Trigger is null");
            }
            return t.trigger;
        }

        public void Fire(T1 obj, T2 obj2, T3 obj3)
        {
            if (hasFired == false)
            {
                try
                {
                    trigger.Invoke(obj, obj2, obj3);
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
    }

    public class Trigger<T1, T2, T3, T4> : Trigger
    {
        Action<T1, T2, T3, T4> trigger;

        public override bool HasDelegate { get { return hasDelegate = trigger != null && trigger.Method != null; } }

        protected static Trigger<T1, T2, T3, T4> Init(Action<T1, T2, T3, T4> method)
        {
            return new Trigger<T1, T2, T3, T4>() { trigger = method, hasFired = false };
        }

        public static implicit operator Trigger<T1, T2, T3, T4>(Action<T1, T2, T3, T4> a) => Init(a);
        public static implicit operator Action<T1, T2, T3, T4>(Trigger<T1, T2, T3, T4> t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("Trigger is null");
            }
            return t.trigger;
        }

        public void Fire(T1 obj, T2 obj2, T3 obj3, T4 obj4)
        {
            if (hasFired == false)
            {
                try
                {
                    trigger.Invoke(obj, obj2, obj3, obj4);
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
    }
}