﻿namespace Gu.Wpf.UiAutomation.UIA3.Converters
{
    using System;
    using System.Collections.Generic;

    public static class AutomationElementConverter
    {
        public static IReadOnlyList<AutomationElement> NativeArrayToManaged(AutomationBase automation, object nativeElements)
        {
            if (nativeElements == null)
            {
                return new AutomationElement[0];
            }

            var uia3Automation = (UIA3Automation)automation;
            var nativeElementsCasted = (Interop.UIAutomationClient.IUIAutomationElementArray)nativeElements;
            var retArray = new AutomationElement[nativeElementsCasted.Length];
            for (var i = 0; i < nativeElementsCasted.Length; i++)
            {
                var nativeElement = nativeElementsCasted.GetElement(i);
                var automationElement = uia3Automation.WrapNativeElement(nativeElement);
                retArray[i] = automationElement;
            }

            return retArray;
        }

        public static AutomationElement NativeToManaged(AutomationBase automation, object nativeElement)
        {
            var uia3Automation = (UIA3Automation)automation;
            return uia3Automation.WrapNativeElement((Interop.UIAutomationClient.IUIAutomationElement)nativeElement);
        }

        public static Interop.UIAutomationClient.IUIAutomationElement ToNative(this AutomationElement automationElement)
        {
            if (automationElement == null)
            {
                return null;
            }

            var basicElement = automationElement.BasicAutomationElement as UIA3BasicAutomationElement;
            if (basicElement == null)
            {
                throw new Exception("Element is not an UIA3 element");
            }

            return basicElement.NativeElement;
        }
    }
}
