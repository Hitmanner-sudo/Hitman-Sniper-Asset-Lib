using System;
using Il2CppDummyDll;
using Technology.Core.Android;
using Technology.Core.Auth;

namespace Technology.GooglePlayGames.Auth
{
	[Token(Token = "0x2000BAD")]
	internal sealed class LoginGooglePlayGames : IAuthenticationState
	{
		[Token(Token = "0x4003AD0")]
		[FieldOffset(Offset = "0x10")]
		private IAndroidPermissionProvider _permissionProvider;

		[Token(Token = "0x4003AD1")]
		[FieldOffset(Offset = "0x18")]
		private Action<object> _resultAction;

		[Token(Token = "0x4003AD2")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD684", Offset = "0x5BD684")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x1700095B")]
		public bool IsInProgress
		{
			[Token(Token = "0x6004A2C")]
			[Address(RVA = "0x9DE358", Offset = "0x9DE358", VA = "0x9DE358", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627970", Offset = "0x627970")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A2D")]
			[Address(RVA = "0x9DE360", Offset = "0x9DE360", VA = "0x9DE360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627980", Offset = "0x627980")]
			private set
			{
			}
		}

		[Token(Token = "0x6004A2B")]
		[Address(RVA = "0x9DE284", Offset = "0x9DE284", VA = "0x9DE284")]
		public LoginGooglePlayGames()
		{
		}

		[Token(Token = "0x6004A2E")]
		[Address(RVA = "0x9DE36C", Offset = "0x9DE36C", VA = "0x9DE36C", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x6004A2F")]
		[Address(RVA = "0x9DE9A4", Offset = "0x9DE9A4", VA = "0x9DE9A4")]
		private void OnPermissionResult(object sender, PermissionRequestArgs e)
		{
		}

		[Token(Token = "0x6004A30")]
		[Address(RVA = "0x9DE554", Offset = "0x9DE554", VA = "0x9DE554")]
		private bool HasPermissions()
		{
			return default(bool);
		}

		[Token(Token = "0x6004A31")]
		[Address(RVA = "0x9DE64C", Offset = "0x9DE64C", VA = "0x9DE64C")]
		private void RequestPermissions()
		{
		}

		[Token(Token = "0x6004A32")]
		[Address(RVA = "0x9DE888", Offset = "0x9DE888", VA = "0x9DE888")]
		private void Authenticate()
		{
		}

		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x9DEABC", Offset = "0x9DEABC", VA = "0x9DEABC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627990", Offset = "0x627990")]
		private void _003C_002Ector_003Eb__2_0(object sender, EventArgs evt)
		{
		}

		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x9DEB38", Offset = "0x9DEB38", VA = "0x9DEB38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6279A0", Offset = "0x6279A0")]
		private void _003CAuthenticate_003Eb__11_0(bool success)
		{
		}
	}
}
