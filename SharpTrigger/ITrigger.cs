namespace SharpTrigger
{
    /// <summary>
    /// Interface containing comments
    /// </summary>
    internal interface ITrigger
    {
        /// <summary>
        /// Whether this <see cref="ITrigger"/> instance has an assigned Delegate
        /// </summary>
        bool HasDelegate { get; }
        /// <summary>
        /// Whether this <see cref="ITrigger"/> instance has fired
        /// </summary>
        bool HasFired { get; }

        /// <summary>
        /// Fires the <see cref="ITrigger"/> if <see cref="HasFired"/> is <see langword="false"/>
        /// </summary>
        void Fire();
        /// <summary>
        /// Reloads the <see cref="ITrigger"/> instance to re-enable <see cref="ITrigger.Fire"/>
        /// </summary>
        void Reload();
    }
}