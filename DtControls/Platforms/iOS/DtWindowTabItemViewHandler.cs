
namespace DtControls.Handlers
{
    using System;

    using DtControls.UserControls;
    using Microsoft.Maui;
    using Microsoft.Maui.Graphics;
    using Microsoft.Maui.Handlers;
    using Microsoft.Maui.Primitives;

    public partial class DtWindowTabItemViewHandler : ViewHandler<DtWindowTabItemView, UIKit.UIView>, IDtWindowTabItemViewHandler
    {

        IDtWindowTabItemView IDtWindowTabItemViewHandler.VirtualView => VirtualView;

        public string Header { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object IconSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsClosable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object PlatformObject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

       // IElementHandler IElement.Handler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public event EventHandler CloseRequested;

        protected override UIKit.UIView CreatePlatformView()
        {
            throw new NotImplementedException();
        }

        #region Events
        protected override void ConnectHandler(UIKit.UIView platformView)
        {
            base.ConnectHandler(platformView);
            //platformView.CloseRequested += PlatformView_CloseRequested;
        }

        protected override void DisconnectHandler(UIKit.UIView platformView)
        {
            base.DisconnectHandler(platformView);
            //platformView.CloseRequested -= PlatformView_CloseRequested;
        }
        #endregion

        #region PropertyMaps
        public static void MapHeader(IDtWindowTabItemView handler, IDtWindowTabItemView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapIconSource(IDtWindowTabItemView handler, IDtWindowTabItemView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapIsClosable(IDtWindowTabItemView handler, IDtWindowTabItemView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapContent(IDtWindowTabItemView handler, IDtWindowTabItemView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapPlatformObject(IDtWindowTabItemView handler, IDtWindowTabItemView virtualView)
        {
            throw new NotImplementedException();
        }

        public void WinCloseRequested(object sender, object args)
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
        #endregion
    }
}
