using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.Persistence;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DAB")]
	public class SquareEnixContext : AbstractAuthenticationContext
	{
		[Token(Token = "0x2000DAC")]
		public delegate void AccountSynchronisationHandler(PersistenceCacheGroup localSaveGame, PersistenceCacheGroup remoteSaveGame);

		[Token(Token = "0x2000DAD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5989A4", Offset = "0x5989A4")]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			[Token(Token = "0x4004114")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetUserProfileCountry svcop;

			[Token(Token = "0x4004115")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			[Token(Token = "0x4004116")]
			[FieldOffset(Offset = "0x20")]
			public string locale;

			[Token(Token = "0x4004117")]
			[FieldOffset(Offset = "0x28")]
			public SquareEnixPersonalRecord info;

			[Token(Token = "0x6005453")]
			[Address(RVA = "0xA52CD8", Offset = "0xA52CD8", VA = "0xA52CD8")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6005454")]
			[Address(RVA = "0xA52CE0", Offset = "0xA52CE0", VA = "0xA52CE0")]
			internal void _003CSetInfo_003Eb__0()
			{
			}

			[Token(Token = "0x6005455")]
			[Address(RVA = "0xA52D04", Offset = "0xA52D04", VA = "0xA52D04")]
			internal void _003CSetInfo_003Eb__1(IResponseContext context, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
			{
			}
		}

		[Token(Token = "0x17000B08")]
		public override bool IsLoggedIn
		{
			[Token(Token = "0x6005440")]
			[Address(RVA = "0xD25FCC", Offset = "0xD25FCC", VA = "0xD25FCC", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005441")]
			[Address(RVA = "0xD25FFC", Offset = "0xD25FFC", VA = "0xD25FFC", Slot = "6")]
			protected set
			{
			}
		}

		[Token(Token = "0x14000169")]
		public static event EventHandler<AuthenticationEvent> OnMigrateSuccess
		{
			[Token(Token = "0x600543A")]
			[Address(RVA = "0xD25B54", Offset = "0xD25B54", VA = "0xD25B54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A570", Offset = "0x62A570")]
			add
			{
			}
			[Token(Token = "0x600543B")]
			[Address(RVA = "0xD25C10", Offset = "0xD25C10", VA = "0xD25C10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A580", Offset = "0x62A580")]
			remove
			{
			}
		}

		[Token(Token = "0x1400016A")]
		public static event EventHandler<AuthenticationEvent> OnMigrateFailure
		{
			[Token(Token = "0x600543C")]
			[Address(RVA = "0xD25CCC", Offset = "0xD25CCC", VA = "0xD25CCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A590", Offset = "0x62A590")]
			add
			{
			}
			[Token(Token = "0x600543D")]
			[Address(RVA = "0xD25D8C", Offset = "0xD25D8C", VA = "0xD25D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A5A0", Offset = "0x62A5A0")]
			remove
			{
			}
		}

		[Token(Token = "0x1400016B")]
		public static event AccountSynchronisationHandler OnMigrationSynchronisation
		{
			[Token(Token = "0x600543E")]
			[Address(RVA = "0xD25E4C", Offset = "0xD25E4C", VA = "0xD25E4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A5B0", Offset = "0x62A5B0")]
			add
			{
			}
			[Token(Token = "0x600543F")]
			[Address(RVA = "0xD25F0C", Offset = "0xD25F0C", VA = "0xD25F0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A5C0", Offset = "0x62A5C0")]
			remove
			{
			}
		}

		[Token(Token = "0x6005442")]
		[Address(RVA = "0xD26030", Offset = "0xD26030", VA = "0xD26030")]
		public SquareEnixContext(AuthenticationContext context)
		{
		}

		[Token(Token = "0x6005443")]
		[Address(RVA = "0xD260A4", Offset = "0xD260A4", VA = "0xD260A4", Slot = "4")]
		protected override IAuthenticationState[] InitializeStates()
		{
			return null;
		}

		[Token(Token = "0x6005444")]
		[Address(RVA = "0xD26270", Offset = "0xD26270", VA = "0xD26270", Slot = "9")]
		internal override void Login()
		{
		}

		[Token(Token = "0x6005445")]
		[Address(RVA = "0xD264A0", Offset = "0xD264A0", VA = "0xD264A0", Slot = "11")]
		internal override void Connect()
		{
		}

		[Token(Token = "0x6005446")]
		[Address(RVA = "0xD266D0", Offset = "0xD266D0", VA = "0xD266D0")]
		internal void SetForMigration(string passphrase)
		{
		}

		[Token(Token = "0x6005447")]
		[Address(RVA = "0xD26868", Offset = "0xD26868", VA = "0xD26868")]
		public void GetMigrationData(string uid)
		{
		}

		[Token(Token = "0x6005448")]
		[Address(RVA = "0xD2686C", Offset = "0xD2686C", VA = "0xD2686C")]
		public void GetMigrationData(string passphrase, string uid)
		{
		}

		[Token(Token = "0x6005449")]
		[Address(RVA = "0xD2697C", Offset = "0xD2697C", VA = "0xD2697C", Slot = "7")]
		public override void MigrateData()
		{
		}

		[Token(Token = "0x600544A")]
		[Address(RVA = "0xD26980", Offset = "0xD26980", VA = "0xD26980")]
		public void MigrateData(object actionResponse)
		{
		}

		[Token(Token = "0x600544B")]
		[Address(RVA = "0xD274B0", Offset = "0xD274B0", VA = "0xD274B0")]
		private void SetInfo(string uid, string uuid)
		{
		}

		[Token(Token = "0x600544C")]
		[Address(RVA = "0xD277C8", Offset = "0xD277C8", VA = "0xD277C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A5D0", Offset = "0x62A5D0")]
		private void _003CLogin_003Eb__15_0(object result)
		{
		}

		[Token(Token = "0x600544D")]
		[Address(RVA = "0xD27A68", Offset = "0xD27A68", VA = "0xD27A68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A5E0", Offset = "0x62A5E0")]
		private void _003CConnect_003Eb__16_0(object result)
		{
		}

		[Token(Token = "0x600544E")]
		[Address(RVA = "0xD27E38", Offset = "0xD27E38", VA = "0xD27E38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A5F0", Offset = "0x62A5F0")]
		private void _003CSetForMigration_003Eb__17_0(object o)
		{
		}
	}
}
