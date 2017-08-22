﻿namespace Gu.Wpf.UiAutomation.Identifiers
{
    using System;

    /// <summary>
    /// Base class for identifiers which are convertible
    /// </summary>
    public abstract class ConvertibleIdentifierBase : IdentifierBase
    {
        private Func<AutomationBase, object, object> converterMethod;

        protected ConvertibleIdentifierBase(int id, string name)
            : base(id, name)
        {
        }

        /// <summary>
        /// Sets a custom convert method to convert the values for this id
        /// </summary>
        protected T SetConverter<T>(Func<AutomationBase, object, object> convertMethod) where T : ConvertibleIdentifierBase
        {
            this.converterMethod = convertMethod;
            return (T)this;
        }

        /// <summary>
        /// Converts the given value with the converter or casts it, if no converter is given
        /// </summary>
        public T Convert<T>(AutomationBase automation, object value)
        {
            return this.converterMethod == null ? (T)value : (T)this.converterMethod(automation, value);
        }
    }
}
