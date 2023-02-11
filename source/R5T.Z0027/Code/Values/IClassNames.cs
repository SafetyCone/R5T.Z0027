using System;

using R5T.T0131;


namespace R5T.Z0027
{
    [ValuesMarker]
    public partial interface IClassNames : IValuesMarker
    {
        /// <summary>
        /// The default class name for new classes.
        /// </summary>
        public string Class1 => "Class1";

        /// <summary>
        /// The name of standard program class.
        /// </summary>
        public string Program => "Program";

        /// <summary>
        /// The name of a type specifying application startup.
        /// </summary>
        public string Startup => "Startup";
    }
}
