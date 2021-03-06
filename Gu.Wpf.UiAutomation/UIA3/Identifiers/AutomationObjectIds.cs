﻿namespace Gu.Wpf.UiAutomation.UIA3.Identifiers
{
    using Gu.Wpf.UiAutomation.UIA3.Converters;

    public static class AutomationObjectIds
    {
        // Base element properties
        public static readonly PropertyId AcceleratorKeyProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_AcceleratorKeyPropertyId, "AcceleratorKey");
        public static readonly PropertyId AccessKeyProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_AccessKeyPropertyId, "AccessKey");
        public static readonly PropertyId AriaPropertiesProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_AriaPropertiesPropertyId, "AriaProperties");
        public static readonly PropertyId AriaRoleProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_AriaRolePropertyId, "AriaRole");
        public static readonly PropertyId AutomationIdProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_AutomationIdPropertyId, "AutomationId");
        public static readonly PropertyId BoundingRectangleProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_BoundingRectanglePropertyId, "BoundingRectangle", ValueConverter.ToRectangle);
        public static readonly PropertyId ClassNameProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_ClassNamePropertyId, "ClassName");
        public static readonly PropertyId ClickablePointProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_ClickablePointPropertyId, "ClickablePoint", ValueConverter.ToPoint);
        public static readonly PropertyId ControllerForProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_ControllerForPropertyId, "ControllerFor", AutomationElementConverter.NativeArrayToManaged);
        public static readonly PropertyId ControlTypeProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_ControlTypePropertyId, "ControlType", ControlTypeConverter.ToControlType);
        public static readonly PropertyId CultureProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_CulturePropertyId, "Culture", ValueConverter.ToCulture);
        public static readonly PropertyId DescribedByProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_DescribedByPropertyId, "DescribedBy");
        public static readonly PropertyId FlowsFromProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_FlowsFromPropertyId, "FlowsFrom");
        public static readonly PropertyId FlowsToProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_FlowsToPropertyId, "FlowsTo");
        public static readonly PropertyId FrameworkIdProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_FrameworkIdPropertyId, "FrameworkId");
        public static readonly PropertyId HasKeyboardFocusProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_HasKeyboardFocusPropertyId, "HasKeyboardFocus");
        public static readonly PropertyId HelpTextProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_HelpTextPropertyId, "HelpText");
        public static readonly PropertyId IsContentElementProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsContentElementPropertyId, "IsContentElement");
        public static readonly PropertyId IsControlElementProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsControlElementPropertyId, "IsControlElement");
        public static readonly PropertyId IsDataValidForFormProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsDataValidForFormPropertyId, "IsDataValidForForm");
        public static readonly PropertyId IsEnabledProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsEnabledPropertyId, "IsEnabled");
        public static readonly PropertyId IsKeyboardFocusableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsKeyboardFocusablePropertyId, "IsKeyboardFocusable");
        public static readonly PropertyId IsOffscreenProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsOffscreenPropertyId, "IsOffscreen");
        public static readonly PropertyId IsPasswordProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsPasswordPropertyId, "IsPassword");
        public static readonly PropertyId IsPeripheralProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsPeripheralPropertyId, "IsPeripheral");
        public static readonly PropertyId IsRequiredForFormProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsRequiredForFormPropertyId, "IsRequiredForForm");
        public static readonly PropertyId ItemStatusProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_ItemStatusPropertyId, "ItemStatus");
        public static readonly PropertyId ItemTypeProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_ItemTypePropertyId, "ItemType");
        public static readonly PropertyId LabeledByProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_LabeledByPropertyId, "LabeledBy");
        public static readonly PropertyId LiveSettingProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_LiveSettingPropertyId, "LiveSetting");
        public static readonly PropertyId LocalizedControlTypeProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_LocalizedControlTypePropertyId, "LocalizedControlType");
        public static readonly PropertyId NameProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_NamePropertyId, "Name");
        public static readonly PropertyId NativeWindowHandleProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_NativeWindowHandlePropertyId, "NativeWindowHandle", ValueConverter.IntToIntPtr);
        public static readonly PropertyId OptimizeForVisualContentProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_OptimizeForVisualContentPropertyId, "OptimizeForVisualContent");
        public static readonly PropertyId OrientationProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_OrientationPropertyId, "Orientation");
        public static readonly PropertyId ProcessIdProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_ProcessIdPropertyId, "ProcessId");
        public static readonly PropertyId ProviderDescriptionProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_ProviderDescriptionPropertyId, "ProviderDescription");
        public static readonly PropertyId RuntimeIdProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_RuntimeIdPropertyId, "RuntimeId");

        // Pattern availability properties
        public static readonly PropertyId IsAnnotationPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsAnnotationPatternAvailablePropertyId, "IsAnnotationPatternAvailable");
        public static readonly PropertyId IsDockPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsDockPatternAvailablePropertyId, "IsDockPatternAvailable");
        public static readonly PropertyId IsDragPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsDragPatternAvailablePropertyId, "IsDragPatternAvailable");
        public static readonly PropertyId IsDropTargetPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsDropTargetPatternAvailablePropertyId, "IsDropTargetPatternAvailable");
        public static readonly PropertyId IsExpandCollapsePatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsExpandCollapsePatternAvailablePropertyId, "IsExpandCollapsePatternAvailable");
        public static readonly PropertyId IsGridItemPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsGridItemPatternAvailablePropertyId, "IsGridItemPatternAvailable");
        public static readonly PropertyId IsGridPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsGridPatternAvailablePropertyId, "IsGridPatternAvailable");
        public static readonly PropertyId IsInvokePatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsInvokePatternAvailablePropertyId, "IsInvokePatternAvailable");
        public static readonly PropertyId IsItemContainerPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsItemContainerPatternAvailablePropertyId, "IsItemContainerPatternAvailable");
        public static readonly PropertyId IsLegacyIAccessiblePatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsLegacyIAccessiblePatternAvailablePropertyId, "IsLegacyIAccessiblePatternAvailable");
        public static readonly PropertyId IsMultipleViewPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsMultipleViewPatternAvailablePropertyId, "IsMultipleViewPatternAvailable");
        public static readonly PropertyId IsObjectModelPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsObjectModelPatternAvailablePropertyId, "IsObjectModelPatternAvailable");
        public static readonly PropertyId IsRangeValuePatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsRangeValuePatternAvailablePropertyId, "IsRangeValuePatternAvailable");
        public static readonly PropertyId IsScrollItemPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsScrollItemPatternAvailablePropertyId, "IsScrollItemPatternAvailable");
        public static readonly PropertyId IsScrollPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsScrollPatternAvailablePropertyId, "IsScrollPatternAvailable");
        public static readonly PropertyId IsSelectionItemPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsSelectionItemPatternAvailablePropertyId, "IsSelectionItemPatternAvailable");
        public static readonly PropertyId IsSelectionPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsSelectionPatternAvailablePropertyId, "IsSelectionPatternAvailable");
        public static readonly PropertyId IsSpreadsheetPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsSpreadsheetPatternAvailablePropertyId, "IsSpreadsheetPatternAvailable");
        public static readonly PropertyId IsSpreadsheetItemPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsSpreadsheetItemPatternAvailablePropertyId, "IsSpreadsheetItemPatternAvailable");
        public static readonly PropertyId IsStylesPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsStylesPatternAvailablePropertyId, "IsStylesPatternAvailable");
        public static readonly PropertyId IsSynchronizedInputPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsSynchronizedInputPatternAvailablePropertyId, "IsSynchronizedInputPatternAvailable");
        public static readonly PropertyId IsTableItemPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsTableItemPatternAvailablePropertyId, "IsTableItemPatternAvailable");
        public static readonly PropertyId IsTablePatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsTablePatternAvailablePropertyId, "IsTablePatternAvailable");
        public static readonly PropertyId IsTextChildPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsTextChildPatternAvailablePropertyId, "IsTextChildPatternAvailable");
        public static readonly PropertyId IsTextEditPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsTextEditPatternAvailablePropertyId, "IsTextEditPatternAvailable");
        public static readonly PropertyId IsTextPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsTextPatternAvailablePropertyId, "IsTextPatternAvailable");
        public static readonly PropertyId IsTextPattern2AvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsTextPattern2AvailablePropertyId, "IsTextPattern2Available");
        public static readonly PropertyId IsTogglePatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsTogglePatternAvailablePropertyId, "IsTogglePatternAvailable");
        public static readonly PropertyId IsTransformPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsTransformPatternAvailablePropertyId, "IsTransformPatternAvailable");
        public static readonly PropertyId IsTransformPattern2AvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsTransformPattern2AvailablePropertyId, "IsTransformPattern2Available");
        public static readonly PropertyId IsValuePatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsValuePatternAvailablePropertyId, "IsValuePatternAvailable");
        public static readonly PropertyId IsVirtualizedItemPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsVirtualizedItemPatternAvailablePropertyId, "IsVirtualizedItemPatternAvailable");
        public static readonly PropertyId IsWindowPatternAvailableProperty = PropertyId.GetOrCreate(Interop.UIAutomationClient.UIA_PropertyIds.UIA_IsWindowPatternAvailablePropertyId, "IsWindowPatternAvailable");

        public static readonly EventId AsyncContentLoadedEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_AsyncContentLoadedEventId, "AsyncContentLoaded");
        public static readonly EventId FocusChangedEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_AutomationFocusChangedEventId, "AutomationFocusChanged");
        public static readonly EventId PropertyChangedEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_AutomationPropertyChangedEventId, "AutomationPropertyChanged");
        public static readonly EventId HostedFragmentRootsInvalidatedEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_HostedFragmentRootsInvalidatedEventId, "HostedFragmentRootsInvalidated");
        public static readonly EventId LayoutInvalidatedEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_LayoutInvalidatedEventId, "LayoutInvalidated");
        public static readonly EventId LiveRegionChangedEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_LiveRegionChangedEventId, "LiveRegionChanged");
        public static readonly EventId MenuClosedEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_MenuClosedEventId, "MenuClosed");
        public static readonly EventId MenuModeEndEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_MenuModeEndEventId, "MenuModeEnd");
        public static readonly EventId MenuModeStartEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_MenuModeStartEventId, "MenuModeStart");
        public static readonly EventId MenuOpenedEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_MenuOpenedEventId, "MenuOpened");
        public static readonly EventId StructureChangedEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_StructureChangedEventId, "StructureChanged");
        public static readonly EventId SystemAlertEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_SystemAlertEventId, "SystemAlert");
        public static readonly EventId ToolTipClosedEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_ToolTipClosedEventId, "ToolTipClosed");
        public static readonly EventId ToolTipOpenedEvent = EventId.GetOrCreate(Interop.UIAutomationClient.UIA_EventIds.UIA_ToolTipOpenedEventId, "ToolTipOpened");
    }
}
