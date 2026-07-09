using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DA3")]
	public class FacebookContext : AbstractAuthenticationContext
	{
		[Token(Token = "0x2000DA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598964", Offset = "0x598964")]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			[Token(Token = "0x4004101")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetMigrationFacebookUser svcOp;

			[Token(Token = "0x600541F")]
			[Address(RVA = "0x8707FC", Offset = "0x8707FC", VA = "0x8707FC")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6005420")]
			[Address(RVA = "0x870804", Offset = "0x870804", VA = "0x870804")]
			internal void _003CMigrateData_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000DA5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598974", Offset = "0x598974")]
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			[Token(Token = "0x4004102")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpRefreshFacebookFriends svcOpRefreshFriends;

			[Token(Token = "0x4004103")]
			[FieldOffset(Offset = "0x18")]
			public FacebookContext _003C_003E4__this;

			[Token(Token = "0x6005421")]
			[Address(RVA = "0x87086C", Offset = "0x87086C", VA = "0x87086C")]
			public _003C_003Ec__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6005422")]
			[Address(RVA = "0x870874", Offset = "0x870874", VA = "0x870874")]
			internal void _003COnGetMigrationFacebookUser_003Eb__0()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000DA6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598984", Offset = "0x598984")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4004104")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4004105")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, object>, string> _003C_003E9__16_1;

			[Token(Token = "0x4004106")]
			[FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<string, object>, object> _003C_003E9__16_2;

			[Token(Token = "0x6005424")]
			[Address(RVA = "0x870774", Offset = "0x870774", VA = "0x870774")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005425")]
			[Address(RVA = "0x87077C", Offset = "0x87077C", VA = "0x87077C")]
			internal string _003CLogin_003Eb__16_1(KeyValuePair<string, object> kvp)
			{
				return null;
			}

			[Token(Token = "0x6005426")]
			[Address(RVA = "0x8707BC", Offset = "0x8707BC", VA = "0x8707BC")]
			internal object _003CLogin_003Eb__16_2(KeyValuePair<string, object> kvp)
			{
				return null;
			}
		}

		[Token(Token = "0x2000DA7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598994", Offset = "0x598994")]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			[Token(Token = "0x4004107")]
			[FieldOffset(Offset = "0x10")]
			public FacebookPersonalRecord fbinfo;

			[Token(Token = "0x4004108")]
			[FieldOffset(Offset = "0x18")]
			public FacebookContext _003C_003E4__this;

			[Token(Token = "0x4004109")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, string> profileRequestOptions;

			[Token(Token = "0x6005427")]
			[Address(RVA = "0x8708B8", Offset = "0x8708B8", VA = "0x8708B8")]
			public _003C_003Ec__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6005428")]
			[Address(RVA = "0x8708C0", Offset = "0x8708C0", VA = "0x8708C0")]
			internal void _003CCompleteLogin_003Eb__0(object _003Cp0_003E)
			{
			}

			[Token(Token = "0x6005429")]
			[Address(RVA = "0x870A14", Offset = "0x870A14", VA = "0x870A14")]
			internal void _003CCompleteLogin_003Eb__1()
			{
			}

			[Token(Token = "0x600542A")]
			[Address(RVA = "0x870AFC", Offset = "0x870AFC", VA = "0x870AFC")]
			internal void _003CCompleteLogin_003Eb__2()
			{
			}
		}

		[Token(Token = "0x40040FC")]
		[FieldOffset(Offset = "0x0")]
		public static Action<FacebookPersonalRecord> UserLoginCompletion;

		[Token(Token = "0x40040FD")]
		[FieldOffset(Offset = "0x8")]
		public static FacebookContext Instance;

		[Token(Token = "0x4004100")]
		[FieldOffset(Offset = "0x50")]
		private readonly FacebookConfiguration _facebookConfiguration;

		[Token(Token = "0x17000B06")]
		public override bool IsLoggedIn
		{
			[Token(Token = "0x6005415")]
			[Address(RVA = "0x94E380", Offset = "0x94E380", VA = "0x94E380", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005416")]
			[Address(RVA = "0x94E3B0", Offset = "0x94E3B0", VA = "0x94E3B0", Slot = "6")]
			protected set
			{
			}
		}

		[Token(Token = "0x14000165")]
		public static event EventHandler<AuthenticationEvent> OnImageDownloadSuccess
		{
			[Token(Token = "0x600540F")]
			[Address(RVA = "0x94DBF0", Offset = "0x94DBF0", VA = "0x94DBF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A4C0", Offset = "0x62A4C0")]
			add
			{
			}
			[Token(Token = "0x6005410")]
			[Address(RVA = "0x94DCE8", Offset = "0x94DCE8", VA = "0x94DCE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A4D0", Offset = "0x62A4D0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000166")]
		public static event EventHandler<AuthenticationEvent> OnImageDownloadFailure
		{
			[Token(Token = "0x6005411")]
			[Address(RVA = "0x94DDE0", Offset = "0x94DDE0", VA = "0x94DDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A4E0", Offset = "0x62A4E0")]
			add
			{
			}
			[Token(Token = "0x6005412")]
			[Address(RVA = "0x94DED8", Offset = "0x94DED8", VA = "0x94DED8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A4F0", Offset = "0x62A4F0")]
			remove
			{
			}
		}

		[Token(Token = "0x6005413")]
		[Address(RVA = "0x94DFD0", Offset = "0x94DFD0", VA = "0x94DFD0")]
		public FacebookContext(AuthenticationContext context)
		{
		}

		[Token(Token = "0x6005414")]
		[Address(RVA = "0x94E154", Offset = "0x94E154", VA = "0x94E154", Slot = "4")]
		protected override IAuthenticationState[] InitializeStates()
		{
			return null;
		}

		[Token(Token = "0x6005417")]
		[Address(RVA = "0x94E3E4", Offset = "0x94E3E4", VA = "0x94E3E4", Slot = "7")]
		public override void MigrateData()
		{
		}

		[Token(Token = "0x6005418")]
		[Address(RVA = "0x94E578", Offset = "0x94E578", VA = "0x94E578")]
		private void OnGetMigrationFacebookUser(IResponseContext context, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
		{
		}

		[Token(Token = "0x6005419")]
		[Address(RVA = "0x94EE48", Offset = "0x94EE48", VA = "0x94EE48", Slot = "9")]
		internal override void Login()
		{
		}

		[Token(Token = "0x600541A")]
		[Address(RVA = "0x94F078", Offset = "0x94F078", VA = "0x94F078")]
		public void CompleteLogin(FacebookPersonalRecord fbinfo)
		{
		}

		[Token(Token = "0x600541B")]
		[Address(RVA = "0x94F308", Offset = "0x94F308", VA = "0x94F308")]
		public void RaiseUserLoginFailure()
		{
		}

		[Token(Token = "0x600541D")]
		[Address(RVA = "0x94F38C", Offset = "0x94F38C", VA = "0x94F38C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A500", Offset = "0x62A500")]
		private void _003COnGetMigrationFacebookUser_003Eb__15_1(IResponseContext _003Cp0_003E, IRequestContext _003Cp1_003E, OSRequestState _003Cp2_003E, Dictionary<string, object> _003Cp3_003E)
		{
		}

		[Token(Token = "0x600541E")]
		[Address(RVA = "0x94F40C", Offset = "0x94F40C", VA = "0x94F40C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A510", Offset = "0x62A510")]
		private void _003CLogin_003Eb__16_0(object result)
		{
		}
	}
}
