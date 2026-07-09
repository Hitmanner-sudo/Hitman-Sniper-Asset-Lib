using System;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;
using Technology.Core.Auth;

namespace Technology.GooglePlayGames.Auth
{
	[Token(Token = "0x2000BA6")]
	internal sealed class ConnectGooglePlayGames : IAuthenticationState
	{
		[Token(Token = "0x4003AC2")]
		[FieldOffset(Offset = "0x10")]
		private Action<object> _resultAction;

		[Token(Token = "0x4003AC3")]
		[FieldOffset(Offset = "0x18")]
		private string _cloudData;

		[Token(Token = "0x4003AC4")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD5F4", Offset = "0x5BD5F4")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000958")]
		public bool IsInProgress
		{
			[Token(Token = "0x6004A09")]
			[Address(RVA = "0x8E0A44", Offset = "0x8E0A44", VA = "0x8E0A44", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627920", Offset = "0x627920")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A0A")]
			[Address(RVA = "0x8E0A4C", Offset = "0x8E0A4C", VA = "0x8E0A4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627930", Offset = "0x627930")]
			private set
			{
			}
		}

		[Token(Token = "0x6004A0B")]
		[Address(RVA = "0x8E0A58", Offset = "0x8E0A58", VA = "0x8E0A58", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x6004A0C")]
		[Address(RVA = "0x8E0D44", Offset = "0x8E0D44", VA = "0x8E0D44")]
		private void OnSavedGameOpen(SavedGameRequestStatus status, ISavedGameMetadata metadata)
		{
		}

		[Token(Token = "0x6004A0D")]
		[Address(RVA = "0x8E1074", Offset = "0x8E1074", VA = "0x8E1074")]
		private void OnSavedGameCommitted(SavedGameRequestStatus status, ISavedGameMetadata metadata)
		{
		}

		[Token(Token = "0x6004A0E")]
		[Address(RVA = "0x8E11FC", Offset = "0x8E11FC", VA = "0x8E11FC")]
		public ConnectGooglePlayGames()
		{
		}
	}
}
