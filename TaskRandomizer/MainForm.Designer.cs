namespace AufgabenVerteiler
{
    partial class MainForm
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addElement = new System.Windows.Forms.TabPage();
            this.save = new System.Windows.Forms.Button();
            this.removeRow = new System.Windows.Forms.Button();
            this.addRow = new System.Windows.Forms.Button();
            this.removeRoleText = new System.Windows.Forms.TextBox();
            this.removeRole = new System.Windows.Forms.Button();
            this.addRoleText = new System.Windows.Forms.TextBox();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRole = new System.Windows.Forms.Button();
            this.roleSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rollCount = new System.Windows.Forms.NumericUpDown();
            this.roll = new System.Windows.Forms.Button();
            this.rollDisplay = new System.Windows.Forms.RichTextBox();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.addElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.addElement);
            this.tabs.Location = new System.Drawing.Point(5, 6);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(879, 432);
            this.tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rollDisplay);
            this.tabPage1.Controls.Add(this.roll);
            this.tabPage1.Controls.Add(this.rollCount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.roleSelection);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verteiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addElement
            // 
            this.addElement.Controls.Add(this.save);
            this.addElement.Controls.Add(this.removeRow);
            this.addElement.Controls.Add(this.addRow);
            this.addElement.Controls.Add(this.removeRoleText);
            this.addElement.Controls.Add(this.removeRole);
            this.addElement.Controls.Add(this.addRoleText);
            this.addElement.Controls.Add(this.dataTable);
            this.addElement.Controls.Add(this.addRole);
            this.addElement.Location = new System.Drawing.Point(4, 24);
            this.addElement.Name = "addElement";
            this.addElement.Padding = new System.Windows.Forms.Padding(3);
            this.addElement.Size = new System.Drawing.Size(871, 404);
            this.addElement.TabIndex = 1;
            this.addElement.Text = "Daten";
            this.addElement.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(789, 6);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "Speichern";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // removeRow
            // 
            this.removeRow.Location = new System.Drawing.Point(686, 5);
            this.removeRow.Name = "removeRow";
            this.removeRow.Size = new System.Drawing.Size(97, 23);
            this.removeRow.TabIndex = 6;
            this.removeRow.Text = "Zeile löschen";
            this.removeRow.UseVisualStyleBackColor = true;
            this.removeRow.Click += new System.EventHandler(this.removeRow_Click);
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(576, 6);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(104, 23);
            this.addRow.TabIndex = 1;
            this.addRow.Text = "Zeile hinzufügen";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // removeRoleText
            // 
            this.removeRoleText.Location = new System.Drawing.Point(392, 6);
            this.removeRoleText.Name = "removeRoleText";
            this.removeRoleText.PlaceholderText = "Name der Rolle";
            this.removeRoleText.Size = new System.Drawing.Size(178, 23);
            this.removeRoleText.TabIndex = 5;
            // 
            // removeRole
            // 
            this.removeRole.Location = new System.Drawing.Point(291, 6);
            this.removeRole.Name = "removeRole";
            this.removeRole.Size = new System.Drawing.Size(95, 23);
            this.removeRole.TabIndex = 4;
            this.removeRole.Text = "Rolle entfernen";
            this.removeRole.UseVisualStyleBackColor = true;
            this.removeRole.Click += new System.EventHandler(this.removeRole_Click);
            // 
            // addRoleText
            // 
            this.addRoleText.Location = new System.Drawing.Point(117, 6);
            this.addRoleText.Name = "addRoleText";
            this.addRoleText.PlaceholderText = "Name der Rolle";
            this.addRoleText.Size = new System.Drawing.Size(168, 23);
            this.addRoleText.TabIndex = 3;
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.dataTable.Location = new System.Drawing.Point(6, 35);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowTemplate.Height = 25;
            this.dataTable.Size = new System.Drawing.Size(858, 363);
            this.dataTable.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // addRole
            // 
            this.addRole.Location = new System.Drawing.Point(6, 6);
            this.addRole.Name = "addRole";
            this.addRole.Size = new System.Drawing.Size(105, 23);
            this.addRole.TabIndex = 1;
            this.addRole.Text = "Rolle hinzufügen";
            this.addRole.UseVisualStyleBackColor = true;
            this.addRole.Click += new System.EventHandler(this.addRole_Click);
            // 
            // roleSelection
            // 
            this.roleSelection.FormattingEnabled = true;
            this.roleSelection.Location = new System.Drawing.Point(439, 20);
            this.roleSelection.Name = "roleSelection";
            this.roleSelection.Size = new System.Drawing.Size(154, 23);
            this.roleSelection.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wähle eine Rolle aus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anzahl an Auserwählten:";
            // 
            // rollCount
            // 
            this.rollCount.Location = new System.Drawing.Point(439, 62);
            this.rollCount.Name = "rollCount";
            this.rollCount.Size = new System.Drawing.Size(154, 23);
            this.rollCount.TabIndex = 3;
            // 
            // roll
            // 
            this.roll.Location = new System.Drawing.Point(391, 100);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(75, 23);
            this.roll.TabIndex = 4;
            this.roll.Text = "Rollen";
            this.roll.UseVisualStyleBackColor = true;
            this.roll.Click += new System.EventHandler(this.roll_Click);
            // 
            // rollDisplay
            // 
            this.rollDisplay.Location = new System.Drawing.Point(278, 134);
            this.rollDisplay.Name = "rollDisplay";
            this.rollDisplay.Size = new System.Drawing.Size(315, 264);
            this.rollDisplay.TabIndex = 5;
            this.rollDisplay.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 440);
            this.Controls.Add(this.tabs);
            this.Name = "mainForm";
            this.Text = "Aufgaben Verteiler";
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.addElement.ResumeLayout(false);
            this.addElement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabs;
        private TabPage tabPage1;
        private TabPage addElement;
        private Button addRole;
        private DataGridView dataTable;
        private TextBox addRoleText;
        private TextBox removeRoleText;
        private Button removeRole;
        private Button removeRow;
        private Button addRow;
        private DataGridViewTextBoxColumn ID;
        private Button save;
        private Label label1;
        private ComboBox roleSelection;
        private NumericUpDown rollCount;
        private Label label2;
        private Button roll;
        private RichTextBox rollDisplay;
    }
}