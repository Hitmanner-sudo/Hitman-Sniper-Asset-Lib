using System;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Security
{
	[Token(Token = "0x2000C4F")]
	internal class AndroidInstallValidator : IInstallValidator
	{
		[Token(Token = "0x2000C50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598614", Offset = "0x598614")]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			[Token(Token = "0x4003CA4")]
			[FieldOffset(Offset = "0x10")]
			public Action<InstallValidationEventArgs> onComplete;

			[Token(Token = "0x6004D45")]
			[Address(RVA = "0x91AB54", Offset = "0x91AB54", VA = "0x91AB54")]
			public _003C_003Ec__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6004D46")]
			[Address(RVA = "0x91AB5C", Offset = "0x91AB5C", VA = "0x91AB5C")]
			internal void _003CValidate_003Eb__0(JSONNode json)
			{
			}
		}

		[Token(Token = "0x6004D43")]
		[Address(RVA = "0xD6E894", Offset = "0xD6E894", VA = "0xD6E894", Slot = "4")]
		public void Validate(Action<InstallValidationEventArgs> onComplete)
		{
		}

		[Token(Token = "0x6004D44")]
		[Address(RVA = "0xD6EAC4", Offset = "0xD6EAC4", VA = "0xD6EAC4")]
		public AndroidInstallValidator()
		{
		}
	}
}
