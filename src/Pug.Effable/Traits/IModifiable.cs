namespace Pug.Effable
{
	public interface IModifiable<TEntityVersionUser, TModificationInfo> where TModificationInfo : IActionContext<TEntityVersionUser>
	{
		TModificationInfo LastModification
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
