#if MACCATALYST
namespace DtControls.Models;

using DtControls.Controls;

using System.Collections.Generic;

public class DtBuildMenuContext : IDtBuildMenuContext
{
    List<object> IDtBuildMenuContext.BuildPlatformMenus(List<DtMenuItem> menulist)
    {
        throw new NotImplementedException();
    }

    void IDtBuildMenuContext.Clear()
    {
        throw new NotImplementedException();
    }
}
#endif

