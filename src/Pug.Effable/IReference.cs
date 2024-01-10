namespace Pug.Effable
{
	/// <summary>
	/// Describes link to another entity of the same or different type
	/// </summary>
	public interface IReference
	{
		/// <summary>
		/// TYpe of entity being referenced
		/// </summary>
		string Type { get; set; }
        
		/// <summary>
		/// Identifier of entity being referenced
		/// </summary>
		string Identifier { get; set; }
	}
}