
namespace PS4Shenanigans
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
            this.cntbtn = new System.Windows.Forms.Button();
            this.ipaddrinput = new System.Windows.Forms.TextBox();
            this.disconnectbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyicons = new System.Windows.Forms.ComboBox();
            this.printsendbtn = new System.Windows.Forms.Button();
            this.printinput = new System.Windows.Forms.TextBox();
            this.rebootbtn = new System.Windows.Forms.Button();
            this.notifybtn = new System.Windows.Forms.Button();
            this.notifyinput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cntstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.payloadpath = new System.Windows.Forms.TextBox();
            this.loadpayload = new System.Windows.Forms.Button();
            this.ipaddrinputpl = new System.Windows.Forms.TextBox();
            this.portinput = new System.Windows.Forms.TextBox();
            this.sendpayload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.injectbtn = new System.Windows.Forms.Button();
            this.elfpath = new System.Windows.Forms.TextBox();
            this.elfloadbtn = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.processlist = new System.Windows.Forms.ComboBox();
            this.plist = new System.Windows.Forms.Label();
            this.prokill = new System.Windows.Forms.Button();
            this.proresume = new System.Windows.Forms.Button();
            this.prostop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntbtn
            // 
            this.cntbtn.Location = new System.Drawing.Point(18, 61);
            this.cntbtn.Name = "cntbtn";
            this.cntbtn.Size = new System.Drawing.Size(75, 23);
            this.cntbtn.TabIndex = 0;
            this.cntbtn.Text = "Connect";
            this.cntbtn.UseVisualStyleBackColor = true;
            this.cntbtn.Click += new System.EventHandler(this.cntbtn_Click);
            // 
            // ipaddrinput
            // 
            this.ipaddrinput.Location = new System.Drawing.Point(18, 35);
            this.ipaddrinput.Name = "ipaddrinput";
            this.ipaddrinput.Size = new System.Drawing.Size(159, 20);
            this.ipaddrinput.TabIndex = 1;
            this.ipaddrinput.Text = "192.168.0.52";
            // 
            // disconnectbtn
            // 
            this.disconnectbtn.Location = new System.Drawing.Point(99, 61);
            this.disconnectbtn.Name = "disconnectbtn";
            this.disconnectbtn.Size = new System.Drawing.Size(78, 23);
            this.disconnectbtn.TabIndex = 3;
            this.disconnectbtn.Text = "Disconnect";
            this.disconnectbtn.UseVisualStyleBackColor = true;
            this.disconnectbtn.Click += new System.EventHandler(this.disconnectbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.plist);
            this.groupBox1.Controls.Add(this.processlist);
            this.groupBox1.Controls.Add(this.ipaddrinput);
            this.groupBox1.Controls.Add(this.disconnectbtn);
            this.groupBox1.Controls.Add(this.cntbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prostop);
            this.groupBox2.Controls.Add(this.proresume);
            this.groupBox2.Controls.Add(this.prokill);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.notifyicons);
            this.groupBox2.Controls.Add(this.printsendbtn);
            this.groupBox2.Controls.Add(this.printinput);
            this.groupBox2.Controls.Add(this.rebootbtn);
            this.groupBox2.Controls.Add(this.notifybtn);
            this.groupBox2.Controls.Add(this.notifyinput);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 194);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Console";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Print to output (UART or Telnet with Mira)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Notify";
            // 
            // notifyicons
            // 
            this.notifyicons.FormattingEnabled = true;
            this.notifyicons.Items.AddRange(new object[] {
            "0: -Blank-",
            "1: Unknown USB device connected.",
            "2: Too many USB hubs connected.",
            "3: Connect this device using a USB cable, or connect it again.",
            "4: %s battery level low.",
            "5: %s disconnected.",
            "6: Too many USB devices connected.",
            "7: Cannot connect another Bluetooth device.",
            "8: -Blank-",
            "9: Cannot connect another controller.",
            "10: Cannot connect another mouse or keyboard.",
            "11: Cannot use controller feature of keyboard.",
            "12: Device not supported.",
            "13: Cannot use wireless controllers for PS3.",
            "14: %s connected their companion app.",
            "15: %s disconnected their companion app.",
            "16: %s connected using Remote Play.",
            "17: %s disconnected from Remote Play.",
            "18: %s cannot see the screen due to Remote Play blocked scene.",
            "19: %s can see the screen again because Remote Play blocked scene ended.",
            "20: -Blank-",
            "21: -Blank-",
            "22: Less than %s free in system storage.",
            "23: LAN cable not connected.",
            "24: Wi-Fi network connection lost.",
            "25: Cannot connect to network.",
            "26: %s logged in to PS4.",
            "27: -Blank-",
            "28: Your account is banned from PlayStation Network.",
            "29: PlayStation Network access from this PS4 banned or temporarily suspended.",
            "30: Update the system software.",
            "31: PlayStation Network is currently busy.",
            "32: PlayStation Network is currently undergoing maintenance.",
            "33: PlayStation Network is no longer available.",
            "34: -Blank-",
            "35: Sign in to PSN to use network features.",
            "36: Signed out of PSN.",
            "37: Update application to use network features.",
            "38: Update system software to use network features.",
            "39: PlayStation Network features in this application unavailable due to age restr" +
                "ictions.",
            "40: Application will expire in %s minutes.",
            "41: Application suspending in %s minutes because license cannot be verified.",
            "42: Party chat audio prioritized.",
            "43: Game chat audio prioritized.",
            "44: -Blank-",
            "45: Cannot use voice chat with %s, possibly due to NAT type.",
            "46: Kicked out of party.",
            "47: No longer in party due to network error.",
            "48: Cannot take screenshot now.",
            "49: This is a blocked scene for gameplay recording.",
            "50: Cannot display menu now.",
            "51: Only microphone audio is being broadcast.",
            "52: -Blank-",
            "53: Broadcast stopped.",
            "54: Song playback stopped.",
            "55: -Blank-",
            "56: The PS4 automatically turned off due to power save settings.",
            "57: Only 4 users can be logged in at the same time.",
            "58: Deleted because you already have %s Bluetooth devices registered.",
            "59: Message sent.",
            "60: To switch to your screen, press the PS button.",
            "61: Gameplay recording paused because you entered blocked scene.",
            "62: Gameplay recording resumed because you exited blocked scene.",
            "63: -Snapshot Icon-",
            "64: -Recording Icon-",
            "65: -Blank-",
            "66: Chat audio switched to game.",
            "67: Chat audio switched to party.",
            "68: -Blank-",
            "69: Chat audio also muted for players on same PS4 as %s.",
            "70: -Blank-",
            "71: Cannot connect to server, so network features for this application unavailabl" +
                "e.",
            "72: -Blank-",
            "73: Confirming your licenses for using content on this PS4.",
            "74: This ad will end soon.",
            "75: %s disconnected. Charge the battery.",
            "76: -Blank-",
            "77: %s disconnected. Charge the battery.",
            "78: Gameplay is currently not being recorded.",
            "79: %s joined the party. (Players: )",
            "80: %s left the party. (Players: )",
            "81: You are now party owner.",
            "82: Broadcast paused.",
            "83: Video clip saved.",
            "84: Microphone not connected.",
            "85: Both microphone audio and gameplay are being broadcast.",
            "86: Broadcast ends in %s minutes.",
            "87: Broadcasting only microphone audio because you entered a blocked scene.",
            "88: Broadcast paused because you entered a blocked scene.",
            "89: Broadcasting gameplay and microphone audio because you exited a blocked scene" +
                ".",
            "90: Game closing in %s minutes due to inactivity.",
            "91: Game closed due to inactivity.",
            "92: -Blank-",
            "93: Game closing in %s minutes because time limit will be reached.",
            "94: Server maintenance starts in %s hours.",
            "95: -Blank-",
            "96: -Blank-",
            "97: Game closing soon because server maintenance starts in %s minutes.",
            "98: Screenshot saved.",
            "99: Network features for this application temporarily unavailable.",
            "100: Game closed due to insufficient internet connection quality.",
            "101: Cannot start game.",
            "102: Game closed because PS Now game was started on another device.",
            "103: Game closed because connection to server was lost.",
            "104: Game closed because time limit was reached.",
            "105: Game closed due to server maintenance.",
            "106: %s suggested players to invite to your party.",
            "107: Cannot connect another audio device.",
            "108: Broadcast started, and will end in %s.",
            "109: Microphone for PS camera muted, so players in party cannot hear you.",
            "110: The BD remote control is not supported by the PS4.",
            "111: Broadcast resumed.",
            "112: Broadcasting resumed because you exited blocked scene.",
            "113: Game closing in 1 minute due to inactivity.",
            "114: Insufficient free space to record your gameplay.",
            "115: Server maintenance starts in %s minutes.",
            "116: -Blank-",
            "117: PS Now game closing due to insufficient internet connection.",
            "118: Use the controller that was just connected.",
            "119: Gameplay recording is temporarily paused.",
            "120: You cannot control the system now.",
            "121: Cannot operate PS4 with voice now.",
            "122: This USB device\'s file system is unsupported.",
            "123: Feature unavailable for visitors.",
            "124: Cannot connect another USB device.",
            "125: -Blank-",
            "126: Cannot find face.",
            "127: Cannot find face because PS Camera is already in use.",
            "128: Share Play started as host.",
            "129: %s is connecting to your PS4 to join Share Play.",
            "130: Visitor cannot see game screen when you view non-game screens.",
            "131: You joined share play with %s (host).",
            "132: Visitor cannot see game screen due to blocked scene.",
            "133: Visitor can see game screen again.",
            "134: Cannot control Share Play game now.",
            "135: Visitor cannot control game due to restricted scene.",
            "136: Visitor can control game again.",
            "137: Share Play stops in %s minutes.",
            "138: Share Play will stop in 1 minute.",
            "139: Visitor cannot use selected feature.",
            "140: Controller given to visitor.",
            "141: -Blank-",
            "142: You can now play as host.",
            "143: You can now play together with host.",
            "144: Controller taken back by %s (host).",
            "145: %s (visitor) left Share Play.",
            "146: Cannot display all songs because there are more than %s.",
            "147: -Blank-",
            "148: Microphone switched to microphone for PS Camera.",
            "149: Microphone switched to headset connected to controller.",
            "150: -Blank-",
            "151: Microphone switched to USB microphone.",
            "152: Microphone switched to USB headset.",
            "153: Microphone switched to Bluetooth headset.",
            "154: Restart your PS4.",
            "155: -Blank-",
            "156: -Blank-",
            "157: %s could not connect to your PS4.",
            "158: Microphone switched to microphone on VR headset.",
            "159: Cannot use audio device you just connected while using VR headset.",
            "160: Cannot use this USB storage device.",
            "161: Gameplay recording paused.",
            "162: Gameplay recording resumed.",
            "163: Gameplay recording currently paused.",
            "164: Screen resolution changed by application.",
            "165: Information posted.",
            "166: Could not post information.",
            "167: Visitor cannot play or see game until you return to it.",
            "168: Invitation sent to %s.",
            "169: Private party created and invitation sent to %s.",
            "170: Keypad disconnected.",
            "171: Cannot use keypad because too many mice or keyboards are connected.",
            "172: -Blank-",
            "173: No microphone that you can use.",
            "174: All users\' microphones switched to microphone on PS Camera.",
            "175: -Blank-",
            "176: PS Camera disconnected, so now no users have a microphone.",
            "177: Insufficient free space to take screenshots.",
            "178: Controller type changed.",
            "179: Controller type changed, and you can play as host.",
            "180: Controller type changed, and you can play together with host.",
            "181: An event is about to start for the following user. -Subtext-%s",
            "182: -Blank-",
            "183: Cannot add one or more players.",
            "184: Cannot change group name.",
            "185: Cannot change group image.",
            "186: Cannot add group to [Favorite Groups].",
            "187: Cannot delete group from [Favorite Groups].",
            "188: Cannot leave group.",
            "189: Cannot listen to music in the background while using Remote Play.",
            "190: Cannot listen to music in the background while broadcasting.",
            "191: Cannot listen to music in the background while using Share Play.",
            "192: Group added to [Favorite Groups].",
            "193: -Blank-",
            "194: Invitations sent to players.",
            "195: msg_invitation_suggestion_sent_multiple",
            "196: msg_invitation_sent_player_priv_party_created_multiple",
            "197: Request sent to %s.",
            "198: Group deleted from [Favorite Groups].",
            "199: Cannot create new group.",
            "200: Group already added to [Favorite Groups].",
            "201: Cannot use another USB audio device while using VR headset.",
            "202: Virtual surround sound of the audio headset is temporarily disabled.",
            "203: -No Notification-",
            "204: Review surroundings and clear any obstacles before use. See important health" +
                " and safety warnings in the Settings menu.",
            "205: Start this game now to join a game session more quickly.",
            "206: -Blank-",
            "207: Cannot add some players because of their settings.",
            "208: Party invitation sent to group.",
            "209: Private party created and invitation sent to group.",
            "210: %s connected.",
            "211: Following %s.",
            "212: Cannot change the limit on the number of players.",
            "213: Group created.",
            "214: Cannot add some players because of their settings.",
            "215: -Blank-",
            "216: Cannot share event with message group.",
            "217: Cannot share event with Community.",
            "218: Cannot use audio features of this device.",
            "219: Cannot use audio features of some devices.",
            "220: Activity shared.",
            "221: Cannot share activity.",
            "222: %s",
            "223: Player blocked.",
            "224: Cannot send message.",
            "225: High-resolution captures unsupported by this application are not displayed.",
            "226: Song playback stopped because you reached the monthly free time limit.",
            "227: -Blank-",
            "228: -Blank-",
            "229: -Blank-",
            "230: -Blank-",
            "231: -Blank-",
            "232: 3D audio of the audio headset is temporarily disabled.",
            "233: Players suggested to the party owner for invitation.",
            "234: Private party created and invitations sent to players.",
            "235: Song added to [Your Music].",
            "236: Song removed from [Your Music].",
            "237: Cannot add song to [Your Music].",
            "238: Cannot remove song from [Your Music].",
            "239: Your account is suspended from PlayStation Network.",
            "240: You have left the party."});
            this.notifyicons.Location = new System.Drawing.Point(18, 46);
            this.notifyicons.Name = "notifyicons";
            this.notifyicons.Size = new System.Drawing.Size(171, 21);
            this.notifyicons.TabIndex = 6;
            // 
            // printsendbtn
            // 
            this.printsendbtn.Location = new System.Drawing.Point(428, 89);
            this.printsendbtn.Name = "printsendbtn";
            this.printsendbtn.Size = new System.Drawing.Size(46, 23);
            this.printsendbtn.TabIndex = 4;
            this.printsendbtn.Text = "Send";
            this.printsendbtn.UseVisualStyleBackColor = true;
            this.printsendbtn.Click += new System.EventHandler(this.printsendbtn_Click);
            // 
            // printinput
            // 
            this.printinput.Location = new System.Drawing.Point(18, 91);
            this.printinput.Name = "printinput";
            this.printinput.Size = new System.Drawing.Size(404, 20);
            this.printinput.TabIndex = 3;
            // 
            // rebootbtn
            // 
            this.rebootbtn.Location = new System.Drawing.Point(18, 132);
            this.rebootbtn.Name = "rebootbtn";
            this.rebootbtn.Size = new System.Drawing.Size(68, 23);
            this.rebootbtn.TabIndex = 2;
            this.rebootbtn.Text = "Reboot";
            this.rebootbtn.UseVisualStyleBackColor = true;
            // 
            // notifybtn
            // 
            this.notifybtn.Location = new System.Drawing.Point(428, 46);
            this.notifybtn.Name = "notifybtn";
            this.notifybtn.Size = new System.Drawing.Size(46, 23);
            this.notifybtn.TabIndex = 1;
            this.notifybtn.Text = "Send";
            this.notifybtn.UseVisualStyleBackColor = true;
            this.notifybtn.Click += new System.EventHandler(this.notifybtn_Click);
            // 
            // notifyinput
            // 
            this.notifyinput.Location = new System.Drawing.Point(195, 46);
            this.notifyinput.Name = "notifyinput";
            this.notifyinput.Size = new System.Drawing.Size(227, 20);
            this.notifyinput.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(533, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cntstatus
            // 
            this.cntstatus.Name = "cntstatus";
            this.cntstatus.Size = new System.Drawing.Size(91, 17);
            this.cntstatus.Text = "Not Connected!";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.payloadpath);
            this.groupBox3.Controls.Add(this.loadpayload);
            this.groupBox3.Controls.Add(this.ipaddrinputpl);
            this.groupBox3.Controls.Add(this.portinput);
            this.groupBox3.Controls.Add(this.sendpayload);
            this.groupBox3.Location = new System.Drawing.Point(238, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 80);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payload Sender";
            // 
            // payloadpath
            // 
            this.payloadpath.Location = new System.Drawing.Point(6, 45);
            this.payloadpath.Name = "payloadpath";
            this.payloadpath.Size = new System.Drawing.Size(140, 20);
            this.payloadpath.TabIndex = 8;
            // 
            // loadpayload
            // 
            this.loadpayload.Location = new System.Drawing.Point(152, 45);
            this.loadpayload.Name = "loadpayload";
            this.loadpayload.Size = new System.Drawing.Size(66, 23);
            this.loadpayload.TabIndex = 7;
            this.loadpayload.Text = "Load";
            this.loadpayload.UseVisualStyleBackColor = true;
            this.loadpayload.Click += new System.EventHandler(this.loadpayload_Click);
            // 
            // ipaddrinputpl
            // 
            this.ipaddrinputpl.Location = new System.Drawing.Point(6, 19);
            this.ipaddrinputpl.Name = "ipaddrinputpl";
            this.ipaddrinputpl.Size = new System.Drawing.Size(159, 20);
            this.ipaddrinputpl.TabIndex = 4;
            this.ipaddrinputpl.Text = "192.168.0.52";
            // 
            // portinput
            // 
            this.portinput.Location = new System.Drawing.Point(171, 19);
            this.portinput.Name = "portinput";
            this.portinput.Size = new System.Drawing.Size(95, 20);
            this.portinput.TabIndex = 4;
            this.portinput.Text = "9020";
            // 
            // sendpayload
            // 
            this.sendpayload.Location = new System.Drawing.Point(224, 45);
            this.sendpayload.Name = "sendpayload";
            this.sendpayload.Size = new System.Drawing.Size(51, 23);
            this.sendpayload.TabIndex = 0;
            this.sendpayload.Text = "Send";
            this.sendpayload.UseVisualStyleBackColor = true;
            this.sendpayload.Click += new System.EventHandler(this.sendpayload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "bin files|*.bin";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.injectbtn);
            this.groupBox4.Controls.Add(this.elfpath);
            this.groupBox4.Controls.Add(this.elfloadbtn);
            this.groupBox4.Location = new System.Drawing.Point(238, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 80);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Elf Injector";
            // 
            // injectbtn
            // 
            this.injectbtn.Location = new System.Drawing.Point(202, 45);
            this.injectbtn.Name = "injectbtn";
            this.injectbtn.Size = new System.Drawing.Size(66, 23);
            this.injectbtn.TabIndex = 9;
            this.injectbtn.Text = "Inject";
            this.injectbtn.UseVisualStyleBackColor = true;
            this.injectbtn.Click += new System.EventHandler(this.injectbtn_Click);
            // 
            // elfpath
            // 
            this.elfpath.Location = new System.Drawing.Point(6, 19);
            this.elfpath.Name = "elfpath";
            this.elfpath.Size = new System.Drawing.Size(262, 20);
            this.elfpath.TabIndex = 8;
            // 
            // elfloadbtn
            // 
            this.elfloadbtn.Location = new System.Drawing.Point(130, 45);
            this.elfloadbtn.Name = "elfloadbtn";
            this.elfloadbtn.Size = new System.Drawing.Size(66, 23);
            this.elfloadbtn.TabIndex = 7;
            this.elfloadbtn.Text = "Load";
            this.elfloadbtn.UseVisualStyleBackColor = true;
            this.elfloadbtn.Click += new System.EventHandler(this.elfloadbtn_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "elf files|*.elf";
            // 
            // processlist
            // 
            this.processlist.FormattingEnabled = true;
            this.processlist.Location = new System.Drawing.Point(18, 116);
            this.processlist.Name = "processlist";
            this.processlist.Size = new System.Drawing.Size(180, 21);
            this.processlist.TabIndex = 9;
            // 
            // plist
            // 
            this.plist.AutoSize = true;
            this.plist.Location = new System.Drawing.Point(15, 100);
            this.plist.Name = "plist";
            this.plist.Size = new System.Drawing.Size(60, 13);
            this.plist.TabIndex = 9;
            this.plist.Text = "Process list";
            // 
            // prokill
            // 
            this.prokill.Location = new System.Drawing.Point(92, 132);
            this.prokill.Name = "prokill";
            this.prokill.Size = new System.Drawing.Size(68, 23);
            this.prokill.TabIndex = 9;
            this.prokill.Text = "ProcessKill";
            this.prokill.UseVisualStyleBackColor = true;
            this.prokill.Click += new System.EventHandler(this.prokill_Click);
            // 
            // proresume
            // 
            this.proresume.Location = new System.Drawing.Point(250, 132);
            this.proresume.Name = "proresume";
            this.proresume.Size = new System.Drawing.Size(96, 23);
            this.proresume.TabIndex = 10;
            this.proresume.Text = "ProcessResume";
            this.proresume.UseVisualStyleBackColor = true;
            this.proresume.Click += new System.EventHandler(this.proresume_Click);
            // 
            // prostop
            // 
            this.prostop.Location = new System.Drawing.Point(166, 132);
            this.prostop.Name = "prostop";
            this.prostop.Size = new System.Drawing.Size(78, 23);
            this.prostop.TabIndex = 11;
            this.prostop.Text = "ProcessStop";
            this.prostop.UseVisualStyleBackColor = true;
            this.prostop.Click += new System.EventHandler(this.prostop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 424);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PS4Shenanigans";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cntbtn;
        private System.Windows.Forms.TextBox ipaddrinput;
        private System.Windows.Forms.Button disconnectbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox notifyicons;
        private System.Windows.Forms.Button printsendbtn;
        private System.Windows.Forms.TextBox printinput;
        private System.Windows.Forms.Button rebootbtn;
        private System.Windows.Forms.Button notifybtn;
        private System.Windows.Forms.TextBox notifyinput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel cntstatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button sendpayload;
        private System.Windows.Forms.TextBox portinput;
        private System.Windows.Forms.Button loadpayload;
        private System.Windows.Forms.TextBox ipaddrinputpl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox payloadpath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox elfpath;
        private System.Windows.Forms.Button elfloadbtn;
        private System.Windows.Forms.Button injectbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox processlist;
        private System.Windows.Forms.Label plist;
        private System.Windows.Forms.Button prokill;
        private System.Windows.Forms.Button prostop;
        private System.Windows.Forms.Button proresume;
    }
}

