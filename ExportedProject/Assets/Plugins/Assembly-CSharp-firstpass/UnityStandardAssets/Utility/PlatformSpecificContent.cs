using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000033")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000034")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x4000110")]
			Standalone = 0,
			[Token(Token = "0x4000111")]
			Mobile = 1
		}

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x10F11DC", Offset = "0x10F11DC", VA = "0x10F11DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x10F11E0", Offset = "0x10F11E0", VA = "0x10F11E0")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x10F11FC", Offset = "0x10F11FC", VA = "0x10F11FC")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x10F15AC", Offset = "0x10F15AC", VA = "0x10F15AC")]
		public PlatformSpecificContent()
		{
		}
	}
}
