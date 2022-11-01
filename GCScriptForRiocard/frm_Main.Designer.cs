namespace RiocardTools
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.mns_Main = new System.Windows.Forms.MenuStrip();
            this.tsmi_Browser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_User = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_User_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_User_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_User_Search_Id = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_User_Search_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_User_Search_CPF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Card = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Card_CardList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Card_CardList_All = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Card_CardList_Active = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Card_CardList_Inactive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Card_Balance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Card_Balance_ConsultCards = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Request = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Request_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Browser_Request_Manage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tools_Consult = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tools_Consult_Card = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tools_Consult_Balance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tools_Consult_Users = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_T01 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_T02 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_T03 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_T04 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_T05 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_T06 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_T07 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_T08 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_T09 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_T10 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_StatusBar = new System.Windows.Forms.Panel();
            this.StatusBar_lbl_Message = new System.Windows.Forms.Label();
            this.StatusBar_btn_SideBar = new System.Windows.Forms.Button();
            this.StatusBar_lbl_Percentage = new System.Windows.Forms.Label();
            this.StatusBar_lbl_Credits = new System.Windows.Forms.Label();
            this.tbc_Main = new System.Windows.Forms.TabControl();
            this.tbp_Browser = new System.Windows.Forms.TabPage();
            this.wbs_Browser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.tbp_Settings = new System.Windows.Forms.TabPage();
            this.tbp_ConsultCards = new System.Windows.Forms.TabPage();
            this.tblp_ConsultCards = new System.Windows.Forms.TableLayoutPanel();
            this.tblp_ConsultCards_Body = new System.Windows.Forms.TableLayoutPanel();
            this.lstv_ConsultCards = new System.Windows.Forms.ListView();
            this.col_ConsultCards_Search = new System.Windows.Forms.ColumnHeader();
            this.col_ConsultCards_CNPJ = new System.Windows.Forms.ColumnHeader();
            this.col_ConsultCards_Company = new System.Windows.Forms.ColumnHeader();
            this.col_ConsultCards_Unity = new System.Windows.Forms.ColumnHeader();
            this.col_ConsultCards_Card = new System.Windows.Forms.ColumnHeader();
            this.col_ConsultCards_ID = new System.Windows.Forms.ColumnHeader();
            this.col_ConsultCards_Name = new System.Windows.Forms.ColumnHeader();
            this.col_ConsultCards_CPF = new System.Windows.Forms.ColumnHeader();
            this.col_ConsultCards_Type = new System.Windows.Forms.ColumnHeader();
            this.col_ConsultCards_Status = new System.Windows.Forms.ColumnHeader();
            this.col_ConsultCards_Restriction = new System.Windows.Forms.ColumnHeader();
            this.btn_ConsultCards_LoadCards = new System.Windows.Forms.Button();
            this.btn_ConsultCards_LoadCardData = new System.Windows.Forms.Button();
            this.btn_ConsultCards_SaveCardBalance = new System.Windows.Forms.Button();
            this.tblp_ConsultCards_437120 = new System.Windows.Forms.TableLayoutPanel();
            this.tblp_ConsultCards_AutoBalance = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ConsultCards_AutoBalance_CNPJ = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_ConsultCards_AutoBalance_Company = new System.Windows.Forms.TextBox();
            this.txt_ConsultCards_AutoBalance_Unity = new System.Windows.Forms.TextBox();
            this.txt_ConsultCards_AutoBalance_User = new System.Windows.Forms.TextBox();
            this.txt_ConsultCards_AutoBalance_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstv_Sidebar_Data_Main_AutoConsult = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_SideBar = new System.Windows.Forms.Panel();
            this.tbc_SideBar = new System.Windows.Forms.TabControl();
            this.SideBar_tbp_Data = new System.Windows.Forms.TabPage();
            this.tblp_Sidebar_Data_Main = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Sidebar_Data_Main_CompanyInfo = new System.Windows.Forms.Panel();
            this.pnl_Sidebar_Data_CompanyLogo = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tblp_Sidebar_Data_Main_CompanyData = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Sidebar_Data_Main_CompanyData_Company = new System.Windows.Forms.Label();
            this.cmd_Sidebar_Data_Main_CompanyData_Company = new System.Windows.Forms.ComboBox();
            this.lbl_Sidebar_Data_Main_CompanyData_Unity = new System.Windows.Forms.Label();
            this.cmd_Sidebar_Data_Main_CompanyData_Unity = new System.Windows.Forms.ComboBox();
            this.lbl_Sidebar_Data_Main_CompanyData_User = new System.Windows.Forms.Label();
            this.txt_Sidebar_Data_Main_CompanyData_User = new System.Windows.Forms.TextBox();
            this.lbl_Sidebar_Data_Main_CompanyData_Password = new System.Windows.Forms.Label();
            this.txt_Sidebar_Data_Main_CompanyData_Password = new System.Windows.Forms.TextBox();
            this.tblp_Sidebar_Data_Main_AutoConsult = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Sidebar_Data_Main_AutoConsult_Start = new System.Windows.Forms.Button();
            this.btn_Sidebar_Data_Main_AutoConsult_Edit = new System.Windows.Forms.Button();
            this.btn_Sidebar_Data_Main_AutoConsult_Remove = new System.Windows.Forms.Button();
            this.btn_Sidebar_Data_Main_AutoConsult_497761 = new System.Windows.Forms.Button();
            this.btn_Sidebar_Data_Main_AutoConsult_Clear = new System.Windows.Forms.Button();
            this.lbl_Sidebar_Data_Main_AutoConsult_Title = new System.Windows.Forms.Label();
            this.lbl_Sidebar_Data_Main_AutoConsult_Count1 = new System.Windows.Forms.Label();
            this.lbl_Sidebar_Data_Main_AutoConsult_Count2 = new System.Windows.Forms.Label();
            this.lbl_Sidebar_Data_Main_AutoConsult_Count3 = new System.Windows.Forms.Label();
            this.SideBar_tbp_SearchUsers = new System.Windows.Forms.TabPage();
            this.SideBar_tblp_SearchUsers = new System.Windows.Forms.TableLayoutPanel();
            this.lstv_SearchUsers = new System.Windows.Forms.ListView();
            this.col_SearchUsers_ID = new System.Windows.Forms.ColumnHeader();
            this.col_SearchUsers_Name = new System.Windows.Forms.ColumnHeader();
            this.col_SearchUsers_CPF = new System.Windows.Forms.ColumnHeader();
            this.col_SearchUsers_Status = new System.Windows.Forms.ColumnHeader();
            this.col_SearchUsers_Card = new System.Windows.Forms.ColumnHeader();
            this.col_SearchUsers_StatusBU = new System.Windows.Forms.ColumnHeader();
            this.col_SearchUsers_PIR = new System.Windows.Forms.ColumnHeader();
            this.col_SearchUsers_OBS = new System.Windows.Forms.ColumnHeader();
            this.col_SearchUsers_Date = new System.Windows.Forms.ColumnHeader();
            this.SideBar_SearchUsers_btn_PasteID = new System.Windows.Forms.Button();
            this.SideBar_SearchUsers_btn_PasteName = new System.Windows.Forms.Button();
            this.SideBar_SearchUsers_btn_PasteCPF = new System.Windows.Forms.Button();
            this.SideBar_SearchUsers_btn_Search = new System.Windows.Forms.Button();
            this.SideBar_SearchUsers_btn_PasteSave = new System.Windows.Forms.Button();
            this.SideBar_SearchUsers_cmb_Status = new System.Windows.Forms.ComboBox();
            this.pnl_ProgressBar = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tlp_Header = new System.Windows.Forms.TableLayoutPanel();
            this.Header_chk_AutoReload = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.importarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.mns_Main.SuspendLayout();
            this.pnl_StatusBar.SuspendLayout();
            this.tbc_Main.SuspendLayout();
            this.tbp_Browser.SuspendLayout();
            this.tbp_ConsultCards.SuspendLayout();
            this.tblp_ConsultCards.SuspendLayout();
            this.tblp_ConsultCards_Body.SuspendLayout();
            this.tblp_ConsultCards_437120.SuspendLayout();
            this.tblp_ConsultCards_AutoBalance.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.pnl_SideBar.SuspendLayout();
            this.tbc_SideBar.SuspendLayout();
            this.SideBar_tbp_Data.SuspendLayout();
            this.tblp_Sidebar_Data_Main.SuspendLayout();
            this.pnl_Sidebar_Data_Main_CompanyInfo.SuspendLayout();
            this.tblp_Sidebar_Data_Main_CompanyData.SuspendLayout();
            this.tblp_Sidebar_Data_Main_AutoConsult.SuspendLayout();
            this.SideBar_tbp_SearchUsers.SuspendLayout();
            this.SideBar_tblp_SearchUsers.SuspendLayout();
            this.pnl_ProgressBar.SuspendLayout();
            this.tlp_Header.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tlp_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns_Main
            // 
            this.mns_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mns_Main.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mns_Main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mns_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Browser,
            this.tsmi_Tools,
            this.tsmi_Settings,
            this.tsmi_T01,
            this.tsmi_T02,
            this.tsmi_T03,
            this.tsmi_T04,
            this.tsmi_T05,
            this.tsmi_T06,
            this.tsmi_T07,
            this.tsmi_T08,
            this.tsmi_T09,
            this.tsmi_T10});
            this.mns_Main.Location = new System.Drawing.Point(0, 0);
            this.mns_Main.Name = "mns_Main";
            this.mns_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mns_Main.Size = new System.Drawing.Size(1178, 32);
            this.mns_Main.TabIndex = 3;
            this.mns_Main.Text = "menuStrip1";
            // 
            // tsmi_Browser
            // 
            this.tsmi_Browser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Browser_Login,
            this.tsmi_Browser_Home,
            this.tsmi_Browser_User,
            this.tsmi_Browser_Card,
            this.tsmi_Browser_Request});
            this.tsmi_Browser.Name = "tsmi_Browser";
            this.tsmi_Browser.Size = new System.Drawing.Size(116, 28);
            this.tsmi_Browser.Text = "Navegador";
            this.tsmi_Browser.Click += new System.EventHandler(this.tsmi_Browser_Click);
            // 
            // tsmi_Browser_Login
            // 
            this.tsmi_Browser_Login.Name = "tsmi_Browser_Login";
            this.tsmi_Browser_Login.Size = new System.Drawing.Size(190, 34);
            this.tsmi_Browser_Login.Text = "Login";
            this.tsmi_Browser_Login.Click += new System.EventHandler(this.tsmi_Browser_Login_Click);
            // 
            // tsmi_Browser_Home
            // 
            this.tsmi_Browser_Home.Name = "tsmi_Browser_Home";
            this.tsmi_Browser_Home.Size = new System.Drawing.Size(190, 34);
            this.tsmi_Browser_Home.Text = "Início";
            this.tsmi_Browser_Home.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // tsmi_Browser_User
            // 
            this.tsmi_Browser_User.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Browser_User_Import,
            this.tsmi_Browser_User_Search});
            this.tsmi_Browser_User.Name = "tsmi_Browser_User";
            this.tsmi_Browser_User.Size = new System.Drawing.Size(190, 34);
            this.tsmi_Browser_User.Text = "Usuários";
            // 
            // tsmi_Browser_User_Import
            // 
            this.tsmi_Browser_User_Import.Name = "tsmi_Browser_User_Import";
            this.tsmi_Browser_User_Import.Size = new System.Drawing.Size(200, 34);
            this.tsmi_Browser_User_Import.Text = "Importar";
            this.tsmi_Browser_User_Import.Click += new System.EventHandler(this.importarToolStripMenuItem1_Click);
            // 
            // tsmi_Browser_User_Search
            // 
            this.tsmi_Browser_User_Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Browser_User_Search_Id,
            this.tsmi_Browser_User_Search_Name,
            this.tsmi_Browser_User_Search_CPF});
            this.tsmi_Browser_User_Search.Name = "tsmi_Browser_User_Search";
            this.tsmi_Browser_User_Search.Size = new System.Drawing.Size(200, 34);
            this.tsmi_Browser_User_Search.Text = "Pesquisar";
            // 
            // tsmi_Browser_User_Search_Id
            // 
            this.tsmi_Browser_User_Search_Id.Name = "tsmi_Browser_User_Search_Id";
            this.tsmi_Browser_User_Search_Id.Size = new System.Drawing.Size(240, 34);
            this.tsmi_Browser_User_Search_Id.Text = "Por Matrícula";
            this.tsmi_Browser_User_Search_Id.Click += new System.EventHandler(this.porMatriculaToolStripMenuItem_Click);
            // 
            // tsmi_Browser_User_Search_Name
            // 
            this.tsmi_Browser_User_Search_Name.Name = "tsmi_Browser_User_Search_Name";
            this.tsmi_Browser_User_Search_Name.Size = new System.Drawing.Size(240, 34);
            this.tsmi_Browser_User_Search_Name.Text = "Por Nome";
            this.tsmi_Browser_User_Search_Name.Click += new System.EventHandler(this.porNomeToolStripMenuItem_Click);
            // 
            // tsmi_Browser_User_Search_CPF
            // 
            this.tsmi_Browser_User_Search_CPF.Name = "tsmi_Browser_User_Search_CPF";
            this.tsmi_Browser_User_Search_CPF.Size = new System.Drawing.Size(240, 34);
            this.tsmi_Browser_User_Search_CPF.Text = "Por CPF";
            this.tsmi_Browser_User_Search_CPF.Click += new System.EventHandler(this.porCPFToolStripMenuItem_Click);
            // 
            // tsmi_Browser_Card
            // 
            this.tsmi_Browser_Card.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Browser_Card_CardList,
            this.tsmi_Browser_Card_Balance});
            this.tsmi_Browser_Card.Name = "tsmi_Browser_Card";
            this.tsmi_Browser_Card.Size = new System.Drawing.Size(190, 34);
            this.tsmi_Browser_Card.Text = "Cartoes";
            // 
            // tsmi_Browser_Card_CardList
            // 
            this.tsmi_Browser_Card_CardList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Browser_Card_CardList_All,
            this.tsmi_Browser_Card_CardList_Active,
            this.tsmi_Browser_Card_CardList_Inactive});
            this.tsmi_Browser_Card_CardList.Name = "tsmi_Browser_Card_CardList";
            this.tsmi_Browser_Card_CardList.Size = new System.Drawing.Size(290, 34);
            this.tsmi_Browser_Card_CardList.Text = "Relacao de Cartoes";
            // 
            // tsmi_Browser_Card_CardList_All
            // 
            this.tsmi_Browser_Card_CardList_All.Name = "tsmi_Browser_Card_CardList_All";
            this.tsmi_Browser_Card_CardList_All.Size = new System.Drawing.Size(190, 34);
            this.tsmi_Browser_Card_CardList_All.Text = "Todos";
            this.tsmi_Browser_Card_CardList_All.Click += new System.EventHandler(this.todosToolStripMenuItem1_Click);
            // 
            // tsmi_Browser_Card_CardList_Active
            // 
            this.tsmi_Browser_Card_CardList_Active.Name = "tsmi_Browser_Card_CardList_Active";
            this.tsmi_Browser_Card_CardList_Active.Size = new System.Drawing.Size(190, 34);
            this.tsmi_Browser_Card_CardList_Active.Text = "Ativos";
            this.tsmi_Browser_Card_CardList_Active.Click += new System.EventHandler(this.ativosToolStripMenuItem1_Click);
            // 
            // tsmi_Browser_Card_CardList_Inactive
            // 
            this.tsmi_Browser_Card_CardList_Inactive.Name = "tsmi_Browser_Card_CardList_Inactive";
            this.tsmi_Browser_Card_CardList_Inactive.Size = new System.Drawing.Size(190, 34);
            this.tsmi_Browser_Card_CardList_Inactive.Text = "Inativos";
            this.tsmi_Browser_Card_CardList_Inactive.Click += new System.EventHandler(this.inativosToolStripMenuItem1_Click);
            // 
            // tsmi_Browser_Card_Balance
            // 
            this.tsmi_Browser_Card_Balance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Browser_Card_Balance_ConsultCards});
            this.tsmi_Browser_Card_Balance.Name = "tsmi_Browser_Card_Balance";
            this.tsmi_Browser_Card_Balance.Size = new System.Drawing.Size(290, 34);
            this.tsmi_Browser_Card_Balance.Text = "Saldos";
            // 
            // tsmi_Browser_Card_Balance_ConsultCards
            // 
            this.tsmi_Browser_Card_Balance_ConsultCards.Name = "tsmi_Browser_Card_Balance_ConsultCards";
            this.tsmi_Browser_Card_Balance_ConsultCards.Size = new System.Drawing.Size(280, 34);
            this.tsmi_Browser_Card_Balance_ConsultCards.Text = "Consultar Cartões";
            // 
            // tsmi_Browser_Request
            // 
            this.tsmi_Browser_Request.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Browser_Request_Import,
            this.tsmi_Browser_Request_Manage});
            this.tsmi_Browser_Request.Name = "tsmi_Browser_Request";
            this.tsmi_Browser_Request.Size = new System.Drawing.Size(190, 34);
            this.tsmi_Browser_Request.Text = "Pedidos";
            // 
            // tsmi_Browser_Request_Import
            // 
            this.tsmi_Browser_Request_Import.Name = "tsmi_Browser_Request_Import";
            this.tsmi_Browser_Request_Import.Size = new System.Drawing.Size(200, 34);
            this.tsmi_Browser_Request_Import.Text = "Importar";
            this.tsmi_Browser_Request_Import.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // tsmi_Browser_Request_Manage
            // 
            this.tsmi_Browser_Request_Manage.Name = "tsmi_Browser_Request_Manage";
            this.tsmi_Browser_Request_Manage.Size = new System.Drawing.Size(200, 34);
            this.tsmi_Browser_Request_Manage.Text = "Gerenciar";
            this.tsmi_Browser_Request_Manage.Click += new System.EventHandler(this.gerenciarToolStripMenuItem_Click);
            // 
            // tsmi_Tools
            // 
            this.tsmi_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Tools_Consult});
            this.tsmi_Tools.Name = "tsmi_Tools";
            this.tsmi_Tools.Size = new System.Drawing.Size(136, 28);
            this.tsmi_Tools.Text = "Ferramentas";
            // 
            // tsmi_Tools_Consult
            // 
            this.tsmi_Tools_Consult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Tools_Consult_Card,
            this.tsmi_Tools_Consult_Balance,
            this.tsmi_Tools_Consult_Users});
            this.tsmi_Tools_Consult.Name = "tsmi_Tools_Consult";
            this.tsmi_Tools_Consult.Size = new System.Drawing.Size(200, 34);
            this.tsmi_Tools_Consult.Text = "Consultar";
            // 
            // tsmi_Tools_Consult_Card
            // 
            this.tsmi_Tools_Consult_Card.Name = "tsmi_Tools_Consult_Card";
            this.tsmi_Tools_Consult_Card.Size = new System.Drawing.Size(190, 34);
            this.tsmi_Tools_Consult_Card.Text = "Cartões";
            this.tsmi_Tools_Consult_Card.Click += new System.EventHandler(this.tsmi_Tools_Consult_Card_Click);
            // 
            // tsmi_Tools_Consult_Balance
            // 
            this.tsmi_Tools_Consult_Balance.Name = "tsmi_Tools_Consult_Balance";
            this.tsmi_Tools_Consult_Balance.Size = new System.Drawing.Size(190, 34);
            this.tsmi_Tools_Consult_Balance.Text = "Saldos";
            this.tsmi_Tools_Consult_Balance.Click += new System.EventHandler(this.tsmi_Tools_Consult_Balance_Click);
            // 
            // tsmi_Tools_Consult_Users
            // 
            this.tsmi_Tools_Consult_Users.Name = "tsmi_Tools_Consult_Users";
            this.tsmi_Tools_Consult_Users.Size = new System.Drawing.Size(190, 34);
            this.tsmi_Tools_Consult_Users.Text = "Usuários";
            this.tsmi_Tools_Consult_Users.Click += new System.EventHandler(this.tsmi_Tools_Consult_Users_Click);
            // 
            // tsmi_Settings
            // 
            this.tsmi_Settings.Name = "tsmi_Settings";
            this.tsmi_Settings.Size = new System.Drawing.Size(156, 28);
            this.tsmi_Settings.Text = "Configurações";
            this.tsmi_Settings.Click += new System.EventHandler(this.tsmi_Settings_Click);
            // 
            // tsmi_T01
            // 
            this.tsmi_T01.Name = "tsmi_T01";
            this.tsmi_T01.Size = new System.Drawing.Size(46, 28);
            this.tsmi_T01.Text = "T1";
            this.tsmi_T01.Click += new System.EventHandler(this.tsmi_T01_Click);
            // 
            // tsmi_T02
            // 
            this.tsmi_T02.Name = "tsmi_T02";
            this.tsmi_T02.Size = new System.Drawing.Size(46, 28);
            this.tsmi_T02.Text = "T2";
            this.tsmi_T02.Click += new System.EventHandler(this.tsmi_T02_Click);
            // 
            // tsmi_T03
            // 
            this.tsmi_T03.Name = "tsmi_T03";
            this.tsmi_T03.Size = new System.Drawing.Size(46, 28);
            this.tsmi_T03.Text = "T3";
            this.tsmi_T03.Click += new System.EventHandler(this.tsmi_T03_Click);
            // 
            // tsmi_T04
            // 
            this.tsmi_T04.Name = "tsmi_T04";
            this.tsmi_T04.Size = new System.Drawing.Size(46, 28);
            this.tsmi_T04.Text = "T4";
            this.tsmi_T04.Click += new System.EventHandler(this.tsmi_T04_Click);
            // 
            // tsmi_T05
            // 
            this.tsmi_T05.Name = "tsmi_T05";
            this.tsmi_T05.Size = new System.Drawing.Size(46, 28);
            this.tsmi_T05.Text = "T5";
            this.tsmi_T05.Click += new System.EventHandler(this.tsmi_T05_Click);
            // 
            // tsmi_T06
            // 
            this.tsmi_T06.Name = "tsmi_T06";
            this.tsmi_T06.Size = new System.Drawing.Size(46, 28);
            this.tsmi_T06.Text = "T6";
            this.tsmi_T06.Click += new System.EventHandler(this.tsmi_T06_Click);
            // 
            // tsmi_T07
            // 
            this.tsmi_T07.Name = "tsmi_T07";
            this.tsmi_T07.Size = new System.Drawing.Size(46, 28);
            this.tsmi_T07.Text = "T7";
            this.tsmi_T07.Click += new System.EventHandler(this.tsmi_T07_Click);
            // 
            // tsmi_T08
            // 
            this.tsmi_T08.Name = "tsmi_T08";
            this.tsmi_T08.Size = new System.Drawing.Size(46, 28);
            this.tsmi_T08.Text = "T8";
            this.tsmi_T08.Click += new System.EventHandler(this.tsmi_T08_Click);
            // 
            // tsmi_T09
            // 
            this.tsmi_T09.Name = "tsmi_T09";
            this.tsmi_T09.Size = new System.Drawing.Size(46, 28);
            this.tsmi_T09.Text = "T9";
            this.tsmi_T09.Click += new System.EventHandler(this.tsmi_T09_Click);
            // 
            // tsmi_T10
            // 
            this.tsmi_T10.Name = "tsmi_T10";
            this.tsmi_T10.Size = new System.Drawing.Size(56, 28);
            this.tsmi_T10.Text = "T10";
            this.tsmi_T10.Click += new System.EventHandler(this.tsmi_T10_Click);
            // 
            // pnl_StatusBar
            // 
            this.pnl_StatusBar.Controls.Add(this.StatusBar_lbl_Message);
            this.pnl_StatusBar.Controls.Add(this.StatusBar_btn_SideBar);
            this.pnl_StatusBar.Controls.Add(this.StatusBar_lbl_Percentage);
            this.pnl_StatusBar.Controls.Add(this.StatusBar_lbl_Credits);
            this.pnl_StatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_StatusBar.Location = new System.Drawing.Point(0, 914);
            this.pnl_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_StatusBar.Name = "pnl_StatusBar";
            this.pnl_StatusBar.Size = new System.Drawing.Size(1178, 30);
            this.pnl_StatusBar.TabIndex = 1;
            // 
            // StatusBar_lbl_Message
            // 
            this.StatusBar_lbl_Message.Dock = System.Windows.Forms.DockStyle.Right;
            this.StatusBar_lbl_Message.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusBar_lbl_Message.Location = new System.Drawing.Point(698, 0);
            this.StatusBar_lbl_Message.Name = "StatusBar_lbl_Message";
            this.StatusBar_lbl_Message.Size = new System.Drawing.Size(420, 30);
            this.StatusBar_lbl_Message.TabIndex = 4;
            this.StatusBar_lbl_Message.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusBar_btn_SideBar
            // 
            this.StatusBar_btn_SideBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StatusBar_btn_SideBar.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusBar_btn_SideBar.Location = new System.Drawing.Point(1, 1);
            this.StatusBar_btn_SideBar.Name = "StatusBar_btn_SideBar";
            this.StatusBar_btn_SideBar.Size = new System.Drawing.Size(200, 28);
            this.StatusBar_btn_SideBar.TabIndex = 3;
            this.StatusBar_btn_SideBar.Text = "Mostrar SideBar";
            this.StatusBar_btn_SideBar.UseVisualStyleBackColor = true;
            this.StatusBar_btn_SideBar.Click += new System.EventHandler(this.StatusBar_btn_SideBar_Click);
            // 
            // StatusBar_lbl_Percentage
            // 
            this.StatusBar_lbl_Percentage.Dock = System.Windows.Forms.DockStyle.Right;
            this.StatusBar_lbl_Percentage.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusBar_lbl_Percentage.Location = new System.Drawing.Point(1118, 0);
            this.StatusBar_lbl_Percentage.Margin = new System.Windows.Forms.Padding(0);
            this.StatusBar_lbl_Percentage.Name = "StatusBar_lbl_Percentage";
            this.StatusBar_lbl_Percentage.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.StatusBar_lbl_Percentage.Size = new System.Drawing.Size(60, 30);
            this.StatusBar_lbl_Percentage.TabIndex = 2;
            this.StatusBar_lbl_Percentage.Text = "100%";
            this.StatusBar_lbl_Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusBar_lbl_Credits
            // 
            this.StatusBar_lbl_Credits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusBar_lbl_Credits.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusBar_lbl_Credits.Location = new System.Drawing.Point(484, 1);
            this.StatusBar_lbl_Credits.Margin = new System.Windows.Forms.Padding(0);
            this.StatusBar_lbl_Credits.Name = "StatusBar_lbl_Credits";
            this.StatusBar_lbl_Credits.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StatusBar_lbl_Credits.Size = new System.Drawing.Size(210, 28);
            this.StatusBar_lbl_Credits.TabIndex = 0;
            this.StatusBar_lbl_Credits.Text = "developed by GCScript";
            this.StatusBar_lbl_Credits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbc_Main
            // 
            this.tbc_Main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbc_Main.Controls.Add(this.tbp_Browser);
            this.tbc_Main.Controls.Add(this.tbp_Settings);
            this.tbc_Main.Controls.Add(this.tbp_ConsultCards);
            this.tbc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_Main.ItemSize = new System.Drawing.Size(0, 1);
            this.tbc_Main.Location = new System.Drawing.Point(0, 0);
            this.tbc_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tbc_Main.Name = "tbc_Main";
            this.tbc_Main.SelectedIndex = 0;
            this.tbc_Main.Size = new System.Drawing.Size(1172, 836);
            this.tbc_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbc_Main.TabIndex = 1;
            // 
            // tbp_Browser
            // 
            this.tbp_Browser.Controls.Add(this.wbs_Browser);
            this.tbp_Browser.Location = new System.Drawing.Point(4, 5);
            this.tbp_Browser.Name = "tbp_Browser";
            this.tbp_Browser.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Browser.Size = new System.Drawing.Size(1164, 827);
            this.tbp_Browser.TabIndex = 0;
            this.tbp_Browser.Text = "Navegador";
            this.tbp_Browser.UseVisualStyleBackColor = true;
            // 
            // wbs_Browser
            // 
            this.wbs_Browser.ActivateBrowserOnCreation = false;
            this.wbs_Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbs_Browser.Location = new System.Drawing.Point(3, 3);
            this.wbs_Browser.Name = "wbs_Browser";
            this.wbs_Browser.Size = new System.Drawing.Size(1158, 821);
            this.wbs_Browser.TabIndex = 0;
            this.wbs_Browser.Text = "chromiumWebBrowser1";
            this.wbs_Browser.FrameLoadStart += new System.EventHandler<CefSharp.FrameLoadStartEventArgs>(this.wbs_Browser_FrameLoadStart);
            this.wbs_Browser.FrameLoadEnd += new System.EventHandler<CefSharp.FrameLoadEndEventArgs>(this.wbs_Browser_FrameLoadEnd);
            // 
            // tbp_Settings
            // 
            this.tbp_Settings.Location = new System.Drawing.Point(4, 5);
            this.tbp_Settings.Name = "tbp_Settings";
            this.tbp_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Settings.Size = new System.Drawing.Size(1164, 827);
            this.tbp_Settings.TabIndex = 1;
            this.tbp_Settings.Text = "Settings";
            this.tbp_Settings.UseVisualStyleBackColor = true;
            // 
            // tbp_ConsultCards
            // 
            this.tbp_ConsultCards.Controls.Add(this.tblp_ConsultCards);
            this.tbp_ConsultCards.Location = new System.Drawing.Point(4, 5);
            this.tbp_ConsultCards.Name = "tbp_ConsultCards";
            this.tbp_ConsultCards.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_ConsultCards.Size = new System.Drawing.Size(1164, 827);
            this.tbp_ConsultCards.TabIndex = 2;
            this.tbp_ConsultCards.Text = "tabPage1";
            this.tbp_ConsultCards.UseVisualStyleBackColor = true;
            // 
            // tblp_ConsultCards
            // 
            this.tblp_ConsultCards.ColumnCount = 10;
            this.tblp_ConsultCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards.Controls.Add(this.tblp_ConsultCards_Body, 0, 1);
            this.tblp_ConsultCards.Controls.Add(this.tblp_ConsultCards_437120, 0, 0);
            this.tblp_ConsultCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp_ConsultCards.Location = new System.Drawing.Point(3, 3);
            this.tblp_ConsultCards.Margin = new System.Windows.Forms.Padding(0);
            this.tblp_ConsultCards.Name = "tblp_ConsultCards";
            this.tblp_ConsultCards.RowCount = 2;
            this.tblp_ConsultCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblp_ConsultCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp_ConsultCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblp_ConsultCards.Size = new System.Drawing.Size(1158, 821);
            this.tblp_ConsultCards.TabIndex = 20;
            // 
            // tblp_ConsultCards_Body
            // 
            this.tblp_ConsultCards_Body.ColumnCount = 10;
            this.tblp_ConsultCards.SetColumnSpan(this.tblp_ConsultCards_Body, 10);
            this.tblp_ConsultCards_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblp_ConsultCards_Body.Controls.Add(this.lstv_ConsultCards, 0, 1);
            this.tblp_ConsultCards_Body.Controls.Add(this.btn_ConsultCards_LoadCards, 2, 2);
            this.tblp_ConsultCards_Body.Controls.Add(this.btn_ConsultCards_LoadCardData, 4, 2);
            this.tblp_ConsultCards_Body.Controls.Add(this.btn_ConsultCards_SaveCardBalance, 6, 2);
            this.tblp_ConsultCards_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp_ConsultCards_Body.Location = new System.Drawing.Point(0, 300);
            this.tblp_ConsultCards_Body.Margin = new System.Windows.Forms.Padding(0);
            this.tblp_ConsultCards_Body.Name = "tblp_ConsultCards_Body";
            this.tblp_ConsultCards_Body.RowCount = 3;
            this.tblp_ConsultCards_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblp_ConsultCards_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp_ConsultCards_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblp_ConsultCards_Body.Size = new System.Drawing.Size(1158, 521);
            this.tblp_ConsultCards_Body.TabIndex = 21;
            // 
            // lstv_ConsultCards
            // 
            this.lstv_ConsultCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ConsultCards_Search,
            this.col_ConsultCards_CNPJ,
            this.col_ConsultCards_Company,
            this.col_ConsultCards_Unity,
            this.col_ConsultCards_Card,
            this.col_ConsultCards_ID,
            this.col_ConsultCards_Name,
            this.col_ConsultCards_CPF,
            this.col_ConsultCards_Type,
            this.col_ConsultCards_Status,
            this.col_ConsultCards_Restriction});
            this.tblp_ConsultCards_Body.SetColumnSpan(this.lstv_ConsultCards, 10);
            this.lstv_ConsultCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstv_ConsultCards.FullRowSelect = true;
            this.lstv_ConsultCards.Location = new System.Drawing.Point(3, 33);
            this.lstv_ConsultCards.MultiSelect = false;
            this.lstv_ConsultCards.Name = "lstv_ConsultCards";
            this.lstv_ConsultCards.ShowGroups = false;
            this.lstv_ConsultCards.Size = new System.Drawing.Size(1152, 435);
            this.lstv_ConsultCards.TabIndex = 19;
            this.lstv_ConsultCards.UseCompatibleStateImageBehavior = false;
            this.lstv_ConsultCards.View = System.Windows.Forms.View.Details;
            // 
            // col_ConsultCards_Search
            // 
            this.col_ConsultCards_Search.Text = "Buscador";
            this.col_ConsultCards_Search.Width = 0;
            // 
            // col_ConsultCards_CNPJ
            // 
            this.col_ConsultCards_CNPJ.Text = "CNPJ";
            this.col_ConsultCards_CNPJ.Width = 0;
            // 
            // col_ConsultCards_Company
            // 
            this.col_ConsultCards_Company.Text = "Empresa";
            this.col_ConsultCards_Company.Width = 0;
            // 
            // col_ConsultCards_Unity
            // 
            this.col_ConsultCards_Unity.Text = "Unidade";
            this.col_ConsultCards_Unity.Width = 0;
            // 
            // col_ConsultCards_Card
            // 
            this.col_ConsultCards_Card.Text = "Nr. Cartao";
            this.col_ConsultCards_Card.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_ConsultCards_Card.Width = 0;
            // 
            // col_ConsultCards_ID
            // 
            this.col_ConsultCards_ID.Text = "Matrícula";
            this.col_ConsultCards_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col_ConsultCards_ID.Width = 0;
            // 
            // col_ConsultCards_Name
            // 
            this.col_ConsultCards_Name.Text = "Nome";
            this.col_ConsultCards_Name.Width = 0;
            // 
            // col_ConsultCards_CPF
            // 
            this.col_ConsultCards_CPF.Text = "CPF";
            this.col_ConsultCards_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_ConsultCards_CPF.Width = 0;
            // 
            // col_ConsultCards_Type
            // 
            this.col_ConsultCards_Type.Text = "Tipo";
            this.col_ConsultCards_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_ConsultCards_Type.Width = 0;
            // 
            // col_ConsultCards_Status
            // 
            this.col_ConsultCards_Status.Text = "Status";
            this.col_ConsultCards_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_ConsultCards_Status.Width = 0;
            // 
            // col_ConsultCards_Restriction
            // 
            this.col_ConsultCards_Restriction.Text = "Restrição";
            this.col_ConsultCards_Restriction.Width = 0;
            // 
            // btn_ConsultCards_LoadCards
            // 
            this.tblp_ConsultCards_Body.SetColumnSpan(this.btn_ConsultCards_LoadCards, 2);
            this.btn_ConsultCards_LoadCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ConsultCards_LoadCards.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConsultCards_LoadCards.Location = new System.Drawing.Point(233, 474);
            this.btn_ConsultCards_LoadCards.Name = "btn_ConsultCards_LoadCards";
            this.btn_ConsultCards_LoadCards.Size = new System.Drawing.Size(224, 44);
            this.btn_ConsultCards_LoadCards.TabIndex = 20;
            this.btn_ConsultCards_LoadCards.Text = "Cartões";
            this.btn_ConsultCards_LoadCards.UseVisualStyleBackColor = true;
            this.btn_ConsultCards_LoadCards.Click += new System.EventHandler(this.btn_ConsultCards_LoadCards_Click);
            // 
            // btn_ConsultCards_LoadCardData
            // 
            this.tblp_ConsultCards_Body.SetColumnSpan(this.btn_ConsultCards_LoadCardData, 2);
            this.btn_ConsultCards_LoadCardData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ConsultCards_LoadCardData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConsultCards_LoadCardData.Location = new System.Drawing.Point(463, 474);
            this.btn_ConsultCards_LoadCardData.Name = "btn_ConsultCards_LoadCardData";
            this.btn_ConsultCards_LoadCardData.Size = new System.Drawing.Size(224, 44);
            this.btn_ConsultCards_LoadCardData.TabIndex = 21;
            this.btn_ConsultCards_LoadCardData.Text = "Dados";
            this.btn_ConsultCards_LoadCardData.UseVisualStyleBackColor = true;
            this.btn_ConsultCards_LoadCardData.Click += new System.EventHandler(this.btn_ConsultCards_LoadCardData_Click);
            // 
            // btn_ConsultCards_SaveCardBalance
            // 
            this.tblp_ConsultCards_Body.SetColumnSpan(this.btn_ConsultCards_SaveCardBalance, 2);
            this.btn_ConsultCards_SaveCardBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ConsultCards_SaveCardBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConsultCards_SaveCardBalance.Location = new System.Drawing.Point(693, 474);
            this.btn_ConsultCards_SaveCardBalance.Name = "btn_ConsultCards_SaveCardBalance";
            this.btn_ConsultCards_SaveCardBalance.Size = new System.Drawing.Size(224, 44);
            this.btn_ConsultCards_SaveCardBalance.TabIndex = 24;
            this.btn_ConsultCards_SaveCardBalance.Text = "Saldos";
            this.btn_ConsultCards_SaveCardBalance.UseVisualStyleBackColor = true;
            this.btn_ConsultCards_SaveCardBalance.Click += new System.EventHandler(this.btn_ConsultCards_SaveCardBalance_Click);
            // 
            // tblp_ConsultCards_437120
            // 
            this.tblp_ConsultCards_437120.ColumnCount = 5;
            this.tblp_ConsultCards.SetColumnSpan(this.tblp_ConsultCards_437120, 10);
            this.tblp_ConsultCards_437120.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp_ConsultCards_437120.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp_ConsultCards_437120.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp_ConsultCards_437120.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp_ConsultCards_437120.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp_ConsultCards_437120.Controls.Add(this.tblp_ConsultCards_AutoBalance, 0, 1);
            this.tblp_ConsultCards_437120.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp_ConsultCards_437120.Location = new System.Drawing.Point(0, 0);
            this.tblp_ConsultCards_437120.Margin = new System.Windows.Forms.Padding(0);
            this.tblp_ConsultCards_437120.Name = "tblp_ConsultCards_437120";
            this.tblp_ConsultCards_437120.RowCount = 5;
            this.tblp_ConsultCards_437120.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblp_ConsultCards_437120.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblp_ConsultCards_437120.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblp_ConsultCards_437120.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblp_ConsultCards_437120.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblp_ConsultCards_437120.Size = new System.Drawing.Size(1158, 300);
            this.tblp_ConsultCards_437120.TabIndex = 23;
            // 
            // tblp_ConsultCards_AutoBalance
            // 
            this.tblp_ConsultCards_AutoBalance.ColumnCount = 6;
            this.tblp_ConsultCards_437120.SetColumnSpan(this.tblp_ConsultCards_AutoBalance, 4);
            this.tblp_ConsultCards_AutoBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblp_ConsultCards_AutoBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblp_ConsultCards_AutoBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblp_ConsultCards_AutoBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblp_ConsultCards_AutoBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblp_ConsultCards_AutoBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblp_ConsultCards_AutoBalance.Controls.Add(this.label1, 0, 0);
            this.tblp_ConsultCards_AutoBalance.Controls.Add(this.txt_ConsultCards_AutoBalance_CNPJ, 0, 1);
            this.tblp_ConsultCards_AutoBalance.Controls.Add(this.button2, 5, 1);
            this.tblp_ConsultCards_AutoBalance.Controls.Add(this.txt_ConsultCards_AutoBalance_Company, 1, 1);
            this.tblp_ConsultCards_AutoBalance.Controls.Add(this.txt_ConsultCards_AutoBalance_Unity, 2, 1);
            this.tblp_ConsultCards_AutoBalance.Controls.Add(this.txt_ConsultCards_AutoBalance_User, 3, 1);
            this.tblp_ConsultCards_AutoBalance.Controls.Add(this.txt_ConsultCards_AutoBalance_Password, 4, 1);
            this.tblp_ConsultCards_AutoBalance.Controls.Add(this.label2, 1, 0);
            this.tblp_ConsultCards_AutoBalance.Controls.Add(this.label3, 2, 0);
            this.tblp_ConsultCards_AutoBalance.Controls.Add(this.label4, 3, 0);
            this.tblp_ConsultCards_AutoBalance.Controls.Add(this.label5, 4, 0);
            this.tblp_ConsultCards_AutoBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp_ConsultCards_AutoBalance.Location = new System.Drawing.Point(0, 60);
            this.tblp_ConsultCards_AutoBalance.Margin = new System.Windows.Forms.Padding(0);
            this.tblp_ConsultCards_AutoBalance.Name = "tblp_ConsultCards_AutoBalance";
            this.tblp_ConsultCards_AutoBalance.RowCount = 2;
            this.tblp_ConsultCards_AutoBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp_ConsultCards_AutoBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp_ConsultCards_AutoBalance.Size = new System.Drawing.Size(924, 60);
            this.tblp_ConsultCards_AutoBalance.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "CNPJ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_ConsultCards_AutoBalance_CNPJ
            // 
            this.txt_ConsultCards_AutoBalance_CNPJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ConsultCards_AutoBalance_CNPJ.Location = new System.Drawing.Point(1, 31);
            this.txt_ConsultCards_AutoBalance_CNPJ.Margin = new System.Windows.Forms.Padding(1);
            this.txt_ConsultCards_AutoBalance_CNPJ.MaxLength = 18;
            this.txt_ConsultCards_AutoBalance_CNPJ.Name = "txt_ConsultCards_AutoBalance_CNPJ";
            this.txt_ConsultCards_AutoBalance_CNPJ.Size = new System.Drawing.Size(198, 29);
            this.txt_ConsultCards_AutoBalance_CNPJ.TabIndex = 3;
            this.txt_ConsultCards_AutoBalance_CNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(825, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_ConsultCards_AutoBalance_Company
            // 
            this.txt_ConsultCards_AutoBalance_Company.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ConsultCards_AutoBalance_Company.Location = new System.Drawing.Point(201, 31);
            this.txt_ConsultCards_AutoBalance_Company.Margin = new System.Windows.Forms.Padding(1);
            this.txt_ConsultCards_AutoBalance_Company.Name = "txt_ConsultCards_AutoBalance_Company";
            this.txt_ConsultCards_AutoBalance_Company.Size = new System.Drawing.Size(154, 29);
            this.txt_ConsultCards_AutoBalance_Company.TabIndex = 4;
            // 
            // txt_ConsultCards_AutoBalance_Unity
            // 
            this.txt_ConsultCards_AutoBalance_Unity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ConsultCards_AutoBalance_Unity.Location = new System.Drawing.Point(357, 31);
            this.txt_ConsultCards_AutoBalance_Unity.Margin = new System.Windows.Forms.Padding(1);
            this.txt_ConsultCards_AutoBalance_Unity.Name = "txt_ConsultCards_AutoBalance_Unity";
            this.txt_ConsultCards_AutoBalance_Unity.Size = new System.Drawing.Size(154, 29);
            this.txt_ConsultCards_AutoBalance_Unity.TabIndex = 5;
            // 
            // txt_ConsultCards_AutoBalance_User
            // 
            this.txt_ConsultCards_AutoBalance_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ConsultCards_AutoBalance_User.Location = new System.Drawing.Point(513, 31);
            this.txt_ConsultCards_AutoBalance_User.Margin = new System.Windows.Forms.Padding(1);
            this.txt_ConsultCards_AutoBalance_User.Name = "txt_ConsultCards_AutoBalance_User";
            this.txt_ConsultCards_AutoBalance_User.Size = new System.Drawing.Size(154, 29);
            this.txt_ConsultCards_AutoBalance_User.TabIndex = 6;
            // 
            // txt_ConsultCards_AutoBalance_Password
            // 
            this.txt_ConsultCards_AutoBalance_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ConsultCards_AutoBalance_Password.Location = new System.Drawing.Point(669, 31);
            this.txt_ConsultCards_AutoBalance_Password.Margin = new System.Windows.Forms.Padding(1);
            this.txt_ConsultCards_AutoBalance_Password.MaxLength = 8;
            this.txt_ConsultCards_AutoBalance_Password.Name = "txt_ConsultCards_AutoBalance_Password";
            this.txt_ConsultCards_AutoBalance_Password.Size = new System.Drawing.Size(154, 29);
            this.txt_ConsultCards_AutoBalance_Password.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(201, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empresa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(357, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unidade";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(513, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuário";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(669, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Senha";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lstv_Sidebar_Data_Main_AutoConsult
            // 
            this.lstv_Sidebar_Data_Main_AutoConsult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.tblp_Sidebar_Data_Main_AutoConsult.SetColumnSpan(this.lstv_Sidebar_Data_Main_AutoConsult, 5);
            this.lstv_Sidebar_Data_Main_AutoConsult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstv_Sidebar_Data_Main_AutoConsult.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstv_Sidebar_Data_Main_AutoConsult.FullRowSelect = true;
            this.lstv_Sidebar_Data_Main_AutoConsult.Location = new System.Drawing.Point(3, 33);
            this.lstv_Sidebar_Data_Main_AutoConsult.MultiSelect = false;
            this.lstv_Sidebar_Data_Main_AutoConsult.Name = "lstv_Sidebar_Data_Main_AutoConsult";
            this.lstv_Sidebar_Data_Main_AutoConsult.ShowGroups = false;
            this.lstv_Sidebar_Data_Main_AutoConsult.Size = new System.Drawing.Size(974, 209);
            this.lstv_Sidebar_Data_Main_AutoConsult.TabIndex = 20;
            this.lstv_Sidebar_Data_Main_AutoConsult.UseCompatibleStateImageBehavior = false;
            this.lstv_Sidebar_Data_Main_AutoConsult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CNPJ";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Empresa";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unidade";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Usuário";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Senha";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 265;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.pnl_SideBar);
            this.pnl_Main.Controls.Add(this.tbc_Main);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(3, 70);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1172, 836);
            this.pnl_Main.TabIndex = 2;
            // 
            // pnl_SideBar
            // 
            this.pnl_SideBar.Controls.Add(this.tbc_SideBar);
            this.pnl_SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_SideBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_SideBar.Name = "pnl_SideBar";
            this.pnl_SideBar.Size = new System.Drawing.Size(1000, 836);
            this.pnl_SideBar.TabIndex = 0;
            this.pnl_SideBar.Visible = false;
            this.pnl_SideBar.VisibleChanged += new System.EventHandler(this.pnl_SideBar_VisibleChanged);
            // 
            // tbc_SideBar
            // 
            this.tbc_SideBar.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbc_SideBar.Controls.Add(this.SideBar_tbp_Data);
            this.tbc_SideBar.Controls.Add(this.SideBar_tbp_SearchUsers);
            this.tbc_SideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_SideBar.ItemSize = new System.Drawing.Size(0, 1);
            this.tbc_SideBar.Location = new System.Drawing.Point(0, 0);
            this.tbc_SideBar.Name = "tbc_SideBar";
            this.tbc_SideBar.SelectedIndex = 0;
            this.tbc_SideBar.Size = new System.Drawing.Size(1000, 836);
            this.tbc_SideBar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbc_SideBar.TabIndex = 0;
            // 
            // SideBar_tbp_Data
            // 
            this.SideBar_tbp_Data.Controls.Add(this.tblp_Sidebar_Data_Main);
            this.SideBar_tbp_Data.Location = new System.Drawing.Point(4, 5);
            this.SideBar_tbp_Data.Name = "SideBar_tbp_Data";
            this.SideBar_tbp_Data.Padding = new System.Windows.Forms.Padding(3);
            this.SideBar_tbp_Data.Size = new System.Drawing.Size(992, 827);
            this.SideBar_tbp_Data.TabIndex = 1;
            this.SideBar_tbp_Data.Text = "Dados";
            this.SideBar_tbp_Data.UseVisualStyleBackColor = true;
            // 
            // tblp_Sidebar_Data_Main
            // 
            this.tblp_Sidebar_Data_Main.ColumnCount = 1;
            this.tblp_Sidebar_Data_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp_Sidebar_Data_Main.Controls.Add(this.pnl_Sidebar_Data_Main_CompanyInfo, 0, 0);
            this.tblp_Sidebar_Data_Main.Controls.Add(this.tblp_Sidebar_Data_Main_CompanyData, 0, 1);
            this.tblp_Sidebar_Data_Main.Controls.Add(this.tblp_Sidebar_Data_Main_AutoConsult, 0, 2);
            this.tblp_Sidebar_Data_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp_Sidebar_Data_Main.Location = new System.Drawing.Point(3, 3);
            this.tblp_Sidebar_Data_Main.Name = "tblp_Sidebar_Data_Main";
            this.tblp_Sidebar_Data_Main.RowCount = 3;
            this.tblp_Sidebar_Data_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tblp_Sidebar_Data_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblp_Sidebar_Data_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp_Sidebar_Data_Main.Size = new System.Drawing.Size(986, 821);
            this.tblp_Sidebar_Data_Main.TabIndex = 24;
            // 
            // pnl_Sidebar_Data_Main_CompanyInfo
            // 
            this.pnl_Sidebar_Data_Main_CompanyInfo.Controls.Add(this.pnl_Sidebar_Data_CompanyLogo);
            this.pnl_Sidebar_Data_Main_CompanyInfo.Controls.Add(this.label14);
            this.pnl_Sidebar_Data_Main_CompanyInfo.Controls.Add(this.label16);
            this.pnl_Sidebar_Data_Main_CompanyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Sidebar_Data_Main_CompanyInfo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Sidebar_Data_Main_CompanyInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Sidebar_Data_Main_CompanyInfo.Name = "pnl_Sidebar_Data_Main_CompanyInfo";
            this.pnl_Sidebar_Data_Main_CompanyInfo.Size = new System.Drawing.Size(986, 270);
            this.pnl_Sidebar_Data_Main_CompanyInfo.TabIndex = 24;
            // 
            // pnl_Sidebar_Data_CompanyLogo
            // 
            this.pnl_Sidebar_Data_CompanyLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Sidebar_Data_CompanyLogo.Location = new System.Drawing.Point(10, 10);
            this.pnl_Sidebar_Data_CompanyLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Sidebar_Data_CompanyLogo.Name = "pnl_Sidebar_Data_CompanyLogo";
            this.pnl_Sidebar_Data_CompanyLogo.Size = new System.Drawing.Size(250, 250);
            this.pnl_Sidebar_Data_CompanyLogo.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(559, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 30);
            this.label14.TabIndex = 10;
            this.label14.Text = "00.000.000/0000-00";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(550, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 48);
            this.label16.TabIndex = 9;
            this.label16.Text = "Gustavo";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblp_Sidebar_Data_Main_CompanyData
            // 
            this.tblp_Sidebar_Data_Main_CompanyData.ColumnCount = 2;
            this.tblp_Sidebar_Data_Main_CompanyData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp_Sidebar_Data_Main_CompanyData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp_Sidebar_Data_Main_CompanyData.Controls.Add(this.lbl_Sidebar_Data_Main_CompanyData_Company, 0, 0);
            this.tblp_Sidebar_Data_Main_CompanyData.Controls.Add(this.cmd_Sidebar_Data_Main_CompanyData_Company, 0, 1);
            this.tblp_Sidebar_Data_Main_CompanyData.Controls.Add(this.lbl_Sidebar_Data_Main_CompanyData_Unity, 0, 2);
            this.tblp_Sidebar_Data_Main_CompanyData.Controls.Add(this.cmd_Sidebar_Data_Main_CompanyData_Unity, 0, 3);
            this.tblp_Sidebar_Data_Main_CompanyData.Controls.Add(this.lbl_Sidebar_Data_Main_CompanyData_User, 0, 4);
            this.tblp_Sidebar_Data_Main_CompanyData.Controls.Add(this.txt_Sidebar_Data_Main_CompanyData_User, 0, 5);
            this.tblp_Sidebar_Data_Main_CompanyData.Controls.Add(this.lbl_Sidebar_Data_Main_CompanyData_Password, 0, 6);
            this.tblp_Sidebar_Data_Main_CompanyData.Controls.Add(this.txt_Sidebar_Data_Main_CompanyData_Password, 0, 7);
            this.tblp_Sidebar_Data_Main_CompanyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp_Sidebar_Data_Main_CompanyData.Location = new System.Drawing.Point(0, 270);
            this.tblp_Sidebar_Data_Main_CompanyData.Margin = new System.Windows.Forms.Padding(0);
            this.tblp_Sidebar_Data_Main_CompanyData.Name = "tblp_Sidebar_Data_Main_CompanyData";
            this.tblp_Sidebar_Data_Main_CompanyData.RowCount = 9;
            this.tblp_Sidebar_Data_Main_CompanyData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblp_Sidebar_Data_Main_CompanyData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblp_Sidebar_Data_Main_CompanyData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblp_Sidebar_Data_Main_CompanyData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblp_Sidebar_Data_Main_CompanyData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblp_Sidebar_Data_Main_CompanyData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblp_Sidebar_Data_Main_CompanyData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblp_Sidebar_Data_Main_CompanyData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblp_Sidebar_Data_Main_CompanyData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp_Sidebar_Data_Main_CompanyData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblp_Sidebar_Data_Main_CompanyData.Size = new System.Drawing.Size(986, 250);
            this.tblp_Sidebar_Data_Main_CompanyData.TabIndex = 23;
            // 
            // lbl_Sidebar_Data_Main_CompanyData_Company
            // 
            this.lbl_Sidebar_Data_Main_CompanyData_Company.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Sidebar_Data_Main_CompanyData_Company.Location = new System.Drawing.Point(3, 0);
            this.lbl_Sidebar_Data_Main_CompanyData_Company.Name = "lbl_Sidebar_Data_Main_CompanyData_Company";
            this.lbl_Sidebar_Data_Main_CompanyData_Company.Size = new System.Drawing.Size(487, 30);
            this.lbl_Sidebar_Data_Main_CompanyData_Company.TabIndex = 0;
            this.lbl_Sidebar_Data_Main_CompanyData_Company.Text = "Empresa";
            this.lbl_Sidebar_Data_Main_CompanyData_Company.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmd_Sidebar_Data_Main_CompanyData_Company
            // 
            this.tblp_Sidebar_Data_Main_CompanyData.SetColumnSpan(this.cmd_Sidebar_Data_Main_CompanyData_Company, 2);
            this.cmd_Sidebar_Data_Main_CompanyData_Company.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmd_Sidebar_Data_Main_CompanyData_Company.FormattingEnabled = true;
            this.cmd_Sidebar_Data_Main_CompanyData_Company.Location = new System.Drawing.Point(3, 33);
            this.cmd_Sidebar_Data_Main_CompanyData_Company.Name = "cmd_Sidebar_Data_Main_CompanyData_Company";
            this.cmd_Sidebar_Data_Main_CompanyData_Company.Size = new System.Drawing.Size(980, 30);
            this.cmd_Sidebar_Data_Main_CompanyData_Company.TabIndex = 2;
            // 
            // lbl_Sidebar_Data_Main_CompanyData_Unity
            // 
            this.lbl_Sidebar_Data_Main_CompanyData_Unity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Sidebar_Data_Main_CompanyData_Unity.Location = new System.Drawing.Point(3, 60);
            this.lbl_Sidebar_Data_Main_CompanyData_Unity.Name = "lbl_Sidebar_Data_Main_CompanyData_Unity";
            this.lbl_Sidebar_Data_Main_CompanyData_Unity.Size = new System.Drawing.Size(487, 30);
            this.lbl_Sidebar_Data_Main_CompanyData_Unity.TabIndex = 1;
            this.lbl_Sidebar_Data_Main_CompanyData_Unity.Text = "Unidade";
            this.lbl_Sidebar_Data_Main_CompanyData_Unity.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmd_Sidebar_Data_Main_CompanyData_Unity
            // 
            this.tblp_Sidebar_Data_Main_CompanyData.SetColumnSpan(this.cmd_Sidebar_Data_Main_CompanyData_Unity, 2);
            this.cmd_Sidebar_Data_Main_CompanyData_Unity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmd_Sidebar_Data_Main_CompanyData_Unity.FormattingEnabled = true;
            this.cmd_Sidebar_Data_Main_CompanyData_Unity.Location = new System.Drawing.Point(3, 93);
            this.cmd_Sidebar_Data_Main_CompanyData_Unity.Name = "cmd_Sidebar_Data_Main_CompanyData_Unity";
            this.cmd_Sidebar_Data_Main_CompanyData_Unity.Size = new System.Drawing.Size(980, 30);
            this.cmd_Sidebar_Data_Main_CompanyData_Unity.TabIndex = 3;
            // 
            // lbl_Sidebar_Data_Main_CompanyData_User
            // 
            this.lbl_Sidebar_Data_Main_CompanyData_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Sidebar_Data_Main_CompanyData_User.Location = new System.Drawing.Point(3, 120);
            this.lbl_Sidebar_Data_Main_CompanyData_User.Name = "lbl_Sidebar_Data_Main_CompanyData_User";
            this.lbl_Sidebar_Data_Main_CompanyData_User.Size = new System.Drawing.Size(487, 30);
            this.lbl_Sidebar_Data_Main_CompanyData_User.TabIndex = 4;
            this.lbl_Sidebar_Data_Main_CompanyData_User.Text = "Usuário";
            this.lbl_Sidebar_Data_Main_CompanyData_User.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_Sidebar_Data_Main_CompanyData_User
            // 
            this.tblp_Sidebar_Data_Main_CompanyData.SetColumnSpan(this.txt_Sidebar_Data_Main_CompanyData_User, 2);
            this.txt_Sidebar_Data_Main_CompanyData_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Sidebar_Data_Main_CompanyData_User.Location = new System.Drawing.Point(3, 153);
            this.txt_Sidebar_Data_Main_CompanyData_User.Name = "txt_Sidebar_Data_Main_CompanyData_User";
            this.txt_Sidebar_Data_Main_CompanyData_User.Size = new System.Drawing.Size(980, 29);
            this.txt_Sidebar_Data_Main_CompanyData_User.TabIndex = 6;
            // 
            // lbl_Sidebar_Data_Main_CompanyData_Password
            // 
            this.lbl_Sidebar_Data_Main_CompanyData_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Sidebar_Data_Main_CompanyData_Password.Location = new System.Drawing.Point(3, 180);
            this.lbl_Sidebar_Data_Main_CompanyData_Password.Name = "lbl_Sidebar_Data_Main_CompanyData_Password";
            this.lbl_Sidebar_Data_Main_CompanyData_Password.Size = new System.Drawing.Size(487, 30);
            this.lbl_Sidebar_Data_Main_CompanyData_Password.TabIndex = 5;
            this.lbl_Sidebar_Data_Main_CompanyData_Password.Text = "Senha";
            this.lbl_Sidebar_Data_Main_CompanyData_Password.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_Sidebar_Data_Main_CompanyData_Password
            // 
            this.tblp_Sidebar_Data_Main_CompanyData.SetColumnSpan(this.txt_Sidebar_Data_Main_CompanyData_Password, 2);
            this.txt_Sidebar_Data_Main_CompanyData_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Sidebar_Data_Main_CompanyData_Password.Location = new System.Drawing.Point(3, 213);
            this.txt_Sidebar_Data_Main_CompanyData_Password.Name = "txt_Sidebar_Data_Main_CompanyData_Password";
            this.txt_Sidebar_Data_Main_CompanyData_Password.Size = new System.Drawing.Size(980, 29);
            this.txt_Sidebar_Data_Main_CompanyData_Password.TabIndex = 7;
            // 
            // tblp_Sidebar_Data_Main_AutoConsult
            // 
            this.tblp_Sidebar_Data_Main_AutoConsult.ColumnCount = 5;
            this.tblp_Sidebar_Data_Main_AutoConsult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp_Sidebar_Data_Main_AutoConsult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp_Sidebar_Data_Main_AutoConsult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp_Sidebar_Data_Main_AutoConsult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp_Sidebar_Data_Main_AutoConsult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp_Sidebar_Data_Main_AutoConsult.Controls.Add(this.lstv_Sidebar_Data_Main_AutoConsult, 0, 1);
            this.tblp_Sidebar_Data_Main_AutoConsult.Controls.Add(this.btn_Sidebar_Data_Main_AutoConsult_Start, 0, 2);
            this.tblp_Sidebar_Data_Main_AutoConsult.Controls.Add(this.btn_Sidebar_Data_Main_AutoConsult_Edit, 1, 2);
            this.tblp_Sidebar_Data_Main_AutoConsult.Controls.Add(this.btn_Sidebar_Data_Main_AutoConsult_Remove, 2, 2);
            this.tblp_Sidebar_Data_Main_AutoConsult.Controls.Add(this.btn_Sidebar_Data_Main_AutoConsult_497761, 3, 2);
            this.tblp_Sidebar_Data_Main_AutoConsult.Controls.Add(this.btn_Sidebar_Data_Main_AutoConsult_Clear, 4, 2);
            this.tblp_Sidebar_Data_Main_AutoConsult.Controls.Add(this.lbl_Sidebar_Data_Main_AutoConsult_Title, 0, 0);
            this.tblp_Sidebar_Data_Main_AutoConsult.Controls.Add(this.lbl_Sidebar_Data_Main_AutoConsult_Count1, 2, 0);
            this.tblp_Sidebar_Data_Main_AutoConsult.Controls.Add(this.lbl_Sidebar_Data_Main_AutoConsult_Count2, 3, 0);
            this.tblp_Sidebar_Data_Main_AutoConsult.Controls.Add(this.lbl_Sidebar_Data_Main_AutoConsult_Count3, 4, 0);
            this.tblp_Sidebar_Data_Main_AutoConsult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp_Sidebar_Data_Main_AutoConsult.Location = new System.Drawing.Point(3, 523);
            this.tblp_Sidebar_Data_Main_AutoConsult.Name = "tblp_Sidebar_Data_Main_AutoConsult";
            this.tblp_Sidebar_Data_Main_AutoConsult.RowCount = 3;
            this.tblp_Sidebar_Data_Main_AutoConsult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblp_Sidebar_Data_Main_AutoConsult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp_Sidebar_Data_Main_AutoConsult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblp_Sidebar_Data_Main_AutoConsult.Size = new System.Drawing.Size(980, 295);
            this.tblp_Sidebar_Data_Main_AutoConsult.TabIndex = 21;
            // 
            // btn_Sidebar_Data_Main_AutoConsult_Start
            // 
            this.btn_Sidebar_Data_Main_AutoConsult_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sidebar_Data_Main_AutoConsult_Start.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sidebar_Data_Main_AutoConsult_Start.Location = new System.Drawing.Point(3, 248);
            this.btn_Sidebar_Data_Main_AutoConsult_Start.Name = "btn_Sidebar_Data_Main_AutoConsult_Start";
            this.btn_Sidebar_Data_Main_AutoConsult_Start.Size = new System.Drawing.Size(190, 44);
            this.btn_Sidebar_Data_Main_AutoConsult_Start.TabIndex = 21;
            this.btn_Sidebar_Data_Main_AutoConsult_Start.Text = "Iniciar";
            this.btn_Sidebar_Data_Main_AutoConsult_Start.UseVisualStyleBackColor = true;
            this.btn_Sidebar_Data_Main_AutoConsult_Start.Click += new System.EventHandler(this.btn_Sidebar_Data_Main_AutoConsult_Start_Click);
            // 
            // btn_Sidebar_Data_Main_AutoConsult_Edit
            // 
            this.btn_Sidebar_Data_Main_AutoConsult_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sidebar_Data_Main_AutoConsult_Edit.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sidebar_Data_Main_AutoConsult_Edit.Location = new System.Drawing.Point(199, 248);
            this.btn_Sidebar_Data_Main_AutoConsult_Edit.Name = "btn_Sidebar_Data_Main_AutoConsult_Edit";
            this.btn_Sidebar_Data_Main_AutoConsult_Edit.Size = new System.Drawing.Size(190, 44);
            this.btn_Sidebar_Data_Main_AutoConsult_Edit.TabIndex = 22;
            this.btn_Sidebar_Data_Main_AutoConsult_Edit.Text = "Editar";
            this.btn_Sidebar_Data_Main_AutoConsult_Edit.UseVisualStyleBackColor = true;
            this.btn_Sidebar_Data_Main_AutoConsult_Edit.Click += new System.EventHandler(this.btn_Sidebar_Data_Main_AutoConsult_Edit_Click);
            // 
            // btn_Sidebar_Data_Main_AutoConsult_Remove
            // 
            this.btn_Sidebar_Data_Main_AutoConsult_Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sidebar_Data_Main_AutoConsult_Remove.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sidebar_Data_Main_AutoConsult_Remove.Location = new System.Drawing.Point(395, 248);
            this.btn_Sidebar_Data_Main_AutoConsult_Remove.Name = "btn_Sidebar_Data_Main_AutoConsult_Remove";
            this.btn_Sidebar_Data_Main_AutoConsult_Remove.Size = new System.Drawing.Size(190, 44);
            this.btn_Sidebar_Data_Main_AutoConsult_Remove.TabIndex = 23;
            this.btn_Sidebar_Data_Main_AutoConsult_Remove.Text = "Remover";
            this.btn_Sidebar_Data_Main_AutoConsult_Remove.UseVisualStyleBackColor = true;
            this.btn_Sidebar_Data_Main_AutoConsult_Remove.Click += new System.EventHandler(this.btn_Sidebar_Data_Main_AutoConsult_Remove_Click);
            // 
            // btn_Sidebar_Data_Main_AutoConsult_497761
            // 
            this.btn_Sidebar_Data_Main_AutoConsult_497761.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sidebar_Data_Main_AutoConsult_497761.Enabled = false;
            this.btn_Sidebar_Data_Main_AutoConsult_497761.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sidebar_Data_Main_AutoConsult_497761.Location = new System.Drawing.Point(591, 248);
            this.btn_Sidebar_Data_Main_AutoConsult_497761.Name = "btn_Sidebar_Data_Main_AutoConsult_497761";
            this.btn_Sidebar_Data_Main_AutoConsult_497761.Size = new System.Drawing.Size(190, 44);
            this.btn_Sidebar_Data_Main_AutoConsult_497761.TabIndex = 24;
            this.btn_Sidebar_Data_Main_AutoConsult_497761.Text = "Breve";
            this.btn_Sidebar_Data_Main_AutoConsult_497761.UseVisualStyleBackColor = true;
            this.btn_Sidebar_Data_Main_AutoConsult_497761.Click += new System.EventHandler(this.btn_Sidebar_Data_Main_AutoConsult_497761_Click);
            // 
            // btn_Sidebar_Data_Main_AutoConsult_Clear
            // 
            this.btn_Sidebar_Data_Main_AutoConsult_Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sidebar_Data_Main_AutoConsult_Clear.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sidebar_Data_Main_AutoConsult_Clear.Location = new System.Drawing.Point(787, 248);
            this.btn_Sidebar_Data_Main_AutoConsult_Clear.Name = "btn_Sidebar_Data_Main_AutoConsult_Clear";
            this.btn_Sidebar_Data_Main_AutoConsult_Clear.Size = new System.Drawing.Size(190, 44);
            this.btn_Sidebar_Data_Main_AutoConsult_Clear.TabIndex = 25;
            this.btn_Sidebar_Data_Main_AutoConsult_Clear.Text = "Limpar";
            this.btn_Sidebar_Data_Main_AutoConsult_Clear.UseVisualStyleBackColor = true;
            this.btn_Sidebar_Data_Main_AutoConsult_Clear.Click += new System.EventHandler(this.btn_Sidebar_Data_Main_AutoConsult_Clear_Click);
            // 
            // lbl_Sidebar_Data_Main_AutoConsult_Title
            // 
            this.tblp_Sidebar_Data_Main_AutoConsult.SetColumnSpan(this.lbl_Sidebar_Data_Main_AutoConsult_Title, 2);
            this.lbl_Sidebar_Data_Main_AutoConsult_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Sidebar_Data_Main_AutoConsult_Title.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sidebar_Data_Main_AutoConsult_Title.Location = new System.Drawing.Point(3, 0);
            this.lbl_Sidebar_Data_Main_AutoConsult_Title.Name = "lbl_Sidebar_Data_Main_AutoConsult_Title";
            this.lbl_Sidebar_Data_Main_AutoConsult_Title.Size = new System.Drawing.Size(386, 30);
            this.lbl_Sidebar_Data_Main_AutoConsult_Title.TabIndex = 26;
            this.lbl_Sidebar_Data_Main_AutoConsult_Title.Text = "Auto Consulta";
            this.lbl_Sidebar_Data_Main_AutoConsult_Title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_Sidebar_Data_Main_AutoConsult_Count1
            // 
            this.lbl_Sidebar_Data_Main_AutoConsult_Count1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Sidebar_Data_Main_AutoConsult_Count1.Location = new System.Drawing.Point(395, 0);
            this.lbl_Sidebar_Data_Main_AutoConsult_Count1.Name = "lbl_Sidebar_Data_Main_AutoConsult_Count1";
            this.lbl_Sidebar_Data_Main_AutoConsult_Count1.Size = new System.Drawing.Size(190, 30);
            this.lbl_Sidebar_Data_Main_AutoConsult_Count1.TabIndex = 27;
            this.lbl_Sidebar_Data_Main_AutoConsult_Count1.Text = "0";
            this.lbl_Sidebar_Data_Main_AutoConsult_Count1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbl_Sidebar_Data_Main_AutoConsult_Count2
            // 
            this.lbl_Sidebar_Data_Main_AutoConsult_Count2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Sidebar_Data_Main_AutoConsult_Count2.Location = new System.Drawing.Point(591, 0);
            this.lbl_Sidebar_Data_Main_AutoConsult_Count2.Name = "lbl_Sidebar_Data_Main_AutoConsult_Count2";
            this.lbl_Sidebar_Data_Main_AutoConsult_Count2.Size = new System.Drawing.Size(190, 30);
            this.lbl_Sidebar_Data_Main_AutoConsult_Count2.TabIndex = 29;
            this.lbl_Sidebar_Data_Main_AutoConsult_Count2.Text = "0";
            this.lbl_Sidebar_Data_Main_AutoConsult_Count2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbl_Sidebar_Data_Main_AutoConsult_Count3
            // 
            this.lbl_Sidebar_Data_Main_AutoConsult_Count3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Sidebar_Data_Main_AutoConsult_Count3.Location = new System.Drawing.Point(787, 0);
            this.lbl_Sidebar_Data_Main_AutoConsult_Count3.Name = "lbl_Sidebar_Data_Main_AutoConsult_Count3";
            this.lbl_Sidebar_Data_Main_AutoConsult_Count3.Size = new System.Drawing.Size(190, 30);
            this.lbl_Sidebar_Data_Main_AutoConsult_Count3.TabIndex = 28;
            this.lbl_Sidebar_Data_Main_AutoConsult_Count3.Text = "0";
            this.lbl_Sidebar_Data_Main_AutoConsult_Count3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // SideBar_tbp_SearchUsers
            // 
            this.SideBar_tbp_SearchUsers.Controls.Add(this.SideBar_tblp_SearchUsers);
            this.SideBar_tbp_SearchUsers.Location = new System.Drawing.Point(4, 5);
            this.SideBar_tbp_SearchUsers.Name = "SideBar_tbp_SearchUsers";
            this.SideBar_tbp_SearchUsers.Padding = new System.Windows.Forms.Padding(3);
            this.SideBar_tbp_SearchUsers.Size = new System.Drawing.Size(992, 827);
            this.SideBar_tbp_SearchUsers.TabIndex = 0;
            this.SideBar_tbp_SearchUsers.Text = "Consultar Usuarios";
            this.SideBar_tbp_SearchUsers.UseVisualStyleBackColor = true;
            // 
            // SideBar_tblp_SearchUsers
            // 
            this.SideBar_tblp_SearchUsers.ColumnCount = 10;
            this.SideBar_tblp_SearchUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SideBar_tblp_SearchUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SideBar_tblp_SearchUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SideBar_tblp_SearchUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SideBar_tblp_SearchUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SideBar_tblp_SearchUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SideBar_tblp_SearchUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SideBar_tblp_SearchUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SideBar_tblp_SearchUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SideBar_tblp_SearchUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SideBar_tblp_SearchUsers.Controls.Add(this.lstv_SearchUsers, 0, 1);
            this.SideBar_tblp_SearchUsers.Controls.Add(this.SideBar_SearchUsers_btn_PasteID, 0, 2);
            this.SideBar_tblp_SearchUsers.Controls.Add(this.SideBar_SearchUsers_btn_PasteName, 2, 2);
            this.SideBar_tblp_SearchUsers.Controls.Add(this.SideBar_SearchUsers_btn_PasteCPF, 4, 2);
            this.SideBar_tblp_SearchUsers.Controls.Add(this.SideBar_SearchUsers_btn_Search, 6, 2);
            this.SideBar_tblp_SearchUsers.Controls.Add(this.SideBar_SearchUsers_btn_PasteSave, 8, 2);
            this.SideBar_tblp_SearchUsers.Controls.Add(this.SideBar_SearchUsers_cmb_Status, 8, 0);
            this.SideBar_tblp_SearchUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideBar_tblp_SearchUsers.Location = new System.Drawing.Point(3, 3);
            this.SideBar_tblp_SearchUsers.Name = "SideBar_tblp_SearchUsers";
            this.SideBar_tblp_SearchUsers.RowCount = 3;
            this.SideBar_tblp_SearchUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SideBar_tblp_SearchUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SideBar_tblp_SearchUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SideBar_tblp_SearchUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SideBar_tblp_SearchUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SideBar_tblp_SearchUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SideBar_tblp_SearchUsers.Size = new System.Drawing.Size(986, 821);
            this.SideBar_tblp_SearchUsers.TabIndex = 0;
            // 
            // lstv_SearchUsers
            // 
            this.lstv_SearchUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_SearchUsers_ID,
            this.col_SearchUsers_Name,
            this.col_SearchUsers_CPF,
            this.col_SearchUsers_Status,
            this.col_SearchUsers_Card,
            this.col_SearchUsers_StatusBU,
            this.col_SearchUsers_PIR,
            this.col_SearchUsers_OBS,
            this.col_SearchUsers_Date});
            this.SideBar_tblp_SearchUsers.SetColumnSpan(this.lstv_SearchUsers, 10);
            this.lstv_SearchUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstv_SearchUsers.FullRowSelect = true;
            this.lstv_SearchUsers.Location = new System.Drawing.Point(3, 33);
            this.lstv_SearchUsers.MultiSelect = false;
            this.lstv_SearchUsers.Name = "lstv_SearchUsers";
            this.lstv_SearchUsers.ShowGroups = false;
            this.lstv_SearchUsers.Size = new System.Drawing.Size(980, 735);
            this.lstv_SearchUsers.TabIndex = 20;
            this.lstv_SearchUsers.UseCompatibleStateImageBehavior = false;
            this.lstv_SearchUsers.View = System.Windows.Forms.View.Details;
            this.lstv_SearchUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstv_SearchUsers_MouseDoubleClick);
            // 
            // col_SearchUsers_ID
            // 
            this.col_SearchUsers_ID.Text = "Matricula";
            this.col_SearchUsers_ID.Width = 102;
            // 
            // col_SearchUsers_Name
            // 
            this.col_SearchUsers_Name.Text = "Nome";
            this.col_SearchUsers_Name.Width = 52;
            // 
            // col_SearchUsers_CPF
            // 
            this.col_SearchUsers_CPF.Text = "CPF";
            this.col_SearchUsers_CPF.Width = 42;
            // 
            // col_SearchUsers_Status
            // 
            this.col_SearchUsers_Status.Text = "Status";
            this.col_SearchUsers_Status.Width = 72;
            // 
            // col_SearchUsers_Card
            // 
            this.col_SearchUsers_Card.Text = "Cartao";
            this.col_SearchUsers_Card.Width = 72;
            // 
            // col_SearchUsers_StatusBU
            // 
            this.col_SearchUsers_StatusBU.Text = "BU";
            this.col_SearchUsers_StatusBU.Width = 38;
            // 
            // col_SearchUsers_PIR
            // 
            this.col_SearchUsers_PIR.Text = "PIR";
            this.col_SearchUsers_PIR.Width = 42;
            // 
            // col_SearchUsers_OBS
            // 
            this.col_SearchUsers_OBS.Text = "OBS";
            this.col_SearchUsers_OBS.Width = 42;
            // 
            // col_SearchUsers_Date
            // 
            this.col_SearchUsers_Date.Text = "Data";
            this.col_SearchUsers_Date.Width = 314;
            // 
            // SideBar_SearchUsers_btn_PasteID
            // 
            this.SideBar_tblp_SearchUsers.SetColumnSpan(this.SideBar_SearchUsers_btn_PasteID, 2);
            this.SideBar_SearchUsers_btn_PasteID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideBar_SearchUsers_btn_PasteID.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SideBar_SearchUsers_btn_PasteID.Location = new System.Drawing.Point(3, 774);
            this.SideBar_SearchUsers_btn_PasteID.Name = "SideBar_SearchUsers_btn_PasteID";
            this.SideBar_SearchUsers_btn_PasteID.Size = new System.Drawing.Size(190, 44);
            this.SideBar_SearchUsers_btn_PasteID.TabIndex = 21;
            this.SideBar_SearchUsers_btn_PasteID.Text = "Colar\r\nMatriculas";
            this.SideBar_SearchUsers_btn_PasteID.UseVisualStyleBackColor = true;
            this.SideBar_SearchUsers_btn_PasteID.Click += new System.EventHandler(this.SideBar_SearchUsers_btn_PasteID_Click);
            // 
            // SideBar_SearchUsers_btn_PasteName
            // 
            this.SideBar_tblp_SearchUsers.SetColumnSpan(this.SideBar_SearchUsers_btn_PasteName, 2);
            this.SideBar_SearchUsers_btn_PasteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideBar_SearchUsers_btn_PasteName.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SideBar_SearchUsers_btn_PasteName.Location = new System.Drawing.Point(199, 774);
            this.SideBar_SearchUsers_btn_PasteName.Name = "SideBar_SearchUsers_btn_PasteName";
            this.SideBar_SearchUsers_btn_PasteName.Size = new System.Drawing.Size(190, 44);
            this.SideBar_SearchUsers_btn_PasteName.TabIndex = 22;
            this.SideBar_SearchUsers_btn_PasteName.Text = "Colar\r\nNomes";
            this.SideBar_SearchUsers_btn_PasteName.UseVisualStyleBackColor = true;
            this.SideBar_SearchUsers_btn_PasteName.Click += new System.EventHandler(this.SideBar_SearchUsers_btn_PasteName_Click);
            // 
            // SideBar_SearchUsers_btn_PasteCPF
            // 
            this.SideBar_tblp_SearchUsers.SetColumnSpan(this.SideBar_SearchUsers_btn_PasteCPF, 2);
            this.SideBar_SearchUsers_btn_PasteCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideBar_SearchUsers_btn_PasteCPF.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SideBar_SearchUsers_btn_PasteCPF.Location = new System.Drawing.Point(395, 774);
            this.SideBar_SearchUsers_btn_PasteCPF.Name = "SideBar_SearchUsers_btn_PasteCPF";
            this.SideBar_SearchUsers_btn_PasteCPF.Size = new System.Drawing.Size(190, 44);
            this.SideBar_SearchUsers_btn_PasteCPF.TabIndex = 23;
            this.SideBar_SearchUsers_btn_PasteCPF.Text = "Colar\r\nCPFs";
            this.SideBar_SearchUsers_btn_PasteCPF.UseVisualStyleBackColor = true;
            this.SideBar_SearchUsers_btn_PasteCPF.Click += new System.EventHandler(this.SideBar_SearchUsers_btn_PasteCPF_Click);
            // 
            // SideBar_SearchUsers_btn_Search
            // 
            this.SideBar_tblp_SearchUsers.SetColumnSpan(this.SideBar_SearchUsers_btn_Search, 2);
            this.SideBar_SearchUsers_btn_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideBar_SearchUsers_btn_Search.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SideBar_SearchUsers_btn_Search.Location = new System.Drawing.Point(591, 774);
            this.SideBar_SearchUsers_btn_Search.Name = "SideBar_SearchUsers_btn_Search";
            this.SideBar_SearchUsers_btn_Search.Size = new System.Drawing.Size(190, 44);
            this.SideBar_SearchUsers_btn_Search.TabIndex = 24;
            this.SideBar_SearchUsers_btn_Search.Text = "Pesquisar";
            this.SideBar_SearchUsers_btn_Search.UseVisualStyleBackColor = true;
            this.SideBar_SearchUsers_btn_Search.Click += new System.EventHandler(this.SideBar_SearchUsers_btn_Search_Click);
            // 
            // SideBar_SearchUsers_btn_PasteSave
            // 
            this.SideBar_tblp_SearchUsers.SetColumnSpan(this.SideBar_SearchUsers_btn_PasteSave, 2);
            this.SideBar_SearchUsers_btn_PasteSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideBar_SearchUsers_btn_PasteSave.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SideBar_SearchUsers_btn_PasteSave.Location = new System.Drawing.Point(787, 774);
            this.SideBar_SearchUsers_btn_PasteSave.Name = "SideBar_SearchUsers_btn_PasteSave";
            this.SideBar_SearchUsers_btn_PasteSave.Size = new System.Drawing.Size(196, 44);
            this.SideBar_SearchUsers_btn_PasteSave.TabIndex = 25;
            this.SideBar_SearchUsers_btn_PasteSave.Text = "Salvar";
            this.SideBar_SearchUsers_btn_PasteSave.UseVisualStyleBackColor = true;
            this.SideBar_SearchUsers_btn_PasteSave.Click += new System.EventHandler(this.SideBar_SearchUsers_btn_PasteSave_Click);
            // 
            // SideBar_SearchUsers_cmb_Status
            // 
            this.SideBar_tblp_SearchUsers.SetColumnSpan(this.SideBar_SearchUsers_cmb_Status, 2);
            this.SideBar_SearchUsers_cmb_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideBar_SearchUsers_cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SideBar_SearchUsers_cmb_Status.FormattingEnabled = true;
            this.SideBar_SearchUsers_cmb_Status.Items.AddRange(new object[] {
            "Todos",
            "Ativos",
            "Inativos"});
            this.SideBar_SearchUsers_cmb_Status.Location = new System.Drawing.Point(787, 3);
            this.SideBar_SearchUsers_cmb_Status.Name = "SideBar_SearchUsers_cmb_Status";
            this.SideBar_SearchUsers_cmb_Status.Size = new System.Drawing.Size(196, 30);
            this.SideBar_SearchUsers_cmb_Status.TabIndex = 26;
            // 
            // pnl_ProgressBar
            // 
            this.pnl_ProgressBar.Controls.Add(this.progressBar);
            this.pnl_ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ProgressBar.Location = new System.Drawing.Point(0, 909);
            this.pnl_ProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_ProgressBar.Name = "pnl_ProgressBar";
            this.pnl_ProgressBar.Size = new System.Drawing.Size(1178, 5);
            this.pnl_ProgressBar.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1178, 5);
            this.progressBar.TabIndex = 0;
            this.progressBar.Value = 100;
            // 
            // tlp_Header
            // 
            this.tlp_Header.ColumnCount = 2;
            this.tlp_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlp_Header.Controls.Add(this.Header_chk_AutoReload, 1, 0);
            this.tlp_Header.Controls.Add(this.toolStrip1, 0, 0);
            this.tlp_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Header.Location = new System.Drawing.Point(0, 32);
            this.tlp_Header.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Header.Name = "tlp_Header";
            this.tlp_Header.RowCount = 1;
            this.tlp_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Header.Size = new System.Drawing.Size(1178, 35);
            this.tlp_Header.TabIndex = 1;
            // 
            // Header_chk_AutoReload
            // 
            this.Header_chk_AutoReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header_chk_AutoReload.Location = new System.Drawing.Point(1018, 0);
            this.Header_chk_AutoReload.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Header_chk_AutoReload.Name = "Header_chk_AutoReload";
            this.Header_chk_AutoReload.Size = new System.Drawing.Size(150, 35);
            this.Header_chk_AutoReload.TabIndex = 0;
            this.Header_chk_AutoReload.Text = "Auto Reload";
            this.Header_chk_AutoReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Header_chk_AutoReload.UseVisualStyleBackColor = true;
            this.Header_chk_AutoReload.CheckedChanged += new System.EventHandler(this.Header_chk_AutoReload_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1008, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarUsuárioToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(189, 30);
            this.toolStripSplitButton1.Text = "Importar Pedido";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // importarUsuárioToolStripMenuItem
            // 
            this.importarUsuárioToolStripMenuItem.Name = "importarUsuárioToolStripMenuItem";
            this.importarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.importarUsuárioToolStripMenuItem.Text = "Importar Usuário";
            this.importarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.importarUsuárioToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(190, 30);
            this.toolStripButton2.Text = "Gerenciar Pedidos";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(199, 30);
            this.toolStripButton1.Text = "Pesquisar Usuários";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.mns_Main, 0, 0);
            this.tlp_Main.Controls.Add(this.tlp_Header, 0, 1);
            this.tlp_Main.Controls.Add(this.pnl_Main, 0, 2);
            this.tlp_Main.Controls.Add(this.pnl_ProgressBar, 0, 3);
            this.tlp_Main.Controls.Add(this.pnl_StatusBar, 0, 4);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 5;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.Size = new System.Drawing.Size(1178, 944);
            this.tlp_Main.TabIndex = 1;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.tlp_Main);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.mns_Main;
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCScriptForRiocard";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.mns_Main.ResumeLayout(false);
            this.mns_Main.PerformLayout();
            this.pnl_StatusBar.ResumeLayout(false);
            this.tbc_Main.ResumeLayout(false);
            this.tbp_Browser.ResumeLayout(false);
            this.tbp_ConsultCards.ResumeLayout(false);
            this.tblp_ConsultCards.ResumeLayout(false);
            this.tblp_ConsultCards_Body.ResumeLayout(false);
            this.tblp_ConsultCards_437120.ResumeLayout(false);
            this.tblp_ConsultCards_AutoBalance.ResumeLayout(false);
            this.tblp_ConsultCards_AutoBalance.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_SideBar.ResumeLayout(false);
            this.tbc_SideBar.ResumeLayout(false);
            this.SideBar_tbp_Data.ResumeLayout(false);
            this.tblp_Sidebar_Data_Main.ResumeLayout(false);
            this.pnl_Sidebar_Data_Main_CompanyInfo.ResumeLayout(false);
            this.tblp_Sidebar_Data_Main_CompanyData.ResumeLayout(false);
            this.tblp_Sidebar_Data_Main_CompanyData.PerformLayout();
            this.tblp_Sidebar_Data_Main_AutoConsult.ResumeLayout(false);
            this.SideBar_tbp_SearchUsers.ResumeLayout(false);
            this.SideBar_tblp_SearchUsers.ResumeLayout(false);
            this.pnl_ProgressBar.ResumeLayout(false);
            this.tlp_Header.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip mns_Main;
        private ToolStripMenuItem tsmi_Browser;
        private ToolStripMenuItem tsmi_Settings;
        private ToolStripMenuItem tsmi_Browser_Login;
        private ToolStripMenuItem tsmi_T01;
        private ToolStripMenuItem tsmi_T02;
        private ToolStripMenuItem tsmi_T03;
        private ToolStripMenuItem tsmi_T04;
        private ToolStripMenuItem tsmi_T05;
        private ToolStripMenuItem tsmi_T06;
        private ToolStripMenuItem tsmi_T07;
        private ToolStripMenuItem tsmi_T08;
        private ToolStripMenuItem tsmi_T09;
        private ToolStripMenuItem tsmi_T10;
        private Panel pnl_StatusBar;
        private TabControl tbc_Main;
        private TabPage tbp_Browser;
        private TabPage tbp_Settings;
        private CefSharp.WinForms.ChromiumWebBrowser wbs_Browser;
        private Label StatusBar_lbl_Credits;
        private ToolStripMenuItem tsmi_Browser_User;
        private ToolStripMenuItem tsmi_Browser_User_Search;
        private ToolStripMenuItem tsmi_Browser_User_Search_Id;
        private ToolStripMenuItem tsmi_Browser_User_Search_Name;
        private ToolStripMenuItem tsmi_Browser_User_Search_CPF;
        private ToolStripMenuItem tsmi_Browser_User_Import;
        private ToolStripMenuItem tsmi_Browser_Request;
        private ToolStripMenuItem tsmi_Browser_Request_Import;
        private ToolStripMenuItem tsmi_Browser_Request_Manage;
        private ToolStripMenuItem tsmi_Browser_Home;
        private ToolStripMenuItem tsmi_Browser_Card;
        private ToolStripMenuItem tsmi_Browser_Card_CardList;
        private ToolStripMenuItem tsmi_Browser_Card_CardList_All;
        private ToolStripMenuItem tsmi_Browser_Card_CardList_Active;
        private ToolStripMenuItem tsmi_Browser_Card_CardList_Inactive;
        private ToolStripMenuItem tsmi_Tools;
        private TabPage tbp_ConsultCards;
        private ListView lstv_ConsultCards;
        private ColumnHeader col_ConsultCards_Name;
        private ColumnHeader col_ConsultCards_CPF;
        private ColumnHeader col_ConsultCards_Card;
        private TableLayoutPanel tblp_ConsultCards;
        private TableLayoutPanel tblp_ConsultCards_Body;
        private ColumnHeader col_ConsultCards_CNPJ;
        private ColumnHeader col_ConsultCards_Company;
        private ColumnHeader col_ConsultCards_Unity;
        private ColumnHeader col_ConsultCards_Search;
        private ColumnHeader col_ConsultCards_ID;
        private Button btn_ConsultCards_LoadCards;
        private Button btn_ConsultCards_LoadCardData;
        private Button btn_ConsultCards_SaveCardBalance;
        private Panel pnl_Main;
        private Panel pnl_SideBar;
        private TabControl tbc_SideBar;
        private TabPage SideBar_tbp_SearchUsers;
        private TabPage SideBar_tbp_Data;
        private TableLayoutPanel SideBar_tblp_SearchUsers;
        private ListView lstv_SearchUsers;
        private ColumnHeader col_SearchUsers_ID;
        private ColumnHeader col_SearchUsers_Name;
        private ColumnHeader col_SearchUsers_CPF;
        private ColumnHeader col_SearchUsers_Status;
        private ColumnHeader col_SearchUsers_Card;
        private ColumnHeader col_SearchUsers_StatusBU;
        private ColumnHeader col_SearchUsers_PIR;
        private Button SideBar_SearchUsers_btn_PasteID;
        private Button SideBar_SearchUsers_btn_PasteName;
        private Button SideBar_SearchUsers_btn_PasteCPF;
        private Button SideBar_SearchUsers_btn_Search;
        private Button SideBar_SearchUsers_btn_PasteSave;
        private ColumnHeader col_SearchUsers_Date;
        private ToolStripMenuItem tsmi_Browser_Card_Balance;
        private ToolStripMenuItem tsmi_Browser_Card_Balance_ConsultCards;
        private ToolStripMenuItem tsmi_Tools_Consult;
        private ToolStripMenuItem tsmi_Tools_Consult_Balance;
        private Panel pnl_ProgressBar;
        private ProgressBar progressBar;
        private Label StatusBar_lbl_Percentage;
        private Button StatusBar_btn_SideBar;
        private ColumnHeader col_ConsultCards_Type;
        private ColumnHeader col_ConsultCards_Status;
        private ColumnHeader col_ConsultCards_Restriction;
        private Label StatusBar_lbl_Message;
        private TableLayoutPanel tblp_ConsultCards_437120;
        private TableLayoutPanel tblp_ConsultCards_AutoBalance;
        private Label label1;
        private TextBox txt_ConsultCards_AutoBalance_CNPJ;
        private Button button2;
        private TextBox txt_ConsultCards_AutoBalance_Company;
        private TextBox txt_ConsultCards_AutoBalance_Unity;
        private TextBox txt_ConsultCards_AutoBalance_User;
        private TextBox txt_ConsultCards_AutoBalance_Password;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListView lstv_Sidebar_Data_Main_AutoConsult;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ToolStripMenuItem tsmi_Tools_Consult_Card;
        private ColumnHeader columnHeader6;
        private ComboBox SideBar_SearchUsers_cmb_Status;
        private ToolStripMenuItem tsmi_Tools_Consult_Users;
        private TableLayoutPanel tblp_Sidebar_Data_Main_AutoConsult;
        private Button btn_Sidebar_Data_Main_AutoConsult_Start;
        private Button btn_Sidebar_Data_Main_AutoConsult_Edit;
        private Button btn_Sidebar_Data_Main_AutoConsult_Remove;
        private Button btn_Sidebar_Data_Main_AutoConsult_497761;
        private Button btn_Sidebar_Data_Main_AutoConsult_Clear;
        private Label lbl_Sidebar_Data_Main_AutoConsult_Title;
        private Label lbl_Sidebar_Data_Main_AutoConsult_Count1;
        private Label lbl_Sidebar_Data_Main_AutoConsult_Count3;
        private Label lbl_Sidebar_Data_Main_AutoConsult_Count2;
        private Panel pnl_Sidebar_Data_CompanyLogo;
        private TableLayoutPanel tblp_Sidebar_Data_Main_CompanyData;
        private Label lbl_Sidebar_Data_Main_CompanyData_Company;
        private ComboBox cmd_Sidebar_Data_Main_CompanyData_Company;
        private Label lbl_Sidebar_Data_Main_CompanyData_Unity;
        private ComboBox cmd_Sidebar_Data_Main_CompanyData_Unity;
        private Label lbl_Sidebar_Data_Main_CompanyData_User;
        private TextBox txt_Sidebar_Data_Main_CompanyData_User;
        private Label lbl_Sidebar_Data_Main_CompanyData_Password;
        private TextBox txt_Sidebar_Data_Main_CompanyData_Password;
        private Label label14;
        private Label label16;
        private TableLayoutPanel tblp_Sidebar_Data_Main;
        private Panel pnl_Sidebar_Data_Main_CompanyInfo;
        private ColumnHeader col_SearchUsers_OBS;
        private TableLayoutPanel tlp_Header;
        private CheckBox Header_chk_AutoReload;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem importarUsuárioToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private TableLayoutPanel tlp_Main;
        private ToolStripButton toolStripButton2;
    }
}