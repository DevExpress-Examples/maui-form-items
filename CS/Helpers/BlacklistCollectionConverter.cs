using System.Globalization;

namespace FormItemExample.Helpers {
    public class BlacklistCollectionConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is IList<string> contacts) {
                return String.Join("; ", contacts.Select(x => x));
            }
            return String.Empty;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return null;
        }
    }
}
