using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cray_Card_Manager
{
    public partial class Main : Form
    {
        //Data
        DataSet allCards;
        Dictionary<string, string> cardDictionary = new Dictionary<string, string>();
        List<KeyValuePair<string, string>> list_Searched = new List<KeyValuePair<string, string>>();

        //Form Variables
        Bitmap currentImage = null;
        bool stopEvent = false;

        //Other
        List<string> Clans = new List<string>();
        List<string> Nation = new List<string>();
        List<string> Races = new List<string>();
        
        public Main(DataSet data)
        {
            InitializeComponent();

            //Load Data Set
            allCards = data;

            foreach (DataTable dt in allCards.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    //Add Card to Dictionary
                    cardDictionary.Add(dr["cardID"].ToString(), dr["name"].ToString());

                    //Get Values for Clans, Nations and Races
                    string clan = dr["clan"].ToString().Trim();
                    string nation = dr["nation"].ToString().Trim();
                    string[] cardRaces = dr["race"].ToString().Trim().Split('/');

                    if (!Clans.Contains(clan)) Clans.Add(clan);
                    if (!Nation.Contains(nation)) Nation.Add(nation);

                    foreach (string race in cardRaces)
                    {
                        if (!Races.Contains(race)) Races.Add(race);
                    }
                }
            }

            //Get Search List
            list_Searched = cardDictionary.ToList();
            list_Searched = list_Searched.OrderBy(keyValue => keyValue.Value).ToList();
            listBox_SearchList.DataSource = list_Searched;

            //Set Clans and Races
            Clans.Sort();
            Races.Sort();
            Nation.Sort();

            comboBox_Clan.DataSource = Clans;
            comboBox_Race.DataSource = Races;
            comboBox_Nation.DataSource = Nation;

            comboBox_Clan.Text = "";
        }

        private void listBox_SearchList_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataTable dt in allCards.Tables)
            {
                DataRow[] drArray = dt.Select("cardID='" + listBox_SearchList.SelectedValue + "'");
                if (drArray.Length == 0) continue;

                //Grab Card
                DataRow dr = drArray[0];
                textBox_CardID.Text = dr["cardID"].ToString();

                //Grab Image
                try
                {
                    Bitmap tempLoad = new Bitmap(@"Images/" + textBox_CardID.Text.Replace('/', '-') + ".jpg");
                    currentImage = new Bitmap(tempLoad);
                    tempLoad.Dispose();

                    pictureBox_Image.Image = currentImage;
                }
                catch
                {
                    currentImage = null;
                    pictureBox_Image.Image = Properties.Resources.Sleeve_Blue;
                }

                stopEvent = true;

                //Load Information
                textBox_Name.Text = dr["name"].ToString();
                comboBox_UClass.Text = dr["uclass"].ToString();
                comboBox_Trigger.Text = dr["trigger"].ToString();
                numeric_Grade.Value = Convert.ToInt32(dr["grade"]);
                comboBox_SkillIcon.Text = dr["skillicon"].ToString();
                numeric_Power.Value = Convert.ToInt32(dr["power"]);

                try
                {
                    numeric_Shield.Value = Convert.ToInt32(dr["shield"]);
                    checkBox_NoShield.Checked = false;
                }
                catch
                {
                    checkBox_NoShield.Checked = true;
                    numeric_Shield.Value = 0;
                }

                numeric_Critical.Value = Convert.ToInt32(dr["critical"]);
                comboBox_Clan.Text = dr["clan"].ToString();
                comboBox_Race.Text = dr["race"].ToString();
                comboBox_Nation.Text = dr["nation"].ToString();
                textBox_Illust.Text = dr["illustrator"].ToString();


                richTextBox_Abilities.Text = dr["effect"].ToString();
                richTextBox_Flavour.Text = dr["flavour"].ToString();

                stopEvent = false;
                //Stop Looping
                break;
            }
        }

        private void textBox_Search_GotFocus(object sender, EventArgs e)
        {
            //Get Original Sender
            TextBox origSender = sender as TextBox;
            if (origSender == null) return;

            //Change Values
            if (origSender.ForeColor == Color.Gray)
            {
                origSender.Text = "";
                origSender.ForeColor = Color.Black;
            }
        }

        private void textbox_NameSearch_LostFocus(object sender, EventArgs e)
        {
            //Change Values
            if (textBox_NameSearch.Text == "")
            {
                textBox_NameSearch.ForeColor = Color.Gray;
                textBox_NameSearch.Text = "Name";
            }
        }

        private void textbox_SetSearch_LostFocus(object sender, EventArgs e)
        {
            //Change Values
            if (textBox_SetSearch.Text == "")
            {
                textBox_SetSearch.ForeColor = Color.Gray;
                textBox_SetSearch.Text = "Set";
            }
        }

        private void textbox_Search_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_SetSearch.ForeColor == Color.Gray && textBox_NameSearch.ForeColor == Color.Gray) || 
                (textBox_NameSearch.Text == "" && textBox_SetSearch.Text == ""))
            {
                if (list_Searched.Count == cardDictionary.Count) return;
                //Return all Cards
                list_Searched = cardDictionary.OrderBy(keyValue => keyValue.Value).ToList();
                listBox_SearchList.DataSource = list_Searched;
                return;
            }

            list_Searched.Clear();
            foreach (KeyValuePair<string, string> keyValue in cardDictionary)
            {
                //Add Card to List
                if ((keyValue.Key.ToUpper().Contains(textBox_SetSearch.Text.ToUpper()) || textBox_SetSearch.ForeColor == Color.Gray)
                    && (keyValue.Value.ToUpper().Contains(textBox_NameSearch.Text.ToUpper()) || textBox_NameSearch.ForeColor == Color.Gray))
                    list_Searched.Add(keyValue);
            }

            //Load DataSource
            list_Searched = list_Searched.OrderBy(keyValue => keyValue.Value).ToList();
            listBox_SearchList.DataSource = list_Searched.ToList();
        }

        private void comboBox_UClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_UClass.SelectedIndex != 1)
            {
                comboBox_Trigger.Text = "";
                comboBox_Trigger.Enabled = false;
            }
            else comboBox_Trigger.Enabled = true;
        }

        private void numeric_Grade_ValueChanged(object sender, EventArgs e)
        {
            if (!stopEvent)
            {
                switch ((int) numeric_Grade.Value)
                {
                    case 0:
                        comboBox_SkillIcon.Text = "Boost";
                        if (comboBox_UClass.Text == "Trigger Unit") numeric_Power.Value = 4000;
                        else numeric_Power.Value = 5000;
                        checkBox_NoShield.Checked = false;
                        numeric_Shield.Value = 10000;
                        break;
                    case 1:
                        comboBox_SkillIcon.Text = "Boost";
                        numeric_Power.Value = 7000;
                        checkBox_NoShield.Checked = false;
                        numeric_Shield.Value = 5000;
                        break;
                    case 2:
                        comboBox_SkillIcon.Text = "Intercept";
                        numeric_Power.Value = 9000;
                        checkBox_NoShield.Checked = false;
                        numeric_Shield.Value = 5000;
                        break;
                    case 3:
                        comboBox_SkillIcon.Text = "Twin Drive";
                        numeric_Power.Value = 11000;
                        checkBox_NoShield.Checked = true;
                        break;
                    case 4:
                        if (comboBox_UClass.Text == "G Unit")
                        {
                            comboBox_SkillIcon.Text = "Triple Drive";
                            numeric_Power.Value = 15000;
                        }
                        else
                        {
                            comboBox_SkillIcon.Text = "Twin Drive";
                            numeric_Power.Value = 13000;
                        }
                        checkBox_NoShield.Checked = true;
                        break;
                    case 5:
                        comboBox_SkillIcon.Text = "Triple Drive";
                        numeric_Power.Value = 15000;
                        checkBox_NoShield.Checked = true;
                        break;
                }
            }
        }

        private void numeric_Power_ValueChanged(object sender, EventArgs e)
        {
            if (!stopEvent && comboBox_UClass.Text == "G Unit" && numeric_Power.Value == 0)
            {
                numeric_Shield.Value = 15000;
                checkBox_NoShield.Checked = false;
                comboBox_SkillIcon.Text = "";
            }
        }

        private void checkBox_NoShield_CheckedChanged(object sender, EventArgs e)
        {
            numeric_Shield.Enabled = !checkBox_NoShield.Checked;
        }

        private void comboBox_Clan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!stopEvent)
            {
                switch (comboBox_Clan.Text)
                {
                    case "Royal Paladin":
                    case "Angel Feather":
                    case "Shadow Paladin":
                    case "Genesis":
                    case "Oracle Think Tank":
                    case "Gold Paladin":
                        comboBox_Nation.Text = "United Sanctuary";
                        break;
                    case "Narukami":
                    case "Kagerō":
                    case "Nubatama":
                    case "Murakumo":
                    case "Tachikaze":
                        comboBox_Nation.Text = "Dragon Empire";
                        break;
                    case "Bermuda Triangle":
                    case "Granblue":
                    case "Aqua Force":
                    case "Ocean Route":
                        comboBox_Nation.Text = "Magallanica";
                        break;
                    case "Neo Nectar":
                    case "Megacolony":
                    case "Great Nature":
                        comboBox_Nation.Text = "Zoo";
                        break;
                    case "Nova Grappler":
                    case "Link Joker":
                    case "Etranger":
                    case "Dimension Police":
                        comboBox_Nation.Text = "Star Gate";
                        break;
                    case "Dark Irregulars":
                    case "Pale Moon":
                    case "Spike Brothers":
                    case "Gear Chronicle":
                    case "Empty Heart":
                        comboBox_Nation.Text = "Dark Zone";
                        break;
                    case "Soaring Eye":
                        comboBox_Nation.Text = "Aether";
                        break;
                    case "Raidech":
                        comboBox_Nation.Text = "Riot City";
                        break;
                    case "Cray Elemental":
                        comboBox_Nation.Text = "";
                        break;
                }
            }
        }

        private void comboBox_Clan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!stopEvent)
            {
                //Get Sender
                ComboBox origSender = sender as ComboBox;
                if (origSender == null || ModifierKeys.HasFlag(Keys.Control)
                    || (char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Enter)) return;
                else if (e.KeyChar == (char)Keys.Enter)
                {
                    origSender.Select(origSender.Text.Length, 0);
                }

                stopEvent = true;

                //AutoFill
                origSender.SelectedText = e.KeyChar + "";
                string initialText = origSender.Text;
                int index = 0;
                foreach (string item in origSender.Items)
                {
                    if (item.StartsWith(initialText, StringComparison.OrdinalIgnoreCase))
                    {
                        //Set New Value
                        stopEvent = false;
                        origSender.SelectedIndex = index;
                        origSender.Select(initialText.Length, item.Length - initialText.Length);
                        break;
                    }
                    index++;
                }

                //Handled
                e.Handled = true;
                stopEvent = false;
            }
        }

        private void comboBox_Race_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!stopEvent)
            {
                //Get Sender
                ComboBox origSender = sender as ComboBox;
                if (origSender == null || ModifierKeys.HasFlag(Keys.Control)
                    || (char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Enter)) return;
                else if (e.KeyChar == (char)Keys.Enter)
                {
                    origSender.Select(origSender.Text.Length, 0);
                }

                stopEvent = true;

                //AutoFill
                origSender.SelectedText = e.KeyChar + "";
                string initialText = origSender.Text.Split('/').Last();
                int beginIndex = origSender.Text.LastIndexOf('/') < 0 ? 0 : origSender.Text.LastIndexOf('/') + 1;
                string allText = origSender.Text.Substring(0, beginIndex);
                //Iterate Through Items
                int index = 0;
                foreach (string item in origSender.Items)
                {
                    if (item.StartsWith(initialText, StringComparison.OrdinalIgnoreCase))
                    {
                        //Set New Text
                        stopEvent = false;
                        origSender.Text = allText + item;
                        origSender.Select(beginIndex + initialText.Length, item.Length - initialText.Length);
                        break;
                    }
                    index++;
                }

                //Handled
                e.Handled = true;
                stopEvent = false;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //Save To DataBase
            using (SQLiteConnection cnn = new SQLiteConnection("datasource=" + Program.sqliteDBFile))
            {
                try
                {
                    SQLiteCommand cmd;
                    string cmdstring;

                    string tableName = "Custom";

                    //Get Table
                    foreach (DataTable dataTable in allCards.Tables)
                    {
                        //Get Array
                        DataRow[] drArray = dataTable.Select("cardID='" + textBox_CardID.Text + "'");

                        tableName = dataTable.TableName;

                        if (drArray.Length == 0) continue;

                        //Save Information
                        DataRow dr = drArray[0];
                        DialogResult dialog = DialogResult.No;

                        //Overwrite
                        if (dr["name"].ToString() != textBox_Name.Text)
                        {
                            dialog = MessageBox.Show("Do you want to overwrite " + dr["name"] + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (dialog != DialogResult.Yes) return;
                        }

                        if (dialog == DialogResult.Yes) dataTable.Rows.Remove(dr);

                        //Set Up Command
                        cmd = new SQLiteCommand("select * from Main", cnn);
                        cmdstring = @"UPDATE " + tableName + " SET name='CARDNAME', uclass='UNITTYPE', trigger='TRIGGERTYPE', grade='GRADEVALUE',skillicon='SKILLICONVALUE', power='POWERVALUE',"
                            + "critical='CRITICALVAL', shield='SHIELDVALUE', clan='CLANVALUE', race='RACEVALUE', effect='ABILITIES', flavour='FLAVOURTEXT', nation='NATIONVALUE', illustrator='ILLUSTRATORNAME' WHERE cardID='CARDIDVAL'";
                        cmdstring = ReplaceCommandString(cmdstring);

                        Console.WriteLine(cmdstring);
                        cmd.CommandText = cmdstring;
                        cnn.Open();

                        int updateI = cmd.ExecuteNonQuery();
                        if (updateI == 1)
                        {
                            //Update DataRow
                            UpdateDataRow(dr);
                            if (dialog == DialogResult.Yes)
                            {
                                dataTable.Rows.Add(dr);

                                //Set Up Lists
                                if (!Clans.Contains(comboBox_Clan.Text))
                                {
                                    Clans.Add(comboBox_Clan.Text);
                                    comboBox_Clan.DataSource = null;
                                    comboBox_Clan.DataSource = Clans;
                                }

                                if (!Nation.Contains(comboBox_Nation.Text))
                                {
                                    Nation.Add(comboBox_Nation.Text);
                                    comboBox_Nation.DataSource = null;
                                    comboBox_Nation.DataSource = Nation;
                                }

                                foreach (string str in comboBox_Race.Text.Split('/'))
                                {
                                    if (!Races.Contains(str))
                                    {
                                        Races.Add(str);
                                        comboBox_Race.DataSource = null;
                                        comboBox_Race.DataSource = Races;
                                    }
                                }

                                cardDictionary[textBox_CardID.Text] = textBox_Name.Text;

                                textbox_Search_TextChanged(sender, e);
                            }

                            //Save Image
                            if (currentImage != null)
                            {
                                Bitmap saveBmp = new Bitmap(165, 242);
                                Graphics g = Graphics.FromImage(saveBmp);

                                //Set Quality
                                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                                //Resize Image
                                Rectangle destRect = new Rectangle(0, 0, 165, 242);
                                g.DrawImage(currentImage, destRect);
                                //Dispose Image
                                g.Dispose();

                                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                                myEncoderParameters.Param[0] = myEncoderParameter;
                                string filename = @".\Images\" + textBox_CardID.Text.Replace('/', '-') + ".jpg";
                                if (System.IO.File.Exists(filename)) System.IO.File.Delete(filename);
                                saveBmp.Save(filename, jpgEncoder, myEncoderParameters);
                                saveBmp.Dispose();
                            }

                            MessageBox.Show(textBox_Name.Text + " was saved to the database!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        //Return to Form
                        return;
                    }

                    tableName = "Custom";

                    //Custom or Main
                    DialogResult result = MessageBox.Show("Do you want to save it to the Custom?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Cancel) return;
                    else if (result == DialogResult.No) tableName = "Main";

                    //Set Up Commands
                    cmd = new SQLiteCommand("select * from " + tableName, cnn);
                    cmdstring = @"INSERT INTO " + tableName + " (cardID, name, uclass, trigger, grade, skillicon, power, critical, shield, clan, race, effect, flavour, nation, illustrator)" +
                        "VALUES ('CARDIDVAL', 'CARDNAME', 'UNITTYPE', 'TRIGGERTYPE', 'GRADEVALUE', 'SKILLICONVALUE', 'POWERVALUE', 'CRITICALVAL' ,'SHIELDVALUE', 'CLANVALUE', 'RACEVALUE', 'ABILITIES', 'FLAVOURTEXT', 'NATIONVALUE', 'ILLUSTRATORNAME')";
                    cmdstring = ReplaceCommandString(cmdstring);

                    Console.WriteLine(cmdstring);
                    cmd.CommandText = cmdstring;

                    //Open Connection
                    cnn.Open();

                    //Execute Command
                    int insertI = cmd.ExecuteNonQuery();
                    if (insertI == 1)
                    {
                        //Add DataRow
                        DataRow dr = allCards.Tables[tableName].NewRow();
                        UpdateDataRow(dr);
                        allCards.Tables[tableName].Rows.Add(dr);

                        //Set Up Lists
                        if (!Clans.Contains(comboBox_Clan.Text))
                        {
                            Clans.Add(comboBox_Clan.Text);
                            comboBox_Clan.DataSource = null;
                            comboBox_Clan.DataSource = Clans;
                        }

                        if (!Nation.Contains(comboBox_Nation.Text))
                        {
                            Nation.Add(comboBox_Nation.Text);
                            comboBox_Nation.DataSource = null;
                            comboBox_Nation.DataSource = Nation;
                        }

                        foreach (string str in comboBox_Race.Text.Split('/'))
                        {
                            if (!Races.Contains(str))
                            {
                                Races.Add(str);
                                comboBox_Race.DataSource = null;
                                comboBox_Race.DataSource = Races;
                            }
                        }

                        cardDictionary.Add(textBox_CardID.Text, textBox_Name.Text);

                        textbox_Search_TextChanged(sender, e);

                        //Save Image
                        if (currentImage != null)
                        {
                            Bitmap saveBmp = new Bitmap(165, 242);
                            Graphics g = Graphics.FromImage(saveBmp);

                            //Set Quality
                            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                            //Resize Image
                            Rectangle destRect = new Rectangle(0, 0, 165, 242);
                            g.DrawImage(currentImage, destRect);
                            //Dispose Image
                            g.Dispose();

                            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                            EncoderParameters myEncoderParameters = new EncoderParameters(1);

                            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                            myEncoderParameters.Param[0] = myEncoderParameter;
                            string filename = @".\Images\" + textBox_CardID.Text.Replace('/', '-') + ".jpg";
                            if (System.IO.File.Exists(filename)) System.IO.File.Delete(filename);
                            saveBmp.Save(filename, jpgEncoder, myEncoderParameters);
                            saveBmp.Dispose();
                        }

                        MessageBox.Show(textBox_Name.Text + " was saved to the database!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DataRow UpdateDataRow(DataRow dr)
        {
            dr["cardID"] = textBox_CardID.Text;
            dr["name"] = textBox_Name.Text;
            dr["uclass"] = comboBox_UClass.Text;
            dr["trigger"] = comboBox_Trigger.Text;
            dr["grade"] = numeric_Grade.Value;
            dr["skillicon"] = comboBox_SkillIcon.Text;
            dr["power"] = numeric_Power.Value;
            dr["critical"] = numeric_Critical.Value;
            if (!checkBox_NoShield.Checked) dr["shield"] = numeric_Shield.Value;
            else dr["shield"] = "";
            dr["clan"] = comboBox_Clan.Text;
            dr["race"] = comboBox_Race.Text;
            dr["effect"] = richTextBox_Abilities.Text;
            dr["flavour"] = richTextBox_Flavour.Text;
            dr["nation"] = comboBox_Nation.Text;
            dr["illustrator"] = textBox_Illust.Text;
            return dr;
        }

        public string ReplaceCommandString(string s)
        {
            s = s.Replace("CARDIDVAL", textBox_CardID.Text.Replace("'", "''"));
            s = s.Replace("CARDNAME", textBox_Name.Text.Replace("'", "''"));
            s = s.Replace("UNITTYPE", comboBox_UClass.Text.Replace("'", "''"));
            s = s.Replace("TRIGGERTYPE", comboBox_Trigger.Text.Replace("'", "''"));
            s = s.Replace("GRADEVALUE", numeric_Grade.Value.ToString());
            s = s.Replace("SKILLICONVALUE", comboBox_SkillIcon.Text.Replace("'", "''"));
            s = s.Replace("POWERVALUE", numeric_Power.Value.ToString());
            s = s.Replace("CRITICALVAL", numeric_Critical.Value.ToString());
            if (!checkBox_NoShield.Checked) s = s.Replace("SHIELDVALUE", numeric_Shield.Value.ToString());
            else s = s.Replace("SHIELDVALUE", "");
            s = s.Replace("CLANVALUE", comboBox_Clan.Text.Replace("'", "''"));
            s = s.Replace("RACEVALUE", comboBox_Race.Text.Replace("'", "''"));
            s = s.Replace("ABILITIES", richTextBox_Abilities.Text.Replace("'", "''"));
            s = s.Replace("FLAVOURTEXT", richTextBox_Flavour.Text.Replace("'", "''"));
            s = s.Replace("NATIONVALUE", comboBox_Nation.Text.Replace("'", "''"));
            s = s.Replace("ILLUSTRATORNAME", textBox_Illust.Text.Replace("'", "''"));

            s = s.Replace(Environment.NewLine, "\n");

            return s;
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void button_LoadImage_Click(object sender, EventArgs e)
        {
            if (openFile_Images.ShowDialog(this) == DialogResult.OK)
            {
                //Load Image from File
                Bitmap tmpBitmap = new Bitmap(openFile_Images.FileName);
                currentImage = new Bitmap(tmpBitmap);
                pictureBox_Image.Image = currentImage;
                tmpBitmap.Dispose();
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            //Prevent Events
            stopEvent = true;

            currentImage = null;
            pictureBox_Image.Image = Properties.Resources.Sleeve_Blue;

            textBox_CardID.Text = "";
            textBox_Name.Text = "";
            comboBox_UClass.Text = "Normal Unit";
            comboBox_Trigger.Text = "";
            comboBox_Trigger.Enabled = false;
            numeric_Grade.Value = 0;
            comboBox_SkillIcon.Text = "Boost";
            numeric_Power.Value = 5000;
            numeric_Shield.Value = 10000;
            checkBox_NoShield.Checked = false;

            numeric_Critical.Value = 1;
            comboBox_Clan.Text = "";
            comboBox_Race.Text = "";
            comboBox_Nation.Text = "";
            textBox_Illust.Text = "";


            richTextBox_Abilities.Text = "";
            richTextBox_Flavour.Text = "";

            stopEvent = false;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete " + textBox_Name.Text + "?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

            using (SQLiteConnection cnn = new SQLiteConnection("datasource=" + Program.sqliteDBFile))
            {
                try
                {
                    foreach (DataTable dataTable in allCards.Tables)
                    {
                        DataRow[] drArray = dataTable.Select("cardID='" + textBox_CardID.Text + "'");
                        if (drArray.Length == 0) continue;

                        //Initialize Command
                        SQLiteCommand cmd = new SQLiteCommand("Select * FROM " + dataTable.TableName, cnn);
                        string cmdstring = "DELETE FROM " + dataTable.TableName + " WHERE cardID='" + textBox_CardID.Text + "'";
                        cmd.CommandText = cmdstring;
                        cnn.Open();

                        //Execute Command
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            //Command Successful
                            foreach (DataRow dr in drArray)
                            {
                                dataTable.Rows.Remove(dr);
                                cardDictionary.Remove(textBox_CardID.Text);
                            }

                            //Re-Initiate Search
                            textbox_Search_TextChanged(sender, e);

                            string imageName = @"Images\" + textBox_CardID.Text.Replace('/', '-') + ".jpg";
                            if (File.Exists(imageName)) File.Delete(imageName);

                            button_Clear_Click(sender, e);
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (cnn!= null) cnn.Close();
                }
            }

        }

        private void button_OpenCard_Click(object sender, EventArgs e)
        {
            if (openFile_Card.ShowDialog(this) == DialogResult.OK)
            {
                button_Clear_Click(sender, e);
                using (StreamReader reader = new StreamReader(openFile_Card.FileName))
                {
                    //Text File into String
                    string textFile = reader.ReadToEnd();

                    stopEvent = true;

                    //Each '|' represents a new parameter
                    string[] parameters = textFile.Split('|');
                    foreach (string parameter in parameters)
                    {
                        //'=' is the seperator between the key and value
                        string[] values = parameter.Split('=');
                        //Load based on Key
                        switch (values[0])
                        {
                            case "Code":
                                textBox_CardID.Text = values[1];
                                break;
                            case "Name":
                                textBox_Name.Text = values[1];
                                break;
                            case "Border":
                                switch (values[1])
                                {
                                    case "Normal":
                                        comboBox_UClass.SelectedIndex = 0;
                                        break;
                                    case "Trigger":
                                        comboBox_UClass.SelectedIndex = 1;
                                        break;
                                    case "Stride":
                                        checkBox_NoShield.Checked = true;
                                        comboBox_UClass.SelectedIndex = 2;
                                        break;
                                    case "G-Guardian":
                                        checkBox_NoShield.Checked = false;
                                        comboBox_UClass.SelectedIndex = 2;
                                        numeric_Power.Value = 0;
                                        break;
                                }
                                stopEvent = false;
                                comboBox_UClass_SelectedIndexChanged(comboBox_UClass, e);
                                stopEvent = true;
                                break;
                            case "Trigger":
                                switch (values[1])
                                {
                                    case "Critical Trigger":
                                        comboBox_Trigger.Text = "Critical";
                                        break;
                                    case "Stand Trigger":
                                        comboBox_Trigger.Text = "Stand";
                                        break;
                                    case "Draw Trigger":
                                        comboBox_Trigger.Text = "Draw";
                                        break;
                                    case "Heal Trigger":
                                        comboBox_Trigger.Text = "Heal";
                                        break;
                                }
                                break;
                            case "Grade":
                                //Convert to Decimal
                                numeric_Grade.Value = decimal.Parse(values[1]);
                                break;
                            case "Power":
                                //Convert to Decimal
                                numeric_Power.Value = decimal.Parse(values[1]);
                                break;
                            case "Shield":
                                numeric_Shield.Text = values[1];
                                break;
                            case "Clan":
                                comboBox_Clan.Text = values[1];
                                break;
                            case "Nation":
                                comboBox_Nation.Text = values[1];
                                break;
                            case "Race":
                                comboBox_Race.Text = values[1];
                                break;
                            case "Illust":
                                textBox_Illust.Text = values[1];
                                break;
                            case "Design":
                                textBox_Illust.Text += (values[1] == "" ? "" : "/" + values[1]);
                                break;
                            case "Flavour":
                                //Load complete flavour into textbox
                                richTextBox_Flavour.Text = values[1];
                                break;
                        }
                    }

                    stopEvent = false;
                    //End Reading
                    reader.Close();
                }
            }
        }

        private void button_LoadTemplate_Click(object sender, EventArgs e)
        {
            string input = "";
            stopEvent = true;

            //Load Input
            if (InputBox.Show("Copy+Paste", "Copy+Paste the Information here", ref input) == DialogResult.OK && input != "")
            {
                //Set Defaults
                button_Clear_Click(sender, e);
                checkBox_NoShield.Checked = true;
                numeric_Shield.Value = 0;
                numeric_Power.Value = 0;

                //Get Parameters
                string[] parameters = input.Remove(input.Length - 2, 2).Split('|');
                foreach (string parameter in parameters)
                {
                    string[] values = parameter.Split('=');
                    switch (values[0].Trim())
                    {
                        case "set1":
                            textBox_CardID.Text = values[1].Split(new string[] { "<br>", "<br/>", " " }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                            break;
                        case "name":
                            textBox_Name.Text = values[1].Trim();
                            break;
                        case "unittype":
                            comboBox_UClass.Text = values[1].Trim() + " Unit";
                            break;
                        case "style":
                            switch (values[1].Trim())
                            {
                                case "gunit":
                                    comboBox_UClass.Text = "G Unit";
                                    break;
                                default:
                                    comboBox_UClass.Text = "Normal Unit";
                                    break;
                            }
                            break;
                        case "trig":
                            comboBox_UClass.Text = "Trigger Unit";
                            switch (values[1].Trim())
                            {
                                case "Draw":
                                    comboBox_Trigger.Text = "+5000 Power, Draw 1";
                                    break;
                                case "Critical":
                                    comboBox_Trigger.Text = "+5000 Power, +1 Critical";
                                    break;
                                case "Stand":
                                    comboBox_Trigger.Text = "+5000, Stand";
                                    break;
                                case "Heal":
                                    comboBox_Trigger.Text = "+5000 Power, Heal";
                                    break;
                                case "G":
                                    comboBox_UClass.Text = "G Unit";
                                    break;
                            }
                            break;
                        case "illust":
                            textBox_Illust.Text = values[1].Trim();
                            break;
                        case "Design":
                            textBox_Illust.Text += "/" + values[1].Trim();
                            break;
                        case "grade":
                            numeric_Grade.Value = int.Parse(values[1].Trim());
                            break;
                        case "power":
                            numeric_Power.Value = int.Parse(values[1].Replace("+", "").Trim());
                            break;
                        case "shield":
                            numeric_Shield.Value = int.Parse(values[1].Replace("+", "").Trim());
                            break;
                        case "clan":
                            comboBox_Clan.SelectedIndex = 0;
                            comboBox_Clan.Text = values[1].Trim();
                            stopEvent = false;
                            comboBox_Clan_SelectedIndexChanged(sender, e);
                            stopEvent = true;
                            break;
                        case "race":
                            comboBox_Race.Text = values[1].Trim();
                            break;
                        case "flavor":
                            richTextBox_Flavour.Text = values[1].Replace("<br>", Environment.NewLine).Replace("<br/>", Environment.NewLine).Trim();
                            break;
                        case "effect":
                            values[1] = values[1].Replace("[[", "").Replace("]]", "");
                            string[] lines = values[1].Split(new string[] { "<br>", "<br/>" }, StringSplitOptions.RemoveEmptyEntries);
                            richTextBox_Abilities.Text = "";
                            foreach (string line in lines)
                            {
                                richTextBox_Abilities.Text += line.Trim() + Environment.NewLine;
                            }
                            break;
                    }
                }
            }

            //Finish
            stopEvent = false;
        }
    }
}
