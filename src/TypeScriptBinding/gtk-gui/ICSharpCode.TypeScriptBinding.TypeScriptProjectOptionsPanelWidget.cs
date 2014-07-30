
// This file has been generated by the GUI designer. Do not modify.
namespace ICSharpCode.TypeScriptBinding
{
	public partial class TypeScriptProjectOptionsPanelWidget
	{
		private global::Gtk.VBox mainVBox;
		
		private global::Gtk.Frame generalOptionsFrame;
		
		private global::Gtk.Alignment generalOptionsAlignment;
		
		private global::Gtk.VBox generalOptionsVBox;
		
		private global::Gtk.CheckButton compileOnSaveCheckButton;
		
		private global::Gtk.CheckButton compileOnBuildCheckButton;
		
		private global::Gtk.Label generalFrameLabel;
		
		private global::Gtk.Frame compilerOptionsFrame;
		
		private global::Gtk.Alignment compilerOptionsAlignment;
		
		private global::Gtk.VBox compilerOptionsVBox;
		
		private global::Gtk.Table ecmaVersionAndModuleTable;
		
		private global::Gtk.HBox ecmaScriptVersionLabelHBox;
		
		private global::Gtk.Label ecmaVersionLabel;
		
		private global::Gtk.Label ecmaScriptVersionPaddingLabel;
		
		private global::Gtk.ComboBox ecmaVersionComboBox;
		
		private global::Gtk.ComboBox moduleComboBox;
		
		private global::Gtk.HBox moduleLabelHBox;
		
		private global::Gtk.Label moduleLabel;
		
		private global::Gtk.Label modulePaddingLabel;
		
		private global::Gtk.CheckButton allowImplicitAnyCheckButton;
		
		private global::Gtk.CheckButton includeCommentsCheckButton;
		
		private global::Gtk.CheckButton generateSourceMapCheckButton;
		
