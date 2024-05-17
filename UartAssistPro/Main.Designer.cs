namespace UartAssistPro
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tab1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbStopBit = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbParity = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDataBit = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBaudRate = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPortName = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbtnReceiveUtf8 = new MaterialSkin.Controls.MaterialRadioButton();
            this.chkAutoClear = new MaterialSkin.Controls.MaterialCheckbox();
            this.rbtnReceiveHex = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnReceiveAscii = new MaterialSkin.Controls.MaterialRadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnSendHex = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnSendAscii = new MaterialSkin.Controls.MaterialRadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblTx = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.lblRx = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblState = new MaterialSkin.Controls.MaterialLabel();
            this.btnPause = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.btnSave = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.rtbReceive = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnOpenPort = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.btnDeleteReceive = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.txtSend = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSend = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Controls.Add(this.tabPage3);
            this.tab1.Depth = 0;
            this.tab1.ImageList = this.imageList1;
            this.tab1.Location = new System.Drawing.Point(6, 67);
            this.tab1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab1.Multiline = true;
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(328, 507);
            this.tab1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.cmbStopBit);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.cmbParity);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.cmbDataBit);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.cmbBaudRate);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.cmbPortName);
            this.tabPage1.ImageKey = "serial.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(320, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "串口设置";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(85, 374);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(49, 23);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "停止位";
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.AutoResize = false;
            this.cmbStopBit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbStopBit.Depth = 0;
            this.cmbStopBit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStopBit.DropDownHeight = 174;
            this.cmbStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBit.DropDownWidth = 121;
            this.cmbStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbStopBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbStopBit.FormattingEnabled = true;
            this.cmbStopBit.IntegralHeight = false;
            this.cmbStopBit.ItemHeight = 43;
            this.cmbStopBit.Location = new System.Drawing.Point(159, 360);
            this.cmbStopBit.MaxDropDownItems = 4;
            this.cmbStopBit.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(145, 49);
            this.cmbStopBit.StartIndex = 0;
            this.cmbStopBit.TabIndex = 12;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(85, 291);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(49, 23);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "校验位";
            // 
            // cmbParity
            // 
            this.cmbParity.AutoResize = false;
            this.cmbParity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbParity.Depth = 0;
            this.cmbParity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbParity.DropDownHeight = 174;
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.DropDownWidth = 121;
            this.cmbParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbParity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.IntegralHeight = false;
            this.cmbParity.ItemHeight = 43;
            this.cmbParity.Location = new System.Drawing.Point(159, 277);
            this.cmbParity.MaxDropDownItems = 4;
            this.cmbParity.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(145, 49);
            this.cmbParity.StartIndex = 0;
            this.cmbParity.TabIndex = 10;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(85, 208);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(49, 23);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "数据位";
            // 
            // cmbDataBit
            // 
            this.cmbDataBit.AutoResize = false;
            this.cmbDataBit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDataBit.Depth = 0;
            this.cmbDataBit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDataBit.DropDownHeight = 174;
            this.cmbDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBit.DropDownWidth = 121;
            this.cmbDataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDataBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDataBit.FormattingEnabled = true;
            this.cmbDataBit.IntegralHeight = false;
            this.cmbDataBit.ItemHeight = 43;
            this.cmbDataBit.Location = new System.Drawing.Point(159, 194);
            this.cmbDataBit.MaxDropDownItems = 4;
            this.cmbDataBit.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDataBit.Name = "cmbDataBit";
            this.cmbDataBit.Size = new System.Drawing.Size(145, 49);
            this.cmbDataBit.StartIndex = 0;
            this.cmbDataBit.TabIndex = 8;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(85, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(65, 23);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "通讯速率";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.AutoResize = false;
            this.cmbBaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBaudRate.Depth = 0;
            this.cmbBaudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBaudRate.DropDownHeight = 174;
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.DropDownWidth = 121;
            this.cmbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.IntegralHeight = false;
            this.cmbBaudRate.ItemHeight = 43;
            this.cmbBaudRate.Location = new System.Drawing.Point(159, 111);
            this.cmbBaudRate.MaxDropDownItems = 4;
            this.cmbBaudRate.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(145, 49);
            this.cmbBaudRate.StartIndex = 0;
            this.cmbBaudRate.TabIndex = 6;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(85, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(33, 23);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "端口";
            // 
            // cmbPortName
            // 
            this.cmbPortName.AutoResize = false;
            this.cmbPortName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPortName.Depth = 0;
            this.cmbPortName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPortName.DropDownHeight = 174;
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.DropDownWidth = 121;
            this.cmbPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.IntegralHeight = false;
            this.cmbPortName.ItemHeight = 43;
            this.cmbPortName.Location = new System.Drawing.Point(159, 28);
            this.cmbPortName.MaxDropDownItems = 4;
            this.cmbPortName.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(145, 49);
            this.cmbPortName.StartIndex = 0;
            this.cmbPortName.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.rbtnReceiveUtf8);
            this.tabPage2.Controls.Add(this.chkAutoClear);
            this.tabPage2.Controls.Add(this.rbtnReceiveHex);
            this.tabPage2.Controls.Add(this.rbtnReceiveAscii);
            this.tabPage2.ImageKey = "receive.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(320, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "接收设置";
            // 
            // rbtnReceiveUtf8
            // 
            this.rbtnReceiveUtf8.AutoSize = true;
            this.rbtnReceiveUtf8.Depth = 0;
            this.rbtnReceiveUtf8.Location = new System.Drawing.Point(77, 50);
            this.rbtnReceiveUtf8.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnReceiveUtf8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnReceiveUtf8.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnReceiveUtf8.Name = "rbtnReceiveUtf8";
            this.rbtnReceiveUtf8.Ripple = true;
            this.rbtnReceiveUtf8.Size = new System.Drawing.Size(75, 37);
            this.rbtnReceiveUtf8.TabIndex = 3;
            this.rbtnReceiveUtf8.TabStop = true;
            this.rbtnReceiveUtf8.Text = "UTF8";
            this.rbtnReceiveUtf8.UseVisualStyleBackColor = true;
            // 
            // chkAutoClear
            // 
            this.chkAutoClear.AutoSize = true;
            this.chkAutoClear.Depth = 0;
            this.chkAutoClear.Location = new System.Drawing.Point(77, 87);
            this.chkAutoClear.Margin = new System.Windows.Forms.Padding(0);
            this.chkAutoClear.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAutoClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAutoClear.Name = "chkAutoClear";
            this.chkAutoClear.ReadOnly = false;
            this.chkAutoClear.Ripple = true;
            this.chkAutoClear.Size = new System.Drawing.Size(99, 37);
            this.chkAutoClear.TabIndex = 2;
            this.chkAutoClear.Text = "自动清空";
            this.chkAutoClear.UseVisualStyleBackColor = true;
            // 
            // rbtnReceiveHex
            // 
            this.rbtnReceiveHex.AutoSize = true;
            this.rbtnReceiveHex.Depth = 0;
            this.rbtnReceiveHex.Location = new System.Drawing.Point(152, 13);
            this.rbtnReceiveHex.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnReceiveHex.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnReceiveHex.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnReceiveHex.Name = "rbtnReceiveHex";
            this.rbtnReceiveHex.Ripple = true;
            this.rbtnReceiveHex.Size = new System.Drawing.Size(67, 37);
            this.rbtnReceiveHex.TabIndex = 1;
            this.rbtnReceiveHex.TabStop = true;
            this.rbtnReceiveHex.Text = "HEX";
            this.rbtnReceiveHex.UseVisualStyleBackColor = true;
            // 
            // rbtnReceiveAscii
            // 
            this.rbtnReceiveAscii.AutoSize = true;
            this.rbtnReceiveAscii.Depth = 0;
            this.rbtnReceiveAscii.Location = new System.Drawing.Point(77, 13);
            this.rbtnReceiveAscii.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnReceiveAscii.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnReceiveAscii.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnReceiveAscii.Name = "rbtnReceiveAscii";
            this.rbtnReceiveAscii.Ripple = true;
            this.rbtnReceiveAscii.Size = new System.Drawing.Size(75, 37);
            this.rbtnReceiveAscii.TabIndex = 0;
            this.rbtnReceiveAscii.TabStop = true;
            this.rbtnReceiveAscii.Text = "ASCII";
            this.rbtnReceiveAscii.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialLabel7);
            this.tabPage3.Controls.Add(this.materialTextBox21);
            this.tabPage3.Controls.Add(this.materialRadioButton1);
            this.tabPage3.Controls.Add(this.rbtnSendHex);
            this.tabPage3.Controls.Add(this.rbtnSendAscii);
            this.tabPage3.ImageKey = "send2.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(320, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "发送设置";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(85, 108);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(152, 23);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "自动发送周期（ms）";
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBox21.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(248, 92);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(66, 48);
            this.materialTextBox21.TabIndex = 5;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.Text = "1000";
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Location = new System.Drawing.Point(76, 53);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(75, 37);
            this.materialRadioButton1.TabIndex = 4;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "UTF8";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtnSendHex
            // 
            this.rbtnSendHex.AutoSize = true;
            this.rbtnSendHex.Depth = 0;
            this.rbtnSendHex.Location = new System.Drawing.Point(151, 16);
            this.rbtnSendHex.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnSendHex.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnSendHex.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnSendHex.Name = "rbtnSendHex";
            this.rbtnSendHex.Ripple = true;
            this.rbtnSendHex.Size = new System.Drawing.Size(67, 37);
            this.rbtnSendHex.TabIndex = 3;
            this.rbtnSendHex.TabStop = true;
            this.rbtnSendHex.Text = "HEX";
            this.rbtnSendHex.UseVisualStyleBackColor = true;
            // 
            // rbtnSendAscii
            // 
            this.rbtnSendAscii.AutoSize = true;
            this.rbtnSendAscii.Depth = 0;
            this.rbtnSendAscii.Location = new System.Drawing.Point(76, 16);
            this.rbtnSendAscii.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnSendAscii.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnSendAscii.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnSendAscii.Name = "rbtnSendAscii";
            this.rbtnSendAscii.Ripple = true;
            this.rbtnSendAscii.Size = new System.Drawing.Size(75, 37);
            this.rbtnSendAscii.TabIndex = 2;
            this.rbtnSendAscii.TabStop = true;
            this.rbtnSendAscii.Text = "ASCII";
            this.rbtnSendAscii.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "receive.png");
            this.imageList1.Images.SetKeyName(1, "send2.png");
            this.imageList1.Images.SetKeyName(2, "serial.png");
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblTx);
            this.materialCard1.Controls.Add(this.materialLabel9);
            this.materialCard1.Controls.Add(this.lblRx);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.lblState);
            this.materialCard1.Controls.Add(this.btnPause);
            this.materialCard1.Controls.Add(this.btnSave);
            this.materialCard1.Controls.Add(this.rtbReceive);
            this.materialCard1.Controls.Add(this.btnOpenPort);
            this.materialCard1.Controls.Add(this.btnDeleteReceive);
            this.materialCard1.Controls.Add(this.txtSend);
            this.materialCard1.Controls.Add(this.btnSend);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(347, 68);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(591, 516);
            this.materialCard1.TabIndex = 5;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // lblTx
            // 
            this.lblTx.AutoSize = true;
            this.lblTx.BackColor = System.Drawing.Color.Transparent;
            this.lblTx.Depth = 0;
            this.lblTx.Font = new System.Drawing.Font("思源黑体 CN Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTx.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblTx.ForeColor = System.Drawing.Color.Black;
            this.lblTx.HighEmphasis = true;
            this.lblTx.Location = new System.Drawing.Point(369, 492);
            this.lblTx.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTx.Name = "lblTx";
            this.lblTx.Size = new System.Drawing.Size(10, 17);
            this.lblTx.TabIndex = 17;
            this.lblTx.Text = "   ";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("思源黑体 CN Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel9.ForeColor = System.Drawing.Color.Black;
            this.materialLabel9.HighEmphasis = true;
            this.materialLabel9.Location = new System.Drawing.Point(345, 492);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(17, 17);
            this.materialLabel9.TabIndex = 16;
            this.materialLabel9.Text = "Tx:";
            // 
            // lblRx
            // 
            this.lblRx.AutoSize = true;
            this.lblRx.BackColor = System.Drawing.Color.Transparent;
            this.lblRx.Depth = 0;
            this.lblRx.Font = new System.Drawing.Font("思源黑体 CN Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRx.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblRx.ForeColor = System.Drawing.Color.Black;
            this.lblRx.HighEmphasis = true;
            this.lblRx.Location = new System.Drawing.Point(172, 492);
            this.lblRx.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRx.Name = "lblRx";
            this.lblRx.Size = new System.Drawing.Size(7, 17);
            this.lblRx.TabIndex = 15;
            this.lblRx.Text = "  ";
            this.lblRx.UseAccent = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("思源黑体 CN Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel6.ForeColor = System.Drawing.Color.Black;
            this.materialLabel6.HighEmphasis = true;
            this.materialLabel6.Location = new System.Drawing.Point(148, 492);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(18, 17);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "Rx:";
            this.materialLabel6.UseAccent = true;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Depth = 0;
            this.lblState.Font = new System.Drawing.Font("思源黑体 CN Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblState.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Location = new System.Drawing.Point(17, 492);
            this.lblState.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(92, 17);
            this.lblState.TabIndex = 13;
            this.lblState.Text = "COM XX Opened";
            this.lblState.UseAccent = true;
            // 
            // btnPause
            // 
            this.btnPause.AnimateShowHideButton = true;
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.Depth = 0;
            this.btnPause.Icon = global::UartAssistPro.Properties.Resources.pause;
            this.btnPause.ImageList = this.imageList1;
            this.btnPause.Location = new System.Drawing.Point(538, 63);
            this.btnPause.Mini = true;
            this.btnPause.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(40, 40);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "materialFloatingActionButton2";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimateShowHideButton = true;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = global::UartAssistPro.Properties.Resources.save;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(538, 109);
            this.btnSave.Mini = true;
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "materialFloatingActionButton1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbReceive
            // 
            this.rtbReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtbReceive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbReceive.Depth = 0;
            this.rtbReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rtbReceive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtbReceive.Location = new System.Drawing.Point(17, 17);
            this.rtbReceive.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtbReceive.Name = "rtbReceive";
            this.rtbReceive.ReadOnly = true;
            this.rtbReceive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbReceive.Size = new System.Drawing.Size(513, 413);
            this.rtbReceive.TabIndex = 10;
            this.rtbReceive.Text = "";
            this.rtbReceive.TextChanged += new System.EventHandler(this.rtbReceive_TextChanged);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.AnimateShowHideButton = true;
            this.btnOpenPort.Depth = 0;
            this.btnOpenPort.Icon = global::UartAssistPro.Properties.Resources.play;
            this.btnOpenPort.ImageList = this.imageList1;
            this.btnOpenPort.Location = new System.Drawing.Point(538, 17);
            this.btnOpenPort.Mini = true;
            this.btnOpenPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(40, 40);
            this.btnOpenPort.TabIndex = 8;
            this.btnOpenPort.Text = "materialFloatingActionButton1";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnDeleteReceive
            // 
            this.btnDeleteReceive.AnimateShowHideButton = true;
            this.btnDeleteReceive.Depth = 0;
            this.btnDeleteReceive.Icon = global::UartAssistPro.Properties.Resources.delete;
            this.btnDeleteReceive.ImageList = this.imageList1;
            this.btnDeleteReceive.Location = new System.Drawing.Point(538, 155);
            this.btnDeleteReceive.Mini = true;
            this.btnDeleteReceive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteReceive.Name = "btnDeleteReceive";
            this.btnDeleteReceive.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteReceive.TabIndex = 7;
            this.btnDeleteReceive.Text = "materialFloatingActionButton1";
            this.btnDeleteReceive.UseVisualStyleBackColor = true;
            this.btnDeleteReceive.Click += new System.EventHandler(this.btnDeleteReceive_Click);
            // 
            // txtSend
            // 
            this.txtSend.AnimateReadOnly = false;
            this.txtSend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSend.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSend.Depth = 0;
            this.txtSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.HideSelection = true;
            this.txtSend.Hint = "撰写消息";
            this.txtSend.LeadingIcon = null;
            this.txtSend.Location = new System.Drawing.Point(17, 436);
            this.txtSend.MaxLength = 32767;
            this.txtSend.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSend.Name = "txtSend";
            this.txtSend.PasswordChar = '\0';
            this.txtSend.PrefixSuffixText = null;
            this.txtSend.ReadOnly = false;
            this.txtSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSend.SelectedText = "";
            this.txtSend.SelectionLength = 0;
            this.txtSend.SelectionStart = 0;
            this.txtSend.ShortcutsEnabled = true;
            this.txtSend.Size = new System.Drawing.Size(513, 48);
            this.txtSend.TabIndex = 5;
            this.txtSend.TabStop = false;
            this.txtSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSend.TrailingIcon = global::UartAssistPro.Properties.Resources.close;
            this.txtSend.UseSystemPasswordChar = false;
            this.txtSend.TrailingIconClick += new System.EventHandler(this.txtSend_TrailingIconClick);
            this.txtSend.Enter += new System.EventHandler(this.txtSend_Enter);
            // 
            // btnSend
            // 
            this.btnSend.AnimateShowHideButton = true;
            this.btnSend.Depth = 0;
            this.btnSend.Icon = global::UartAssistPro.Properties.Resources.send2;
            this.btnSend.ImageList = this.imageList1;
            this.btnSend.Location = new System.Drawing.Point(536, 438);
            this.btnSend.Mini = true;
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(40, 40);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "materialFloatingActionButton1";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 581);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.tab1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tab1;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 4);
            this.Sizable = false;
            this.Text = "Material Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cmbStopBit;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cmbParity;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cmbDataBit;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cmbBaudRate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmbPortName;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnSend;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtSend;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnDeleteReceive;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnOpenPort;
        private System.IO.Ports.SerialPort serialPort1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox rtbReceive;
        private MaterialSkin.Controls.MaterialRadioButton rbtnReceiveAscii;
        private MaterialSkin.Controls.MaterialRadioButton rbtnReceiveHex;
        private MaterialSkin.Controls.MaterialCheckbox chkAutoClear;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnSave;
        private MaterialSkin.Controls.MaterialRadioButton rbtnSendHex;
        private MaterialSkin.Controls.MaterialRadioButton rbtnSendAscii;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnPause;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private MaterialSkin.Controls.MaterialRadioButton rbtnReceiveUtf8;
        private MaterialSkin.Controls.MaterialLabel lblState;
        private MaterialSkin.Controls.MaterialLabel lblRx;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblTx;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private System.Windows.Forms.Timer timer1;
    }
}

