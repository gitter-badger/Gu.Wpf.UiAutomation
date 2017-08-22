﻿namespace Gu.Wpf.UiAutomation.UIA2
{
    using System;
    using Gu.Wpf.UiAutomation.Exceptions;
    using Gu.Wpf.UiAutomation.Identifiers;
    using Gu.Wpf.UiAutomation.Patterns;
    using Gu.Wpf.UiAutomation.UIA2.Patterns;
    using UIA = System.Windows.Automation;

    public class UIA2AutomationElementPatternValues : AutomationElementPatternValuesBase
    {
        public UIA2AutomationElementPatternValues(UIA2BasicAutomationElement basicAutomationElement) : base(basicAutomationElement)
        {
        }

        protected override IAutomationPattern<IAnnotationPattern> InitializeAnnotationPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IDockPattern> InitializeDockPattern()
        {
            return new AutomationPattern<IDockPattern, UIA.DockPattern>(
                DockPattern.Pattern, this.BasicAutomationElement, (b, p) => new DockPattern(b, p));
        }

        protected override IAutomationPattern<IDragPattern> InitializeDragPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IDropTargetPattern> InitializeDropTargetPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IExpandCollapsePattern> InitializeExpandCollapsePattern()
        {
            return new AutomationPattern<IExpandCollapsePattern, UIA.ExpandCollapsePattern>(
                ExpandCollapsePattern.Pattern, this.BasicAutomationElement, (b, p) => new ExpandCollapsePattern(b, p));
        }

        protected override IAutomationPattern<IGridItemPattern> InitializeGridItemPattern()
        {
            return new AutomationPattern<IGridItemPattern, UIA.GridItemPattern>(
                GridItemPattern.Pattern, this.BasicAutomationElement, (b, p) => new GridItemPattern(b, p));
        }

        protected override IAutomationPattern<IGridPattern> InitializeGridPattern()
        {
            return new AutomationPattern<IGridPattern, UIA.GridPattern>(
                 GridPattern.Pattern, this.BasicAutomationElement, (b, p) => new GridPattern(b, p));
        }

        protected override IAutomationPattern<IInvokePattern> InitializeInvokePattern()
        {
            return new AutomationPattern<IInvokePattern, UIA.InvokePattern>(
                InvokePattern.Pattern, this.BasicAutomationElement, (b, p) => new InvokePattern(b, p));
        }

        protected override IAutomationPattern<IItemContainerPattern> InitializeItemContainerPattern()
        {
#if NET35
            throw new NotSupportedByFrameworkException();
#else
            return new AutomationPattern<IItemContainerPattern, UIA.ItemContainerPattern>(
                ItemContainerPattern.Pattern, this.BasicAutomationElement, (b, p) => new ItemContainerPattern(b, p));
#endif
        }

        protected override IAutomationPattern<ILegacyIAccessiblePattern> InitializeLegacyIAccessiblePattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IMultipleViewPattern> InitializeMultipleViewPattern()
        {
            return new AutomationPattern<IMultipleViewPattern, UIA.MultipleViewPattern>(
                MultipleViewPattern.Pattern, this.BasicAutomationElement, (b, p) => new MultipleViewPattern(b, p));
        }

        protected override IAutomationPattern<IObjectModelPattern> InitializeObjectModelPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IRangeValuePattern> InitializeRangeValuePattern()
        {
            return new AutomationPattern<IRangeValuePattern, UIA.RangeValuePattern>(
                RangeValuePattern.Pattern, this.BasicAutomationElement, (b, p) => new RangeValuePattern(b, p));
        }

        protected override IAutomationPattern<IScrollItemPattern> InitializeScrollItemPattern()
        {
            return new AutomationPattern<IScrollItemPattern, UIA.ScrollItemPattern>(
                ScrollItemPattern.Pattern, this.BasicAutomationElement, (b, p) => new ScrollItemPattern(b, p));
        }

        protected override IAutomationPattern<IScrollPattern> InitializeScrollPattern()
        {
            return new AutomationPattern<IScrollPattern, UIA.ScrollPattern>(
                ScrollPattern.Pattern, this.BasicAutomationElement, (b, p) => new ScrollPattern(b, p));
        }

        protected override IAutomationPattern<ISelectionItemPattern> InitializeSelectionItemPattern()
        {
            return new AutomationPattern<ISelectionItemPattern, UIA.SelectionItemPattern>(
                SelectionItemPattern.Pattern, this.BasicAutomationElement, (b, p) => new SelectionItemPattern(b, p));
        }

        protected override IAutomationPattern<ISelectionPattern> InitializeSelectionPattern()
        {
            return new AutomationPattern<ISelectionPattern, UIA.SelectionPattern>(
                SelectionPattern.Pattern, this.BasicAutomationElement, (b, p) => new SelectionPattern(b, p));
        }

        protected override IAutomationPattern<ISpreadsheetItemPattern> InitializeSpreadsheetItemPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ISpreadsheetPattern> InitializeSpreadsheetPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IStylesPattern> InitializeStylesPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ISynchronizedInputPattern> InitializeSynchronizedInputPattern()
        {
#if NET35
            throw new NotSupportedByFrameworkException();
#else
            return new AutomationPattern<ISynchronizedInputPattern, UIA.SynchronizedInputPattern>(
                SynchronizedInputPattern.Pattern, this.BasicAutomationElement, (b, p) => new SynchronizedInputPattern(b, p));
#endif
        }

        protected override IAutomationPattern<ITableItemPattern> InitializeTableItemPattern()
        {
            return new AutomationPattern<ITableItemPattern, UIA.TableItemPattern>(
                TableItemPattern.Pattern, this.BasicAutomationElement, (b, p) => new TableItemPattern(b, p));
        }

        protected override IAutomationPattern<ITablePattern> InitializeTablePattern()
        {
            return new AutomationPattern<ITablePattern, UIA.TablePattern>(
                TablePattern.Pattern, this.BasicAutomationElement, (b, p) => new TablePattern(b, p));
        }

        protected override IAutomationPattern<ITextChildPattern> InitializeTextChildPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ITextEditPattern> InitializeTextEditPattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<IText2Pattern> InitializeText2Pattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ITextPattern> InitializeTextPattern()
        {
            return new AutomationPattern<ITextPattern, UIA.TextPattern>(
                TextPattern.Pattern, this.BasicAutomationElement, (b, p) => new TextPattern(b, p));
        }

        protected override IAutomationPattern<ITogglePattern> InitializeTogglePattern()
        {
            return new AutomationPattern<ITogglePattern, UIA.TogglePattern>(
                TogglePattern.Pattern, this.BasicAutomationElement, (b, p) => new TogglePattern(b, p));
        }

        protected override IAutomationPattern<ITransform2Pattern> InitializeTransform2Pattern()
        {
            throw new NotSupportedByFrameworkException();
        }

        protected override IAutomationPattern<ITransformPattern> InitializeTransformPattern()
        {
            return new AutomationPattern<ITransformPattern, UIA.TransformPattern>(
                TransformPattern.Pattern, this.BasicAutomationElement, (b, p) => new TransformPattern(b, p));
        }

        protected override IAutomationPattern<IValuePattern> InitializeValuePattern()
        {
            return new AutomationPattern<IValuePattern, UIA.ValuePattern>(
                ValuePattern.Pattern, this.BasicAutomationElement, (b, p) => new ValuePattern(b, p));
        }

        protected override IAutomationPattern<IVirtualizedItemPattern> InitializeVirtualizedItemPattern()
        {
#if NET35
            throw new NotSupportedByFrameworkException();
#else
            return new AutomationPattern<IVirtualizedItemPattern, UIA.VirtualizedItemPattern>(
                 VirtualizedItemPattern.Pattern, this.BasicAutomationElement, (b, p) => new VirtualizedItemPattern(b, p));
#endif
        }

        protected override IAutomationPattern<IWindowPattern> InitializeWindowPattern()
        {
            return new AutomationPattern<IWindowPattern, UIA.WindowPattern>(
                WindowPattern.Pattern, this.BasicAutomationElement, (b, p) => new WindowPattern(b, p));
        }

        public override IAutomationPattern<T> GetCustomPattern<T, TNative>(PatternId pattern, Func<BasicAutomationElementBase, TNative, T> patternCreateFunc)
        {
            return new AutomationPattern<T, TNative>(pattern, this.BasicAutomationElement, patternCreateFunc);
        }
    }
}
