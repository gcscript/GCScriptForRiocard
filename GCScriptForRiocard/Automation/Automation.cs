using CefSharp.WinForms;
using CefSharp;
using utilities;
using System.Text.RegularExpressions;
using GCScriptForRiocard.Data;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using CefSharp.DevTools.Network;
using System.Net.Http.Json;
using System.Text.Json;
using GCScriptForRiocard.Models;

namespace GCScriptForRiocard.Automation
{
    class Automation
    {
        private ChromiumWebBrowser _browser { get; set; }

        public Automation(ChromiumWebBrowser browser)
        {
            _browser = browser;
        }

        public async Task Start(string url)
        {
            if (url.Contains("PesquisarUsuario.do")) PesquisarUsuario();
            else if (url.Contains("UploadImportacaoPedido.do")) await UploadImportacaoPedido();
            //else if (url.Contains("ListaRelacaoCartoes.do")) ListaRelacaoCartoes();
            else if (url.Contains("ImportarUsuarios.do")) await ImportarUsuarios();
            else if (url.Contains("ImportacaoPedido.do")) await ImportacaoPedido();
            else if (url.Contains("GerenciamentoPedidos.do")) await GerenciamentoPedidos();
            // FECHAR PEDIDO
            else if (url.Contains("IniciarEntregaPedido.do")) await IniciarEntregaPedido();
            else if (url.Contains("IniciarFechamentoPedido.do")) await IniciarFechamentoPedido();
            else if (url.Contains("IniciarPagamentoPedido.do")) await IniciarPagamentoPedido();
            else if (url.Contains("RealizaPagamentoPedido.do")) await RealizaPagamentoPedido();
        }

