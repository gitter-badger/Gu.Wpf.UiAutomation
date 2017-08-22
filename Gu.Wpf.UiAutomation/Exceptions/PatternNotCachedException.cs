﻿namespace Gu.Wpf.UiAutomation.Exceptions
{
    using System;
    using System.Runtime.Serialization;
    using Gu.Wpf.UiAutomation.Identifiers;

    [Serializable]
    public class PatternNotCachedException : NotCachedException
    {
        private const string DefaultMessage = "The requested pattern is not cached";
        private const string DefaultMessageWithData = "The requested pattern '{0}' is not cached";

        public PatternNotCachedException() : base(DefaultMessage)
        {
        }

        public PatternNotCachedException(PatternId pattern)
            : base(String.Format(DefaultMessageWithData, pattern))
        {
            this.Pattern = pattern;
        }

        public PatternNotCachedException(string message, PatternId pattern)
            : base(message)
        {
            this.Pattern = pattern;
        }

        public PatternNotCachedException(PatternId pattern, Exception innerException)
            : base(String.Format(DefaultMessageWithData, pattern), innerException)
        {
            this.Pattern = pattern;
        }

        public PatternNotCachedException(string message, PatternId pattern, Exception innerException)
            : base(message, innerException)
        {
            this.Pattern = pattern;
        }

        protected PatternNotCachedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            this.Pattern = (PatternId)info.GetValue("Pattern", typeof(PatternId));
        }

        public PatternId Pattern { get; }

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
