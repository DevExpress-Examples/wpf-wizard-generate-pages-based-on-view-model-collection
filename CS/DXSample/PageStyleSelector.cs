using System.Windows;
using System.Windows.Controls;

namespace DXSample {
    public class PageStyleSelector : StyleSelector {
        public Style WelcomePageStyle { get; set; }
        public Style CommonPageStyle { get; set; }
        public Style CompletionPageStyle { get; set; }
        public override Style SelectStyle(object item, DependencyObject container) {
            if (!(item is PageViewModel)) return null;
            var vm = item as PageViewModel;
            switch (vm.Type) {
                case PageType.Welcome:
                    return WelcomePageStyle;
                case PageType.Common:
                    return CommonPageStyle;
                case PageType.Completion:
                    return CompletionPageStyle;
            }
            return base.SelectStyle(item, container);
        }
    }
}
