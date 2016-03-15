using iTextSharp.text;
using iTextSharp.text.pdf;
using SistemaDeAmortizacao.Modelo.Modelo;
using System;
using System.Collections.ObjectModel;

namespace SistemaDeAmortizacao.Utilitarios.Tools
{
    public static class PDF
    {
        public static void ExportToPdf(ObservableCollection<Parcela> list, string sistemaDeAmortizacao, string savename)
        {
            if (list == null) throw new InvalidOperationException("Por favor, gere primeiro o empréstimo antes de salva-lo");

            PdfPTable table = new PdfPTable(5);

            table.TotalWidth = 530f;
            table.LockedWidth = true;
            float[] widths = new float[] { 50f, 120, 120, 120, 120f};
            table.SetWidths(widths);
            table.HorizontalAlignment = 0;
            table.SpacingBefore = 20f;
            table.SpacingAfter = 30f;

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new System.IO.FileStream(savename, System.IO.FileMode.Create));

            doc.Open();

            PdfPCell cell = new PdfPCell(new Phrase(sistemaDeAmortizacao));
            cell.Colspan = 5;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.AddCell(cell);

            table.AddCell("");
            table.AddCell("Prestação(R$)");
            table.AddCell("Juros(R$)");
            table.AddCell("Amortização(R$)");
            table.AddCell("Saldo Devedor(R$)");

            table.HeaderRows = 1;

            foreach (var item in list)
            {
                table.AddCell(new Phrase(item.Identificador));
                table.AddCell(new Phrase(item.Prestacao.ToString()));
                table.AddCell(new Phrase(item.Juros.ToString()));
                table.AddCell(new Phrase(item.Amortizacao.ToString()));
                table.AddCell(new Phrase(item.Saldo.ToString()));
            }

            doc.Add(table);
            doc.Close();
        }
    }
}
