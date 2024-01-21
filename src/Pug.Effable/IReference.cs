using System;

namespace Pug.Effable
{
	/// <summary>
	/// Describes link to another entity of the same or different type
	/// </summary>
	public interface IReference : IEquatable<IReference>
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
		string Identifier 
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