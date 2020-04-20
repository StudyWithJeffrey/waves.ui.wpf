﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Fluid.UI.Windows.Converters.Inverse
{
    /// <inheritdoc />
    public class InverseBoolConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && !(bool) value;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && !(bool) value;
        }
    }
}