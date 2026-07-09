using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E83")]
	public static class ActionHelpers
	{
		[Token(Token = "0x400445C")]
		[FieldOffset(Offset = "0x0")]
		public static RaycastHit mousePickInfo;

		[Token(Token = "0x400445D")]
		[FieldOffset(Offset = "0x2C")]
		private static float mousePickRaycastTime;

		[Token(Token = "0x400445E")]
		[FieldOffset(Offset = "0x30")]
		private static float mousePickDistanceUsed;

		[Token(Token = "0x400445F")]
		[FieldOffset(Offset = "0x34")]
		private static int mousePickLayerMaskUsed;

		[Token(Token = "0x4004460")]
		public const string colon = ": ";

		[Token(Token = "0x17000C02")]
		public static Texture2D WhiteTexture
		{
			[Token(Token = "0x60059E6")]
			[Address(RVA = "0xAA84FC", Offset = "0xAA84FC", VA = "0xAA84FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60059E7")]
		[Address(RVA = "0xAA8504", Offset = "0xAA8504", VA = "0xAA8504")]
		public static Color BlendColor(ColorBlendMode blendMode, Color c1, Color c2)
		{
			return default(Color);
		}

		[Token(Token = "0x60059E8")]
		[Address(RVA = "0xAA86B0", Offset = "0xAA86B0", VA = "0xAA86B0")]
		public static bool IsVisible(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60059E9")]
		[Address(RVA = "0xAA8798", Offset = "0xAA8798", VA = "0xAA8798")]
		public static bool IsVisible(GameObject go, Camera camera, bool useBounds)
		{
			return default(bool);
		}

		[Token(Token = "0x60059EA")]
		[Address(RVA = "0xAA8960", Offset = "0xAA8960", VA = "0xAA8960")]
		public static GameObject GetOwnerDefault(FsmStateAction action, FsmOwnerDefault ownerDefault)
		{
			return null;
		}

		[Token(Token = "0x60059EB")]
		[Address(RVA = "0xAA8984", Offset = "0xAA8984", VA = "0xAA8984")]
		public static PlayMakerFSM GetGameObjectFsm(GameObject go, string fsmName)
		{
			return null;
		}

		[Token(Token = "0x60059EC")]
		[Address(RVA = "0xAA8B20", Offset = "0xAA8B20", VA = "0xAA8B20")]
		public static int GetRandomWeightedIndex(FsmFloat[] weights)
		{
			return default(int);
		}

		[Token(Token = "0x60059ED")]
		[Address(RVA = "0xAA8C2C", Offset = "0xAA8C2C", VA = "0xAA8C2C")]
		public static void AddAnimationClip(GameObject go, AnimationClip animClip)
		{
		}

		[Token(Token = "0x60059EE")]
		[Address(RVA = "0xAA8D38", Offset = "0xAA8D38", VA = "0xAA8D38")]
		public static bool HasAnimationFinished(AnimationState anim, float prevTime, float currentTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60059EF")]
		[Address(RVA = "0xAA8E20", Offset = "0xAA8E20", VA = "0xAA8E20")]
		public static Vector3 GetPosition(FsmGameObject fsmGameObject, FsmVector3 fsmVector3)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60059F0")]
		[Address(RVA = "0xAA8F38", Offset = "0xAA8F38", VA = "0xAA8F38")]
		public static Vector3 GetDeviceAcceleration()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60059F1")]
		[Address(RVA = "0xAA8F40", Offset = "0xAA8F40", VA = "0xAA8F40")]
		public static Vector3 GetMousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60059F2")]
		[Address(RVA = "0xAA8F48", Offset = "0xAA8F48", VA = "0xAA8F48")]
		public static bool AnyKeyDown()
		{
			return default(bool);
		}

		[Token(Token = "0x60059F3")]
		[Address(RVA = "0xAA8F50", Offset = "0xAA8F50", VA = "0xAA8F50")]
		public static bool IsMouseOver(GameObject gameObject, float distance, int layerMask)
		{
			return default(bool);
		}

		[Token(Token = "0x60059F4")]
		[Address(RVA = "0xAA916C", Offset = "0xAA916C", VA = "0xAA916C")]
		public static RaycastHit MousePick(float distance, int layerMask)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60059F5")]
		[Address(RVA = "0xAA9028", Offset = "0xAA9028", VA = "0xAA9028")]
		public static GameObject MouseOver(float distance, int layerMask)
		{
			return null;
		}

		[Token(Token = "0x60059F6")]
		[Address(RVA = "0xAA9234", Offset = "0xAA9234", VA = "0xAA9234")]
		private static void DoMousePick(float distance, int layerMask)
		{
		}

		[Token(Token = "0x60059F7")]
		[Address(RVA = "0xAA9360", Offset = "0xAA9360", VA = "0xAA9360")]
		public static int LayerArrayToLayerMask(FsmInt[] layers, bool invert)
		{
			return default(int);
		}

		[Token(Token = "0x60059F8")]
		[Address(RVA = "0xAA940C", Offset = "0xAA940C", VA = "0xAA940C")]
		public static bool IsLoopingWrapMode(WrapMode wrapMode)
		{
			return default(bool);
		}

		[Token(Token = "0x60059F9")]
		[Address(RVA = "0xAA9424", Offset = "0xAA9424", VA = "0xAA9424")]
		public static string CheckRayDistance(float rayDistance)
		{
			return null;
		}

		[Token(Token = "0x60059FA")]
		[Address(RVA = "0xAA9490", Offset = "0xAA9490", VA = "0xAA9490")]
		public static string CheckForValidEvent(FsmState state, string eventName)
		{
			return null;
		}

		[Token(Token = "0x60059FB")]
		[Address(RVA = "0xAA9608", Offset = "0xAA9608", VA = "0xAA9608")]
		public static string CheckPhysicsSetup(FsmOwnerDefault ownerDefault)
		{
			return null;
		}

		[Token(Token = "0x60059FC")]
		[Address(RVA = "0xAA97F0", Offset = "0xAA97F0", VA = "0xAA97F0")]
		public static string CheckOwnerPhysicsSetup(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x60059FD")]
		[Address(RVA = "0xAA9674", Offset = "0xAA9674", VA = "0xAA9674")]
		public static string CheckPhysicsSetup(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x60059FE")]
		[Address(RVA = "0xAA97F4", Offset = "0xAA97F4", VA = "0xAA97F4")]
		public static string CheckPhysics2dSetup(FsmOwnerDefault ownerDefault)
		{
			return null;
		}

		[Token(Token = "0x60059FF")]
		[Address(RVA = "0xAA99DC", Offset = "0xAA99DC", VA = "0xAA99DC")]
		public static string CheckOwnerPhysics2dSetup(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6005A00")]
		[Address(RVA = "0xAA9860", Offset = "0xAA9860", VA = "0xAA9860")]
		public static string CheckPhysics2dSetup(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6005A01")]
		[Address(RVA = "0xAA99E0", Offset = "0xAA99E0", VA = "0xAA99E0")]
		public static void DebugLog(Fsm fsm, LogLevel logLevel, string text, bool sendToUnityLog = false)
		{
		}

		[Token(Token = "0x6005A02")]
		[Address(RVA = "0xAA9D98", Offset = "0xAA9D98", VA = "0xAA9D98")]
		public static void LogError(string text)
		{
		}

		[Token(Token = "0x6005A03")]
		[Address(RVA = "0xAA9E08", Offset = "0xAA9E08", VA = "0xAA9E08")]
		public static void LogWarning(string text)
		{
		}

		[Token(Token = "0x6005A04")]
		[Address(RVA = "0xAA9BE0", Offset = "0xAA9BE0", VA = "0xAA9BE0")]
		public static string FormatUnityLogString(string text)
		{
			return null;
		}

		[Token(Token = "0x6005A05")]
		[Address(RVA = "0xAA9E78", Offset = "0xAA9E78", VA = "0xAA9E78")]
		public static string StripTags(string textWithTags)
		{
			return null;
		}

		[Token(Token = "0x6005A06")]
		[Address(RVA = "0xAA9F60", Offset = "0xAA9F60", VA = "0xAA9F60")]
		public static string GetValueLabel(INamedVariable variable)
		{
			return null;
		}

		[Token(Token = "0x6005A07")]
		[Address(RVA = "0xAA9FA4", Offset = "0xAA9FA4", VA = "0xAA9FA4")]
		public static string GetValueLabel(Fsm fsm, FsmOwnerDefault ownerDefault)
		{
			return null;
		}

		[Token(Token = "0x6005A08")]
		[Address(RVA = "0xAAA044", Offset = "0xAAA044", VA = "0xAAA044")]
		public static string AutoName(FsmStateAction action, params INamedVariable[] exposedFields)
		{
			return null;
		}

		[Token(Token = "0x6005A09")]
		[Address(RVA = "0xAAA194", Offset = "0xAAA194", VA = "0xAAA194")]
		public static string AutoName(FsmStateAction action, Fsm fsm, FsmOwnerDefault ownerDefault)
		{
			return null;
		}

		[Token(Token = "0x6005A0A")]
		[Address(RVA = "0xAAA350", Offset = "0xAAA350", VA = "0xAAA350")]
		public static string AutoName(FsmStateAction action, params string[] labels)
		{
			return null;
		}

		[Token(Token = "0x6005A0B")]
		[Address(RVA = "0xAAA39C", Offset = "0xAAA39C", VA = "0xAAA39C")]
		public static string AutoName(FsmStateAction action, FsmEvent fsmEvent)
		{
			return null;
		}

		[Token(Token = "0x6005A0C")]
		[Address(RVA = "0xAAA090", Offset = "0xAAA090", VA = "0xAAA090")]
		public static string AutoName(string actionName, params INamedVariable[] exposedFields)
		{
			return null;
		}

		[Token(Token = "0x6005A0D")]
		[Address(RVA = "0xAAA288", Offset = "0xAAA288", VA = "0xAAA288")]
		public static string AutoName(string actionName, params string[] labels)
		{
			return null;
		}

		[Token(Token = "0x6005A0E")]
		[Address(RVA = "0xAAA4A8", Offset = "0xAAA4A8", VA = "0xAAA4A8")]
		public static string AutoName(FsmStateAction action, Fsm fsm, FsmOwnerDefault target, params INamedVariable[] exposedFields)
		{
			return null;
		}

		[Token(Token = "0x6005A0F")]
		[Address(RVA = "0xAAA4FC", Offset = "0xAAA4FC", VA = "0xAAA4FC")]
		public static string AutoName(string actionName, Fsm fsm, FsmOwnerDefault target, params INamedVariable[] exposedFields)
		{
			return null;
		}

		[Token(Token = "0x6005A10")]
		[Address(RVA = "0xAAA614", Offset = "0xAAA614", VA = "0xAAA614")]
		public static string AutoNameRange(FsmStateAction action, NamedVariable min, NamedVariable max)
		{
			return null;
		}

		[Token(Token = "0x6005A11")]
		[Address(RVA = "0xAAA668", Offset = "0xAAA668", VA = "0xAAA668")]
		public static string AutoNameRange(string actionName, NamedVariable min, NamedVariable max)
		{
			return null;
		}

		[Token(Token = "0x6005A12")]
		[Address(RVA = "0xAAA82C", Offset = "0xAAA82C", VA = "0xAAA82C")]
		public static string AutoNameSetVar(FsmStateAction action, NamedVariable var, NamedVariable value)
		{
			return null;
		}

		[Token(Token = "0x6005A13")]
		[Address(RVA = "0xAAA880", Offset = "0xAAA880", VA = "0xAAA880")]
		public static string AutoNameSetVar(string actionName, NamedVariable var, NamedVariable value)
		{
			return null;
		}

		[Token(Token = "0x6005A14")]
		[Address(RVA = "0xAAAA44", Offset = "0xAAAA44", VA = "0xAAAA44")]
		public static string AutoNameConvert(FsmStateAction action, NamedVariable fromVariable, NamedVariable toVariable)
		{
			return null;
		}

		[Token(Token = "0x6005A15")]
		[Address(RVA = "0xAAAA98", Offset = "0xAAAA98", VA = "0xAAAA98")]
		public static string AutoNameConvert(string actionName, NamedVariable fromVariable, NamedVariable toVariable)
		{
			return null;
		}

		[Token(Token = "0x6005A16")]
		[Address(RVA = "0xAAAC98", Offset = "0xAAAC98", VA = "0xAAAC98")]
		public static string AutoNameGetProperty(FsmStateAction action, NamedVariable property, NamedVariable store)
		{
			return null;
		}

		[Token(Token = "0x6005A17")]
		[Address(RVA = "0xAAACEC", Offset = "0xAAACEC", VA = "0xAAACEC")]
		public static string AutoNameGetProperty(string actionName, NamedVariable property, NamedVariable store)
		{
			return null;
		}

		[Token(Token = "0x6005A18")]
		[Address(RVA = "0xAAAEB0", Offset = "0xAAAEB0", VA = "0xAAAEB0")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x62BF28", Offset = "0x62BF28")]
		public static void RuntimeError(FsmStateAction action, string error)
		{
		}
	}
}
