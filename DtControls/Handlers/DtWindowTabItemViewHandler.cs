// -----------------------------------------------------------------------
//  <copyright file="ZtTabViewItemViewHandler.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace DtControls.Handlers
{
    using DtControls.UserControls;
    public partial class DtWindowTabItemViewHandler 
    {
        public static IPropertyMapper<IDtWindowTabItemView, IDtWindowTabItemViewHandler> DtWindowTabItemViewPropertyMapper => new PropertyMapper<IDtWindowTabItemView, IDtWindowTabItemViewHandler>()
        {
            [nameof(DtWindowTabItemView.Header)] = MapHeader,
            [nameof(DtWindowTabItemView.IconSource)] = MapIconSource,
            [nameof(DtWindowTabItemView.IsClosable)] = MapIsClosable,
            [nameof(DtWindowTabItemView.PlatformObject)] = MapPlatformObject,
            [nameof(IContentView.Content)] = MapContent,
        };

        public static CommandMapper<IDtWindowTabItemView, IDtWindowTabItemViewHandler> DtWindowTabItemViewCommandMapper => new CommandMapper<IDtWindowTabItemView, IDtWindowTabItemViewHandler>();

        public DtWindowTabItemViewHandler() : base(DtWindowTabItemViewPropertyMapper, DtWindowTabItemViewCommandMapper)
        {

        }

        public DtWindowTabItemViewHandler(IPropertyMapper mapper = null) : base(mapper ?? DtWindowTabItemViewPropertyMapper, DtWindowTabItemViewCommandMapper)
        {
        }
    }
}
