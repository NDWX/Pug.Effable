using System;

namespace Pug.Effable
{
    /// <summary>
    /// Describes link to another entity of the same or different type
    /// </summary>
    [Obsolete("Use IReference type instead")]
    public interface IReferenceInfo
    {
        /// <summary>
        /// TYpe of entity being referenced
        /// </summary>
        string Type 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
        
        
        /// <summary>
        /// Identifier of entity being referenced
        /// </summary>
        string Value 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
		init;
#endif
	}
    }
}
