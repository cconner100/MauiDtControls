namespace DtControls.Models;

using DtControls.UserControls;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
public partial class DtWindowTabItem
{
    /// <summary>
    /// 
    /// </summary>
    public event EventHandler CloseRequested;

    #region Properties

    [ObservableProperty]
    private string? header;

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty HeaderProperty = BindableProperty.Create("Header", typeof(string), typeof(DtWindowTabItemView));

    /// <summary>
    /// 
    /// </summary>
    public string Header
    {
        get { return (string)GetValue(HeaderProperty); }
        set { SetValue(HeaderProperty, value); }
    }


    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty IconSourceProperty = BindableProperty.Create("IconSource", typeof(object), typeof(DtWindowTabItemView));

    /// <summary>
    /// 
    /// </summary>
    public object IconSource
    {
        get { return GetValue(IconSourceProperty); }
        set { SetValue(IconSourceProperty, value); }
    }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty IsClosableProperty = BindableProperty.Create("IsClosable", typeof(bool), typeof(DtWindowTabItemView));

    /// <summary>
    /// 
    /// </summary>
    public bool IsClosable
    {
        get { return (bool)GetValue(IsClosableProperty); }
        set { SetValue(IsClosableProperty, value); }
    }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(DtWindowTabItemView));

    /// <summary>
    /// 
    /// </summary>
    public object Content
    {
        get { return GetValue(ContentProperty); }
        set { SetValue(ContentProperty, value); }
    }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty PlatformObjectProperty = BindableProperty.Create("PlatformObject", typeof(object), typeof(DtWindowTabItemView));

    /// <summary>
    /// 
    /// </summary>
    public object PlatformObject
    {
        get { return GetValue(PlatformObjectProperty); }
        set { }
    }

    #endregion
}
