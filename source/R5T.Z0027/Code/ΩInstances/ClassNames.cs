using System;


namespace R5T.Z0027
{
    public class ClassNames : IClassNames
    {
        #region Infrastructure

        public static IClassNames Instance { get; } = new ClassNames();


        private ClassNames()
        {
        }

        #endregion
    }
}
