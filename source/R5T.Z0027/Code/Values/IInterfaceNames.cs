using System;

using R5T.T0131;


namespace R5T.Z0027
{
    [ValuesMarker]
    public partial interface IInterfaceNames : IValuesMarker
    {
        /// <summary>
        /// The default interface name for new interfaces.
        /// </summary>
        public string Interface1 => "Interface1";
    }
}
