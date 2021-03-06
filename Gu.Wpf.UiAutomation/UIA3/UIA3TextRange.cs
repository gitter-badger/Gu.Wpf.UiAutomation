﻿namespace Gu.Wpf.UiAutomation.UIA3
{
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using Gu.Wpf.UiAutomation.UIA3.Converters;

    public class UIA3TextRange : ITextRange
    {
        internal UIA3TextRange(UIA3Automation automation, Interop.UIAutomationClient.IUIAutomationTextRange nativeRange)
        {
            this.Automation = automation;
            this.NativeRange = nativeRange;
        }

        public UIA3Automation Automation { get; }

        public Interop.UIAutomationClient.IUIAutomationTextRange NativeRange { get; }

        public void AddToSelection()
        {
            Com.Call(() => this.NativeRange.AddToSelection());
        }

        public ITextRange Clone()
        {
            var clonedTextRangeNative = Com.Call(() => this.NativeRange.Clone());
            return TextRangeConverter.NativeToManaged(this.Automation, clonedTextRangeNative);
        }

        public bool Compare(ITextRange range)
        {
            var nativeRange = this.ToNativeRange(range);
            return Com.Call(() => this.NativeRange.Compare(nativeRange)) != 0;
        }

        public int CompareEndpoints(TextPatternRangeEndpoint srcEndPoint, ITextRange targetRange, TextPatternRangeEndpoint targetEndPoint)
        {
            var nativeRange = this.ToNativeRange(targetRange);
            return Com.Call(() => this.NativeRange.CompareEndpoints((Interop.UIAutomationClient.TextPatternRangeEndpoint)srcEndPoint, nativeRange, (Interop.UIAutomationClient.TextPatternRangeEndpoint)targetEndPoint));
        }

        public void ExpandToEnclosingUnit(TextUnit textUnit)
        {
            Com.Call(() => this.NativeRange.ExpandToEnclosingUnit((Interop.UIAutomationClient.TextUnit)textUnit));
        }

        public ITextRange FindAttribute(TextAttributeId attribute, object value, bool backward)
        {
            var nativeValue = ValueConverter.ToNative(value);
            var nativeTextRange = Com.Call(() => this.NativeRange.FindAttribute(attribute.Id, nativeValue, backward.ToInt()));
            return TextRangeConverter.NativeToManaged(this.Automation, nativeTextRange);
        }

        public ITextRange FindText(string text, bool backward, bool ignoreCase)
        {
            var nativeTextRange = Com.Call(() => this.NativeRange.FindText(text, backward.ToInt(), ignoreCase.ToInt()));
            return TextRangeConverter.NativeToManaged(this.Automation, nativeTextRange);
        }

        public object GetAttributeValue(TextAttributeId attribute)
        {
            var nativeValue = Com.Call(() => this.NativeRange.GetAttributeValue(attribute.Id));
            return attribute.Convert<object>(this.Automation, nativeValue);
        }

        public Rect[] GetBoundingRectangles()
        {
            var unrolledRects = Com.Call(() => this.NativeRange.GetBoundingRectangles());
            if (unrolledRects == null)
            {
                return null;
            }

            // If unrolledRects is somehow not a multiple of 4, we still will not
            // overrun it, since (x / 4) * 4 <= x for C# integer math.
            var result = new Rect[unrolledRects.Length / 4];
            for (var i = 0; i < result.Length; i++)
            {
                var j = i * 4;
                result[i] = new Rect(unrolledRects[j], unrolledRects[j + 1], unrolledRects[j + 2], unrolledRects[j + 3]);
            }

            return result;
        }

        public IReadOnlyList<AutomationElement> GetChildren()
        {
            var nativeChildren = Com.Call(() => this.NativeRange.GetChildren());
            return AutomationElementConverter.NativeArrayToManaged(this.Automation, nativeChildren);
        }

        public AutomationElement GetEnclosingElement()
        {
            var nativeElement = Com.Call(() => this.NativeRange.GetEnclosingElement());
            return AutomationElementConverter.NativeToManaged(this.Automation, nativeElement);
        }

        public string GetText(int maxLength)
        {
            return Com.Call(() => this.NativeRange.GetText(maxLength));
        }

        public int Move(TextUnit unit, int count)
        {
            return Com.Call(() => this.NativeRange.Move((Interop.UIAutomationClient.TextUnit)unit, count));
        }

        public void MoveEndpointByRange(TextPatternRangeEndpoint srcEndPoint, ITextRange targetRange, TextPatternRangeEndpoint targetEndPoint)
        {
            var nativeRange = this.ToNativeRange(targetRange);
            Com.Call(() => this.NativeRange.MoveEndpointByRange((Interop.UIAutomationClient.TextPatternRangeEndpoint)srcEndPoint, nativeRange, (Interop.UIAutomationClient.TextPatternRangeEndpoint)targetEndPoint));
        }

        public int MoveEndpointByUnit(TextPatternRangeEndpoint endpoint, TextUnit unit, int count)
        {
            return Com.Call(() => this.NativeRange.MoveEndpointByUnit((Interop.UIAutomationClient.TextPatternRangeEndpoint)endpoint, (Interop.UIAutomationClient.TextUnit)unit, count));
        }

        public void RemoveFromSelection()
        {
            Com.Call(() => this.NativeRange.RemoveFromSelection());
        }

        public void ScrollIntoView(bool alignToTop)
        {
            Com.Call(() => this.NativeRange.ScrollIntoView(alignToTop.ToInt()));
        }

        public void Select()
        {
            Com.Call(() => this.NativeRange.Select());
        }

        public UIA3TextRange2 AsTextRange2()
        {
            var nativeRange2 = (Interop.UIAutomationClient.IUIAutomationTextRange2)this.NativeRange;
            return TextRangeConverter.NativeToManaged(this.Automation, nativeRange2);
        }

        protected Interop.UIAutomationClient.IUIAutomationTextRange ToNativeRange(ITextRange range)
        {
            var concreteTextRange = range as UIA3TextRange;
            if (concreteTextRange == null)
            {
                throw new Exception("TextRange is no UIA3 TextRange");
            }

            return concreteTextRange.NativeRange;
        }
    }
}
