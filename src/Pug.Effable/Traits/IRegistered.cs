namespace Pug.Effable
{
	public interface IRegistered<TEntityVersionUser, TRegistrationInfo> where TRegistrationInfo : IActionContext<TEntityVersionUser>
	{
		TRegistrationInfo Registration 
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
