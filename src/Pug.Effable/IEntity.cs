namespace Pug.Effable
{
    public interface IEntity<out TIdentifier>
	{
		TIdentifier Identifier { get; }
    }
    
    public interface IEntity<TInfo, out TIdentifier>  : IEntity<TIdentifier>
		where TInfo : IEntityInfo<TIdentifier>
	{
		TInfo GetInfo();
    }
}
