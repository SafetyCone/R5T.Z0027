using System;

using R5T.T0131;


namespace R5T.Z0027
{
    [ValuesMarker]
    public partial interface ITypeParameterNames : IValuesMarker
    {
        /// <summary>
        /// "T", The default generic type parameter name.
        /// </summary>
        public string T => "T";
    }
}
