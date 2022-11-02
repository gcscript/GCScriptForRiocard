using CefSharp;
using utilities;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;
using GCScriptForRiocard.Automation;
using GCScriptForRiocard;
using GCScriptForRiocard.Data;
using GCScriptForRiocard.Models;
using DocumentFormat.OpenXml.Spreadsheet;

namespace RiocardTools
{

    public partial class frm_Main : Form
    {
        public List<ListarUsuario> listOfMultipleUsers { get; set; } = new List<ListarUsuario>();
        private readonly ListViewColumnSorter lvwColumnSorter;

        public frm_Main()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.lstv_ConsultCards.ListViewItemSorter = lvwColumnSorter;
            this.lstv_SearchUsers.ListViewItemSorter = lvwColumnSorter;
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            //pnl_SideBar.Dock = DockStyle.Left;
            //pnl_SideBar.Location = new Point(0, 30);
            //pnl_SideBar.Size = new Size(800, 884);

            tsmi_Browser_Login.Image = icons.Properties.Resources.icons8_login_48px;
            tsmi_Browser_Home.Image = icons.Properties.Resources.icons8_home_48px;
            tsmi_Browser_User.Image = icons.Properties.Resources.icons8_user_48px;
            tsmi_Browser_User_Import.Image = icons.Properties.Resources.icons8_import_48px;
            tsmi_Browser_User_Search.Image = icons.Properties.Resources.icons8_search_48px;

            tsmi_Browser_User_Search_Id.Image = icons.Properties.Resources.icons8_search_48px;
            tsmi_Browser_User_Search_Name.Image = icons.Properties.Resources.icons8_search_48px;
            tsmi_Browser_User_Search_CPF.Image = icons.Properties.Resources.icons8_search_48px;


            tsmi_Browser_Card.Image = icons.Properties.Resources.icons8_credit_card_48px;
            tsmi_Browser_Card_CardList.Image = icons.Properties.Resources.icons8_list_48px;
            tsmi_Browser_Card_CardList_All.Image = icons.Properties.Resources.icons8_list_48px;
            tsmi_Browser_Card_CardList_Active.Image = icons.Properties.Resources.icons8_list_48px;
            tsmi_Browser_Card_CardList_Inactive.Image = icons.Properties.Resources.icons8_list_48px;
            tsmi_Browser_Request.Image = icons.Properties.Resources.icons8_list_48px;
            tsmi_Browser_Request_Import.Image = icons.Properties.Resources.icons8_import_48px;
            tsmi_Browser_Request_Manage.Image = icons.Properties.Resources.icons8_list_48px;

            btn_ConsultCards_LoadCards.Image = icons.Properties.Resources.icons8_download_48px;
            btn_ConsultCards_LoadCardData.Image = icons.Properties.Resources.icons8_download_48px;
            btn_ConsultCards_SaveCardBalance.Image = icons.Properties.Resources.icons8_save_48px;

            tsmi_Tools_Consult.Image = icons.Properties.Resources.icons8_us_dollar_48px;
            tsmi_Tools_Consult_Card.Image = icons.Properties.Resources.icons8_credit_card_48px;
            tsmi_Tools_Consult_Balance.Image = icons.Properties.Resources.icons8_search_48px;
            //tsmi_Browser_Card_Balance


            SideBar_SearchUsers_cmb_Status.SelectedIndex = 0;

            Header_chk_AutoReload.Checked = Settings.autoReload;
        }

