using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilities
{
    public class cl_ExcelFunctions
    {
        public void SetWorksheetHeaders(IXLWorksheet ws, List<string> headers)
        {
            IXLRange headerRow = ws.Range(ws.Cell(1, 1), ws.Cell(1, headers.Count));
            headerRow.Style.Font.Bold = true;
            headerRow.Style.NumberFormat.Format = "@";

            headerRow.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

            foreach (string header in headers)
            {
                IXLCell cell = ws.Cell(1, headers.IndexOf(header) + 1);
                IXLRange rng = ws.Range(cell, cell);
                ws.Cell(1, headers.IndexOf(header) + 1).Value = header;

                if (cl_Tools.TreatText(header) != "NOME")
                {
                    if (cl_Tools.TreatText(header) == "CPF")
                    {
                        Styles_Bootstrap(rng, 1, true);
                    }
                    else if (cl_Tools.TreatText(header) == "SALDO")
                    {
                        Styles_Bootstrap(rng, 3, true);
                    }
                    else if (cl_Tools.TreatText(header) == "CARTAO")
                    {
                        Styles_Bootstrap(rng, 5, true);
                    }
                    else
                    {
                        Styles_Emphasis(rng, 3);
                    }

                    rng.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                }
                else
                {
                    rng.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                    Styles_Emphasis(rng, 3);
                }
            }
        }

        public void SetDottedBorders(IXLRange rng)
        {
            rng.Style.Border.TopBorder = XLBorderStyleValues.Dotted;
            rng.Style.Border.BottomBorder = XLBorderStyleValues.Dotted;
            rng.Style.Border.LeftBorder = XLBorderStyleValues.Dotted;
            rng.Style.Border.RightBorder = XLBorderStyleValues.Dotted;
            rng.Style.Border.InsideBorder = XLBorderStyleValues.Dotted;
        }

        public void SetView(IXLWorksheet ws)
        {
            IXLSheetView view = ws.SheetView;
            view.View = XLSheetViewOptions.PageBreakPreview;
            view.ZoomScale = 100;
        }

        public void SetPrintArea(IXLRange rng)
        {
            IXLWorksheet ws = rng.Worksheet;
            ws.PageSetup.PrintAreas.Add(rng.RangeAddress.ToString());
        }

        public void Styles_Colors(IXLRange rng, int color, bool bold = false)
        {
            // 1 = Primary
            // 2 = Secondary
            // 3 = Success
            // 4 = Danger
            // 5 = Warning
            // 6 = Info

            switch (color)
            {
                case 1:
                    BackgroundColor(rng, "#99BCFF");
                    FontColor(rng, "#002365");
                    break;
                case 2:
                    BackgroundColor(rng, "#C8CCCF");
                    FontColor(rng, "#2F3336");
                    break;
                case 3:
                    BackgroundColor(rng, "#B4E3B8");
                    FontColor(rng, "#1B4A1F");
                    break;
                case 4:
                    BackgroundColor(rng, "#EDAAB1");
                    FontColor(rng, "#541118");
                    break;
                case 5:
                    BackgroundColor(rng, "#FCE49B");
                    FontColor(rng, "#634B02");
                    break;
                case 6:
                    BackgroundColor(rng, "#B0DEE7");
                    FontColor(rng, "#17454E");
                    break;
                default:
                    break;
            }
            rng.Style.Font.Bold = bold;
        }

        public void Styles_Bootstrap(IXLRange rng, int color, bool bold = false)
        {
            // 1 = Primary
            // 2 = Secondary
            // 3 = Success
            // 4 = Danger
            // 5 = Warning
            // 6 = Info
            // 7 = Light
            // 8 = Dark
            // 9 = White

            switch (color)
            {
                case 1:
                    BackgroundColor(rng, "#007BFF"); // bg-primary
                    FontColor(rng, "#FFFFFF"); // text-white
                    break;
                case 2:
                    BackgroundColor(rng, "#6C757D"); // bg-secondary
                    FontColor(rng, "#FFFFFF"); // text-white
                    break;
                case 3:
                    BackgroundColor(rng, "#28A745"); // bg-success
                    FontColor(rng, "#FFFFFF"); // text-white
                    break;
                case 4:
                    BackgroundColor(rng, "#DC3545"); // bg-danger
                    FontColor(rng, "#FFFFFF"); // text-white
                    break;
                case 5:
                    BackgroundColor(rng, "#FFC107"); // bg-warning
                    FontColor(rng, "#343A40"); // text-dark
                    break;
                case 6:
                    BackgroundColor(rng, "#17A2B8"); // bg-info
                    FontColor(rng, "#FFFFFF"); // text-white
                    break;
                case 7:
                    BackgroundColor(rng, "#F8F9FA"); // bg-light
                    FontColor(rng, "#343A40"); // text-dark
                    break;
                case 8:
                    BackgroundColor(rng, "#343A40"); // bg-dark
                    FontColor(rng, "#FFFFFF"); // text-white
                    break;
                case 9:
                    BackgroundColor(rng, "#FFFFFF"); // bg-white
                    FontColor(rng, "#343A40"); // text-dark
                    break;
                default:
                    break;
            }
            rng.Style.Font.Bold = bold;
        }

        public void Styles_Emphasis(IXLRange rng, int color, bool bold = true)
        {
            switch (color)
            {
                case 1:
                    BackgroundColor(rng, "#999999");
                    FontColor(rng, "#FFFFFF");
                    break;
                case 2:
                    BackgroundColor(rng, "#727272");
                    FontColor(rng, "#FFFFFF");
                    break;
                case 3:
                    BackgroundColor(rng, "#4C4C4C");
                    FontColor(rng, "#FFFFFF");
                    break;
                case 4:
                    BackgroundColor(rng, "#262626");
                    FontColor(rng, "#FFFFFF");
                    break;
                case 5:
                    BackgroundColor(rng, "#000000");
                    FontColor(rng, "#FFFFFF");
                    break;
                default:
                    break;
            }
            rng.Style.Font.Bold = bold;
        }

        public void BackgroundColor(IXLRange rng, string htmlColor)
        {
            rng.Style.Fill.BackgroundColor = XLColor.FromHtml(htmlColor);
        }

        public void FontColor(IXLRange rng, string htmlColor)
        {
            rng.Style.Font.FontColor = XLColor.FromHtml(htmlColor);
        }


        public void SaveWorksheet(string opUF, string opName, ListView listView, List<object> content)
        {
            string dateTimeNow = DateTime.Now.ToString("yyyy-MM-dd");

            #region SaveFileDialog
            SaveFileDialog sfdSalvar = new();
            sfdSalvar.Title = "Salvar como";
            sfdSalvar.Filter = "Arquivo de Excel|*.xlsx";
            //sfdSalvar.FileName = $"_{opUF}-{opName}_{dateTimeNow}";
            sfdSalvar.FileName = $"_RJ_RIOCARD_SEARCH_USERS";
            if (sfdSalvar.ShowDialog() != DialogResult.OK) { return; }
            string dirSalvar = sfdSalvar.FileName;
            #endregion

            using (XLWorkbook wb = new())
            {
                cl_ExcelFunctions excelFunctions = new();
                IXLWorksheet ws = wb.Worksheets.Add(dateTimeNow);

                // RANGES
                List<IXLRange> rngList = new();
                for (int i = 0; i < listView.Columns.Count; i++)
                {
                    rngList.Add(ws.Range(ws.Cell(2, i + 1), ws.Cell(listView.Items.Count + 1, i + 1)));
                }

                // HEADERS
                List<string> headerList = new();
                for (int i = 0; i < listView.Columns.Count; i++)
                {
                    string headerName = listView.Columns[i].Text.Trim().ToUpper();
                    headerList.Add(headerName);

                    rngList[i].Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                    // FORMAT
                    if (headerName == "NOME")
                    {
                        rngList[i].Style.NumberFormat.Format = "@";
                        rngList[i].Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                    }
                    else if (headerName == "CPF")
                    {
                        rngList[i].Style.NumberFormat.Format = "@";
                        excelFunctions.Styles_Colors(rngList[i], 1);
                        rngList[i].Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    }
                    else if (headerName == "CARTAO")
                    {
                        rngList[i].Style.NumberFormat.Format = "@";
                        excelFunctions.Styles_Colors(rngList[i], 5);
                        rngList[i].Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    }
                    else if (headerName == "SALDO")
                    {
                        rngList[i].Style.NumberFormat.Format = "_-* #,##0.00_-;-* #,##0.00_-;_-* \"-\"??_-;_-@_-";
                        excelFunctions.Styles_Colors(rngList[i], 3);
                        rngList[i].Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    }
                    else
                    {
                        rngList[i].Style.NumberFormat.Format = "@";
                        rngList[i].Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    }
                }
                excelFunctions.SetWorksheetHeaders(ws, headerList);

                //BODY
                ws.Cell(2, 1).InsertData(content);

                //FINISHING
                IXLRange usedRange = ws.RangeUsed();
                excelFunctions.SetDottedBorders(usedRange);
                excelFunctions.SetView(ws);
                excelFunctions.SetPrintArea(usedRange);
                ws.Columns().AdjustToContents();

                wb.SaveAs(dirSalvar);
            }
            cl_Alert.Alert("Saldos salvos!", frm_Alert.enmType.Success);
        }



    }
}
