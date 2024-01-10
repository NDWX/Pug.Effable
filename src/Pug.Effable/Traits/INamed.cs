namespace Pug.Effable
{
	public interface INamed<N>
	{
		N Name
		{
			get;
			set;
		}
	}

	public interface INamed : INamed<string>
	{
	}
}
