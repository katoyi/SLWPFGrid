using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using GridRowVisibilityProject.Model;

namespace GridRowVisibilityProject.Helpers
{
    public class GridVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return Visibility.Visible;
            }
            var data = value as IEnumerable<Person>;
            if (data != null)
            {
                var noEmpty = from d in data
                    let v = d.GetType().GetProperty(parameter.ToString()).GetValue(d, null)
                    where v != null && !string.IsNullOrEmpty(v.ToString())
                    select d;
                return noEmpty.Any() ? Visibility.Visible : Visibility.Collapsed;
            }
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
