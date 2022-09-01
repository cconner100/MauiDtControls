namespace DtControls.Models;

using System.Collections.Generic;

public interface IDtMenu
{
    void InitMenuData();
    List<DtMenuItem> GetMenu();
    List<DtMenuItem> GetFooterMenu();
}
