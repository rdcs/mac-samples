// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace SamplesButtonMadness {
	
	
	// Should subclass AppKit.NSButton
	[Foundation.Register("DropDownButton")]
	public partial class DropDownButton {
	}
	
	// Should subclass AppKit.NSWindow
	[Foundation.Register("TestWindow")]
	public partial class TestWindow {
	}
	
	// Should subclass AppKit.NSWindowController
	[Foundation.Register("TestWindowController")]
	public partial class TestWindowController {
		
		private global::AppKit.NSBox __mt_buttonBox;
		
		private global::AppKit.NSMenu __mt_buttonMenu;
		
		private global::AppKit.NSBox __mt_colorBox;
		
		private DropDownButton __mt_dropDownButton;
		
		private global::AppKit.NSBox __mt_indicatorBox;
		
		private global::AppKit.NSStepper __mt_levelAdjuster;
		
		private global::AppKit.NSBox __mt_matrixBox;
		
		private global::AppKit.NSButton __mt_nibBasedButtonRound;
		
		private global::AppKit.NSButton __mt_nibBasedButtonSquare;
		
		private global::AppKit.NSColorWell __mt_nibBasedColorWell;
		
		private global::AppKit.NSLevelIndicator __mt_nibBasedIndicator;
		
		private global::AppKit.NSMatrix __mt_nibBasedMatrix;
		
		private global::AppKit.NSPopUpButton __mt_nibBasedPopUpDown;
		
		private global::AppKit.NSPopUpButton __mt_nibBasedPopUpRight;
		
		private global::AppKit.NSSegmentedControl __mt_nibBasedSegControl;
		
		private global::AppKit.NSView __mt_placeHolder1;
		
		private global::AppKit.NSView __mt_placeHolder2;
		
		private global::AppKit.NSView __mt_placeHolder3;
		
		private global::AppKit.NSView __mt_placeHolder4;
		
		private global::AppKit.NSView __mt_placeHolder5;
		
		private global::AppKit.NSView __mt_placeHolder6;
		
		private global::AppKit.NSView __mt_placeHolder7;
		
		private global::AppKit.NSView __mt_placeHolder8;
		
		private global::AppKit.NSBox __mt_popupBox;
		
		private global::AppKit.NSBox __mt_segmentBox;
		
		#pragma warning disable 0169
		[Foundation.Export("buttonAction:")]
		partial void buttonAction (Foundation.NSObject sender);

		[Foundation.Export("colorAction:")]
		partial void colorAction (Foundation.NSObject sender);

		[Foundation.Export("dropDownAction:")]
		partial void dropDownAction (Foundation.NSObject sender);

		[Foundation.Export("levelAction:")]
		partial void levelAction (Foundation.NSObject sender);

		[Foundation.Export("levelAdjustAction:")]
		partial void levelAdjustAction (Foundation.NSObject sender);

		[Foundation.Export("matrixAction:")]
		partial void matrixAction (Foundation.NSObject sender);

		[Foundation.Export("popupAction:")]
		partial void popupAction (Foundation.NSObject sender);

		[Foundation.Export("pullsDownAction:")]
		partial void pullsDownAction (Foundation.NSObject sender);

		[Foundation.Export("segmentAction:")]
		partial void segmentAction (Foundation.NSObject sender);

		[Foundation.Export("setStyleAction:")]
		partial void setStyleAction (Foundation.NSObject sender);

		[Foundation.Export("unselectAction:")]
		partial void unselectAction (Foundation.NSObject sender);

		[Foundation.Export("useIconAction:")]
		partial void useIconAction (Foundation.NSObject sender);

		[Foundation.Connect("buttonBox")]
		private global::AppKit.NSBox buttonBox {
			get {
				this.__mt_buttonBox = ((global::AppKit.NSBox)(this.GetNativeField("buttonBox")));
				return this.__mt_buttonBox;
			}
			set {
				this.__mt_buttonBox = value;
				this.SetNativeField("buttonBox", value);
			}
		}
		
		[Foundation.Connect("buttonMenu")]
		private global::AppKit.NSMenu buttonMenu {
			get {
				this.__mt_buttonMenu = ((global::AppKit.NSMenu)(this.GetNativeField("buttonMenu")));
				return this.__mt_buttonMenu;
			}
			set {
				this.__mt_buttonMenu = value;
				this.SetNativeField("buttonMenu", value);
			}
		}
		
		[Foundation.Connect("colorBox")]
		private global::AppKit.NSBox colorBox {
			get {
				this.__mt_colorBox = ((global::AppKit.NSBox)(this.GetNativeField("colorBox")));
				return this.__mt_colorBox;
			}
			set {
				this.__mt_colorBox = value;
				this.SetNativeField("colorBox", value);
			}
		}
		
		[Foundation.Connect("dropDownButton")]
		private DropDownButton dropDownButton {
			get {
				this.__mt_dropDownButton = ((DropDownButton)(this.GetNativeField("dropDownButton")));
				return this.__mt_dropDownButton;
			}
			set {
				this.__mt_dropDownButton = value;
				this.SetNativeField("dropDownButton", value);
			}
		}
		
		[Foundation.Connect("indicatorBox")]
		private global::AppKit.NSBox indicatorBox {
			get {
				this.__mt_indicatorBox = ((global::AppKit.NSBox)(this.GetNativeField("indicatorBox")));
				return this.__mt_indicatorBox;
			}
			set {
				this.__mt_indicatorBox = value;
				this.SetNativeField("indicatorBox", value);
			}
		}
		
		[Foundation.Connect("levelAdjuster")]
		private global::AppKit.NSStepper levelAdjuster {
			get {
				this.__mt_levelAdjuster = ((global::AppKit.NSStepper)(this.GetNativeField("levelAdjuster")));
				return this.__mt_levelAdjuster;
			}
			set {
				this.__mt_levelAdjuster = value;
				this.SetNativeField("levelAdjuster", value);
			}
		}
		
		[Foundation.Connect("matrixBox")]
		private global::AppKit.NSBox matrixBox {
			get {
				this.__mt_matrixBox = ((global::AppKit.NSBox)(this.GetNativeField("matrixBox")));
				return this.__mt_matrixBox;
			}
			set {
				this.__mt_matrixBox = value;
				this.SetNativeField("matrixBox", value);
			}
		}
		
		[Foundation.Connect("nibBasedButtonRound")]
		private global::AppKit.NSButton nibBasedButtonRound {
			get {
				this.__mt_nibBasedButtonRound = ((global::AppKit.NSButton)(this.GetNativeField("nibBasedButtonRound")));
				return this.__mt_nibBasedButtonRound;
			}
			set {
				this.__mt_nibBasedButtonRound = value;
				this.SetNativeField("nibBasedButtonRound", value);
			}
		}
		
		[Foundation.Connect("nibBasedButtonSquare")]
		private global::AppKit.NSButton nibBasedButtonSquare {
			get {
				this.__mt_nibBasedButtonSquare = ((global::AppKit.NSButton)(this.GetNativeField("nibBasedButtonSquare")));
				return this.__mt_nibBasedButtonSquare;
			}
			set {
				this.__mt_nibBasedButtonSquare = value;
				this.SetNativeField("nibBasedButtonSquare", value);
			}
		}
		
		[Foundation.Connect("nibBasedColorWell")]
		private global::AppKit.NSColorWell nibBasedColorWell {
			get {
				this.__mt_nibBasedColorWell = ((global::AppKit.NSColorWell)(this.GetNativeField("nibBasedColorWell")));
				return this.__mt_nibBasedColorWell;
			}
			set {
				this.__mt_nibBasedColorWell = value;
				this.SetNativeField("nibBasedColorWell", value);
			}
		}
		
		[Foundation.Connect("nibBasedIndicator")]
		private global::AppKit.NSLevelIndicator nibBasedIndicator {
			get {
				this.__mt_nibBasedIndicator = ((global::AppKit.NSLevelIndicator)(this.GetNativeField("nibBasedIndicator")));
				return this.__mt_nibBasedIndicator;
			}
			set {
				this.__mt_nibBasedIndicator = value;
				this.SetNativeField("nibBasedIndicator", value);
			}
		}
		
		[Foundation.Connect("nibBasedMatrix")]
		private global::AppKit.NSMatrix nibBasedMatrix {
			get {
				this.__mt_nibBasedMatrix = ((global::AppKit.NSMatrix)(this.GetNativeField("nibBasedMatrix")));
				return this.__mt_nibBasedMatrix;
			}
			set {
				this.__mt_nibBasedMatrix = value;
				this.SetNativeField("nibBasedMatrix", value);
			}
		}
		
		[Foundation.Connect("nibBasedPopUpDown")]
		private global::AppKit.NSPopUpButton nibBasedPopUpDown {
			get {
				this.__mt_nibBasedPopUpDown = ((global::AppKit.NSPopUpButton)(this.GetNativeField("nibBasedPopUpDown")));
				return this.__mt_nibBasedPopUpDown;
			}
			set {
				this.__mt_nibBasedPopUpDown = value;
				this.SetNativeField("nibBasedPopUpDown", value);
			}
		}
		
		[Foundation.Connect("nibBasedPopUpRight")]
		private global::AppKit.NSPopUpButton nibBasedPopUpRight {
			get {
				this.__mt_nibBasedPopUpRight = ((global::AppKit.NSPopUpButton)(this.GetNativeField("nibBasedPopUpRight")));
				return this.__mt_nibBasedPopUpRight;
			}
			set {
				this.__mt_nibBasedPopUpRight = value;
				this.SetNativeField("nibBasedPopUpRight", value);
			}
		}
		
		[Foundation.Connect("nibBasedSegControl")]
		private global::AppKit.NSSegmentedControl nibBasedSegControl {
			get {
				this.__mt_nibBasedSegControl = ((global::AppKit.NSSegmentedControl)(this.GetNativeField("nibBasedSegControl")));
				return this.__mt_nibBasedSegControl;
			}
			set {
				this.__mt_nibBasedSegControl = value;
				this.SetNativeField("nibBasedSegControl", value);
			}
		}
		
		[Foundation.Connect("placeHolder1")]
		private global::AppKit.NSView placeHolder1 {
			get {
				this.__mt_placeHolder1 = ((global::AppKit.NSView)(this.GetNativeField("placeHolder1")));
				return this.__mt_placeHolder1;
			}
			set {
				this.__mt_placeHolder1 = value;
				this.SetNativeField("placeHolder1", value);
			}
		}
		
		[Foundation.Connect("placeHolder2")]
		private global::AppKit.NSView placeHolder2 {
			get {
				this.__mt_placeHolder2 = ((global::AppKit.NSView)(this.GetNativeField("placeHolder2")));
				return this.__mt_placeHolder2;
			}
			set {
				this.__mt_placeHolder2 = value;
				this.SetNativeField("placeHolder2", value);
			}
		}
		
		[Foundation.Connect("placeHolder3")]
		private global::AppKit.NSView placeHolder3 {
			get {
				this.__mt_placeHolder3 = ((global::AppKit.NSView)(this.GetNativeField("placeHolder3")));
				return this.__mt_placeHolder3;
			}
			set {
				this.__mt_placeHolder3 = value;
				this.SetNativeField("placeHolder3", value);
			}
		}
		
		[Foundation.Connect("placeHolder4")]
		private global::AppKit.NSView placeHolder4 {
			get {
				this.__mt_placeHolder4 = ((global::AppKit.NSView)(this.GetNativeField("placeHolder4")));
				return this.__mt_placeHolder4;
			}
			set {
				this.__mt_placeHolder4 = value;
				this.SetNativeField("placeHolder4", value);
			}
		}
		
		[Foundation.Connect("placeHolder5")]
		private global::AppKit.NSView placeHolder5 {
			get {
				this.__mt_placeHolder5 = ((global::AppKit.NSView)(this.GetNativeField("placeHolder5")));
				return this.__mt_placeHolder5;
			}
			set {
				this.__mt_placeHolder5 = value;
				this.SetNativeField("placeHolder5", value);
			}
		}
		
		[Foundation.Connect("placeHolder6")]
		private global::AppKit.NSView placeHolder6 {
			get {
				this.__mt_placeHolder6 = ((global::AppKit.NSView)(this.GetNativeField("placeHolder6")));
				return this.__mt_placeHolder6;
			}
			set {
				this.__mt_placeHolder6 = value;
				this.SetNativeField("placeHolder6", value);
			}
		}
		
		[Foundation.Connect("placeHolder7")]
		private global::AppKit.NSView placeHolder7 {
			get {
				this.__mt_placeHolder7 = ((global::AppKit.NSView)(this.GetNativeField("placeHolder7")));
				return this.__mt_placeHolder7;
			}
			set {
				this.__mt_placeHolder7 = value;
				this.SetNativeField("placeHolder7", value);
			}
		}
		
		[Foundation.Connect("placeHolder8")]
		private global::AppKit.NSView placeHolder8 {
			get {
				this.__mt_placeHolder8 = ((global::AppKit.NSView)(this.GetNativeField("placeHolder8")));
				return this.__mt_placeHolder8;
			}
			set {
				this.__mt_placeHolder8 = value;
				this.SetNativeField("placeHolder8", value);
			}
		}
		
		[Foundation.Connect("popupBox")]
		private global::AppKit.NSBox popupBox {
			get {
				this.__mt_popupBox = ((global::AppKit.NSBox)(this.GetNativeField("popupBox")));
				return this.__mt_popupBox;
			}
			set {
				this.__mt_popupBox = value;
				this.SetNativeField("popupBox", value);
			}
		}
		
		[Foundation.Connect("segmentBox")]
		private global::AppKit.NSBox segmentBox {
			get {
				this.__mt_segmentBox = ((global::AppKit.NSBox)(this.GetNativeField("segmentBox")));
				return this.__mt_segmentBox;
			}
			set {
				this.__mt_segmentBox = value;
				this.SetNativeField("segmentBox", value);
			}
		}
	}
}
