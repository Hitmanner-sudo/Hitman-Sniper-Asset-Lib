using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000035")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x18")]
		public Text camSwitchButton;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x20")]
		public GameObject[] objects;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x28")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x10F162C", Offset = "0x10F162C", VA = "0x10F162C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x10F1698", Offset = "0x10F1698", VA = "0x10F1698")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x10F1770", Offset = "0x10F1770", VA = "0x10F1770")]
		public SimpleActivatorMenu()
		{
		}
	}
}
