﻿using System.Windows.Documents;
using System.Windows.Media;

namespace PublicLogicaFull.DocumentLogica.FlowDocumentExample.ExamleFlowDocument
{
   public class AddDocument
    {
        public static FlowDocument DocumentSnuOneForm(string example)
        {
            var document = new FlowDocument();
            document.Blocks.Add(new Paragraph(new Run("Образец на выходе!!!")) { TextIndent = 48, FontSize = 20, Foreground = Brushes.Red });
            document.Blocks.Add(new Paragraph(new Run(example) { FontSize = 12 }));
            return document;
        }
    }
}