namespace Raw_Data_AoB_Extractor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_ByteCodeInput = new System.Windows.Forms.RichTextBox();
            this.MenuStrip_InputPane = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionToWildcardInput_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wildcardALLOperandsInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_ByteCodeEdit = new System.Windows.Forms.RichTextBox();
            this.MenuStrip_EditPane = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nOPSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectionToNOPUnityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionToWildcardEdit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_copyToEditPane = new System.Windows.Forms.Button();
            this.tb_AoBOrig = new System.Windows.Forms.TextBox();
            this.tb_AoBEdited = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForNewVersionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cE4byteCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aoBReverserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rootVarAddressToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iLDASMBytecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konghackcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitHackToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSetupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.syntaxHighlightingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedBytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnemonicConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_AoBTitle = new System.Windows.Forms.TextBox();
            this.tb_AoBFinalOutput = new System.Windows.Forms.TextBox();
            this.groupBox_style = new System.Windows.Forms.GroupBox();
            this.rb_none = new System.Windows.Forms.RadioButton();
            this.rb_BBCODE = new System.Windows.Forms.RadioButton();
            this.rb_html = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip_InputPane.SuspendLayout();
            this.MenuStrip_EditPane.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox_style.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ByteCodeInput
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.tb_ByteCodeInput, 4);
            this.tb_ByteCodeInput.ContextMenuStrip = this.MenuStrip_InputPane;
            this.tb_ByteCodeInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ByteCodeInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ByteCodeInput.Location = new System.Drawing.Point(3, 3);
            this.tb_ByteCodeInput.Name = "tb_ByteCodeInput";
            this.tb_ByteCodeInput.Size = new System.Drawing.Size(296, 206);
            this.tb_ByteCodeInput.TabIndex = 0;
            this.tb_ByteCodeInput.Text = "Original codes go here";
            this.tb_ByteCodeInput.WordWrap = false;
            this.tb_ByteCodeInput.SelectionChanged += new System.EventHandler(this.tb_ByteCode_SelectionChanged);
            this.tb_ByteCodeInput.TextChanged += new System.EventHandler(this.tb_ByteCodeInputBox_TextChanged);
            // 
            // MenuStrip_InputPane
            // 
            this.MenuStrip_InputPane.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.selectionToWildcardInput_ToolStripMenuItem,
            this.wildcardALLOperandsInputToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.MenuStrip_InputPane.Name = "contextMenuStrip1";
            this.MenuStrip_InputPane.ShowImageMargin = false;
            this.MenuStrip_InputPane.Size = new System.Drawing.Size(204, 92);
            this.MenuStrip_InputPane.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_InputPane_Opening);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectionToWildcardInput_ToolStripMenuItem
            // 
            this.selectionToWildcardInput_ToolStripMenuItem.Name = "selectionToWildcardInput_ToolStripMenuItem";
            this.selectionToWildcardInput_ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.selectionToWildcardInput_ToolStripMenuItem.Text = "Selection to wildcard (??)";
            this.selectionToWildcardInput_ToolStripMenuItem.Click += new System.EventHandler(this.selectionToWildcardToolStripMenuItem_Click);
            // 
            // wildcardALLOperandsInputToolStripMenuItem
            // 
            this.wildcardALLOperandsInputToolStripMenuItem.Name = "wildcardALLOperandsInputToolStripMenuItem";
            this.wildcardALLOperandsInputToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.wildcardALLOperandsInputToolStripMenuItem.Text = "Convert ALL Operands to (??)";
            this.wildcardALLOperandsInputToolStripMenuItem.Click += new System.EventHandler(this.wildcardALLOperandsToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(3, 217);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Highlight Hex";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tb_ByteCodeEdit
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tb_ByteCodeEdit, 4);
            this.tb_ByteCodeEdit.ContextMenuStrip = this.MenuStrip_EditPane;
            this.tb_ByteCodeEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ByteCodeEdit.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ByteCodeEdit.Location = new System.Drawing.Point(3, 3);
            this.tb_ByteCodeEdit.Name = "tb_ByteCodeEdit";
            this.tb_ByteCodeEdit.Size = new System.Drawing.Size(281, 206);
            this.tb_ByteCodeEdit.TabIndex = 2;
            this.tb_ByteCodeEdit.Text = "Edit the codes over here";
            this.tb_ByteCodeEdit.WordWrap = false;
            this.tb_ByteCodeEdit.SelectionChanged += new System.EventHandler(this.tb_ByteCode_SelectionChanged);
            this.tb_ByteCodeEdit.Enter += new System.EventHandler(this.tb_ByteCodeEditBoxHighlightListener);
            this.tb_ByteCodeEdit.Leave += new System.EventHandler(this.tb_ByteCodeEditBoxHighlightListener);
            // 
            // MenuStrip_EditPane
            // 
            this.MenuStrip_EditPane.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOPSelectionToolStripMenuItem,
            this.SelectionToNOPUnityToolStripMenuItem,
            this.selectionToWildcardEdit_ToolStripMenuItem,
            this.pasteToolStripMenuItem1});
            this.MenuStrip_EditPane.Name = "contextMenuStrip2";
            this.MenuStrip_EditPane.ShowImageMargin = false;
            this.MenuStrip_EditPane.Size = new System.Drawing.Size(186, 92);
            this.MenuStrip_EditPane.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // nOPSelectionToolStripMenuItem
            // 
            this.nOPSelectionToolStripMenuItem.Name = "nOPSelectionToolStripMenuItem";
            this.nOPSelectionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.nOPSelectionToolStripMenuItem.Text = "NOP Selection (02:Flash)";
            this.nOPSelectionToolStripMenuItem.Click += new System.EventHandler(this.SelectionToNOPFlashToolStripMenuItem_Click);
            // 
            // SelectionToNOPUnityToolStripMenuItem
            // 
            this.SelectionToNOPUnityToolStripMenuItem.Name = "SelectionToNOPUnityToolStripMenuItem";
            this.SelectionToNOPUnityToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.SelectionToNOPUnityToolStripMenuItem.Text = "NOP Selection (00:UNITY)";
            this.SelectionToNOPUnityToolStripMenuItem.Click += new System.EventHandler(this.SelectionToNOPUnityToolStripMenuItem_Click);
            // 
            // selectionToWildcardEdit_ToolStripMenuItem
            // 
            this.selectionToWildcardEdit_ToolStripMenuItem.Name = "selectionToWildcardEdit_ToolStripMenuItem";
            this.selectionToWildcardEdit_ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.selectionToWildcardEdit_ToolStripMenuItem.Text = "Selection to wildcard (??)";
            this.selectionToWildcardEdit_ToolStripMenuItem.Click += new System.EventHandler(this.selectionToWildcardToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // btn_copyToEditPane
            // 
            this.btn_copyToEditPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_copyToEditPane.Location = new System.Drawing.Point(174, 212);
            this.btn_copyToEditPane.Margin = new System.Windows.Forms.Padding(0);
            this.btn_copyToEditPane.Name = "btn_copyToEditPane";
            this.btn_copyToEditPane.Size = new System.Drawing.Size(115, 28);
            this.btn_copyToEditPane.TabIndex = 3;
            this.btn_copyToEditPane.Text = "Copy to Edit Pane";
            this.btn_copyToEditPane.UseVisualStyleBackColor = true;
            this.btn_copyToEditPane.Click += new System.EventHandler(this.btn_CopyToEditPane_Click);
            // 
            // tb_AoBOrig
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.tb_AoBOrig, 4);
            this.tb_AoBOrig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_AoBOrig.Location = new System.Drawing.Point(3, 243);
            this.tb_AoBOrig.Name = "tb_AoBOrig";
            this.tb_AoBOrig.Size = new System.Drawing.Size(296, 20);
            this.tb_AoBOrig.TabIndex = 4;
            this.tb_AoBOrig.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // tb_AoBEdited
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tb_AoBEdited, 4);
            this.tb_AoBEdited.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_AoBEdited.Location = new System.Drawing.Point(3, 243);
            this.tb_AoBEdited.Name = "tb_AoBEdited";
            this.tb_AoBEdited.Size = new System.Drawing.Size(281, 20);
            this.tb_AoBEdited.TabIndex = 5;
            this.tb_AoBEdited.Click += new System.EventHandler(this.textBox2_Click);
            this.tb_AoBEdited.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(95, 212);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Get AoB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(0, 212);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Get AoB";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.xtrasToolStripMenuItem,
            this.unityToolStripMenuItem,
            this.javaToolStripMenuItem,
            this.konghackcomToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.selectedBytesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.checkForNewVersionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkForNewVersionsToolStripMenuItem
            // 
            this.checkForNewVersionsToolStripMenuItem.Name = "checkForNewVersionsToolStripMenuItem";
            this.checkForNewVersionsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.checkForNewVersionsToolStripMenuItem.Text = "Check for new Versions";
            this.checkForNewVersionsToolStripMenuItem.Click += new System.EventHandler(this.checkForNewVersionsToolStripMenuItem_Click);
            // 
            // xtrasToolStripMenuItem
            // 
            this.xtrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cE4byteCalcToolStripMenuItem,
            this.aoBReverserToolStripMenuItem,
            this.cheatTableToolStripMenuItem,
            this.rootVarAddressToolToolStripMenuItem});
            this.xtrasToolStripMenuItem.Name = "xtrasToolStripMenuItem";
            this.xtrasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.xtrasToolStripMenuItem.Text = "Tools";
            // 
            // cE4byteCalcToolStripMenuItem
            // 
            this.cE4byteCalcToolStripMenuItem.Name = "cE4byteCalcToolStripMenuItem";
            this.cE4byteCalcToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cE4byteCalcToolStripMenuItem.Text = "4byte Converter";
            this.cE4byteCalcToolStripMenuItem.Click += new System.EventHandler(this.cE4byteCalcToolStripMenuItem_Click);
            // 
            // aoBReverserToolStripMenuItem
            // 
            this.aoBReverserToolStripMenuItem.Name = "aoBReverserToolStripMenuItem";
            this.aoBReverserToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aoBReverserToolStripMenuItem.Text = "AoB Reverser";
            this.aoBReverserToolStripMenuItem.Click += new System.EventHandler(this.aoBReverserToolStripMenuItem_Click);
            // 
            // cheatTableToolStripMenuItem
            // 
            this.cheatTableToolStripMenuItem.Name = "cheatTableToolStripMenuItem";
            this.cheatTableToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cheatTableToolStripMenuItem.Text = "AoB Cheat Table Maker";
            this.cheatTableToolStripMenuItem.Click += new System.EventHandler(this.cheatTableToolStripMenuItem_Click);
            // 
            // rootVarAddressToolToolStripMenuItem
            // 
            this.rootVarAddressToolToolStripMenuItem.Name = "rootVarAddressToolToolStripMenuItem";
            this.rootVarAddressToolToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.rootVarAddressToolToolStripMenuItem.Text = "root var address tool";
            this.rootVarAddressToolToolStripMenuItem.Click += new System.EventHandler(this.rootVarAddressToolToolStripMenuItem_Click);
            // 
            // unityToolStripMenuItem
            // 
            this.unityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iLDASMBytecodeToolStripMenuItem});
            this.unityToolStripMenuItem.Name = "unityToolStripMenuItem";
            this.unityToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.unityToolStripMenuItem.Text = "Unity";
            // 
            // iLDASMBytecodeToolStripMenuItem
            // 
            this.iLDASMBytecodeToolStripMenuItem.Name = "iLDASMBytecodeToolStripMenuItem";
            this.iLDASMBytecodeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.iLDASMBytecodeToolStripMenuItem.Text = "IL DASM -> bytecode";
            this.iLDASMBytecodeToolStripMenuItem.Click += new System.EventHandler(this.iLDASMBytecodeToolStripMenuItem_Click);
            // 
            // konghackcomToolStripMenuItem
            // 
            this.konghackcomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitHackToDatabaseToolStripMenuItem,
            this.openWebsiteToolStripMenuItem});
            this.konghackcomToolStripMenuItem.Name = "konghackcomToolStripMenuItem";
            this.konghackcomToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.konghackcomToolStripMenuItem.Text = "KongHack.com";
            // 
            // submitHackToDatabaseToolStripMenuItem
            // 
            this.submitHackToDatabaseToolStripMenuItem.Enabled = false;
            this.submitHackToDatabaseToolStripMenuItem.Name = "submitHackToDatabaseToolStripMenuItem";
            this.submitHackToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.submitHackToDatabaseToolStripMenuItem.Text = "SubmitHack to Database";
            this.submitHackToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.submitHackToDatabaseToolStripMenuItem_Click);
            // 
            // openWebsiteToolStripMenuItem
            // 
            this.openWebsiteToolStripMenuItem.Name = "openWebsiteToolStripMenuItem";
            this.openWebsiteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.openWebsiteToolStripMenuItem.Text = "Open Website";
            this.openWebsiteToolStripMenuItem.Click += new System.EventHandler(this.openWebsiteToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSetupToolStripMenuItem1,
            this.syntaxHighlightingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // fontSetupToolStripMenuItem1
            // 
            this.fontSetupToolStripMenuItem1.Name = "fontSetupToolStripMenuItem1";
            this.fontSetupToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.fontSetupToolStripMenuItem1.Text = "Font Setup";
            this.fontSetupToolStripMenuItem1.Click += new System.EventHandler(this.fontSetupToolStripMenuItem_Click);
            // 
            // syntaxHighlightingToolStripMenuItem
            // 
            this.syntaxHighlightingToolStripMenuItem.Enabled = false;
            this.syntaxHighlightingToolStripMenuItem.Name = "syntaxHighlightingToolStripMenuItem";
            this.syntaxHighlightingToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.syntaxHighlightingToolStripMenuItem.Text = "Syntax Highlighting";
            // 
            // selectedBytesToolStripMenuItem
            // 
            this.selectedBytesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.selectedBytesToolStripMenuItem.Enabled = false;
            this.selectedBytesToolStripMenuItem.Name = "selectedBytesToolStripMenuItem";
            this.selectedBytesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.selectedBytesToolStripMenuItem.Text = "Selected Bytes:";
            // 
            // javaToolStripMenuItem
            // 
            this.javaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnemonicConverterToolStripMenuItem});
            this.javaToolStripMenuItem.Name = "javaToolStripMenuItem";
            this.javaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.javaToolStripMenuItem.Text = "Java";
            // 
            // mnemonicConverterToolStripMenuItem
            // 
            this.mnemonicConverterToolStripMenuItem.Name = "mnemonicConverterToolStripMenuItem";
            this.mnemonicConverterToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.mnemonicConverterToolStripMenuItem.Text = "(JBE) Mnemonic Converter";
            this.mnemonicConverterToolStripMenuItem.Click += new System.EventHandler(this.mnemonicConverterToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 3);
            this.label2.Location = new System.Drawing.Point(102, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 361);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 273);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(614, 88);
            this.tableLayoutPanel5.TabIndex = 23;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel4.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(97, 88);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "Get Forum Post";
            this.toolTip1.SetToolTip(this.button4, "Ctrl+Click to generate AutoAssembly Script for CheatEngine\r\n");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(3, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 42);
            this.button5.TabIndex = 15;
            this.button5.Text = "Copy To Clipboard";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_AoBTitle, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_AoBFinalOutput, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox_style, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(100, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(511, 82);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "AoB Title";
            // 
            // tb_AoBTitle
            // 
            this.tb_AoBTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_AoBTitle.Location = new System.Drawing.Point(150, 0);
            this.tb_AoBTitle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tb_AoBTitle.Name = "tb_AoBTitle";
            this.tb_AoBTitle.Size = new System.Drawing.Size(358, 20);
            this.tb_AoBTitle.TabIndex = 8;
            this.tb_AoBTitle.WordWrap = false;
            // 
            // tb_AoBFinalOutput
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.tb_AoBFinalOutput, 2);
            this.tb_AoBFinalOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_AoBFinalOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AoBFinalOutput.Location = new System.Drawing.Point(96, 24);
            this.tb_AoBFinalOutput.Multiline = true;
            this.tb_AoBFinalOutput.Name = "tb_AoBFinalOutput";
            this.tableLayoutPanel3.SetRowSpan(this.tb_AoBFinalOutput, 2);
            this.tb_AoBFinalOutput.Size = new System.Drawing.Size(412, 55);
            this.tb_AoBFinalOutput.TabIndex = 12;
            this.tb_AoBFinalOutput.WordWrap = false;
            // 
            // groupBox_style
            // 
            this.groupBox_style.Controls.Add(this.rb_none);
            this.groupBox_style.Controls.Add(this.rb_BBCODE);
            this.groupBox_style.Controls.Add(this.rb_html);
            this.groupBox_style.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_style.Location = new System.Drawing.Point(0, 0);
            this.groupBox_style.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox_style.Name = "groupBox_style";
            this.tableLayoutPanel3.SetRowSpan(this.groupBox_style, 3);
            this.groupBox_style.Size = new System.Drawing.Size(93, 82);
            this.groupBox_style.TabIndex = 13;
            this.groupBox_style.TabStop = false;
            this.groupBox_style.Text = "Post Style";
            // 
            // rb_none
            // 
            this.rb_none.AutoSize = true;
            this.rb_none.Location = new System.Drawing.Point(2, 58);
            this.rb_none.Name = "rb_none";
            this.rb_none.Size = new System.Drawing.Size(51, 17);
            this.rb_none.TabIndex = 14;
            this.rb_none.Text = "None";
            this.rb_none.UseVisualStyleBackColor = true;
            this.rb_none.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // rb_BBCODE
            // 
            this.rb_BBCODE.AutoSize = true;
            this.rb_BBCODE.Location = new System.Drawing.Point(2, 19);
            this.rb_BBCODE.Name = "rb_BBCODE";
            this.rb_BBCODE.Size = new System.Drawing.Size(64, 17);
            this.rb_BBCODE.TabIndex = 13;
            this.rb_BBCODE.Text = "BBCode";
            this.rb_BBCODE.UseVisualStyleBackColor = true;
            this.rb_BBCODE.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // rb_html
            // 
            this.rb_html.AutoSize = true;
            this.rb_html.Checked = true;
            this.rb_html.Location = new System.Drawing.Point(2, 38);
            this.rb_html.Name = "rb_html";
            this.rb_html.Size = new System.Drawing.Size(55, 17);
            this.rb_html.TabIndex = 12;
            this.rb_html.TabStop = true;
            this.rb_html.Text = "HTML";
            this.rb_html.UseVisualStyleBackColor = true;
            this.rb_html.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.splitContainer1, 2);
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(608, 267);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.SplitterWidth = 15;
            this.splitContainer1.TabIndex = 24;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tb_AoBOrig, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.btn_copyToEditPane, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tb_ByteCodeInput, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(302, 265);
            this.tableLayoutPanel6.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tb_ByteCodeEdit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_AoBEdited, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(287, 265);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 385);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Raw Data AoB Extractor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip_InputPane.ResumeLayout(false);
            this.MenuStrip_EditPane.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox_style.ResumeLayout(false);
            this.groupBox_style.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox tb_ByteCodeEdit;
        private System.Windows.Forms.Button btn_copyToEditPane;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MenuStrip_InputPane;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MenuStrip_EditPane;
        private System.Windows.Forms.ToolStripMenuItem nOPSelectionToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem xtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rootVarAddressToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cE4byteCalcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aoBReverserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionToWildcardInput_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionToWildcardEdit_ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ToolStripMenuItem unityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iLDASMBytecodeToolStripMenuItem;
        internal System.Windows.Forms.RichTextBox tb_ByteCodeInput;
        private System.Windows.Forms.ToolStripMenuItem konghackcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitHackToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWebsiteToolStripMenuItem;
        internal System.Windows.Forms.TextBox tb_AoBOrig;
        internal System.Windows.Forms.TextBox tb_AoBEdited;
        private System.Windows.Forms.ToolStripMenuItem checkForNewVersionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectionToNOPUnityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSetupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem syntaxHighlightingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedBytesToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem wildcardALLOperandsInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnemonicConverterToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox tb_AoBTitle;
        private System.Windows.Forms.TextBox tb_AoBFinalOutput;
        private System.Windows.Forms.GroupBox groupBox_style;
        private System.Windows.Forms.RadioButton rb_none;
        private System.Windows.Forms.RadioButton rb_BBCODE;
        private System.Windows.Forms.RadioButton rb_html;
    }
}

