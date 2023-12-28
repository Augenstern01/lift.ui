﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Lift.Core.Converters;

namespace Lift.UI.Core.Converters;

/// <summary>
/// 共轭bool，true to false,false to true.
/// </summary>
public class ConjugateBoolConverter : BaseValueConverter<ConjugateBoolConverter>
{
    public override object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        => value is bool v ? !v : Binding.DoNothing;
}