

namespace DtControls.DtNavigationView
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    using DtControls.UserControls;

        using Microsoft.Maui.Controls.Platform;
        using Microsoft.Maui.Graphics;
        using Microsoft.Maui.Handlers;
        using Microsoft.Maui.Primitives;
        using UIKit;

    public class DtNavigationViewHandler : UISplitViewController, IPlatformViewHandler, IDtNavigationView
    {
        UIView rootview;

        public DtNavigationViewHandler()
        {
            rootview = new UIView();
        }

        event EventHandler IDtNavigationView.Collapsed
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public static IPropertyMapper<DtNavigationView, DtNavigationViewHandler> Mapper = new PropertyMapper<DtNavigationView, DtNavigationViewHandler>(ViewHandler.ViewMapper);
        public static CommandMapper<DtNavigationView, DtNavigationViewHandler> CommandMapper = new CommandMapper<DtNavigationView, DtNavigationViewHandler>(ViewHandler.ViewCommandMapper);

        public UIView NativeView => rootview;
        public UIView PlatformView { get; }
        public UIView ContainerView { get; }
        public UISplitViewController ViewController => this;
        public bool HasContainer { get; set; }
        public IView VirtualView { get; }
        public IMauiContext MauiContext { get; }
        public event EventHandler<VisualElementChangedEventArgs> ElementChanged;
        public event EventHandler BackRequested;
        public event EventHandler DisplayModeChanged;
        public event EventHandler Expanding;
        public event EventHandler ItemInvoked;
        public event EventHandler PaneClosed;
        public event EventHandler PaneClosing;
        public event EventHandler PaneOpened;
        public event EventHandler PaneOpening;
        public event EventHandler SelectionChanged;

        public VisualElement Element { get; private set; }

        object IViewHandler.ContainerView { get; }
        IMauiContext _mauiContext;
        IMauiContext IElementHandler.MauiContext => _mauiContext;
        UIView IPlatformViewHandler.PlatformView => NativeView;
        UIView IPlatformViewHandler.ContainerView => null;
        IElement IElementHandler.VirtualView => Element;
        object IElementHandler.PlatformView => NativeView;

        UIViewController IPlatformViewHandler.ViewController => this;

        public string Header { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AlwaysShowHeader { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DtNavigationView.BackButtonVisable IsBackButtonVisable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsBackButtonEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CompactModeThresholdWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CompactPaneLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DtNavigationView.ViewDisplayMode IDtNavigationView.DisplayMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double ExpandedModeThresholdWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<object> FooterMenuItems => throw new NotImplementedException();

        public object FooterMenuItemsSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DataTemplate HeaderTemplate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsPaneOpen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsPaneToggleButtonVisible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSettingsVisible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsTitleBarAutoPaddingEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Style MenuItemContainerStyle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<object> MenuItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object MenuItemsSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DataTemplate MenuItemsTemplate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double OpenPaneLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DtNavigationView.ViewOverflowLabelMode OverflowLabelMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DtNavigationView.ViewPaneDisplayMode PaneDisplayMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object SelectedItem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object Content => throw new NotImplementedException();

        public IView PresentedContent => throw new NotImplementedException();

        public string AutomationId => throw new NotImplementedException();

        public FlowDirection FlowDirection => throw new NotImplementedException();

        public LayoutAlignment HorizontalLayoutAlignment => throw new NotImplementedException();

        public LayoutAlignment VerticalLayoutAlignment => throw new NotImplementedException();

        public Semantics Semantics => throw new NotImplementedException();

        public IShape Clip => throw new NotImplementedException();

        public IShadow Shadow => throw new NotImplementedException();

        public bool IsEnabled => throw new NotImplementedException();

        public bool IsFocused { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Visibility Visibility => throw new NotImplementedException();

        public double Opacity => throw new NotImplementedException();

        public Paint Background => throw new NotImplementedException();

        public Rect Frame { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Width => throw new NotImplementedException();

        public double MinimumWidth => throw new NotImplementedException();

        public double MaximumWidth => throw new NotImplementedException();

        public double Height => throw new NotImplementedException();

        public double MinimumHeight => throw new NotImplementedException();

        public double MaximumHeight => throw new NotImplementedException();

        public Thickness Margin => throw new NotImplementedException();

        public Size DesiredSize => throw new NotImplementedException();

        public int ZIndex => throw new NotImplementedException();

        public IViewHandler Handler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool InputTransparent => throw new NotImplementedException();

        IElementHandler IElement.Handler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IElement Parent => throw new NotImplementedException();

        public double TranslationX => throw new NotImplementedException();

        public double TranslationY => throw new NotImplementedException();

        public double Scale => throw new NotImplementedException();

        public double ScaleX => throw new NotImplementedException();

        public double ScaleY => throw new NotImplementedException();

        public double Rotation => throw new NotImplementedException();

        public double RotationX => throw new NotImplementedException();

        public double RotationY => throw new NotImplementedException();

        public double AnchorX => throw new NotImplementedException();

        public double AnchorY => throw new NotImplementedException();

        public Thickness Padding => throw new NotImplementedException();

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

        public void WinBackRequested(object sender, object args)
        {
            throw new NotImplementedException();
        }

        public void WinCollapsed(object sender, object args)
        {
            throw new NotImplementedException();
        }

        public void WinDisplayModeChanged(object sender, object args)
        {
            throw new NotImplementedException();
        }

        public void WinExpanding(object sender, object args)
        {
            throw new NotImplementedException();
        }

        public void WinItemInvoked(object sender, object args)
        {
            throw new NotImplementedException();
        }

        public void WinPaneClosed(object sender, object args)
        {
            throw new NotImplementedException();
        }

        public void WinPaneClosing(object sender, object args)
        {
            throw new NotImplementedException();
        }

        public void WinPaneOpened(object sender, object args)
        {
            throw new NotImplementedException();
        }

        public void WinPaneOpening(object sender, object args)
        {
            throw new NotImplementedException();
        }

        public void WinSelectionChanged(object sender, object args)
        {
            throw new NotImplementedException();
        }

        public Size CrossPlatformMeasure(double widthConstraint, double heightConstraint)
        {
            throw new NotImplementedException();
        }

        public Size CrossPlatformArrange(Rect bounds)
        {
            throw new NotImplementedException();
        }

        public Size Arrange(Rect bounds)
        {
            throw new NotImplementedException();
        }

        public Size Measure(double widthConstraint, double heightConstraint)
        {
            throw new NotImplementedException();
        }

        public void InvalidateMeasure()
        {
            throw new NotImplementedException();
        }

        public void InvalidateArrange()
        {
            throw new NotImplementedException();
        }

        public bool Focus()
        {
            throw new NotImplementedException();
        }

        public void Unfocus()
        {
            throw new NotImplementedException();
        }
    }
}
