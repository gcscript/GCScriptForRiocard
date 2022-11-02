using utilities;
using GCScriptForRiocard.Data;
using GCScriptForRiocard.Models;

namespace GCScriptForRiocard
{
    public partial class frm_UserInfo : Form
    {
        private UserInfoData _userInfoData;
        private List<ListarUsuario> _listOfMultipleUsers;

        public frm_UserInfo(UserInfoData userInfoData, List<ListarUsuario> listOfMultipleUsers)
        {
            InitializeComponent();
            _userInfoData = userInfoData;
            _listOfMultipleUsers = listOfMultipleUsers;

            Button cancelBTN = new Button();
            cancelBTN.Size = new Size(0, 0);
            cancelBTN.TabStop = false;
            this.Controls.Add(cancelBTN);
            this.CancelButton = cancelBTN;
        }

        private void frm_UserInfo_Load(object sender, EventArgs e)
        {
            txt_Matricula.Text = _userInfoData.Matricula;
            txt_Nome.Text = _userInfoData.Nome;
            txt_Cpf.Text = _userInfoData.Cpf;
            txt_Status.Text = _userInfoData.Status;
            txt_NrDoCartao.Text = _userInfoData.NrDoCartao;
            txt_StatusBu.Text = _userInfoData.StatusBu;
            txt_PassagemInterRodoviaria.Text = _userInfoData.PassagemInterRodoviaria;
            txt_Obs.Text = _userInfoData.Obs;
            lbl_Data.Text = _userInfoData.Data;

            lbl_Data.Focus();

            DefinirStatus();

            if (txt_Matricula.Text != "")
            {
                Clipboard.SetText(txt_Matricula.Text);
            }

            foreach (var user in _listOfMultipleUsers)
            {
                ListViewItem listviewitem = new();
                listviewitem.Text = user.Matricula;
                listviewitem.SubItems.Add(user.Nome);
                listviewitem.SubItems.Add(user.Cpf);
                listviewitem.SubItems.Add(user.Status);
                listviewitem.SubItems.Add(user.NrDoCartao);
                listviewitem.SubItems.Add(user.StatusBu);
                listviewitem.SubItems.Add(user.Pir);

                lstv_Users.Items.Add(listviewitem);
            }
            cl_Tools.AdjustColumnWidthInListView(lstv_Users);

        }

        private void DefinirStatus()
        {
            if (txt_Status.Text == "" && txt_Obs.Text.Contains("RESULTADOS"))
            {
                lbl_Result.Text = "VERIFIQUE MANUALMENTE";
            }
            else if (txt_Status.Text == "" && txt_Obs.Text.Contains("O CPF INFORMADO E INVALIDO"))
            {
                lbl_Result.Text = "CPF INCORRETO";
            }
            else if (txt_Status.Text == "" && txt_Obs.Text.Contains("NENHUM USUARIO CADASTRADO PARA ESTA CONDICAO"))
            {
                lbl_Result.Text = "SEM CADASTRO";
            }
            else if (txt_Matricula.Text != "" && txt_Nome.Text != "" && txt_Status.Text == "ATIVO" && txt_NrDoCartao.Text.Length > 2)
            {
                lbl_Result.Text = "SEM PROBLEMAS";
            }
            else if (txt_Matricula.Text != "" && txt_Nome.Text != "" && txt_Status.Text == "ATIVO" && txt_NrDoCartao.Text.Length < 2)
            {
                lbl_Result.Text = "NOVO/SEM CARTAO";
            }
            else if (txt_Matricula.Text != "" && txt_Nome.Text != "" && txt_Status.Text == "INATIVO" && txt_NrDoCartao.Text.Length < 2)
            {
                lbl_Result.Text = "INATIVO";
            }

            switch (lbl_Result.Text)
            {
                case "SEM PROBLEMAS":
                    lbl_Result.ForeColor = Color.Green;
                    break;
                case "VERIFIQUE MANUALMENTE":
                    lbl_Result.ForeColor = Color.Orange;
                    break;
                default:
                    lbl_Result.ForeColor = Color.Red;
                    break;
            }
        }

        private void txt_NrDoCartao_TextChanged(object sender, EventArgs e)
        {
            if (txt_NrDoCartao.Text == "-")
            {
                txt_NrDoCartao.Text = "";
            }
        }

        private void SetClipboard(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                var text = textBox.Text;
                if (textBox.Name == "txt_Cpf") text = cl_Tools.FormatCPF1(text);
                Clipboard.SetText(text);
                if (lbl_Message.Text == "") SetMessage("Texto Copiado com Sucesso!");
            }
        }

        private async void SetMessage(string text)
        {
            lbl_Message.Text = text;
            await Task.Delay(3000);
            lbl_Message.Text = "";
        }

        private void lstv_Users_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lstv_Users.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                txt_Matricula.Text = item.SubItems[0].Text;
                txt_Nome.Text = item.SubItems[1].Text;
                txt_Cpf.Text = item.SubItems[2].Text;
                txt_Status.Text = cl_Tools.TreatText(item.SubItems[3].Text);
                txt_NrDoCartao.Text = cl_Tools.TreatText(item.SubItems[4].Text);
                txt_StatusBu.Text = cl_Tools.TreatText(item.SubItems[5].Text);
                txt_PassagemInterRodoviaria.Text = cl_Tools.TreatText(item.SubItems[6].Text);
                txt_Obs.Text = null;
                DefinirStatus();
            }

            if (txt_Matricula.Text != "")
            {
                Clipboard.SetText(txt_Matricula.Text);
            }
        }

        private void txt_Matricula_DoubleClick(object sender, EventArgs e) => SetClipboard(txt_Matricula);
        private void txt_Nome_DoubleClick(object sender, EventArgs e) => SetClipboard(txt_Nome);

        private void txt_Cpf_DoubleClick(object sender, EventArgs e) => SetClipboard(txt_Cpf);

        private void txt_Status_DoubleClick(object sender, EventArgs e) => SetClipboard(txt_Status);

        private void txt_NrDoCartao_DoubleClick(object sender, EventArgs e) => SetClipboard(txt_NrDoCartao);

        private void txt_StatusBu_DoubleClick(object sender, EventArgs e) => SetClipboard(txt_StatusBu);

        private void txt_PassagemInterRodoviaria_DoubleClick(object sender, EventArgs e) => SetClipboard(txt_PassagemInterRodoviaria);

        private void txt_Obs_DoubleClick(object sender, EventArgs e) => SetClipboard(txt_Obs);

        private void lbl_Result_DoubleClick(object sender, EventArgs e) { if (lbl_Result.Text != "") Clipboard.SetText(lbl_Result.Text); if (lbl_Message.Text == "") SetMessage("Texto Copiado com Sucesso!"); }
    }
}
