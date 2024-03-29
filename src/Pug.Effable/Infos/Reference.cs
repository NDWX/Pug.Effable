using System;

namespace Pug.Effable;

public class Reference : IReference, IEquatable<Reference>
{
	public string Type 
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}
		
	public string Identifier
	{
		get;
#if NETSTANDARD2_0
		set;
#else
			init;
#endif
	}

	public virtual bool Equals( Reference other )
	{
		if( ReferenceEquals( null, other ) ) return false;
		if( ReferenceEquals( this, other ) ) return true;
		return Type == other.Type && Identifier == other.Identifier;
	}

	bool IEquatable<IReference>.Equals( IReference other )
	{
		if( ReferenceEquals( null, other ) ) return false;
		if( ReferenceEquals( this, other ) ) return true;
		return Type == other.Type && Identifier == other.Identifier;
	}

	public override bool Equals( object obj )
	{
		if( ReferenceEquals( null, obj ) ) return false;
		if( ReferenceEquals( this, obj ) ) return true;
		if( obj.GetType() != this.GetType() ) return false;
		return Equals( (Reference)obj );
	}

	public override int GetHashCode()
	{
		unchecked
		{
			return ( ( Type != null ? Type.GetHashCode() : 0 ) * 397 ) ^ ( Identifier != null ? Identifier.GetHashCode() : 0 );
		}
	}

	public static bool operator ==( Reference left, Reference right )
	{
		return Equals( left, right );
	}

	public static bool operator !=( Reference left, Reference right )
	{
		return !Equals( left, right );
	}
}