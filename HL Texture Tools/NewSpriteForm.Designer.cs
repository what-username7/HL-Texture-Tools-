﻿namespace HLTextureTools
{
    partial class NewSpriteForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listPictures = new HLTextureTools.ListViewEx();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnMoveImageDown = new System.Windows.Forms.Button();
            this.btnMoveImageUp = new System.Windows.Forms.Button();
            this.btnRemoveImages = new System.Windows.Forms.Button();
            this.btnAddImages = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inputPaletteIndex = new System.Windows.Forms.NumericUpDown();
            this.panelPickTransparentColor = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioAlphaTestTexture = new System.Windows.Forms.RadioButton();
            this.radioIndexAlphaTexture = new System.Windows.Forms.RadioButton();
            this.radioAdditiveTexture = new System.Windows.Forms.RadioButton();
            this.radioNormalTexture = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioParallelOriented = new System.Windows.Forms.RadioButton();
            this.radioOriented = new System.Windows.Forms.RadioButton();
            this.radioParallel = new System.Windows.Forms.RadioButton();
            this.radioFacingUpright = new System.Windows.Forms.RadioButton();
            this.radioParallelUpright = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.helpBrowser = new System.Windows.Forms.WebBrowser();
            this.progLbl = new System.Windows.Forms.Label();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.buttonSaveSprite = new System.Windows.Forms.Button();
            this.addImagesFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveSpriteFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPaletteIndex)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 551);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listPictures);
            this.tabPage1.Controls.Add(this.btnMoveImageDown);
            this.tabPage1.Controls.Add(this.btnMoveImageUp);
            this.tabPage1.Controls.Add(this.btnRemoveImages);
            this.tabPage1.Controls.Add(this.btnAddImages);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1. Images";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listPictures
            // 
            this.listPictures.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listPictures.AllowRowReorder = true;
            this.listPictures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPictures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPictures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listPictures.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listPictures.HideSelection = false;
            this.listPictures.LargeImageList = this.imageList1;
            this.listPictures.Location = new System.Drawing.Point(8, 37);
            this.listPictures.Name = "listPictures";
            this.listPictures.ShowGroups = false;
            this.listPictures.Size = new System.Drawing.Size(702, 477);
            this.listPictures.TabIndex = 5;
            this.listPictures.TileSize = new System.Drawing.Size(230, 75);
            this.listPictures.UseCompatibleStateImageBehavior = false;
            this.listPictures.View = System.Windows.Forms.View.Tile;
            this.listPictures.SelectedIndexChanged += new System.EventHandler(this.listPictures_SelectedIndexChanged);
            this.listPictures.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listPictures_KeyDown);
            this.listPictures.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPictures_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(72, 72);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnMoveImageDown
            // 
            this.btnMoveImageDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveImageDown.Enabled = false;
            this.btnMoveImageDown.Image = global::HLTextureTools.Properties.Resources.arrow_down;
            this.btnMoveImageDown.Location = new System.Drawing.Point(672, 8);
            this.btnMoveImageDown.Name = "btnMoveImageDown";
            this.btnMoveImageDown.Size = new System.Drawing.Size(30, 23);
            this.btnMoveImageDown.TabIndex = 4;
            this.btnMoveImageDown.UseVisualStyleBackColor = true;
            this.btnMoveImageDown.Click += new System.EventHandler(this.btnMoveImageDown_Click);
            // 
            // btnMoveImageUp
            // 
            this.btnMoveImageUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveImageUp.Enabled = false;
            this.btnMoveImageUp.Image = global::HLTextureTools.Properties.Resources.arrow_up;
            this.btnMoveImageUp.Location = new System.Drawing.Point(642, 8);
            this.btnMoveImageUp.Name = "btnMoveImageUp";
            this.btnMoveImageUp.Size = new System.Drawing.Size(30, 23);
            this.btnMoveImageUp.TabIndex = 3;
            this.btnMoveImageUp.UseVisualStyleBackColor = true;
            this.btnMoveImageUp.Click += new System.EventHandler(this.btnMoveImageUp_Click);
            // 
            // btnRemoveImages
            // 
            this.btnRemoveImages.Enabled = false;
            this.btnRemoveImages.Image = global::HLTextureTools.Properties.Resources.delete;
            this.btnRemoveImages.Location = new System.Drawing.Point(140, 6);
            this.btnRemoveImages.Name = "btnRemoveImages";
            this.btnRemoveImages.Size = new System.Drawing.Size(128, 25);
            this.btnRemoveImages.TabIndex = 2;
            this.btnRemoveImages.Text = "Remove";
            this.btnRemoveImages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveImages.UseVisualStyleBackColor = true;
            this.btnRemoveImages.Click += new System.EventHandler(this.btnRemoveImages_Click);
            // 
            // btnAddImages
            // 
            this.btnAddImages.Image = global::HLTextureTools.Properties.Resources.add;
            this.btnAddImages.Location = new System.Drawing.Point(6, 6);
            this.btnAddImages.Name = "btnAddImages";
            this.btnAddImages.Size = new System.Drawing.Size(128, 25);
            this.btnAddImages.TabIndex = 1;
            this.btnAddImages.Text = "Add images";
            this.btnAddImages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddImages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddImages.UseVisualStyleBackColor = true;
            this.btnAddImages.Click += new System.EventHandler(this.btnAddImages_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2. Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.inputPaletteIndex);
            this.groupBox2.Controls.Add(this.panelPickTransparentColor);
            this.groupBox2.Location = new System.Drawing.Point(8, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 123);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image color palette";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Use palette from image index:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Transparent color replacement:";
            // 
            // inputPaletteIndex
            // 
            this.inputPaletteIndex.Location = new System.Drawing.Point(217, 34);
            this.inputPaletteIndex.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.inputPaletteIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputPaletteIndex.Name = "inputPaletteIndex";
            this.inputPaletteIndex.Size = new System.Drawing.Size(90, 22);
            this.inputPaletteIndex.TabIndex = 2;
            this.inputPaletteIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelPickTransparentColor
            // 
            this.panelPickTransparentColor.BackColor = System.Drawing.Color.Blue;
            this.panelPickTransparentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPickTransparentColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPickTransparentColor.ForeColor = System.Drawing.Color.White;
            this.panelPickTransparentColor.Location = new System.Drawing.Point(230, 70);
            this.panelPickTransparentColor.Name = "panelPickTransparentColor";
            this.panelPickTransparentColor.Size = new System.Drawing.Size(33, 34);
            this.panelPickTransparentColor.TabIndex = 9;
            this.panelPickTransparentColor.Click += new System.EventHandler(this.panelPickTransparentColor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.radioAlphaTestTexture);
            this.groupBox3.Controls.Add(this.radioIndexAlphaTexture);
            this.groupBox3.Controls.Add(this.radioAdditiveTexture);
            this.groupBox3.Controls.Add(this.radioNormalTexture);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 245);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Texture format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(45, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Greyscale, last color in palette is the sprite color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(45, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Additive transparency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(45, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No transparency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(45, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last color in palette is the transparent color";
            // 
            // radioAlphaTestTexture
            // 
            this.radioAlphaTestTexture.AutoSize = true;
            this.radioAlphaTestTexture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioAlphaTestTexture.Location = new System.Drawing.Point(29, 175);
            this.radioAlphaTestTexture.Name = "radioAlphaTestTexture";
            this.radioAlphaTestTexture.Size = new System.Drawing.Size(82, 20);
            this.radioAlphaTestTexture.TabIndex = 0;
            this.radioAlphaTestTexture.Text = "Alphatest";
            this.radioAlphaTestTexture.UseVisualStyleBackColor = true;
            // 
            // radioIndexAlphaTexture
            // 
            this.radioIndexAlphaTexture.AutoSize = true;
            this.radioIndexAlphaTexture.Location = new System.Drawing.Point(28, 128);
            this.radioIndexAlphaTexture.Name = "radioIndexAlphaTexture";
            this.radioIndexAlphaTexture.Size = new System.Drawing.Size(92, 20);
            this.radioIndexAlphaTexture.TabIndex = 0;
            this.radioIndexAlphaTexture.Text = "Indexalpha";
            this.radioIndexAlphaTexture.UseVisualStyleBackColor = true;
            // 
            // radioAdditiveTexture
            // 
            this.radioAdditiveTexture.AutoSize = true;
            this.radioAdditiveTexture.Location = new System.Drawing.Point(29, 79);
            this.radioAdditiveTexture.Name = "radioAdditiveTexture";
            this.radioAdditiveTexture.Size = new System.Drawing.Size(75, 20);
            this.radioAdditiveTexture.TabIndex = 0;
            this.radioAdditiveTexture.Text = "Additive";
            this.radioAdditiveTexture.UseVisualStyleBackColor = true;
            // 
            // radioNormalTexture
            // 
            this.radioNormalTexture.AutoSize = true;
            this.radioNormalTexture.Checked = true;
            this.radioNormalTexture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioNormalTexture.Location = new System.Drawing.Point(28, 32);
            this.radioNormalTexture.Name = "radioNormalTexture";
            this.radioNormalTexture.Size = new System.Drawing.Size(76, 20);
            this.radioNormalTexture.TabIndex = 0;
            this.radioNormalTexture.TabStop = true;
            this.radioNormalTexture.Text = "Normal";
            this.radioNormalTexture.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioParallelOriented);
            this.groupBox1.Controls.Add(this.radioOriented);
            this.groupBox1.Controls.Add(this.radioParallel);
            this.groupBox1.Controls.Add(this.radioFacingUpright);
            this.groupBox1.Controls.Add(this.radioParallelUpright);
            this.groupBox1.Location = new System.Drawing.Point(365, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sprite type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(47, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fixed orientation in space";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(47, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Default type, image always faces camera";
            // 
            // radioParallelOriented
            // 
            this.radioParallelOriented.AutoSize = true;
            this.radioParallelOriented.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioParallelOriented.Location = new System.Drawing.Point(30, 128);
            this.radioParallelOriented.Name = "radioParallelOriented";
            this.radioParallelOriented.Size = new System.Drawing.Size(126, 20);
            this.radioParallelOriented.TabIndex = 4;
            this.radioParallelOriented.TabStop = true;
            this.radioParallelOriented.Text = "Parallel Oriented";
            this.radioParallelOriented.UseVisualStyleBackColor = true;
            // 
            // radioOriented
            // 
            this.radioOriented.AutoSize = true;
            this.radioOriented.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioOriented.Location = new System.Drawing.Point(30, 79);
            this.radioOriented.Name = "radioOriented";
            this.radioOriented.Size = new System.Drawing.Size(85, 20);
            this.radioOriented.TabIndex = 3;
            this.radioOriented.TabStop = true;
            this.radioOriented.Text = "Oriented";
            this.radioOriented.UseVisualStyleBackColor = true;
            // 
            // radioParallel
            // 
            this.radioParallel.AutoSize = true;
            this.radioParallel.Checked = true;
            this.radioParallel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioParallel.Location = new System.Drawing.Point(30, 32);
            this.radioParallel.Name = "radioParallel";
            this.radioParallel.Size = new System.Drawing.Size(80, 20);
            this.radioParallel.TabIndex = 2;
            this.radioParallel.TabStop = true;
            this.radioParallel.Text = "Parallel";
            this.radioParallel.UseVisualStyleBackColor = true;
            // 
            // radioFacingUpright
            // 
            this.radioFacingUpright.AutoSize = true;
            this.radioFacingUpright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioFacingUpright.Location = new System.Drawing.Point(30, 192);
            this.radioFacingUpright.Name = "radioFacingUpright";
            this.radioFacingUpright.Size = new System.Drawing.Size(113, 20);
            this.radioFacingUpright.TabIndex = 1;
            this.radioFacingUpright.TabStop = true;
            this.radioFacingUpright.Text = "Facing Upright";
            this.radioFacingUpright.UseVisualStyleBackColor = true;
            // 
            // radioParallelUpright
            // 
            this.radioParallelUpright.AutoSize = true;
            this.radioParallelUpright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioParallelUpright.Location = new System.Drawing.Point(30, 160);
            this.radioParallelUpright.Name = "radioParallelUpright";
            this.radioParallelUpright.Size = new System.Drawing.Size(118, 20);
            this.radioParallelUpright.TabIndex = 0;
            this.radioParallelUpright.TabStop = true;
            this.radioParallelUpright.Text = "Parallel Upright";
            this.radioParallelUpright.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.helpBrowser);
            this.tabPage3.Controls.Add(this.progLbl);
            this.tabPage3.Controls.Add(this.progBar);
            this.tabPage3.Controls.Add(this.buttonSaveSprite);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(716, 522);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3. Save";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // helpBrowser
            // 
            this.helpBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBrowser.IsWebBrowserContextMenuEnabled = false;
            this.helpBrowser.Location = new System.Drawing.Point(6, 6);
            this.helpBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.helpBrowser.Name = "helpBrowser";
            this.helpBrowser.Size = new System.Drawing.Size(702, 390);
            this.helpBrowser.TabIndex = 10;
            this.helpBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // progLbl
            // 
            this.progLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progLbl.AutoSize = true;
            this.progLbl.Location = new System.Drawing.Point(8, 415);
            this.progLbl.Name = "progLbl";
            this.progLbl.Size = new System.Drawing.Size(126, 16);
            this.progLbl.TabIndex = 9;
            this.progLbl.Text = "Creating sprite file ...";
            this.progLbl.Visible = false;
            // 
            // progBar
            // 
            this.progBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progBar.Location = new System.Drawing.Point(8, 434);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(700, 23);
            this.progBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progBar.TabIndex = 8;
            this.progBar.Visible = false;
            // 
            // buttonSaveSprite
            // 
            this.buttonSaveSprite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveSprite.Enabled = false;
            this.buttonSaveSprite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveSprite.Location = new System.Drawing.Point(8, 463);
            this.buttonSaveSprite.Name = "buttonSaveSprite";
            this.buttonSaveSprite.Size = new System.Drawing.Size(700, 51);
            this.buttonSaveSprite.TabIndex = 0;
            this.buttonSaveSprite.Text = "Save sprite";
            this.buttonSaveSprite.UseVisualStyleBackColor = true;
            this.buttonSaveSprite.Click += new System.EventHandler(this.buttonSaveSprite_Click);
            // 
            // addImagesFileDialog
            // 
            this.addImagesFileDialog.Filter = "Image files|*.bmp;*.png;*.jpg;*.gif;*.tiff|Bitmap files (*.bmp)|*.bmp|PNG files (" +
    "*.png)|*.png|JPEG files (*.jpg)|*.jpg|Gif files (*.gif)|*.gif|Tiff files (*.tiff" +
    ")|*.tiff";
            this.addImagesFileDialog.Multiselect = true;
            // 
            // saveSpriteFileDialog
            // 
            this.saveSpriteFileDialog.Filter = "HL SPR Files (*.spr)|*.spr";
            // 
            // NewSpriteForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 551);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewSpriteForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new sprite ...";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPaletteIndex)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddImages;
        private System.Windows.Forms.Button btnRemoveImages;
        private System.Windows.Forms.Button btnMoveImageUp;
        private System.Windows.Forms.Button btnMoveImageDown;
        private System.Windows.Forms.OpenFileDialog addImagesFileDialog;
        private System.Windows.Forms.Button buttonSaveSprite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioParallelOriented;
        private System.Windows.Forms.RadioButton radioOriented;
        private System.Windows.Forms.RadioButton radioParallel;
        private System.Windows.Forms.RadioButton radioFacingUpright;
        private System.Windows.Forms.RadioButton radioParallelUpright;
        private System.Windows.Forms.NumericUpDown inputPaletteIndex;
        private System.Windows.Forms.SaveFileDialog saveSpriteFileDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioAlphaTestTexture;
        private System.Windows.Forms.RadioButton radioIndexAlphaTexture;
        private System.Windows.Forms.RadioButton radioAdditiveTexture;
        private System.Windows.Forms.RadioButton radioNormalTexture;
        private System.Windows.Forms.Label label2;
        private ListViewEx listPictures;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Label progLbl;
        private System.Windows.Forms.WebBrowser helpBrowser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelPickTransparentColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColorDialog colorPicker;
    }
}