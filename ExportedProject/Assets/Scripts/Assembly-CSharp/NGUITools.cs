using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000058")]
public static class NGUITools
{
	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x0")]
	private static AudioListener mListener;

	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x8")]
	private static bool mLoaded;

	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0xC")]
	private static float mGlobalVolume;

	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<int, Camera> _cameraCache;

	[Token(Token = "0x1700005A")]
	public static float soundVolume
	{
		[Token(Token = "0x6000277")]
		[Address(RVA = "0xC4DCC0", Offset = "0xC4DCC0", VA = "0xC4DCC0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000278")]
		[Address(RVA = "0xC4DDA0", Offset = "0xC4DDA0", VA = "0xC4DDA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700005B")]
	public static bool fileAccess
	{
		[Token(Token = "0x6000279")]
		[Address(RVA = "0xC4DE78", Offset = "0xC4DE78", VA = "0xC4DE78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005C")]
	public static string clipboard
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xC51588", Offset = "0xC51588", VA = "0xC51588")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xC51604", Offset = "0xC51604", VA = "0xC51604")]
		set
		{
		}
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xC4DE98", Offset = "0xC4DE98", VA = "0xC4DE98")]
	public static AudioSource PlaySound(AudioClip clip)
	{
		return null;
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xC4E444", Offset = "0xC4E444", VA = "0xC4E444")]
	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
		return null;
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xC4DF00", Offset = "0xC4DF00", VA = "0xC4DF00")]
	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		return null;
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xC4E544", Offset = "0xC4E544", VA = "0xC4E544")]
	public static WWW OpenURL(string url)
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xC4E67C", Offset = "0xC4E67C", VA = "0xC4E67C")]
	public static WWW OpenURL(string url, WWWForm form)
	{
		return null;
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xC4E814", Offset = "0xC4E814", VA = "0xC4E814")]
	public static int RandomRange(int min, int max)
	{
		return default(int);
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xC4E82C", Offset = "0xC4E82C", VA = "0xC4E82C")]
	public static string GetHierarchy(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x6000281")]
	public static List<T> FindAll<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000282")]
	public static T[] FindActive<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0xC4E954", Offset = "0xC4E954", VA = "0xC4E954")]
	public static void ClearCameraCache()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xC4E9D8", Offset = "0xC4E9D8", VA = "0xC4E9D8")]
	public static Camera FindCameraForLayer(int layer, bool includeInactive = false)
	{
		return null;
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xC4EC20", Offset = "0xC4EC20", VA = "0xC4EC20")]
	public static BoxCollider AddWidgetCollider(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xC4EC84", Offset = "0xC4EC84", VA = "0xC4EC84")]
	public static BoxCollider AddWidgetCollider(GameObject go, bool considerInactive)
	{
		return null;
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xC4EFC0", Offset = "0xC4EFC0", VA = "0xC4EFC0")]
	public static void UpdateWidgetCollider(GameObject go)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xC4F024", Offset = "0xC4F024", VA = "0xC4F024")]
	public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xC4F114", Offset = "0xC4F114", VA = "0xC4F114")]
	public static void UpdateWidgetCollider(BoxCollider bc)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xC4EEA4", Offset = "0xC4EEA4", VA = "0xC4EEA4")]
	public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
	{
	}

	[Token(Token = "0x600028B")]
	public static string GetTypeName<T>()
	{
		return null;
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xC4F178", Offset = "0xC4F178", VA = "0xC4F178")]
	public static string GetTypeName(Object obj)
	{
		return null;
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xC4F29C", Offset = "0xC4F29C", VA = "0xC4F29C")]
	public static GameObject AddChild(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xC4F3D4", Offset = "0xC4F3D4", VA = "0xC4F3D4")]
	public static GameObject AddChild(GameObject parent, GameObject prefab, bool setLayer = true)
	{
		return null;
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xC4F574", Offset = "0xC4F574", VA = "0xC4F574")]
	public static int CalculateRaycastDepth(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xC4F704", Offset = "0xC4F704", VA = "0xC4F704")]
	public static int CalculateNextDepth(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xC4F7CC", Offset = "0xC4F7CC", VA = "0xC4F7CC")]
	public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
	{
		return default(int);
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xC4F9AC", Offset = "0xC4F9AC", VA = "0xC4F9AC")]
	public static int AdjustDepth(GameObject go, int adjustment)
	{
		return default(int);
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xC4FB88", Offset = "0xC4FB88", VA = "0xC4FB88")]
	public static void BringForward(GameObject go)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xC4FFD0", Offset = "0xC4FFD0", VA = "0xC4FFD0")]
	public static void PushBack(GameObject go)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xC50090", Offset = "0xC50090", VA = "0xC50090")]
	public static void NormalizeDepths()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xC4FE0C", Offset = "0xC4FE0C", VA = "0xC4FE0C")]
	public static void NormalizeWidgetDepths()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xC4FC48", Offset = "0xC4FC48", VA = "0xC4FC48")]
	public static void NormalizePanelDepths()
	{
	}

	[Token(Token = "0x6000298")]
	public static T AddChild<T>(GameObject parent) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000299")]
	public static T AddWidget<T>(GameObject go) where T : UIWidget
	{
		return null;
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xC500EC", Offset = "0xC500EC", VA = "0xC500EC")]
	public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName)
	{
		return null;
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xC5023C", Offset = "0xC5023C", VA = "0xC5023C")]
	public static GameObject GetRoot(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600029C")]
	public static T FindInParents<T>(GameObject go) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xC502F0", Offset = "0xC502F0", VA = "0xC502F0")]
	public static void Destroy(Object obj)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xC5040C", Offset = "0xC5040C", VA = "0xC5040C")]
	public static void DestroyImmediate(Object obj)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xC504E0", Offset = "0xC504E0", VA = "0xC504E0")]
	public static void Broadcast(string funcName)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xC50624", Offset = "0xC50624", VA = "0xC50624")]
	public static void Broadcast(string funcName, object param)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xC50778", Offset = "0xC50778", VA = "0xC50778")]
	public static bool IsChild(Transform parent, Transform child)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xC508A0", Offset = "0xC508A0", VA = "0xC508A0")]
	private static void Activate(Transform t)
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xC50A0C", Offset = "0xC50A0C", VA = "0xC50A0C")]
	private static void Deactivate(Transform t)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xC50A94", Offset = "0xC50A94", VA = "0xC50A94")]
	public static void SetActive(GameObject go, bool state)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xC50B48", Offset = "0xC50B48", VA = "0xC50B48")]
	public static void SetActiveChildren(GameObject go, bool state)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xC50C74", Offset = "0xC50C74", VA = "0xC50C74")]
	public static bool IsActive(MonoBehaviour mb)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xC4E4B8", Offset = "0xC4E4B8", VA = "0xC4E4B8")]
	public static bool GetActive(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xC509F0", Offset = "0xC509F0", VA = "0xC509F0")]
	public static void SetActiveSelf(GameObject go, bool state)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xC50D20", Offset = "0xC50D20", VA = "0xC50D20")]
	public static void SetLayer(GameObject go, int layer)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xC50E10", Offset = "0xC50E10", VA = "0xC50E10")]
	public static Vector3 Round(Vector3 v)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xC50FA0", Offset = "0xC50FA0", VA = "0xC50FA0")]
	public static void MakePixelPerfect(Transform t)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xC51204", Offset = "0xC51204", VA = "0xC51204")]
	public static bool Save(string fileName, byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xC513F8", Offset = "0xC513F8", VA = "0xC513F8")]
	public static byte[] Load(string fileName)
	{
		return null;
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xC514B8", Offset = "0xC514B8", VA = "0xC514B8")]
	public static Color ApplyPMA(Color c)
	{
		return default(Color);
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xC514D4", Offset = "0xC514D4", VA = "0xC514D4")]
	public static void MarkParentAsChanged(GameObject go)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xC516BC", Offset = "0xC516BC", VA = "0xC516BC")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x611A20", Offset = "0x611A20")]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xC5174C", Offset = "0xC5174C", VA = "0xC5174C")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x611A58", Offset = "0x611A58")]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xC517BC", Offset = "0xC517BC", VA = "0xC517BC")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x611A90", Offset = "0x611A90")]
	public static string StripSymbols(string text)
	{
		return null;
	}
}
