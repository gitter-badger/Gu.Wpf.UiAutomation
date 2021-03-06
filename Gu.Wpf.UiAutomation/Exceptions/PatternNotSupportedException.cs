﻿namespace Gu.Wpf.UiAutomation
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class PatternNotSupportedException : NotSupportedException
    {
        private const string DefaultMessage = "The requested pattern is not supported";
        private const string DefaultMessageWithData = "The requested pattern '{0}' is not supported";

        public PatternNotSupportedException()
            : base(DefaultMessage)
        {
        }

        public PatternNotSupportedException(PatternId pattern)
            : base(string.Format(DefaultMessageWithData, pattern.Name))
        {
            this.Pattern = pattern;
        }

        public PatternNotSupportedException(string message, PatternId pattern)
            : base(message)
        {
            this.Pattern = pattern;
        }

        public PatternNotSupportedException(PatternId pattern, Exception innerException)
            : base(string.Format(DefaultMessageWithData, pattern.Name), innerException)
        {
            this.Pattern = pattern;
        }

        public PatternNotSupportedException(string message, PatternId pattern, Exception innerException)
            : base(message, innerException)
        {
            this.Pattern = pattern;
        }

        protected PatternNotSupportedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            this.Pattern = (PatternId)info.GetValue("Pattern", typeof(PatternId));
        }

        public PatternId Pattern { get; }

        /// <inheritdoc/>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            info.AddValue("Pattern", this.Pattern);
            base.GetObjectData(info, context);
        }
    }
}
