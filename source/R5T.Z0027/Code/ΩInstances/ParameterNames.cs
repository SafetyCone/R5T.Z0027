using System;


namespace R5T.Z0027
{
    public class ParameterNames : IParameterNames
    {
        #region Infrastructure

        public static IParameterNames Instance { get; } = new ParameterNames();


        private ParameterNames()
        {
        }

        #endregion
    }
}
