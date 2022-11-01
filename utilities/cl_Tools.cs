using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace utilities
{
    public static class cl_Tools
    {
        public static string FormatCPF1(string CPFNumber, bool AddZero = false)
        {
            // Format: 00000000000

            string NewCPFNumber = CPFNumber.Trim();
            NewCPFNumber = Regex.Replace(NewCPFNumber, @"[^\d]", "");

            if (AddZero)
            {
                NewCPFNumber = NewCPFNumber.Trim().PadLeft(11, '0');
            }

            if (NewCPFNumber.Length == 11)
            {
                return NewCPFNumber;
            }
            else
            {
                return CPFNumber;
            }
        }

        public static string FormatCPF2(string CPFNumber, bool AddZero = false)
        {
            // Format: 000.000.000-00

            string NewCPFNumber = CPFNumber.Trim();
            NewCPFNumber = Regex.Replace(NewCPFNumber, @"[^\d]", "");

            if (AddZero)
            {
                NewCPFNumber = NewCPFNumber.Trim().PadLeft(11, '0');
            }

            if (NewCPFNumber.Length == 11)
            {
                NewCPFNumber = Regex.Replace(NewCPFNumber, "([0-9][0-9][0-9])([0-9][0-9][0-9])([0-9][0-9][0-9])([0-9][0-9])", "$1.$2.$3-$4");
                return NewCPFNumber;
            }
            else
            {
                return CPFNumber;
            }
        }

        public static string ConvertCentsInReal(string text)
        {
            decimal value = decimal.Parse(text) / 100;
            return value.ToString("N2");
        }

        public static string TreatText(string text, bool trim = true, bool toUpper = true, bool removeAccents = true, bool removeDuplicateSpaces = true)
        {
            if (trim)
                text = text.Trim();
            if (toUpper)
                text = text.ToUpper();
            if (removeAccents)
                text = RemoveAccents(text);
            if (removeDuplicateSpaces)
                text = RemoveDuplicateSpaces(text);
            return text;
        }

        public static string RemoveAccents(string texto)
        {
            StringBuilder sbReturn = new();
            var arrayText = texto.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }

        public static string RemoveDuplicateSpaces(string texto)
        {
            texto = Regex.Replace(texto, @"\s{2,}", " ");
            texto = texto.Trim();

            return texto;
        }

        public static string GetPartOfText()
        {
            string text = "<em>fique ligado! o saldo atual deste cartao e de&nbsp;</em><bdsasdaadsadsasdasdasd>r$&nbsp;sdasdaadss1.234.567,89,56daadsads</sdasdaadssad> - saasdasdsdaasd<small>atualizadsdasdasdasdao em 02/08/2019 as 18h03</small>";
            // get 1.920,57 from text with regex RegexOptions.IgnoreCase
            string pattern = @"(\d{1,3}(\.\d{3})*\,\d{2})";
            Match match = Regex.Match(text, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            return "#N/D";
        }

        public static void AdjustColumnWidthInListView(ListView listView, int width = -2)
        {
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                listView.Columns[i].Width = width;
            }
        }

        public static void AdjustColumnWidthInListView(ListView listView, int[] columns, int width = -2)
        {
            foreach (int column in columns)
            {
                listView.Columns[column].Width = width;
            }
        }
        public static async void EnableButtons(List<Button> buttons, int delay = 3000)
        {
            await Task.Delay(delay);
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }

        public static async void DesableButtons(List<Button> buttons, int delay = 1)
        {
            await Task.Delay(delay);
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }

    }
}
