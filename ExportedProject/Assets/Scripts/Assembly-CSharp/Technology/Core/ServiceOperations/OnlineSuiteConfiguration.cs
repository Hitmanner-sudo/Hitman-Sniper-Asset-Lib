using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D19")]
	public class OnlineSuiteConfiguration : ScriptableObject
	{
		[Token(Token = "0x4003EA7")]
		[FieldOffset(Offset = "0x18")]
		public int DefaultRequestQueueSize;

		[Token(Token = "0x4003EA8")]
		[FieldOffset(Offset = "0x1C")]
		public int DefaultResponseQueueSize;

		[Token(Token = "0x4003EA9")]
		[FieldOffset(Offset = "0x20")]
		public string ProductName;

		[Token(Token = "0x4003EAA")]
		[FieldOffset(Offset = "0x28")]
		public string PublicAuthToken;

		[Token(Token = "0x4003EAB")]
		[FieldOffset(Offset = "0x30")]
		public string ServletURI;

		[Token(Token = "0x4003EAC")]
		[FieldOffset(Offset = "0x38")]
		public string ServletPath;

		[Token(Token = "0x4003EAD")]
		[FieldOffset(Offset = "0x40")]
		public int HttpRequestTimeoutInSeconds;

		[Token(Token = "0x4003EAE")]
		[FieldOffset(Offset = "0x44")]
		public int OSAuthTimeoutInSeconds;

		[Token(Token = "0x4003EAF")]
		[FieldOffset(Offset = "0x48")]
		public float AnalyticsFlushTimeoutInSeconds;

		[Token(Token = "0x4003EB0")]
		[FieldOffset(Offset = "0x4C")]
		public int AnalyticsQueueCapacity;

		[Token(Token = "0x4003EB1")]
		[FieldOffset(Offset = "0x50")]
		public bool IsInFinalMode;

		[Token(Token = "0x4003EB2")]
		[FieldOffset(Offset = "0x51")]
		public bool IsInProdnet;

		[Token(Token = "0x4003EB3")]
		[FieldOffset(Offset = "0x52")]
		public bool IsInPreProdnet;

		[Token(Token = "0x4003EB4")]
		[FieldOffset(Offset = "0x53")]
		public bool IsInPreDevnet;

		[Token(Token = "0x60050D7")]
		[Address(RVA = "0x9FA128", Offset = "0x9FA128", VA = "0x9FA128")]
		protected OnlineSuiteConfiguration()
		{
		}

		[Token(Token = "0x60050D8")]
		[Address(RVA = "0x9FA1D4", Offset = "0x9FA1D4", VA = "0x9FA1D4", Slot = "4")]
		public virtual string SystemLanguage()
		{
			return null;
		}

		[Token(Token = "0x60050D9")]
		[Address(RVA = "0x9FA344", Offset = "0x9FA344", VA = "0x9FA344", Slot = "5")]
		public virtual string GamerTag()
		{
			return null;
		}

		[Token(Token = "0x60050DA")]
		[Address(RVA = "0x9FA378", Offset = "0x9FA378", VA = "0x9FA378", Slot = "6")]
		public virtual string Zone()
		{
			return null;
		}

		[Token(Token = "0x60050DB")]
		[Address(RVA = "0x9FA3BC", Offset = "0x9FA3BC", VA = "0x9FA3BC", Slot = "7")]
		public virtual float PositionX()
		{
			return default(float);
		}

		[Token(Token = "0x60050DC")]
		[Address(RVA = "0x9FA3C4", Offset = "0x9FA3C4", VA = "0x9FA3C4", Slot = "8")]
		public virtual float PositionY()
		{
			return default(float);
		}

		[Token(Token = "0x60050DD")]
		[Address(RVA = "0x9FA3CC", Offset = "0x9FA3CC", VA = "0x9FA3CC", Slot = "9")]
		public virtual float PositionZ()
		{
			return default(float);
		}

		[Token(Token = "0x60050DE")]
		[Address(RVA = "0x9FA3D4", Offset = "0x9FA3D4", VA = "0x9FA3D4", Slot = "10")]
		public virtual string StateProvince()
		{
			return null;
		}

		[Token(Token = "0x60050DF")]
		[Address(RVA = "0x9FA418", Offset = "0x9FA418", VA = "0x9FA418", Slot = "11")]
		public virtual string Country()
		{
			return null;
		}

		[Token(Token = "0x60050E0")]
		[Address(RVA = "0x9FA45C", Offset = "0x9FA45C", VA = "0x9FA45C", Slot = "12")]
		public virtual float Progress()
		{
			return default(float);
		}

		[Token(Token = "0x60050E1")]
		[Address(RVA = "0x9FA464", Offset = "0x9FA464", VA = "0x9FA464", Slot = "13")]
		public virtual string Platform()
		{
			return null;
		}

		[Token(Token = "0x60050E2")]
		[Address(RVA = "0x9FA4A8", Offset = "0x9FA4A8", VA = "0x9FA4A8", Slot = "14")]
		public virtual int Age()
		{
			return default(int);
		}
	}
}
