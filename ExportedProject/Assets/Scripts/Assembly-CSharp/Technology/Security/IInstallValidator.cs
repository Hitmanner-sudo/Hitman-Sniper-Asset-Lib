using System;
using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C51")]
	public interface IInstallValidator
	{
		[Token(Token = "0x6004D47")]
		void Validate(Action<InstallValidationEventArgs> onComplete);
	}
}
