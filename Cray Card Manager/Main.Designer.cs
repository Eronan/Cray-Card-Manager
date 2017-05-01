namespace Cray_Card_Manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ManagerTabs = new System.Windows.Forms.TabControl();
            this.CardCreation = new System.Windows.Forms.TabPage();
            this.button_MassAdd = new System.Windows.Forms.Button();
            this.button_LoadTemplate = new System.Windows.Forms.Button();
            this.button_OpenCard = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox_CardText = new System.Windows.Forms.GroupBox();
            this.richTextBox_Abilities = new System.Windows.Forms.RichTextBox();
            this.label_Abilities = new System.Windows.Forms.Label();
            this.richTextBox_Flavour = new System.Windows.Forms.RichTextBox();
            this.label_Flavour = new System.Windows.Forms.Label();
            this.groupBox_CardInfo = new System.Windows.Forms.GroupBox();
            this.comboBox_Trigger = new System.Windows.Forms.ComboBox();
            this.label_Trigger = new System.Windows.Forms.Label();
            this.label_Critical = new System.Windows.Forms.Label();
            this.numeric_Critical = new System.Windows.Forms.NumericUpDown();
            this.checkBox_NoShield = new System.Windows.Forms.CheckBox();
            this.numeric_Power = new System.Windows.Forms.NumericUpDown();
            this.label_Shield = new System.Windows.Forms.Label();
            this.numeric_Shield = new System.Windows.Forms.NumericUpDown();
            this.textBox_Illust = new System.Windows.Forms.TextBox();
            this.label_Illustrator = new System.Windows.Forms.Label();
            this.comboBox_Nation = new System.Windows.Forms.ComboBox();
            this.label_Nation = new System.Windows.Forms.Label();
            this.comboBox_Race = new System.Windows.Forms.ComboBox();
            this.label_Race = new System.Windows.Forms.Label();
            this.comboBox_Clan = new System.Windows.Forms.ComboBox();
            this.label_Clan = new System.Windows.Forms.Label();
            this.label_Power = new System.Windows.Forms.Label();
            this.comboBox_SkillIcon = new System.Windows.Forms.ComboBox();
            this.numeric_Grade = new System.Windows.Forms.NumericUpDown();
            this.label_Grade = new System.Windows.Forms.Label();
            this.comboBox_UClass = new System.Windows.Forms.ComboBox();
            this.label_Unit = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_CardID = new System.Windows.Forms.TextBox();
            this.label_Code = new System.Windows.Forms.Label();
            this.cardIDLabel = new System.Windows.Forms.Label();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.listBox_SearchList = new System.Windows.Forms.ListBox();
            this.textBox_SetSearch = new System.Windows.Forms.TextBox();
            this.textBox_NameSearch = new System.Windows.Forms.TextBox();
            this.button_LoadImage = new System.Windows.Forms.Button();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.CardPackerImport = new System.Windows.Forms.TabPage();
            this.CardPackerExport = new System.Windows.Forms.TabPage();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ExpSaveButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ExpCardIDImp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpCardNameImp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExportGroupImp = new System.Windows.Forms.GroupBox();
            this.newImportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportLabelImp = new System.Windows.Forms.Label();
            this.ExportListExp = new System.Windows.Forms.ListView();
            this.CardID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExportIDSearch = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.Label();
            this.ExportNameSearch = new System.Windows.Forms.TextBox();
            this.ExportNameLabel = new System.Windows.Forms.Label();
            this.ExportGroupExp = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFile_Images = new System.Windows.Forms.OpenFileDialog();
            this.openFile_Card = new System.Windows.Forms.OpenFileDialog();
            this.ManagerTabs.SuspendLayout();
            this.CardCreation.SuspendLayout();
            this.groupBox_CardText.SuspendLayout();
            this.groupBox_CardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Critical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Shield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Grade)).BeginInit();
            this.groupBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.CardPackerExport.SuspendLayout();
            this.ExportGroupImp.SuspendLayout();
            this.ExportGroupExp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerTabs
            // 
            this.ManagerTabs.Controls.Add(this.CardCreation);
            this.ManagerTabs.Controls.Add(this.CardPackerImport);
            this.ManagerTabs.Controls.Add(this.CardPackerExport);
            this.ManagerTabs.Location = new System.Drawing.Point(-1, -1);
            this.ManagerTabs.Name = "ManagerTabs";
            this.ManagerTabs.SelectedIndex = 0;
            this.ManagerTabs.Size = new System.Drawing.Size(752, 508);
            this.ManagerTabs.TabIndex = 1;
            // 
            // CardCreation
            // 
            this.CardCreation.BackColor = System.Drawing.SystemColors.Control;
            this.CardCreation.Controls.Add(this.button_MassAdd);
            this.CardCreation.Controls.Add(this.button_LoadTemplate);
            this.CardCreation.Controls.Add(this.button_OpenCard);
            this.CardCreation.Controls.Add(this.button_Save);
            this.CardCreation.Controls.Add(this.button_Delete);
            this.CardCreation.Controls.Add(this.button_Clear);
            this.CardCreation.Controls.Add(this.groupBox_CardText);
            this.CardCreation.Controls.Add(this.groupBox_CardInfo);
            this.CardCreation.Controls.Add(this.groupBox_Search);
            this.CardCreation.Controls.Add(this.button_LoadImage);
            this.CardCreation.Controls.Add(this.pictureBox_Image);
            this.CardCreation.Location = new System.Drawing.Point(4, 22);
            this.CardCreation.Name = "CardCreation";
            this.CardCreation.Padding = new System.Windows.Forms.Padding(3);
            this.CardCreation.Size = new System.Drawing.Size(744, 482);
            this.CardCreation.TabIndex = 0;
            this.CardCreation.Text = "Create Cards";
            // 
            // button_MassAdd
            // 
            this.button_MassAdd.Location = new System.Drawing.Point(663, 416);
            this.button_MassAdd.Name = "button_MassAdd";
            this.button_MassAdd.Size = new System.Drawing.Size(75, 23);
            this.button_MassAdd.TabIndex = 11;
            this.button_MassAdd.Text = "Mass Add";
            this.button_MassAdd.UseVisualStyleBackColor = true;
            // 
            // button_LoadTemplate
            // 
            this.button_LoadTemplate.Location = new System.Drawing.Point(608, 387);
            this.button_LoadTemplate.Name = "button_LoadTemplate";
            this.button_LoadTemplate.Size = new System.Drawing.Size(130, 23);
            this.button_LoadTemplate.TabIndex = 10;
            this.button_LoadTemplate.Text = "Load Template";
            this.button_LoadTemplate.UseVisualStyleBackColor = true;
            this.button_LoadTemplate.Click += new System.EventHandler(this.button_LoadTemplate_Click);
            // 
            // button_OpenCard
            // 
            this.button_OpenCard.Location = new System.Drawing.Point(527, 387);
            this.button_OpenCard.Name = "button_OpenCard";
            this.button_OpenCard.Size = new System.Drawing.Size(75, 23);
            this.button_OpenCard.TabIndex = 9;
            this.button_OpenCard.Text = "Open Card";
            this.button_OpenCard.UseVisualStyleBackColor = true;
            this.button_OpenCard.Click += new System.EventHandler(this.button_OpenCard_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(504, 358);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Save Card";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(582, 358);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Delete Card";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(663, 358);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // groupBox_CardText
            // 
            this.groupBox_CardText.Controls.Add(this.richTextBox_Abilities);
            this.groupBox_CardText.Controls.Add(this.label_Abilities);
            this.groupBox_CardText.Controls.Add(this.richTextBox_Flavour);
            this.groupBox_CardText.Controls.Add(this.label_Flavour);
            this.groupBox_CardText.Location = new System.Drawing.Point(405, 8);
            this.groupBox_CardText.Name = "groupBox_CardText";
            this.groupBox_CardText.Size = new System.Drawing.Size(334, 344);
            this.groupBox_CardText.TabIndex = 4;
            this.groupBox_CardText.TabStop = false;
            this.groupBox_CardText.Text = "Card Text";
            // 
            // richTextBox_Abilities
            // 
            this.richTextBox_Abilities.Location = new System.Drawing.Point(6, 33);
            this.richTextBox_Abilities.Name = "richTextBox_Abilities";
            this.richTextBox_Abilities.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_Abilities.Size = new System.Drawing.Size(318, 186);
            this.richTextBox_Abilities.TabIndex = 1;
            this.richTextBox_Abilities.Text = "";
            // 
            // label_Abilities
            // 
            this.label_Abilities.AutoSize = true;
            this.label_Abilities.Location = new System.Drawing.Point(3, 17);
            this.label_Abilities.Name = "label_Abilities";
            this.label_Abilities.Size = new System.Drawing.Size(45, 13);
            this.label_Abilities.TabIndex = 0;
            this.label_Abilities.Text = "Abilities:";
            // 
            // richTextBox_Flavour
            // 
            this.richTextBox_Flavour.Location = new System.Drawing.Point(6, 238);
            this.richTextBox_Flavour.Name = "richTextBox_Flavour";
            this.richTextBox_Flavour.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_Flavour.Size = new System.Drawing.Size(318, 100);
            this.richTextBox_Flavour.TabIndex = 3;
            this.richTextBox_Flavour.Text = "";
            // 
            // label_Flavour
            // 
            this.label_Flavour.AutoSize = true;
            this.label_Flavour.Location = new System.Drawing.Point(3, 222);
            this.label_Flavour.Name = "label_Flavour";
            this.label_Flavour.Size = new System.Drawing.Size(69, 13);
            this.label_Flavour.TabIndex = 2;
            this.label_Flavour.Text = "Flavour Text:";
            // 
            // groupBox_CardInfo
            // 
            this.groupBox_CardInfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_CardInfo.Controls.Add(this.comboBox_Trigger);
            this.groupBox_CardInfo.Controls.Add(this.label_Trigger);
            this.groupBox_CardInfo.Controls.Add(this.label_Critical);
            this.groupBox_CardInfo.Controls.Add(this.numeric_Critical);
            this.groupBox_CardInfo.Controls.Add(this.checkBox_NoShield);
            this.groupBox_CardInfo.Controls.Add(this.numeric_Power);
            this.groupBox_CardInfo.Controls.Add(this.label_Shield);
            this.groupBox_CardInfo.Controls.Add(this.numeric_Shield);
            this.groupBox_CardInfo.Controls.Add(this.textBox_Illust);
            this.groupBox_CardInfo.Controls.Add(this.label_Illustrator);
            this.groupBox_CardInfo.Controls.Add(this.comboBox_Nation);
            this.groupBox_CardInfo.Controls.Add(this.label_Nation);
            this.groupBox_CardInfo.Controls.Add(this.comboBox_Race);
            this.groupBox_CardInfo.Controls.Add(this.label_Race);
            this.groupBox_CardInfo.Controls.Add(this.comboBox_Clan);
            this.groupBox_CardInfo.Controls.Add(this.label_Clan);
            this.groupBox_CardInfo.Controls.Add(this.label_Power);
            this.groupBox_CardInfo.Controls.Add(this.comboBox_SkillIcon);
            this.groupBox_CardInfo.Controls.Add(this.numeric_Grade);
            this.groupBox_CardInfo.Controls.Add(this.label_Grade);
            this.groupBox_CardInfo.Controls.Add(this.comboBox_UClass);
            this.groupBox_CardInfo.Controls.Add(this.label_Unit);
            this.groupBox_CardInfo.Controls.Add(this.textBox_Name);
            this.groupBox_CardInfo.Controls.Add(this.label_Name);
            this.groupBox_CardInfo.Controls.Add(this.textBox_CardID);
            this.groupBox_CardInfo.Controls.Add(this.label_Code);
            this.groupBox_CardInfo.Controls.Add(this.cardIDLabel);
            this.groupBox_CardInfo.Location = new System.Drawing.Point(173, 8);
            this.groupBox_CardInfo.Name = "groupBox_CardInfo";
            this.groupBox_CardInfo.Size = new System.Drawing.Size(226, 338);
            this.groupBox_CardInfo.TabIndex = 3;
            this.groupBox_CardInfo.TabStop = false;
            this.groupBox_CardInfo.Text = "Card Info";
            // 
            // comboBox_Trigger
            // 
            this.comboBox_Trigger.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Trigger.DropDownHeight = 212;
            this.comboBox_Trigger.Enabled = false;
            this.comboBox_Trigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Trigger.FormattingEnabled = true;
            this.comboBox_Trigger.IntegralHeight = false;
            this.comboBox_Trigger.Items.AddRange(new object[] {
            "",
            "Critical",
            "Draw",
            "Stand",
            "Heal"});
            this.comboBox_Trigger.Location = new System.Drawing.Point(64, 98);
            this.comboBox_Trigger.MaxDropDownItems = 30;
            this.comboBox_Trigger.MaxLength = 100;
            this.comboBox_Trigger.Name = "comboBox_Trigger";
            this.comboBox_Trigger.Size = new System.Drawing.Size(153, 21);
            this.comboBox_Trigger.TabIndex = 6;
            // 
            // label_Trigger
            // 
            this.label_Trigger.AutoSize = true;
            this.label_Trigger.Location = new System.Drawing.Point(17, 101);
            this.label_Trigger.Name = "label_Trigger";
            this.label_Trigger.Size = new System.Drawing.Size(43, 13);
            this.label_Trigger.TabIndex = 6;
            this.label_Trigger.Text = "Trigger:";
            // 
            // label_Critical
            // 
            this.label_Critical.AutoSize = true;
            this.label_Critical.Location = new System.Drawing.Point(18, 206);
            this.label_Critical.Name = "label_Critical";
            this.label_Critical.Size = new System.Drawing.Size(41, 13);
            this.label_Critical.TabIndex = 14;
            this.label_Critical.Text = "Critical:";
            // 
            // numeric_Critical
            // 
            this.numeric_Critical.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numeric_Critical.Location = new System.Drawing.Point(64, 204);
            this.numeric_Critical.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_Critical.Name = "numeric_Critical";
            this.numeric_Critical.ReadOnly = true;
            this.numeric_Critical.Size = new System.Drawing.Size(30, 20);
            this.numeric_Critical.TabIndex = 15;
            this.numeric_Critical.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_NoShield
            // 
            this.checkBox_NoShield.AutoSize = true;
            this.checkBox_NoShield.Location = new System.Drawing.Point(148, 180);
            this.checkBox_NoShield.Name = "checkBox_NoShield";
            this.checkBox_NoShield.Size = new System.Drawing.Size(72, 17);
            this.checkBox_NoShield.TabIndex = 13;
            this.checkBox_NoShield.Text = "No Shield";
            this.checkBox_NoShield.UseVisualStyleBackColor = true;
            this.checkBox_NoShield.CheckedChanged += new System.EventHandler(this.checkBox_NoShield_CheckedChanged);
            // 
            // numeric_Power
            // 
            this.numeric_Power.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numeric_Power.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_Power.Location = new System.Drawing.Point(64, 152);
            this.numeric_Power.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numeric_Power.Name = "numeric_Power";
            this.numeric_Power.Size = new System.Drawing.Size(153, 20);
            this.numeric_Power.TabIndex = 10;
            this.numeric_Power.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numeric_Power.ValueChanged += new System.EventHandler(this.numeric_Power_ValueChanged);
            // 
            // label_Shield
            // 
            this.label_Shield.AutoSize = true;
            this.label_Shield.Location = new System.Drawing.Point(18, 181);
            this.label_Shield.Name = "label_Shield";
            this.label_Shield.Size = new System.Drawing.Size(39, 13);
            this.label_Shield.TabIndex = 11;
            this.label_Shield.Text = "Shield:";
            // 
            // numeric_Shield
            // 
            this.numeric_Shield.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numeric_Shield.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numeric_Shield.Location = new System.Drawing.Point(64, 178);
            this.numeric_Shield.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numeric_Shield.Name = "numeric_Shield";
            this.numeric_Shield.Size = new System.Drawing.Size(78, 20);
            this.numeric_Shield.TabIndex = 12;
            // 
            // textBox_Illust
            // 
            this.textBox_Illust.Location = new System.Drawing.Point(64, 311);
            this.textBox_Illust.MaxLength = 30;
            this.textBox_Illust.Name = "textBox_Illust";
            this.textBox_Illust.Size = new System.Drawing.Size(153, 20);
            this.textBox_Illust.TabIndex = 23;
            // 
            // label_Illustrator
            // 
            this.label_Illustrator.AutoSize = true;
            this.label_Illustrator.Location = new System.Drawing.Point(6, 314);
            this.label_Illustrator.Name = "label_Illustrator";
            this.label_Illustrator.Size = new System.Drawing.Size(52, 13);
            this.label_Illustrator.TabIndex = 22;
            this.label_Illustrator.Text = "Illustrator:";
            // 
            // comboBox_Nation
            // 
            this.comboBox_Nation.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Nation.DropDownHeight = 212;
            this.comboBox_Nation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Nation.FormattingEnabled = true;
            this.comboBox_Nation.IntegralHeight = false;
            this.comboBox_Nation.Location = new System.Drawing.Point(64, 284);
            this.comboBox_Nation.MaxLength = 30;
            this.comboBox_Nation.Name = "comboBox_Nation";
            this.comboBox_Nation.Size = new System.Drawing.Size(153, 21);
            this.comboBox_Nation.TabIndex = 21;
            this.comboBox_Nation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Clan_KeyPress);
            // 
            // label_Nation
            // 
            this.label_Nation.AutoSize = true;
            this.label_Nation.Location = new System.Drawing.Point(17, 287);
            this.label_Nation.Name = "label_Nation";
            this.label_Nation.Size = new System.Drawing.Size(41, 13);
            this.label_Nation.TabIndex = 20;
            this.label_Nation.Text = "Nation:";
            // 
            // comboBox_Race
            // 
            this.comboBox_Race.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Race.DropDownHeight = 212;
            this.comboBox_Race.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Race.FormattingEnabled = true;
            this.comboBox_Race.IntegralHeight = false;
            this.comboBox_Race.Location = new System.Drawing.Point(64, 257);
            this.comboBox_Race.MaxDropDownItems = 16;
            this.comboBox_Race.MaxLength = 30;
            this.comboBox_Race.Name = "comboBox_Race";
            this.comboBox_Race.Size = new System.Drawing.Size(153, 21);
            this.comboBox_Race.TabIndex = 19;
            this.comboBox_Race.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Race_KeyPress);
            // 
            // label_Race
            // 
            this.label_Race.AutoSize = true;
            this.label_Race.Location = new System.Drawing.Point(22, 260);
            this.label_Race.Name = "label_Race";
            this.label_Race.Size = new System.Drawing.Size(36, 13);
            this.label_Race.TabIndex = 18;
            this.label_Race.Text = "Race:";
            // 
            // comboBox_Clan
            // 
            this.comboBox_Clan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_Clan.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Clan.CausesValidation = false;
            this.comboBox_Clan.DropDownHeight = 212;
            this.comboBox_Clan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Clan.FormattingEnabled = true;
            this.comboBox_Clan.IntegralHeight = false;
            this.comboBox_Clan.Location = new System.Drawing.Point(64, 230);
            this.comboBox_Clan.MaxDropDownItems = 30;
            this.comboBox_Clan.MaxLength = 30;
            this.comboBox_Clan.Name = "comboBox_Clan";
            this.comboBox_Clan.Size = new System.Drawing.Size(153, 21);
            this.comboBox_Clan.TabIndex = 17;
            this.comboBox_Clan.SelectedIndexChanged += new System.EventHandler(this.comboBox_Clan_SelectedIndexChanged);
            this.comboBox_Clan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Clan_KeyPress);
            // 
            // label_Clan
            // 
            this.label_Clan.AutoSize = true;
            this.label_Clan.Location = new System.Drawing.Point(27, 233);
            this.label_Clan.Name = "label_Clan";
            this.label_Clan.Size = new System.Drawing.Size(31, 13);
            this.label_Clan.TabIndex = 16;
            this.label_Clan.Text = "Clan:";
            // 
            // label_Power
            // 
            this.label_Power.AutoSize = true;
            this.label_Power.Location = new System.Drawing.Point(18, 155);
            this.label_Power.Name = "label_Power";
            this.label_Power.Size = new System.Drawing.Size(40, 13);
            this.label_Power.TabIndex = 9;
            this.label_Power.Text = "Power:";
            // 
            // comboBox_SkillIcon
            // 
            this.comboBox_SkillIcon.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_SkillIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SkillIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SkillIcon.FormattingEnabled = true;
            this.comboBox_SkillIcon.Items.AddRange(new object[] {
            "Boost",
            "Intercept",
            "Twin Drive",
            "Triple Drive",
            ""});
            this.comboBox_SkillIcon.Location = new System.Drawing.Point(100, 125);
            this.comboBox_SkillIcon.MaxLength = 30;
            this.comboBox_SkillIcon.Name = "comboBox_SkillIcon";
            this.comboBox_SkillIcon.Size = new System.Drawing.Size(117, 21);
            this.comboBox_SkillIcon.TabIndex = 8;
            // 
            // numeric_Grade
            // 
            this.numeric_Grade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numeric_Grade.Location = new System.Drawing.Point(64, 126);
            this.numeric_Grade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_Grade.Name = "numeric_Grade";
            this.numeric_Grade.ReadOnly = true;
            this.numeric_Grade.Size = new System.Drawing.Size(30, 20);
            this.numeric_Grade.TabIndex = 7;
            this.numeric_Grade.ValueChanged += new System.EventHandler(this.numeric_Grade_ValueChanged);
            // 
            // label_Grade
            // 
            this.label_Grade.AutoSize = true;
            this.label_Grade.Location = new System.Drawing.Point(19, 128);
            this.label_Grade.Name = "label_Grade";
            this.label_Grade.Size = new System.Drawing.Size(39, 13);
            this.label_Grade.TabIndex = 6;
            this.label_Grade.Text = "Grade:";
            // 
            // comboBox_UClass
            // 
            this.comboBox_UClass.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_UClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_UClass.FormattingEnabled = true;
            this.comboBox_UClass.Items.AddRange(new object[] {
            "Normal Unit",
            "Trigger Unit",
            "G Unit"});
            this.comboBox_UClass.Location = new System.Drawing.Point(64, 71);
            this.comboBox_UClass.MaxLength = 30;
            this.comboBox_UClass.Name = "comboBox_UClass";
            this.comboBox_UClass.Size = new System.Drawing.Size(153, 21);
            this.comboBox_UClass.TabIndex = 5;
            this.comboBox_UClass.SelectedIndexChanged += new System.EventHandler(this.comboBox_UClass_SelectedIndexChanged);
            // 
            // label_Unit
            // 
            this.label_Unit.AutoSize = true;
            this.label_Unit.Location = new System.Drawing.Point(29, 74);
            this.label_Unit.Name = "label_Unit";
            this.label_Unit.Size = new System.Drawing.Size(29, 13);
            this.label_Unit.TabIndex = 4;
            this.label_Unit.Text = "Unit:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(64, 46);
            this.textBox_Name.MaxLength = 62;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(153, 20);
            this.textBox_Name.TabIndex = 3;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(23, 49);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(38, 13);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Name:";
            // 
            // textBox_CardID
            // 
            this.textBox_CardID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_CardID.Location = new System.Drawing.Point(64, 20);
            this.textBox_CardID.MaxLength = 11;
            this.textBox_CardID.Name = "textBox_CardID";
            this.textBox_CardID.Size = new System.Drawing.Size(153, 20);
            this.textBox_CardID.TabIndex = 1;
            // 
            // label_Code
            // 
            this.label_Code.AutoSize = true;
            this.label_Code.Location = new System.Drawing.Point(26, 23);
            this.label_Code.Name = "label_Code";
            this.label_Code.Size = new System.Drawing.Size(35, 13);
            this.label_Code.TabIndex = 0;
            this.label_Code.Text = "Code:";
            // 
            // cardIDLabel
            // 
            this.cardIDLabel.AutoSize = true;
            this.cardIDLabel.Location = new System.Drawing.Point(23, 23);
            this.cardIDLabel.Name = "cardIDLabel";
            this.cardIDLabel.Size = new System.Drawing.Size(35, 13);
            this.cardIDLabel.TabIndex = 0;
            this.cardIDLabel.Text = "Code:";
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.listBox_SearchList);
            this.groupBox_Search.Controls.Add(this.textBox_SetSearch);
            this.groupBox_Search.Controls.Add(this.textBox_NameSearch);
            this.groupBox_Search.Location = new System.Drawing.Point(8, 228);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(159, 251);
            this.groupBox_Search.TabIndex = 0;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Search";
            // 
            // listBox_SearchList
            // 
            this.listBox_SearchList.DisplayMember = "Value";
            this.listBox_SearchList.FormattingEnabled = true;
            this.listBox_SearchList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listBox_SearchList.Location = new System.Drawing.Point(6, 19);
            this.listBox_SearchList.Name = "listBox_SearchList";
            this.listBox_SearchList.Size = new System.Drawing.Size(147, 199);
            this.listBox_SearchList.TabIndex = 0;
            this.listBox_SearchList.ValueMember = "Key";
            this.listBox_SearchList.DoubleClick += new System.EventHandler(this.listBox_SearchList_DoubleClick);
            // 
            // textBox_SetSearch
            // 
            this.textBox_SetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SetSearch.ForeColor = System.Drawing.Color.Gray;
            this.textBox_SetSearch.Location = new System.Drawing.Point(109, 225);
            this.textBox_SetSearch.Name = "textBox_SetSearch";
            this.textBox_SetSearch.Size = new System.Drawing.Size(45, 20);
            this.textBox_SetSearch.TabIndex = 2;
            this.textBox_SetSearch.Text = "Set";
            this.textBox_SetSearch.TextChanged += new System.EventHandler(this.textbox_Search_TextChanged);
            this.textBox_SetSearch.GotFocus += new System.EventHandler(this.textBox_Search_GotFocus);
            this.textBox_SetSearch.LostFocus += new System.EventHandler(this.textbox_SetSearch_LostFocus);
            // 
            // textBox_NameSearch
            // 
            this.textBox_NameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameSearch.ForeColor = System.Drawing.Color.Gray;
            this.textBox_NameSearch.Location = new System.Drawing.Point(6, 225);
            this.textBox_NameSearch.Name = "textBox_NameSearch";
            this.textBox_NameSearch.Size = new System.Drawing.Size(97, 20);
            this.textBox_NameSearch.TabIndex = 1;
            this.textBox_NameSearch.Text = "Name";
            this.textBox_NameSearch.TextChanged += new System.EventHandler(this.textbox_Search_TextChanged);
            this.textBox_NameSearch.GotFocus += new System.EventHandler(this.textBox_Search_GotFocus);
            this.textBox_NameSearch.LostFocus += new System.EventHandler(this.textbox_NameSearch_LostFocus);
            // 
            // button_LoadImage
            // 
            this.button_LoadImage.Location = new System.Drawing.Point(49, 199);
            this.button_LoadImage.Name = "button_LoadImage";
            this.button_LoadImage.Size = new System.Drawing.Size(75, 23);
            this.button_LoadImage.TabIndex = 2;
            this.button_LoadImage.Text = "Set Image";
            this.button_LoadImage.UseVisualStyleBackColor = true;
            this.button_LoadImage.Click += new System.EventHandler(this.button_LoadImage_Click);
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Image.Image = global::Cray_Card_Manager.Properties.Resources.Sleeve_Blue;
            this.pictureBox_Image.Location = new System.Drawing.Point(25, 8);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(125, 185);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Image.TabIndex = 0;
            this.pictureBox_Image.TabStop = false;
            // 
            // CardPackerImport
            // 
            this.CardPackerImport.BackColor = System.Drawing.SystemColors.Control;
            this.CardPackerImport.Location = new System.Drawing.Point(4, 22);
            this.CardPackerImport.Name = "CardPackerImport";
            this.CardPackerImport.Padding = new System.Windows.Forms.Padding(3);
            this.CardPackerImport.Size = new System.Drawing.Size(744, 482);
            this.CardPackerImport.TabIndex = 1;
            this.CardPackerImport.Text = "Import Cards";
            // 
            // CardPackerExport
            // 
            this.CardPackerExport.BackColor = System.Drawing.SystemColors.Control;
            this.CardPackerExport.Controls.Add(this.ExportButton);
            this.CardPackerExport.Controls.Add(this.ExpSaveButton);
            this.CardPackerExport.Controls.Add(this.progressBar1);
            this.CardPackerExport.Controls.Add(this.listView1);
            this.CardPackerExport.Controls.Add(this.ExportGroupImp);
            this.CardPackerExport.Controls.Add(this.ExportListExp);
            this.CardPackerExport.Controls.Add(this.ExportIDSearch);
            this.CardPackerExport.Controls.Add(this.Code);
            this.CardPackerExport.Controls.Add(this.ExportNameSearch);
            this.CardPackerExport.Controls.Add(this.ExportNameLabel);
            this.CardPackerExport.Controls.Add(this.ExportGroupExp);
            this.CardPackerExport.Location = new System.Drawing.Point(4, 22);
            this.CardPackerExport.Name = "CardPackerExport";
            this.CardPackerExport.Size = new System.Drawing.Size(744, 482);
            this.CardPackerExport.TabIndex = 2;
            this.CardPackerExport.Text = "Export Cards";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(341, 174);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(52, 23);
            this.ExportButton.TabIndex = 12;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // ExpSaveButton
            // 
            this.ExpSaveButton.Location = new System.Drawing.Point(683, 45);
            this.ExpSaveButton.Name = "ExpSaveButton";
            this.ExpSaveButton.Size = new System.Drawing.Size(49, 23);
            this.ExpSaveButton.TabIndex = 3;
            this.ExpSaveButton.Text = "Save";
            this.ExpSaveButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(467, 45);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(210, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ExpCardIDImp,
            this.ExpCardNameImp});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(467, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(265, 400);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ExpCardIDImp
            // 
            this.ExpCardIDImp.Text = "ID";
            this.ExpCardIDImp.Width = 39;
            // 
            // ExpCardNameImp
            // 
            this.ExpCardNameImp.Text = "Card Name";
            this.ExpCardNameImp.Width = 159;
            // 
            // ExportGroupImp
            // 
            this.ExportGroupImp.Controls.Add(this.newImportButton);
            this.ExportGroupImp.Controls.Add(this.ImportButton);
            this.ExportGroupImp.Controls.Add(this.ExportLabelImp);
            this.ExportGroupImp.Location = new System.Drawing.Point(467, 3);
            this.ExportGroupImp.Name = "ExportGroupImp";
            this.ExportGroupImp.Size = new System.Drawing.Size(265, 36);
            this.ExportGroupImp.TabIndex = 6;
            this.ExportGroupImp.TabStop = false;
            this.ExportGroupImp.Text = "Import";
            // 
            // newImportButton
            // 
            this.newImportButton.Location = new System.Drawing.Point(210, 11);
            this.newImportButton.Name = "newImportButton";
            this.newImportButton.Size = new System.Drawing.Size(49, 23);
            this.newImportButton.TabIndex = 3;
            this.newImportButton.Text = "New";
            this.newImportButton.UseVisualStyleBackColor = true;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(155, 11);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(49, 23);
            this.ImportButton.TabIndex = 1;
            this.ImportButton.Text = "Open";
            this.ImportButton.UseVisualStyleBackColor = true;
            // 
            // ExportLabelImp
            // 
            this.ExportLabelImp.AutoSize = true;
            this.ExportLabelImp.Location = new System.Drawing.Point(6, 16);
            this.ExportLabelImp.Name = "ExportLabelImp";
            this.ExportLabelImp.Size = new System.Drawing.Size(39, 13);
            this.ExportLabelImp.TabIndex = 2;
            this.ExportLabelImp.Text = "File.zip";
            // 
            // ExportListExp
            // 
            this.ExportListExp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CardID,
            this.CardName});
            this.ExportListExp.GridLines = true;
            this.ExportListExp.Location = new System.Drawing.Point(8, 94);
            this.ExportListExp.Name = "ExportListExp";
            this.ExportListExp.Size = new System.Drawing.Size(265, 380);
            this.ExportListExp.TabIndex = 4;
            this.ExportListExp.UseCompatibleStateImageBehavior = false;
            this.ExportListExp.View = System.Windows.Forms.View.Details;
            // 
            // CardID
            // 
            this.CardID.Text = "ID";
            this.CardID.Width = 39;
            // 
            // CardName
            // 
            this.CardName.Text = "Card Name";
            this.CardName.Width = 159;
            // 
            // ExportIDSearch
            // 
            this.ExportIDSearch.Location = new System.Drawing.Point(52, 68);
            this.ExportIDSearch.Name = "ExportIDSearch";
            this.ExportIDSearch.Size = new System.Drawing.Size(221, 20);
            this.ExportIDSearch.TabIndex = 3;
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(25, 71);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(21, 13);
            this.Code.TabIndex = 2;
            this.Code.Text = "ID:";
            // 
            // ExportNameSearch
            // 
            this.ExportNameSearch.Location = new System.Drawing.Point(51, 42);
            this.ExportNameSearch.Name = "ExportNameSearch";
            this.ExportNameSearch.Size = new System.Drawing.Size(222, 20);
            this.ExportNameSearch.TabIndex = 1;
            // 
            // ExportNameLabel
            // 
            this.ExportNameLabel.AutoSize = true;
            this.ExportNameLabel.Location = new System.Drawing.Point(8, 45);
            this.ExportNameLabel.Name = "ExportNameLabel";
            this.ExportNameLabel.Size = new System.Drawing.Size(38, 13);
            this.ExportNameLabel.TabIndex = 0;
            this.ExportNameLabel.Text = "Name:";
            // 
            // ExportGroupExp
            // 
            this.ExportGroupExp.Controls.Add(this.pictureBox1);
            this.ExportGroupExp.Controls.Add(this.label1);
            this.ExportGroupExp.Location = new System.Drawing.Point(8, 3);
            this.ExportGroupExp.Name = "ExportGroupExp";
            this.ExportGroupExp.Size = new System.Drawing.Size(207, 36);
            this.ExportGroupExp.TabIndex = 0;
            this.ExportGroupExp.TabStop = false;
            this.ExportGroupExp.Text = "Export";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(43, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 14);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cardfight Custom";
            // 
            // openFile_Images
            // 
            this.openFile_Images.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // openFile_Card
            // 
            this.openFile_Card.Filter = "CFVG Card (*.crd) | *.crd";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 499);
            this.Controls.Add(this.ManagerTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(762, 538);
            this.MinimumSize = new System.Drawing.Size(762, 538);
            this.Name = "Main";
            this.Text = "Cray Sim Manager";
            this.ManagerTabs.ResumeLayout(false);
            this.CardCreation.ResumeLayout(false);
            this.groupBox_CardText.ResumeLayout(false);
            this.groupBox_CardText.PerformLayout();
            this.groupBox_CardInfo.ResumeLayout(false);
            this.groupBox_CardInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Critical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Shield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Grade)).EndInit();
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.CardPackerExport.ResumeLayout(false);
            this.CardPackerExport.PerformLayout();
            this.ExportGroupImp.ResumeLayout(false);
            this.ExportGroupImp.PerformLayout();
            this.ExportGroupExp.ResumeLayout(false);
            this.ExportGroupExp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ManagerTabs;
        private System.Windows.Forms.TabPage CardCreation;
        private System.Windows.Forms.Button button_MassAdd;
        private System.Windows.Forms.Button button_LoadTemplate;
        private System.Windows.Forms.Button button_OpenCard;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.GroupBox groupBox_CardText;
        private System.Windows.Forms.RichTextBox richTextBox_Abilities;
        private System.Windows.Forms.Label label_Abilities;
        private System.Windows.Forms.RichTextBox richTextBox_Flavour;
        private System.Windows.Forms.Label label_Flavour;
        private System.Windows.Forms.GroupBox groupBox_CardInfo;
        private System.Windows.Forms.ComboBox comboBox_Trigger;
        private System.Windows.Forms.Label label_Trigger;
        private System.Windows.Forms.Label label_Critical;
        private System.Windows.Forms.NumericUpDown numeric_Critical;
        private System.Windows.Forms.CheckBox checkBox_NoShield;
        private System.Windows.Forms.NumericUpDown numeric_Power;
        private System.Windows.Forms.Label label_Shield;
        private System.Windows.Forms.NumericUpDown numeric_Shield;
        private System.Windows.Forms.TextBox textBox_Illust;
        private System.Windows.Forms.Label label_Illustrator;
        private System.Windows.Forms.ComboBox comboBox_Nation;
        private System.Windows.Forms.Label label_Nation;
        private System.Windows.Forms.ComboBox comboBox_Race;
        private System.Windows.Forms.Label label_Race;
        private System.Windows.Forms.ComboBox comboBox_Clan;
        private System.Windows.Forms.Label label_Clan;
        private System.Windows.Forms.Label label_Power;
        private System.Windows.Forms.ComboBox comboBox_SkillIcon;
        private System.Windows.Forms.NumericUpDown numeric_Grade;
        private System.Windows.Forms.Label label_Grade;
        private System.Windows.Forms.ComboBox comboBox_UClass;
        private System.Windows.Forms.Label label_Unit;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_CardID;
        private System.Windows.Forms.Label label_Code;
        private System.Windows.Forms.Label cardIDLabel;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.ListBox listBox_SearchList;
        private System.Windows.Forms.TextBox textBox_SetSearch;
        private System.Windows.Forms.TextBox textBox_NameSearch;
        private System.Windows.Forms.Button button_LoadImage;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.TabPage CardPackerImport;
        private System.Windows.Forms.TabPage CardPackerExport;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ExpSaveButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ExpCardIDImp;
        private System.Windows.Forms.ColumnHeader ExpCardNameImp;
        private System.Windows.Forms.GroupBox ExportGroupImp;
        private System.Windows.Forms.Button newImportButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Label ExportLabelImp;
        private System.Windows.Forms.ListView ExportListExp;
        private System.Windows.Forms.ColumnHeader CardID;
        private System.Windows.Forms.ColumnHeader CardName;
        private System.Windows.Forms.TextBox ExportIDSearch;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.TextBox ExportNameSearch;
        private System.Windows.Forms.Label ExportNameLabel;
        private System.Windows.Forms.GroupBox ExportGroupExp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFile_Images;
        private System.Windows.Forms.OpenFileDialog openFile_Card;
    }
}

