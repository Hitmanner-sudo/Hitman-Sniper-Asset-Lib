using System;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;
using Technology.Core.Auth;

namespace Technology.GooglePlayGames.Auth
{
	[Token(Token = "0x2000BA7")]
	internal sealed class DisconnectGooglePlayGames : IAuthenticationState
	{
		[Token(Token = "0x4003AC5")]
		[FieldOffset(Offset = "0x10")]
		private Action<object> _resultAction;

		[Token(Token = "0x4003AC6")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD604", Offset = "0x5BD604")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000959")]
		public bool IsInProgress
		{
			[Token(Token = "0x6004A0F")]
			[Address(RVA = "0xC15A1C", Offset = "0xC15A1C", VA = "0xC15A1C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627940", Offset = "0x627940")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A10")]
			[Address(RVA = "0xC15A24", Offset = "0xC15A24", VA = "0xC15A24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627950", Offset = "0x627950")]
			private set
			{
			}
		}

		[Token(Token = "0x6004A11")]
		[Address(RVA = "0xC15A30", Offset = "0xC15A30", VA = "0xC15A30", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x6004A12")]
		[Address(RVA = "0xC15C74", Offset = "0xC15C74", VA = "0xC15C74")]
		private void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata metadata)
		{
		}

		[Token(Token = "0x6004A13")]
		[Address(RVA = "0xC15EDC", Offset = "0xC15EDC", VA = "0xC15EDC")]
		public DisconnectGooglePlayGames()
		{
		}
	}
}
