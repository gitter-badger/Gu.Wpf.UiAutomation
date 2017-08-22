﻿namespace Gu.Wpf.UiAutomation.UIA3
{
    using Gu.Wpf.UiAutomation.Conditions;
    using Gu.Wpf.UiAutomation.UIA3.Converters;

    public class UIA3TreeWalkerFactory : ITreeWalkerFactory
    {
        private readonly UIA3Automation automation;

        public UIA3TreeWalkerFactory(UIA3Automation automation)
        {
            this.automation = automation;
        }

        public ITreeWalker GetControlViewWalker()
        {
            var nativeTreeWalker = this.automation.NativeAutomation.ControlViewWalker;
            return new UIA3TreeWalker(this.automation, nativeTreeWalker);
        }

        public ITreeWalker GetContentViewWalker()
        {
            var nativeTreeWalker = this.automation.NativeAutomation.ContentViewWalker;
            return new UIA3TreeWalker(this.automation, nativeTreeWalker);
        }

        public ITreeWalker GetRawViewWalker()
        {
            var nativeTreeWalker = this.automation.NativeAutomation.RawViewWalker;
            return new UIA3TreeWalker(this.automation, nativeTreeWalker);
        }

        public ITreeWalker GetCustomTreeWalker(ConditionBase condition)
        {
            var nativeCondition = ConditionConverter.ToNative(this.automation, condition);
            var nativeTreeWalker = this.automation.NativeAutomation.CreateTreeWalker(nativeCondition);
            return new UIA3TreeWalker(this.automation, nativeTreeWalker);
        }
    }
}
