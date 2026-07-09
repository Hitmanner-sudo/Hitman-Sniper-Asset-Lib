using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CA6")]
	public class SvcOpUpdateProfileSharedData : SvcOpPost
	{
		[Token(Token = "0x170009F9")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004E55")]
			[Address(RVA = "0xB490D8", Offset = "0xB490D8", VA = "0xB490D8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004E56")]
		[Address(RVA = "0xB4911C", Offset = "0xB4911C", VA = "0xB4911C")]
		public SvcOpUpdateProfileSharedData()
		{
		}

		[Token(Token = "0x6004E57")]
		[Address(RVA = "0xB49130", Offset = "0xB49130", VA = "0xB49130")]
		public void Post(string uid, bool overrideValues, Dictionary<string, object> dictionary)
		{
		}
	}
}
