using System;
using Il2CppDummyDll;

namespace Technology.Core.Android
{
	[Token(Token = "0x2000E2E")]
	internal interface IAndroidPermissionProvider : IArmoryProvider
	{
		[Token(Token = "0x14000172")]
		event EventHandler<PermissionRequestArgs> PermissionRequest;

		[Token(Token = "0x60056E7")]
		bool CanRequestPermissions();

		[Token(Token = "0x60056E8")]
		void RequestPermission(string permission);

		[Token(Token = "0x60056E9")]
		void RequestPermissions(string[] permissions);

		[Token(Token = "0x60056EA")]
		bool HasPermission(string permission);

		[Token(Token = "0x60056EB")]
		bool ShouldShowRequestPermissionRationale(string permission);

		[Token(Token = "0x60056EC")]
		void OpenApplicationSettings();
	}
}
