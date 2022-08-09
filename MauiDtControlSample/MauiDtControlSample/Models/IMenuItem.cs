namespace MauiDtControlSample.Models
{
    public class DtMenuItem
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string NameResource { get; set; }
        public object IconObject { get; set; }
        public string ToolTipResource { get; set; }
        public Type Screen { get; set; }

        /// <summary>
        /// Make the menu resource, will format resource names correctly
        /// </summary>
        /// <param name="id"></param>
        /// <param name="parentid"></param>
        /// <param name="nameresource"></param>
        /// <param name="iconObject"></param>
        /// <param name="screen"></param>
        /// <returns></returns>
        public static DtMenuItem MakeMenuItem(int id, int parentid, string nameresource, object iconObject = null, Type screen = null)
        {
            var resname = nameresource;
            return new DtMenuItem() { Id = id, ParentId = parentid, NameResource = resname, IconObject = iconObject, ToolTipResource = resname + "_TOOLTIP", Screen = screen };
        }
    }

}
