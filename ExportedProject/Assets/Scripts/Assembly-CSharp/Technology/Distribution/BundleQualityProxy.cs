using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BE5")]
	[ExecuteInEditMode]
	public class BundleQualityProxy : QualityProxy
	{
		[Token(Token = "0x4003B8A")]
		[FieldOffset(Offset = "0x48")]
		public GameObject high;

		[Token(Token = "0x4003B8B")]
		[FieldOffset(Offset = "0x50")]
		public GameObject low;

		[Token(Token = "0x4003B8C")]
		private const string EDITOR_ONLY = "EditorOnly";

		[Token(Token = "0x4003B8D")]
		private const string UNTAGGED = "Untagged";

		[Token(Token = "0x4003B8E")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public string _highTag;

		[Token(Token = "0x4003B8F")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public string _lowTag;

		[Token(Token = "0x6004B5F")]
		[Address(RVA = "0xA89A68", Offset = "0xA89A68", VA = "0xA89A68")]
		public BundleQualityProxy()
		{
		}
	}
}
