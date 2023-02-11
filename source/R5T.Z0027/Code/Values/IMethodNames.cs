using System;

using R5T.T0131;


namespace R5T.Z0027
{
    [ValuesMarker]
    public partial interface IMethodNames : IValuesMarker
    {
        /// <summary>
        /// The name of the Microsoft.Extensions.DependencyInjection extension method.
        /// </summary>
        public string AddSingleton => "AddSingleton";

        /// <summary>
        /// "Main", The standard entry-point main method name.
        /// </summary>
        public string Main => "Main";

        /// <summary>
        /// The name of the <see cref="Object.ToString"/> method.
        /// </summary>
        public string ToString => "ToString";
    }
}
