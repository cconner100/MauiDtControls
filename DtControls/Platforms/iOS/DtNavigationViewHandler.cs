#if __IOS__ 
namespace DtControls.Handlers
{
    using System.ComponentModel;
    using DtControls.UserControls;

    using Microsoft.Maui.Controls.Platform;
    using Microsoft.Maui.Graphics;
    using Microsoft.Maui.Handlers;
    using Microsoft.Maui.Primitives;
    using UIKit;


    public partial class DtNavigationViewHandler : ViewHandler<IDtNavigationView, UIKit.UIView>, IElementHandler
    {
        protected override UIKit.UIView CreatePlatformView()
        {
            return new UIKit.UIView();
        }

        #region Properties

        public static void MapContent(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapHeader(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapAlwaysShowHeader(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsBackButtonVisable(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapBackButtonEnabled(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCompactModeThresholdWidth(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCompactPaneLength(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapDisplayMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapExpandedModeThresholdWidth(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        //public static void MapFooterMenuItems(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        //{
        //     virtualView.FooterMenuItems = ((NavigationView)(viewHandler?.PlatformView)).FooterMenuItems; = virtualView.FooterMenuItems;
        //}

        public static void MapFooterMenuItemsSource(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapHeaderTemplate(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsPaneOpen(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsPaneToggleButtonVisible(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsSettingsVisible(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsTitleBarAutoPaddingEnabled(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItemContainerStyle(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItems(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItemsSource(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItemsTemplate(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapOpenPaneLength(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapPaneDisplayMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapOverflowLabelMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapSelectedItem(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public void DisconnectHandler()
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var config = new UICollectionLayoutListConfiguration(UICollectionLayoutListAppearance.Sidebar);
            //config.HeaderMode = UICollectionLayoutListHeaderMode.None;
            //config.HeaderMode = UICollectionLayoutListHeaderMode.FirstItemInSection;


            var layout = UICollectionViewCompositionalLayout.GetLayout(config);


            UICollectionView collectionView = new UICollectionView(UIScreen.MainScreen.Bounds, layout);
            this.Add(collectionView);


            collectionView.TranslatesAutoresizingMaskIntoConstraints = false;
            NSLayoutConstraint.ActivateConstraints(new[]
            {
                 collectionView.TopAnchor.ConstraintEqualTo(View.LayoutMarginsGuide.TopAnchor, 0.0f),
                 collectionView.LeadingAnchor.ConstraintEqualTo(View.LeadingAnchor, 0.0f),
                 collectionView.TrailingAnchor.ConstraintEqualTo(View.TrailingAnchor, 0.0f),
                 collectionView.BottomAnchor.ConstraintEqualTo(View.BottomAnchor, 0.0f)
             });
        }

        public Size GetDesiredSize(double widthConstraint, double heightConstraint)
        {
            return new Size(100, 100);
        }

        public void Invoke(string command, object args = null)
        {
            //CommandMapper.Invoke(this, Element, command, args);
        }

        public void PlatformArrange(Rect frame)
        {
            //throw new NotImplementedException();
        }

        public void SetMauiContext(IMauiContext mauiContext)
        {
            _mauiContext = mauiContext;
        }

        public void SetVirtualView(IElement view)
        {
            SetElement((VisualElement)view);
        }

        public void UpdateValue(string property)
        {
            Mapper.UpdateProperty(this, Element, property);
        }

        public void SetElement(VisualElement element)
        {
            if (Element != null)
                throw new NotSupportedException("Reuse of the Shell Renderer is not supported");
            Element = element;
            OnElementSet((DtNavigationView)Element);

            ElementChanged?.Invoke(this, new VisualElementChangedEventArgs(null, Element));
            Mapper.UpdateProperties(this, Element);
        }

        protected virtual void OnElementSet(DtNavigationView element)
        {
            if (element == null)
                return;

            element.PropertyChanged += OnElementPropertyChanged;
        }
        protected virtual void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == Shell.CurrentItemProperty.PropertyName)
            {
                OnCurrentItemChanged();
            }
            else if (e.PropertyName == VisualElement.FlowDirectionProperty.PropertyName)
            {
                // UpdateFlowDirection(true);
            }
        }

        protected virtual async void OnCurrentItemChanged()
        {
            try
            {
                await OnCurrentItemChangedAsync();
            }
            catch (Exception exc)
            {
                //_mauiContext?.CreateLogger<DtShellHandler>()?.LogWarning(exc, "Failed on changing current item");
            }
        }

        protected virtual async Task OnCurrentItemChangedAsync()
        {
            //var currentItem = DtShell.CurrentItem;

            //var oldLayer = _currentShellItemRenderer
            //    ?.ViewController
            //    ?.View
            //    ?.Layer;

            //if (oldLayer?.AnimationKeys?.Length > 0)
            //    oldLayer.RemoveAllAnimations();

            //await _activeTransition;
            //if (_currentShellItemRenderer?.ShellItem != currentItem)
            //{
            //    var newController = CreateShellItemRenderer(currentItem);
            //    await SetCurrentShellItemControllerAsync(newController);
            //}
        }
        #endregion
    }
}
#endif
