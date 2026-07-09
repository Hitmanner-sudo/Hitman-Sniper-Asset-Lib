using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000060")]
	[Attribute(Name = "RequireComponent", RVA = "0x6F90F8", Offset = "0x6F90F8")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000061")]
		public enum AxisOption
		{
			[Token(Token = "0x40001D3")]
			Both = 0,
			[Token(Token = "0x40001D4")]
			OnlyHorizontal = 1,
			[Token(Token = "0x40001D5")]
			OnlyVertical = 2
		}

		[Token(Token = "0x2000062")]
		public enum ControlStyle
		{
			[Token(Token = "0x40001D7")]
			Absolute = 0,
			[Token(Token = "0x40001D8")]
			Relative = 1,
			[Token(Token = "0x40001D9")]
			Swipe = 2
		}

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x18BBF98", Offset = "0x18BBF98", VA = "0x18BBF98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x18BC0E8", Offset = "0x18BC0E8", VA = "0x18BC0E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x18BBF9C", Offset = "0x18BBF9C", VA = "0x18BBF9C")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x18BC160", Offset = "0x18BC160", VA = "0x18BC160")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x18BC1CC", Offset = "0x18BC1CC", VA = "0x18BC1CC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x18BC204", Offset = "0x18BC204", VA = "0x18BC204")]
		private void Update()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x18BC34C", Offset = "0x18BC34C", VA = "0x18BC34C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x18BC380", Offset = "0x18BC380", VA = "0x18BC380")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x18BC480", Offset = "0x18BC480", VA = "0x18BC480")]
		public TouchPad()
		{
		}
	}
}
