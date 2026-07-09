using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AB1")]
	public class LabeledArrayAttribute : PropertyAttribute
	{
		[Token(Token = "0x40036F2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBFE8", Offset = "0x5BBFE8")]
		private string[] _003CLabels_003Ek__BackingField;

		[Token(Token = "0x17000887")]
		public string[] Labels
		{
			[Token(Token = "0x60042FD")]
			[Address(RVA = "0x994214", Offset = "0x994214", VA = "0x994214")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625DD8", Offset = "0x625DD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042FE")]
			[Address(RVA = "0x99421C", Offset = "0x99421C", VA = "0x99421C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625DE8", Offset = "0x625DE8")]
			private set
			{
			}
		}

		[Token(Token = "0x60042FF")]
		[Address(RVA = "0x994224", Offset = "0x994224", VA = "0x994224")]
		public LabeledArrayAttribute(string[] labels)
		{
		}
	}
}
