﻿namespace Intel_8086_forms
{
    partial class Intel8086
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SetRegistersGroupBox = new System.Windows.Forms.GroupBox();
            this.DlRegisterTextBox = new System.Windows.Forms.TextBox();
            this.DhRegisterTextBox = new System.Windows.Forms.TextBox();
            this.ClRegisterTextBox = new System.Windows.Forms.TextBox();
            this.ChRegisterTextBox = new System.Windows.Forms.TextBox();
            this.BlRegisterTextBox = new System.Windows.Forms.TextBox();
            this.BhRegisterTextBox = new System.Windows.Forms.TextBox();
            this.AlRegisterTextBox = new System.Windows.Forms.TextBox();
            this.AhRegisterTextBox = new System.Windows.Forms.TextBox();
            this.DlRegisterLabel = new System.Windows.Forms.Label();
            this.DhRegisterLabel = new System.Windows.Forms.Label();
            this.ClRegisterLabel = new System.Windows.Forms.Label();
            this.ChRegisterLabel = new System.Windows.Forms.Label();
            this.BhRegisterLabel = new System.Windows.Forms.Label();
            this.BlRegisterLabel = new System.Windows.Forms.Label();
            this.AhRegisterLabel = new System.Windows.Forms.Label();
            this.AlRegisterLabel = new System.Windows.Forms.Label();
            this.InstructionSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.Register1SelectionComboBox = new System.Windows.Forms.ComboBox();
            this.InstructionSelectionLabel = new System.Windows.Forms.Label();
            this.InstructionGroupBox = new System.Windows.Forms.GroupBox();
            this.Register1TextBox = new System.Windows.Forms.TextBox();
            this.Register2TextBox = new System.Windows.Forms.TextBox();
            this.Register2MemoryAdressCheckBox = new System.Windows.Forms.CheckBox();
            this.Register1MemoryAdressCheckBox = new System.Windows.Forms.CheckBox();
            this.Register2Label = new System.Windows.Forms.Label();
            this.Register1Label = new System.Windows.Forms.Label();
            this.Register2SelectionComboBox = new System.Windows.Forms.ComboBox();
            this.ClearRegistersButton = new System.Windows.Forms.Button();
            this.ExecuteInstructionButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SetRegistersButton = new System.Windows.Forms.Button();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MemoryStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutMemoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MemoryValueLabel = new System.Windows.Forms.Label();
            this.MemoryIndexLabel = new System.Windows.Forms.Label();
            this.SetRegistersGroupBox.SuspendLayout();
            this.InstructionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            this.MemoryStatusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetRegistersGroupBox
            // 
            this.SetRegistersGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SetRegistersGroupBox.Controls.Add(this.DlRegisterTextBox);
            this.SetRegistersGroupBox.Controls.Add(this.DhRegisterTextBox);
            this.SetRegistersGroupBox.Controls.Add(this.ClRegisterTextBox);
            this.SetRegistersGroupBox.Controls.Add(this.ChRegisterTextBox);
            this.SetRegistersGroupBox.Controls.Add(this.BlRegisterTextBox);
            this.SetRegistersGroupBox.Controls.Add(this.BhRegisterTextBox);
            this.SetRegistersGroupBox.Controls.Add(this.AlRegisterTextBox);
            this.SetRegistersGroupBox.Controls.Add(this.AhRegisterTextBox);
            this.SetRegistersGroupBox.Controls.Add(this.DlRegisterLabel);
            this.SetRegistersGroupBox.Controls.Add(this.DhRegisterLabel);
            this.SetRegistersGroupBox.Controls.Add(this.ClRegisterLabel);
            this.SetRegistersGroupBox.Controls.Add(this.ChRegisterLabel);
            this.SetRegistersGroupBox.Controls.Add(this.BhRegisterLabel);
            this.SetRegistersGroupBox.Controls.Add(this.BlRegisterLabel);
            this.SetRegistersGroupBox.Controls.Add(this.AhRegisterLabel);
            this.SetRegistersGroupBox.Controls.Add(this.AlRegisterLabel);
            this.SetRegistersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetRegistersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SetRegistersGroupBox.Name = "SetRegistersGroupBox";
            this.SetRegistersGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SetRegistersGroupBox.Size = new System.Drawing.Size(268, 278);
            this.SetRegistersGroupBox.TabIndex = 0;
            this.SetRegistersGroupBox.TabStop = false;
            this.SetRegistersGroupBox.Text = "Register State";
            // 
            // DlRegisterTextBox
            // 
            this.DlRegisterTextBox.Location = new System.Drawing.Point(187, 222);
            this.DlRegisterTextBox.Name = "DlRegisterTextBox";
            this.DlRegisterTextBox.Size = new System.Drawing.Size(37, 31);
            this.DlRegisterTextBox.TabIndex = 8;
            // 
            // DhRegisterTextBox
            // 
            this.DhRegisterTextBox.Location = new System.Drawing.Point(74, 222);
            this.DhRegisterTextBox.Name = "DhRegisterTextBox";
            this.DhRegisterTextBox.Size = new System.Drawing.Size(37, 31);
            this.DhRegisterTextBox.TabIndex = 7;
            // 
            // ClRegisterTextBox
            // 
            this.ClRegisterTextBox.Location = new System.Drawing.Point(187, 164);
            this.ClRegisterTextBox.Name = "ClRegisterTextBox";
            this.ClRegisterTextBox.Size = new System.Drawing.Size(37, 31);
            this.ClRegisterTextBox.TabIndex = 6;
            // 
            // ChRegisterTextBox
            // 
            this.ChRegisterTextBox.Location = new System.Drawing.Point(74, 164);
            this.ChRegisterTextBox.Name = "ChRegisterTextBox";
            this.ChRegisterTextBox.Size = new System.Drawing.Size(37, 31);
            this.ChRegisterTextBox.TabIndex = 5;
            // 
            // BlRegisterTextBox
            // 
            this.BlRegisterTextBox.Location = new System.Drawing.Point(187, 105);
            this.BlRegisterTextBox.Name = "BlRegisterTextBox";
            this.BlRegisterTextBox.Size = new System.Drawing.Size(37, 31);
            this.BlRegisterTextBox.TabIndex = 4;
            // 
            // BhRegisterTextBox
            // 
            this.BhRegisterTextBox.Location = new System.Drawing.Point(74, 105);
            this.BhRegisterTextBox.Name = "BhRegisterTextBox";
            this.BhRegisterTextBox.Size = new System.Drawing.Size(37, 31);
            this.BhRegisterTextBox.TabIndex = 3;
            // 
            // AlRegisterTextBox
            // 
            this.AlRegisterTextBox.Location = new System.Drawing.Point(187, 51);
            this.AlRegisterTextBox.Name = "AlRegisterTextBox";
            this.AlRegisterTextBox.Size = new System.Drawing.Size(37, 31);
            this.AlRegisterTextBox.TabIndex = 2;
            // 
            // AhRegisterTextBox
            // 
            this.AhRegisterTextBox.Location = new System.Drawing.Point(74, 51);
            this.AhRegisterTextBox.Name = "AhRegisterTextBox";
            this.AhRegisterTextBox.Size = new System.Drawing.Size(37, 31);
            this.AhRegisterTextBox.TabIndex = 1;
            // 
            // DlRegisterLabel
            // 
            this.DlRegisterLabel.AutoSize = true;
            this.DlRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DlRegisterLabel.Location = new System.Drawing.Point(146, 227);
            this.DlRegisterLabel.Name = "DlRegisterLabel";
            this.DlRegisterLabel.Size = new System.Drawing.Size(33, 24);
            this.DlRegisterLabel.TabIndex = 0;
            this.DlRegisterLabel.Text = "DL";
            // 
            // DhRegisterLabel
            // 
            this.DhRegisterLabel.AutoSize = true;
            this.DhRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DhRegisterLabel.Location = new System.Drawing.Point(30, 227);
            this.DhRegisterLabel.Name = "DhRegisterLabel";
            this.DhRegisterLabel.Size = new System.Drawing.Size(37, 24);
            this.DhRegisterLabel.TabIndex = 0;
            this.DhRegisterLabel.Text = "DH";
            // 
            // ClRegisterLabel
            // 
            this.ClRegisterLabel.AutoSize = true;
            this.ClRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClRegisterLabel.Location = new System.Drawing.Point(146, 169);
            this.ClRegisterLabel.Name = "ClRegisterLabel";
            this.ClRegisterLabel.Size = new System.Drawing.Size(33, 24);
            this.ClRegisterLabel.TabIndex = 0;
            this.ClRegisterLabel.Text = "CL";
            // 
            // ChRegisterLabel
            // 
            this.ChRegisterLabel.AutoSize = true;
            this.ChRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChRegisterLabel.Location = new System.Drawing.Point(30, 169);
            this.ChRegisterLabel.Name = "ChRegisterLabel";
            this.ChRegisterLabel.Size = new System.Drawing.Size(37, 24);
            this.ChRegisterLabel.TabIndex = 0;
            this.ChRegisterLabel.Text = "CH";
            // 
            // BhRegisterLabel
            // 
            this.BhRegisterLabel.AutoSize = true;
            this.BhRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BhRegisterLabel.Location = new System.Drawing.Point(30, 110);
            this.BhRegisterLabel.Name = "BhRegisterLabel";
            this.BhRegisterLabel.Size = new System.Drawing.Size(36, 24);
            this.BhRegisterLabel.TabIndex = 0;
            this.BhRegisterLabel.Text = "BH";
            // 
            // BlRegisterLabel
            // 
            this.BlRegisterLabel.AutoSize = true;
            this.BlRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BlRegisterLabel.Location = new System.Drawing.Point(146, 110);
            this.BlRegisterLabel.Name = "BlRegisterLabel";
            this.BlRegisterLabel.Size = new System.Drawing.Size(32, 24);
            this.BlRegisterLabel.TabIndex = 0;
            this.BlRegisterLabel.Text = "BL";
            // 
            // AhRegisterLabel
            // 
            this.AhRegisterLabel.AutoSize = true;
            this.AhRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AhRegisterLabel.Location = new System.Drawing.Point(30, 56);
            this.AhRegisterLabel.Name = "AhRegisterLabel";
            this.AhRegisterLabel.Size = new System.Drawing.Size(37, 24);
            this.AhRegisterLabel.TabIndex = 0;
            this.AhRegisterLabel.Text = "AH";
            // 
            // AlRegisterLabel
            // 
            this.AlRegisterLabel.AutoSize = true;
            this.AlRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlRegisterLabel.Location = new System.Drawing.Point(146, 56);
            this.AlRegisterLabel.Name = "AlRegisterLabel";
            this.AlRegisterLabel.Size = new System.Drawing.Size(33, 24);
            this.AlRegisterLabel.TabIndex = 0;
            this.AlRegisterLabel.Text = "AL";
            // 
            // InstructionSelectionComboBox
            // 
            this.InstructionSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstructionSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstructionSelectionComboBox.FormattingEnabled = true;
            this.InstructionSelectionComboBox.Items.AddRange(new object[] {
            "MOV",
            "XCHG",
            "AND",
            "OR",
            "XOR",
            "ADD",
            "SUB",
            "NOT",
            "INC",
            "DEC"});
            this.InstructionSelectionComboBox.Location = new System.Drawing.Point(15, 81);
            this.InstructionSelectionComboBox.Name = "InstructionSelectionComboBox";
            this.InstructionSelectionComboBox.Size = new System.Drawing.Size(177, 32);
            this.InstructionSelectionComboBox.TabIndex = 9;
            this.InstructionSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.InstructionSelectionComboBox_SelectedIndexChanged);
            // 
            // Register1SelectionComboBox
            // 
            this.Register1SelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Register1SelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register1SelectionComboBox.FormattingEnabled = true;
            this.Register1SelectionComboBox.Location = new System.Drawing.Point(15, 161);
            this.Register1SelectionComboBox.Name = "Register1SelectionComboBox";
            this.Register1SelectionComboBox.Size = new System.Drawing.Size(177, 32);
            this.Register1SelectionComboBox.TabIndex = 10;
            // 
            // InstructionSelectionLabel
            // 
            this.InstructionSelectionLabel.AutoSize = true;
            this.InstructionSelectionLabel.Location = new System.Drawing.Point(15, 45);
            this.InstructionSelectionLabel.Name = "InstructionSelectionLabel";
            this.InstructionSelectionLabel.Size = new System.Drawing.Size(111, 25);
            this.InstructionSelectionLabel.TabIndex = 3;
            this.InstructionSelectionLabel.Text = "Instruction";
            // 
            // InstructionGroupBox
            // 
            this.InstructionGroupBox.Controls.Add(this.Register1TextBox);
            this.InstructionGroupBox.Controls.Add(this.Register2TextBox);
            this.InstructionGroupBox.Controls.Add(this.Register2MemoryAdressCheckBox);
            this.InstructionGroupBox.Controls.Add(this.Register1MemoryAdressCheckBox);
            this.InstructionGroupBox.Controls.Add(this.Register2Label);
            this.InstructionGroupBox.Controls.Add(this.Register1Label);
            this.InstructionGroupBox.Controls.Add(this.InstructionSelectionLabel);
            this.InstructionGroupBox.Controls.Add(this.Register2SelectionComboBox);
            this.InstructionGroupBox.Controls.Add(this.Register1SelectionComboBox);
            this.InstructionGroupBox.Controls.Add(this.InstructionSelectionComboBox);
            this.InstructionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstructionGroupBox.Location = new System.Drawing.Point(297, 12);
            this.InstructionGroupBox.Name = "InstructionGroupBox";
            this.InstructionGroupBox.Size = new System.Drawing.Size(417, 278);
            this.InstructionGroupBox.TabIndex = 4;
            this.InstructionGroupBox.TabStop = false;
            this.InstructionGroupBox.Text = "Properties";
            // 
            // Register1TextBox
            // 
            this.Register1TextBox.Location = new System.Drawing.Point(15, 161);
            this.Register1TextBox.Name = "Register1TextBox";
            this.Register1TextBox.Size = new System.Drawing.Size(177, 31);
            this.Register1TextBox.TabIndex = 14;
            this.Register1TextBox.Visible = false;
            // 
            // Register2TextBox
            // 
            this.Register2TextBox.Location = new System.Drawing.Point(15, 234);
            this.Register2TextBox.Name = "Register2TextBox";
            this.Register2TextBox.Size = new System.Drawing.Size(177, 31);
            this.Register2TextBox.TabIndex = 14;
            this.Register2TextBox.Visible = false;
            // 
            // Register2MemoryAdressCheckBox
            // 
            this.Register2MemoryAdressCheckBox.AutoSize = true;
            this.Register2MemoryAdressCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register2MemoryAdressCheckBox.Location = new System.Drawing.Point(201, 239);
            this.Register2MemoryAdressCheckBox.Name = "Register2MemoryAdressCheckBox";
            this.Register2MemoryAdressCheckBox.Size = new System.Drawing.Size(177, 24);
            this.Register2MemoryAdressCheckBox.TabIndex = 13;
            this.Register2MemoryAdressCheckBox.Text = "Allow memory adress";
            this.Register2MemoryAdressCheckBox.UseVisualStyleBackColor = true;
            this.Register2MemoryAdressCheckBox.CheckedChanged += new System.EventHandler(this.Register2MemoryAdressCheckBox_CheckedChanged);
            // 
            // Register1MemoryAdressCheckBox
            // 
            this.Register1MemoryAdressCheckBox.AutoSize = true;
            this.Register1MemoryAdressCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register1MemoryAdressCheckBox.Location = new System.Drawing.Point(201, 166);
            this.Register1MemoryAdressCheckBox.Name = "Register1MemoryAdressCheckBox";
            this.Register1MemoryAdressCheckBox.Size = new System.Drawing.Size(177, 24);
            this.Register1MemoryAdressCheckBox.TabIndex = 12;
            this.Register1MemoryAdressCheckBox.Text = "Allow memory adress";
            this.Register1MemoryAdressCheckBox.UseVisualStyleBackColor = true;
            this.Register1MemoryAdressCheckBox.CheckedChanged += new System.EventHandler(this.Register1MemoryAdressCheckBox_CheckedChanged);
            // 
            // Register2Label
            // 
            this.Register2Label.AutoSize = true;
            this.Register2Label.Location = new System.Drawing.Point(15, 199);
            this.Register2Label.Name = "Register2Label";
            this.Register2Label.Size = new System.Drawing.Size(171, 25);
            this.Register2Label.TabIndex = 3;
            this.Register2Label.Text = "Second Register";
            // 
            // Register1Label
            // 
            this.Register1Label.AutoSize = true;
            this.Register1Label.Location = new System.Drawing.Point(15, 123);
            this.Register1Label.Name = "Register1Label";
            this.Register1Label.Size = new System.Drawing.Size(140, 25);
            this.Register1Label.TabIndex = 3;
            this.Register1Label.Text = "First Register";
            // 
            // Register2SelectionComboBox
            // 
            this.Register2SelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Register2SelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register2SelectionComboBox.FormattingEnabled = true;
            this.Register2SelectionComboBox.Items.AddRange(new object[] {
            "AH",
            "AL",
            "BH",
            "BL",
            "CH",
            "CL",
            "DH",
            "DL"});
            this.Register2SelectionComboBox.Location = new System.Drawing.Point(15, 234);
            this.Register2SelectionComboBox.Name = "Register2SelectionComboBox";
            this.Register2SelectionComboBox.Size = new System.Drawing.Size(177, 32);
            this.Register2SelectionComboBox.TabIndex = 11;
            // 
            // ClearRegistersButton
            // 
            this.ClearRegistersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearRegistersButton.Location = new System.Drawing.Point(12, 296);
            this.ClearRegistersButton.Name = "ClearRegistersButton";
            this.ClearRegistersButton.Size = new System.Drawing.Size(111, 53);
            this.ClearRegistersButton.TabIndex = 14;
            this.ClearRegistersButton.Text = "Clear";
            this.ClearRegistersButton.UseVisualStyleBackColor = true;
            this.ClearRegistersButton.Click += new System.EventHandler(this.ClearRegistersButton_Click);
            // 
            // ExecuteInstructionButton
            // 
            this.ExecuteInstructionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExecuteInstructionButton.Location = new System.Drawing.Point(398, 296);
            this.ExecuteInstructionButton.Name = "ExecuteInstructionButton";
            this.ExecuteInstructionButton.Size = new System.Drawing.Size(213, 53);
            this.ExecuteInstructionButton.TabIndex = 15;
            this.ExecuteInstructionButton.Text = "Execute";
            this.ExecuteInstructionButton.UseVisualStyleBackColor = true;
            this.ExecuteInstructionButton.Click += new System.EventHandler(this.ExecuteInstructionButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(826, 296);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(115, 53);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SetRegistersButton
            // 
            this.SetRegistersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetRegistersButton.Location = new System.Drawing.Point(169, 296);
            this.SetRegistersButton.Name = "SetRegistersButton";
            this.SetRegistersButton.Size = new System.Drawing.Size(111, 53);
            this.SetRegistersButton.TabIndex = 14;
            this.SetRegistersButton.Text = "Set";
            this.SetRegistersButton.UseVisualStyleBackColor = true;
            this.SetRegistersButton.Click += new System.EventHandler(this.SetRegistersButton_Click);
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataSource = typeof(Intel_8086_forms.Register);
            // 
            // MemoryStatusGroupBox
            // 
            this.MemoryStatusGroupBox.Controls.Add(this.label2);
            this.MemoryStatusGroupBox.Controls.Add(this.label1);
            this.MemoryStatusGroupBox.Controls.Add(this.flowLayoutMemoryPanel);
            this.MemoryStatusGroupBox.Controls.Add(this.MemoryValueLabel);
            this.MemoryStatusGroupBox.Controls.Add(this.MemoryIndexLabel);
            this.MemoryStatusGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemoryStatusGroupBox.Location = new System.Drawing.Point(720, 12);
            this.MemoryStatusGroupBox.Name = "MemoryStatusGroupBox";
            this.MemoryStatusGroupBox.Size = new System.Drawing.Size(221, 278);
            this.MemoryStatusGroupBox.TabIndex = 15;
            this.MemoryStatusGroupBox.TabStop = false;
            this.MemoryStatusGroupBox.Text = "Memory Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cell";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // flowLayoutMemoryPanel
            // 
            this.flowLayoutMemoryPanel.AutoScroll = true;
            this.flowLayoutMemoryPanel.Location = new System.Drawing.Point(3, 56);
            this.flowLayoutMemoryPanel.Name = "flowLayoutMemoryPanel";
            this.flowLayoutMemoryPanel.Size = new System.Drawing.Size(215, 219);
            this.flowLayoutMemoryPanel.TabIndex = 1;
            // 
            // MemoryValueLabel
            // 
            this.MemoryValueLabel.AutoSize = true;
            this.MemoryValueLabel.Location = new System.Drawing.Point(103, 46);
            this.MemoryValueLabel.Name = "MemoryValueLabel";
            this.MemoryValueLabel.Size = new System.Drawing.Size(0, 25);
            this.MemoryValueLabel.TabIndex = 0;
            // 
            // MemoryIndexLabel
            // 
            this.MemoryIndexLabel.AutoSize = true;
            this.MemoryIndexLabel.Location = new System.Drawing.Point(13, 46);
            this.MemoryIndexLabel.Name = "MemoryIndexLabel";
            this.MemoryIndexLabel.Size = new System.Drawing.Size(0, 25);
            this.MemoryIndexLabel.TabIndex = 0;
            // 
            // Intel8086
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 360);
            this.Controls.Add(this.MemoryStatusGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExecuteInstructionButton);
            this.Controls.Add(this.SetRegistersButton);
            this.Controls.Add(this.ClearRegistersButton);
            this.Controls.Add(this.InstructionGroupBox);
            this.Controls.Add(this.SetRegistersGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Intel8086";
            this.Text = "Intel 8086 simulator";
            this.Load += new System.EventHandler(this.Intel8086_Load);
            this.SetRegistersGroupBox.ResumeLayout(false);
            this.SetRegistersGroupBox.PerformLayout();
            this.InstructionGroupBox.ResumeLayout(false);
            this.InstructionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            this.MemoryStatusGroupBox.ResumeLayout(false);
            this.MemoryStatusGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox SetRegistersGroupBox;
        private Label DlRegisterLabel;
        private Label DhRegisterLabel;
        private Label ClRegisterLabel;
        private Label ChRegisterLabel;
        private Label BhRegisterLabel;
        private Label BlRegisterLabel;
        private Label AhRegisterLabel;
        private Label AlRegisterLabel;
        private TextBox DlRegisterTextBox;
        private TextBox DhRegisterTextBox;
        private TextBox ClRegisterTextBox;
        private TextBox ChRegisterTextBox;
        private TextBox BlRegisterTextBox;
        private TextBox BhRegisterTextBox;
        private TextBox AlRegisterTextBox;
        private TextBox AhRegisterTextBox;
        private ComboBox InstructionSelectionComboBox;
        private ComboBox Register1SelectionComboBox;
        private Label InstructionSelectionLabel;
        private GroupBox InstructionGroupBox;
        private Label Register1Label;
        private CheckBox Register1MemoryAdressCheckBox;
        private Label Register2Label;
        private ComboBox Register2SelectionComboBox;
        private CheckBox Register2MemoryAdressCheckBox;
        private Button ClearRegistersButton;
        private Button ExecuteInstructionButton;
        private Button ExitButton;
        private Button SetRegistersButton;
        private BindingSource registerBindingSource;
        private TextBox Register1TextBox;
        private TextBox Register2TextBox;
        private GroupBox MemoryStatusGroupBox;
        private Label MemoryValueLabel;
        private Label MemoryIndexLabel;
        private FlowLayoutPanel flowLayoutMemoryPanel;
        private Label label2;
        private Label label1;
    }
}