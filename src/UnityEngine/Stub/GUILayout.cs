using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections;

namespace UnityEngine
{


// The GUILayout class is the interface for Unity gui with automatic layout.
public class GUILayout
{
	static public void Label (string text, params GUILayoutOption[] options) {}
	/*
	/// *listonly*
	CSRAW static public void Label (Texture image, params GUILayoutOption[] options)					{ DoLabel (GUIContent.Temp (image), GUI.skin.label, options); }
	/// *listonly*
	CSRAW 						{ DoLabel (GUIContent.Temp (text), GUI.skin.label, options); }
	/// *listonly*
	CSRAW static public void Label (GUIContent content, params GUILayoutOption[] options)				{ DoLabel (content, GUI.skin.label, options); }
	/// *listonly*
	CSRAW static public void Label (Texture image, GUIStyle style, params GUILayoutOption[] options)		{ DoLabel (GUIContent.Temp (image), style, options); }
	/// *listonly*
	CSRAW static public void Label (string text, GUIStyle style, params GUILayoutOption[] options)			{ DoLabel (GUIContent.Temp (text), style, options); }
	// Make an auto-layout label.
	CSRAW static public void Label (GUIContent content, GUIStyle style, params GUILayoutOption[] options)	{ DoLabel (content, style, options); }
	CSRAW static void DoLabel (GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{ GUI.Label (GUILayoutUtility.GetRect (content, style, options), content, style); }


	/// *listonly*
	CSRAW static public void Box (Texture image, params GUILayoutOption[] options)					{ DoBox (GUIContent.Temp (image), GUI.skin.box, options); }
	/// *listonly*
	CSRAW static public void Box (string text, params GUILayoutOption[] options)						{ DoBox (GUIContent.Temp (text), GUI.skin.box, options); }
	/// *listonly*
	CSRAW static public void Box (GUIContent content, params GUILayoutOption[] options)				{ DoBox (content, GUI.skin.box, options); }
	/// *listonly*
	CSRAW static public void Box (Texture image, GUIStyle style, params GUILayoutOption[] options)		{ DoBox (GUIContent.Temp (image), style, options); }
	/// *listonly*
	CSRAW static public void Box (string text, GUIStyle style, params GUILayoutOption[] options)			{ DoBox (GUIContent.Temp (text), style, options); }
	// Make an auto-layout box.
	CSRAW static public void Box (GUIContent content, GUIStyle style, params GUILayoutOption[] options)	{ DoBox (content, style, options); }
	CSRAW static void DoBox (GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{ GUI.Box (GUILayoutUtility.GetRect (content, style, options), content, style); }

	/// *listonly*
	CSRAW static public bool Button (Texture image, params GUILayoutOption[] options)					{ return DoButton (GUIContent.Temp (image), GUI.skin.button, options); }
	/// *listonly*
	CSRAW static public bool Button (string text, params GUILayoutOption[] options)						{ return DoButton (GUIContent.Temp (text), GUI.skin.button, options); }
	/// *listonly*
	CSRAW static public bool Button (GUIContent content, params GUILayoutOption[] options)				{ return DoButton (content, GUI.skin.button, options); }
	/// *listonly*
	CSRAW static public bool Button (Texture image, GUIStyle style, params GUILayoutOption[] options)		{ return DoButton (GUIContent.Temp (image), style, options); }
	/// *listonly*
	CSRAW static public bool Button (string text, GUIStyle style, params GUILayoutOption[] options)			{ return DoButton (GUIContent.Temp (text), style, options); }
	// Make a single press button. The user clicks them and something happens immediately.
	CSRAW static public bool Button (GUIContent content, GUIStyle style, params GUILayoutOption[] options)	{ return DoButton (content, style, options); }
	CSRAW static bool DoButton (GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{ return GUI.Button (GUILayoutUtility.GetRect (content, style, options), content, style); }



	/// *listonly*
	CSRAW static public bool RepeatButton (Texture image, params GUILayoutOption[] options)				{ return DoRepeatButton (GUIContent.Temp (image), GUI.skin.button, options); }
	/// *listonly*
	CSRAW static public bool RepeatButton (string text, params GUILayoutOption[] options)						{ return DoRepeatButton (GUIContent.Temp (text), GUI.skin.button, options); }
	/// *listonly*
	CSRAW static public bool RepeatButton (GUIContent content, params GUILayoutOption[] options)				{ return DoRepeatButton (content, GUI.skin.button, options); }
	/// *listonly*
	CSRAW static public bool RepeatButton (Texture image, GUIStyle style, params GUILayoutOption[] options)	{ return DoRepeatButton (GUIContent.Temp (image), style, options); }
	/// *listonly*
	CSRAW static public bool RepeatButton (string text, GUIStyle style, params GUILayoutOption[] options)			{ return DoRepeatButton (GUIContent.Temp (text), style, options); }
	// Make a repeating button. The button returns true as long as the user holds down the mouse
	CSRAW static public bool RepeatButton (GUIContent content, GUIStyle style, params GUILayoutOption[] options)	{ return DoRepeatButton (content, style, options); }
	CSRAW static bool DoRepeatButton (GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{ return GUI.RepeatButton (GUILayoutUtility.GetRect (content, style, options), content, style); }

	/// *listonly*
	CSRAW public static string TextField (string text, params GUILayoutOption[] options)							{ return DoTextField (text, -1, false, GUI.skin.textField, options); }
	/// *listonly*
	CSRAW public static string TextField (string text, int maxLength, params GUILayoutOption[] options)				{ return DoTextField (text, maxLength, false, GUI.skin.textField, options); }
	/// *listonly*
	CSRAW public static string TextField (string text, GUIStyle style, params GUILayoutOption[] options)				{ return DoTextField (text, -1, false, style, options); }
	// Make a single-line text field where the user can edit a string.
	CSRAW public static string TextField (string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)		{ return DoTextField (text, maxLength, true, style, options); }

	/// *listonly*
	CSRAW public static string PasswordField (string password, char maskChar, params GUILayoutOption[] options) {
		return PasswordField(password, maskChar, -1, GUI.skin.textField, options);
	}
	/// *listonly*
	CSRAW public static string PasswordField (string password, char maskChar, int maxLength, params GUILayoutOption[] options)	{
		return PasswordField(password, maskChar, maxLength, GUI.skin.textField, options);
	}
	/// *listonly*
	CSRAW public static string PasswordField (string password, char maskChar, GUIStyle style, params GUILayoutOption[] options) {
		return PasswordField(password, maskChar, -1, style, options);
	}
	// Make a text field where the user can enter a password.
	CSRAW public static string PasswordField (string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options)	{
		GUIContent t = GUIContent.Temp (GUI.PasswordFieldGetStrToShow(password, maskChar));
		return GUI.PasswordField(GUILayoutUtility.GetRect (t, GUI.skin.textField, options), password, maskChar, maxLength, style);
	}

	/// *listonly*
	CSRAW public static string TextArea (string text, params GUILayoutOption[] options)							{ return DoTextField (text, -1, true, GUI.skin.textArea, options); }
	/// *listonly*
	CSRAW public static string TextArea (string text, int maxLength, params GUILayoutOption[] options)				{ return DoTextField (text, maxLength, true, GUI.skin.textArea, options); }
	/// *listonly*
	CSRAW public static string TextArea (string text, GUIStyle style, params GUILayoutOption[] options)				{ return DoTextField (text, -1, true, style, options); }
	// Make a multi-line text field where the user can edit a string.
	CSRAW public static string TextArea (string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)	{ return DoTextField (text, maxLength, true, style, options); }

	CSRAW static string DoTextField (string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) {
		int id = GUIUtility.GetControlID (FocusType.Keyboard);
		GUIContent content = GUIContent.Temp (text);
		Rect r;
		if (GUIUtility.keyboardControl != id)
			content = GUIContent.Temp (text);
		else
			content = GUIContent.Temp (text + Input.compositionString);

		r = GUILayoutUtility.GetRect (content, style, options);
		if (GUIUtility.keyboardControl == id)
			content = GUIContent.Temp (text);
		GUI.DoTextField (r, id, content, multiline, maxLength, style);
		return content.text;
	}
	
	/// *listonly*
	CSRAW static public bool Toggle (bool value, Texture image, params GUILayoutOption[] options)				{ return DoToggle (value, GUIContent.Temp (image), GUI.skin.toggle, options); }
	/// *listonly*
	CSRAW static public bool Toggle (bool value, string text, params GUILayoutOption[] options)						{ return DoToggle (value, GUIContent.Temp (text), GUI.skin.toggle, options); }
	/// *listonly*
	CSRAW static public bool Toggle (bool value, GUIContent content, params GUILayoutOption[] options)				{ return DoToggle (value, content, GUI.skin.toggle, options); }
	/// *listonly*
	CSRAW static public bool Toggle (bool value, Texture image, GUIStyle style, params GUILayoutOption[] options)	{ return DoToggle (value, GUIContent.Temp (image), style, options); }
	/// *listonly*
	CSRAW static public bool Toggle (bool value, string text, GUIStyle style, params GUILayoutOption[] options)			{ return DoToggle (value, GUIContent.Temp (text), style, options); }
	// Make an on/off toggle button.
	CSRAW static public bool Toggle (bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)	{ return DoToggle (value, content, style, options); }

	//*undocumented*
	CSRAW static bool DoToggle (bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{ return GUI.Toggle (GUILayoutUtility.GetRect (content, style, options), value, content, style); }



	/// *listonly*
	CSRAW public static int Toolbar (int selected, string[] texts, params GUILayoutOption[] options)					{ return Toolbar (selected, GUIContent.Temp (texts), GUI.skin.button, options); }
	/// *listonly*
	CSRAW public static int Toolbar (int selected, Texture[] images, params GUILayoutOption[] options)				{ return Toolbar (selected, GUIContent.Temp (images), GUI.skin.button, options); }
	/// *listonly*
	CSRAW public static int Toolbar (int selected, GUIContent[] content, params GUILayoutOption[] options)				{ return Toolbar (selected, content, GUI.skin.button, options); }
	/// *listonly*
	CSRAW public static int Toolbar (int selected, string[] texts, GUIStyle style, params GUILayoutOption[] options)		{ return Toolbar (selected, GUIContent.Temp (texts), style, options); }
	/// *listonly*
	CSRAW public static int Toolbar (int selected, Texture[] images, GUIStyle style, params GUILayoutOption[] options)	{ return Toolbar (selected, GUIContent.Temp (images), style, options); }
	// Make a toolbar
	CSRAW	public static int Toolbar (int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options) {
		GUIStyle firstStyle, midStyle, lastStyle;
		GUI.FindStyles (ref style, out firstStyle, out midStyle, out lastStyle, "left", "mid", "right");

		Vector2 size = new Vector2();
		int count = contents.Length;
		GUIStyle currentStyle = count > 1 ? firstStyle : style;
		GUIStyle nextStyle = count > 1 ? midStyle : style;
		GUIStyle endStyle = count > 1 ? lastStyle : style;
		int margins = currentStyle.margin.left;

		for (int i = 0; i < contents.Length; i++)
		{
			if (i == count - 2)
			{
				currentStyle = nextStyle;
				nextStyle = endStyle;
			}
			if (i == count - 1)
				currentStyle = endStyle;
			
			Vector2 thisSize = currentStyle.CalcSize (contents[i]);
			
			if (thisSize.x > size.x)
				size.x = thisSize.x;
			if (thisSize.y > size.y)
				size.y = thisSize.y;
			
			if (i == count - 1)
				margins += currentStyle.margin.right;
			else
				margins += Mathf.Max (currentStyle.margin.right, nextStyle.margin.left);
		}
		
		size.x = size.x * contents.Length + margins;
		
		return GUI.Toolbar (GUILayoutUtility.GetRect (size.x, size.y, style, options), selected, contents, style);
	}

	/// *listonly*
	CSRAW public static int SelectionGrid (int selected, string[] texts, int xCount, params GUILayoutOption[] options)						{ return SelectionGrid (selected, GUIContent.Temp (texts), xCount, GUI.skin.button, options); }
	/// *listonly*
	CSRAW public static int SelectionGrid (int selected, Texture[] images, int xCount, params GUILayoutOption[] options)					{ return SelectionGrid (selected, GUIContent.Temp (images), xCount, GUI.skin.button, options); }
	/// *listonly*
	CSRAW public static int SelectionGrid (int selected, GUIContent[] content, int xCount, params GUILayoutOption[] options)				{ return SelectionGrid (selected, content, xCount, GUI.skin.button, options); }
	/// *listonly*
	CSRAW public static int SelectionGrid (int selected, string[] texts, int xCount, GUIStyle style, params GUILayoutOption[] options)			{ return SelectionGrid (selected, GUIContent.Temp (texts), xCount, style, options); }
	/// *listonly*
	CSRAW public static int SelectionGrid (int selected, Texture[] images, int xCount, GUIStyle style, params GUILayoutOption[] options)		{ return SelectionGrid (selected, GUIContent.Temp (images), xCount, style, options); }
	// Make a Selection Grid
	CSRAW public static int SelectionGrid (int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options) {
		return GUI.SelectionGrid (GUIGridSizer.GetRect (contents, xCount, style, options), selected, contents, xCount, style);
	}

	/// *listonly*
	static public float HorizontalSlider (float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{ return DoHorizontalSlider(value, leftValue, rightValue, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, options); }
	// A horizontal slider the user can drag to change a value between a min and a max.
	static public float HorizontalSlider (float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{ return DoHorizontalSlider(value, leftValue, rightValue, slider, thumb, options); }
	static float DoHorizontalSlider (float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options)
		{ return GUI.HorizontalSlider(GUILayoutUtility.GetRect (GUIContent.Temp ("mmmm"), slider, options), value, leftValue, rightValue, slider, thumb); }
	
	/// *listonly*
	static public float VerticalSlider (float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{ return DoVerticalSlider(value, leftValue, rightValue, GUI.skin.verticalSlider, GUI.skin.verticalSliderThumb, options); }
	// A vertical slider the user can drag to change a value between a min and a max.
	static public float VerticalSlider (float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{ return DoVerticalSlider(value, leftValue, rightValue, slider, thumb, options); }
	static float DoVerticalSlider (float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{ return GUI.VerticalSlider(GUILayoutUtility.GetRect (GUIContent.Temp ("\n\n\n\n\n"), slider, options), value, leftValue, rightValue, slider, thumb); }


	/// *listonly*
	CSRAW public static float HorizontalScrollbar (float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
		{ return HorizontalScrollbar (value, size, leftValue, rightValue, GUI.skin.horizontalScrollbar, options); }
	// Make a horiztonal scrollbar.
	CSRAW public static float HorizontalScrollbar (float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
		{ return GUI.HorizontalScrollbar (GUILayoutUtility.GetRect (GUIContent.Temp ("mmmm"), style, options), value, size, leftValue, rightValue, style); }



	/// *listonly*
	CSRAW public static float VerticalScrollbar (float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options)
		{ return VerticalScrollbar (value, size, topValue, bottomValue, GUI.skin.verticalScrollbar, options); }
	// Make a vertical scrollbar.
	CSRAW public static float VerticalScrollbar (float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options)
		{ return GUI.VerticalScrollbar (GUILayoutUtility.GetRect (GUIContent.Temp ("\n\n\n\n"), style, options), value, size, topValue, bottomValue, style); }

	// Insert a space in the current layout group.
	CSRAW static public void Space (float pixels) {
		GUIUtility.CheckOnGUI();
		if (GUILayoutUtility.current.topLevel.isVertical)
			GUILayoutUtility.GetRect (0, pixels, GUILayoutUtility.spaceStyle, GUILayout.Height (pixels));
		else
			GUILayoutUtility.GetRect (pixels, 0, GUILayoutUtility.spaceStyle, GUILayout.Width (pixels));
	}

	// Insert a flexible space element.
	CSRAW static public void FlexibleSpace () {
		GUIUtility.CheckOnGUI();
		GUILayoutOption op;
		if (GUILayoutUtility.current.topLevel.isVertical)
			op = ExpandHeight (true);
		else
			op = ExpandWidth (true);

		op.value = 10000;
		GUILayoutUtility.GetRect (0,0, GUILayoutUtility.spaceStyle, op);
	}

	


	/// *listonly*
	CSRAW public static void BeginHorizontal (params GUILayoutOption[] options)
		{ BeginHorizontal (GUIContent.none, GUIStyle.none, options); }
	/// *listonly*
	CSRAW public static void BeginHorizontal (GUIStyle style, params GUILayoutOption[] options)
		{ BeginHorizontal (GUIContent.none, style, options); }
	/// *listonly*
	CSRAW public static void BeginHorizontal (string text, GUIStyle style, params GUILayoutOption[] options)
		{ BeginHorizontal (GUIContent.Temp(text), style, options); }
	/// *listonly*
	CSRAW public static void BeginHorizontal (Texture image, GUIStyle style, params GUILayoutOption[] options)
		{ BeginHorizontal (GUIContent.Temp(image), style, options); }
	// Begin a Horizontal control group.
	CSRAW public static void BeginHorizontal (GUIContent content, GUIStyle style, params GUILayoutOption[] options) {
		GUILayoutGroup g = GUILayoutUtility.BeginLayoutGroup (style, options, typeof (GUILayoutGroup));
		g.isVertical = false;
		if (style != GUIStyle.none || content != GUIContent.none)
			GUI.Box (g.rect, content, style);
	}

	// Close a group started with BeginHorizontal
	CSRAW public static void EndHorizontal () {
		GUILayoutUtility.EndGroup ("GUILayout.EndHorizontal");
		GUILayoutUtility.EndLayoutGroup ();
	}

	/// *listonly*
	CSRAW public static void BeginVertical (params GUILayoutOption[] options)
		{ BeginVertical (GUIContent.none, GUIStyle.none, options); }
	/// *listonly*
	CSRAW public static void BeginVertical (GUIStyle style, params GUILayoutOption[] options)
		{ BeginVertical (GUIContent.none, style, options); }
	/// *listonly*
	CSRAW public static void BeginVertical (string text, GUIStyle style, params GUILayoutOption[] options)
		{ BeginVertical (GUIContent.Temp(text), style, options); }
	/// *listonly*
	CSRAW public static void BeginVertical (Texture image, GUIStyle style, params GUILayoutOption[] options)
		{ BeginVertical (GUIContent.Temp(image), style, options); }
	// Begin a vertical control group.
	CSRAW public static void BeginVertical (GUIContent content, GUIStyle style, params GUILayoutOption[] options) {
		GUILayoutGroup g = GUILayoutUtility.BeginLayoutGroup (style, options, typeof (GUILayoutGroup));
		g.isVertical = true;
		if (style != GUIStyle.none)
			GUI.Box (g.rect, content, style);
	}

	// Close a group started with BeginVertical
	CSRAW public static void EndVertical () {
		GUILayoutUtility.EndGroup ("GUILayout.EndVertical");
		GUILayoutUtility.EndLayoutGroup ();
	}


	/// *listonly*
	CSRAW static public void BeginArea (Rect screenRect)									{ BeginArea (screenRect, GUIContent.none, GUIStyle.none);			}
	/// *listonly*
	CSRAW static public void BeginArea (Rect screenRect, string text)							{ BeginArea (screenRect, GUIContent.Temp (text), GUIStyle.none);		}
	/// *listonly*
	CSRAW static public void BeginArea (Rect screenRect, Texture image)					{ BeginArea (screenRect, GUIContent.Temp (image), GUIStyle.none);	}
	/// *listonly*
	CSRAW static public void BeginArea (Rect screenRect, GUIContent content)					{ BeginArea (screenRect, GUIContent.none, GUIStyle.none);			}
	/// *listonly*
	CSRAW static public void BeginArea (Rect screenRect, GUIStyle style)						{ BeginArea (screenRect, GUIContent.none, style);			}
	/// *listonly*
	CSRAW static public void BeginArea (Rect screenRect, string text, GUIStyle style)				{ BeginArea (screenRect, GUIContent.Temp (text), style);		}
	/// *listonly*
	CSRAW static public void BeginArea (Rect screenRect, Texture image, GUIStyle style)		{ BeginArea (screenRect, GUIContent.Temp (image), style);	}

	// Begin a GUILayout block of GUI controls in a fixed screen area.
	CSRAW static public void BeginArea (Rect screenRect, GUIContent content, GUIStyle style)
	{
		GUIUtility.CheckOnGUI ();
		GUILayoutGroup g = GUILayoutUtility.BeginLayoutArea (style, typeof (GUILayoutGroup));
		if (Event.current.type == EventType.Layout)
		{
			g.resetCoords = true;
			g.minWidth = g.maxWidth = screenRect.width;
			g.minHeight = g.maxHeight = screenRect.height;
			g.rect = Rect.MinMaxRect(screenRect.xMin, screenRect.yMin, g.rect.xMax, g.rect.yMax);
		}
		
		GUI.BeginGroup (g.rect, content, style);
	}
	
	// Close a GUILayout block started with BeginArea
	CSRAW static public void EndArea () {
		GUIUtility.CheckOnGUI ();
		if (Event.current.type == EventType.Used)
			return;
		GUILayoutUtility.current.layoutGroups.Pop ();
		GUILayoutUtility.current.topLevel = (GUILayoutGroup)GUILayoutUtility.current.layoutGroups.Peek ();
		GUI.EndGroup ();
	}


// ====================================================== SCROLLVIEWS ===============================
	/// *listonly*
	CSRAW public static Vector2 BeginScrollView (Vector2 scrollPosition, params GUILayoutOption[] options)		{ return BeginScrollView (scrollPosition, false, false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options); }
	/// *listonly*
	CSRAW public static Vector2 BeginScrollView (Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)		{ return BeginScrollView (scrollPosition, alwaysShowHorizontal, alwaysShowVertical, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options); }
	/// *listonly*
	CSRAW public static Vector2 BeginScrollView (Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)		{ return BeginScrollView (scrollPosition, false, false, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options); }

	// We need to keep both of the following versions of BeginScrollView() since it was added with a different signature in 3.5
	// Adding an optional argument with params unfortunately *does* change the function signature
	/// *listonly*
	CSRAW public static Vector2 BeginScrollView (Vector2 scrollPosition, GUIStyle style)
	{
		GUILayoutOption[] option = null;
		return BeginScrollView (scrollPosition, style, option);
	}
	/// *listonly*
	CSRAW public static Vector2 BeginScrollView (Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
	{
		string name = style.name;
		
		GUIStyle vertical = GUI.skin.FindStyle (name + "VerticalScrollbar");
		if (vertical == null)
			vertical = GUI.skin.verticalScrollbar;
		GUIStyle horizontal = GUI.skin.FindStyle (name + "HorizontalScrollbar");
		if (horizontal == null)
			horizontal = GUI.skin.horizontalScrollbar;
		return BeginScrollView (scrollPosition, false, false, horizontal, vertical, style, options);
	}

	/// *listonly*
	CSRAW public static Vector2 BeginScrollView (Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{ return BeginScrollView (scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options); }

	// Begin an automatically laid out scrollview.
	CSRAW public static Vector2 BeginScrollView (Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options) {
		GUIUtility.CheckOnGUI();
	
		GUIScrollGroup g = (GUIScrollGroup)GUILayoutUtility.BeginLayoutGroup (background, null, typeof (GUIScrollGroup));
		switch (Event.current.type) {
		case EventType.Layout:
			g.resetCoords = true;
			g.isVertical = true;
			g.stretchWidth = 1;
			g.stretchHeight = 1;
			g.verticalScrollbar = verticalScrollbar;
			g.horizontalScrollbar = horizontalScrollbar;
			g.needsVerticalScrollbar = alwaysShowVertical;
			g.needsHorizontalScrollbar = alwaysShowHorizontal;
			g.ApplyOptions (options);
			break;
		default:
			break;
		}
		return GUI.BeginScrollView (g.rect, scrollPosition, new Rect (0,0,g.clientWidth,g.clientHeight), alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background);
	}
	// End a scroll view begun with a call to BeginScrollView.
	public static void EndScrollView () {
		EndScrollView (true);
	}
	
	
	internal static void EndScrollView (bool handleScrollWheel) {
		GUILayoutUtility.EndGroup ("GUILayout.EndScrollView");
		GUILayoutUtility.EndLayoutGroup ();
		GUI.EndScrollView (handleScrollWheel);
	}

	/// *listonly*
	CSRAW public static Rect Window (int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[ ] options)						{ return DoWindow (id, screenRect, func, GUIContent.Temp (text), GUI.skin.window, options); }
	/// *listonly*
	CSRAW public static Rect Window (int id, Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[ ] options)				{ return DoWindow (id, screenRect, func, GUIContent.Temp (image), GUI.skin.window, options); }
	/// *listonly*
	CSRAW public static Rect Window (int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[ ] options)				{ return DoWindow (id, screenRect, func, content, GUI.skin.window, options); }
	/// *listonly*
	CSRAW public static Rect Window (int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[ ] options)			{ return DoWindow (id, screenRect, func, GUIContent.Temp (text), style, options); }
	/// *listonly*
	CSRAW public static Rect Window (int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[ ] options)	{ return DoWindow (id, screenRect, func, GUIContent.Temp (image), style, options); }

	// Make a popup window that layouts its contents automatically.
	CSRAW public static Rect Window (int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[ ] options)	{ return DoWindow (id, screenRect, func, content, style, options); }
	// Make an auto-sized draggable window...
	CSRAW static Rect DoWindow (int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[ ] options)  {
		GUIUtility.CheckOnGUI ();
		LayoutedWindow lw = new LayoutedWindow (func, screenRect, content, options, style);
		return GUI.Window (id, screenRect, lw.DoWindow, content, style);
	}

	CLASS private LayoutedWindow
		CSRAW
		GUI.WindowFunction func;
		Rect screenRect;
		GUILayoutOption[ ] options;
		GUIStyle style;
		//*undocumented*
		internal LayoutedWindow (GUI.WindowFunction f, Rect _screenRect, GUIContent _content, GUILayoutOption[ ] _options, GUIStyle _style) {
			func = f;
			screenRect = _screenRect;
			options = _options;
			style = _style;
		}
		
		//*undocumented*
		public void DoWindow (int windowID) {
			GUILayoutGroup g = GUILayoutUtility.current.topLevel;
			
			switch (Event.current.type) {
			case EventType.Layout:
				// TODO: Add layoutoptions
				// TODO: Take titlebar size into consideration
				g.resetCoords = true;
				g.rect = screenRect;
				if (options != null)
					g.ApplyOptions (options);
				g.isWindow = true;
				g.windowID = windowID;
				g.style = style;
				break;
			default:
				g.ResetCursor ();
				break;
			}
			func (windowID);
		}
	END

	// Option passed to a control to give it an absolute width.
	CSRAW static public GUILayoutOption Width (float width)					{ return new GUILayoutOption (GUILayoutOption.Type.fixedWidth, width); }
	// Option passed to a control to specify a minimum width.\\
	CSRAW static public GUILayoutOption MinWidth (float minWidth)				{ return new GUILayoutOption (GUILayoutOption.Type.minWidth, minWidth); }
	// Option passed to a control to specify a maximum width.
	CSRAW static public GUILayoutOption MaxWidth (float maxWidth)				{ return new GUILayoutOption (GUILayoutOption.Type.maxWidth, maxWidth); }
	// Option passed to a control to give it an absolute height.
	CSRAW static public GUILayoutOption Height (float height)					{ return new GUILayoutOption (GUILayoutOption.Type.fixedHeight, height); }

	// Option passed to a control to specify a minimum height.
	CSRAW static public GUILayoutOption MinHeight (float minHeight)				{ return new GUILayoutOption (GUILayoutOption.Type.minHeight, minHeight); }

	// Option passed to a control to specify a maximum height.
	CSRAW static public GUILayoutOption MaxHeight (float maxHeight)			{ return new GUILayoutOption (GUILayoutOption.Type.maxHeight, maxHeight); }

	// Option passed to a control to allow or disallow horizontal expansion.
	CSRAW static public GUILayoutOption ExpandWidth (bool expand)			{ return new GUILayoutOption (GUILayoutOption.Type.stretchWidth, expand ? 1 : 0); }
	// Option passed to a control to allow or disallow vertical expansion.
	CSRAW static public GUILayoutOption ExpandHeight (bool expand)			{ return new GUILayoutOption (GUILayoutOption.Type.stretchHeight, expand ? 1 : 0); }
END
*/
}

}
