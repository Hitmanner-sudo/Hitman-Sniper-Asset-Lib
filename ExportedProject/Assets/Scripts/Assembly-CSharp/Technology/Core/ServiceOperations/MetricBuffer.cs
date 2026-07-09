using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CD3")]
	public class MetricBuffer
	{
		[Token(Token = "0x4003DD3")]
		private const string METRIC_ATTRIBUTE_FROMCACHE = "b_FromCache";

		[Token(Token = "0x4003DD4")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Dictionary<string, object>> _metrics;

		[Token(Token = "0x6004F77")]
		[Address(RVA = "0x9C1D64", Offset = "0x9C1D64", VA = "0x9C1D64")]
		public void Enqueue(Dictionary<string, object> metric)
		{
		}

		[Token(Token = "0x6004F78")]
		[Address(RVA = "0x9C1DC8", Offset = "0x9C1DC8", VA = "0x9C1DC8")]
		public bool HasItems()
		{
			return default(bool);
		}

		[Token(Token = "0x6004F79")]
		[Address(RVA = "0x9C1E20", Offset = "0x9C1E20", VA = "0x9C1E20")]
		public void Clear()
		{
		}

		[Token(Token = "0x6004F7A")]
		[Address(RVA = "0x9C1E74", Offset = "0x9C1E74", VA = "0x9C1E74")]
		public int Count()
		{
			return default(int);
		}

		[Token(Token = "0x6004F7B")]
		[Address(RVA = "0x9C1EC0", Offset = "0x9C1EC0", VA = "0x9C1EC0")]
		public string Serialize(bool addFromCacheAttribute)
		{
			return null;
		}

		[Token(Token = "0x6004F7C")]
		[Address(RVA = "0x9C21BC", Offset = "0x9C21BC", VA = "0x9C21BC")]
		public MetricBuffer()
		{
		}
	}
}
