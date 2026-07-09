using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D9F")]
	public abstract class AbstractAuthenticationContext
	{
		[Token(Token = "0x2000DA0")]
		public delegate void CloudSynchronisationMethod(string localID, string remoteID);

		[Token(Token = "0x2000DA1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598954", Offset = "0x598954")]
		private sealed class _003C_003Ec__DisplayClass57_0
		{
			[Token(Token = "0x40040F5")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetUserProfileGameSpecific svcOp;

			[Token(Token = "0x40040F6")]
			[FieldOffset(Offset = "0x18")]
			public string cloudUID;

			[Token(Token = "0x40040F7")]
			[FieldOffset(Offset = "0x20")]
			public AbstractAuthenticationContext _003C_003E4__this;

			[Token(Token = "0x40040F8")]
			[FieldOffset(Offset = "0x28")]
			public string cloudUUID;

			[Token(Token = "0x40040F9")]
			[FieldOffset(Offset = "0x30")]
			public string localID;

			[Token(Token = "0x6005407")]
			[Address(RVA = "0x911000", Offset = "0x911000", VA = "0x911000")]
			public _003C_003Ec__DisplayClass57_0()
			{
			}

			[Token(Token = "0x6005408")]
			[Address(RVA = "0x911008", Offset = "0x911008", VA = "0x911008")]
			internal void _003CMigrateData_003Eb__0()
			{
			}

			[Token(Token = "0x6005409")]
			[Address(RVA = "0x911030", Offset = "0x911030", VA = "0x911030")]
			internal void _003CMigrateData_003Eb__1(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> meta)
			{
			}
		}

		[Token(Token = "0x40040EE")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int ACTION_LOGIN;

		[Token(Token = "0x40040EF")]
		[FieldOffset(Offset = "0x4")]
		internal static readonly int ACTION_CONNECT;

		[Token(Token = "0x40040F0")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int ACTION_DISCONNECT;

		[Token(Token = "0x40040F1")]
		[FieldOffset(Offset = "0xC")]
		internal static readonly int ACTION_LOGOUT;

		[Token(Token = "0x40040F2")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE824", Offset = "0x5BE824")]
		private IAuthenticationState[] _003CActions_003Ek__BackingField;

		[Token(Token = "0x40040F3")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE834", Offset = "0x5BE834")]
		private AuthenticationContext _003CContext_003Ek__BackingField;

		[Token(Token = "0x40040F4")]
		public const string CONNECTING_SAME_ACCOUNT = "ConnectingSameAccount";

		[Token(Token = "0x17000AFD")]
		protected IAuthenticationState[] Actions
		{
			[Token(Token = "0x60053E6")]
			[Address(RVA = "0xA9F2F0", Offset = "0xA9F2F0", VA = "0xA9F2F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A410", Offset = "0x62A410")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053E7")]
			[Address(RVA = "0xA9F2F8", Offset = "0xA9F2F8", VA = "0xA9F2F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A420", Offset = "0x62A420")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AFE")]
		protected AuthenticationContext Context
		{
			[Token(Token = "0x60053E8")]
			[Address(RVA = "0xA9F300", Offset = "0xA9F300", VA = "0xA9F300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A430", Offset = "0x62A430")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053E9")]
			[Address(RVA = "0xA9F308", Offset = "0xA9F308", VA = "0xA9F308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A440", Offset = "0x62A440")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AFF")]
		public bool IsLoggingIn
		{
			[Token(Token = "0x60053EA")]
			[Address(RVA = "0xA9F310", Offset = "0xA9F310", VA = "0xA9F310")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B00")]
		public bool IsConnecting
		{
			[Token(Token = "0x60053EB")]
			[Address(RVA = "0xA9F4A8", Offset = "0xA9F4A8", VA = "0xA9F4A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B01")]
		public bool IsDisconnecting
		{
			[Token(Token = "0x60053EC")]
			[Address(RVA = "0xA9F640", Offset = "0xA9F640", VA = "0xA9F640")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B02")]
		public bool IsLogingOut
		{
			[Token(Token = "0x60053ED")]
			[Address(RVA = "0xA9F7D8", Offset = "0xA9F7D8", VA = "0xA9F7D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B03")]
		public abstract bool IsLoggedIn
		{
			[Token(Token = "0x60053F6")]
			get;
			[Token(Token = "0x60053F7")]
			protected set;
		}

		[Token(Token = "0x1400015F")]
		public event EventHandler<AuthenticationEvent> OnLogin
		{
			[Token(Token = "0x60053DA")]
			[Address(RVA = "0xA9EB70", Offset = "0xA9EB70", VA = "0xA9EB70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A350", Offset = "0x62A350")]
			add
			{
			}
			[Token(Token = "0x60053DB")]
			[Address(RVA = "0xA9EC10", Offset = "0xA9EC10", VA = "0xA9EC10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A360", Offset = "0x62A360")]
			remove
			{
			}
		}

		[Token(Token = "0x14000160")]
		public event EventHandler<AuthenticationEvent> OnLogout
		{
			[Token(Token = "0x60053DC")]
			[Address(RVA = "0xA9ECB0", Offset = "0xA9ECB0", VA = "0xA9ECB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A370", Offset = "0x62A370")]
			add
			{
			}
			[Token(Token = "0x60053DD")]
			[Address(RVA = "0xA9ED50", Offset = "0xA9ED50", VA = "0xA9ED50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A380", Offset = "0x62A380")]
			remove
			{
			}
		}

		[Token(Token = "0x14000161")]
		public event EventHandler<AuthenticationEvent> OnConnect
		{
			[Token(Token = "0x60053DE")]
			[Address(RVA = "0xA9EDF0", Offset = "0xA9EDF0", VA = "0xA9EDF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A390", Offset = "0x62A390")]
			add
			{
			}
			[Token(Token = "0x60053DF")]
			[Address(RVA = "0xA9EE90", Offset = "0xA9EE90", VA = "0xA9EE90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A3A0", Offset = "0x62A3A0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000162")]
		public event EventHandler<AuthenticationEvent> OnDisconnect
		{
			[Token(Token = "0x60053E0")]
			[Address(RVA = "0xA9EF30", Offset = "0xA9EF30", VA = "0xA9EF30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A3B0", Offset = "0x62A3B0")]
			add
			{
			}
			[Token(Token = "0x60053E1")]
			[Address(RVA = "0xA9EFD0", Offset = "0xA9EFD0", VA = "0xA9EFD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A3C0", Offset = "0x62A3C0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000163")]
		public event EventHandler<AuthenticationEvent> OnMigrateDataFailure
		{
			[Token(Token = "0x60053E2")]
			[Address(RVA = "0xA9F070", Offset = "0xA9F070", VA = "0xA9F070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A3D0", Offset = "0x62A3D0")]
			add
			{
			}
			[Token(Token = "0x60053E3")]
			[Address(RVA = "0xA9F110", Offset = "0xA9F110", VA = "0xA9F110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A3E0", Offset = "0x62A3E0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000164")]
		public event CloudSynchronisationMethod OnCloudSynchronisation
		{
			[Token(Token = "0x60053E4")]
			[Address(RVA = "0xA9F1B0", Offset = "0xA9F1B0", VA = "0xA9F1B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A3F0", Offset = "0x62A3F0")]
			add
			{
			}
			[Token(Token = "0x60053E5")]
			[Address(RVA = "0xA9F250", Offset = "0xA9F250", VA = "0xA9F250")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A400", Offset = "0x62A400")]
			remove
			{
			}
		}

		[Token(Token = "0x60053EE")]
		[Address(RVA = "0xA9F970", Offset = "0xA9F970", VA = "0xA9F970")]
		protected AbstractAuthenticationContext(AuthenticationContext context)
		{
		}

		[Token(Token = "0x60053EF")]
		[Address(RVA = "0xA9F99C", Offset = "0xA9F99C", VA = "0xA9F99C")]
		protected void RaiseOnLogin(AuthenticationEvent authenticationEvent)
		{
		}

		[Token(Token = "0x60053F0")]
		[Address(RVA = "0xA9F9FC", Offset = "0xA9F9FC", VA = "0xA9F9FC")]
		protected void RaiseOnConnect(AuthenticationEvent authenticationEvent)
		{
		}

		[Token(Token = "0x60053F1")]
		[Address(RVA = "0xA9FA5C", Offset = "0xA9FA5C", VA = "0xA9FA5C")]
		protected void RaiseOnLogout(AuthenticationEvent authenticationEvent)
		{
		}

		[Token(Token = "0x60053F2")]
		[Address(RVA = "0xA9FABC", Offset = "0xA9FABC", VA = "0xA9FABC")]
		protected void RaiseOnDisconnect(AuthenticationEvent authenticationEvent)
		{
		}

		[Token(Token = "0x60053F3")]
		[Address(RVA = "0xA9FB1C", Offset = "0xA9FB1C", VA = "0xA9FB1C")]
		protected void RaiseOnMigrateDataFailureEvent(AuthenticationEvent authenticationEvent)
		{
		}

		[Token(Token = "0x60053F4")]
		[Address(RVA = "0xA9FB7C", Offset = "0xA9FB7C", VA = "0xA9FB7C")]
		protected void RaiseOnCloudSynchronisation(string localID, string cloudUID)
		{
		}

		[Token(Token = "0x60053F5")]
		protected abstract IAuthenticationState[] InitializeStates();

		[Token(Token = "0x60053F8")]
		public abstract void MigrateData();

		[Token(Token = "0x60053F9")]
		[Address(RVA = "0xA9FB90", Offset = "0xA9FB90", VA = "0xA9FB90", Slot = "8")]
		internal virtual void Initialize()
		{
		}

		[Token(Token = "0x60053FA")]
		[Address(RVA = "0xA9FBBC", Offset = "0xA9FBBC", VA = "0xA9FBBC", Slot = "9")]
		internal virtual void Login()
		{
		}

		[Token(Token = "0x60053FB")]
		[Address(RVA = "0xA9FE70", Offset = "0xA9FE70", VA = "0xA9FE70", Slot = "10")]
		internal virtual void Logout()
		{
		}

		[Token(Token = "0x60053FC")]
		[Address(RVA = "0xAA0168", Offset = "0xAA0168", VA = "0xAA0168", Slot = "11")]
		internal virtual void Connect()
		{
		}

		[Token(Token = "0x60053FD")]
		[Address(RVA = "0xAA0460", Offset = "0xAA0460", VA = "0xAA0460", Slot = "12")]
		internal virtual void Disconnect()
		{
		}

		[Token(Token = "0x60053FE")]
		[Address(RVA = "0xAA0758", Offset = "0xAA0758", VA = "0xAA0758", Slot = "13")]
		internal virtual void MigrateData(string cloudUID, string cloudUUID)
		{
		}

		[Token(Token = "0x6005400")]
		[Address(RVA = "0xAA0A04", Offset = "0xAA0A04", VA = "0xAA0A04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A450", Offset = "0x62A450")]
		private void _003CLogout_003Eb__54_0(object o)
		{
		}

		[Token(Token = "0x6005401")]
		[Address(RVA = "0xAA0A94", Offset = "0xAA0A94", VA = "0xAA0A94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A460", Offset = "0x62A460")]
		private void _003CConnect_003Eb__55_0(object o)
		{
		}

		[Token(Token = "0x6005402")]
		[Address(RVA = "0xAA0BEC", Offset = "0xAA0BEC", VA = "0xAA0BEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A470", Offset = "0x62A470")]
		private void _003CDisconnect_003Eb__56_0(object o)
		{
		}
	}
}
