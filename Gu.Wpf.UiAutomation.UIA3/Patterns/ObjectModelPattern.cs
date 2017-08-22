﻿using Gu.Wpf.UiAutomation;
using Gu.Wpf.UiAutomation.Identifiers;
using Gu.Wpf.UiAutomation.Patterns;
using Gu.Wpf.UiAutomation.Patterns.Infrastructure;
using Gu.Wpf.UiAutomation.Tools;
using Gu.Wpf.UiAutomation.UIA3.Identifiers;
using UIA = Interop.UIAutomationClient;

namespace Gu.Wpf.UiAutomation.UIA3.Patterns
{
    public class ObjectModelPattern : PatternBase<UIA.IUIAutomationObjectModelPattern>, IObjectModelPattern
    {
        public static readonly PatternId Pattern = PatternId.Register(AutomationType.UIA3, UIA.UIA_PatternIds.UIA_ObjectModelPatternId, "ObjectModel", AutomationObjectIds.IsObjectModelPatternAvailableProperty);

        public ObjectModelPattern(BasicAutomationElementBase basicAutomationElement, UIA.IUIAutomationObjectModelPattern nativePattern) : base(basicAutomationElement, nativePattern)
        {
        }

        public object GetUnderlyingObjectModel()
        {
            return ComCallWrapper.Call(() => NativePattern.GetUnderlyingObjectModel());
        }
    }
}