using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DeltaDNA
{
	[Token(Token = "0x2001321")]
	public class ImageMessage
	{
		[Token(Token = "0x2001322")]
		public class EventArgs : System.EventArgs
		{
			[Token(Token = "0x4005BE1")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6113E0", Offset = "0x6113E0")]
			private string _003CID_003Ek__BackingField;

			[Token(Token = "0x4005BE2")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6113F0", Offset = "0x6113F0")]
			private string _003CActionType_003Ek__BackingField;

			[Token(Token = "0x4005BE3")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611400", Offset = "0x611400")]
			private string _003CActionValue_003Ek__BackingField;

			[Token(Token = "0x17000CE4")]
			public string ID
			{
				[Token(Token = "0x60070A2")]
				[Address(RVA = "0xB22C94", Offset = "0xB22C94", VA = "0xB22C94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D4E0", Offset = "0x62D4E0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60070A3")]
				[Address(RVA = "0xB22C9C", Offset = "0xB22C9C", VA = "0xB22C9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D4F0", Offset = "0x62D4F0")]
				set
				{
				}
			}

			[Token(Token = "0x17000CE5")]
			public string ActionType
			{
				[Token(Token = "0x60070A4")]
				[Address(RVA = "0xB22CA4", Offset = "0xB22CA4", VA = "0xB22CA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D500", Offset = "0x62D500")]
				get
				{
					return null;
				}
				[Token(Token = "0x60070A5")]
				[Address(RVA = "0xB22CAC", Offset = "0xB22CAC", VA = "0xB22CAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D510", Offset = "0x62D510")]
				set
				{
				}
			}

			[Token(Token = "0x17000CE6")]
			public string ActionValue
			{
				[Token(Token = "0x60070A6")]
				[Address(RVA = "0xB22CB4", Offset = "0xB22CB4", VA = "0xB22CB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D520", Offset = "0x62D520")]
				get
				{
					return null;
				}
				[Token(Token = "0x60070A7")]
				[Address(RVA = "0xB22CBC", Offset = "0xB22CBC", VA = "0xB22CBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D530", Offset = "0x62D530")]
				set
				{
				}
			}

			[Token(Token = "0x60070A1")]
			[Address(RVA = "0xB22C08", Offset = "0xB22C08", VA = "0xB22C08")]
			public EventArgs(string id, string type, string value)
			{
			}

			[Token(Token = "0x60070A8")]
			[Address(RVA = "0xB22CC4", Offset = "0xB22CC4", VA = "0xB22CC4")]
			internal static EventArgs Create(string platform, string id, string type, object value)
			{
				return null;
			}
		}

		[Token(Token = "0x2001323")]
		public class StoreEventArgs : EventArgs
		{
			[Token(Token = "0x60070A9")]
			[Address(RVA = "0xB22DDC", Offset = "0xB22DDC", VA = "0xB22DDC")]
			public StoreEventArgs(string platform, string id, string type, object value)
			{
			}
		}

		[Token(Token = "0x2001324")]
		private class SpriteMap : MonoBehaviour
		{
			[Token(Token = "0x2001325")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE8BC", Offset = "0x5AE8BC")]
			private sealed class _003C_003Ec__DisplayClass16_0
			{
				[Token(Token = "0x4005BEA")]
				[FieldOffset(Offset = "0x10")]
				public SpriteMap _003C_003E4__this;

				[Token(Token = "0x4005BEB")]
				[FieldOffset(Offset = "0x18")]
				public Action<string> callback;

				[Token(Token = "0x60070B9")]
				[Address(RVA = "0xA460BC", Offset = "0xA460BC", VA = "0xA460BC")]
				public _003C_003Ec__DisplayClass16_0()
				{
				}

				[Token(Token = "0x60070BA")]
				[Address(RVA = "0xA460C4", Offset = "0xA460C4", VA = "0xA460C4")]
				internal void _003CLoadResource_003Eb__0(Texture2D t)
				{
				}
			}

			[Token(Token = "0x4005BE4")]
			[FieldOffset(Offset = "0x18")]
			private ImageMessageStore store;

			[Token(Token = "0x4005BE5")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, object> configuration;

			[Token(Token = "0x4005BE6")]
			[FieldOffset(Offset = "0x28")]
			private Texture2D texture;

			[Token(Token = "0x4005BE7")]
			[FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611410", Offset = "0x611410")]
			private string _003CURL_003Ek__BackingField;

			[Token(Token = "0x4005BE8")]
			[FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611420", Offset = "0x611420")]
			private int _003CWidth_003Ek__BackingField;

			[Token(Token = "0x4005BE9")]
			[FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611430", Offset = "0x611430")]
			private int _003CHeight_003Ek__BackingField;

			[Token(Token = "0x17000CE7")]
			public string URL
			{
				[Token(Token = "0x60070AA")]
				[Address(RVA = "0xB23670", Offset = "0xB23670", VA = "0xB23670")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D540", Offset = "0x62D540")]
				get
				{
					return null;
				}
				[Token(Token = "0x60070AB")]
				[Address(RVA = "0xB23678", Offset = "0xB23678", VA = "0xB23678")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D550", Offset = "0x62D550")]
				private set
				{
				}
			}

			[Token(Token = "0x17000CE8")]
			public int Width
			{
				[Token(Token = "0x60070AC")]
				[Address(RVA = "0xB23680", Offset = "0xB23680", VA = "0xB23680")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D560", Offset = "0x62D560")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60070AD")]
				[Address(RVA = "0xB23688", Offset = "0xB23688", VA = "0xB23688")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D570", Offset = "0x62D570")]
				private set
				{
				}
			}

			[Token(Token = "0x17000CE9")]
			public int Height
			{
				[Token(Token = "0x60070AE")]
				[Address(RVA = "0xB23690", Offset = "0xB23690", VA = "0xB23690")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D580", Offset = "0x62D580")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60070AF")]
				[Address(RVA = "0xB23698", Offset = "0xB23698", VA = "0xB23698")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D590", Offset = "0x62D590")]
				private set
				{
				}
			}

			[Token(Token = "0x17000CEA")]
			public Texture Texture
			{
				[Token(Token = "0x60070B2")]
				[Address(RVA = "0xB23AA4", Offset = "0xB23AA4", VA = "0xB23AA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CEB")]
			public Sprite Background
			{
				[Token(Token = "0x60070B3")]
				[Address(RVA = "0xB23AAC", Offset = "0xB23AAC", VA = "0xB23AAC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CEC")]
			public List<Sprite> Buttons
			{
				[Token(Token = "0x60070B4")]
				[Address(RVA = "0xB23EA0", Offset = "0xB23EA0", VA = "0xB23EA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60070B0")]
			[Address(RVA = "0xB236A0", Offset = "0xB236A0", VA = "0xB236A0")]
			public void Build(DDNA ddna, Dictionary<string, object> configuration)
			{
			}

			[Token(Token = "0x60070B1")]
			[Address(RVA = "0xB239A4", Offset = "0xB239A4", VA = "0xB239A4")]
			public void LoadResource(Action<string> callback)
			{
			}

			[Token(Token = "0x60070B5")]
			[Address(RVA = "0xB23DF8", Offset = "0xB23DF8", VA = "0xB23DF8")]
			public Sprite GetSubRegion(int x, int y, int width, int height)
			{
				return null;
			}

			[Token(Token = "0x60070B6")]
			[Address(RVA = "0xB24504", Offset = "0xB24504", VA = "0xB24504")]
			public Sprite GetSubRegion(Rect rect)
			{
				return null;
			}

			[Token(Token = "0x60070B7")]
			[Address(RVA = "0xB245AC", Offset = "0xB245AC", VA = "0xB245AC")]
			private void OnDestroy()
			{
			}

			[Token(Token = "0x60070B8")]
			[Address(RVA = "0xB24614", Offset = "0xB24614", VA = "0xB24614")]
			public SpriteMap()
			{
			}
		}

		[Token(Token = "0x2001326")]
		private class Layer : MonoBehaviour
		{
			[Serializable]
			[Token(Token = "0x2001327")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE8CC", Offset = "0x5AE8CC")]
			private sealed class _003C_003Ec
			{
				[Token(Token = "0x4005BF1")]
				[FieldOffset(Offset = "0x0")]
				public static readonly _003C_003Ec _003C_003E9;

				[Token(Token = "0x4005BF2")]
				[FieldOffset(Offset = "0x8")]
				public static Action _003C_003E9__5_0;

				[Token(Token = "0x4005BF3")]
				[FieldOffset(Offset = "0x10")]
				public static Action _003C_003E9__6_0;

				[Token(Token = "0x60070C0")]
				[Address(RVA = "0xA45D74", Offset = "0xA45D74", VA = "0xA45D74")]
				public _003C_003Ec()
				{
				}

				[Token(Token = "0x60070C1")]
				[Address(RVA = "0xA45D7C", Offset = "0xA45D7C", VA = "0xA45D7C")]
				internal void _003CRegisterAction_003Eb__5_0()
				{
				}

				[Token(Token = "0x60070C2")]
				[Address(RVA = "0xA45D80", Offset = "0xA45D80", VA = "0xA45D80")]
				internal void _003CRegisterAction_003Eb__6_0()
				{
				}
			}

			[Token(Token = "0x2001328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE8DC", Offset = "0x5AE8DC")]
			private sealed class _003C_003Ec__DisplayClass6_0
			{
				[Token(Token = "0x4005BF4")]
				[FieldOffset(Offset = "0x10")]
				public object valueObj;

				[Token(Token = "0x4005BF5")]
				[FieldOffset(Offset = "0x18")]
				public Layer _003C_003E4__this;

				[Token(Token = "0x4005BF6")]
				[FieldOffset(Offset = "0x20")]
				public EventArgs eventArgs;

				[Token(Token = "0x4005BF7")]
				[FieldOffset(Offset = "0x28")]
				public GameEvent actionEvent;

				[Token(Token = "0x60070C3")]
				[Address(RVA = "0xA45D84", Offset = "0xA45D84", VA = "0xA45D84")]
				public _003C_003Ec__DisplayClass6_0()
				{
				}

				[Token(Token = "0x60070C4")]
				[Address(RVA = "0xA45D8C", Offset = "0xA45D8C", VA = "0xA45D8C")]
				internal void _003CRegisterAction_003Eb__1()
				{
				}

				[Token(Token = "0x60070C5")]
				[Address(RVA = "0xA45E50", Offset = "0xA45E50", VA = "0xA45E50")]
				internal void _003CRegisterAction_003Eb__2()
				{
				}

				[Token(Token = "0x60070C6")]
				[Address(RVA = "0xA45F44", Offset = "0xA45F44", VA = "0xA45F44")]
				internal void _003CRegisterAction_003Eb__3()
				{
				}

				[Token(Token = "0x60070C7")]
				[Address(RVA = "0xA46000", Offset = "0xA46000", VA = "0xA46000")]
				internal void _003CRegisterAction_003Eb__4()
				{
				}
			}

			[Token(Token = "0x4005BEC")]
			[FieldOffset(Offset = "0x18")]
			protected DDNA ddna;

			[Token(Token = "0x4005BED")]
			[FieldOffset(Offset = "0x20")]
			protected GameObject parent;

			[Token(Token = "0x4005BEE")]
			[FieldOffset(Offset = "0x28")]
			protected ImageMessage imageMessage;

			[Token(Token = "0x4005BEF")]
			[FieldOffset(Offset = "0x30")]
			protected List<Action> actions;

			[Token(Token = "0x4005BF0")]
			[FieldOffset(Offset = "0x38")]
			protected int depth;

			[Token(Token = "0x60070BB")]
			[Address(RVA = "0xB20CC4", Offset = "0xB20CC4", VA = "0xB20CC4")]
			protected void RegisterAction()
			{
			}

			[Token(Token = "0x60070BC")]
			[Address(RVA = "0xB204C4", Offset = "0xB204C4", VA = "0xB204C4")]
			protected void RegisterAction(Dictionary<string, object> action, string id)
			{
			}

			[Token(Token = "0x60070BD")]
			[Address(RVA = "0xB2181C", Offset = "0xB2181C", VA = "0xB2181C")]
			protected void PositionObject(GameObject obj, Rect position)
			{
			}

			[Token(Token = "0x60070BE")]
			[Address(RVA = "0xB21E84", Offset = "0xB21E84", VA = "0xB21E84")]
			public Layer()
			{
			}
		}

		[Token(Token = "0x2001329")]
		private class ShimLayer : Layer
		{
			[Token(Token = "0x4005BF8")]
			[FieldOffset(Offset = "0x40")]
			private Texture2D texture;

			[Token(Token = "0x4005BF9")]
			[FieldOffset(Offset = "0x48")]
			private readonly byte dimmedMaskAlpha;

			[Token(Token = "0x4005BFA")]
			[FieldOffset(Offset = "0x50")]
			private Sprite sprite;

			[Token(Token = "0x60070C8")]
			[Address(RVA = "0xB22F70", Offset = "0xB22F70", VA = "0xB22F70")]
			public void Build(DDNA ddna, GameObject parent, ImageMessage imageMessage, Dictionary<string, object> config, int depth)
			{
			}

			[Token(Token = "0x60070C9")]
			[Address(RVA = "0xB23240", Offset = "0xB23240", VA = "0xB23240")]
			private void Start()
			{
			}

			[Token(Token = "0x60070CA")]
			[Address(RVA = "0xB23574", Offset = "0xB23574", VA = "0xB23574")]
			private void OnDestroy()
			{
			}

			[Token(Token = "0x60070CB")]
			[Address(RVA = "0xB235E8", Offset = "0xB235E8", VA = "0xB235E8")]
			public ShimLayer()
			{
			}

			[Token(Token = "0x60070CC")]
			[Address(RVA = "0xB235F4", Offset = "0xB235F4", VA = "0xB235F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D5A0", Offset = "0x62D5A0")]
			private void _003CStart_003Eb__4_0()
			{
			}
		}

		[Token(Token = "0x200132A")]
		private class BackgroundLayer : Layer
		{
			[Token(Token = "0x4005BFB")]
			[FieldOffset(Offset = "0x3C")]
			private Rect position;

			[Token(Token = "0x4005BFC")]
			[FieldOffset(Offset = "0x4C")]
			private float scale;

			[Token(Token = "0x4005BFD")]
			[FieldOffset(Offset = "0x50")]
			private Sprite sprite;

			[Token(Token = "0x4005BFE")]
			[FieldOffset(Offset = "0x58")]
			private Dictionary<string, object> layout;

			[Token(Token = "0x4005BFF")]
			[FieldOffset(Offset = "0x60")]
			private GameObject obj;

			[Token(Token = "0x17000CED")]
			public Rect Position
			{
				[Token(Token = "0x60070D1")]
				[Address(RVA = "0xB21A08", Offset = "0xB21A08", VA = "0xB21A08")]
				get
				{
					return default(Rect);
				}
			}

			[Token(Token = "0x17000CEE")]
			public float Scale
			{
				[Token(Token = "0x60070D2")]
				[Address(RVA = "0xB21A14", Offset = "0xB21A14", VA = "0xB21A14")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60070CD")]
			[Address(RVA = "0xB20324", Offset = "0xB20324", VA = "0xB20324")]
			public void Build(DDNA ddna, GameObject parent, ImageMessage imageMessage, Dictionary<string, object> layout, Sprite sprite, int depth)
			{
			}

			[Token(Token = "0x60070CE")]
			[Address(RVA = "0xB20DD4", Offset = "0xB20DD4", VA = "0xB20DD4")]
			private void CalculatePosition()
			{
			}

			[Token(Token = "0x60070CF")]
			[Address(RVA = "0xB2180C", Offset = "0xB2180C", VA = "0xB2180C")]
			private void UpdatePosition()
			{
			}

			[Token(Token = "0x60070D0")]
			[Address(RVA = "0xB219D8", Offset = "0xB219D8", VA = "0xB219D8")]
			public void Resize()
			{
			}

			[Token(Token = "0x60070D3")]
			[Address(RVA = "0xB21A1C", Offset = "0xB21A1C", VA = "0xB21A1C")]
			private void Start()
			{
			}

			[Token(Token = "0x60070D4")]
			[Address(RVA = "0xB20FE0", Offset = "0xB20FE0", VA = "0xB20FE0")]
			private Rect RenderAsCover(Dictionary<string, object> rules)
			{
				return default(Rect);
			}

			[Token(Token = "0x60070D5")]
			[Address(RVA = "0xB2131C", Offset = "0xB2131C", VA = "0xB2131C")]
			private Rect RenderAsContain(Dictionary<string, object> rules)
			{
				return default(Rect);
			}

			[Token(Token = "0x60070D6")]
			[Address(RVA = "0xB21CBC", Offset = "0xB21CBC", VA = "0xB21CBC")]
			private float GetConstraintPixels(string constraint, float edge)
			{
				return default(float);
			}

			[Token(Token = "0x60070D7")]
			[Address(RVA = "0xB21E18", Offset = "0xB21E18", VA = "0xB21E18")]
			private void OnDestroy()
			{
			}

			[Token(Token = "0x60070D8")]
			[Address(RVA = "0xB21E80", Offset = "0xB21E80", VA = "0xB21E80")]
			public BackgroundLayer()
			{
			}

			[Token(Token = "0x60070D9")]
			[Address(RVA = "0xB21EFC", Offset = "0xB21EFC", VA = "0xB21EFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D5B0", Offset = "0x62D5B0")]
			private void _003CStart_003Eb__13_0()
			{
			}
		}

		[Token(Token = "0x200132B")]
		private class ButtonsLayer : Layer
		{
			[Token(Token = "0x200132C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE8EC", Offset = "0x5AE8EC")]
			private sealed class _003C_003Ec__DisplayClass8_0
			{
				[Token(Token = "0x4005C05")]
				[FieldOffset(Offset = "0x10")]
				public Action action;

				[Token(Token = "0x60070E0")]
				[Address(RVA = "0xA45CF0", Offset = "0xA45CF0", VA = "0xA45CF0")]
				public _003C_003Ec__DisplayClass8_0()
				{
				}

				[Token(Token = "0x60070E1")]
				[Address(RVA = "0xA45CF8", Offset = "0xA45CF8", VA = "0xA45CF8")]
				internal void _003CStart_003Eb__0()
				{
				}
			}

			[Token(Token = "0x4005C00")]
			[FieldOffset(Offset = "0x40")]
			private List<Sprite> sprites;

			[Token(Token = "0x4005C01")]
			[FieldOffset(Offset = "0x48")]
			private List<Rect> positions;

			[Token(Token = "0x4005C02")]
			[FieldOffset(Offset = "0x50")]
			private BackgroundLayer content;

			[Token(Token = "0x4005C03")]
			[FieldOffset(Offset = "0x58")]
			private Dictionary<string, object> orientation;

			[Token(Token = "0x4005C04")]
			[FieldOffset(Offset = "0x60")]
			private List<GameObject> buttonObjects;

			[Token(Token = "0x60070DA")]
			[Address(RVA = "0xB21F78", Offset = "0xB21F78", VA = "0xB21F78")]
			public void Build(DDNA ddna, GameObject parent, ImageMessage imageMessage, Dictionary<string, object> orientation, List<Sprite> sprites, BackgroundLayer content, int depth)
			{
			}

			[Token(Token = "0x60070DB")]
			[Address(RVA = "0xB2254C", Offset = "0xB2254C", VA = "0xB2254C")]
			public void Resize()
			{
			}

			[Token(Token = "0x60070DC")]
			[Address(RVA = "0xB22050", Offset = "0xB22050", VA = "0xB22050")]
			private void UpdatePositions(bool shouldRegisterActions = false)
			{
			}

			[Token(Token = "0x60070DD")]
			[Address(RVA = "0xB2264C", Offset = "0xB2264C", VA = "0xB2264C")]
			private void Start()
			{
			}

			[Token(Token = "0x60070DE")]
			[Address(RVA = "0xB229D0", Offset = "0xB229D0", VA = "0xB229D0")]
			private void OnDestroy()
			{
			}

			[Token(Token = "0x60070DF")]
			[Address(RVA = "0xB22B14", Offset = "0xB22B14", VA = "0xB22B14")]
			public ButtonsLayer()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200132D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE8FC", Offset = "0x5AE8FC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005C06")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005C07")]
			[FieldOffset(Offset = "0x8")]
			public static Action<string> _003C_003E9__34_0;

			[Token(Token = "0x60070E3")]
			[Address(RVA = "0xB20318", Offset = "0xB20318", VA = "0xB20318")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60070E4")]
			[Address(RVA = "0xB20320", Offset = "0xB20320", VA = "0xB20320")]
			internal void _003CShow_003Eb__34_0(string e)
			{
			}
		}

		[Token(Token = "0x4005BD7")]
		[FieldOffset(Offset = "0x38")]
		private readonly DDNA ddna;

		[Token(Token = "0x4005BD8")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, object> configuration;

		[Token(Token = "0x4005BD9")]
		[FieldOffset(Offset = "0x48")]
		private GameObject gameObject;

		[Token(Token = "0x4005BDA")]
		[FieldOffset(Offset = "0x50")]
		private SpriteMap spriteMap;

		[Token(Token = "0x4005BDB")]
		[FieldOffset(Offset = "0x58")]
		private int depth;

		[Token(Token = "0x4005BDC")]
		[FieldOffset(Offset = "0x5C")]
		private bool showing;

		[Token(Token = "0x4005BDD")]
		[FieldOffset(Offset = "0x60")]
		private Engagement engagement;

		[Token(Token = "0x4005BDE")]
		[FieldOffset(Offset = "0x68")]
		private string name;

		[Token(Token = "0x4005BDF")]
		[FieldOffset(Offset = "0x70")]
		private OrientationChange changeListener;

		[Token(Token = "0x4005BE0")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6113D0", Offset = "0x6113D0")]
		private Dictionary<string, object> _003CParameters_003Ek__BackingField;

		[Token(Token = "0x17000CE3")]
		public Dictionary<string, object> Parameters
		{
			[Token(Token = "0x600709E")]
			[Address(RVA = "0xA18B54", Offset = "0xA18B54", VA = "0xA18B54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D4B0", Offset = "0x62D4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600709F")]
			[Address(RVA = "0xA18B5C", Offset = "0xA18B5C", VA = "0xA18B5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D4C0", Offset = "0x62D4C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1400019D")]
		public event Action OnDidReceiveResources
		{
			[Token(Token = "0x6007089")]
			[Address(RVA = "0xA1716C", Offset = "0xA1716C", VA = "0xA1716C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D410", Offset = "0x62D410")]
			add
			{
			}
			[Token(Token = "0x600708A")]
			[Address(RVA = "0xA1720C", Offset = "0xA1720C", VA = "0xA1720C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D420", Offset = "0x62D420")]
			remove
			{
			}
		}

		[Token(Token = "0x1400019E")]
		public event Action<string> OnDidFailToReceiveResources
		{
			[Token(Token = "0x600708B")]
			[Address(RVA = "0xA172AC", Offset = "0xA172AC", VA = "0xA172AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D430", Offset = "0x62D430")]
			add
			{
			}
			[Token(Token = "0x600708C")]
			[Address(RVA = "0xA1734C", Offset = "0xA1734C", VA = "0xA1734C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D440", Offset = "0x62D440")]
			remove
			{
			}
		}

		[Token(Token = "0x1400019F")]
		public event Action<EventArgs> OnDismiss
		{
			[Token(Token = "0x600708D")]
			[Address(RVA = "0xA173EC", Offset = "0xA173EC", VA = "0xA173EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D450", Offset = "0x62D450")]
			add
			{
			}
			[Token(Token = "0x600708E")]
			[Address(RVA = "0xA1748C", Offset = "0xA1748C", VA = "0xA1748C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D460", Offset = "0x62D460")]
			remove
			{
			}
		}

		[Token(Token = "0x140001A0")]
		public event Action<EventArgs> OnAction
		{
			[Token(Token = "0x600708F")]
			[Address(RVA = "0xA1752C", Offset = "0xA1752C", VA = "0xA1752C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D470", Offset = "0x62D470")]
			add
			{
			}
			[Token(Token = "0x6007090")]
			[Address(RVA = "0xA175CC", Offset = "0xA175CC", VA = "0xA175CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D480", Offset = "0x62D480")]
			remove
			{
			}
		}

		[Token(Token = "0x140001A1")]
		public event Action<EventArgs> OnStore
		{
			[Token(Token = "0x6007091")]
			[Address(RVA = "0xA1766C", Offset = "0xA1766C", VA = "0xA1766C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D490", Offset = "0x62D490")]
			add
			{
			}
			[Token(Token = "0x6007092")]
			[Address(RVA = "0xA1770C", Offset = "0xA1770C", VA = "0xA1770C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D4A0", Offset = "0x62D4A0")]
			remove
			{
			}
		}

		[Token(Token = "0x6007093")]
		[Address(RVA = "0xA177AC", Offset = "0xA177AC", VA = "0xA177AC")]
		private ImageMessage(DDNA ddna, Dictionary<string, object> configuration, string name, int depth, Engagement engagement)
		{
		}

		[Token(Token = "0x6007094")]
		[Address(RVA = "0xA179D4", Offset = "0xA179D4", VA = "0xA179D4")]
		private void redraw()
		{
		}

		[Token(Token = "0x6007095")]
		[Address(RVA = "0xA17A64", Offset = "0xA17A64", VA = "0xA17A64")]
		public static ImageMessage Create(Engagement engagement)
		{
			return null;
		}

		[Token(Token = "0x6007096")]
		[Address(RVA = "0xA17F5C", Offset = "0xA17F5C", VA = "0xA17F5C")]
		public static ImageMessage Create(Engagement engagement, Dictionary<string, object> options)
		{
			return null;
		}

		[Token(Token = "0x6007097")]
		[Address(RVA = "0xA17AE4", Offset = "0xA17AE4", VA = "0xA17AE4")]
		public static ImageMessage Create(DDNA ddna, Engagement engagement, Dictionary<string, object> options)
		{
			return null;
		}

		[Token(Token = "0x6007098")]
		[Address(RVA = "0xA17FE8", Offset = "0xA17FE8", VA = "0xA17FE8")]
		private static bool ValidConfiguration(Dictionary<string, object> c)
		{
			return default(bool);
		}

		[Token(Token = "0x6007099")]
		[Address(RVA = "0xA1823C", Offset = "0xA1823C", VA = "0xA1823C")]
		public void FetchResources()
		{
		}

		[Token(Token = "0x600709A")]
		[Address(RVA = "0xA1831C", Offset = "0xA1831C", VA = "0xA1831C")]
		public bool IsReady()
		{
			return default(bool);
		}

		[Token(Token = "0x600709B")]
		[Address(RVA = "0xA18368", Offset = "0xA18368", VA = "0xA18368")]
		public void Show()
		{
		}

		[Token(Token = "0x600709C")]
		[Address(RVA = "0xA18AD4", Offset = "0xA18AD4", VA = "0xA18AD4")]
		public bool IsShowing()
		{
			return default(bool);
		}

		[Token(Token = "0x600709D")]
		[Address(RVA = "0xA18ADC", Offset = "0xA18ADC", VA = "0xA18ADC")]
		public void Close()
		{
		}

		[Token(Token = "0x60070A0")]
		[Address(RVA = "0xA18B64", Offset = "0xA18B64", VA = "0xA18B64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D4D0", Offset = "0x62D4D0")]
		private void _003CFetchResources_003Eb__32_0(string error)
		{
		}
	}
}
