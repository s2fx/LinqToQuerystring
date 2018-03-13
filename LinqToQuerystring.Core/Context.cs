namespace LinqToQuerystring.Core
{
    using System;
    using System.Collections.Generic;

    using LinqToQuerystring.Core.Utils;

    public class Context
    {
        private static readonly Lazy<Context> s_context = new Lazy<Context>(() => new Context(), true);

        public Func<Type, Type> DefaultTypeMap = (type) => type;

        public Func<Type, Type, Type> DefaultTypeConversionMap = (from, to) => to;

        /// <summary>
        /// Exstensibility point for specifying an alternate type mapping when casting to IEnumerable
        /// </summary>
        public Func<Type, Type> EnumerableTypeMap { get; set; }

        /// <summary>
        /// Exstensibility point for specifying an alternate type mapping when casting values
        /// </summary>
        public Func<Type, Type, Type> TypeConversionMap { get; set; }

        /// <summary>
        /// Allows the specification of custom tree nodes for particular situations, i.e Entity Framework include
        /// </summary>
        public Dictionary<string, CustomNodeMappings> CustomNodes { get; set; }

        public void Reset()
        {
            EnumerableTypeMap = DefaultTypeMap;
            TypeConversionMap = DefaultTypeConversionMap;
            CustomNodes = new Dictionary<string, CustomNodeMappings>();
        }

        public Context()
        {
            Reset();
        }


        public static Context GlobalContext => s_context.Value;
    }
}
