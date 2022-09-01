namespace DtControls.Models;

public interface IDtBuildMenuContext
{
    List<object> BuildPlatformMenus(List<DtMenuItem> menulist);
    void Clear();
}
