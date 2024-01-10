namespace Pug.Effable
{
	public interface IRegistered<TEntityVersionUser, TRegistrationInfo> where TRegistrationInfo : IRegistrationInfo<TEntityVersionUser>
	{
		TRegistrationInfo RegistrationInfo 
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
