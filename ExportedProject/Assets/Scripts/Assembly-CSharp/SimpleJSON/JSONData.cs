using System.IO;
using Il2CppDummyDll;

namespace SimpleJSON
{
	[Token(Token = "0x2000A21")]
	public sealed class JSONData : JSONNode
	{
		[Token(Token = "0x4003547")]
		[FieldOffset(Offset = "0x10")]
		private object m_Data;

		[Token(Token = "0x1700083C")]
		public override object Value
		{
			[Token(Token = "0x600405F")]
			[Address(RVA = "0x10CE33C", Offset = "0x10CE33C", VA = "0x10CE33C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004060")]
			[Address(RVA = "0x10CE344", Offset = "0x10CE344", VA = "0x10CE344", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6004061")]
		[Address(RVA = "0x10CC144", Offset = "0x10CC144", VA = "0x10CC144")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x6004062")]
		[Address(RVA = "0x10CE34C", Offset = "0x10CE34C", VA = "0x10CE34C")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x6004063")]
		[Address(RVA = "0x10CE390", Offset = "0x10CE390", VA = "0x10CE390")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x6004064")]
		[Address(RVA = "0x10CE3D4", Offset = "0x10CE3D4", VA = "0x10CE3D4")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x6004065")]
		[Address(RVA = "0x10CE410", Offset = "0x10CE410", VA = "0x10CE410")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x6004066")]
		[Address(RVA = "0x10CE44C", Offset = "0x10CE44C", VA = "0x10CE44C")]
		public JSONData(long aData)
		{
		}

		[Token(Token = "0x6004067")]
		[Address(RVA = "0x10CE488", Offset = "0x10CE488", VA = "0x10CE488", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004068")]
		[Address(RVA = "0x10CE5C4", Offset = "0x10CE5C4", VA = "0x10CE5C4", Slot = "18")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6004069")]
		[Address(RVA = "0x10CE644", Offset = "0x10CE644", VA = "0x10CE644", Slot = "45")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
