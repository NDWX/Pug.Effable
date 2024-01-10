namespace Pug.Effable
{
	public interface IUpdatable<TEntityVersionUser, TUpdateInfo> where TUpdateInfo : IActionContext<TEntityVersionUser>
	{
		TUpdateInfo LastUpdateInfo 
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
