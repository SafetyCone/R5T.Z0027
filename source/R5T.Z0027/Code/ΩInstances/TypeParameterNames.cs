using System;


namespace R5T.Z0027
{
    public class TypeParameterNames : ITypeParameterNames
    {
        #region Infrastructure

        public static ITypeParameterNames Instance { get; } = new TypeParameterNames();


        private TypeParameterNames()
        {
        }

        #endregion
    }
}
