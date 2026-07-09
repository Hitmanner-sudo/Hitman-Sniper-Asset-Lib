using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E86")]
	public class PlayMakerCanvasRaycastFilterProxy : MonoBehaviour, ICanvasRaycastFilter
	{
		[Token(Token = "0x4004470")]
		[FieldOffset(Offset = "0x18")]
		public bool RayCastingEnabled;

		[Token(Token = "0x6005A19")]
		[Address(RVA = "0xB7E1A0", Offset = "0xB7E1A0", VA = "0xB7E1A0", Slot = "4")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6005A1A")]
		[Address(RVA = "0xB7E1A8", Offset = "0xB7E1A8", VA = "0xB7E1A8")]
		public PlayMakerCanvasRaycastFilterProxy()
		{
		}
	}
}
