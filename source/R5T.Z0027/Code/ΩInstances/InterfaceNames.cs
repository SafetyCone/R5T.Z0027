using System;


namespace R5T.Z0027
{
    public class InterfaceNames : IInterfaceNames
    {
        #region Infrastructure

        public static IInterfaceNames Instance { get; } = new InterfaceNames();


        private InterfaceNames()
        {
        }

        #endregion
    }
}
