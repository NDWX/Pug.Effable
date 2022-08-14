namespace Pug.Effable
{
	public interface IRegistered<TEntityVersionUser, TRegistrationInfo> where TRegistrationInfo : IRegistrationInfo<TEntityVersionUser>
	{
		TRegistrationInfo RegistrationInfo { get; set; }
	}
}
