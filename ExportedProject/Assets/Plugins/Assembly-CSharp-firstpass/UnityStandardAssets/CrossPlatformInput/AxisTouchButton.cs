using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000052")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x10DC638", Offset = "0x10DC638", VA = "0x10DC638")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x10DC894", Offset = "0x10DC894", VA = "0x10DC894")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x10DCA34", Offset = "0x10DCA34", VA = "0x10DCA34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x10DCA50", Offset = "0x10DCA50", VA = "0x10DCA50", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x10DCB10", Offset = "0x10DCB10", VA = "0x10DCB10", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x10DCB64", Offset = "0x10DCB64", VA = "0x10DCB64")]
		public AxisTouchButton()
		{
		}
	}
}
