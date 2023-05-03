using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormItemExample.Helpers {
    public static class BioHelper {
        public const string bioText = "Bio";
        public const string detailText = "Add a few words about yourself";
    }
    public class BioTextConverter : IMarkupExtension, IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return string.IsNullOrEmpty(value?.ToString()) ? BioHelper.bioText : value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();

        public object ProvideValue(IServiceProvider serviceProvider) => this;
    }

    public class BioDetailsConverter : IMarkupExtension, IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return string.IsNullOrEmpty(value?.ToString()) ? BioHelper.detailText : BioHelper.bioText;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();

        public object ProvideValue(IServiceProvider serviceProvider) => this;
    }
}
