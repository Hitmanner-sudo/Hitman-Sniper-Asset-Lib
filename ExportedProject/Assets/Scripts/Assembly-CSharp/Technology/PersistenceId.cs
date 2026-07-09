using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AA9")]
	[ExecuteInEditMode]
	public class PersistenceId : MonoBehaviour
	{
		[Token(Token = "0x40036E5")]
		[FieldOffset(Offset = "0x18")]
		public string Id;

		[Token(Token = "0x40036E6")]
		[FieldOffset(Offset = "0x20")]
		private string _idTemp;

		[Token(Token = "0x40036E7")]
		[FieldOffset(Offset = "0x28")]
		private bool _isTracked;

		[Token(Token = "0x60042ED")]
		[Address(RVA = "0x90579C", Offset = "0x90579C", VA = "0x90579C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60042EE")]
		[Address(RVA = "0x90587C", Offset = "0x90587C", VA = "0x90587C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60042EF")]
		[Address(RVA = "0x905934", Offset = "0x905934", VA = "0x905934")]
		public void OverrideId(string id)
		{
		}

		[Token(Token = "0x60042F0")]
		[Address(RVA = "0x9059EC", Offset = "0x9059EC", VA = "0x9059EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60042F1")]
		[Address(RVA = "0x905AAC", Offset = "0x905AAC", VA = "0x905AAC")]
		public PersistenceId()
		{
		}
	}
}
