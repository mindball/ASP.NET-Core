﻿using System;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;

namespace LearningSystem.Services
{
    public class PdfGeneratorService : IPdfGeneratorService
    {
        public byte[] GeneratePdfFromHtml(string html)
        {
            var pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

            var htmlparser = new HtmlWorker(pdfDoc);

            using (var memoryStream = new MemoryStream())
            {
                PdfWriter.GetInstance(pdfDoc, memoryStream);
                pdfDoc.Open();

                using (var stringReader = new StringReader(html))
                {
                    htmlparser.Parse(stringReader);
                }

                pdfDoc.Close();

                return memoryStream.ToArray();
            }
        }
    }
}