        private async Task ImportacaoPedido()
        {
            string pedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ped.txt");
            if (File.Exists(pedPath))
            {
                try
                {
                    await Task.Delay(1000);
                    _browser.DialogHandler = new CustomFileDialogHandler(new List<string> { pedPath });
                    string script = "(function() { let element = document.querySelector('input[type=file]'); let el = element.getBoundingClientRect(); return JSON.stringify({x: el.left, y: el.top}); })();";
                    var response = await _browser.EvaluateScriptAsync(script);

                    if (!response.Success) return;

                    var json = JsonSerializer.Deserialize<Coordinates>(response.Result.ToString());

                    int positionX = (int)json.x + 10;
                    int positionY = (int)json.y + 10;

                    await Task.Delay(1000);
                    _browser.GetBrowser()
                            .GetHost()
                            .SendMouseClickEvent(x: positionX,
                                                 y: positionY,
                                                 mouseButtonType: MouseButtonType.Left,
                                                 mouseUp: false,
                                                 clickCount: 1,
                                                 modifiers: CefEventFlags.None);

                    Thread.Sleep(millisecondsTimeout: 50);

                    _browser.GetBrowser()
                            .GetHost()
                            .SendMouseClickEvent(x: positionX,
                                                 y: positionY,
                                                 mouseButtonType: MouseButtonType.Left,
                                                 mouseUp: true,
                                                 clickCount: 1,
                                                 modifiers: CefEventFlags.None);

                    await Task.Delay(1000);
                    string script2 = "submeterForm()";
                    var response2 = await _browser.EvaluateScriptAsync(script2);
                }
                catch (Exception)
                {
                    MessageBox.Show($"Erro ao importar arquivo de pedido", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private async Task RealizaPagamentoPedido()
        {
            await Task.Delay(1000);

            string script = "(function() { let el = document.querySelectorAll('a'); let nrPed1; let nrPed2; for (let i = 0; i < el.length; i++) { if (el[i].href.includes('UltimaEtapaPedido')) { nrPed1 = el[i].href.match(/nrPedido=([0-9]{8})/)[1]; } else if (el[i].href.includes('IniciarPagamentoPedido')) { nrPed2 = el[i].href.match(/nrPedido=([0-9]{8})/)[1]; } } return JSON.stringify({nrPedido1: nrPed1, nrPedido2: nrPed2}); })();";
            var response = await _browser.EvaluateScriptAsync(script);

            if (!response.Success) return;


            var source = cl_Tools.TreatText(await _browser.GetSourceAsync());
            var match = Regex.Match(source, @"NRPEDIDO=([0-9]{8})");

            if (!match.Success) { MessageBox.Show($"Erro ao Capturar o Numero do Pedido", "E_614651", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return; }

            string result = match.Groups[1].Value;

            if (result == "") { MessageBox.Show($"Número do pedido não encontrado!", "E_113949", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); }
            await _browser.LoadUrlAsync($"https://www.cartaoriocard.com.br/vt2/comprador/pedidos/ImpressaoPedido.do?nrPedido={result}");

            await _browser.PrintToPdfAsync(Path.Combine(Settings.purchaseDirectory, "RJ - RIOCARD - ADM - Resumo.pdf"));

            var urlBoleto = $"https://www.cartaoriocard.com.br/vt2/comprador/pedidos/UltimaEtapaPedido.do?nrPedido={result}";

            await _browser.LoadUrlAsync(urlBoleto);

            var ds = new DownloadSettings
            {
                ShowDialog = false,
                Directory = Settings.purchaseDirectory,
                FileName = $"RJ - RIOCARD - ADM - Boleto.pdf",
            };

            _browser.DownloadHandler = new CustomDownloadHandler(ds);
            _browser.StartDownload(urlBoleto);
            //MessageBox.Show($"Resumo Salvo com Sucesso!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //MessageBox.Show($"  asdadsads", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private async Task GerenciamentoPedidos()
        {
            string script = "setTimeout((function(){document.documentElement.innerHTML.toUpperCase().indexOf('EM PROCESSO DE IMPORTAÇÃO')>-1&&location.reload()}),1e3);";
            await _browser.EvaluateScriptAsync(script);
        }

        private void ListaRelacaoCartoes()
        {
            //string script = "(function(){let table=document.querySelector('#lancamento');let rows=table.querySelectorAll('tr');let data=[];for(let i=1;i<rows.length;i++){let row=rows[i];let cols=row.querySelectorAll('td');let colsData=[];for(let j=0;j<cols.length;j++){let col=cols[j];colsData.push(col.innerText)}data.push(colsData)}return data})();";
            //JavascriptResponse response = await _browser.EvaluateScriptAsync(script);
            //int i = 0;
        }

        private async Task ImportarUsuarios()
        {
            string script = "document.getElementById('aceitoTermoComodato').checked=!0;";
            await _browser.EvaluateScriptAsync(script);
        }

        private async Task IniciarEntregaPedido()
        {
            var source = cl_Tools.TreatText(await _browser.GetSourceAsync());

            if (source.Contains("EXISTEM ERROS NA PAGINA"))
            {
                MessageBox.Show($"Existem erros na página", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            else if (source.Contains("ESCOLHA A FORMA DE ENTREGA"))
            {
                MessageBox.Show($"Escolha a forma de entrega!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                string script = "salvarEstadoDoPedido('continuar')";
                await _browser.EvaluateScriptAsync(script);
            }
        }

        private async Task IniciarFechamentoPedido()
        {
            var source = cl_Tools.TreatText(await _browser.GetSourceAsync());

            if (source.Contains("SHOWDIALOGDIVIDIRPEDIDO('FALSE')"))
            {
                string script = "showDialogDividirPedido('false')";
                await _browser.EvaluateScriptAsync(script);
            }
        }

        private async Task IniciarPagamentoPedido()
        {
            string script = "setTimeout((function(){document.getElementById('escolhidoBoleto').click(),document.getElementById('finalizarPagamentoForm').submit()}),300);";
            await _browser.EvaluateScriptAsync(script);
        }

        private async Task UploadImportacaoPedido()
        {
            await _browser.LoadUrlAsync($"https://www.cartaoriocard.com.br/vt2/comprador/pedidos/GerenciamentoPedidos.do");
        }

        private void PesquisarUsuario()
        {
            _browser.ExecuteScriptAsyncWhenPageLoaded($"document.getElementById('campoStatusUsuario').value='',document.getElementById('tpFiltroUsuario').value={Settings.searchUserFilter},document.getElementById('campoPalavraChave').select();");
        }
    }
}
