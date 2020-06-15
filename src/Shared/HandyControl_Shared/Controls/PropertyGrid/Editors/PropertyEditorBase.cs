﻿using System.Windows;
using System.Windows.Data;

namespace HandyControl.Controls
{
    public abstract class PropertyEditorBase : FrameworkElement
    {
        public abstract FrameworkElement CreateElement(PropertyItem propertyItem);

        public virtual Binding CreateBinding(PropertyItem propertyItem) =>
            new Binding(propertyItem.PropertyName)
            {
                Source = propertyItem.Value,
                Mode = GetBindingMode(),
                UpdateSourceTrigger = GetUpdateSourceTrigger()
            };

        public virtual BindingMode GetBindingMode() => BindingMode.OneWay;

        public virtual UpdateSourceTrigger GetUpdateSourceTrigger() => UpdateSourceTrigger.Default;
    }
}