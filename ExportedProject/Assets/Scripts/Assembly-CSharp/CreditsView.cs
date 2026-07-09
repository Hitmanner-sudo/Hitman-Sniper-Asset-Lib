using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200065E")]
public class CreditsView : View
{
	[Token(Token = "0x200065F")]
	private class CreditsDisplayInfo
	{
		[Token(Token = "0x4002345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly GameObject GameObject;

		[Token(Token = "0x4002346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Text;

		[Token(Token = "0x4002347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly int LineID;

		[Token(Token = "0x4002348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Text2;

		[Token(Token = "0x4002349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string HyperLink;

		[Token(Token = "0x600295B")]
		[Address(RVA = "0x86506C", Offset = "0x86506C", VA = "0x86506C")]
		public CreditsDisplayInfo(GameObject gameObject, string text, int lineID, string text2, [Optional] string hyperLink)
		{
		}
	}

	[Token(Token = "0x4002332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool _titleNextToName;

	[Token(Token = "0x4002333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private TextAsset _creditsData;

	[Token(Token = "0x4002334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _creditParent;

	[Token(Token = "0x4002335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject _companyLabel;

	[Token(Token = "0x4002336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject _titleLabel;

	[Token(Token = "0x4002337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject _nameLabel;

	[Token(Token = "0x4002338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject _centeredLabel;

	[Token(Token = "0x4002339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject _hyperLinkLabel;

	[Token(Token = "0x400233A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float _scollSpeed;

	[Token(Token = "0x400233B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float _lineSpaceSize;

	[Token(Token = "0x400233C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private UIDraggableCamera _draggableCamera;

	[Token(Token = "0x400233D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Vector3 _cameraInitialPosition;

	[Token(Token = "0x400233E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private string _credit;

	[Token(Token = "0x400233F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float _maxY;

	[Token(Token = "0x4002340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly List<GameObject> _createdGameObjects;

	[Token(Token = "0x4002341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly Queue<CreditsDisplayInfo> _creditsToCreate;

	[Token(Token = "0x4002342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string[] _lineSeparator;

	[Token(Token = "0x4002343")]
	private const int SPACE_BETWEEN_START_AND_END_OF_CREDITS = 475;

	[Token(Token = "0x4002344")]
	private const int MAX_CREDITS_TO_CREATE_PER_FRAME = 5;

	[Token(Token = "0x6002951")]
	[Address(RVA = "0xD83B94", Offset = "0xD83B94", VA = "0xD83B94", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002952")]
	[Address(RVA = "0xD840FC", Offset = "0xD840FC", VA = "0xD840FC", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002953")]
	[Address(RVA = "0xD83BBC", Offset = "0xD83BBC", VA = "0xD83BBC")]
	private void ResetCredits()
	{
	}

	[Token(Token = "0x6002954")]
	[Address(RVA = "0xD843D8", Offset = "0xD843D8", VA = "0xD843D8")]
	private void CreateLabel(GameObject parent, string text, int lineID, [Optional] string text2, [Optional] string hyperLink)
	{
	}

	[Token(Token = "0x6002955")]
	[Address(RVA = "0xD842D0", Offset = "0xD842D0", VA = "0xD842D0")]
	private static void GetLocalizedText(ref string text)
	{
	}

	[Token(Token = "0x6002956")]
	[Address(RVA = "0xD8449C", Offset = "0xD8449C", VA = "0xD8449C")]
	protected void Update()
	{
	}

	[Token(Token = "0x6002957")]
	[Address(RVA = "0xD84640", Offset = "0xD84640", VA = "0xD84640")]
	private void CreateMissingCredits()
	{
	}

	[Token(Token = "0x6002958")]
	[Address(RVA = "0xD846EC", Offset = "0xD846EC", VA = "0xD846EC")]
	private void CreateCredit(CreditsDisplayInfo creditsDisplayInfo)
	{
	}

	[Token(Token = "0x6002959")]
	[Address(RVA = "0xD84930", Offset = "0xD84930", VA = "0xD84930")]
	public CreditsView()
	{
	}
}