		private global::Gtk.Label compilerFrameLabel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ICSharpCode.TypeScriptBinding.TypeScriptProjectOptionsPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "ICSharpCode.TypeScriptBinding.TypeScriptProjectOptionsPanelWidget";
			// Container child ICSharpCode.TypeScriptBinding.TypeScriptProjectOptionsPanelWidget.Gtk.Container+ContainerChild
			this.mainVBox = new global::Gtk.VBox ();
			this.mainVBox.Name = "mainVBox";
			this.mainVBox.Spacing = 6;
			// Container child mainVBox.Gtk.Box+BoxChild
			this.generalOptionsFrame = new global::Gtk.Frame ();
			this.generalOptionsFrame.Name = "generalOptionsFrame";
			this.generalOptionsFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child generalOptionsFrame.Gtk.Container+ContainerChild
			this.generalOptionsAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.generalOptionsAlignment.Name = "generalOptionsAlignment";
			this.generalOptionsAlignment.LeftPadding = ((uint)(12));
			// Container child generalOptionsAlignment.Gtk.Container+ContainerChild
			this.generalOptionsVBox = new global::Gtk.VBox ();
			this.generalOptionsVBox.Name = "generalOptionsVBox";
			this.generalOptionsVBox.Spacing = 6;
			this.generalOptionsVBox.BorderWidth = ((uint)(6));
			// Container child generalOptionsVBox.Gtk.Box+BoxChild
			this.compileOnSaveCheckButton = new global::Gtk.CheckButton ();
			this.compileOnSaveCheckButton.CanFocus = true;
			this.compileOnSaveCheckButton.Name = "compileOnSaveCheckButton";
			this.compileOnSaveCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Compile on save");
			this.compileOnSaveCheckButton.DrawIndicator = true;
			this.compileOnSaveCheckButton.UseUnderline = true;
			this.generalOptionsVBox.Add (this.compileOnSaveCheckButton);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.generalOptionsVBox [this.compileOnSaveCheckButton]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child generalOptionsVBox.Gtk.Box+BoxChild
			this.compileOnBuildCheckButton = new global::Gtk.CheckButton ();
			this.compileOnBuildCheckButton.CanFocus = true;
			this.compileOnBuildCheckButton.Name = "compileOnBuildCheckButton";
			this.compileOnBuildCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Compile on build");
			this.compileOnBuildCheckButton.DrawIndicator = true;
			this.compileOnBuildCheckButton.UseUnderline = true;
			this.generalOptionsVBox.Add (this.compileOnBuildCheckButton);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.generalOptionsVBox [this.compileOnBuildCheckButton]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.generalOptionsAlignment.Add (this.generalOptionsVBox);
			this.generalOptionsFrame.Add (this.generalOptionsAlignment);
			this.generalFrameLabel = new global::Gtk.Label ();
			this.generalFrameLabel.Name = "generalFrameLabel";
			this.generalFrameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>General</b>");
			this.generalFrameLabel.UseMarkup = true;
			this.generalOptionsFrame.LabelWidget = this.generalFrameLabel;
			this.mainVBox.Add (this.generalOptionsFrame);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.generalOptionsFrame]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child mainVBox.Gtk.Box+BoxChild
			this.compilerOptionsFrame = new global::Gtk.Frame ();
			this.compilerOptionsFrame.Name = "compilerOptionsFrame";
			this.compilerOptionsFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child compilerOptionsFrame.Gtk.Container+ContainerChild
			this.compilerOptionsAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.compilerOptionsAlignment.Name = "compilerOptionsAlignment";
			this.compilerOptionsAlignment.LeftPadding = ((uint)(12));
			// Container child compilerOptionsAlignment.Gtk.Container+ContainerChild
			this.compilerOptionsVBox = new global::Gtk.VBox ();
			this.compilerOptionsVBox.Name = "compilerOptionsVBox";
			this.compilerOptionsVBox.Spacing = 6;
			this.compilerOptionsVBox.BorderWidth = ((uint)(6));
			// Container child compilerOptionsVBox.Gtk.Box+BoxChild
			this.ecmaVersionAndModuleTable = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.ecmaVersionAndModuleTable.Name = "ecmaVersionAndModuleTable";
			this.ecmaVersionAndModuleTable.RowSpacing = ((uint)(6));
			this.ecmaVersionAndModuleTable.ColumnSpacing = ((uint)(6));
			// Container child ecmaVersionAndModuleTable.Gtk.Table+TableChild
			this.ecmaScriptVersionLabelHBox = new global::Gtk.HBox ();
			this.ecmaScriptVersionLabelHBox.Name = "ecmaScriptVersionLabelHBox";
			this.ecmaScriptVersionLabelHBox.Spacing = 6;
			// Container child ecmaScriptVersionLabelHBox.Gtk.Box+BoxChild
			this.ecmaVersionLabel = new global::Gtk.Label ();
			this.ecmaVersionLabel.Name = "ecmaVersionLabel";
			this.ecmaVersionLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("ECMAScript version:");
			this.ecmaScriptVersionLabelHBox.Add (this.ecmaVersionLabel);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.ecmaScriptVersionLabelHBox [this.ecmaVersionLabel]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child ecmaScriptVersionLabelHBox.Gtk.Box+BoxChild
			this.ecmaScriptVersionPaddingLabel = new global::Gtk.Label ();
			this.ecmaScriptVersionPaddingLabel.Name = "ecmaScriptVersionPaddingLabel";
			this.ecmaScriptVersionLabelHBox.Add (this.ecmaScriptVersionPaddingLabel);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.ecmaScriptVersionLabelHBox [this.ecmaScriptVersionPaddingLabel]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.ecmaVersionAndModuleTable.Add (this.ecmaScriptVersionLabelHBox);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.ecmaVersionAndModuleTable [this.ecmaScriptVersionLabelHBox]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child ecmaVersionAndModuleTable.Gtk.Table+TableChild
			this.ecmaVersionComboBox = global::Gtk.ComboBox.NewText ();
			this.ecmaVersionComboBox.Name = "ecmaVersionComboBox";
			this.ecmaVersionAndModuleTable.Add (this.ecmaVersionComboBox);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.ecmaVersionAndModuleTable [this.ecmaVersionComboBox]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child ecmaVersionAndModuleTable.Gtk.Table+TableChild
			this.moduleComboBox = global::Gtk.ComboBox.NewText ();
			this.moduleComboBox.Name = "moduleComboBox";
			this.ecmaVersionAndModuleTable.Add (this.moduleComboBox);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.ecmaVersionAndModuleTable [this.moduleComboBox]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child ecmaVersionAndModuleTable.Gtk.Table+TableChild
			this.moduleLabelHBox = new global::Gtk.HBox ();
			this.moduleLabelHBox.Name = "moduleLabelHBox";
			this.moduleLabelHBox.Spacing = 6;
			// Container child moduleLabelHBox.Gtk.Box+BoxChild
			this.moduleLabel = new global::Gtk.Label ();
			this.moduleLabel.Name = "moduleLabel";
			this.moduleLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Module system:");
			this.moduleLabelHBox.Add (this.moduleLabel);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.moduleLabelHBox [this.moduleLabel]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child moduleLabelHBox.Gtk.Box+BoxChild
			this.modulePaddingLabel = new global::Gtk.Label ();
			this.modulePaddingLabel.Name = "modulePaddingLabel";
			this.moduleLabelHBox.Add (this.modulePaddingLabel);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.moduleLabelHBox [this.modulePaddingLabel]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.ecmaVersionAndModuleTable.Add (this.moduleLabelHBox);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.ecmaVersionAndModuleTable [this.moduleLabelHBox]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.compilerOptionsVBox.Add (this.ecmaVersionAndModuleTable);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.compilerOptionsVBox [this.ecmaVersionAndModuleTable]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child compilerOptionsVBox.Gtk.Box+BoxChild
			this.allowImplicitAnyCheckButton = new global::Gtk.CheckButton ();
			this.allowImplicitAnyCheckButton.CanFocus = true;
			this.allowImplicitAnyCheckButton.Name = "allowImplicitAnyCheckButton";
			this.allowImplicitAnyCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Allow implicit \'any\' types");
			this.allowImplicitAnyCheckButton.DrawIndicator = true;
			this.allowImplicitAnyCheckButton.UseUnderline = true;
			this.compilerOptionsVBox.Add (this.allowImplicitAnyCheckButton);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.compilerOptionsVBox [this.allowImplicitAnyCheckButton]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child compilerOptionsVBox.Gtk.Box+BoxChild
			this.includeCommentsCheckButton = new global::Gtk.CheckButton ();
			this.includeCommentsCheckButton.CanFocus = true;
			this.includeCommentsCheckButton.Name = "includeCommentsCheckButton";
			this.includeCommentsCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Include comments");
			this.includeCommentsCheckButton.DrawIndicator = true;
			this.includeCommentsCheckButton.UseUnderline = true;
			this.compilerOptionsVBox.Add (this.includeCommentsCheckButton);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.compilerOptionsVBox [this.includeCommentsCheckButton]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			// Container child compilerOptionsVBox.Gtk.Box+BoxChild
			this.generateSourceMapCheckButton = new global::Gtk.CheckButton ();
			this.generateSourceMapCheckButton.CanFocus = true;
			this.generateSourceMapCheckButton.Name = "generateSourceMapCheckButton";
			this.generateSourceMapCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Generate source map");
			this.generateSourceMapCheckButton.DrawIndicator = true;
			this.generateSourceMapCheckButton.UseUnderline = true;
			this.compilerOptionsVBox.Add (this.generateSourceMapCheckButton);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.compilerOptionsVBox [this.generateSourceMapCheckButton]));
			w17.Position = 3;
			w17.Expand = false;
			w17.Fill = false;
			this.compilerOptionsAlignment.Add (this.compilerOptionsVBox);
			this.compilerOptionsFrame.Add (this.compilerOptionsAlignment);
			this.compilerFrameLabel = new global::Gtk.Label ();
			this.compilerFrameLabel.Name = "compilerFrameLabel";
			this.compilerFrameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Compiler</b>");
			this.compilerFrameLabel.UseMarkup = true;
			this.compilerOptionsFrame.LabelWidget = this.compilerFrameLabel;
			this.mainVBox.Add (this.compilerOptionsFrame);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.compilerOptionsFrame]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			this.Add (this.mainVBox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
