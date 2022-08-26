﻿#if NET6_0 && !ANDROID && !IOS && !MACCATALYST && !WINDOWS
namespace DtControls.Handlers;

using System;

using DtControls.UserControls;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Primitives;

/// <summary>
/// 
/// </summary>
public partial class DtWindowTabItemHandler : ViewHandler<DtWindowTabItem, object>, IDtWindowTabItemHandler
{

    IDtWindowTabItem IDtWindowTabItemHandler.VirtualView => VirtualView;
    /// <summary>
    /// 
    /// </summary>
    public string Header { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <summary>
    /// 
    /// </summary>
    public object IconSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <summary>
    /// 
    /// </summary>
    public bool IsClosable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <summary>
    /// 
    /// </summary>
    public object PlatformObject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <summary>
    /// 
    /// </summary>
    public object Content => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public IView PresentedContent => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public string AutomationId => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public FlowDirection FlowDirection => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public LayoutAlignment HorizontalLayoutAlignment => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public LayoutAlignment VerticalLayoutAlignment => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public Semantics Semantics => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public IShape Clip => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public IShadow Shadow => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public bool IsEnabled => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public bool IsFocused { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <summary>
    /// 
    /// </summary>
    public Visibility Visibility => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double Opacity => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public Paint Background => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public Rect Frame { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <summary>
    /// 
    /// </summary>
    public double Width => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double MinimumWidth => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double MaximumWidth => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double Height => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double MinimumHeight => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double MaximumHeight => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public Thickness Margin => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public Size DesiredSize => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public int ZIndex => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public IViewHandler Handler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <summary>
    /// 
    /// </summary>
    public bool InputTransparent => throw new NotImplementedException();

   // IElementHandler IElement.Handler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
   /// <summary>
   /// 
   /// </summary>
    public IElement Parent => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double TranslationX => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double TranslationY => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double Scale => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double ScaleX => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double ScaleY => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double Rotation => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double RotationX => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double RotationY => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double AnchorX => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public double AnchorY => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public Thickness Padding => throw new NotImplementedException();
    /// <summary>
    /// 
    /// </summary>
    public event EventHandler CloseRequested;
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    protected override object CreatePlatformView()
    {
        throw new NotImplementedException();
    }

#region Events
    /// <summary>
    /// 
    /// </summary>
    /// <param name="platformView"></param>
    protected override void ConnectHandler(object platformView)
    {
        base.ConnectHandler(platformView);
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="platformView"></param>
    protected override void DisconnectHandler(object platformView)
    {
        base.DisconnectHandler(platformView);
        throw new NotImplementedException();
    }
#endregion

#region PropertyMaps
    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapHeader(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIconSource(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsClosable(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapContent(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapPlatformObject(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void WinCloseRequested(object sender, object args)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="widthConstraint"></param>
    /// <param name="heightConstraint"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Size CrossPlatformMeasure(double widthConstraint, double heightConstraint)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="bounds"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Size CrossPlatformArrange(Rect bounds)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="bounds"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Size Arrange(Rect bounds)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="widthConstraint"></param>
    /// <param name="heightConstraint"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Size Measure(double widthConstraint, double heightConstraint)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void InvalidateMeasure()
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void InvalidateArrange()
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool Focus()
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void Unfocus()
    {
        throw new NotImplementedException();
    }
#endregion
}
#endif