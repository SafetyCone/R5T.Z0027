using System;

using R5T.T0131;


namespace R5T.Z0027
{
    [ValuesMarker]
    public partial interface IParameterNames : IValuesMarker
    {
        /// <summary>
        /// "args", The standard entry-point main method arguments parameter name.
        /// </summary>
        public string Args => "args";
    }
}
