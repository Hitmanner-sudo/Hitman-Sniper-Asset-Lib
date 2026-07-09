using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CF8")]
	public static class SvcOpHeaderDefinition
	{
		[Token(Token = "0x2000CF9")]
		public static class Key
		{
			[Token(Token = "0x4003E20")]
			public const string OSSTIME = "OS-STime";

			[Token(Token = "0x4003E21")]
			public const string OSUID = "OS-UID";

			[Token(Token = "0x4003E22")]
			public const string OSSID = "OS-SID";

			[Token(Token = "0x4003E23")]
			public const string OSAGE = "OS-Age";

			[Token(Token = "0x4003E24")]
			public const string OSXYZ = "OS-XYZ";

			[Token(Token = "0x4003E25")]
			public const string OSZONE = "OS-Zone";

			[Token(Token = "0x4003E26")]
			public const string OSAUTHID = "OS-AuthID";

			[Token(Token = "0x4003E27")]
			public const string OSAUTHTICKETDATA = "OS-AuthTicketData";

			[Token(Token = "0x4003E28")]
			public const string OSAUTHTICKETSIZE = "OS-AuthTicketSize";

			[Token(Token = "0x4003E29")]
			public const string OSAUTHPROVIDER = "OS-AuthProvider";

			[Token(Token = "0x4003E2A")]
			public const string OSPLATFORM = "OS-Platform";

			[Token(Token = "0x4003E2B")]
			public const string OSSYSTEM = "OS-System";

			[Token(Token = "0x4003E2C")]
			public const string OSVERSION = "OS-OSVersion";

			[Token(Token = "0x4003E2D")]
			public const string OSBUILD = "OS-Build";

			[Token(Token = "0x4003E2E")]
			public const string OSPID = "OS-PID";

			[Token(Token = "0x4003E2F")]
			public const string OSLOCALE = "OS-Locale";

			[Token(Token = "0x4003E30")]
			public const string OSHNAME = "OS-HName";

			[Token(Token = "0x4003E31")]
			public const string OSAUTHRESPONSE = "OS-AuthResponse";

			[Token(Token = "0x4003E32")]
			public const string OSDEST = "OS-Dest";

			[Token(Token = "0x4003E33")]
			public const string OSPROGRESS = "OS-Progress";

			[Token(Token = "0x4003E34")]
			public const string OSGAMERTAG = "OS-GamerTag";

			[Token(Token = "0x4003E35")]
			public const string OSDBTARGET = "OS-DBTarget";

			[Token(Token = "0x4003E36")]
			public const string XIFMODIFIEDSINCE = "X-If-Modified-Since";

			[Token(Token = "0x4003E37")]
			public const string ACCEPT = "Accept";

			[Token(Token = "0x4003E38")]
			public const string CACHECONTROL = "Cache-Control";

			[Token(Token = "0x4003E39")]
			public const string DATASERVICEVERSION = "DataServiceVersion";

			[Token(Token = "0x4003E3A")]
			public const string MAXDATASERVICEVERSION = "MaxDataServiceVersion";

			[Token(Token = "0x4003E3B")]
			public const string CONTENTTYPE = "content-type";
		}

		[Token(Token = "0x2000CFA")]
		public static class InternalValues
		{
			[Token(Token = "0x4003E3C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly string ACCEPT_VAL;

			[Token(Token = "0x4003E3D")]
			[FieldOffset(Offset = "0x8")]
			public static readonly string CACHECONTROL_VAL;

			[Token(Token = "0x4003E3E")]
			[FieldOffset(Offset = "0x10")]
			public static readonly string DATASERVICEVERSION_VAL;

			[Token(Token = "0x4003E3F")]
			[FieldOffset(Offset = "0x18")]
			public static readonly string MAXDATASERVICEVERSION_VAL;

			[Token(Token = "0x4003E40")]
			[FieldOffset(Offset = "0x20")]
			public static readonly string FRMWRKVERSION;

			[Token(Token = "0x4003E41")]
			[FieldOffset(Offset = "0x28")]
			public static readonly string UNKNOWN_VAL;

			[Token(Token = "0x4003E42")]
			[FieldOffset(Offset = "0x30")]
			public static readonly string UNKNOWN_VAL_NUMBER;

			[Token(Token = "0x4003E43")]
			[FieldOffset(Offset = "0x38")]
			public static readonly string ROUTE_DEVNET;

			[Token(Token = "0x4003E44")]
			[FieldOffset(Offset = "0x40")]
			public static readonly string ROUTE_PREDEVNET;

			[Token(Token = "0x4003E45")]
			[FieldOffset(Offset = "0x48")]
			public static readonly string ROUTE_PREPRODNET;

			[Token(Token = "0x4003E46")]
			[FieldOffset(Offset = "0x50")]
			public static readonly string ROUTE_PRODNET;

			[Token(Token = "0x4003E47")]
			[FieldOffset(Offset = "0x58")]
			public static readonly string CONTENT_VAL;
		}

		[Token(Token = "0x2000CFB")]
		public enum AuthProviderId
		{
			[Token(Token = "0x4003E49")]
			Facebook = 13,
			[Token(Token = "0x4003E4A")]
			OnlineSuite = 6,
			[Token(Token = "0x4003E4B")]
			Frictionless = 16
		}
	}
}