        private void tsmi_Browser_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_Browser;
        }

        private void tsmi_Settings_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_Settings;
        }


        private void tsmi_T01_Click(object sender, EventArgs e)
        {
            string url = $"{wbs_Browser.Address}";
            MessageBox.Show($"{url}", "URL", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            Clipboard.SetText(url);
            //wbs_Browser.ExecuteScriptAsync("let element=document.querySelectorAll('input');for(let i=0;i<element.length;i++)'login'==element[i].name?element[i].value='transvaz':'senha'==element[i].name&&(element[i].value='Trans@02');");

        }

        private async void tsmi_T02_Click(object sender, EventArgs e)
        {
            var source = cl_Tools.TreatText(await wbs_Browser.GetSourceAsync());
            //var regex = new Regex("nrPedido=[0-9]{8}", RegexOptions.IgnoreCase);

            var teste = Regex.Match(source, @"NRPEDIDO=([0-9]{8})");
            var sss = teste.Groups[1].Value;
            Clipboard.SetText(source);
            //wbs_Browser.ExecuteScriptAsync("let element=document.querySelectorAll('input');for(let i=0;i<element.length;i++)'login'==element[i].name?element[i].value='serede':'senha'==element[i].name&&(element[i].value='Srde026');");

        }

        private async void tsmi_T03_Click(object sender, EventArgs e)
        {
            string card = "0117054984231";
            string url = $"https://www.cartaoriocard.com.br/vt2/comprador/cartoes/ExibirDadosCartao.do?filtrar=&historico=false&nrCartao={card}&tipoPesquisa=&pesquisa=";
            LoadUrlAsyncResponse page = await wbs_Browser.LoadUrlAsync(url);
            if (!page.Success) { MessageBox.Show("ERROR: 355381", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        }

        private async void tsmi_T04_Click(object sender, EventArgs e)
        {
            string card = "0104149723091";
            string url = $"https://www.cartaoriocard.com.br/vt2/comprador/cartoes/ExibirDadosCartao.do?filtrar=&historico=false&nrCartao={card}&tipoPesquisa=&pesquisa=";
            LoadUrlAsyncResponse page = await wbs_Browser.LoadUrlAsync(url);
            if (!page.Success) { MessageBox.Show("ERROR: 355381", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        }

        private async void tsmi_T05_Click(object sender, EventArgs e)
        {

        }

        private async void tsmi_T06_Click(object sender, EventArgs e)
        {
            string script = "(function(){let a=document.querySelector('#matriculaLabel').innerText;let b=document.querySelector('#nomeLabe1l').innerText;let c=document.querySelector('#cpfLabel').innerText;return[a,b,c]})();";
            JavascriptResponse response = await wbs_Browser.EvaluateScriptAsync(script);

            if (!response.Success) { MessageBox.Show("ERROR: 577304"); return; }
            //var source = cl_Tools.TreatText(await wbs_Browser.GetSourceAsync());

            dynamic obj = response.Result;
        }

        private void tsmi_T07_Click(object sender, EventArgs e)
        {
            ListViewItem listviewitem = new();
            listviewitem.Text = $""; // BUSCADOR
            listviewitem.SubItems.Add($""); // CNPJ
            listviewitem.SubItems.Add($""); // EMPRESA
            listviewitem.SubItems.Add($""); // UNIDADE
            listviewitem.SubItems.Add($"Gustavo"); // CARTAO
            listviewitem.SubItems.Add($""); // MATRICULA
            listviewitem.SubItems.Add($""); // NOME
            listviewitem.SubItems.Add($""); // CPF
            listviewitem.SubItems.Add($""); // SALDO
            listviewitem.SubItems.Add($""); // DATA
            listviewitem.SubItems.Add($""); // REC. PEND.
            listviewitem.SubItems.Add($""); // PAGAMENTO

            lstv_ConsultCards.Items.Add(listviewitem);
        }

        private void tsmi_T08_Click(object sender, EventArgs e)
        {
            if (lstv_ConsultCards.Items.Cast<ListViewItem>().Where(item => item.SubItems[col_ConsultCards_Card.Index].Text == "Gustavo").Count() > 0)
            {

            }
        }

        private void tsmi_T09_Click(object sender, EventArgs e)
        {
            string teste = "Gustavo";
            MessageBox.Show(cl_Tools.TreatText(teste));

        }

        private void tsmi_T10_Click(object sender, EventArgs e)
        {
        }

        private void tsmi_Browser_Login_Click(object sender, EventArgs e)
        {
            wbs_Browser.LoadUrl("https://www.cartaoriocard.com.br/vt2/visitante/login/Login.do");
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbs_Browser.LoadUrl("https://www.cartaoriocard.com.br/vt2/comprador/home/CarregarHome.do");
        }

        private async void wbs_Browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            string url = wbs_Browser.Address;

            Settings.percentLabel = StatusBar_lbl_Percentage;

            var auto = new Automation(wbs_Browser);
            await auto.Start(url);

            if (Settings.autoReload)
            {
                if (!url.Contains("login", StringComparison.OrdinalIgnoreCase))
                {
                    wbs_Browser.ExecuteScriptAsync("setTimeout((function(){location.reload()}),60*1000);");
                }
            }
        }

        private void wbs_Browser_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {
            wbs_Browser.ExecuteScriptAsync("window.print = function(){};");
        }

        private void importarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wbs_Browser.LoadUrl("https://www.cartaoriocard.com.br/vt2/comprador/usuarios/ImportarUsuarios.do");
        }

        private void porMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbs_Browser.LoadUrl("https://www.cartaoriocard.com.br/vt2/comprador/usuarios/PesquisarUsuario.do");
            Settings.searchUserFilter = 1;
        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbs_Browser.LoadUrl("https://www.cartaoriocard.com.br/vt2/comprador/usuarios/PesquisarUsuario.do");
            Settings.searchUserFilter = 2;
        }

        private void porCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbs_Browser.LoadUrl("https://www.cartaoriocard.com.br/vt2/comprador/usuarios/PesquisarUsuario.do");
            Settings.searchUserFilter = 3;
        }

        private void todosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wbs_Browser.LoadUrl("https://www.cartaoriocard.com.br/vt2/comprador/relatorios/ListaRelacaoCartoes.do?nrTpFiltroOrdem=&tpFiltroOrdem=2&cdStatus=4&diaInicial=&mesInicial=&anoInicial=&diaFinal=&mesFinal=&anoFinal=&nrCartaoDe=0000000000000&nrCartaoAte=");
        }

        private void ativosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wbs_Browser.LoadUrl("https://www.cartaoriocard.com.br/vt2/comprador/relatorios/ListaRelacaoCartoes.do?nrTpFiltroOrdem=&tpFiltroOrdem=2&cdStatus=1&diaInicial=&mesInicial=&anoInicial=&diaFinal=&mesFinal=&anoFinal=&nrCartaoDe=0000000000000&nrCartaoAte=");
        }

        private void inativosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wbs_Browser.LoadUrl("https://www.cartaoriocard.com.br/vt2/comprador/relatorios/ListaRelacaoCartoes.do?nrTpFiltroOrdem=&tpFiltroOrdem=2&cdStatus=2&diaInicial=&mesInicial=&anoInicial=&diaFinal=&mesFinal=&anoFinal=&nrCartaoDe=0000000000000&nrCartaoAte=");
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbs_Browser.LoadUrl("https://www.cartaoriocard.com.br/vt2/comprador/pedidos/ImportacaoPedido.do");
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbs_Browser.LoadUrl("https://www.cartaoriocard.com.br/vt2/comprador/pedidos/GerenciamentoPedidos.do");
        }

        private void Settings_chk_AutoReload_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SideBar_SearchUsers_btn_PasteID_Click(object sender, EventArgs e)
        {
            lstv_SearchUsers.Items.Clear();
            Settings.searchUserMode = 1;
            string clipboard = Clipboard.GetText();

            if (clipboard.Length < 1) { return; }

            string[] array_Clipboard = clipboard.Trim().Split('\n');

            List<ListViewItem> listOfItemsForListView = new();

            foreach (var item in array_Clipboard)
            {
                string linha = cl_Tools.TreatText(item, true, true, false, false);

                ListViewItem listviewitem = new();
                listviewitem.Text = $"{linha}"; // MAT
                listviewitem.SubItems.Add($""); // NOME
                listviewitem.SubItems.Add($""); // CPF
                listviewitem.SubItems.Add($""); // STATUS
                listviewitem.SubItems.Add($""); // CARTAO
                listviewitem.SubItems.Add($""); // BU
                listviewitem.SubItems.Add($""); // PIR
                listviewitem.SubItems.Add($""); // OBS
                listviewitem.SubItems.Add($""); // DATE

                listOfItemsForListView.Add(listviewitem);
            }
            lstv_SearchUsers.Items.AddRange(listOfItemsForListView.ToArray());
            cl_Tools.AdjustColumnWidthInListView(lstv_SearchUsers);
        }

        private void SideBar_SearchUsers_btn_PasteName_Click(object sender, EventArgs e)
        {
            lstv_SearchUsers.Items.Clear();
            Settings.searchUserMode = 2;
            string clipboard = Clipboard.GetText();

            if (clipboard.Length < 1) { return; }

            string[] array_Clipboard = clipboard.Trim().Split('\n');

            List<ListViewItem> listOfItemsForListView = new();

            foreach (var item in array_Clipboard)
            {
                string linha = cl_Tools.TreatText(item, true, true, false, false);

                ListViewItem listviewitem = new();
                listviewitem.Text = $""; // MAT
                listviewitem.SubItems.Add($"{linha}"); // NOME
                listviewitem.SubItems.Add($""); // CPF
                listviewitem.SubItems.Add($""); // STATUS
                listviewitem.SubItems.Add($""); // CARTAO
                listviewitem.SubItems.Add($""); // BU
                listviewitem.SubItems.Add($""); // PIR
                listviewitem.SubItems.Add($""); // OBS
                listviewitem.SubItems.Add($""); // DATE

                listOfItemsForListView.Add(listviewitem);
            }
            lstv_SearchUsers.Items.AddRange(listOfItemsForListView.ToArray());
            cl_Tools.AdjustColumnWidthInListView(lstv_SearchUsers);
        }

        private void SideBar_SearchUsers_btn_PasteCPF_Click(object sender, EventArgs e)
        {
            lstv_SearchUsers.Items.Clear();
            Settings.searchUserMode = 3;
            string clipboard = Clipboard.GetText();

            if (clipboard.Length < 1) { return; }

            string[] array_Clipboard = clipboard.Trim().Split('\n');

            List<ListViewItem> listOfItemsForListView = new();

            foreach (var item in array_Clipboard)
            {
                string linha = cl_Tools.FormatCPF1(cl_Tools.TreatText(item), true);

                if (linha.Length != 11)
                {
                    MessageBox.Show($"Erro na linha:\n{linha}", "ERROR: 834735", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }

                ListViewItem listviewitem = new();
                listviewitem.Text = $""; // MAT
                listviewitem.SubItems.Add($""); // NOME
                listviewitem.SubItems.Add($"{linha}"); // CPF
                listviewitem.SubItems.Add($""); // STATUS
                listviewitem.SubItems.Add($""); // CARTAO
                listviewitem.SubItems.Add($""); // BU
                listviewitem.SubItems.Add($""); // PIR
                listviewitem.SubItems.Add($""); // OBS
                listviewitem.SubItems.Add($""); // DATE

                listOfItemsForListView.Add(listviewitem);
            }
            lstv_SearchUsers.Items.AddRange(listOfItemsForListView.ToArray());
            cl_Tools.AdjustColumnWidthInListView(lstv_SearchUsers);
        }

        private async void SideBar_SearchUsers_btn_Search_Click(object sender, EventArgs e)
        {
            if (lstv_SearchUsers.Items.Count == 0) { return; }
            listOfMultipleUsers.Clear();

            List<Button> buttons = new() { SideBar_SearchUsers_btn_PasteID, SideBar_SearchUsers_btn_PasteName, SideBar_SearchUsers_btn_PasteCPF, SideBar_SearchUsers_btn_Search, SideBar_SearchUsers_btn_PasteSave };

            try
            {
                cl_Tools.DesableButtons(buttons);
                if (lstv_SearchUsers.Items.Count == 0) { return; }

                foreach (ListViewItem item in lstv_SearchUsers.Items)
                {
                    string itemSearch = "";

                    if (Settings.searchUserMode == 1)
                    {
                        itemSearch = item.SubItems[0].Text;
                    }
                    else if (Settings.searchUserMode == 2)
                    {
                        itemSearch = item.SubItems[1].Text;
                    }
                    else
                    {
                        itemSearch = item.SubItems[2].Text;
                    }

                    string stUsuar = ""; // TODOS

                    if (SideBar_SearchUsers_cmb_Status.SelectedIndex == 1) // ATIVOS
                    {
                        stUsuar = "A";
                    }
                    else if (SideBar_SearchUsers_cmb_Status.SelectedIndex == 2) // INATIVOS
                    {
                        stUsuar = "I";
                    }

                    string url = $"https://www.cartaoriocard.com.br/vt2/comprador/usuarios/ListarUsuario.do?&tpFiltroUsuario={Settings.searchUserMode}&palavraChave={HttpUtility.UrlEncode(itemSearch)}&palavraDe=&palavraAte=&stUsuar={stUsuar}&tpFiltroBilheteUnico=0&tpFiltroCompraPassagem=2";

                    LoadUrlAsyncResponse page = await wbs_Browser.LoadUrlAsync(url);


                    await Task.Delay(Settings.searchDelay);

                    string script = "(function () { let table = document.querySelector('#listUsuariosTable'); let rows = table.querySelectorAll('tr'); let data = []; for (let i = 1; i < rows.length; i++) { let row = rows[i]; let cols = row.querySelectorAll('td'); data.push({ 'Matricula': cols[0].innerText, 'Nome': cols[1].innerText, 'Cpf': cols[2].innerText, 'Status': cols[3].innerText, 'NrDoCartao': cols[4].innerText, 'StatusBu': cols[5].innerText, 'Pir': cols[6].innerText }); } return JSON.stringify(data) })();";
                    JavascriptResponse response = await wbs_Browser.EvaluateScriptAsync(script);

                    if (!response.Success)
                    {
                        var source = cl_Tools.TreatText(await wbs_Browser.GetSourceAsync());

                        if (source.Contains("O CPF INFORMADO E INVALIDO"))
                        {
                            item.SubItems[7].Text = "O CPF INFORMADO E INVALIDO";
                        }
                        else if (source.Contains("NENHUM USUARIO CADASTRADO PARA ESTA CONDICAO"))
                        {
                            item.SubItems[7].Text = "NENHUM USUARIO CADASTRADO PARA ESTA CONDICAO";
                        }
                        else
                        {
                            item.SubItems[7].Text = "ERROR: 263356";
                        }

                        item.SubItems[8].Text = DateTime.Now.ToString("g"); // DATE

                        continue;
                    }

                    var json = JsonSerializer.Deserialize<List<ListarUsuario>>(response.Result.ToString());

                    if (json.Count == 1)
                    {
                        item.SubItems[0].Text = json[0].Matricula;
                        item.SubItems[1].Text = json[0].Nome;
                        item.SubItems[2].Text = json[0].Cpf;
                        item.SubItems[3].Text = json[0].Status;
                        item.SubItems[4].Text = json[0].NrDoCartao;
                        item.SubItems[5].Text = json[0].StatusBu;
                        item.SubItems[6].Text = json[0].Pir;
                        item.SubItems[7].Text = ""; // OBS
                        item.SubItems[8].Text = DateTime.Now.ToString("g");
                    }
                    else
                    {
                        item.SubItems[7].Text = $"{json.Count} RESULTADOS";
                        item.SubItems[8].Text = DateTime.Now.ToString("g"); // DATE

                        foreach (var user in json)
                        {
                            listOfMultipleUsers.Add(user);
                        }

                        continue;
                    }
                }
                cl_Tools.AdjustColumnWidthInListView(lstv_SearchUsers);
            }
            catch (Exception)
            {
                //cl_Alert.Alert("ERROR: 270794", frm_Alert.enmType.Error);
            }
            finally
            {
                //progressBar.Value = 0;
                //lbl_percentage.Text = "0%";
                cl_Tools.EnableButtons(buttons);
            }

        }


        private void SideBar_SearchUsers_btn_PasteSave_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new() { SideBar_SearchUsers_btn_PasteID, SideBar_SearchUsers_btn_PasteName, SideBar_SearchUsers_btn_PasteCPF, SideBar_SearchUsers_btn_Search, SideBar_SearchUsers_btn_PasteSave };
            //progressBar.Value = 0;
            //progressBar.Maximum = lstv_Main.Items.Count;
            try
            {
                cl_Tools.DesableButtons(buttons);

                List<object> content = new();
                foreach (ListViewItem item in lstv_SearchUsers.Items)
                {
                    string id = item.SubItems[0].Text;
                    string name = item.SubItems[1].Text;
                    string cpf = cl_Tools.FormatCPF1(item.SubItems[2].Text, true);
                    string status = item.SubItems[3].Text;
                    string card = item.SubItems[4].Text;
                    string bu = item.SubItems[5].Text;
                    string pir = item.SubItems[6].Text;
                    string obs = item.SubItems[7].Text;
                    string date = item.SubItems[8].Text;

                    content.Add(new object[] { id, name, cpf, status, card, bu, pir, obs, date });

                    //progressBar.Value++;
                    //lbl_percentage.Text = $"{progressBar.Value * 100 / progressBar.Maximum}%";
                }

                cl_ExcelFunctions excelFunctions = new();
                excelFunctions.SaveWorksheet("RJ", "GUSTAVO", lstv_SearchUsers, content);

            }
            catch (Exception erro)
            {
                cl_Alert.Alert("ERROR: 233585", frm_Alert.enmType.Error);
                MessageBox.Show(erro.Message, "ERROR: 233585");
            }
            finally
            {
                //progressBar.Value = 0;
                //lbl_percentage.Text = "0%";
                cl_Tools.EnableButtons(buttons);
            }
        }

        private async void btn_ConsultCards_LoadCards_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new()
            {
                btn_ConsultCards_LoadCards,
                btn_ConsultCards_LoadCardData,
                btn_ConsultCards_SaveCardBalance
            };

            tblp_ConsultCards.Enabled = false;
            cl_Tools.DesableButtons(buttons);

            GCS_Response gcs_response = await LoadCards();

            if (!gcs_response.Success)
            {
                if (gcs_response.Message == "")
                {
                    MessageBox.Show("Aconteceu um erro!", $"ERROR: {gcs_response.ErroCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(gcs_response.Message, $"ERROR: {gcs_response.ErroCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cl_Alert.Alert($"ERROR: {gcs_response.ErroCode}", frm_Alert.enmType.Error);
                tblp_ConsultCards.Enabled = true;
                cl_Tools.EnableButtons(buttons);
                return;
            }

            tblp_ConsultCards.Enabled = true;
            cl_Tools.EnableButtons(buttons);
            cl_Alert.Alert("Cartões carregados!", frm_Alert.enmType.Success);
        }

        private async void btn_ConsultCards_LoadCardData_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new()
            {
                btn_ConsultCards_LoadCards,
                btn_ConsultCards_LoadCardData,
                btn_ConsultCards_SaveCardBalance
            };

            tblp_ConsultCards.Enabled = false;
            cl_Tools.DesableButtons(buttons);

            GCS_Response gcs_response = await LoadCardData();

            if (!gcs_response.Success)
            {
                if (gcs_response.Message == "")
                {
                    MessageBox.Show("Aconteceu um erro!", $"ERROR: {gcs_response.ErroCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(gcs_response.Message, $"ERROR: {gcs_response.ErroCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cl_Alert.Alert($"ERROR: {gcs_response.ErroCode}", frm_Alert.enmType.Error);
                tblp_ConsultCards.Enabled = true;
                cl_Tools.EnableButtons(buttons);
                return;
            }

            tblp_ConsultCards.Enabled = true;
            cl_Tools.EnableButtons(buttons);
            cl_Alert.Alert("Dados carregados!", frm_Alert.enmType.Success);
        }

        private void btn_ConsultCards_SaveCardBalance_Click(object sender, EventArgs e)
        {
            SaveTemp();
        }

        private void SaveTemp()
        {
            SaveFileDialog sfdSalvar = new();
            sfdSalvar.Filter = "Arquivo de Texto|*.txt";
            sfdSalvar.Title = "Salvar como";
            sfdSalvar.FileName = $"Dados {txt_ConsultCards_AutoBalance_Unity.Text} [{DateTime.Now:yyyy-MM-dd}]";
            sfdSalvar.ShowDialog();

            if (sfdSalvar.FileName == "")
            {
                return;
            }

            StreamWriter sw = new(sfdSalvar.FileName, false, encoding: System.Text.Encoding.UTF8);

            foreach (ListViewItem item in lstv_ConsultCards.Items)
            {
                string cpf = item.SubItems[col_ConsultCards_CPF.Index].Text;
                string card = item.SubItems[col_ConsultCards_Card.Index].Text;
                string id = item.SubItems[col_ConsultCards_ID.Index].Text;
                string name = item.SubItems[col_ConsultCards_Name.Index].Text;
                string type = item.SubItems[col_ConsultCards_Type.Index].Text;
                string cnpj = txt_ConsultCards_AutoBalance_CNPJ.Text;
                string unity = txt_ConsultCards_AutoBalance_Unity.Text;
                string search = cnpj + id + name.Substring(0, 3);

                sw.WriteLine($"{cpf}|{card}|{id}|{name}|{type}|{cnpj}|{unity}|{search}");
            }

            sw.Dispose();
            MessageBox.Show("Salvo");

            txt_ConsultCards_AutoBalance_CNPJ.Text = "";
            txt_ConsultCards_AutoBalance_Unity.Text = "";
            tbc_Main.SelectedTab = tbp_Browser;
            txt_ConsultCards_AutoBalance_CNPJ.Focus();

        }

        private async Task<GCS_Response> LoadCards()
        {
            GCS_Response gcs_response = new();
            try
            {
                lstv_ConsultCards.Items.Clear();
                StatusBar_lbl_Message.Text = "Carregando cartões...";

                foreach (ColumnHeader item in lstv_ConsultCards.Columns)
                {
                    if (item == col_ConsultCards_Card)
                    {
                        item.Width = 72;
                    }
                    else
                    {
                        item.Width = 0;
                    }
                }

                string card = "0000000000000";

                while (true)
                {
                    string url = $"https://www.cartaoriocard.com.br/vt2/comprador/relatorios/ListaRelacaoCartoes.do?nrTpFiltroOrdem=&tpFiltroOrdem=2&cdStatus=1&diaInicial=&mesInicial=&anoInicial=&diaFinal=&mesFinal=&anoFinal=&nrCartaoDe={card}&nrCartaoAte=";
                    LoadUrlAsyncResponse page = await wbs_Browser.LoadUrlAsync(url);

                    if (!page.Success)
                    {
                        gcs_response.ErroCode = "306504"; gcs_response.Message = "Aconteceu um erro!"; gcs_response.Success = false; return gcs_response;
                    }

                    var source = cl_Tools.TreatText(await wbs_Browser.GetSourceAsync());

                    if (source.Contains("NAO EXISTE USUARIO NA SESSAO"))
                    {
                        gcs_response.ErroCode = "913708"; gcs_response.Message = "Não existe usuário na sessão."; gcs_response.Success = false; return gcs_response;
                    }
                    else if (source.Contains("SUA SESSAO FOI EXPIRADA POR INATIVIDADE"))
                    {
                        gcs_response.ErroCode = "707420"; gcs_response.Message = "Sua sessão foi expirada por inatividade, favor autenticar-se novamente."; gcs_response.Success = false; return gcs_response;
                    }

                    string script = "(function(){let table=document.querySelector('#lancamento');let rows=table.querySelectorAll('tr');let data=[];for(let i=1;i<rows.length;i++){let row=rows[i];let cols=row.querySelectorAll('td');let colsData=[];for(let j=0;j<cols.length;j++){let col=cols[j];colsData.push(col.innerText)}data.push(colsData)}return data})();";
                    JavascriptResponse response = await wbs_Browser.EvaluateScriptAsync(script);

                    if (!response.Success)
                    {
                        gcs_response.ErroCode = "774395"; gcs_response.Success = false; return gcs_response; ;
                    }

                    dynamic obj = response.Result;

                    List<string> list_cards = new();

                    foreach (var item in obj)
                    {
                        string cardNumber = item[0];
                        //if (lstv_ConsultCards.Items.Cast<ListViewItem>().Where(item => item.SubItems[col_ConsultCards_Card.Index].Text == cardNumber).Count() > 0) { continue; }
                        if (list_cards.Contains(cardNumber)) { continue; }

                        list_cards.Add(cardNumber);

                        ListViewItem listviewitem = new();
                        listviewitem.Text = $""; // BUSCADOR
                        listviewitem.SubItems.Add($""); // CNPJ
                        listviewitem.SubItems.Add($""); // EMPRESA
                        listviewitem.SubItems.Add($""); // UNIDADE
                        listviewitem.SubItems.Add(cardNumber); // CARTAO
                        listviewitem.SubItems.Add($""); // MATRICULA
                        listviewitem.SubItems.Add($""); // NOME
                        listviewitem.SubItems.Add($""); // CPF
                        listviewitem.SubItems.Add($""); // SALDO
                        listviewitem.SubItems.Add($""); // DATA
                        listviewitem.SubItems.Add($""); // REC. PEND.
                        listviewitem.SubItems.Add($""); // PAGAMENTO

                        lstv_ConsultCards.Items.Add(listviewitem);
                    }

                    SortDataInListView(lstv_ConsultCards, new int[] { 4 });

                    if (obj.Count == 2000)
                    {
                        card = Regex.Replace(lstv_ConsultCards.Items[lstv_ConsultCards.Items.Count - 1].SubItems[4].Text, @"[^\d]", "");
                        continue;
                    }

                    break;
                }

                cl_Tools.AdjustColumnWidthInListView(lstv_ConsultCards, new int[] { 4 });
                return gcs_response; ;
            }
            catch (Exception)
            {
                gcs_response.ErroCode = "391846"; gcs_response.Success = false; return gcs_response; ;
            }
            finally
            {
                StatusBar_lbl_Message.Text = "";
            }
        }

        private async Task<GCS_Response> LoadCardData()
        {
            GCS_Response gcs_response = new();

            try
            {
                StatusBar_lbl_Message.Text = "Carregando dados dos cartões...";
                cl_Tools.AdjustColumnWidthInListView(lstv_ConsultCards, new int[] { col_ConsultCards_ID.Index,
                                                                                    col_ConsultCards_Name.Index,
                                                                                    col_ConsultCards_CPF.Index,
                                                                                    col_ConsultCards_Type.Index,
                                                                                    col_ConsultCards_Status.Index,
                                                                                    col_ConsultCards_Restriction.Index }
                );

                //int countBalance = 0;
                //int countError = 0;
                //progressBar.Maximum = lstv_ConsultCards.Items.Count;

                foreach (ListViewItem item in lstv_ConsultCards.Items)
                {
                    string card = Regex.Replace(item.SubItems[col_ConsultCards_Card.Index].Text, @"[^\d]", "");
                    string url = $"https://www.cartaoriocard.com.br/vt2/comprador/cartoes/ExibirDadosCartao.do?filtrar=&historico=false&nrCartao={card}&tipoPesquisa=&pesquisa=";
                    LoadUrlAsyncResponse page = await wbs_Browser.LoadUrlAsync(url);

                    if (!page.Success)
                    {
                        gcs_response.ErroCode = "174463"; gcs_response.Success = false; return gcs_response;
                    }

                    #region get type, status and restriction 
                    string script1 = "(function(){let a=document.querySelector('#tipoImpressaoLabel').innerText;let b=document.querySelector('#statusLabel').innerText;let c=document.querySelector('#restricaoLabel').innerText;return[a,b,c]})();";
                    JavascriptResponse response1 = await wbs_Browser.EvaluateScriptAsync(script1);
                    if (!response1.Success)
                    {
                        string source = cl_Tools.TreatText(await wbs_Browser.GetSourceAsync());

                        if (source.Contains("NENHUM CARTAO ENCONTRADO"))
                        {
                            continue;
                        }
                        else
                        {
                            gcs_response.ErroCode = "727063"; gcs_response.Success = false; return gcs_response;
                        }
                    }

                    dynamic obj1 = response1.Result;

                    string type = obj1[0].ToString();
                    string status = obj1[1].ToString();
                    string restriction = obj1[2].ToString();

                    if (cl_Tools.TreatText(status) == "FORA DE USO")
                    {
                        item.SubItems[col_ConsultCards_Type.Index].Text = type;
                        item.SubItems[col_ConsultCards_Status.Index].Text = status;
                        item.SubItems[col_ConsultCards_Restriction.Index].Text = restriction;
                        continue;
                    }
                    #endregion

                    #region get id, name and cpf 
                    string script2 = "(function(){let a=document.querySelector('#matriculaLabel').innerText;let b=document.querySelector('#nomeLabel').innerText;let c=document.querySelector('#cpfLabel').innerText;return[a,b,c]})();";
                    JavascriptResponse response2 = await wbs_Browser.EvaluateScriptAsync(script2);
                    if (!response2.Success)
                    {
                        gcs_response.ErroCode = "694929"; gcs_response.Success = false; return gcs_response;
                    }

                    dynamic obj2 = response2.Result;

                    string id = obj2[0].ToString();
                    string name = obj2[1].ToString();
                    string cpf = obj2[2].ToString();

                    #endregion

                    item.SubItems[col_ConsultCards_Type.Index].Text = cl_Riocard.TreatType(type);
                    item.SubItems[col_ConsultCards_Status.Index].Text = cl_Tools.TreatText(status);
                    item.SubItems[col_ConsultCards_Restriction.Index].Text = cl_Tools.TreatText(restriction);
                    item.SubItems[col_ConsultCards_ID.Index].Text = cl_Tools.TreatText(id);
                    item.SubItems[col_ConsultCards_Name.Index].Text = cl_Tools.TreatText(name);
                    item.SubItems[col_ConsultCards_CPF.Index].Text = cl_Tools.FormatCPF1(cpf, true);
                    await Task.Delay(Settings.delay);
                }

                cl_Tools.AdjustColumnWidthInListView(lstv_ConsultCards, new int[] { col_ConsultCards_ID.Index,
                                                                                    col_ConsultCards_Name.Index,
                                                                                    col_ConsultCards_CPF.Index,
                                                                                    col_ConsultCards_Type.Index,
                                                                                    col_ConsultCards_Status.Index,
                                                                                    col_ConsultCards_Restriction.Index }
                );

                return gcs_response;
            }
            catch (Exception)
            {
                gcs_response.ErroCode = "739343"; gcs_response.Success = false; return gcs_response;
            }
            finally
            {
                StatusBar_lbl_Message.Text = "";
            }
        }

        private async void LoadCards_Backup()
        {
            lstv_ConsultCards.Items.Clear();

            foreach (ColumnHeader item in lstv_ConsultCards.Columns)
            {
                if (item == col_ConsultCards_Card)
                {
                    item.Width = 72;
                }
                else
                {
                    item.Width = 0;
                }
            }


            List<Button> buttons = new()
            {
                btn_ConsultCards_LoadCards,
                btn_ConsultCards_LoadCardData,
                btn_ConsultCards_SaveCardBalance
            };

            try
            {
                tblp_ConsultCards.Enabled = false;
                cl_Tools.DesableButtons(buttons);

                //cl_Tools.AdjustColumnWidthInListView(lstv_Main, new int[] { 3 }, 92);

                //int countBalance = 0;
                //int countError = 0;
                //progressBar.Maximum = lstv_ConsultCards.Items.Count;

                string card = "0000000000000";

                while (true)
                {
                    string url = $"https://www.cartaoriocard.com.br/vt2/comprador/relatorios/ListaRelacaoCartoes.do?nrTpFiltroOrdem=&tpFiltroOrdem=2&cdStatus=1&diaInicial=&mesInicial=&anoInicial=&diaFinal=&mesFinal=&anoFinal=&nrCartaoDe={card}&nrCartaoAte=";
                    LoadUrlAsyncResponse page = await wbs_Browser.LoadUrlAsync(url);

                    if (!page.Success) { MessageBox.Show("ERROR: 148720", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                    var source = cl_Tools.TreatText(await wbs_Browser.GetSourceAsync());

                    if (source.Contains("NAO EXISTE USUARIO NA SESSAO"))
                    {
                        tbc_Main.SelectedTab = tbp_Browser;
                        MessageBox.Show("Não existe usuário na sessão", "ERROR: 294200", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (source.Contains("SUA SESSAO FOI EXPIRADA POR INATIVIDADE"))
                    {
                        tbc_Main.SelectedTab = tbp_Browser;
                        MessageBox.Show("Sua sessão foi expirada por inatividade, favor autenticar-se novamente.", "ERROR: 891945", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string script = "(function(){let table=document.querySelector('#lancamento');let rows=table.querySelectorAll('tr');let data=[];for(let i=1;i<rows.length;i++){let row=rows[i];let cols=row.querySelectorAll('td');let colsData=[];for(let j=0;j<cols.length;j++){let col=cols[j];colsData.push(col.innerText)}data.push(colsData)}return data})();";
                    JavascriptResponse response = await wbs_Browser.EvaluateScriptAsync(script);

                    if (!response.Success) { MessageBox.Show("ERROR: 138097"); return; }

                    dynamic obj = response.Result;

                    List<string> list_cards = new();

                    foreach (var item in obj)
                    {
                        string cardNumber = item[0];
                        //if (lstv_ConsultCards.Items.Cast<ListViewItem>().Where(item => item.SubItems[col_ConsultCards_Card.Index].Text == cardNumber).Count() > 0) { continue; }
                        if (list_cards.Contains(cardNumber)) { continue; }

                        list_cards.Add(cardNumber);

                        ListViewItem listviewitem = new();
                        listviewitem.Text = $""; // BUSCADOR
                        listviewitem.SubItems.Add($""); // CNPJ
                        listviewitem.SubItems.Add($""); // EMPRESA
                        listviewitem.SubItems.Add($""); // UNIDADE
                        listviewitem.SubItems.Add(cardNumber); // CARTAO
                        listviewitem.SubItems.Add($""); // MATRICULA
                        listviewitem.SubItems.Add($""); // NOME
                        listviewitem.SubItems.Add($""); // CPF
                        listviewitem.SubItems.Add($""); // SALDO
                        listviewitem.SubItems.Add($""); // DATA
                        listviewitem.SubItems.Add($""); // REC. PEND.
                        listviewitem.SubItems.Add($""); // PAGAMENTO

                        lstv_ConsultCards.Items.Add(listviewitem);

                    }

                    SortDataInListView(lstv_ConsultCards, new int[] { 4 });

                    if (obj.Count == 2000)
                    {
                        card = Regex.Replace(lstv_ConsultCards.Items[lstv_ConsultCards.Items.Count - 1].SubItems[4].Text, @"[^\d]", "");
                        continue;
                    }

                    break;
                }

                cl_Tools.AdjustColumnWidthInListView(lstv_ConsultCards, new int[] { 4 });
                cl_Alert.Alert("Cartões carregados!", frm_Alert.enmType.Success);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: 958502", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cl_Alert.Alert("ERROR: 958502", frm_Alert.enmType.Error);
            }
            finally
            {
                //progressBar.Value = 0;
                //lbl_percentage.Text = "0%";
                tblp_ConsultCards.Enabled = true;
                cl_Tools.EnableButtons(buttons);
            }
        }

        private async void LoadCardData_Backup()
        {
            List<Button> buttons = new()
            {
                btn_ConsultCards_LoadCards,
                btn_ConsultCards_LoadCardData,
                btn_ConsultCards_SaveCardBalance
            };

            try
            {
                tblp_ConsultCards.Enabled = false;
                cl_Tools.DesableButtons(buttons);

                cl_Tools.AdjustColumnWidthInListView(lstv_ConsultCards, new int[] { col_ConsultCards_ID.Index,
                                                                                    col_ConsultCards_Name.Index,
                                                                                    col_ConsultCards_CPF.Index,
                                                                                    col_ConsultCards_Type.Index,
                                                                                    col_ConsultCards_Status.Index,
                                                                                    col_ConsultCards_Restriction.Index }
                );

                //int countBalance = 0;
                //int countError = 0;
                //progressBar.Maximum = lstv_ConsultCards.Items.Count;

                foreach (ListViewItem item in lstv_ConsultCards.Items)
                {
                    string card = Regex.Replace(item.SubItems[col_ConsultCards_Card.Index].Text, @"[^\d]", "");
                    string url = $"https://www.cartaoriocard.com.br/vt2/comprador/cartoes/ExibirDadosCartao.do?filtrar=&historico=false&nrCartao={card}&tipoPesquisa=&pesquisa=";
                    LoadUrlAsyncResponse page = await wbs_Browser.LoadUrlAsync(url);
                    if (!page.Success) { MessageBox.Show("ERROR: 568920", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                    #region get type, status and restriction 
                    string script1 = "(function(){let a=document.querySelector('#tipoImpressaoLabel').innerText;let b=document.querySelector('#statusLabel').innerText;let c=document.querySelector('#restricaoLabel').innerText;return[a,b,c]})();";
                    JavascriptResponse response1 = await wbs_Browser.EvaluateScriptAsync(script1);
                    if (!response1.Success)
                    {
                        string source = cl_Tools.TreatText(await wbs_Browser.GetSourceAsync());

                        if (source.Contains("NENHUM CARTAO ENCONTRADO"))
                        {
                            continue;
                        }
                        else
                        {
                            MessageBox.Show("ERROR: 904105");
                            return;
                        }
                    }

                    dynamic obj1 = response1.Result;

                    string type = obj1[0].ToString();
                    string status = obj1[1].ToString();
                    string restriction = obj1[2].ToString();

                    if (cl_Tools.TreatText(status) == "FORA DE USO")
                    {
                        item.SubItems[col_ConsultCards_Type.Index].Text = type;
                        item.SubItems[col_ConsultCards_Status.Index].Text = status;
                        item.SubItems[col_ConsultCards_Restriction.Index].Text = restriction;
                        continue;
                    }
                    #endregion

                    #region get id, name and cpf 
                    string script2 = "(function(){let a=document.querySelector('#matriculaLabel').innerText;let b=document.querySelector('#nomeLabel').innerText;let c=document.querySelector('#cpfLabel').innerText;return[a,b,c]})();";
                    JavascriptResponse response2 = await wbs_Browser.EvaluateScriptAsync(script2);
                    if (!response2.Success) { MessageBox.Show("ERROR: 312588"); return; }

                    dynamic obj2 = response2.Result;

                    string id = obj2[0].ToString();
                    string name = obj2[1].ToString();
                    string cpf = obj2[2].ToString();

                    #endregion

                    item.SubItems[col_ConsultCards_Type.Index].Text = cl_Riocard.TreatType(type);
                    item.SubItems[col_ConsultCards_Status.Index].Text = cl_Tools.TreatText(status);
                    item.SubItems[col_ConsultCards_Restriction.Index].Text = cl_Tools.TreatText(restriction);
                    item.SubItems[col_ConsultCards_ID.Index].Text = id;
                    item.SubItems[col_ConsultCards_Name.Index].Text = name;
                    item.SubItems[col_ConsultCards_CPF.Index].Text = cl_Tools.FormatCPF1(cpf, true);
                }

                cl_Tools.AdjustColumnWidthInListView(lstv_ConsultCards, new int[] { col_ConsultCards_ID.Index,
                                                                                    col_ConsultCards_Name.Index,
                                                                                    col_ConsultCards_CPF.Index,
                                                                                    col_ConsultCards_Type.Index,
                                                                                    col_ConsultCards_Status.Index,
                                                                                    col_ConsultCards_Restriction.Index }
                );
                cl_Alert.Alert("Dados carregados!", frm_Alert.enmType.Success);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: 400878", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cl_Alert.Alert("ERROR: 400878", frm_Alert.enmType.Error);
            }
            finally
            {
                //progressBar.Value = 0;
                //lbl_percentage.Text = "0%";
                tblp_ConsultCards.Enabled = true;
                cl_Tools.EnableButtons(buttons);
            }
        }


        private void SortDataInListView(ListView listView, int[] columns)
        {
            foreach (int column in columns)
            {
                lvwColumnSorter.SortColumn = column;
                lvwColumnSorter.Order = SortOrder.Ascending;
                listView.Sort();
            }
        }

        private void tsmi_Tools_Consult_Balance_Click(object sender, EventArgs e)
        {

        }

        private void StatusBar_btn_SideBar_Click(object sender, EventArgs e)
        {
            if (pnl_SideBar.Visible == false) { tbc_SideBar.SelectedTab = SideBar_tbp_Data; pnl_SideBar.Visible = true; } else { pnl_SideBar.Visible = false; }
        }

        private void pnl_SideBar_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_SideBar.Visible == true) { StatusBar_btn_SideBar.Text = "Ocultar SideBar"; } else { StatusBar_btn_SideBar.Text = "Mostrar SideBar"; }
        }

        private void tsmi_Tools_Consult_Card_Click(object sender, EventArgs e)
        {
            tbc_Main.SelectedTab = tbp_ConsultCards;
        }

        private void tsmi_Tools_Consult_Users_Click(object sender, EventArgs e)
        {
            tbc_SideBar.SelectedTab = SideBar_tbp_SearchUsers;
            pnl_SideBar.Visible = true;
        }

        private async void btn_Sidebar_Data_Main_AutoConsult_Start_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new()
            {
                btn_ConsultCards_LoadCards,
                btn_ConsultCards_LoadCardData,
                btn_ConsultCards_SaveCardBalance
            };

            tblp_ConsultCards.Enabled = false;
            cl_Tools.DesableButtons(buttons);



            GCS_Response gcs_response = await LoadCards();

            if (!gcs_response.Success)
            {
                if (gcs_response.Message == "")
                {
                    MessageBox.Show("Aconteceu um erro!", $"ERROR: {gcs_response.ErroCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(gcs_response.Message, $"ERROR: {gcs_response.ErroCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cl_Alert.Alert($"ERROR: {gcs_response.ErroCode}", frm_Alert.enmType.Error);
                tblp_ConsultCards.Enabled = true;
                cl_Tools.EnableButtons(buttons);
                return;
            }

            gcs_response = await LoadCardData();

            if (!gcs_response.Success)
            {
                if (gcs_response.Message == "")
                {
                    MessageBox.Show("Aconteceu um erro!", $"ERROR: {gcs_response.ErroCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(gcs_response.Message, $"ERROR: {gcs_response.ErroCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cl_Alert.Alert($"ERROR: {gcs_response.ErroCode}", frm_Alert.enmType.Error);
                tblp_ConsultCards.Enabled = true;
                cl_Tools.EnableButtons(buttons);
                return;
            }

            SaveTemp();

            tblp_ConsultCards.Enabled = true;
            cl_Tools.EnableButtons(buttons);
            cl_Alert.Alert("Cartões e Dados carregados!", frm_Alert.enmType.Success);
        }

        private void btn_Sidebar_Data_Main_AutoConsult_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sidebar_Data_Main_AutoConsult_Remove_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sidebar_Data_Main_AutoConsult_497761_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sidebar_Data_Main_AutoConsult_Clear_Click(object sender, EventArgs e)
        {

        }

        private void Header_chk_AutoReload_CheckedChanged(object sender, EventArgs e)
        {
            Settings.autoReload = Header_chk_AutoReload.Checked;
        }

        private async void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            await wbs_Browser.LoadUrlAsync("https://www.cartaoriocard.com.br/vt2/comprador/pedidos/ImportacaoPedido.do");
        }

        private async void importarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await wbs_Browser.LoadUrlAsync("https://www.cartaoriocard.com.br/vt2/comprador/usuarios/ImportarUsuarios.do");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tbc_SideBar.SelectedTab = SideBar_tbp_SearchUsers;
            pnl_SideBar.Visible = true;
        }

        private async void toolStripButton2_Click(object sender, EventArgs e)
        {
            await wbs_Browser.LoadUrlAsync("https://www.cartaoriocard.com.br/vt2/comprador/pedidos/GerenciamentoPedidos.do");
        }

        private void lstv_SearchUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lstv_SearchUsers.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                UserInfoData user = new()
                {
                    Matricula = item.SubItems[0].Text,
                    Nome = item.SubItems[1].Text,
                    Cpf = item.SubItems[2].Text,
                    Status = cl_Tools.TreatText(item.SubItems[3].Text),
                    NrDoCartao = cl_Tools.TreatText(item.SubItems[4].Text),
                    StatusBu = cl_Tools.TreatText(item.SubItems[5].Text),
                    PassagemInterRodoviaria = cl_Tools.TreatText(item.SubItems[6].Text),
                    Obs = item.SubItems[7].Text,
                    Data = item.SubItems[8].Text,
                };

                frm_UserInfo frm = new(user, listOfMultipleUsers);
                frm.ShowDialog();
            }
        }
    }

    public static class WebBrowserExtensions
    {
        public static Task LoadPageAsync(this IWebBrowser browser, string? address = null)
        {
            var tcs = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);

            EventHandler<LoadingStateChangedEventArgs>? handler = null;
            handler = (sender, args) =>
            {
                //Wait for while page to finish loading not just the first frame
                //Aguarde enquanto a p�gina terminar de carregar n�o apenas o primeiro quadro
                if (!args.IsLoading)
                {
                    browser.LoadingStateChanged -= handler;
                    //Important that the continuation runs async using TaskCreationOptions.RunContinuationsAsynchronously
                    //Importante que a continua��o seja executada de forma ass�ncrona usando TaskCreationOptions.RunContinuationsAsynchronously
                    tcs.TrySetResult(true);
                }
            };

            browser.LoadingStateChanged += handler;

            if (!string.IsNullOrEmpty(address))
            {
                browser.Load(address);
            }

            return tcs.Task;
        }
    }


    public class GCS_Response
    {
        public string ErroCode { get; set; } = "";
        public string Message { get; set; } = "";
        public bool Success { get; set; } = true;
    }
}